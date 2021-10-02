using System;

namespace aula_1
{
  public class CalcCategory
  {
    double weight { get; set; }
    public CalcCategory(double weight) {
      this.weight = weight;
    }

    public void CalcWeight()
    {
      if (weight < 50)
      {
        Console.WriteLine("Palha");
      }
      else if (weight <= 59.99)
      {
        Console.WriteLine("Pluma");      
      }
      else if (weight <= 75.99)
      {
        Console.WriteLine("Pesado");            
      }
      else
      {
        Console.WriteLine("Super pesado");            
      }

    }
  }
}