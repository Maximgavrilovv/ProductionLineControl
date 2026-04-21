using ProductionLineControl.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionLineControl.Models
{
    public static class ModelCatalog
    {
        public static Dictionary<Manufacturer, List<string>> Models = new()
        {
            [Manufacturer.SchneiderElectric] = new()
        {
            "Altivar 320",
            "Altivar 630"
        },
            [Manufacturer.ABB] = new()
        {
            "ACS355",
            "ACS580"
        },
            [Manufacturer.Mitsubishi] = new()
        {
            "FR-D700",
            "FR-E800"
        }
        };
    }
}
