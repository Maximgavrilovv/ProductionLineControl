using ProductionLineControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Services
{
    public class MotorService
    {
        private readonly List<Motor> _motors = new();

        public List<Motor> GetAll() => _motors;

        public void Add(Motor motor)
        {
            _motors.Add(motor);
        }

        public void Update(Motor motor)
        {
            var existing = _motors.FirstOrDefault(x => x.Id == motor.Id);
            if (existing == null) return;

            _motors.Remove(existing);
            _motors.Add(motor);
        }

        public void Delete(Guid id)
        {
            var motor = _motors.FirstOrDefault(x => x.Id == id);
            if (motor != null)
                _motors.Remove(motor);
        }
    }
}
