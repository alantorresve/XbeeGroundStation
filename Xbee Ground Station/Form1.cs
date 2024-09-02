using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using crc8_method;
using Ground_command;
using IEEE754;
using log;
using Downstream;


namespace Xbee_Ground_Station
{


    public partial class Form1 : Form
    {

        Crc8_met crc8 = new Crc8_met();
        Epscontrol command = new Epscontrol();
        IEEE754Convert iEEE754Convert = new IEEE754Convert();
        Project_log save_log = new Project_log();
        Data_interpretation data_ADSB = new Data_interpretation();


        string save_str;

        private string allstr = null;
        StreamWriter writer;
        int TurnOnandOff = 0;
        private bool isEnglish=false;



        int uint8_t = 8, cont = 0;
        int uint16_t = 16;
        int uint32_t = 32; string temp_str, na, ICAO, ICAO0001, ICAO0002, ICAO0003, ICAO0004, ICAOname, ICAO2, ICAOname2, ICAO3, ICAOname3, ICAO4, ICAOname4, EPSBattertl, EPS33l, EPS5l, VGPSD, VMTQD, VADSBD, VUHFD, TBD, TED, TOD, time, ACX, ACY, ACZ;
        string SUN_H1;

        string X_TXT, Y_TXT, Z_TXT, YTT;

        private void btn_Translate_Click(object sender, EventArgs e)
        {
            if (!isEnglish)
            {
                // Switch to English
                gup_ComPortState.Text = "COM Port Status";
                Label1.Text = "Select COM Port";
                btn_Connect.Text = "Connect";
                btn_close.Text = "Close";
                gup_OutputData.Text = "Pulse Parameters";
                btn_SendData.Text = "Send Command";
                gup_InputData.Text = "Receive Options";
                btn_ReceiveData.Text = "Start/Stop Receiving";
                gup_MessageDisplay.Text = "Main System Status";
                lab_InputData.Text = "Received Data";
                lab_OutputData.Text = "Output Data";
                btn_ClearOutputData.Text = "Clear Sent Data";
                btn_ClearInputData.Text = "Clear Received Data";
                button3.Text = "Clear";
                label16.Text = "Time";
                label3.Text = "X(uT)";
                label4.Text = "Y(uT)";
                label5.Text = "Z(uT)";
                label6.Text = "Data";
                label7.Text = "ALL(uT)";
                btn_Translate.Text = "中文";
                isEnglish = true;

                /*btn_ResetChartView.Text = "Reset View";
                XDirection.Text = "Direction";
                YDirection.Text = "Direction";
                ZDirection.Text = "Direction";*/
            }
            else
            {
                // Switch to Chinese
                gup_ComPortState.Text = "串列埠狀態";
                Label1.Text = "串列埠 選擇";
                btn_Connect.Text = "串列埠連接";
                btn_close.Text = "關閉";
                gup_OutputData.Text = "脈衝參數";
                btn_SendData.Text = "指令上傳";
                gup_InputData.Text = "接收選單";
                btn_ReceiveData.Text = "下傳資料接收 開/關";
                gup_MessageDisplay.Text = "主系統狀態";
                lab_InputData.Text = "接收資料";
                lab_OutputData.Text = "輸出資料";
                btn_ClearOutputData.Text = "清除上傳資料";
                btn_ClearInputData.Text = "清除下傳資料";
                button3.Text = "清除";
                label16.Text = "時間";
                label3.Text = "X(uT)";
                label4.Text = "Y(uT)";
                label5.Text = "Z(uT)";
                label7.Text = "ALL(uT)";
                btn_Translate.Text = "English";
                isEnglish = false;

                /*btn_RefreshPorts.Text = "刷新";               
                btn_ResetChartView.Text = "重置視圖";                
                XDirection.Text = "方向";
                YDirection.Text = "方向";
                ZDirection.Text = "方向";*/
            }
        }

        string X_HMC, Y_HMC, Z_HMC;

        Double naX;


        private void rad_OnOff_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //chart1.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;//隐藏刻度线
        }

        private void lab_InputData_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_OutputData_TextChanged(object sender, EventArgs e)
        {
            /* int OUTDATA = Convert.ToInt32(txt_OutputData.Text);                ;
             if (OUTDATA >= 9)//txt_OutputData
             {
                 txt_OutputData.Text = "請輸入0~9";
             }*/
        }



        private void button3_Click(object sender, EventArgs e)
        {
            na = "";
            naX = 0;
            ICAO = ""; ICAO2 = ""; ICAO3 = ""; ICAO4 = ""; ICAOname = ""; ICAOname2 = ""; ICAOname3 = ""; //ICAOname4 = "";//EPSBattert = "";
            GPSN = ""; GPST = ""; GPS1 = ""; GPS1N = ""; GPS2 = ""; GPS2N = "";

            //txt_MessageIn.Text = "";

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox20.Text = "";
            txt_MessageOut.Text = "";
            temp_str = "";

        }

        private void txt_MessageIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void gup_MessageDisplay_Enter(object sender, EventArgs e)
        {

        }

        private void txt_ComPortState_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MessageOut_TextChanged(object sender, EventArgs e)
        {

        }

        string GXX, GYY, GZZ, MX, MY, MZ, GPSN, GPST, GPS1, GPS1N, GPS2, GPS2N;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            getCOMPorts();
        }

        byte[] temp_ComreaderData = new byte[1000];//214
        private void getCOMPorts()
        {
            // Get all available COM ports
            string[] ports = SerialPort.GetPortNames();

            // Clear existing items in the ComboBox (if any)
            comboCOM.Items.Clear();

            // Add the COM ports to the ComboBox
            foreach (string port in ports)
            {
                comboCOM.Items.Add(port);
            }

            // Optionally, select the first COM port by default
            if (ports.Length > 0)
            {
                comboCOM.SelectedIndex = 0;
            }
        }
           
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            gup_InputData.Enabled = true;
            gup_MessageDisplay.Enabled = true;
            gup_OutputData.Enabled = true;

            comReader.PortName = comboCOM.Text;                                 //通訊阜號
            comReader.BaudRate = 9600;                                                   //傳輸速率
            comReader.Parity = System.IO.Ports.Parity.None;                              //同位檢查位元
            comReader.DataBits = 8;                                                      //設定每一位元組之資料位元的標準長度
            comReader.StopBits = System.IO.Ports.StopBits.One;                          //物件上使用的停止位元數
            comReader.Encoding = System.Text.Encoding.Default;                           //設定編碼方式



            try
            {

                comReader.Open();                                                          //開啟阜
                comReader.DiscardInBuffer();                                                 //清空接收緩衝區的資料
                comReader.DiscardOutBuffer();                                                //清空傳送緩衝區的資料
                txt_ComPortState.Text = "Connection success!";
                btn_Connect.Enabled = false;


                //Timer_accept.Interval = 500;
            }
            catch (Exception ex)
            {
                txt_ComPortState.Text = "Connection fail!";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            gup_InputData.Enabled = false;
            gup_MessageDisplay.Enabled = false;
            gup_OutputData.Enabled = false;
            timer_accept.Enabled = false;
            btn_Connect.Enabled = true;
            txt_ComPortState.Text = "";
            comReader.Close();
        }

        private void btn_SendData_Click(object sender, EventArgs e)
        {
            //txt_MessageIn.Text = "";

            //byte[] UIDByte = new byte[218]

            int i, J, ASCII_brf = 0;
            byte[] UIDByte = new byte[216];//20//214

            string call, ICAOTX, nu, updata_all;
            call = txt_OutputData.Text + textBox1.Text;
            //ICAOTX = textBox9.Text;
            //nu = textBox34.Text;
            updata_all = call;// + ICAOTX + nu;

            if (txt_OutputData.Text != "")//txt_OutputData
            {
                comReader.DiscardOutBuffer();                     //清空傳送緩衝區的資料
                //UIDByte[0] = Convert.ToByte('$');


                for (i = 0; i < updata_all.Length; i++)
                {
                    UIDByte[i] = Convert.ToByte(Convert.ToChar(updata_all.Substring(i, 1)));
                }

                //comReader.Write(UIDByte, offset, updata_all.Length + 1);
                save_log.Command_log(updata_all);
                txt_MessageOut.Text += DateTime.Now + " >>> " + updata_all + Environment.NewLine;
                //textBox9.Text  += /*DateTime.Now + " ==> " +*/ txt_OutputData.Text + Environment.NewLine;//
                comReader.Write(updata_all);

            }
            //for (i = 0; i < updata_all.Length; i++)
            //{
            //    UIDByte[i] = 0;
            //}

        }

        private void btn_ClearOutputData_Click(object sender, EventArgs e)
        {
            txt_MessageOut.Text = "";
        }

        private void btn_ClearInputData_Click(object sender, EventArgs e)
        {
            //txt_MessageIn.Text = "";
            //txt_MessageIn.Text = "";
            //textBox20.Text = "";
            //na = "";
        }

        private void btn_ReceiveData_Click(object sender, EventArgs e)
        {
            if (TurnOnandOff == 0)
            {
                rad_OnOff.Checked = true;
                timer_accept.Enabled = true;
                timer_accept.Interval = 30;
                TurnOnandOff = 1;

            }
            else
            {
                rad_OnOff.Checked = false;
                timer_accept.Enabled = false;
                TurnOnandOff = 0;
            }
        }
        private void timer_accept_Tick(object sender, EventArgs e)
        {

            int i, k, byteLentgh;
            int X_L, Y_L, Z_L;


            /*
   This code receives data from UART and displays it.
   The code starts by defining a temp_ComreaderData variable and setting it to a new byte array of length 500.
   The code then enters a try-catch block.
   The code then defines a temp_str and a na variable and sets them to an empty string.
   The code then checks if the number of bytes to read is greater than or equal to 20.
   The code then defines a k and a time variable and sets the k variable to 0 and the time variable to the current date and time.
   The code then sets the byteLentgh variable to the number of bytes to read.
   The code then reads 500 bytes to the temp_ComreaderData variable.
   The code then enters a for loop that will run as long as i is less than the byteLentgh variable.
   The code will then check if the current byte in the temp_ComreaderData variable is 0x01 and if the next byte is 0x02 and if the next byte is 0x03 and if the next byte is 0x04.
   If the condition is true, the code will set the k variable to i.
   The code will then add the current byte to the temp_str variable and add the character equivalent of the current byte to the na variable.
   After the for loop, the code will call the NewMethod function and pass in the k variable, which will do something.
   The code will then set the X_TXT variable to the result of the GetText function.
   The code will then set the Y_TXT variable to the result of the GetText function.
   The code will then set the Z_TXT variable to the result of the GetText function.
   The code will then check if the X_TXT variable can be converted to an Int64 variable.
   If the number can be converted, the code will do something.
   If the number cannot be converted, the code will do something else.
   The code will then check if the Y_TXT variable can be converted to an Int64 variable.
   If the number can be converted, the code will do something.
   If the number cannot be converted, the code will do something else.
   The code will then check if the Z_TXT variable can be converted to an Int64 variable.
   If the number can be converted, the code will do something.
   If the number cannot be converted, the code will do something else.
   The code will then define a XYZ_ALL and a XYZ_ALL02 variable and set the XYZ_ALL variable to the square root of the sum of the squares of X23 multiplied by 0.1 and Y23 multiplied by 0.1 and Z23 multiplied by 0.1.
   The code will then set the XYZ_ALL02 variable to the rounded value of XYZ_ALL.
   The code will then set the text of the txt_MessageIn textbox to the value of the temp_str variable.
   The code will then set the text of the textBox20 textbox to the value of the time variable.
   The code will then set the text of the textBox2 textbox to the value of the na variable.
   The code will then set the text of the textBox3 textbox to the value of X23 multiplied by 0.1.
   The code will then set the text of the textBox4 textbox to the value of Y23 multiplied by 0.1.
   The code will then set the text of the textBox5 textbox to the value of Z23 multiplied by 0.1.
   The code will then set the text of the textBox6 textbox to the value of XYZ_ALL02.
   The code will then add a point to the first series in the chart1 chart. The point will have x-value cont and y-value X23 multiplied by 0.1.
   The code will then add a point to the second series in the chart1 chart. The point will have x-value cont and y-value Y23 multiplied by 0.1.
   The code will then add a point to the third series in the chart1 chart. The point will have x-value cont and y-value Z23 multiplied by 0.1.
   The code will then add a point to the fourth series in the chart1 chart. The point will have x-value cont and y-value XYZ_ALL02.
   The code will then increment cont by 2.
   The code will then check if cont is greater than or equal to 600.
   If the condition is true, the code will set cont to 0, clear all the the points in the 4 series in the chart1 chart and add 4 points to the chart.
   The code will then set the text of the label8 label to the value of cont.
   The code will then set the temp_ComreaderData variable to a new byte array of length 500.
   The code will then discard the data in the comReader buffer.
   The code will then call the DataToCsv function and pass in "OBC.csv".
   The code will then call the DataToCsv function and pass in "ADSB01.csv".
   */
            temp_ComreaderData = new byte[500];
            try
            {
                temp_str = "";
                na = "";

                if (comReader.BytesToRead >= 20)//214  //216
                {

                    k = 0;
                    time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    byteLentgh = comReader.BytesToRead;
                    comReader.Read(temp_ComreaderData, 0, 500);//214
                    for (i = 0; i < byteLentgh; i++)//214
                    {
                        if (temp_ComreaderData[i] == 0x01 && temp_ComreaderData[i + 1] == 0x02 && temp_ComreaderData[i + 2] == 0x03 && temp_ComreaderData[i + 3] == 0x04)
                        {
                            k = i;
                        }

                        temp_str += Convert.ToString(temp_ComreaderData[i], 16) + " ";
                        na += Convert.ToString((Convert.ToChar(temp_ComreaderData[i])));
                    }
                    NewMethod(k);

                    X_TXT = GetText(na, "X", "Y");
                    Y_TXT = GetText(na, "Y", "Z");
                    Z_TXT = GetText(na, "Z", "M");

                    if (Int64.TryParse(X_TXT, out Int64 X23))
                    {
                        //textBox6.Text = X23.ToString();
                        Console.WriteLine(X23);
                    }
                    else
                    {
                        textBox6.Text = ("String could not be parsed.");
                        Console.WriteLine("String could not be parsed.");
                    }

                    if (Int64.TryParse(Y_TXT, out Int64 Y23))
                    {
                        //textBox6.Text = Y23.ToString();
                        Console.WriteLine(Y23);
                    }
                    else
                    {
                        textBox6.Text = ("String could not be parsed.");
                        Console.WriteLine("String could not be parsed.");
                    }

                    if (Int64.TryParse(Z_TXT, out Int64 Z23))
                    {
                        //textBox6.Text = Z23.ToString();
                        Console.WriteLine(Z23);
                    }
                    else
                    {
                        textBox6.Text = ("String could not be parsed.");
                        Console.WriteLine("String could not be parsed.");
                    }

                    double XYZ_ALL, XYZ_ALL02;
                    XYZ_ALL = Math.Sqrt(Math.Pow(X23 * 0.1, 2) + Math.Pow(Y23 * 0.1, 2) + Math.Pow(Z23 * 0.1, 2));//((X^2+Y^2+Z^2)^2)^1/2開跟號
                    XYZ_ALL02 = Math.Round(XYZ_ALL, 2);

                    //textBox6.Text = XYZ_ALL.ToString();
                    // Output: -105

                    //Int64 numVal = Int32.Parse(X_TXT);

                    /*
                    int numValX = -1;
                    numValX = Convert.ToInt32(X_TXT);
                    textBox6.Text = (numValX+1).ToString();
                    */

                    //////////////////******************************
                    ////******************************************

                    txt_MessageIn.Text = temp_str.ToString();

                    textBox20.Text = time.ToString();
                    textBox2.Text = na;
                    textBox3.Text = (X23 * 0.1).ToString();
                    textBox4.Text = (Y23 * 0.1).ToString();
                    textBox5.Text = (Z23 * 0.1).ToString();
                    textBox6.Text = XYZ_ALL02.ToString();
                    //textBox7.Text = XYZ_ALL.ToString();
                    save_log.Receive_log(txt_MessageIn.Text);
                    //chart1.ChartAreas[0].AxisX.LineWidth = 20;
                    chart1.Series[0].Points.AddXY(cont, X23 * 0.1);
                    chart1.Series[1].Points.AddXY(cont, Y23 * 0.1);
                    chart1.Series[2].Points.AddXY(cont, Z23 * 0.1);
                    chart1.Series[3].Points.AddXY(cont, XYZ_ALL02);


                    cont = cont + 2;

                    if (cont >= 600)
                    {
                        cont = 0;
                        //chart1.Series.Clear();
                        chart1.Series[0].Points.Clear(); //或是這個 or this
                        chart1.Series[1].Points.Clear(); //或是這個 or this
                        chart1.Series[2].Points.Clear(); //或是這個
                        chart1.Series[3].Points.Clear(); //或是這個
                        chart1.Series[0].Points.AddXY(cont, X23 * 0.1);
                        chart1.Series[1].Points.AddXY(cont, Y23 * 0.1);
                        chart1.Series[2].Points.AddXY(cont, Z23 * 0.1);
                        chart1.Series[3].Points.AddXY(cont, XYZ_ALL02);
                        //chart1.Series[0].Points.AddXY(0, 0);
                    }



                    label8.Text = (cont).ToString();
                    //temp_str = "";

                    ICAO = ""; ICAO2 = ""; ICAO3 = ""; ICAO4 = ""; ICAOname = ""; ICAOname2 = ""; ICAOname3 = ""; //ICAOname4 = "";//EPSBattert = "";
                    GPSN = ""; GPST = ""; GPS1 = ""; GPS1N = ""; GPS2 = ""; GPS2N = "";
                    ICAO0004 = ""; ICAO0003 = ""; ICAO0002 = ""; ICAO0001 = "";
                    //txt_MessageIn.Text = "";
                    //textBox20.Text = "";
                    na = "";


                    DataToCsv("OBC.csv");
                    //DataToCsv2("ADSB01.csv");

                    temp_ComreaderData = new byte[500];
                    comReader.DiscardInBuffer();//讀完UART資料 清除資料

                    //comReader.InBufferCount = 0;




                }
            }
            catch (Exception ex)
            {
                save_log.Error_log(ex.ToString());
            }

        }

        private void NewMethod(int i)
        {

            int uint8_t = 8 / 8;
            int uint16_t = 16 / 8;
            int uint32_t = 32 / 8;
            const byte ASC = 0;
            const byte eps = 1;
            const byte ICAO = 2;
            const byte gyro = 3;
            const byte acc = 4;
            const byte MT = 5;
            const byte OBC_T = 6;
            int Calc__buffer = 0;
            TextBox[] show_table = new TextBox[] {  textBox2 ,

            };
            int[] show_num_table = new int[] { 0, 1, 14, 27, 11, 24, 37, 44, 45, 46, 47, 51, 52, 53, 54, 49, 66, 63, 64, 65, 60, 61, 62, 67, 68, 69 };

            int[] show_method_table = new int[] { ASC , ICAO , ICAO , ICAO , ASC , ASC , ASC , eps , eps , eps , eps , eps , eps , eps , eps , eps , OBC_T,
                                                gyro , gyro , gyro , acc , acc , acc , MT ,MT ,MT};

            int[] type_table = new int[] { uint8_t*4,uint8_t*6, uint32_t, uint32_t, uint32_t , uint32_t , uint16_t , uint16_t , uint16_t , uint16_t, uint16_t, uint8_t , uint8_t * 9, uint8_t , uint8_t,
                                           uint32_t, uint32_t, uint32_t , uint32_t , uint16_t , uint16_t , uint16_t , uint16_t, uint16_t, uint8_t , uint8_t * 9, uint8_t , uint8_t,
                                           uint32_t, uint32_t, uint32_t , uint32_t , uint16_t , uint16_t , uint16_t , uint16_t, uint16_t, uint8_t , uint8_t * 9, uint8_t , uint8_t,
                                           uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,
                                           uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,
                                           uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t,uint16_t};

            int[] dtat_table = new int[78];

            dtat_table[0] = type_table[0];
            for (int data_table_loop = 1; data_table_loop < dtat_table.Length; data_table_loop++)
            {
                if (data_table_loop < type_table.Length)
                {
                    dtat_table[data_table_loop] = dtat_table[data_table_loop - 1] + type_table[data_table_loop];
                }
                else
                {
                    dtat_table[data_table_loop] = dtat_table[data_table_loop - 1] + 16;
                }
            }

            int[,] dtat_buffer = new int[dtat_table.Length, 9];
            for (int data_loop = 0; data_loop < dtat_table.Length; data_loop++)
            {
                for (int data_loop2 = 0; data_loop2 < type_table[data_loop + 1]; data_loop2++)
                {
                    dtat_buffer[data_loop, data_loop2] = temp_ComreaderData[i + dtat_table[data_loop] + data_loop2];
                }
            }
            data_ADSB.ICAO_save(dtat_buffer);
            save_str = "OBC,";
            for (int show_loop = 0; show_loop < show_table.Length; show_loop++)
            {
                Calc__buffer = 0;
                show_table[show_loop].Text = "";
                for (int show_loop2 = 0; show_loop2 < type_table[show_num_table[show_loop] + 1]; show_loop2++)
                {
                    switch (show_method_table[show_loop])
                    {
                        case ASC:

                            show_table[show_loop].Text += Convert.ToChar(dtat_buffer[show_num_table[show_loop], show_loop2]);
                            break;

                        case eps:

                            Calc__buffer += dtat_buffer[show_num_table[show_loop], show_loop2] << 8 * (1 - show_loop2);
                            if (show_loop2 == 1)
                            {
                                show_loop2 = 8;
                                show_table[show_loop].Text = Convert.ToString(Calc__buffer * 0.01);
                            }
                            break;

                        case ICAO:

                            show_table[show_loop].Text += Convert.ToString(dtat_buffer[show_num_table[show_loop], 3 - show_loop2], 16);
                            break;

                        case gyro:

                            Calc__buffer += dtat_buffer[show_num_table[show_loop], show_loop2] << 8 * (1 - show_loop2);

                            if (show_loop2 == 1)
                            {
                                if ((Calc__buffer & 0x8000) > 1)
                                {
                                    Calc__buffer = (~(Calc__buffer - 1)) & 0xFFFF;
                                    Calc__buffer = -Calc__buffer;
                                }
                                show_loop2 = 8;
                                show_table[show_loop].Text = Convert.ToString(Calc__buffer * 0.007633587786);
                            }
                            break;

                        case acc:

                            Calc__buffer += dtat_buffer[show_num_table[show_loop], show_loop2] << 8 * (1 - show_loop2);
                            if (show_loop2 == 1)
                            {
                                if ((Calc__buffer & 0x8000) > 1)
                                {
                                    Calc__buffer = (~(Calc__buffer - 1)) & 0xFFFF;
                                    Calc__buffer = -Calc__buffer;
                                }
                                show_loop2 = 8;
                                show_table[show_loop].Text = Convert.ToString(Calc__buffer * 0.000061035156);
                            }
                            break;
                        case MT:

                            Calc__buffer += dtat_buffer[show_num_table[show_loop], show_loop2] << 8 * (1 - show_loop2);
                            if (show_loop2 == 1)
                            {
                                if ((Calc__buffer & 0x8000) > 1)
                                {
                                    Calc__buffer = (~(Calc__buffer - 1)) & 0xFFFF;
                                    Calc__buffer = -Calc__buffer;
                                }
                                show_loop2 = 8;
                                show_table[show_loop].Text = Convert.ToString(Calc__buffer * 0.00001);
                            }
                            break;

                        case OBC_T:

                            Calc__buffer += dtat_buffer[show_num_table[show_loop], show_loop2] << 8 * (1 - show_loop2);
                            if (show_loop2 == 1)
                            {
                                if ((Calc__buffer & 0x8000) > 1)
                                {
                                    Calc__buffer = (~(Calc__buffer - 1)) & 0xFFFF;
                                    Calc__buffer = -Calc__buffer;
                                }
                                show_loop2 = 8;
                                show_table[show_loop].Text = Convert.ToString(Calc__buffer / 400.0 + 18.5);
                            }
                            break;
                    }
                    //save_str += show_table[show_loop].Text + ",";
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gup_InputData.Enabled = false;
            gup_MessageDisplay.Enabled = false;
            gup_OutputData.Enabled = false;
        }

        private void comboCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /************************************************/
        void DataToCsv(string filepath)
        {
            /*
            textBox3.Text = (X23 * 0.1).ToString();
            textBox4.Text = (Y23 * 0.1).ToString();
            textBox5.Text = (Z23 * 0.1).ToString();
            textBox6.Text = XYZ_ALL.ToString();
            */

            string data_all;
            data_all = save_str;
            data_all = ("DATA" + "," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + ","
            + time.ToString());


            string Data = null;
            StreamWriter stream = new StreamWriter(filepath, true, System.Text.Encoding.UTF8);

            stream.WriteLine(data_all);
            stream.Dispose();
            stream.Close();

        }

        private static string GetText(string t, string k, string j) //擷取指定文字，和易語言的取文字中間差不多 Extract the specified text, which is similar to the middle of the text in Easy Language
        {
            try
            {

                var kn = t.IndexOf(k, StringComparison.Ordinal) + k.Length;
                var jn = t.IndexOf(j, kn, StringComparison.Ordinal);
                return t.Substring(kn, jn - kn);
            }
            catch
            {
                return "發現異常錯誤！Unusual error found!";
            }
        }




    }
}