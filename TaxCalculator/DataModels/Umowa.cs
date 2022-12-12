using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.DataModels
{
    abstract class Umowa
    {
        protected Dictionary<string, Tuple<string, float>> dict;

        public Dictionary<string, Tuple<string, float>> PobierzSkladki()
        {
            return dict;
        }
    }
}
