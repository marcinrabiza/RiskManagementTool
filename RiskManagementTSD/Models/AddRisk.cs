using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskManagementTSD.Models
{
    public class AddRisk
    {
        public string Name{ get; set; }
        public string Description { get; set; }
        public bool? Probability { get; set; }
        public bool? Impact { get; set; }
        public int Score { get; set; }
    }
}
