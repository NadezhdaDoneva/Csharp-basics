using System;

class Program {
  public static void Main (string[] args) {
    /*zad1*/
    /*int i;
    int x = Convert.ToInt32(Console.ReadLine());
    int sum=0;
    for (i=0;i<x;i++){
      sum+=i;
    }
    Console.WriteLine(sum);*/


    /*zad2*/
    /*int x = Convert.ToInt32(Console.ReadLine());
    int i;
    for (i=1; i<=20; i++){
      Console.WriteLine(x*i);
    }*/


    /*zad3*/
   /* int x = Convert.ToInt32(Console.ReadLine());
    int i;
    int multiply=1;
    if (x>10){
      for (i=10; i<=x; i++)
      {
       multiply*=i;
      }
      Console.WriteLine(multiply);
    }
    else {
      Console.WriteLine("none");
    }*/


    /*zad4*/
    /*int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    int sum=0;
    if (x!=y) {
      for (int i=x; i<=y; i++)
      {
        if (i%2==0)
        {
          sum+=i;
        }
      }
      Console.WriteLine(sum);
    }
    else {
      Console.WriteLine("gre6ka");
    }*/


    /*zad5*/
    /*int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    int multiply=1;
    if (x!=y) {
      for (int i=x; i<=y; i++)
      {
        if (i%2==1)
        {
          multiply*=i;
        }
      }
      Console.WriteLine(multiply);
    }
    else {
    Console.WriteLine("gre6ka");
    }*/


    /*zad6*/
   /* int x = Convert.ToInt32(Console.ReadLine());
    int num=0;
    for (int i=1; i<x; i++){
      if (i%3==0){
        num++;
      }
    }
    Console.WriteLine(num);*/


    /*zad7*/
    /* int d=Convert.ToInt32(Console.ReadLine());
    int sum=0;
    for (int i=1; i<=d; i++){
      sum=sum+i*i;
    }
    Console.WriteLine(sum);*/


    /*zad8*/
    /* int e=Convert.ToInt32(Console.ReadLine());
    double sum=0;
    for (int=i;i<=e; i++){
      sum=sum+(i*i)/(i+1);
    }
    Console.WriteLine(sum);*/


    /*zad9*/
    /* int f=Convert.ToInt32(Console.ReadLine());
    double sum=0;
    for (int i=1; i<=f; i++){
      sum=sum+(i*i-1)/(i*i+1);
    }
    Console.WriteLine(sum);*/


    /*zad10*/
    /* int g=Convert.ToInt32(Console.ReadLine());
    double multiply =1;
    for (int i=1; i<=g; i++){
      multiply=multiply*(i-1)/(i+1);
    }
    Console.WriteLine(multiply);*/


    /*zad11*/
    /* int h=Convert.ToInt32(Console.ReadLine());
    int del=0;
    for (int i=-1; i>=h; i--){
      if (I%7==0){
        del++;
      }
    }
    Console.WriteLine(del);*/


    /*zad12*/
    /*int j=Convert.ToInt32(Console.ReadLine());
    for (int i=1; i*i<j; i++){
      Console.WriteLine(i);
    }*/


    /*zad13*/
    /*int k=Convert.ToInt32(Console.ReadLine());
    Console.Write(1+"");
    fpr(int i=2; i+i-1<=k; i++){
      Console.Write(i+"");
    }
    Console.WriteLine();*/


    /*zad14*/
    /* int l=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("o");
    for(int i=2; i<l; i++){
      Console.Write("o");
      for (int t=1; t<=i-1; t++){
        Console.Write("");
      }
      Console.Write("o");
      Console.WriteLine();
    }
    for (int i=1; i<=l; i++){
      Console.Write("o");
    }
    Console.WriteLine();*/


    /*zad15*/
    /*int r=Convert.ToInt32(Console.ReadLine());
    for (int i=1; i<=r; i++){
      Console.WriteLine("o");
    }
    Console.Write();
    for(int i=2; i<r; i++){
      Console.Write("o");
      for (int t=2; t<r; t++){
        Console.Write("");
      }
      Console.Write("o");
      Console.WriteLine();
    }
    for (int i=1; i<r; i++){
      Console.Write("o");
    }
    Console.WriteLine();*/
    

    /*Console.Write("*");
    int row_num=Convert.ToInt32(Console.ReadLine());
    for (int rows=2; rows<row_num; rows++){
      Console.Write("*");
      for (int i=1; i<=rows-2; i++) {
        Console.Write(" ");
      }
      Console.Write("*");
      Console.WriteLine();
    }
    for (int i=1; i<row_num; i++){
      Console.Write("*");
    }
    Console.WriteLine();*/


    
    int row_num=Convert.ToInt32(Console.ReadLine());
    for (int i=1; i<=row_num; i++){
      Console.Write("*");
    }
    for (int rows=2; rows<row_num; rows++){
      Console.Write("*");
      for (int i=2; i<row_num; i++) {
        Console.Write(" ");
      }
      Console.Write("*");
      Console.WriteLine();
    }
    for (int i=1; i<=row_num; i++){
      Console.Write("*");
    }
    Console.WriteLine();

  }
}