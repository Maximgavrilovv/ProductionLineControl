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
}
