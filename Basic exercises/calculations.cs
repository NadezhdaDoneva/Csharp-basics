using System;

class Program {
  public static void Main (string[] args) {
    double x = 2.5*(3-1/4.75);
    Console.WriteLine (x);
    double y = 4+2/(7+4.5);
    Console.WriteLine (y);
    double z = 7%2+3*4.5;
    Console.WriteLine (z);
    bool a = true || (false && true);
    Console.WriteLine (a);
    bool b = !true || (false && true);
    Console.WriteLine (b);
    bool c = false && !(true || false);
    Console.WriteLine (c);
  }
}