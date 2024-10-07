#include <SoftwareSerial.h> // Include Library
#include <Wire.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_HMC5883_U.h>

SoftwareSerial mySerial(10, 11); // Set software UART pin positions - SRX(10), STX(11)
Adafruit_HMC5883_Unified mag = Adafruit_HMC5883_Unified(12345);

String text = ""; // Global variable to store UART data
String HMC5883_all = ""; // All HMC5883 data
String HMC5883_X = ""; // HMC5883 X-axis data
String HMC5883_Y = ""; // HMC5883 Y-axis data
String HMC5883_Z = ""; // HMC5883 Z-axis data
int HMC5883_Xx = 0; // Integer HMC5883 X-axis data
int HMC5883_Yy = 0; // Integer HMC5883 Y-axis data
int HMC5883_Zz = 0; // Integer HMC5883 Z-axis data

boolean gotText = false; // UART flag
int value = 0;
int valueRX = 0;
int RX_DUTY = 0;
int OUT_PWM1 = 0;
String comdata = "";

////////////// HMC5883 Sensor Details Display Function //////////////////
void displaySensorDetails(void) {
    sensor_t sensor;
    mag.getSensor(&sensor);
    Serial.println("------------------------------------");
    Serial.print("Sensor: "); Serial.println(sensor.name);
    Serial.print("Driver Version: "); Serial.println(sensor.version);
    Serial.print("Unique ID: "); Serial.println(sensor.sensor_id);
    Serial.print("Max Value: "); Serial.print(sensor.max_value); Serial.println(" uT");
    Serial.print("Min Value: "); Serial.print(sensor.min_value); Serial.println(" uT");
    Serial.print("Resolution: "); Serial.print(sensor.resolution); Serial.println(" uT");  
    Serial.println("------------------------------------");
    Serial.println("");
    delay(500);
}

void setup() {
    Serial.begin(9600);
    mySerial.begin(9600); // Initialize another UART
    Serial.println("Hello");
    for(int i = 2; i <= 9; i++) { // Set D2-D9 pins on the board to
        pinMode(i, OUTPUT);
    }

    // Initialize HMC5883 sensor
    Serial.println("HMC5883 Magnetometer Test"); Serial.println("");
    if(!mag.begin()) {
        // If the sensor is not detected, check your connections
        Serial.println("Oops, no HMC5883 detected... Check your wiring!");
        while(1);
    }

    // Display sensor details
    displaySensorDetails();
}

void loop() {
    // Handle HMC5883 sensor data
    sensors_event_t event; 
    mag.getEvent(&event);

    HMC5883_X = String(event.magnetic.x * 10); // Convert float to String
    HMC5883_Y = String(event.magnetic.y * 10);
    HMC5883_Z = String(event.magnetic.z * 10);

    HMC5883_Xx = HMC5883_X.toInt();
    HMC5883_Yy = HMC5883_Y.toInt();
    HMC5883_Zz = HMC5883_Z.toInt();

    String HMC5883_XxS = String(HMC5883_Xx);
    String HMC5883_YyS = String(HMC5883_Yy);
    String HMC5883_ZzS = String(HMC5883_Zz);

    Serial.print("X0: "); Serial.print(event.magnetic.x); Serial.print("  ");
    Serial.print("Y0: "); Serial.print(event.magnetic.y); Serial.print("  ");
    Serial.print("Z0: "); Serial.print(event.magnetic.z); Serial.println(" uT");
    Serial.println("///////////////////////////////////////////////////");

    float heading = atan2(event.magnetic.y, event.magnetic.x);
    float declinationAngle = 0.22;
    heading += declinationAngle;

    // Correct heading if it is negative
    if (heading < 0) {
        heading += 2 * PI;
    }

    // Check for wrap around
    if (heading > 2 * PI) {
        heading -= 2 * PI;
    }

    float headingDegrees = heading * 180 / M_PI; // Convert radians to degrees

    // Delay to prevent too rapid serial output
    delay(1000);

    // Handle serial data reception and processing
    while (Serial.available()) {
        gotText = true;
        char tempChar = (char)Serial.read(); // Temporary data
        text += tempChar; // Convert HEX to string
        value = value * 10; // Process individual position of transmitted data
        value += (tempChar - 48);
        delay(1); // Delay time
    }

    if (gotText) { // Flag raised indicating data was received
        gotText = false;
        mySerial.print(text);
        if (value >= 2 && value <= 9) { // Confirm received data is between 2-9
            analogWrite(value, !analogRead(value)); // Set value = inverse value, viewed as a switch
        }
        text = "";
        value = 0;
    }

    /////////////////////////////////////////////////////////////////////////////
    while (mySerial.available()) { // Data transmission over SoftwareSerial
        gotText = true;
        char tempChar = (char)mySerial.read(); // Temporary data
        text += tempChar; // Convert HEX to string
        value = value * 10; // Process individual position of transmitted data
        value += (tempChar - 48);
        delay(5); // Delay time
    }

    if (gotText) { // Flag raised indicating data was received
        int data_length = text.length(); // Data length
        char all_DATA[data_length + 3];
        all_DATA[0] = 'T';
        all_DATA[1] = 'X';
        all_DATA[2] = ';';

        for (int i = 3; i < data_length + 3; i++) { // Transmit data
            all_DATA[i] = text[i - 3];
        }

        for (int j = 0; j < data_length + 3; j++) { // Transmit data
            mySerial.write(all_DATA[j]);
        }

        // Print the length of the data and the data itself
        Serial.print(data_length);
        Serial.println(all_DATA);
        // Control pin positions based on the first character
        valueRX = valueRX * 10; // Process individual position of transmitted data
        valueRX += (text[0] - 48);

        int pwm_num1[3]; // Array to hold PWM values
        for (int ia = 0; ia < 3; ia++) {
            pwm_num1[ia] = (text[ia + 1] - 48); // Convert ASCII to integer
        }

        // Calculate output size
        OUT_PWM1 = pwm_num1[0] * 100 + pwm_num1[1] * 10 + pwm_num1[2] * 1;
        if (valueRX % 2 == 0) {        
          analogWrite(valueRX, OUT_PWM1); // Set PWM output on pin valueRX
          analogWrite(valueRX + 1, 0);
       
        }
        if (valueRX % 2 == 1) {
          analogWrite(valueRX, OUT_PWM1);
          analogWrite(valueRX - 1, 0);
        }
        // Print relevant output values for debugging
        Serial.println(value);
        Serial.println(text[0]);
        Serial.println(pwm_num1[0]);
        Serial.println(pwm_num1[1]);
        Serial.println(pwm_num1[2]);
        Serial.println(OUT_PWM1);
        Serial.println(text);
        
        // Clear text and reset variables
        text = "";
        value = 0;
        valueRX = 0;
        OUT_PWM1 = 0;
        HMC5883_all = ""; // Clear all HMC5883 data
        HMC5883_X = ""; // Clear HMC5883 X data
        HMC5883_Y = ""; // Clear HMC5883 Y data
        HMC5883_Z = ""; // Clear HMC5883 Z data  

        for (int i = 0; i < data_length + 3; i++) {
            all_DATA[i] = 0; // Clear buffer
        }
        gotText = false; // Reset flag
    }
    /////////////////////////////////////////////////////////////////////////////
}
