using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.DataModels
{
    internal class UmowaPraca : Umowa
    {
        float podstawa;

        public UmowaPraca( float podstawa )
        {
            this.podstawa = podstawa;
            base.dict = new Dictionary<string, Tuple<string, float>>()
            {
                { "skladkaEmerytalna", new Tuple<string, float>("Składka emerty", ObliczSkladkeEmerytalna()) },
            };

        }
        float ObliczSkladkeEmerytalna()
        {
           throw new NotImplementedException("Missing implementation of method."); 
        }

    }
}
