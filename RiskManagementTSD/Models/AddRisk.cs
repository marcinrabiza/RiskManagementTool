using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskManagementTSD.Models
{
    
    public class AddRisk
    {
        private int _score;
        private int _impact;
        private int _probability;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Probability
        {

            get
            {
                return _probability;
            }
            set
            {
                if (Probability.HasValue)
                    _probability = Probability.Value;
                else
                    _probability = 0;
            }
        }
        public int? Impact
        {

            get
            {
                return _impact;
            }
            set
            {
                if (Impact.HasValue)
                    _impact = Impact.Value;
                else
                    _impact = 0; 
            }
        }


        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
               if (_probability == 0 || _impact == 0)
                    _score = 0; 
               else
                    _score = _probability * _impact;
            }
        }
       

    }
}
