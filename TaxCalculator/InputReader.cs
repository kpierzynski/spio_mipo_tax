using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator {

    public class InputReaderData {
        public float podstawa {
            get; set;
        }
        public char typ {
            get; set;
        }
    }

    internal class InputReader {
        public InputReaderData ReadInput( ) {
            try {
                Console.WriteLine( "Podaj podstawę:" );
                string? input = Console.ReadLine( );
                float value = float.Parse( input );

                Console.WriteLine( "Podaj typ:" );
                input = Console.ReadLine( );
                char chr = input.First( );

                return new InputReaderData { podstawa = value, typ = chr };
            } catch (Exception e) {
                throw new Exception( "Podane dane są nieprawidłowe." );
            }
        }
    }
}
