using System;

namespace aula_1
{
  class Program
  {
    static void Main(string[] args)
    {
      double peso = Convert.ToDouble(Console.ReadLine());

      new CalcCategory(peso).CalcWeight();
    }
  }
}
