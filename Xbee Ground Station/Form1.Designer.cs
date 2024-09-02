namespace Xbee_Ground_Station
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gup_ComPortState = new System.Windows.Forms.GroupBox();
            this.txt_ComPortState = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.comboCOM = new System.Windows.Forms.ComboBox();
            this.gup_OutputData = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_SendData = new System.Windows.Forms.Button();
            this.txt_OutputData = new System.Windows.Forms.TextBox();
            this.gup_InputData = new System.Windows.Forms.GroupBox();
            this.rad_OnOff = new System.Windows.Forms.RadioButton();
            this.btn_ReceiveData = new System.Windows.Forms.Button();
            this.txt_InputData = new System.Windows.Forms.TextBox();
            this.gup_MessageDisplay = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lab_InputData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_ClearInputData = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.txt_MessageIn = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_OutputData = new System.Windows.Forms.Label();
            this.btn_ClearOutputData = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_MessageOut = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comReader = new System.IO.Ports.SerialPort(this.components);
            this.timer_accept = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.gup_ComPortState.SuspendLayout();
            this.gup_OutputData.SuspendLayout();
            this.gup_InputData.SuspendLayout();
            this.gup_MessageDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gup_ComPortState
            // 
            this.gup_ComPortState.Controls.Add(this.txt_ComPortState);
            this.gup_ComPortState.Controls.Add(this.btn_close);
            this.gup_ComPortState.Controls.Add(this.btn_Connect);
            this.gup_ComPortState.Controls.Add(this.Label1);
            this.gup_ComPortState.Controls.Add(this.comboCOM);
            this.gup_ComPortState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gup_ComPortState.Location = new System.Drawing.Point(12, 12);
            this.gup_ComPortState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_ComPortState.Name = "gup_ComPortState";
            this.gup_ComPortState.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_ComPortState.Size = new System.Drawing.Size(236, 114);
            this.gup_ComPortState.TabIndex = 13;
            this.gup_ComPortState.TabStop = false;
            this.gup_ComPortState.Text = "串列阜";
            // 
            // txt_ComPortState
            // 
            this.txt_ComPortState.Location = new System.Drawing.Point(12, 48);
            this.txt_ComPortState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ComPortState.Name = "txt_ComPortState";
            this.txt_ComPortState.Size = new System.Drawing.Size(217, 27);
            this.txt_ComPortState.TabIndex = 3;
            this.txt_ComPortState.TextChanged += new System.EventHandler(this.txt_ComPortState_TextChanged);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(161, 78);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(67, 26);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "關閉";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(12, 78);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(117, 26);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "串列阜連接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 19);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "串列阜 選擇";
            // 
            // comboCOM
            // 
            this.comboCOM.FormattingEnabled = true;
            this.comboCOM.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboCOM.Location = new System.Drawing.Point(179, 18);
            this.comboCOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCOM.Name = "comboCOM";
            this.comboCOM.Size = new System.Drawing.Size(50, 27);
            this.comboCOM.TabIndex = 0;
            this.comboCOM.Text = "4";
            this.comboCOM.SelectedIndexChanged += new System.EventHandler(this.comboCOM_SelectedIndexChanged);
            // 
            // gup_OutputData
            // 
            this.gup_OutputData.Controls.Add(this.label2);
            this.gup_OutputData.Controls.Add(this.textBox1);
            this.gup_OutputData.Controls.Add(this.label26);
            this.gup_OutputData.Controls.Add(this.btn_SendData);
            this.gup_OutputData.Controls.Add(this.txt_OutputData);
            this.gup_OutputData.Font = new System.Drawing.Font("Calibri", 12F);
            this.gup_OutputData.Location = new System.Drawing.Point(12, 238);
            this.gup_OutputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_OutputData.Name = "gup_OutputData";
            this.gup_OutputData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_OutputData.Size = new System.Drawing.Size(236, 126);
            this.gup_OutputData.TabIndex = 14;
            this.gup_OutputData.TabStop = false;
            this.gup_OutputData.Text = "脈波參數";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 104;
            this.label2.Text = "參數:0~210";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 27);
            this.textBox1.TabIndex = 103;
            this.textBox1.Text = "000";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 19);
            this.label26.TabIndex = 102;
            this.label26.Text = "輸出腳位";
            // 
            // btn_SendData
            // 
            this.btn_SendData.Location = new System.Drawing.Point(6, 84);
            this.btn_SendData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SendData.Name = "btn_SendData";
            this.btn_SendData.Size = new System.Drawing.Size(222, 30);
            this.btn_SendData.TabIndex = 1;
            this.btn_SendData.Text = "指令上傳";
            this.btn_SendData.UseVisualStyleBackColor = true;
            this.btn_SendData.Click += new System.EventHandler(this.btn_SendData_Click);
            // 
            // txt_OutputData
            // 
            this.txt_OutputData.Location = new System.Drawing.Point(100, 26);
            this.txt_OutputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_OutputData.Name = "txt_OutputData";
            this.txt_OutputData.Size = new System.Drawing.Size(129, 27);
            this.txt_OutputData.TabIndex = 0;
            this.txt_OutputData.Text = "3";
            this.txt_OutputData.TextChanged += new System.EventHandler(this.txt_OutputData_TextChanged);
            // 
            // gup_InputData
            // 
            this.gup_InputData.Controls.Add(this.rad_OnOff);
            this.gup_InputData.Controls.Add(this.btn_ReceiveData);
            this.gup_InputData.Controls.Add(this.txt_InputData);
            this.gup_InputData.Font = new System.Drawing.Font("Calibri", 12F);
            this.gup_InputData.Location = new System.Drawing.Point(12, 130);
            this.gup_InputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_InputData.Name = "gup_InputData";
            this.gup_InputData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_InputData.Size = new System.Drawing.Size(236, 103);
            this.gup_InputData.TabIndex = 15;
            this.gup_InputData.TabStop = false;
            this.gup_InputData.Text = "接收選單";
            // 
            // rad_OnOff
            // 
            this.rad_OnOff.AutoSize = true;
            this.rad_OnOff.Location = new System.Drawing.Point(28, 71);
            this.rad_OnOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_OnOff.Name = "rad_OnOff";
            this.rad_OnOff.Size = new System.Drawing.Size(14, 13);
            this.rad_OnOff.TabIndex = 2;
            this.rad_OnOff.TabStop = true;
            this.rad_OnOff.UseVisualStyleBackColor = true;
            this.rad_OnOff.CheckedChanged += new System.EventHandler(this.rad_OnOff_CheckedChanged);
            // 
            // btn_ReceiveData
            // 
            this.btn_ReceiveData.Location = new System.Drawing.Point(62, 60);
            this.btn_ReceiveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ReceiveData.Name = "btn_ReceiveData";
            this.btn_ReceiveData.Size = new System.Drawing.Size(168, 36);
            this.btn_ReceiveData.TabIndex = 1;
            this.btn_ReceiveData.Text = "下傳資料接收 開/關";
            this.btn_ReceiveData.UseVisualStyleBackColor = true;
            this.btn_ReceiveData.Click += new System.EventHandler(this.btn_ReceiveData_Click);
            // 
            // txt_InputData
            // 
            this.txt_InputData.Location = new System.Drawing.Point(9, 30);
            this.txt_InputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_InputData.Name = "txt_InputData";
            this.txt_InputData.Size = new System.Drawing.Size(220, 27);
            this.txt_InputData.TabIndex = 0;
            // 
            // gup_MessageDisplay
            // 
            this.gup_MessageDisplay.Controls.Add(this.chart1);
            this.gup_MessageDisplay.Controls.Add(this.textBox6);
            this.gup_MessageDisplay.Controls.Add(this.label7);
            this.gup_MessageDisplay.Controls.Add(this.button3);
            this.gup_MessageDisplay.Controls.Add(this.lab_InputData);
            this.gup_MessageDisplay.Controls.Add(this.label5);
            this.gup_MessageDisplay.Controls.Add(this.label4);
            this.gup_MessageDisplay.Controls.Add(this.label3);
            this.gup_MessageDisplay.Controls.Add(this.textBox5);
            this.gup_MessageDisplay.Controls.Add(this.label16);
            this.gup_MessageDisplay.Controls.Add(this.btn_ClearInputData);
            this.gup_MessageDisplay.Controls.Add(this.textBox20);
            this.gup_MessageDisplay.Controls.Add(this.txt_MessageIn);
            this.gup_MessageDisplay.Controls.Add(this.textBox2);
            this.gup_MessageDisplay.Controls.Add(this.label6);
            this.gup_MessageDisplay.Controls.Add(this.lab_OutputData);
            this.gup_MessageDisplay.Controls.Add(this.btn_ClearOutputData);
            this.gup_MessageDisplay.Controls.Add(this.textBox4);
            this.gup_MessageDisplay.Controls.Add(this.txt_MessageOut);
            this.gup_MessageDisplay.Controls.Add(this.textBox3);
            this.gup_MessageDisplay.Font = new System.Drawing.Font("Calibri", 12F);
            this.gup_MessageDisplay.Location = new System.Drawing.Point(254, 21);
            this.gup_MessageDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_MessageDisplay.Name = "gup_MessageDisplay";
            this.gup_MessageDisplay.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_MessageDisplay.Size = new System.Drawing.Size(725, 545);
            this.gup_MessageDisplay.TabIndex = 16;
            this.gup_MessageDisplay.TabStop = false;
            this.gup_MessageDisplay.Text = "主系統狀態";
            this.gup_MessageDisplay.Enter += new System.EventHandler(this.gup_MessageDisplay_Enter);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(50, 256);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "X(uT)";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Y(uT)";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Z(uT)";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "ALL(uT)";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(668, 250);
            this.chart1.TabIndex = 73;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(496, 178);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(223, 27);
            this.textBox6.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 71;
            this.label7.Text = "ALL(uT)";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(441, 148);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 26);
            this.button3.TabIndex = 64;
            this.button3.Text = "清除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lab_InputData
            // 
            this.lab_InputData.AutoSize = true;
            this.lab_InputData.Location = new System.Drawing.Point(395, 26);
            this.lab_InputData.Name = "lab_InputData";
            this.lab_InputData.Size = new System.Drawing.Size(73, 19);
            this.lab_InputData.TabIndex = 5;
            this.lab_InputData.Text = "接收資料";
            this.lab_InputData.Click += new System.EventHandler(this.lab_InputData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Z(uT)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 69;
            this.label4.Text = "Y(uT)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "X(uT)";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(496, 209);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(222, 37);
            this.textBox5.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 19);
            this.label16.TabIndex = 41;
            this.label16.Text = "時間";
            // 
            // btn_ClearInputData
            // 
            this.btn_ClearInputData.Location = new System.Drawing.Point(474, 24);
            this.btn_ClearInputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ClearInputData.Name = "btn_ClearInputData";
            this.btn_ClearInputData.Size = new System.Drawing.Size(245, 30);
            this.btn_ClearInputData.TabIndex = 4;
            this.btn_ClearInputData.Text = "清除下傳資料";
            this.btn_ClearInputData.UseVisualStyleBackColor = true;
            this.btn_ClearInputData.Click += new System.EventHandler(this.btn_ClearInputData_Click);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(50, 179);
            this.textBox20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(383, 27);
            this.textBox20.TabIndex = 40;
            // 
            // txt_MessageIn
            // 
            this.txt_MessageIn.Location = new System.Drawing.Point(379, 57);
            this.txt_MessageIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MessageIn.Multiline = true;
            this.txt_MessageIn.Name = "txt_MessageIn";
            this.txt_MessageIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MessageIn.Size = new System.Drawing.Size(340, 82);
            this.txt_MessageIn.TabIndex = 3;
            this.txt_MessageIn.TextChanged += new System.EventHandler(this.txt_MessageIn_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 148);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(383, 27);
            this.textBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "資料";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lab_OutputData
            // 
            this.lab_OutputData.AutoSize = true;
            this.lab_OutputData.Location = new System.Drawing.Point(8, 28);
            this.lab_OutputData.Name = "lab_OutputData";
            this.lab_OutputData.Size = new System.Drawing.Size(73, 19);
            this.lab_OutputData.TabIndex = 2;
            this.lab_OutputData.Text = "輸出資料";
            // 
            // btn_ClearOutputData
            // 
            this.btn_ClearOutputData.Location = new System.Drawing.Point(82, 23);
            this.btn_ClearOutputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ClearOutputData.Name = "btn_ClearOutputData";
            this.btn_ClearOutputData.Size = new System.Drawing.Size(291, 30);
            this.btn_ClearOutputData.TabIndex = 1;
            this.btn_ClearOutputData.Text = "清除上傳資料";
            this.btn_ClearOutputData.UseVisualStyleBackColor = true;
            this.btn_ClearOutputData.Click += new System.EventHandler(this.btn_ClearOutputData_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(273, 210);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 37);
            this.textBox4.TabIndex = 66;
            // 
            // txt_MessageOut
            // 
            this.txt_MessageOut.Location = new System.Drawing.Point(9, 57);
            this.txt_MessageOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MessageOut.Multiline = true;
            this.txt_MessageOut.Name = "txt_MessageOut";
            this.txt_MessageOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MessageOut.Size = new System.Drawing.Size(364, 82);
            this.txt_MessageOut.TabIndex = 0;
            this.txt_MessageOut.TextChanged += new System.EventHandler(this.txt_MessageOut_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(50, 210);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(172, 37);
            this.textBox3.TabIndex = 65;
            // 
            // comReader
            // 
            this.comReader.BaudRate = 38400;
            // 
            // timer_accept
            // 
            this.timer_accept.Interval = 500;
            this.timer_accept.Tick += new System.EventHandler(this.timer_accept_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 70;
            this.label8.Text = "000";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = global::Xbee_Ground_Station.Properties.Resources.公司LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(12, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Translate
            // 
            this.btn_Translate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Translate.Location = new System.Drawing.Point(856, 3);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(123, 24);
            this.btn_Translate.TabIndex = 106;
            this.btn_Translate.Text = "English";
            this.btn_Translate.UseVisualStyleBackColor = true;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btn_Translate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gup_MessageDisplay);
            this.Controls.Add(this.gup_OutputData);
            this.Controls.Add(this.gup_ComPortState);
            this.Controls.Add(this.gup_InputData);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Gran Systems";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gup_ComPortState.ResumeLayout(false);
            this.gup_ComPortState.PerformLayout();
            this.gup_OutputData.ResumeLayout(false);
            this.gup_OutputData.PerformLayout();
            this.gup_InputData.ResumeLayout(false);
            this.gup_InputData.PerformLayout();
            this.gup_MessageDisplay.ResumeLayout(false);
            this.gup_MessageDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.GroupBox gup_ComPortState;
        internal System.Windows.Forms.TextBox txt_ComPortState;
        internal System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Button btn_Connect;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox comboCOM;
        internal System.Windows.Forms.GroupBox gup_OutputData;
        internal System.Windows.Forms.Button btn_SendData;
        internal System.Windows.Forms.TextBox txt_OutputData;
        internal System.Windows.Forms.GroupBox gup_InputData;
        internal System.Windows.Forms.Button btn_ReceiveData;
        internal System.Windows.Forms.TextBox txt_InputData;
        internal System.Windows.Forms.GroupBox gup_MessageDisplay;
        internal System.Windows.Forms.Button btn_ClearOutputData;
        internal System.Windows.Forms.TextBox txt_MessageOut;
        internal System.IO.Ports.SerialPort comReader;
        private System.Windows.Forms.Label lab_InputData;
        internal System.Windows.Forms.Button btn_ClearInputData;
        internal System.Windows.Forms.TextBox txt_MessageIn;
        private System.Windows.Forms.Label lab_OutputData;
        private System.Windows.Forms.Timer timer_accept;
        private System.Windows.Forms.RadioButton rad_OnOff;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox20;
        internal System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Translate;
    }
}

