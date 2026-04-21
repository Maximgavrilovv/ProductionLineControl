using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Enums
{
    public enum Manufacturer
    {
        SchneiderElectric,
        ABB,
        Mitsubishi
    }

    public enum ConnectionType
    {
        Ethernet,
        Serial
    }

    public enum ProtocolType
    {
        ModbusRtu,
        ModbusTcp,
        Custom
    }
}
