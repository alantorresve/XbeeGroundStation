namespace Xbee_Ground_Station
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Dispose of any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            this.btn_RefreshPorts = new System.Windows.Forms.Button();
            this.txt_ComPortState = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.comboCOM = new System.Windows.Forms.ComboBox();
            this.gup_InputData = new System.Windows.Forms.GroupBox();
            this.rad_OnOff = new System.Windows.Forms.RadioButton();
            this.btn_ReceiveData = new System.Windows.Forms.Button();
            this.txt_InputData = new System.Windows.Forms.TextBox();
            this.gup_MessageDisplay = new System.Windows.Forms.GroupBox();
            this.btn_ResetChartView = new System.Windows.Forms.Button();
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
            this.btn_TranslateToEnglish = new System.Windows.Forms.Button();
            this.comReader = new System.IO.Ports.SerialPort(this.components);
            this.timer_accept = new System.Windows.Forms.Timer(this.components);
            this.btn_SendData = new System.Windows.Forms.Button();
            this.gup_OutputData = new System.Windows.Forms.GroupBox();
            this.ZDirection = new System.Windows.Forms.ComboBox();
            this.YDirection = new System.Windows.Forms.ComboBox();
            this.yaxis = new System.Windows.Forms.Label();
            this.zaxis = new System.Windows.Forms.Label();
            this.XDirection = new System.Windows.Forms.ComboBox();
            this.Xaxis = new System.Windows.Forms.Label();
            this.zparamtextbox = new System.Windows.Forms.TextBox();
            this.yparamtextbox = new System.Windows.Forms.TextBox();
            this.xparamtextbox = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.gup_ComPortState.SuspendLayout();
            this.gup_InputData.SuspendLayout();
            this.gup_MessageDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gup_OutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gup_ComPortState
            // 
            this.gup_ComPortState.Controls.Add(this.btn_RefreshPorts);
            this.gup_ComPortState.Controls.Add(this.txt_ComPortState);
            this.gup_ComPortState.Controls.Add(this.btn_close);
            this.gup_ComPortState.Controls.Add(this.btn_Connect);
            this.gup_ComPortState.Controls.Add(this.Label1);
            this.gup_ComPortState.Controls.Add(this.comboCOM);
            this.gup_ComPortState.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gup_ComPortState.Location = new System.Drawing.Point(7, 11);
            this.gup_ComPortState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_ComPortState.Name = "gup_ComPortState";
            this.gup_ComPortState.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_ComPortState.Size = new System.Drawing.Size(236, 143);
            this.gup_ComPortState.TabIndex = 13;
            this.gup_ComPortState.TabStop = false;
            this.gup_ComPortState.Text = "串列阜";
            // 
            // btn_RefreshPorts
            // 
            this.btn_RefreshPorts.AutoSize = true;
            this.btn_RefreshPorts.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshPorts.Location = new System.Drawing.Point(161, 108);
            this.btn_RefreshPorts.Name = "btn_RefreshPorts";
            this.btn_RefreshPorts.Size = new System.Drawing.Size(67, 30);
            this.btn_RefreshPorts.TabIndex = 4;
            this.btn_RefreshPorts.Text = "刷新";
            this.btn_RefreshPorts.UseVisualStyleBackColor = true;
            // 
            // txt_ComPortState
            // 
            this.txt_ComPortState.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ComPortState.Location = new System.Drawing.Point(12, 48);
            this.txt_ComPortState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ComPortState.Name = "txt_ComPortState";
            this.txt_ComPortState.ReadOnly = true;
            this.txt_ComPortState.Size = new System.Drawing.Size(217, 27);
            this.txt_ComPortState.TabIndex = 3;
            this.txt_ComPortState.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(161, 78);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(67, 26);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "關閉";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Location = new System.Drawing.Point(12, 78);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(117, 26);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "串列阜連接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(8, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "串列阜 選擇";
            // 
            // comboCOM
            // 
            this.comboCOM.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCOM.FormattingEnabled = true;
            this.comboCOM.Location = new System.Drawing.Point(161, 18);
            this.comboCOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCOM.Name = "comboCOM";
            this.comboCOM.Size = new System.Drawing.Size(68, 28);
            this.comboCOM.TabIndex = 0;
            // 
            // gup_InputData
            // 
            this.gup_InputData.Controls.Add(this.rad_OnOff);
            this.gup_InputData.Controls.Add(this.btn_ReceiveData);
            this.gup_InputData.Controls.Add(this.txt_InputData);
            this.gup_InputData.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gup_InputData.Location = new System.Drawing.Point(7, 158);
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
            this.rad_OnOff.Location = new System.Drawing.Point(28, 70);
            this.rad_OnOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_OnOff.Name = "rad_OnOff";
            this.rad_OnOff.Size = new System.Drawing.Size(14, 13);
            this.rad_OnOff.TabIndex = 2;
            this.rad_OnOff.TabStop = true;
            this.rad_OnOff.UseVisualStyleBackColor = true;
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
            // 
            // txt_InputData
            // 
            this.txt_InputData.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InputData.Location = new System.Drawing.Point(9, 30);
            this.txt_InputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_InputData.Name = "txt_InputData";
            this.txt_InputData.Size = new System.Drawing.Size(220, 27);
            this.txt_InputData.TabIndex = 0;
            // 
            // gup_MessageDisplay
            // 
            this.gup_MessageDisplay.AutoSize = true;
            this.gup_MessageDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gup_MessageDisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gup_MessageDisplay.Controls.Add(this.btn_ResetChartView);
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
            this.gup_MessageDisplay.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gup_MessageDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gup_MessageDisplay.Location = new System.Drawing.Point(254, 30);
            this.gup_MessageDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_MessageDisplay.Name = "gup_MessageDisplay";
            this.gup_MessageDisplay.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_MessageDisplay.Size = new System.Drawing.Size(725, 544);
            this.gup_MessageDisplay.TabIndex = 16;
            this.gup_MessageDisplay.TabStop = false;
            this.gup_MessageDisplay.Text = "主系統狀態";
            this.gup_MessageDisplay.Enter += new System.EventHandler(this.gup_MessageDisplay_Enter_1);
            // 
            // btn_ResetChartView
            // 
            this.btn_ResetChartView.AutoSize = true;
            this.btn_ResetChartView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ResetChartView.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetChartView.Location = new System.Drawing.Point(617, 352);
            this.btn_ResetChartView.Name = "btn_ResetChartView";
            this.btn_ResetChartView.Size = new System.Drawing.Size(79, 30);
            this.btn_ResetChartView.TabIndex = 76;
            this.btn_ResetChartView.Text = "重置視圖";
            this.btn_ResetChartView.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(50, 269);
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
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(496, 178);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(223, 27);
            this.textBox6.TabIndex = 72;
            this.textBox6.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "ALL(uT)";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(441, 148);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 26);
            this.button3.TabIndex = 64;
            this.button3.Text = "清除";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lab_InputData
            // 
            this.lab_InputData.AutoSize = true;
            this.lab_InputData.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_InputData.Location = new System.Drawing.Point(395, 25);
            this.lab_InputData.Name = "lab_InputData";
            this.lab_InputData.Size = new System.Drawing.Size(69, 20);
            this.lab_InputData.TabIndex = 5;
            this.lab_InputData.Text = "接收資料";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Z(uT)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Y(uT)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "X(uT)";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(496, 209);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(222, 27);
            this.textBox5.TabIndex = 67;
            this.textBox5.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 20);
            this.label16.TabIndex = 41;
            this.label16.Text = "時間";
            // 
            // btn_ClearInputData
            // 
            this.btn_ClearInputData.AutoSize = true;
            this.btn_ClearInputData.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearInputData.Location = new System.Drawing.Point(530, 23);
            this.btn_ClearInputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ClearInputData.Name = "btn_ClearInputData";
            this.btn_ClearInputData.Size = new System.Drawing.Size(189, 30);
            this.btn_ClearInputData.TabIndex = 4;
            this.btn_ClearInputData.Text = "清除下傳資料";
            this.btn_ClearInputData.UseVisualStyleBackColor = true;
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(50, 179);
            this.textBox20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(383, 27);
            this.textBox20.TabIndex = 40;
            this.textBox20.TabStop = false;
            // 
            // txt_MessageIn
            // 
            this.txt_MessageIn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MessageIn.Location = new System.Drawing.Point(379, 57);
            this.txt_MessageIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MessageIn.Multiline = true;
            this.txt_MessageIn.Name = "txt_MessageIn";
            this.txt_MessageIn.ReadOnly = true;
            this.txt_MessageIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MessageIn.Size = new System.Drawing.Size(340, 82);
            this.txt_MessageIn.TabIndex = 3;
            this.txt_MessageIn.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(50, 148);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(383, 27);
            this.textBox2.TabIndex = 7;
            this.textBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "資料";
            // 
            // lab_OutputData
            // 
            this.lab_OutputData.AutoSize = true;
            this.lab_OutputData.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_OutputData.Location = new System.Drawing.Point(8, 27);
            this.lab_OutputData.Name = "lab_OutputData";
            this.lab_OutputData.Size = new System.Drawing.Size(69, 20);
            this.lab_OutputData.TabIndex = 2;
            this.lab_OutputData.Text = "輸出資料";
            // 
            // btn_ClearOutputData
            // 
            this.btn_ClearOutputData.AutoSize = true;
            this.btn_ClearOutputData.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearOutputData.Location = new System.Drawing.Point(171, 22);
            this.btn_ClearOutputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ClearOutputData.Name = "btn_ClearOutputData";
            this.btn_ClearOutputData.Size = new System.Drawing.Size(202, 30);
            this.btn_ClearOutputData.TabIndex = 1;
            this.btn_ClearOutputData.Text = "清除上傳資料";
            this.btn_ClearOutputData.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(273, 210);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(160, 27);
            this.textBox4.TabIndex = 66;
            this.textBox4.TabStop = false;
            // 
            // txt_MessageOut
            // 
            this.txt_MessageOut.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MessageOut.Location = new System.Drawing.Point(9, 57);
            this.txt_MessageOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MessageOut.Multiline = true;
            this.txt_MessageOut.Name = "txt_MessageOut";
            this.txt_MessageOut.ReadOnly = true;
            this.txt_MessageOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MessageOut.Size = new System.Drawing.Size(364, 82);
            this.txt_MessageOut.TabIndex = 0;
            this.txt_MessageOut.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(50, 210);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(172, 27);
            this.textBox3.TabIndex = 65;
            this.textBox3.TabStop = false;
            // 
            // btn_TranslateToEnglish
            // 
            this.btn_TranslateToEnglish.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TranslateToEnglish.Location = new System.Drawing.Point(894, 11);
            this.btn_TranslateToEnglish.Name = "btn_TranslateToEnglish";
            this.btn_TranslateToEnglish.Size = new System.Drawing.Size(79, 30);
            this.btn_TranslateToEnglish.TabIndex = 0;
            this.btn_TranslateToEnglish.Text = "English";
            this.btn_TranslateToEnglish.UseVisualStyleBackColor = true;
            this.btn_TranslateToEnglish.Click += new System.EventHandler(this.btn_TranslateToEnglish_Click);
            // 
            // comReader
            // 
            this.comReader.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.comReader_DataReceived);
            // 
            // timer_accept
            // 
            this.timer_accept.Interval = 500;
            this.timer_accept.Tick += new System.EventHandler(this.timer_accept_Tick);
            // 
            // btn_SendData
            // 
            this.btn_SendData.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendData.Location = new System.Drawing.Point(7, 124);
            this.btn_SendData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SendData.Name = "btn_SendData";
            this.btn_SendData.Size = new System.Drawing.Size(222, 30);
            this.btn_SendData.TabIndex = 1;
            this.btn_SendData.Text = "指令上傳";
            this.btn_SendData.UseVisualStyleBackColor = true;
            // 
            // gup_OutputData
            // 
            this.gup_OutputData.Controls.Add(this.ZDirection);
            this.gup_OutputData.Controls.Add(this.YDirection);
            this.gup_OutputData.Controls.Add(this.yaxis);
            this.gup_OutputData.Controls.Add(this.zaxis);
            this.gup_OutputData.Controls.Add(this.XDirection);
            this.gup_OutputData.Controls.Add(this.Xaxis);
            this.gup_OutputData.Controls.Add(this.zparamtextbox);
            this.gup_OutputData.Controls.Add(this.yparamtextbox);
            this.gup_OutputData.Controls.Add(this.xparamtextbox);
            this.gup_OutputData.Controls.Add(this.btn_SendData);
            this.gup_OutputData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gup_OutputData.Location = new System.Drawing.Point(7, 265);
            this.gup_OutputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_OutputData.Name = "gup_OutputData";
            this.gup_OutputData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_OutputData.Size = new System.Drawing.Size(236, 186);
            this.gup_OutputData.TabIndex = 14;
            this.gup_OutputData.TabStop = false;
            this.gup_OutputData.Text = "脈波參數";
            // 
            // ZDirection
            // 
            this.ZDirection.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZDirection.FormattingEnabled = true;
            this.ZDirection.Items.AddRange(new object[] {
            "Forward",
            "Backward"});
            this.ZDirection.Location = new System.Drawing.Point(117, 92);
            this.ZDirection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ZDirection.MaxDropDownItems = 2;
            this.ZDirection.Name = "ZDirection";
            this.ZDirection.Size = new System.Drawing.Size(99, 28);
            this.ZDirection.TabIndex = 118;
            this.ZDirection.Text = "Direction";
            // 
            // YDirection
            // 
            this.YDirection.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YDirection.FormattingEnabled = true;
            this.YDirection.Items.AddRange(new object[] {
            "Forward",
            "Backward"});
            this.YDirection.Location = new System.Drawing.Point(117, 61);
            this.YDirection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YDirection.MaxDropDownItems = 2;
            this.YDirection.Name = "YDirection";
            this.YDirection.Size = new System.Drawing.Size(99, 28);
            this.YDirection.TabIndex = 117;
            this.YDirection.Text = "Direction";
            // 
            // yaxis
            // 
            this.yaxis.AutoSize = true;
            this.yaxis.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yaxis.Location = new System.Drawing.Point(56, 61);
            this.yaxis.Name = "yaxis";
            this.yaxis.Size = new System.Drawing.Size(54, 20);
            this.yaxis.TabIndex = 116;
            this.yaxis.Text = "Y-Axis";
            this.yaxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yaxis.Click += new System.EventHandler(this.label9_Click);
            // 
            // zaxis
            // 
            this.zaxis.AutoSize = true;
            this.zaxis.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaxis.Location = new System.Drawing.Point(56, 93);
            this.zaxis.Name = "zaxis";
            this.zaxis.Size = new System.Drawing.Size(54, 20);
            this.zaxis.TabIndex = 115;
            this.zaxis.Text = "Z-Axis";
            this.zaxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XDirection
            // 
            this.XDirection.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XDirection.FormattingEnabled = true;
            this.XDirection.Items.AddRange(new object[] {
            "Forward",
            "Backward"});
            this.XDirection.Location = new System.Drawing.Point(117, 29);
            this.XDirection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XDirection.MaxDropDownItems = 2;
            this.XDirection.Name = "XDirection";
            this.XDirection.Size = new System.Drawing.Size(99, 28);
            this.XDirection.TabIndex = 114;
            this.XDirection.Text = "Direction";
            this.XDirection.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Xaxis
            // 
            this.Xaxis.AutoSize = true;
            this.Xaxis.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xaxis.Location = new System.Drawing.Point(56, 32);
            this.Xaxis.Name = "Xaxis";
            this.Xaxis.Size = new System.Drawing.Size(55, 20);
            this.Xaxis.TabIndex = 113;
            this.Xaxis.Text = "X-Axis";
            this.Xaxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zparamtextbox
            // 
            this.zparamtextbox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zparamtextbox.Location = new System.Drawing.Point(12, 90);
            this.zparamtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zparamtextbox.Name = "zparamtextbox";
            this.zparamtextbox.Size = new System.Drawing.Size(38, 27);
            this.zparamtextbox.TabIndex = 112;
            this.zparamtextbox.Text = "0";
            this.zparamtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yparamtextbox
            // 
            this.yparamtextbox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yparamtextbox.Location = new System.Drawing.Point(12, 58);
            this.yparamtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yparamtextbox.Name = "yparamtextbox";
            this.yparamtextbox.Size = new System.Drawing.Size(38, 27);
            this.yparamtextbox.TabIndex = 111;
            this.yparamtextbox.Text = "0";
            this.yparamtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xparamtextbox
            // 
            this.xparamtextbox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xparamtextbox.Location = new System.Drawing.Point(12, 26);
            this.xparamtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xparamtextbox.Name = "xparamtextbox";
            this.xparamtextbox.Size = new System.Drawing.Size(38, 27);
            this.xparamtextbox.TabIndex = 110;
            this.xparamtextbox.Text = "0";
            this.xparamtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Logo
            // 
            this.Logo.Image = global::Xbee_Ground_Station.Properties.Resources.公司LOGO;
            this.Logo.Location = new System.Drawing.Point(7, 427);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(231, 147);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 17;
            this.Logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 582);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.btn_TranslateToEnglish);
            this.Controls.Add(this.gup_ComPortState);
            this.Controls.Add(this.gup_OutputData);
            this.Controls.Add(this.gup_InputData);
            this.Controls.Add(this.gup_MessageDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gran Systems";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gup_ComPortState.ResumeLayout(false);
            this.gup_ComPortState.PerformLayout();
            this.gup_InputData.ResumeLayout(false);
            this.gup_InputData.PerformLayout();
            this.gup_MessageDisplay.ResumeLayout(false);
            this.gup_MessageDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gup_OutputData.ResumeLayout(false);
            this.gup_OutputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        // Declare all controls here
        private System.Windows.Forms.Button btn_GenerateCommand;
        private System.Windows.Forms.Button btn_TranslateToEnglish;
        private System.Windows.Forms.Button btn_RefreshPorts;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_ReceiveData;
        private System.Windows.Forms.Button btn_ClearInputData;
        private System.Windows.Forms.Button btn_ClearOutputData;
        private System.Windows.Forms.Button btn_ResetChartView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_InputData;
        private System.Windows.Forms.TextBox txt_MessageOut;
        private System.Windows.Forms.TextBox txt_MessageIn;
        private System.Windows.Forms.TextBox txt_CommandPreview;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox20;

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lab_InputData;
        private System.Windows.Forms.Label lab_OutputData;

        private System.Windows.Forms.ComboBox comboCOM;

        private System.Windows.Forms.RadioButton rad_OnOff;
        private System.Windows.Forms.RadioButton rdo_XForward;
        private System.Windows.Forms.RadioButton rdo_XBackward;
        private System.Windows.Forms.RadioButton rdo_YForward;
        private System.Windows.Forms.RadioButton rdo_YBackward;
        private System.Windows.Forms.RadioButton rdo_ZForward;
        private System.Windows.Forms.RadioButton rdo_ZBackward;

        private System.Windows.Forms.NumericUpDown num_XPulseValue;
        private System.Windows.Forms.NumericUpDown num_XAdditionalParam;
        private System.Windows.Forms.NumericUpDown num_YPulseValue;
        private System.Windows.Forms.NumericUpDown num_YAdditionalParam;
        private System.Windows.Forms.NumericUpDown num_ZPulseValue;
        private System.Windows.Forms.NumericUpDown num_ZAdditionalParam;

        private System.Windows.Forms.GroupBox gup_ComPortState;
        private System.Windows.Forms.GroupBox gup_InputData;
        private System.Windows.Forms.GroupBox gup_MessageDisplay;

        private System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1;
        private System.Windows.Forms.DataVisualization.Charting.Legend legend1;
        private System.Windows.Forms.DataVisualization.Charting.Series series1;
        private System.Windows.Forms.DataVisualization.Charting.Series series2;
        private System.Windows.Forms.DataVisualization.Charting.Series series3;
        private System.Windows.Forms.DataVisualization.Charting.Series series4;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private System.Windows.Forms.Timer timer_accept;
        private System.IO.Ports.SerialPort comReader;

        // Resource manager for icons or images
        private System.ComponentModel.ComponentResourceManager resources;
        protected internal System.Windows.Forms.TextBox txt_ComPortState;
        private System.Windows.Forms.Button btn_SendData;
        private System.Windows.Forms.GroupBox gup_OutputData;
        private System.Windows.Forms.ComboBox XDirection;
        private System.Windows.Forms.Label Xaxis;
        private System.Windows.Forms.TextBox zparamtextbox;
        private System.Windows.Forms.TextBox yparamtextbox;
        private System.Windows.Forms.TextBox xparamtextbox;
        private System.Windows.Forms.Label yaxis;
        private System.Windows.Forms.Label zaxis;
        private System.Windows.Forms.ComboBox YDirection;
        private System.Windows.Forms.ComboBox ZDirection;
        private System.Windows.Forms.PictureBox Logo;
    }
}
