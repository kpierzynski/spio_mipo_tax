using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.DataModels;

namespace TaxCalculator
{
    internal class Writer
    {
        public void PrezentujKoszty( Umowa koszty )
        {
            foreach( var (key,(nazwa, wartosc)) in koszty.PobierzSkladki() )
            {
                Console.WriteLine("Nazwa: {0}, wartość: {1:0.00}", nazwa, wartosc);
            }
        }
    }
}
