using System;
using System.Collections.Generic;
using System.IO;

namespace DOT_Number_Reading
{
    public class Logger
    {
        private string LogDirectoryPath; //log saved path
        private int logCountThreshold; // Number of logs required before writing to a file
        private int LogCount; //log count
        private List<string> logBuffer; //Buffer to store log entries before writing to a file
        private int logFileIndex;

        // Delegate to update UI
        public Action<string> UpdateLogUI { get; set; }

        public Logger(string logDirectoryPath, int logCountThreshold = 10)
        {
            this.LogDirectoryPath = logDirectoryPath;
            this.logCountThreshold = logCountThreshold;
            this.LogCount = 0;//Initialize log count
            this.logBuffer = new List<string>();
            this.logFileIndex = 1; // Start log file indexing from 1

            // Ensure the log directory exists and is a directory
            EnsureLogDirectory();
        }

        // Ensure log directory exists and is not a file
        private void EnsureLogDirectory()
        {
            // Check if a file exists with the same name as the directory
            if (File.Exists(LogDirectoryPath))
            {
                throw new IOException($"A file with the name {LogDirectoryPath} already exists. Please use a different directory path.");
            }

            // Create directory if it doesn't exist
            if (!Directory.Exists(LogDirectoryPath))
            {
                Directory.CreateDirectory(LogDirectoryPath);
            }
        }

        // Add log message to buffer and check if it needs to be flushed
        public void LogMessage(string message, bool isSystemLog = false)
        {
            string trimmedMessage = message.Trim();
            string timestamp = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}";
            string logEntry;

            // If it's a system log, use '>>'
            if (isSystemLog)
            {
                logEntry = $"{timestamp} >> {trimmedMessage}";
            }
            else
            {

                logEntry = $"{timestamp} > {trimmedMessage}";
            }

            // If message contains "Image saved to", add a new line and increment LogCount
            if (trimmedMessage.StartsWith("[TCP] Sent to server"))
            {
                logEntry += Environment.NewLine;
                LogCount++;
            }

            // Add log entry to buffer
            logBuffer.Add(logEntry);

            // Update UI
            UpdateLogUI?.Invoke(logEntry);

            // Save to a new file when the threshold is reached
            if (LogCount >= logCountThreshold)
            {
                FlushLogs();
            }
        }

        // Write the buffered logs to a file and clear the buffer
        public void FlushLogs()
        {
            if (logBuffer.Count > 0)
            {
                // Create a folder for the current date
                string dateFolder = Path.Combine(LogDirectoryPath, DateTime.Now.ToString("yyyy-MM-dd"));
                Directory.CreateDirectory(dateFolder);

                // Create a folder for the current hour
                string hourFolder = Path.Combine(dateFolder, DateTime.Now.ToString("HH"));
                Directory.CreateDirectory(hourFolder);

                // Generate the log file name
                string logFilePath = Path.Combine(
                    hourFolder,
                    $"{DateTime.Now:yyyyMMdd_HHmmss}_{logFileIndex:D3}"
                );

                File.AppendAllLines(logFilePath, logBuffer);
                logBuffer.Clear();
                LogCount = 0;
                logFileIndex++;
            }
        }
    }
}