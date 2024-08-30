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
        // External Class Instances (assuming these are from your previous code)
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

        public Form1()
        {
            InitializeComponent();
            // Refresh COM ports when the form is loaded
            RefreshComPorts();
        }

        // UI Interaction Handlers
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            gup_InputData.Enabled = true;
            gup_MessageDisplay.Enabled = true;
            gup_OutputData.Enabled = true;

            comReader.PortName = comboCOM.Text; // Use the selected port from the combo box
            comReader.BaudRate = 9600;          // Set baud rate
            comReader.Parity = Parity.None;     // Set parity
            comReader.DataBits = 8;             // Set data bits
            comReader.StopBits = StopBits.One;  // Set stop bits
            comReader.Encoding = System.Text.Encoding.Default; // Set encoding

            try
            {
                comReader.Open();             // Open the COM port
                comReader.DiscardInBuffer();  // Clear the input buffer
                comReader.DiscardOutBuffer(); // Clear the output buffer
                txt_ComPortState.Text = "Connection success!";
                btn_Connect.Enabled = false;  // Disable the connect button
            }
            catch (Exception ex)
            {
                txt_ComPortState.Text = "Connection failed! " + ex.Message;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (comReader.IsOpen)
            {
                comReader.Close();  // Close the COM port
            }
            gup_InputData.Enabled = false;
            gup_MessageDisplay.Enabled = false;
            gup_OutputData.Enabled = false;
            btn_Connect.Enabled = true;
            txt_ComPortState.Text = "Port closed.";
            RefreshComPorts(); // Refresh COM ports after closing
        }

        private void btn_ClearOutputData_Click(object sender, EventArgs e)
        {
            txt_MessageOut.Clear();
        }

        private void btn_ClearInputData_Click(object sender, EventArgs e)
        {
            txt_MessageIn.Clear();
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

        private void comReader_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = comReader.ReadExisting();
                // Append the received data to the txt_InputData textbox
                Invoke(new MethodInvoker(delegate {
                    txt_InputData.AppendText(data);
                }));
            }
            catch (Exception ex)
            {
                save_log.Error_log(ex.ToString());
            }
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

                    txt_MessageIn.Text += na + Environment.NewLine;
                    comReader.DiscardInBuffer();
                }
            }
            catch (Exception ex)
            {
                save_log.Error_log(ex.ToString());
            }
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
                XDirection.Text = "Direction";
                YDirection.Text = "Direction";
                ZDirection.Text = "Direction";
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
                btn_RefreshPorts.Text = "刷新";
                btn_TranslateToEnglish.Text = "English";
                btn_ResetChartView.Text = "重置視圖";
                isEnglish = false;
                XDirection.Text = "方向";
                YDirection.Text = "方向";
                ZDirection.Text = "方向";
            }
        }

        private void btn_RefreshPorts_Click(object sender, EventArgs e)
        {
            RefreshComPorts();
        }

        private void RefreshComPorts()
        {
            comboCOM.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                comboCOM.Items.AddRange(ports);
                comboCOM.SelectedIndex = 0;
            }
            else
            {
                comboCOM.Text = "";
                MessageBox.Show("No COM ports available.");
            }

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

        private void btn_ResetChartView_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            chart1.ResetAutoValues();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gup_InputData.Enabled = false;
            gup_MessageDisplay.Enabled = false;
            gup_OutputData.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Event handler for label9 click, implement logic here if needed
        }

        private void gup_MessageDisplay_Enter_1(object sender, EventArgs e)
        {
            // Event handler for gup_MessageDisplay Enter, implement logic here if needed
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for comboBox2 (probably XDirection or another combo box), implement logic here if needed
        }

        // Other methods can be added below as per your application logic requirements.
    }
}
