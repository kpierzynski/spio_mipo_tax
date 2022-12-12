using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class InputReaderData
    {
        public float podstawa;
        public char typ;
    }


    internal class InputReader
    {
        public InputReaderData ReadInput()
        {
            try
            {
                string? input = Console.ReadLine();
                float value = float.Parse(input);

                input = Console.ReadLine();
                char chr = input.First();

                return (InputReaderData){ value, chr};
            }
            catch (Exception e)
            {
                throw new Exception("Invalid input. Could read proper input from user.");
            }
        }
    }
}
