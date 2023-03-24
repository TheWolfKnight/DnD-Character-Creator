using System;
using System.IO;
using System.Windows.Forms;

using Abstraction.Interface;

namespace DnD_Charactor_Creator.Src.Services
{
    public class LoggingService : ISingleton<LoggingService>
    {
        private static LoggingService _Instance { get; set; } = null!;

        private readonly string _PATH = Path.Combine(Environment.CurrentDirectory, "logs/logging.log");

        public bool LoggingAvaliable = true;

        private LoggingService() {
            if (!Path.Exists(_PATH))
            {
                string? loggingPathDirectory = Path.GetDirectoryName(_PATH);
                if (loggingPathDirectory == null)
                {
                    MessageBox.Show($"You were unable to create a logging folder.{Environment.NewLine}Procced at own risk!", "WARRNING", MessageBoxButtons.OK);
                    return;
                }
                Directory.CreateDirectory(loggingPathDirectory);
                File.Create(_PATH);
            }

        }

        public static LoggingService Instance()
        {
            if (_Instance == null)
                _Instance = new LoggingService();
            return _Instance;
        }

        public void Info(string content)
        {
            if (!LoggingAvaliable)
                return;

            using (StreamWriter writer = new StreamWriter(_PATH, true))
            {
                DateTime now = DateTime.Now;
                writer.WriteLine($"[{now.Date}:{now.TimeOfDay}] INFO: {content}");
            }
        }

        public void Warrning(string content)
        {
            if (!LoggingAvaliable)
                return;

            using (StreamWriter writer = new StreamWriter(_PATH, true))
            {
                DateTime now = DateTime.Now;
                writer.Write($"[{now.Date}:{now.TimeOfDay}] WARRNING: {content}");
            }
        }

        public void Error(string content)
        {
            if (!LoggingAvaliable)
                return;

            using (StreamWriter writer = new StreamWriter(_PATH, true))
            {
                DateTime now = DateTime.Now;
                writer.Write($"[{now.Date}:{now.TimeOfDay}] ERROR: {content}");
            }
        }
    }
}
