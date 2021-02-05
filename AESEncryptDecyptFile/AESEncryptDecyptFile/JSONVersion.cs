using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESEncryptDecyptFile
{
    public class JSONVersion
    {
        public string name { get; set; }
        public string version { get; set; }
        public string user_agent { get; set; }
        public string need_to_update { get; set; }
        public int priority_update_important { get; set; }
        public string description_updates { get; set; }
    }
}
