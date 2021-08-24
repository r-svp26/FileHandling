using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    [Serializable]
    class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationID { get; set; } = 1000;
    }
}
