using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(3.1415*3.1415*3.1415-2.71828*2.7182);
    Console.WriteLine(2*3-4*7);
    Console.WriteLine((17-2*3)*7);
    Console.WriteLine(4-2*(2+5));
    Console.WriteLine(7/(1.2-5*0.2));
    Console.WriteLine(1.2+3.5<3.4+7.1);
    Console.WriteLine((1+2+3)*(1+2+3)==(4-3-2)*(4-3-2));
    Console.WriteLine(!(true&&false));
    Console.WriteLine(true&&!false);
    Console.WriteLine(false&&!(true||false));
    Console.WriteLine(false&&!(true||!(false||true)));
    Console.WriteLine(!(true&&true)||!(!true&&!false));
    Console.WriteLine(!(true&&false));
    Console.WriteLine(!(1.2+3.14<4.12));


    double x = double.Parse(Console.ReadLine());
    if(x-Math.Floor(x)==0)
    {
      Console.WriteLine("x e cqlo");
    }
    else
    {
      Console.WriteLine("x ne e cqlo");
    }


    
    double a = double.Parse(Console.ReadLine());
    if (a % 2 == 0) 
    {
      Console.WriteLine("a e chetno");
    }
    else
    {
      Console.WriteLine("a e nechetno");
    }


    double b = double.Parse(Console.ReadLine());
    if (b<0)
    {
      Console.WriteLine("b e otricatelno");
    }
    else if (b>0)
    {
      Console.WriteLine("b e polojitelno");
    }
    else
    {
      Console.WriteLine("b e 0");
    }


    double c = double.Parse(Console.ReadLine());
    if(c%3==0)
    {
      Console.WriteLine("c se deli na 3");
    }
    else{
      Console.WriteLine("c ne se deli na 3");
    }


     int d = int.Parse(Console.ReadLine());
     if (d>=1 && d<=2100)
     {
       if(d%4==0 && d%100!=0 || d%100==0 && d%4==0)
     {
       Console.WriteLine("Godinata e visokosna");
     }
     else
     {
       Console.WriteLine("Godinata ne e visokosna");
     }
     }
    else
    {
      Console.WriteLine("break");
    }
     


     int e = int.Parse(Console.ReadLine());
     if (e<=12 && e>=1)
     {
       if (e==1 || e==3 || e==5|| e==7 || e==8 || e==10 || e==12 )
       {
         Console.WriteLine("ima 31 dni");
       }
       else if (e==4 || e==6 || e==9 || e==11)
       {
         Console.WriteLine("ima 30 dni");
       }
       else
       {
         Console.WriteLine("ima 28 dni");
       }
     }
     else
     {
       Console.WriteLine("nqma takuv mesec!");
     }
  }
}