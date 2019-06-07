using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskManagementTSD.Models.Context
{
    public class Risk
    {
        public int RiskId { get; set; }
        public string RiskAuthor { get; set; }
        public DateTime RaisedDateTime { get; set; }
        public string RiskCategory { get; set; }
        public string Description { get; set; }
    }
}