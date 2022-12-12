using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.DataModels
{
    internal class KosztyZdrowotne : Koszty
    {
        float podstawa;

        const float kwotaPomniejszajaca = 46.33f;

        public KosztyZdrowotne(float podstawa)
        {
            this.podstawa = podstawa;
            base.dict = new Dictionary<string, Tuple<string, float>>()
            {
                { "skladka9", new Tuple<string, float>("Składka zdrowotna 9%", ObliczSkladkeZdrowotna9())  },
                { "skladka7", new Tuple<string, float>("Składka zdrowotna 7.75%", ObliczSkladkeZdrowotna7())  },
                { "dochodowy", new Tuple<string, float>("Podatek dochodowy 18%", ObliczSkladkeZdrowotna7())  },
                { "skladkaUS", new Tuple<string, float>("Składka Urzędu Skarbowego", ObliczSkladkeUS()) }
            };
        }

        float ObliczSkladkeZdrowotna9()
        {
            return (podstawa * 9) / 100;
        }

        float ObliczSkladkeZdrowotna7()
        {
            return (podstawa * 7.75f) / 100;
        }

        float ObliczPodatekDochodowy()
        {
            return (podstawa * 18f) / 100;
        }

        float ObliczSkladkeUS()
        {
            return ObliczPodatekDochodowy() - ObliczSkladkeZdrowotna7() - kwotaPomniejszajaca;
        }

    }
}
