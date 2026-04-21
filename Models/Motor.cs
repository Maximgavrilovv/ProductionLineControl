using ProductionLineControl.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Models
{
    public class Motor
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public string Model { get; set; }

        public ConnectionType ConnectionType { get; set; }

        public Enums.ProtocolType ProtocolType { get; set; }

        public ConnectionSettings Settings { get; set; } = new();

        // Telemetry
        public double CurrentSpeed { get; set; }
        public double TargetSpeed { get; set; }
        public double Current { get; set; }
        public double Voltage { get; set; }
        public string Status { get; set; }
    }
}
