using System;

class Program {
  public static void Main (string[] args) {
    /*double y = Convert.ToDouble(Console.ReadLine());
    double z = Convert.ToDouble(Console.ReadLine());
    string symbol = Console.ReadLine();
    switch (symbol)
    {
      case "+": Console.WriteLine(y+z);break;
      case "-": Console.WriteLine(y-z);break;
      case "*": Console.WriteLine(y*z);break;
      case "/": Console.WriteLine(y/z);break;
      default: Console.WriteLine("nqma takova deistvie"); break;
    }*/


    /*double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double c = Convert.ToDouble(Console.ReadLine());
    double D = b*b - 4*a*c;
    double x1;
    double x2;
    if (D>0)
    {
      x1 = (-b + Math.Sqrt(D))/(2*a);
      x2 = (-b - Math.Sqrt(D))/(2*a);
      Console.WriteLine(x1);
      Console.WriteLine(x2);
    }
    else if (D==0)
    {
      x1 = -b/(2*a);
      Console.WriteLine(x1);
    }
    else
    {
      Console.WriteLine("nqma realni koreni");
    }*/


    /*double n = Convert.ToDouble(Console.ReadLine());
    double k = Convert.ToDouble(Console.ReadLine());
    if (n>0 && k>0)
    {
      Console.WriteLine("1vi kvadrant");
    }
    else if (n<0 && k>0)
    {
      Console.WriteLine("2ri kvadrant");
    }
    else if (n<0 && k<0)
    {
      Console.WriteLine("3ti kvadrant");
    }
    else
    {
      Console.WriteLine("4ti kvadrant");
    }*/


    double q = Convert.ToDouble(Console.ReadLine());
    double w = Convert.ToDouble(Console.ReadLine());
    double e = Convert.ToDouble(Console.ReadLine());
    if (q>0 && e>0 && w>0)
    {
    if (q<w+e && w<q+e && e<q+w)
    {
      Console.WriteLine("ima takuv triugulnik");
    }
    else
    {
      Console.WriteLine("nqma takuv triugulnik");
    }
    }
    else 
    {
      Console.WriteLine("nqma takuv triugulnik");
    }
  }
}