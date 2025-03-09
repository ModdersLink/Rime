using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;

namespace Rime.Utils
{
    internal class Logger
    {
        public class FixedConcurrentQueue<T> : ConcurrentQueue<T>
        {
            private readonly object m_lock = new object();

            public int Size { get; private set; }

            public FixedConcurrentQueue(int p_Size) 
            {
                Size = p_Size;
            }

            public new void Enqueue(T p_Object)
            {
                base.Enqueue(p_Object);
                lock (m_lock)
                {
                    while (base.Count > Size)
                    {
                        base.TryDequeue(out T? p_Result);
                    }
                }
            }
        }

        public enum LogLevel
        {
            Info,
            Warn,
            Error,
            Debug
        }

        public struct LogEntry
        {
            public LogLevel Level;
            public string Message;
        }

        /// <summary>
        /// Maximum number of logs to keep in rotation
        /// </summary>
        public const int c_MaxLogs = 2048;

        /// <summary>
        /// Current logging level
        /// </summary>
        public LogLevel LoggingLevel { get; set; }

        /// <summary>
        /// File to write logs to
        /// </summary>
        public string? LoggingFile { get; set; }

        // The fixed queue of logs
        protected FixedConcurrentQueue<LogEntry> m_Entries;

        public Logger(LogLevel p_LogLevel, string? p_File = null)
        {
            // Set the logging level
            LoggingLevel = p_LogLevel;
            LoggingFile = p_File;
            m_Entries = new FixedConcurrentQueue<LogEntry>(c_MaxLogs);
        }

        public void WriteLog(LogLevel p_Level, string p_Message)
        {
            var s_Text = $"[{p_Level}] [{DateTime.Now}] - {p_Message}";

            if (LoggingFile is not null)
                File.AppendText(s_Text);

            m_Entries.Enqueue(new LogEntry
            { 
                Level = p_Level, 
                Message = p_Message 
            });

#if DEBUG
            Debug.WriteLine(s_Text);
#else
            Console.WriteLine(s_Text);
#endif
        }
    }
}
