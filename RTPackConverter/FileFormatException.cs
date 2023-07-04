using System;

namespace RTPackConverter
{
    public class FileFormatException : Exception
    {
        public FileFormatException() : base() {}
        public FileFormatException(string msg ) : base(msg) {}
    }
}
