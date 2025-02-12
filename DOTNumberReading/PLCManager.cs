using ActUtlTypeLib;

namespace DOT_Number_Reading
{
    public class PLCManager
    {
        private ActUtlType plc;
        private bool isConnected = false;

        // Constructor to initialize ActUtlType object
        public PLCManager()
        {
            plc = new ActUtlType();
        }

        // Connect to PLC
        public bool Connect()
        {
            plc.ActLogicalStationNumber = 0; // Set logical station number
            int result = plc.Open(); // Open connection to PLC

            if (result == 0)
            {
                isConnected = true;
                return true;
            }
            else
            {
                isConnected = false;
                return false;
            }
        }

        // Disconnect from PLC
        public bool Disconnect()
        {
            int result = plc.Close(); // Close connection to PLC
            if (result == 0)
            {
                isConnected = false;
                return true;
            }
            return false;
        }

        // Check connection status
        public bool IsConnected()
        {
            return isConnected;
        }

        // Read bit data from PLC
        public bool ReadBitData(string address, out bool[] bits)
        {
            bits = new bool[8]; // D400.0 to D400.7

            if (!isConnected) return false; // Check if PLC is connected

            int lplData;
            int ret = plc.ReadDeviceBlock(address, 1, out lplData); // Read data from specified address

            if (ret == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    bits[i] = (lplData & (1 << i)) != 0; // Extract individual bits
                }
                return true;
            }
            return false;
        }

        // Write bit data to PLC
        public bool WriteBitData(string address, int bitPosition, bool value)
        {
            if (!isConnected) return false;

            int lplData;

            // Read current data from PLC
            int ret = plc.ReadDeviceBlock(address, 1, out lplData);
            if (ret != 0) return false;

            // Modify bit at specified position
            if (value)
            {
                lplData |= (1 << (bitPosition)); // Set bit to 1
            }
            else
            {
                lplData &= ~(1 << (bitPosition)); // Set bit to 0
            }

            // Write modified data back to PLC
            ret = plc.WriteDeviceBlock(address, 1, lplData);
            return ret == 0;
        }

    }
}
