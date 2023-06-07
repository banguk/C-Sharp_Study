using System;
namespace Method_1
{
    public class BasicMethod
    {
        public BasicMethod()
        {
        }

        // 값 매개변수 메서드 예제
        public string Combine(string _driveLetter, string _folderPath, string _fileName)
        {
            string path;
            path = string.Format("{1}{0}{2}{0}{3}", System.IO.Path.DirectorySeparatorChar, _driveLetter, _folderPath, _fileName);
            return path;
        }
    }
}

