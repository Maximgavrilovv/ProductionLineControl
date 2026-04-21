using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Interfaces
{
    public interface IDeviceConnection
    {
        void Connect();
        void Disconnect();
        void SendSpeed(double value);
    }
}
