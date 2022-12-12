// See https://aka.ms/new-console-template for more information
using TaxCalculator;
using TaxCalculator.DataModels;

Console.WriteLine("Hello, World!");

Koszty koszt = new KosztyZdrowotne(1000.0f);
new Writer().PrezentujKoszty(koszt);