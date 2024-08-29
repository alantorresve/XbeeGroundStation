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
            this.gup_ComPortState = new System.Windows.Forms.GroupBox();
            this.gup_OutputData = new System.Windows.Forms.GroupBox();
            this.gup_InputData = new System.Windows.Forms.GroupBox();
            this.gup_MessageDisplay = new System.Windows.Forms.GroupBox();

            // Initialize group boxes directly within InitializeComponent
            // Or move their contents here if you had them in separate methods.

            this.InitializeComPortStateGroupBox();  // Ensure this method exists or remove it.
            this.InitializeOutputDataGroupBox();    // Ensure this method exists or remove it.
            this.InitializeInputDataGroupBox();     // Ensure this method exists or remove it.
            this.InitializeMessageDisplayGroupBox();// Ensure this method exists or remove it.

            // Final Form settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.gup_ComPortState);
            this.Controls.Add(this.gup_OutputData);
            this.Controls.Add(this.gup_InputData);
            this.Controls.Add(this.gup_MessageDisplay);
            this.resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gran Systems";
            this.Load += new System.EventHandler(this.Form1_Load);
        }


        private void InitializeComPortStateGroupBox()
        {
            // Initialize gup_ComPortState
            this.gup_ComPortState = new System.Windows.Forms.GroupBox();

            // Initialize controls
            this.comboCOM = new System.Windows.Forms.ComboBox();
            this.btn_RefreshPorts = new System.Windows.Forms.Button();
            this.txt_ComPortState = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();

            // Set properties for comboCOM
            this.comboCOM.FormattingEnabled = true;
            this.comboCOM.Location = new System.Drawing.Point(161, 18);
            this.comboCOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCOM.Name = "comboCOM";
            this.comboCOM.Size = new System.Drawing.Size(68, 27);
            this.comboCOM.TabIndex = 0;

            // Set properties for Label1
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 19);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "串列阜 選擇";

            // Set properties for txt_ComPortState
            this.txt_ComPortState.Location = new System.Drawing.Point(12, 48);
            this.txt_ComPortState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ComPortState.Name = "txt_ComPortState";
            this.txt_ComPortState.Size = new System.Drawing.Size(217, 27);
            this.txt_ComPortState.TabIndex = 3;

            // Set properties for btn_Connect
            this.btn_Connect.Location = new System.Drawing.Point(12, 78);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(117, 26);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "串列阜連接";
            this.btn_Connect.UseVisualStyleBackColor = true;

            // Set properties for btn_close
            this.btn_close.Location = new System.Drawing.Point(161, 78);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(67, 26);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "關閉";
            this.btn_close.UseVisualStyleBackColor = true;

            // Set properties for btn_RefreshPorts
            this.btn_RefreshPorts.AutoSize = true;
            this.btn_RefreshPorts.Location = new System.Drawing.Point(161, 109);
            this.btn_RefreshPorts.Name = "btn_RefreshPorts";
            this.btn_RefreshPorts.Size = new System.Drawing.Size(67, 29);
            this.btn_RefreshPorts.TabIndex = 4;
            this.btn_RefreshPorts.Text = "刷新";
            this.btn_RefreshPorts.UseVisualStyleBackColor = true;

            // Add controls to gup_ComPortState
            this.gup_ComPortState.Controls.Add(this.btn_RefreshPorts);
            this.gup_ComPortState.Controls.Add(this.txt_ComPortState);
            this.gup_ComPortState.Controls.Add(this.btn_close);
            this.gup_ComPortState.Controls.Add(this.btn_Connect);
            this.gup_ComPortState.Controls.Add(this.Label1);
            this.gup_ComPortState.Controls.Add(this.comboCOM);

            // Set properties for gup_ComPortState
            this.gup_ComPortState.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gup_ComPortState.Location = new System.Drawing.Point(12, 12);
            this.gup_ComPortState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_ComPortState.Name = "gup_ComPortState";
            this.gup_ComPortState.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_ComPortState.Size = new System.Drawing.Size(236, 143);
            this.gup_ComPortState.TabIndex = 13;
            this.gup_ComPortState.TabStop = false;
            this.gup_ComPortState.Text = "串列阜";

            // Finally, add gup_ComPortState to the form controls
            this.Controls.Add(this.gup_ComPortState);
        }

        private void InitializeOutputDataGroupBox()
        {
            // Initialize gup_OutputData
            this.gup_OutputData = new System.Windows.Forms.GroupBox();

            // Initialize controls
            this.label26 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PulseParameters = new System.Windows.Forms.TextBox();  // Assuming PulseParameters is a TextBox
            this.btn_SendData = new System.Windows.Forms.Button();

            // Set properties for gup_OutputData
            this.gup_OutputData.Controls.Add(this.label26);
            this.gup_OutputData.Controls.Add(this.label2);
            this.gup_OutputData.Controls.Add(this.PulseParameters);
            this.gup_OutputData.Controls.Add(this.btn_SendData);
            this.gup_OutputData.Font = new System.Drawing.Font("Calibri", 12F);
            this.gup_OutputData.Location = new System.Drawing.Point(12, 267);
            this.gup_OutputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_OutputData.Name = "gup_OutputData";
            this.gup_OutputData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_OutputData.Size = new System.Drawing.Size(236, 212);
            this.gup_OutputData.TabIndex = 14;
            this.gup_OutputData.TabStop = false;
            this.gup_OutputData.Text = "脈波參數";

            // Set properties for label26
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 19);
            this.label26.TabIndex = 102;
            this.label26.Text = "輸出腳位";

            // Set properties for label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 104;
            this.label2.Text = "參數:0~210";

            // Set properties for PulseParameters (assuming it's a TextBox)
            this.PulseParameters.Location = new System.Drawing.Point(179, 119);
            this.PulseParameters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PulseParameters.Name = "PulseParameters";
            this.PulseParameters.Size = new System.Drawing.Size(49, 27);
            this.PulseParameters.TabIndex = 103;
            this.PulseParameters.Text = "000";

            // Set properties for btn_SendData
            this.btn_SendData.Location = new System.Drawing.Point(8, 160);
            this.btn_SendData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SendData.Name = "btn_SendData";
            this.btn_SendData.Size = new System.Drawing.Size(222, 30);
            this.btn_SendData.TabIndex = 1;
            this.btn_SendData.Text = "指令上傳";
            this.btn_SendData.UseVisualStyleBackColor = true;
        }


        private void InitializeMessageDisplayGroupBox()
        {
            // Initialize gup_MessageDisplay
            this.gup_MessageDisplay = new System.Windows.Forms.GroupBox();

            // Initialize controls
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

            // Set properties for gup_MessageDisplay
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
            this.gup_MessageDisplay.Font = new System.Drawing.Font("Calibri", 12F);
            this.gup_MessageDisplay.Location = new System.Drawing.Point(248, 26);
            this.gup_MessageDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_MessageDisplay.Name = "gup_MessageDisplay";
            this.gup_MessageDisplay.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_MessageDisplay.Size = new System.Drawing.Size(725, 545);
            this.gup_MessageDisplay.TabIndex = 16;
            this.gup_MessageDisplay.TabStop = false;
            this.gup_MessageDisplay.Text = "主系統狀態";

            // Set properties for btn_ResetChartView
            this.btn_ResetChartView.AutoSize = true;
            this.btn_ResetChartView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ResetChartView.Location = new System.Drawing.Point(607, 370);
            this.btn_ResetChartView.Name = "btn_ResetChartView";
            this.btn_ResetChartView.Size = new System.Drawing.Size(83, 29);
            this.btn_ResetChartView.TabIndex = 76;
            this.btn_ResetChartView.Text = "重置視圖";
            this.btn_ResetChartView.UseVisualStyleBackColor = true;

            // Set properties for chart1
            this.chart1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            var legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            var series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            var series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(50, 287);
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

            // Set properties for textBox6
            this.textBox6.Location = new System.Drawing.Point(496, 178);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(223, 27);
            this.textBox6.TabIndex = 72;

            // Set properties for label7
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 71;
            this.label7.Text = "ALL(uT)";

            // Set properties for button3
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(441, 148);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 26);
            this.button3.TabIndex = 64;
            this.button3.Text = "清除";
            this.button3.UseVisualStyleBackColor = true;

            // Set properties for lab_InputData
            this.lab_InputData.AutoSize = true;
            this.lab_InputData.Location = new System.Drawing.Point(395, 26);
            this.lab_InputData.Name = "lab_InputData";
            this.lab_InputData.Size = new System.Drawing.Size(73, 19);
            this.lab_InputData.TabIndex = 5;
            this.lab_InputData.Text = "接收資料";

            // Set properties for label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Z(uT)";

            // Set properties for label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 69;
            this.label4.Text = "Y(uT)";

            // Set properties for label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 68;
            this.label3.Text = "X(uT)";

            // Set properties for textBox5
            this.textBox5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(496, 209);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(222, 37);
            this.textBox5.TabIndex = 67;

            // Set properties for label16
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 19);
            this.label16.TabIndex = 41;
            this.label16.Text = "時間";

            // Set properties for btn_ClearInputData
            this.btn_ClearInputData.AutoSize = true;
            this.btn_ClearInputData.Location = new System.Drawing.Point(530, 24);
            this.btn_ClearInputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ClearInputData.Name = "btn_ClearInputData";
            this.btn_ClearInputData.Size = new System.Drawing.Size(189, 30);
            this.btn_ClearInputData.TabIndex = 4;
            this.btn_ClearInputData.Text = "清除下傳資料";
            this.btn_ClearInputData.UseVisualStyleBackColor = true;

            // Set properties for textBox20
            this.textBox20.Location = new System.Drawing.Point(50, 179);
            this.textBox20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(383, 27);
            this.textBox20.TabIndex = 40;

            // Set properties for txt_MessageIn
            this.txt_MessageIn.Location = new System.Drawing.Point(379, 57);
            this.txt_MessageIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MessageIn.Multiline = true;
            this.txt_MessageIn.Name = "txt_MessageIn";
            this.txt_MessageIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MessageIn.Size = new System.Drawing.Size(340, 82);
            this.txt_MessageIn.TabIndex = 3;

            // Set properties for textBox2
            this.textBox2.Location = new System.Drawing.Point(50, 148);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(383, 27);
            this.textBox2.TabIndex = 7;

            // Set properties for label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "資料";

            // Set properties for lab_OutputData
            this.lab_OutputData.AutoSize = true;
            this.lab_OutputData.Location = new System.Drawing.Point(8, 28);
            this.lab_OutputData.Name = "lab_OutputData";
            this.lab_OutputData.Size = new System.Drawing.Size(73, 19);
            this.lab_OutputData.TabIndex = 2;
            this.lab_OutputData.Text = "輸出資料";

            // Set properties for btn_ClearOutputData
            this.btn_ClearOutputData.AutoSize = true;
            this.btn_ClearOutputData.Location = new System.Drawing.Point(171, 23);
            this.btn_ClearOutputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ClearOutputData.Name = "btn_ClearOutputData";
            this.btn_ClearOutputData.Size = new System.Drawing.Size(202, 30);
            this.btn_ClearOutputData.TabIndex = 1;
            this.btn_ClearOutputData.Text = "清除上傳資料";
            this.btn_ClearOutputData.UseVisualStyleBackColor = true;

            // Set properties for textBox4
            this.textBox4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(273, 210);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 37);
            this.textBox4.TabIndex = 66;

            // Set properties for txt_MessageOut
            this.txt_MessageOut.Location = new System.Drawing.Point(9, 57);
            this.txt_MessageOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MessageOut.Multiline = true;
            this.txt_MessageOut.Name = "txt_MessageOut";
            this.txt_MessageOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MessageOut.Size = new System.Drawing.Size(364, 82);
            this.txt_MessageOut.TabIndex = 0;

            // Set properties for textBox3
            this.textBox3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(50, 210);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(172, 37);
            this.textBox3.TabIndex = 65;
        }


        private void InitializeInputDataGroupBox()
        {
            // Initialize gup_InputData
            this.gup_InputData = new System.Windows.Forms.GroupBox();

            // Initialize controls
            this.rad_OnOff = new System.Windows.Forms.RadioButton();
            this.btn_ReceiveData = new System.Windows.Forms.Button();
            this.txt_InputData = new System.Windows.Forms.TextBox();

            // Set properties for gup_InputData
            this.gup_InputData.Controls.Add(this.rad_OnOff);
            this.gup_InputData.Controls.Add(this.btn_ReceiveData);
            this.gup_InputData.Controls.Add(this.txt_InputData);
            this.gup_InputData.Font = new System.Drawing.Font("Calibri", 12F);
            this.gup_InputData.Location = new System.Drawing.Point(12, 159);
            this.gup_InputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_InputData.Name = "gup_InputData";
            this.gup_InputData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gup_InputData.Size = new System.Drawing.Size(236, 103);
            this.gup_InputData.TabIndex = 15;
            this.gup_InputData.TabStop = false;
            this.gup_InputData.Text = "接收選單";

            // Set properties for rad_OnOff
            this.rad_OnOff.AutoSize = true;
            this.rad_OnOff.Location = new System.Drawing.Point(28, 71);
            this.rad_OnOff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_OnOff.Name = "rad_OnOff";
            this.rad_OnOff.Size = new System.Drawing.Size(14, 13);
            this.rad_OnOff.TabIndex = 2;
            this.rad_OnOff.TabStop = true;
            this.rad_OnOff.UseVisualStyleBackColor = true;

            // Set properties for btn_ReceiveData
            this.btn_ReceiveData.Location = new System.Drawing.Point(62, 60);
            this.btn_ReceiveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ReceiveData.Name = "btn_ReceiveData";
            this.btn_ReceiveData.Size = new System.Drawing.Size(168, 36);
            this.btn_ReceiveData.TabIndex = 1;
            this.btn_ReceiveData.Text = "下傳資料接收 開/關";
            this.btn_ReceiveData.UseVisualStyleBackColor = true;

            // Set properties for txt_InputData
            this.txt_InputData.Location = new System.Drawing.Point(9, 30);
            this.txt_InputData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_InputData.Name = "txt_InputData";
            this.txt_InputData.Size = new System.Drawing.Size(220, 27);
            this.txt_InputData.TabIndex = 0;
        }


        private void InitializeSerialPortAndTimer()
        {
            // Initialize the SerialPort
            this.comReader = new System.IO.Ports.SerialPort();
            this.comReader.BaudRate = 9600;
            this.comReader.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.comReader_DataReceived);

            // Initialize the Timer
            this.timer_accept = new System.Windows.Forms.Timer();
            this.timer_accept.Interval = 500; // Set the interval to 500ms
            this.timer_accept.Tick += new System.EventHandler(this.timer_accept_Tick);
        }


        #endregion
        // Declare all controls here
        private System.Windows.Forms.Button btn_GenerateCommand;
        private System.Windows.Forms.Button btn_SendData;
        private System.Windows.Forms.Button btn_TranslateToEnglish;
        private System.Windows.Forms.Button btn_RefreshPorts;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_ReceiveData;
        private System.Windows.Forms.Button btn_ClearInputData;
        private System.Windows.Forms.Button btn_ClearOutputData;
        private System.Windows.Forms.Button btn_ResetChartView;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.TextBox txt_ComPortState;
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
        private System.Windows.Forms.TextBox PulseParameters;

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label26;
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
        private System.Windows.Forms.GroupBox gup_OutputData;
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
    }
}
