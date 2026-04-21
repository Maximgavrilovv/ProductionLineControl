using ProductionLineControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Services
{
    public class DeviceConnection : IDeviceConnection
    {
        public Guid Id { get; set; }
        public void Connect()
        {
            // TODO
        }

        public void Disconnect()
        {
            // TODO
        }

        public void SendSpeed(double value)
        {
            // TODO
        }
    }
}
