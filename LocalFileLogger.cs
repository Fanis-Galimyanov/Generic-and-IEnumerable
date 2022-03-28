 internal class LocalFileLogger<T> : ILogger
    {
        private readonly string _path;
        internal LocalFileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message, Exception ex)
        {
            WriteToFile($"[Error]: [{typeof(T).Name}] : {message} . {ex.Message}");
        }
        public void LogInfo(string message)
        {
            WriteToFile($"[Info]: [{typeof(T).Name}] : {message}"); 
        }
        public void LogWarning(string message)
        {
            WriteToFile($"[Warning]: [{typeof(T).Name}] : {message}");
        }
        void WriteToFile(string line)
        {
             using (StreamWriter writer = new StreamWriter(_path, true))
             {
                writer.WriteLine(line);
             }
        }
}
