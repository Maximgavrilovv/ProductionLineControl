using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Models
{
    public class ConnectionSettings
    {
        // Ethernet
        public string IpAddress { get; set; }
        public int Port { get; set; }

        // Serial
        public string ComPort { get; set; }
        public int BaudRate { get; set; }
    }
}
