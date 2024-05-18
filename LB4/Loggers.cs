namespace LB4
{
    namespace Loggers
    {
        interface ILogger
        {
            void Start();
            void Log(String message);
            void End();
        }

        class ConsoleLogger : ILogger
        {
            public void Log(String message)
            {
                Console.WriteLine(message);
            }

            public void Start()
            {
                Log("Начал запись");
            }

            public void End()
            {
                Log("Закончил запись");
            }
        }

        class FileLogger : ILogger
        {
            private StreamWriter _fileStream;
            public FileLogger()
            {
                File.Create("log.txt").Close();
                _fileStream = new StreamWriter("log.txt");
            }
            public FileLogger(String filePath)
            {
                File.Create(filePath).Close();
                _fileStream = new StreamWriter(filePath);
            }

            public void Log(String message)
            {
                _fileStream.WriteLine(message);
            }

            public void Start()
            {
                Log("Начал запись");
            }

            public void End()
            {
                Log("Закончил запись");
                _fileStream.Close();
            }
        }
    }
}