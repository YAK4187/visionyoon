using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using MetroFramework.Forms;

namespace DOT_Number_Reading
{
    
    public partial class frmMain : MetroForm
    {
        #region Fields and Properties
        // Main objects for the application
        private UDPClient udpClient;
        private UDPServer udpServer;
        private ImageHandler imageHandler;
        private ConfigManager configManager;
        private Logger logger;
        private PLCManager plcManager;
        private Timer plcTimer;
        private Timer heartBeatTimer;
        private Button lastClickedButton;
        private bool isLoggedIn = false;
        private bool isLoading = true;
        public event Action InspectionCompleted;//추가


        // File paths for log, job, and EyeVision files
        private const string logFilePath = @"C:\DOTNumberReading\log";
        private const string jobFilePath = @"C:\ProgramData\EVT\EyeVision\Projects\PC_Local\Programs";
        private const string lastJobFilePath = @"C:\DOTNumberReading\lastJobfile.tmp";
        private const string eyeVisionPath = @"C:\Program Files\EVT\EyeVision_V4_4_006\bin\EyeVision.exe";

        // Heartbeat status
        private bool heartBitStatus = false;

        //SFCS TCP
        private TCPServer tcpServer;
        private TCPClient tcpClient;

        #endregion

        #region External DLL Import
        // Import external DLL for window control
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        #endregion

        #region Constructor
        // Constructor for frmMain form
        public frmMain()
        {
            // Show loading form in a separate thread
            frmLoading loadingForm = new frmLoading();
            Task.Run(() =>
            {
                Application.Run(loadingForm);
            });

            // Initialise components and perform setup on the main thread
            InitializeComponent();
            InitialiseApplication();

            // Close loading form after initialisation
            if (loadingForm != null && !loadingForm.IsDisposed)
            {
                loadingForm.Invoke(new Action(() => loadingForm.Close()));
            }
        }
        #endregion

        #region Initialisation Methods
        // Initialize the application and set up components
        private void InitialiseApplication()
        {
            // Set up logger and UI update delegate
            logger = new Logger(logFilePath);
            logger.UpdateLogUI = UpdateLogDisplay;

            // Initialise configuration manager
            configManager = new ConfigManager(lastJobFilePath);

            // Set up UDP client and server
            udpClient = new UDPClient("127.0.0.1", 5952);
            imageHandler = new ImageHandler();
            udpServer = new UDPServer(5000, SetText, logger);
            udpServer.StartReceiving();

            StartEVT();

            // Initialise PLCManager
            plcManager = new PLCManager();

            // Connect to PLC
            if (plcManager.Connect())
            {
                logger.LogMessage("PLC connected successfully", true);
            }
            else
            {
                logger.LogMessage("Failed to connect to PLC", true);
            }

            // Set up timers for PLC and vision heartbeat
            SetupTimers();

            // Initialise buttons and load last clicked button state
            InitialiseButtons();
            LoadLastClickedButton();

            upDownParameter.Visible = false;
            btnOK.Visible = false;

            isLoading = false;
        }

        private void SetupTimers()
        {
            // Setup timer to check PLC
            plcTimer = new System.Windows.Forms.Timer();
            plcTimer.Interval = 1000;
            plcTimer.Tick += CheckPLC;
            plcTimer.Start();

            // Setup timer for vision heartbeat
            heartBeatTimer = new System.Windows.Forms.Timer();
            heartBeatTimer.Interval = 1000;
            heartBeatTimer.Tick += VisionHeartbeat;
            heartBeatTimer.Start();
        }
        #endregion

        #region PLC Status Check and Control
        private void CheckPLC(object sender, EventArgs e)
        {
            bool[] bits;

            // Read bit data from D400
            if (plcManager.ReadBitData("D400", out bits))
            {
                // Sync D400.1 to D400.7 with D500.1 to D500.7
                for (int i = 1; i <= 7; i++)
                {
                    plcManager.WriteBitData("D500", i, bits[i]); // Sync D500 with D400
                }

                // Update UI for D400.0 to D400.3 
                for (int i = 0; i <= 3; i++)
                {
                    UpdateUI(i, bits[i]);
                }
            }
        }

        // Update UI based on the PLC status

        private void UpdateUI(int index, bool status)
        {
            // Ensure UI updates happen on UI thread
            Invoke(new Action(() =>
            {
                switch (index)
                {
                    case 0: // D400.0 (Heartbeat)
                        UpdateButtonImage(btnPLCHeart, status);
                        break;

                    case 1: // D400.1
                        UpdateButtonImage(btnPLCReady, status);
                        UpdateButtonImage(btnVisionReady, status);
                        break;

                    case 2: // D400.2
                        UpdateButtonImage(btnPLCStart, status);
                        UpdateButtonImage(btnVisionStart, status);
                        if (status)
                        {
                            btnSnapshot_Click(this, EventArgs.Empty); // Trigger snapshot
                        }
                        break;

                    case 3: // D400.3
                        UpdateButtonImage(btnPLCEnd, status);
                        UpdateButtonImage(btnVisionEnd, status);
                        break;
                }
            }));
        }

        // Update button images based on status
        private void UpdateButtonImage(Button button, bool status)
        {
            if (status)
            {
                button.BackgroundImage = Properties.Resources.heartbeat_on;
            }
            else
            {
                button.BackgroundImage = Properties.Resources.heartbeat_off;
            }
        }

        // Vision heartbeat
        private void VisionHeartbeat(object sender, EventArgs e)
        {
            // Toggle heartBitStatus (1 -> 0 -> 1 -> 0, etc.)
            heartBitStatus = !heartBitStatus;

            // Write value to D500.0
            plcManager.WriteBitData("D500", 0, heartBitStatus);

            // Update button colour on UI thread
            Invoke(new Action(() =>
            {
                if (heartBitStatus)
                {
                    btnVisionHeart.BackgroundImage = Properties.Resources.heartbeat_on;
                }
                else
                {
                    btnVisionHeart.BackgroundImage = Properties.Resources.heartbeat_off;
                }
            }));
        }
        #endregion

        #region Button Initialisation
        // Initialise button states and event handlers
        private void InitialiseButtons()
        {
            // Set job file paths as button tags
            btnJobfile1.Tag = Path.Combine(jobFilePath, "OCR_1.ckp");
            btnJobfile2.Tag = Path.Combine(jobFilePath, "OCR_2.ckp");
            btnJobfile3.Tag = Path.Combine(jobFilePath, "OCR_3.ckp");

            // Add event handlers for button clicks
            btnJobfile1.Click += btnJobChange_Click;
            btnJobfile2.Click += btnJobChange_Click;
            btnJobfile3.Click += btnJobChange_Click;
            btnJobChange.Click += btnJobChange_Click;

            UpdateButtonStates();
        }
        #endregion

        #region Last Clicked Button Management
        // Load the last clicked button and update its state
        private void LoadLastClickedButton()
        {
            string lastClickedButtonName = configManager.LoadConfig();
            if (!string.IsNullOrEmpty(lastClickedButtonName))
            {
                // Find the button using the name
                lastClickedButton = Controls.Find(lastClickedButtonName, true).FirstOrDefault() as Button;
                if (lastClickedButton != null)
                {
                    lastClickedButton.BackColor = Color.DarkOrange;
                    lastClickedButton.Enabled = true;

                    // Get the job file path from the button's Tag
                    string currentJobFilePath = lastClickedButton.Tag?.ToString();
                    if (!string.IsNullOrEmpty(currentJobFilePath))
                    {
                        string fileName = Path.GetFileName(currentJobFilePath);
                        logger.LogMessage($"Job file loaded: {fileName}", true);
                    }
                }
                else
                {
                    logger.LogMessage("Error: EyeVision is not ready. Please check the system and try again.", true);
                }
            }
        }
        #endregion

        #region EyeVision Management
        // Start EyeVision
        private void StartEVT()
        {
            // Check if the EyeVision executable exists
            if (!File.Exists(eyeVisionPath)) return;

            // Configure process start information
            var startInfo = new ProcessStartInfo
            {
                FileName = eyeVisionPath,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
            };

            try
            {
                // Start the process
                var process = Process.Start(startInfo);
                if (process == null) return; // Exit if the process failed to start

                // Wait for the process to be ready
                process.WaitForInputIdle();

                IntPtr hwnd = process.MainWindowHandle;

                if (hwnd != IntPtr.Zero)
                {
                    ShowWindow(hwnd, 0); // Hide the window
                    logger.LogMessage("EyeVision started successfully", true);
                }
            }
            catch (Exception ex)
            {
                logger.LogMessage($"Error starting EyeVision: {ex.Message}", true);
            }
        }
        #endregion

        #region Button Click Handlers
        // Change job file
        private void btnJobChange_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = (Button)sender;

                // When a job file button (not the job change button) is clicked
                if (clickedButton != btnJobChange)
                {
                    lastClickedButton = clickedButton;
                    configManager.SaveConfig(clickedButton.Name); // Save the clicked button's name

                    string currentJobFilePath = (string)clickedButton.Tag; // Get job file path from button tag
                    string fileName = Path.GetFileName(currentJobFilePath);
                    string command = $"#001{fileName}#"; // Command for EyeVision PconLAN

                    logger.LogMessage($"Sending command: {command}", true);
                    udpClient.SendCommand(command); // Send the command via UDP

                    logger.LogMessage($"Job file changed to: {fileName}", true);
                }

                UpdateButtonStates(clickedButton);
            }
            catch (Exception ex)
            {
                logger.LogMessage($"Error in btnJobChange_Click: {ex.Message}", true);
            }
        }

        // Start inspection and display image 
        private async void btnSnapshot_Click(object sender, EventArgs e)
        {
            try
            {
                logger.LogMessage("Inspection started");
                progressSpinner.Visible = true;
                lblProgress.Visible = true;

                udpClient.SendCommand("#028;1#"); // Command to start inspection; "1" for one-time execution
                await Task.Delay(2000); // Wait 2 seconds for image saving
                await Task.Run(() => imageHandler.DisplayImage(pbImage));

                progressSpinner.Spinning = false;
                lblProgress.Visible = true;
                lblProgress.Text = "검사 완료!";
                lblProgress.ForeColor = Color.Lime;

                // 검사 완료 후 VIN과 DOT 전송
                SendVinAndDotToServer();
            }
            catch (Exception ex)
            {
                logger.LogMessage($"Error: {ex.Message}", true);
            }
        }
        #endregion

        #region UI Updates
        // Update log message on UI thread
        private void UpdateLogDisplay(string message)
        {
            // Ensure UI thread safety
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action<string>(UpdateLogDisplay), message);
            }
            else
            {
                txtLog.AppendText(message + Environment.NewLine);
            }
        }

        // Update button states based on the clicked button
        private void UpdateButtonStates(Button clickedButton = null)
        {
            Color activeColor = Color.DarkOrange;
            Color inactiveColor = Color.Gray;

            // Reset button states
            btnJobfile1.Enabled = false;
            btnJobfile2.Enabled = false;
            btnJobfile3.Enabled = false;
            btnJobfile1.BackColor = inactiveColor;
            btnJobfile2.BackColor = inactiveColor;
            btnJobfile3.BackColor = inactiveColor;

            // Update clicked button's state
            if (clickedButton == btnJobChange)
            {
                btnJobfile1.Enabled = true;
                btnJobfile2.Enabled = true;
                btnJobfile3.Enabled = true;
            }
            else if (clickedButton != null)
            {
                clickedButton.Enabled = true;
                clickedButton.BackColor = activeColor;
            }
        }

        //변경
        private void SetText(string text)
        {
            if (txtDOT.InvokeRequired)
            {
                txtDOT.Invoke(new Action<string>(SetText), text);
            }
            else
            {
                // DOT 값 설정
                txtDOT.Text = text;
                logger.LogMessage($"Result: {text}");
                logger.LogMessage(@"Image saved to: C:\DOTNumberReading\img\test\Result");

                {                 
                    TriggerInspectionCompleted(); // 검사 완료 이벤트 호출
                };

            }
        }

        // Toggle visibility of the log
        private void btnLog_Click(object sender, EventArgs e)
        {
            txtLog.Visible = !txtLog.Visible;
            btnLog.Text = txtLog.Visible ? "로그 숨기기" : "로그 보기";
        }

        // Handle when the DOT input field gains focus
        private void txtWriteDOT_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtWriteDOT.Text == "타이어 DOT 번호를 입력하세요")
            {
                txtWriteDOT.Text = "";
                txtWriteDOT.ForeColor = Color.Yellow;
            }
        }

        // Handle when the DOT input field loses focus
        private void txtWriteDOT_Leave(object sender, EventArgs e)
        {
            if (txtWriteDOT.Text == "")
            {
                txtWriteDOT.Text = "타이어 DOT 번호를 입력하세요";
                txtWriteDOT.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region Login Functionality 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin
            {
                TopMost = true
            };

            loginForm.Show();
            loginForm.FormClosed += (s, args) =>
            {
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    isLoggedIn = true;

                    upDownParameter.Visible = true;
                    btnOK.Visible = true;
                    lblEdit.Visible = true;

                    this.Activate(); // 메인 폼 활성화
                }
                else
                {
                    // 로그인 실패 시에도 메인 폼 활성 상태 유지
                    isLoggedIn = false;
                    MessageBox.Show("로그인 실패!", "실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };
        }
        #endregion

        #region Parameter Adjustment
        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal thresholdValue = upDownParameter.Value;
            decimal maxThreshold = 1;

            Console.WriteLine($"Threshold Value: {thresholdValue}, Max Threshold: {maxThreshold}");

            if (thresholdValue > maxThreshold)
            {
                MessageBox.Show($"설정값을 초과했습니다. 최대값은 {maxThreshold}입니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string command = $"#030;1;DL OCR.ConfidenceThresh;{thresholdValue}#";

            try
            {
                Console.WriteLine($"Sending command: {command}");
                udpClient.SendCommand(command);

                MessageBox.Show("변경 성공!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"변경 실패: {ex.Message}", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SFCS TCP

        private void StartInspection()
        {
            txtDOT.Text = ""; // Initialize the DOT value

            // Start inspection via UDP command
            udpClient.SendCommand("#028;1#"); // One-time execution command for EyeVision

            // Wait for the inspection results and update the UI
            Task.Run(async () =>
            {
                await Task.Delay(2000); // Wait for 2 seconds (simulate inspection or perform actual work)
                SetText("Sample DOT Result"); // Update the inspection results to the UI
            });
        }

        private void TriggerInspectionCompleted()
        {
            InspectionCompleted?.Invoke(); // Trigger the event when the inspection is completed
        }

        private bool IsInspectionComplete()
        {
            // Check if txtVIN and txtDOT have values
            return !string.IsNullOrWhiteSpace(txtVIN.Text) && !string.IsNullOrWhiteSpace(txtDOT.Text);
        }

        private void CheckAndSendData()
        {
            // Check whether the inspection is complete
            if (!string.IsNullOrWhiteSpace(txtVIN.Text) && !string.IsNullOrWhiteSpace(txtDOT.Text))
            {
                SendVinAndDotToServer(); // Send data if all values are set
            }
            else
            {
                Console.WriteLine("[DEBUG] VIN or DOT value is not yet set. Waiting to send data...");
            }
        }

        private void OnInspectionCompleted()
        {
            Console.WriteLine("[DEBUG] Inspection completed. Preparing to send data...");

            // Retrieve the latest values from the text boxes
            string vin = txtVIN.Text;
            string dot = txtDOT.Text;

            // Send data if the values are not empty
            if (!string.IsNullOrWhiteSpace(vin) && !string.IsNullOrWhiteSpace(dot))
            {
                SendVinAndDotToServer();
            }
            else
            {
                Console.WriteLine("[DEBUG] VIN or DOT value is empty. Skipping data transmission.");
            }
        }

        // Send data via TCP
        private void SendVinAndDotToServer()
        {
            string vin = txtVIN.Text;
            string dot = txtDOT.Text;

            if (!string.IsNullOrWhiteSpace(vin) && !string.IsNullOrWhiteSpace(dot))
            {
                string combinedData = $"VIN: {vin}, DOT: {dot}";
                logger.LogMessage($"Data sent: {combinedData}");
                // TCP transmission logic can be added here
            }
            else
            {
                Console.WriteLine("[DEBUG] VIN or DOT value is empty. Skipping data transmission.");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Initialize the TCP server and client
            InitialiseTCPServer();
            InitialiseTCPClient();

            // Connect the event handler for inspection completion
            InspectionCompleted += OnInspectionCompleted;
        }
        // Initialize the TCP server
        private void InitialiseTCPServer()
        {
            tcpServer = new TCPServer(
                data =>
                {
                    // Display received data in the console
                    Invoke(new Action(() =>
                    {
                        // 여기에 수신 데이터 처리 로직 추가 가능
                    }));
                },
                message =>
                {
                    // Display server messages in the console
                    Invoke(new Action(() =>
                    {
                        Console.WriteLine($"[DEBUG] TCP Server Message: {message}");
                    }));
                });

            // Start the TCP server
            tcpServer.Start("127.0.0.1", 6000); // Specify the desired port number
        }

        private void InitialiseTCPClient()
        {
            tcpClient = new TCPClient(
                data =>
                {
                    // Handle data received from the server
                    Invoke(new Action(() =>
                    {
                        // 여기에 클라이언트 데이터 처리 로직 추가 가능
                    }));
                });

            // Connect the TCP client to the server
            if (tcpClient.Connect("127.0.0.1", 6000)) // Specify the server address and port number
            {
                Console.WriteLine("[DEBUG] TCP Client connected successfully.");
            }
            else
            {
                Console.WriteLine("[DEBUG] TCP Client connection failed.");
            }
        }
        #endregion

        #region Form closing
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string processName = "EyeVision.exe";

            // Terminate the EyeVision process
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = "taskkill", // Command to terminate the process
                    Arguments = $"/IM {processName} /F", // Specify the process name and force termination
                    WindowStyle = ProcessWindowStyle.Hidden, // Hide the command window
                    CreateNoWindow = true // Do not create a command window
                };

                Process.Start(startInfo); // Execute the process termination command
            }
            catch (Exception ex)
            {
                // Show a message box if an error occurs while terminating the process
                MessageBox.Show("An error occurred while terminating the process: " + ex.Message);
            }

            // Stop the TCP server
            try
            {
                tcpServer?.Stop(); // Safely stop the server if it exists
            }
            catch (Exception ex)
            {
                // Log any error that occurs while stopping the TCP server
                Console.WriteLine("[ERROR] Failed to stop TCP Server: " + ex.Message);
            }

            // Disconnect the TCP client
            try
            {
                tcpClient?.Disconnect(); // Safely disconnect the client if it exists
            }
            catch (Exception ex)
            {
                // Log any error that occurs while disconnecting the TCP client
                Console.WriteLine("[ERROR] Failed to disconnect TCP Client: " + ex.Message);
            }
        }
        #endregion
    }
}