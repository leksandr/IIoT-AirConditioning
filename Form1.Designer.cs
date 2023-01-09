using S7PROSIMLib;

namespace AirConditioning
{
    partial class Form1
    {
        public S7ProSimClass Sim = new S7ProSimClass();

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCPUState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScanMode = new System.Windows.Forms.Label();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.checkBox1_Input = new System.Windows.Forms.CheckBox();
            this.checkBox2_Input = new System.Windows.Forms.CheckBox();
            this.checkBox3_Input = new System.Windows.Forms.CheckBox();
            this.checkBox4_Input = new System.Windows.Forms.CheckBox();
            this.radioButton1_Input = new System.Windows.Forms.RadioButton();
            this.radioButton2_Input = new System.Windows.Forms.RadioButton();
            this.checkBox7_Input = new System.Windows.Forms.CheckBox();
            this.checkBox_Manual_Out = new System.Windows.Forms.CheckBox();
            this.timer_ReadOutput_Manual = new System.Windows.Forms.Timer(this.components);
            this.checkBox_Automatic_Out = new System.Windows.Forms.CheckBox();
            this.timer_ReadOutput_Automatic = new System.Windows.Forms.Timer(this.components);
            this.checkBox5_Input = new System.Windows.Forms.CheckBox();
            this.checkBox6_Input = new System.Windows.Forms.CheckBox();
            this.comboBox_CPUState = new System.Windows.Forms.ComboBox();
            this.comboBox_ScanMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Input0_AddressByte = new System.Windows.Forms.TextBox();
            this.Input0_AddressBit = new System.Windows.Forms.TextBox();
            this.Input1_AddressBit = new System.Windows.Forms.TextBox();
            this.Input1_AddressByte = new System.Windows.Forms.TextBox();
            this.Input2_AddressBit = new System.Windows.Forms.TextBox();
            this.Input2_AddressByte = new System.Windows.Forms.TextBox();
            this.Input3_AddressBit = new System.Windows.Forms.TextBox();
            this.Input3_AddressByte = new System.Windows.Forms.TextBox();
            this.Input4_AddressBit = new System.Windows.Forms.TextBox();
            this.Input4_AddressByte = new System.Windows.Forms.TextBox();
            this.Input7_AddressBit = new System.Windows.Forms.TextBox();
            this.Input7_AddressByte = new System.Windows.Forms.TextBox();
            this.Input5_AddressByte = new System.Windows.Forms.TextBox();
            this.Input5_AddressBit = new System.Windows.Forms.TextBox();
            this.Input6_AddressBit = new System.Windows.Forms.TextBox();
            this.Input6_AddressByte = new System.Windows.Forms.TextBox();
            this.Output0_AddressBit = new System.Windows.Forms.TextBox();
            this.Output0_AddressByte = new System.Windows.Forms.TextBox();
            this.Output1_AddressBit = new System.Windows.Forms.TextBox();
            this.Output1_AddressByte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(812, 12);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(86, 44);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(812, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU State:";
            // 
            // labelCPUState
            // 
            this.labelCPUState.AutoSize = true;
            this.labelCPUState.Location = new System.Drawing.Point(884, 161);
            this.labelCPUState.Name = "labelCPUState";
            this.labelCPUState.Size = new System.Drawing.Size(35, 13);
            this.labelCPUState.TabIndex = 2;
            this.labelCPUState.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scan Mode:";
            // 
            // labelScanMode
            // 
            this.labelScanMode.AutoSize = true;
            this.labelScanMode.Location = new System.Drawing.Point(884, 182);
            this.labelScanMode.Name = "labelScanMode";
            this.labelScanMode.Size = new System.Drawing.Size(35, 13);
            this.labelScanMode.TabIndex = 4;
            this.labelScanMode.Text = "label3";
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(912, 12);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(86, 43);
            this.button_Disconnect.TabIndex = 5;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // checkBox1_Input
            // 
            this.checkBox1_Input.AutoSize = true;
            this.checkBox1_Input.Location = new System.Drawing.Point(73, 381);
            this.checkBox1_Input.Name = "checkBox1_Input";
            this.checkBox1_Input.Size = new System.Drawing.Size(108, 17);
            this.checkBox1_Input.TabIndex = 6;
            this.checkBox1_Input.Text = "Window sensor 1";
            this.checkBox1_Input.UseVisualStyleBackColor = true;
            this.checkBox1_Input.CheckedChanged += new System.EventHandler(this.checkBox1_Input_CheckedChanged);
            // 
            // checkBox2_Input
            // 
            this.checkBox2_Input.AutoSize = true;
            this.checkBox2_Input.Location = new System.Drawing.Point(259, 381);
            this.checkBox2_Input.Name = "checkBox2_Input";
            this.checkBox2_Input.Size = new System.Drawing.Size(108, 17);
            this.checkBox2_Input.TabIndex = 7;
            this.checkBox2_Input.Text = "Window sensor 2";
            this.checkBox2_Input.UseVisualStyleBackColor = true;
            this.checkBox2_Input.CheckedChanged += new System.EventHandler(this.checkBox2_Input_CheckedChanged);
            // 
            // checkBox3_Input
            // 
            this.checkBox3_Input.AutoSize = true;
            this.checkBox3_Input.Location = new System.Drawing.Point(442, 381);
            this.checkBox3_Input.Name = "checkBox3_Input";
            this.checkBox3_Input.Size = new System.Drawing.Size(108, 17);
            this.checkBox3_Input.TabIndex = 8;
            this.checkBox3_Input.Text = "Window sensor 3";
            this.checkBox3_Input.UseVisualStyleBackColor = true;
            this.checkBox3_Input.CheckedChanged += new System.EventHandler(this.checkBox3_Input_CheckedChanged);
            // 
            // checkBox4_Input
            // 
            this.checkBox4_Input.AutoSize = true;
            this.checkBox4_Input.Location = new System.Drawing.Point(603, 381);
            this.checkBox4_Input.Name = "checkBox4_Input";
            this.checkBox4_Input.Size = new System.Drawing.Size(108, 17);
            this.checkBox4_Input.TabIndex = 9;
            this.checkBox4_Input.Text = "Window sensor 4";
            this.checkBox4_Input.UseVisualStyleBackColor = true;
            this.checkBox4_Input.CheckedChanged += new System.EventHandler(this.checkBox4_Input_CheckedChanged);
            // 
            // radioButton1_Input
            // 
            this.radioButton1_Input.AutoSize = true;
            this.radioButton1_Input.Location = new System.Drawing.Point(320, 471);
            this.radioButton1_Input.Name = "radioButton1_Input";
            this.radioButton1_Input.Size = new System.Drawing.Size(47, 17);
            this.radioButton1_Input.TabIndex = 10;
            this.radioButton1_Input.TabStop = true;
            this.radioButton1_Input.Text = "Auto";
            this.radioButton1_Input.UseVisualStyleBackColor = true;
            this.radioButton1_Input.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2_Input
            // 
            this.radioButton2_Input.AutoSize = true;
            this.radioButton2_Input.Location = new System.Drawing.Point(464, 471);
            this.radioButton2_Input.Name = "radioButton2_Input";
            this.radioButton2_Input.Size = new System.Drawing.Size(60, 17);
            this.radioButton2_Input.TabIndex = 11;
            this.radioButton2_Input.TabStop = true;
            this.radioButton2_Input.Text = "Manual";
            this.radioButton2_Input.UseVisualStyleBackColor = true;
            this.radioButton2_Input.CheckedChanged += new System.EventHandler(this.radioButton2_Input_CheckedChanged);
            // 
            // checkBox7_Input
            // 
            this.checkBox7_Input.AutoSize = true;
            this.checkBox7_Input.Location = new System.Drawing.Point(536, 108);
            this.checkBox7_Input.Name = "checkBox7_Input";
            this.checkBox7_Input.Size = new System.Drawing.Size(94, 17);
            this.checkBox7_Input.TabIndex = 12;
            this.checkBox7_Input.Text = "Manual switch";
            this.checkBox7_Input.UseVisualStyleBackColor = true;
            this.checkBox7_Input.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox_Manual_Out
            // 
            this.checkBox_Manual_Out.AutoSize = true;
            this.checkBox_Manual_Out.Location = new System.Drawing.Point(353, 50);
            this.checkBox_Manual_Out.Name = "checkBox_Manual_Out";
            this.checkBox_Manual_Out.Size = new System.Drawing.Size(111, 17);
            this.checkBox_Manual_Out.TabIndex = 13;
            this.checkBox_Manual_Out.Text = "Power On Manual";
            this.checkBox_Manual_Out.UseVisualStyleBackColor = true;
            // 
            // timer_ReadOutput_Manual
            // 
            this.timer_ReadOutput_Manual.Enabled = true;
            this.timer_ReadOutput_Manual.Tick += new System.EventHandler(this.timer_ReadOutput_Manual_Tick);
            // 
            // checkBox_Automatic_Out
            // 
            this.checkBox_Automatic_Out.AutoSize = true;
            this.checkBox_Automatic_Out.Location = new System.Drawing.Point(353, 74);
            this.checkBox_Automatic_Out.Name = "checkBox_Automatic_Out";
            this.checkBox_Automatic_Out.Size = new System.Drawing.Size(123, 17);
            this.checkBox_Automatic_Out.TabIndex = 14;
            this.checkBox_Automatic_Out.Text = "Power On Automatic";
            this.checkBox_Automatic_Out.UseVisualStyleBackColor = true;
            // 
            // timer_ReadOutput_Automatic
            // 
            this.timer_ReadOutput_Automatic.Enabled = true;
            this.timer_ReadOutput_Automatic.Tick += new System.EventHandler(this.timer_readOutput_Automatic_Tick);
            // 
            // checkBox5_Input
            // 
            this.checkBox5_Input.AutoSize = true;
            this.checkBox5_Input.Location = new System.Drawing.Point(238, 198);
            this.checkBox5_Input.Name = "checkBox5_Input";
            this.checkBox5_Input.Size = new System.Drawing.Size(129, 17);
            this.checkBox5_Input.TabIndex = 15;
            this.checkBox5_Input.Text = "Temperature sensor 1";
            this.checkBox5_Input.UseVisualStyleBackColor = true;
            this.checkBox5_Input.CheckedChanged += new System.EventHandler(this.checkBox5_Input_CheckedChanged);
            // 
            // checkBox6_Input
            // 
            this.checkBox6_Input.AutoSize = true;
            this.checkBox6_Input.Location = new System.Drawing.Point(603, 198);
            this.checkBox6_Input.Name = "checkBox6_Input";
            this.checkBox6_Input.Size = new System.Drawing.Size(129, 17);
            this.checkBox6_Input.TabIndex = 16;
            this.checkBox6_Input.Text = "Temperature sensor 2";
            this.checkBox6_Input.UseVisualStyleBackColor = true;
            this.checkBox6_Input.CheckedChanged += new System.EventHandler(this.checkBox6_Input_CheckedChanged);
            // 
            // comboBox_CPUState
            // 
            this.comboBox_CPUState.FormattingEnabled = true;
            this.comboBox_CPUState.Items.AddRange(new object[] {
            "RUN_P",
            "RUN",
            "STOP"});
            this.comboBox_CPUState.Location = new System.Drawing.Point(812, 85);
            this.comboBox_CPUState.Name = "comboBox_CPUState";
            this.comboBox_CPUState.Size = new System.Drawing.Size(121, 21);
            this.comboBox_CPUState.TabIndex = 17;
            this.comboBox_CPUState.SelectedIndexChanged += new System.EventHandler(this.comboBox_CPUState_SelectedIndexChanged);
            // 
            // comboBox_ScanMode
            // 
            this.comboBox_ScanMode.FormattingEnabled = true;
            this.comboBox_ScanMode.Items.AddRange(new object[] {
            "Single Scan",
            "Continuous Scan"});
            this.comboBox_ScanMode.Location = new System.Drawing.Point(812, 127);
            this.comboBox_ScanMode.Name = "comboBox_ScanMode";
            this.comboBox_ScanMode.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ScanMode.TabIndex = 18;
            this.comboBox_ScanMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_ScanMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select state";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Select scan mode";
            // 
            // Input0_AddressByte
            // 
            this.Input0_AddressByte.Location = new System.Drawing.Point(923, 232);
            this.Input0_AddressByte.Name = "Input0_AddressByte";
            this.Input0_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Input0_AddressByte.TabIndex = 21;
            this.Input0_AddressByte.TextChanged += new System.EventHandler(this.Input0_AddressByte_TextChanged);
            // 
            // Input0_AddressBit
            // 
            this.Input0_AddressBit.Location = new System.Drawing.Point(955, 232);
            this.Input0_AddressBit.Name = "Input0_AddressBit";
            this.Input0_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Input0_AddressBit.TabIndex = 22;
            this.Input0_AddressBit.TextChanged += new System.EventHandler(this.Input0_AddressBit_TextChanged);
            // 
            // Input1_AddressBit
            // 
            this.Input1_AddressBit.Location = new System.Drawing.Point(955, 258);
            this.Input1_AddressBit.Name = "Input1_AddressBit";
            this.Input1_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Input1_AddressBit.TabIndex = 24;
            this.Input1_AddressBit.TextChanged += new System.EventHandler(this.Input1_AddressBit_TextChanged);
            // 
            // Input1_AddressByte
            // 
            this.Input1_AddressByte.Location = new System.Drawing.Point(923, 258);
            this.Input1_AddressByte.Name = "Input1_AddressByte";
            this.Input1_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Input1_AddressByte.TabIndex = 23;
            this.Input1_AddressByte.TextChanged += new System.EventHandler(this.Input1_AddressByte_TextChanged);
            // 
            // Input2_AddressBit
            // 
            this.Input2_AddressBit.Location = new System.Drawing.Point(955, 284);
            this.Input2_AddressBit.Name = "Input2_AddressBit";
            this.Input2_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Input2_AddressBit.TabIndex = 26;
            this.Input2_AddressBit.TextChanged += new System.EventHandler(this.Input2_AddressBit_TextChanged);
            // 
            // Input2_AddressByte
            // 
            this.Input2_AddressByte.Location = new System.Drawing.Point(923, 284);
            this.Input2_AddressByte.Name = "Input2_AddressByte";
            this.Input2_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Input2_AddressByte.TabIndex = 25;
            this.Input2_AddressByte.TextChanged += new System.EventHandler(this.Input2_AddressByte_TextChanged);
            // 
            // Input3_AddressBit
            // 
            this.Input3_AddressBit.Location = new System.Drawing.Point(955, 310);
            this.Input3_AddressBit.Name = "Input3_AddressBit";
            this.Input3_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Input3_AddressBit.TabIndex = 28;
            this.Input3_AddressBit.TextChanged += new System.EventHandler(this.Input3_AddressBit_TextChanged);
            // 
            // Input3_AddressByte
            // 
            this.Input3_AddressByte.Location = new System.Drawing.Point(923, 310);
            this.Input3_AddressByte.Name = "Input3_AddressByte";
            this.Input3_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Input3_AddressByte.TabIndex = 27;
            this.Input3_AddressByte.TextChanged += new System.EventHandler(this.Input3_AddressByte_TextChanged);
            // 
            // Input4_AddressBit
            // 
            this.Input4_AddressBit.Location = new System.Drawing.Point(955, 336);
            this.Input4_AddressBit.Name = "Input4_AddressBit";
            this.Input4_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Input4_AddressBit.TabIndex = 30;
            this.Input4_AddressBit.TextChanged += new System.EventHandler(this.Input4_AddressBit_TextChanged);
            // 
            // Input4_AddressByte
            // 
            this.Input4_AddressByte.Location = new System.Drawing.Point(923, 336);
            this.Input4_AddressByte.Name = "Input4_AddressByte";
            this.Input4_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Input4_AddressByte.TabIndex = 29;
            this.Input4_AddressByte.TextChanged += new System.EventHandler(this.Input4_AddressByte_TextChanged);
            // 
            // Input7_AddressBit
            // 
            this.Input7_AddressBit.Location = new System.Drawing.Point(955, 414);
            this.Input7_AddressBit.Name = "Input7_AddressBit";
            this.Input7_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Input7_AddressBit.TabIndex = 32;
            this.Input7_AddressBit.TextChanged += new System.EventHandler(this.Input7_AddressBit_TextChanged);
            // 
            // Input7_AddressByte
            // 
            this.Input7_AddressByte.Location = new System.Drawing.Point(923, 414);
            this.Input7_AddressByte.Name = "Input7_AddressByte";
            this.Input7_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Input7_AddressByte.TabIndex = 31;
            this.Input7_AddressByte.TextChanged += new System.EventHandler(this.Input7_AddressByte_TextChanged);
            // 
            // Input5_AddressByte
            // 
            this.Input5_AddressByte.Location = new System.Drawing.Point(923, 362);
            this.Input5_AddressByte.Name = "Input5_AddressByte";
            this.Input5_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Input5_AddressByte.TabIndex = 31;
            this.Input5_AddressByte.TextChanged += new System.EventHandler(this.Input5_AddressByte_TextChanged);
            // 
            // Input5_AddressBit
            // 
            this.Input5_AddressBit.Location = new System.Drawing.Point(955, 362);
            this.Input5_AddressBit.Name = "Input5_AddressBit";
            this.Input5_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Input5_AddressBit.TabIndex = 32;
            this.Input5_AddressBit.TextChanged += new System.EventHandler(this.Input5_AddressBit_TextChanged);
            // 
            // Input6_AddressBit
            // 
            this.Input6_AddressBit.Location = new System.Drawing.Point(955, 388);
            this.Input6_AddressBit.Name = "Input6_AddressBit";
            this.Input6_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Input6_AddressBit.TabIndex = 34;
            this.Input6_AddressBit.TextChanged += new System.EventHandler(this.Input6_AddressBit_TextChanged);
            // 
            // Input6_AddressByte
            // 
            this.Input6_AddressByte.Location = new System.Drawing.Point(923, 388);
            this.Input6_AddressByte.Name = "Input6_AddressByte";
            this.Input6_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Input6_AddressByte.TabIndex = 33;
            this.Input6_AddressByte.TextChanged += new System.EventHandler(this.Input6_AddressByte_TextChanged);
            // 
            // Output0_AddressBit
            // 
            this.Output0_AddressBit.Location = new System.Drawing.Point(955, 440);
            this.Output0_AddressBit.Name = "Output0_AddressBit";
            this.Output0_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Output0_AddressBit.TabIndex = 36;
            this.Output0_AddressBit.TextChanged += new System.EventHandler(this.Output0_AddressBit_TextChanged);
            // 
            // Output0_AddressByte
            // 
            this.Output0_AddressByte.Location = new System.Drawing.Point(923, 440);
            this.Output0_AddressByte.Name = "Output0_AddressByte";
            this.Output0_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Output0_AddressByte.TabIndex = 35;
            this.Output0_AddressByte.TextChanged += new System.EventHandler(this.Output0_AddressByte_TextChanged);
            // 
            // Output1_AddressBit
            // 
            this.Output1_AddressBit.Location = new System.Drawing.Point(955, 466);
            this.Output1_AddressBit.Name = "Output1_AddressBit";
            this.Output1_AddressBit.Size = new System.Drawing.Size(26, 20);
            this.Output1_AddressBit.TabIndex = 38;
            this.Output1_AddressBit.TextChanged += new System.EventHandler(this.Output1_AddressBit_TextChanged);
            // 
            // Output1_AddressByte
            // 
            this.Output1_AddressByte.Location = new System.Drawing.Point(923, 466);
            this.Output1_AddressByte.Name = "Output1_AddressByte";
            this.Output1_AddressByte.Size = new System.Drawing.Size(26, 20);
            this.Output1_AddressByte.TabIndex = 37;
            this.Output1_AddressByte.TextChanged += new System.EventHandler(this.Output1_AddressByte_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Mode switch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(812, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mode switch / I";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(812, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Window sensor 1 / I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(812, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Window sensor 2 / I";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(812, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Window sensor 3 / I";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(812, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Window sensor 4 / I";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(812, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Temp. sensor 1 / I";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(812, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Temp. sensor 2 / I";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(812, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Manual switch / I";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(812, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "PowerOn Auto / Q";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(813, 473);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "PowerOn Manual / Q";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(921, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Byte";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(955, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Bit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AirConditioning.Properties.Resources.AirConditioning;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1010, 500);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Output1_AddressBit);
            this.Controls.Add(this.Output1_AddressByte);
            this.Controls.Add(this.Output0_AddressBit);
            this.Controls.Add(this.Output0_AddressByte);
            this.Controls.Add(this.Input6_AddressBit);
            this.Controls.Add(this.Input6_AddressByte);
            this.Controls.Add(this.Input5_AddressBit);
            this.Controls.Add(this.Input7_AddressBit);
            this.Controls.Add(this.Input5_AddressByte);
            this.Controls.Add(this.Input7_AddressByte);
            this.Controls.Add(this.Input4_AddressBit);
            this.Controls.Add(this.Input4_AddressByte);
            this.Controls.Add(this.Input3_AddressBit);
            this.Controls.Add(this.Input3_AddressByte);
            this.Controls.Add(this.Input2_AddressBit);
            this.Controls.Add(this.Input2_AddressByte);
            this.Controls.Add(this.Input1_AddressBit);
            this.Controls.Add(this.Input1_AddressByte);
            this.Controls.Add(this.Input0_AddressBit);
            this.Controls.Add(this.Input0_AddressByte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ScanMode);
            this.Controls.Add(this.comboBox_CPUState);
            this.Controls.Add(this.checkBox6_Input);
            this.Controls.Add(this.checkBox5_Input);
            this.Controls.Add(this.checkBox_Automatic_Out);
            this.Controls.Add(this.checkBox_Manual_Out);
            this.Controls.Add(this.checkBox7_Input);
            this.Controls.Add(this.radioButton2_Input);
            this.Controls.Add(this.radioButton1_Input);
            this.Controls.Add(this.checkBox4_Input);
            this.Controls.Add(this.checkBox3_Input);
            this.Controls.Add(this.checkBox2_Input);
            this.Controls.Add(this.checkBox1_Input);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.labelScanMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCPUState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Connect);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPUState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScanMode;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.CheckBox checkBox1_Input;
        private System.Windows.Forms.CheckBox checkBox2_Input;
        private System.Windows.Forms.CheckBox checkBox3_Input;
        private System.Windows.Forms.CheckBox checkBox4_Input;
        private System.Windows.Forms.RadioButton radioButton1_Input;
        private System.Windows.Forms.RadioButton radioButton2_Input;
        private System.Windows.Forms.CheckBox checkBox7_Input;
        private System.Windows.Forms.CheckBox checkBox_Manual_Out;
        private System.Windows.Forms.Timer timer_ReadOutput_Manual;
        private System.Windows.Forms.CheckBox checkBox_Automatic_Out;
        private System.Windows.Forms.Timer timer_ReadOutput_Automatic;
        private System.Windows.Forms.CheckBox checkBox5_Input;
        private System.Windows.Forms.CheckBox checkBox6_Input;
        private System.Windows.Forms.ComboBox comboBox_CPUState;
        private System.Windows.Forms.ComboBox comboBox_ScanMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Input0_AddressByte;
        private System.Windows.Forms.TextBox Input0_AddressBit;
        private System.Windows.Forms.TextBox Input1_AddressBit;
        private System.Windows.Forms.TextBox Input1_AddressByte;
        private System.Windows.Forms.TextBox Input2_AddressBit;
        private System.Windows.Forms.TextBox Input2_AddressByte;
        private System.Windows.Forms.TextBox Input3_AddressBit;
        private System.Windows.Forms.TextBox Input3_AddressByte;
        private System.Windows.Forms.TextBox Input4_AddressBit;
        private System.Windows.Forms.TextBox Input4_AddressByte;
        private System.Windows.Forms.TextBox Input7_AddressBit;
        private System.Windows.Forms.TextBox Input7_AddressByte;
        private System.Windows.Forms.TextBox Input5_AddressByte;
        private System.Windows.Forms.TextBox Input5_AddressBit;
        private System.Windows.Forms.TextBox Input6_AddressBit;
        private System.Windows.Forms.TextBox Input6_AddressByte;
        private System.Windows.Forms.TextBox Output0_AddressBit;
        private System.Windows.Forms.TextBox Output0_AddressByte;
        private System.Windows.Forms.TextBox Output1_AddressBit;
        private System.Windows.Forms.TextBox Output1_AddressByte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

