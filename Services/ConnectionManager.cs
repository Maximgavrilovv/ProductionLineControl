using ProductionLineControl.Interfaces;
using ProductionLineControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Services
{
    public class ConnectionManager
    {
        private readonly Dictionary<Guid, IDeviceConnection> _connections = new();

        public void CreateConnection(Motor motor)
        {
            var connection = new DeviceConnection
            {
                Id = motor.Id
            };

            connection.Connect();

            _connections[motor.Id] = connection;
        }

        public IDeviceConnection? Get(Guid motorId)
        {
            return _connections.TryGetValue(motorId, out var conn)
                ? conn
                : null;
        }

        public void Disconnect(Motor motor)
        {
            _connections.TryGetValue(motor.Id, out var conn);

            if (conn != null)
            {
                conn.Disconnect();
                _connections.Remove(motor.Id);
            }
        }
    }
}
