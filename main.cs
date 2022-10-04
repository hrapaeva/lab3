using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("Введите x: ");
      double x = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введите y: ");
      double y = Convert.ToDouble(Console.ReadLine());

      if (Math.Abs(x+y) + Math.Abs(y -x) <= 10) {
      if ((y >= 2*x - 5) & (y <= 2*x + 5) & (x*x + y*y <= 25)) Console.WriteLine($"Точка находится в закрашенной области"); 
      else if ((x <= 0) & (y >=0) & (x*x + y*y >= 25)) Console.WriteLine($"Точка находится в закрашенной области"); 
      else if ((x <= 0) & (y <= 0) & (x*x + y*y >= 25) & (y >= 2*x + 5))  Console.WriteLine($"Точка находится в закрашенной области");
      else if ((x >= 0) & (y <= 0) & (x*x + y*y >=25)) Console.WriteLine($"Точка находится в закрашенной области"); 
      else  Console.WriteLine($"Точка вне закрашенной области"); 
      }
      else  Console.WriteLine($"Точка вне данной области");
}
}
