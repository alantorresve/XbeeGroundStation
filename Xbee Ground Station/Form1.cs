using System;
using System.Windows.Forms;
using System.IO;
using crc8_method;
using Ground_command;
using IEEE754;
using log;
using Downstream;
using System.Threading.Tasks;


namespace Xbee_Ground_Station
{
    public partial class Form1 : Form
    {
        // External Class Instances
        Crc8_met crc8 = new Crc8_met();
        Epscontrol command = new Epscontrol();
        IEEE754Convert iEEE754Convert = new IEEE754Convert();
        Project_log save_log = new Project_log();
        Data_interpretation data_ADSB = new Data_interpretation();

        // State Variables
        private bool isEnglish = false;
        private string save_str;
        private byte[] temp_ComreaderData = new byte[1000];
        private int TurnOnandOff = 0;
        private int cont = 0;

        // UI Related
        private double naX;
        private string temp_str, na;
        private string ICAO, ICAO0001, ICAO0002, ICAO0003, ICAO0004;
        private string ICAOname, ICAO2, ICAOname2, ICAO3, ICAOname3, ICAO4, ICAOname4;
        private string EPSBattertl, EPS33l, EPS5l, VGPSD, VMTQD, VADSBD, VUHFD, TBD, TED, TOD, time, ACX, ACY, ACZ;

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gup_MessageDisplay_Enter_1(object sender, EventArgs e)
        {

        }

        private string SUN_H1, X_TXT, Y_TXT, Z_TXT, YTT, GXX, GYY, GZZ, MX, MY, MZ, GPSN, GPST, GPS1, GPS1N, GPS2, GPS2N;
        StreamWriter writer;

        public Form1()
        {
            InitializeComponent();
            
            // After initialization, refresh the COM ports.
            RefreshComPorts();

            // Set initial UI state
            gup_InputData.Enabled = false;
            gup_MessageDisplay.Enabled = false;
            gup_OutputData.Enabled = false;
            
        }

        // UI Interaction Handlers
        private void btn_GenerateCommand_Click(object sender, EventArgs e)
        {
            string command = "";

            // X-Axis Control
            if (rdo_XForward.Checked)
            {
                command += $"2{num_XPulseValue.Value.ToString("D3")};";
                command += $"3{0.ToString("D3")};";  // Backward pin set to 0
            }
            else if (rdo_XBackward.Checked)
            {
                command += $"3{num_XPulseValue.Value.ToString("D3")};";
                command += $"2{0.ToString("D3")};";  // Forward pin set to 0
            }
            command += $"X{num_XAdditionalParam.Value.ToString("D3")};";

            // Y-Axis Control
            if (rdo_YForward.Checked)
            {
                command += $"4{num_YPulseValue.Value.ToString("D3")};";
                command += $"5{0.ToString("D3")};";  // Backward pin set to 0
            }
            else if (rdo_YBackward.Checked)
            {
                command += $"5{num_YPulseValue.Value.ToString("D3")};";
                command += $"4{0.ToString("D3")};";  // Forward pin set to 0
            }
            command += $"Y{num_YAdditionalParam.Value.ToString("D3")};";

            // Z-Axis Control
            if (rdo_ZForward.Checked)
            {
                command += $"6{num_ZPulseValue.Value.ToString("D3")};";
                command += $"7{0.ToString("D3")};";  // Backward pin set to 0
            }
            else if (rdo_ZBackward.Checked)
            {
                command += $"7{num_ZPulseValue.Value.ToString("D3")};";
                command += $"6{0.ToString("D3")};";  // Forward pin set to 0
            }
            command += $"Z{num_ZAdditionalParam.Value.ToString("D3")};";

            txt_CommandPreview.Text = command;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (comboCOM.Items.Count == 0)
            {
                MessageBox.Show("No COM ports available. Please check your connections and refresh the list.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboCOM.SelectedItem == null)
            {
                MessageBox.Show("Please select a COM port before attempting to connect.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Disable the button to prevent multiple clicks
            btn_Connect.Enabled = false;

            string selectedPort = comboCOM.SelectedItem.ToString();

            // Use Task.Run to perform the connection on a separate thread
            Task.Run(() =>
            {
                try
                {
                    comReader.PortName = selectedPort;
                    comReader.BaudRate = 9600;
                    comReader.Parity = System.IO.Ports.Parity.None;
                    comReader.DataBits = 8;
                    comReader.StopBits = System.IO.Ports.StopBits.One;
                    comReader.Encoding = System.Text.Encoding.Default;

                    comReader.Open();
                    comReader.DiscardInBuffer();
                    comReader.DiscardOutBuffer();

                    // Use Invoke to update the UI from a non-UI thread
                    Invoke(new MethodInvoker(() =>
                    {
                        txt_ComPortState.Text = "Connection success!";
                        btn_Connect.Enabled = false;
                    }));
                }
                catch (Exception ex)
                {
                    // Use Invoke to show the error message on the UI thread
                    Invoke(new MethodInvoker(() =>
                    {
                        txt_ComPortState.Text = "Connection failed! " + ex.Message;
                        btn_Connect.Enabled = true; // Re-enable the button on failure
                    }));
                }
            });
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

        private void btn_ClearOutputData_Click(object sender, EventArgs e)
        {
            txt_MessageOut.Text = "";
        }

        private void btn_ClearInputData_Click(object sender, EventArgs e)
        {
            // Clear relevant input data
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
        private void comReader_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Handle the data received from the serial port here
            // For example, you might want to read the incoming data like this:
            string data = comReader.ReadExisting();

            // Do something with the data, like appending it to a TextBox or processing it
            Invoke(new MethodInvoker(delegate {
                txt_InputData.AppendText(data);
            }));
        }


        private void btn_ResetChartView_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.ResetAutoValues();
            
        }

        private void btn_TranslateToEnglish_Click(object sender, EventArgs e)
        {
            if (!isEnglish)
            {
                // Switch to English
                gup_ComPortState.Text = "COM Port Status";
                Label1.Text = "Select COM Port";
                btn_Connect.Text = "Connect";
                btn_close.Text = "Close";
                gup_OutputData.Text = "Pulse Parameters";
                label26.Text = "Output Pins";
                zaxis.Text = "Parameters: 0~210";
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
                btn_RefreshPorts.Text = "Refresh";
                btn_TranslateToEnglish.Text = "中文";
                btn_ResetChartView.Text = "Reset View";
                isEnglish = true;
            }
            else
            {
                // Switch to Chinese
                gup_ComPortState.Text = "串列埠狀態";
                Label1.Text = "串列埠 選擇";
                btn_Connect.Text = "串列埠連接";
                btn_close.Text = "關閉";
                gup_OutputData.Text = "脈衝參數";
                label26.Text = "輸出腳位";
                zaxis.Text = "參數:0~210";
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
                btn_RefreshPorts.Text = "刷新";
                btn_TranslateToEnglish.Text = "English";
                btn_ResetChartView.Text = "重置視圖";
                isEnglish = false;
            }
        }

        private void btn_RefreshPorts_Click(object sender, EventArgs e)
        {
            RefreshComPorts();
        }

        private void comboCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle COM port selection changes
        }

        private void timer_accept_Tick(object sender, EventArgs e)
        {
            try
            {
                if (comReader.BytesToRead >= 20)
                {
                    int byteLentgh = comReader.BytesToRead;
                    comReader.Read(temp_ComreaderData, 0, 500);

                    string temp_str = "", na = "";
                    for (int i = 0; i < byteLentgh; i++)
                    {
                        if (temp_ComreaderData[i] == 0x01 && temp_ComreaderData[i + 1] == 0x02 && temp_ComreaderData[i + 2] == 0x03 && temp_ComreaderData[i + 3] == 0x04)
                        {
                            // Handle data parsing
                        }

                        temp_str += Convert.ToString(temp_ComreaderData[i], 16) + " ";
                        na += Convert.ToString((Convert.ToChar(temp_ComreaderData[i])));
                    }

                    /*ProcessReceivedData(temp_str, na);*/
                    comReader.DiscardInBuffer();
                }
            }
            catch (Exception ex)
            {
                save_log.Error_log(ex.ToString());
            }
        }

        private void gup_MessageDisplay_Enter(object sender, EventArgs e)
        {
            // Logic for when the Message Display group box is entered (focused)
        }

        private void txt_ComPortState_TextChanged(object sender, EventArgs e)
        {
            // Logic for when the text in the COM Port State TextBox changes
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Implement the logic for label6 click event
        }


        // Utility Functions
        void DataToCsv(string filepath)
        {
            string data_all;
            data_all = save_str;
            data_all = ("DATA" + "," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," + time.ToString());

            StreamWriter stream = new StreamWriter(filepath, true, System.Text.Encoding.UTF8);
            stream.WriteLine(data_all);
            stream.Dispose();
            stream.Close();
        }

        private static string GetText(string t, string k, string j)
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

        // Method to refresh available COM ports
        private void RefreshComPorts()
        {
            if (comboCOM == null || txt_ComPortState == null)
            {
                MessageBox.Show("One or more UI components are not initialized.");
                return;
            }

            this.comboCOM.Items.Clear(); // Clear existing items in the combo box
            string[] ports = System.IO.Ports.SerialPort.GetPortNames(); // Get all available COM ports

            if (ports.Length > 0)
            {
                this.comboCOM.Items.AddRange(ports); // Add the COM ports to the dropdown
                this.comboCOM.SelectedIndex = 0; // Select the first available port by default
            }
            else
            {
                this.comboCOM.Text = ""; // Leave it empty if no ports are found
                MessageBox.Show("No COM ports available.");
            }

            // Display an appropriate message based on the number of ports found
            if (ports.Length == 0)
            {
                txt_ComPortState.Text = "No COM ports found.";
            }
            else if (ports.Length == 1)
            {
                txt_ComPortState.Text = "1 COM port found.";
            }
            else
            {
                txt_ComPortState.Text = $"Found {ports.Length} COM ports.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gup_InputData.Enabled = false;
            gup_MessageDisplay.Enabled = false;
            gup_OutputData.Enabled = false;
        }
    }
}
