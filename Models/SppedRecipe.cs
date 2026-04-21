using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Models
{
    public class SpeedRecipe
    {
        public string Name { get; set; }

        public List<Motor> Motors { get; set; } = new();
    }

    public class SpeedEntry
    {
        public string MotorName { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
    }
}
