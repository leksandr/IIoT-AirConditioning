using S7PROSIMLib;
using System;
using System.Windows.Forms;

namespace AirConditioning
{
    public partial class Form1 : Form
    {
        private readonly Address ModeSwitch = new Address { ByteIndex = 0, BitIndex = 0 };
        private readonly Address WindowSensor1 = new Address { ByteIndex = 0, BitIndex = 1 };
        private readonly Address WindowSensor2 = new Address { ByteIndex = 0, BitIndex = 2 };
        private readonly Address WindowSensor3 = new Address { ByteIndex = 0, BitIndex = 3 };
        private readonly Address WindowSensor4 = new Address { ByteIndex = 0, BitIndex = 4 };
        private readonly Address TemperatureSensor1 = new Address { ByteIndex = 0, BitIndex = 5 };
        private readonly Address TemperatureSensor2 = new Address { ByteIndex = 0, BitIndex = 6 };
        private readonly Address ManualSwitch = new Address { ByteIndex = 0, BitIndex = 7 };

        private readonly Address PowerOnAutomatic = new Address { ByteIndex = 0, BitIndex = 0 };
        private readonly Address PowerOnManual = new Address { ByteIndex = 0, BitIndex = 1 };
        public Form1()
        {
            InitializeComponent();

            Input0_AddressByte.Text = ModeSwitch.ByteIndex.ToString();
            Input0_AddressBit.Text = ModeSwitch.BitIndex.ToString();

            Input1_AddressByte.Text = WindowSensor1.ByteIndex.ToString();
            Input1_AddressBit.Text = WindowSensor1.BitIndex.ToString();

            Input2_AddressByte.Text = WindowSensor2.ByteIndex.ToString();
            Input2_AddressBit.Text = WindowSensor2.BitIndex.ToString();

            Input3_AddressByte.Text = WindowSensor3.ByteIndex.ToString();
            Input3_AddressBit.Text = WindowSensor3.BitIndex.ToString();

            Input4_AddressByte.Text = WindowSensor4.ByteIndex.ToString();
            Input4_AddressBit.Text = WindowSensor4.BitIndex.ToString();

            Input5_AddressByte.Text = TemperatureSensor1.ByteIndex.ToString();
            Input5_AddressBit.Text = TemperatureSensor1.BitIndex.ToString();

            Input6_AddressByte.Text = TemperatureSensor2.ByteIndex.ToString();
            Input6_AddressBit.Text = TemperatureSensor2.BitIndex.ToString();

            Input7_AddressByte.Text = ManualSwitch.ByteIndex.ToString();
            Input7_AddressBit.Text = ManualSwitch.BitIndex.ToString();

            Output0_AddressByte.Text = PowerOnAutomatic.ByteIndex.ToString();
            Output0_AddressBit.Text = PowerOnAutomatic.BitIndex.ToString();

            Output1_AddressByte.Text = PowerOnManual.ByteIndex.ToString();
            Output1_AddressBit.Text = PowerOnManual.BitIndex.ToString();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Sim.Connect();
            Sim.BeginScanNotify();
            Sim.SetScanMode(ScanModeConstants.ContinuousScan);

            labelCPUState.Text = Sim.GetState();
            comboBox_CPUState.SelectedItem = labelCPUState.Text;

            var scanMode = Sim.GetScanMode();
            labelScanMode.Text = Sim.GetScanMode().ToString();
            if (scanMode == ScanModeConstants.SingleScan)
            {
                labelScanMode.Text = "Single Scan";
                comboBox_ScanMode.SelectedItem = labelScanMode.Text;
            }
            else if (scanMode == ScanModeConstants.ContinuousScan)
            {
                labelScanMode.Text = "Continuous Scan";
                comboBox_ScanMode.SelectedItem = labelScanMode.Text;
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            Sim.Disconnect();
            labelCPUState.Text = "-";
            labelScanMode.Text = "-";
        }

        private void checkBox1_Input_CheckedChanged(object sender, EventArgs e)
        {
            object I0_1 = checkBox1_Input.Checked;
            Sim.WriteInputPoint(WindowSensor1.ByteIndex, WindowSensor1.BitIndex, ref I0_1);
        }

        private void checkBox2_Input_CheckedChanged(object sender, EventArgs e)
        {
            object I0_2 = checkBox2_Input.Checked;
            Sim.WriteInputPoint(WindowSensor2.ByteIndex, WindowSensor2.BitIndex, ref I0_2);
        }

        private void checkBox3_Input_CheckedChanged(object sender, EventArgs e)
        {
            object I0_3 = checkBox3_Input.Checked;
            Sim.WriteInputPoint(WindowSensor3.ByteIndex, WindowSensor3.BitIndex, ref I0_3);
        }

        private void checkBox4_Input_CheckedChanged(object sender, EventArgs e)
        {
            object I0_4 = checkBox4_Input.Checked;
            Sim.WriteInputPoint(WindowSensor4.ByteIndex, WindowSensor4.BitIndex, ref I0_4);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            object I0_0 = radioButton1_Input.Checked;
            Sim.WriteInputPoint(ModeSwitch.ByteIndex, ModeSwitch.BitIndex, ref I0_0);
        }

        private void radioButton2_Input_CheckedChanged(object sender, EventArgs e)
        {
            object I0_0 = !radioButton2_Input.Checked;
            Sim.WriteInputPoint(ModeSwitch.ByteIndex, ModeSwitch.BitIndex, ref I0_0);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            object I0_7 = checkBox7_Input.Checked;
            Sim.WriteInputPoint(ManualSwitch.ByteIndex, ManualSwitch.BitIndex, ref I0_7);
        }

        private void timer_readOutput_Automatic_Tick(object sender, EventArgs e)
        {
            object Q0_0 = false; // initial value
            Sim.ReadOutputPoint(PowerOnAutomatic.ByteIndex, PowerOnAutomatic.BitIndex, PointDataTypeConstants.S7_Bit, ref Q0_0);
            checkBox_Automatic_Out.Checked = (bool)Q0_0;
        }

        private void timer_ReadOutput_Manual_Tick(object sender, EventArgs e)
        {
            object Q0_1 = false; // initial value
            Sim.ReadOutputPoint(PowerOnManual.ByteIndex, PowerOnManual.BitIndex, PointDataTypeConstants.S7_Bit, ref Q0_1);
            checkBox_Manual_Out.Checked = (bool)Q0_1;
        }

        private void checkBox5_Input_CheckedChanged(object sender, EventArgs e)
        {
            object I0_5 = checkBox5_Input.Checked;
            Sim.WriteInputPoint(TemperatureSensor1.ByteIndex, TemperatureSensor1.BitIndex, ref I0_5);
        }

        private void checkBox6_Input_CheckedChanged(object sender, EventArgs e)
        {
            object I0_6 = checkBox6_Input.Checked;
            Sim.WriteInputPoint(TemperatureSensor2.ByteIndex, TemperatureSensor2.BitIndex, ref I0_6);
        }

        private void comboBox_CPUState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string state = comboBox_CPUState.SelectedItem.ToString();
            Sim.SetState(state);
            labelCPUState.Text = state;
        }

        private void comboBox_ScanMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scanMode = comboBox_ScanMode.SelectedItem.ToString();
            if (scanMode == "Single Scan")
            {
                Sim.SetScanMode(ScanModeConstants.SingleScan);
            }
            else if (scanMode == "Continuous Scan")
            {
                Sim.SetScanMode(ScanModeConstants.ContinuousScan);
            }

            labelScanMode.Text = scanMode;
        }

        private void Input0_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Input0_AddressByte, ModeSwitch);
        }

        private void Input0_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Input0_AddressBit, ModeSwitch);
        }
        private void Input1_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Input1_AddressByte, WindowSensor1);
        }

        private void Input1_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Input1_AddressBit, WindowSensor1);
        }

        private void Input2_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Input2_AddressByte, WindowSensor2);
        }

        private void Input2_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Input2_AddressBit, WindowSensor2);
        }

        private void Input3_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Input3_AddressByte, WindowSensor3);
        }

        private void Input3_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Input3_AddressBit, WindowSensor3);
        }

        private void Input4_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Input4_AddressByte, WindowSensor4);
        }

        private void Input4_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Input4_AddressBit, WindowSensor4);
        }

        private void Input5_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Input5_AddressByte, TemperatureSensor1);
        }

        private void Input5_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Input5_AddressBit, TemperatureSensor1);
        }

        private void Input6_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Input6_AddressByte, TemperatureSensor2);
        }

        private void Input6_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Input6_AddressBit, TemperatureSensor2);
        }

        private void Input7_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Input7_AddressByte, ManualSwitch);
        }

        private void Input7_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Input7_AddressBit, ManualSwitch);
        }

        private void Output0_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Output0_AddressByte, PowerOnAutomatic);
        }

        private void Output0_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Output0_AddressBit, PowerOnAutomatic);
        }

        private void Output1_AddressByte_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetByteAddress(Output1_AddressByte, PowerOnManual);
        }

        private void Output1_AddressBit_TextChanged(object sender, EventArgs e)
        {
            ParseAndSetBitAddress(Output1_AddressBit, PowerOnManual);
        }

        private void ParseAndSetByteAddress(TextBox textbox, Address address)
        {
            int.TryParse(textbox.Text, out var parsed);
            address.ByteIndex = parsed;
        }
        private void ParseAndSetBitAddress(TextBox textbox, Address address)
        {
            int.TryParse(textbox.Text, out var parsed);
            address.BitIndex = parsed;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
