﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
