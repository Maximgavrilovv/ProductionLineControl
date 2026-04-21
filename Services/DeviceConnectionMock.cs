using ProductionLineControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Services
{
    public class DeviceConnectionMock : IDeviceConnection
    {
        public void Connect()
        {
            // TODO: Implement connection
        }

        public void Disconnect()
        {

        }

        public void SendSpeed(double value)
        {
            // TODO: Send to device
        }
    }
}
