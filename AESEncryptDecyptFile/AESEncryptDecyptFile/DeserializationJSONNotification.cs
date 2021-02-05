using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESEncryptDecyptFile
{
    public class DeserializationJSONNotification
    {
        public string title_form { get; set; }
        public string lblNotification { get; set; }
        public string rtbNotificationDescription { get; set; }
        public bool btnNextOrOKEnabled { get; set; }
        public string btnNextOrOK { get; set; }
        public string actionOfBtnNextOrOK { get; set; }
    }
}
