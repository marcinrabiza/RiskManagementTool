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
        public int? Probability {

            get
            {
                return _probability;
            }
            set
            {
                _probability = value;
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
                _impact = value;
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
               if (_probability == null || _impact == null)
                    _score = 0; 
               else
                    _score = _probability * _impact;
            }
        }
       

    }
}
