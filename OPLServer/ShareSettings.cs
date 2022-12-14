using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OPLServer
{
    public class ShareSettings
    {
        public string ShareName;
        public string SharePath;
        public List<string> ReadAccess;
        public List<string> WriteAccess;

        public ShareSettings(string shareName, string sharePath, List<string> readAccess, List<string> writeAccess)
        {
            ShareName = shareName;
            SharePath = sharePath;
            ReadAccess = readAccess;
            WriteAccess = writeAccess;
        }
    }
}
