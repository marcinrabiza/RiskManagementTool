using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskManagementTSD.Models
{
    public enum Scaled
    {
        L, M, H
    }
    public class AddRisk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Scaled? Probability { get; set; }
        public Scaled? Impact { get; set; }
        public int Score { get; set; }
    }
}
