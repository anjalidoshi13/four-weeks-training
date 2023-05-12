namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var logger = new FileLogger("log.txt"))
            {
                logger.Log("This is a log message.");
                logger.Log("This is another log message.");
            }
        }
    }
    class FileLogger : IDisposable
    {
        private StreamWriter _writer;
        public FileLogger(string filePath)
        {
            _writer = new StreamWriter(filePath);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_writer != null)
                {
                    _writer.Dispose();
                    _writer = null;
                }
            }
        }
        public void Log(string message)
        {
            {
                _writer.WriteLine($"{DateTime.UtcNow}: {message}");
                _writer.Flush();
            }
        }
    }
}