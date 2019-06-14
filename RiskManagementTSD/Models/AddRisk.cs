using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskManagementTSD.Models
{
    
    public class AddRisk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Probability { get; set; }
        public int? Impact { get; set; }
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
               if (Probability == null || Impact == null)
                    _score = 0; 
               else
                    _score = Probability * Impact;
            }
        }
       

    }
}
