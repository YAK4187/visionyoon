using System;
using System.Windows.Forms;
using ActUtlTypeLib;

namespace ConnectPLC
{
    public partial class Form1 : Form
    {
        #region Fields and Initialization
        private ActUtlType plc; // PLC connection object
        private Timer plcTimer; // Timer to periodically read PLC data
        private int d500_0Toggle; // Toggle state for D500.0 (alternates 0, 1)

        public Form1()
        {
            InitializeComponent();
            plc = new ActUtlType();
            plcTimer = new Timer();
            plcTimer.Interval = 1000;
            plcTimer.Tick += PlcTimer_Tick;
            d500_0Toggle = 0;

            // Text box leave event for formatting input values
            tbD510.Leave += (sender, e) => FormatTextBox(tbD510, 4);
            tbD512.Leave += (sender, e) => FormatTextBox(tbD512, 2);
            tbD514.Leave += (sender, e) => FormatTextBox(tbD514, 2);
            tbD516.Leave += (sender, e) => FormatTextBox(tbD516, 2);
            tbD518.Leave += (sender, e) => FormatTextBox(tbD518, 2);
        }
        #endregion

        #region PLC Connection Handling
        // Connect to PLC
        private void btnConnect_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 0;
            int result = plc.Open();

            // Check if connection was successful
            if (result == 0)
            {
                lblStatus.Text = "PLC connected successfully.";
                plcTimer.Start(); // Start timer to read data periodically
            }
            else
            {
                lblStatus.Text = "Failed to connect PLC.";
            }
        }

        // Disconnect from PLC
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            int result = plc.Close();

            // Check if disconnection was successful
            if (result == 0)
            {
                lblStatus.Text = "PLC connection terminated.";
                plcTimer.Stop();
            }
            else
            {
                lblStatus.Text = "Failed to disconnect PLC.";
            }
        }
        #endregion

        #region Data Reading and Syncing
        // Timer tick event to read and sync data
        private void PlcTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Arrays to store data
                int[] d400Data = new int[1];
                int[] d500Data = new int[1];
                int[] d410Data = new int[2]; // DINT (Double integer)
                int[] d412Data = new int[2]; // DINT

                // Read data from PLC
                ReadData(d400Data, d500Data, d410Data, d412Data);

                // Convert and process data
                float floatD410 = ConvertToFloat(d410Data, 10000.0f);
                float floatD412 = ConvertToFloat(d412Data, 100.0f);

                // Sync D400 to D500
                SyncD400ToD500(ref d400Data[0], ref d500Data[0]);

                // Update D500.0 with toggle value (0 or 1)
                d500Data[0] = ToggleD500(d500Data[0]);

                // Update UI with current data
                UpdateTextBoxes(d400Data[0], d500Data[0], floatD410, floatD412);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading and syncing data: {ex.Message}");
            }
        }

        // Read PLC data
        private void ReadData(int[] d400Data, int[] d500Data, int[] d410Data, int[] d412Data)
        {
            plc.ReadDeviceBlock("D400", 1, out d400Data[0]);
            plc.ReadDeviceBlock("D500", 1, out d500Data[0]);
            plc.ReadDeviceBlock("D410", 2, out d410Data[0]);
            plc.ReadDeviceBlock("D412", 2, out d412Data[0]);
        }

        // Convert data to float
        private float ConvertToFloat(int[] data, float scaleFactor)
        {
            int dint = (data[1] << 16) | (data[0] & 0xFFFF); // Combine two words into a DINT
            return dint / scaleFactor;
        }

        // Toggle D500.0 bit between 0 and 1
        private int ToggleD500(int d500Data)
        {
            d500Data &= ~(1 << 0); // Clear D500.0
            d500Data |= (d500_0Toggle << 0); // Set D500.0 to current toggle value
            d500_0Toggle = 1 - d500_0Toggle; // Toggle for next cycle
            return d500Data;
        }

        // Sync D400 to D500 based on the current state of D400
        private void SyncD400ToD500(ref int d400Data, ref int d500Data)
        {
            // Loop through bits 1 to 7 in D400 and set corresponding bits in D500
            for (int i = 1; i <= 7; i++)
            {
                if (((d400Data >> i) & 1) == 1)
                {
                    d500Data |= (1 << i); // Set corresponding bit in D500
                }
                else
                {
                    d500Data &= ~(1 << i); // Clear corresponding bit in D500
                }
            }
        }
        #endregion

        #region UI Update
        // Update text boxes with current data
        private void UpdateTextBoxes(int d400Data, int d500Data, float d410Data, float d412Data)
        {
            tbD400_0.Text = ((d400Data >> 0) & 1).ToString();
            tbD400_1.Text = ((d400Data >> 1) & 1).ToString();
            tbD400_2.Text = ((d400Data >> 2) & 1).ToString();
            tbD400_3.Text = ((d400Data >> 3) & 1).ToString();
            tbD400_4.Text = ((d400Data >> 4) & 1).ToString();
            tbD400_5.Text = ((d400Data >> 5) & 1).ToString();
            tbD400_6.Text = ((d400Data >> 6) & 1).ToString();
            tbD400_7.Text = ((d400Data >> 7) & 1).ToString();

            tbD500_0.Text = ((d500Data >> 0) & 1).ToString();
            tbD500_1.Text = ((d500Data >> 1) & 1).ToString();
            tbD500_2.Text = ((d500Data >> 2) & 1).ToString();
            tbD500_3.Text = ((d500Data >> 3) & 1).ToString();
            tbD500_4.Text = ((d500Data >> 4) & 1).ToString();
            tbD500_5.Text = ((d500Data >> 5) & 1).ToString();
            tbD500_6.Text = ((d500Data >> 6) & 1).ToString();
            tbD500_7.Text = ((d500Data >> 7) & 1).ToString();

            tbD410.Text = d410Data.ToString("F4");
            tbD412.Text = d412Data.ToString("F2");
        }
        #endregion

        #region TextBox Input Formatting
        // Format text box input to a specified number of decimal places
        private void FormatTextBox(TextBox textBox, int decimalPlaces)
        {
            try
            {
                // 입력 값이 비어 있으면 기본값 "0.00" 설정
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = $"0.{new string('0', decimalPlaces)}";
                    return;
                }

                // 입력 값을 float으로 변환
                float value = float.Parse(textBox.Text);

                // 지정된 소수점 자리수만큼 포맷팅
                textBox.Text = value.ToString($"F{decimalPlaces}");
            }
            catch
            {
                // 오류가 발생하면 기본값 "0.00" 설정
                textBox.Text = $"0.{new string('0', decimalPlaces)}";
            }
        }

        #endregion

        #region Writing Data to PLC
        // Write data to PLC (D510, D512, D514, D516, D518)
        private void WriteData(TextBox textBox, string device, int scaleFactor, int decimalPlaces)
        {
            try
            {
                int scaledValue = (int)(Math.Round(Convert.ToSingle(textBox.Text), decimalPlaces) * scaleFactor);
                short lowerWord = (short)(scaledValue & 0xFFFF); // Lower 16 bits
                short upperWord = (short)((scaledValue >> 16) & 0xFFFF); // Upper 16 bits

                plc.WriteDeviceBlock(device, 1, lowerWord); // Write lower word
                plc.WriteDeviceBlock($"{device[0]}{(int.Parse(device.Substring(1)) + 1)}", 1, upperWord); // Write upper word
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Button click events to write data to PLC
        private void btnWrite510_Click(object sender, EventArgs e) => WriteData(tbD510, "D510", 10000, 4);
        private void btnWrite512_Click(object sender, EventArgs e) => WriteData(tbD512, "D512", 100, 2);
        private void btnWrite514_Click(object sender, EventArgs e) => WriteData(tbD514, "D514", 100, 2);
        private void btnWrite516_Click(object sender, EventArgs e) => WriteData(tbD516, "D516", 100, 2);
        private void btnWrite518_Click(object sender, EventArgs e) => WriteData(tbD518, "D518", 100, 2);
        #endregion
    }
}