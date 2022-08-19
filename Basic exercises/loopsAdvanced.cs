using System;

class Program {
  public static void Main (string[] args) {
    /*zad1
    int row=Convert.ToInt32(Console.ReadLine());
    for (int i=1; i<=row; i++){
      for (int j=1; j<=i; j++){
        Console.Write(j+" ");}
        for (int j=i-1; j>=1; j--){
        Console.Write(j+" ");
      }
      Console.WriteLine();
    }*/

    
    /*int br=0;
    string symbol;
    double sum=0;
    while (true){
      symbol=Console.ReadLine();
      if (symbol=="q"){
        break;
      }
      else{
        sum+=Convert.ToInt32(symbol);
        br++;
      }
    }
    Console.WriteLine(sum/br);*/


    /*string symbol;
    double i;
    double max = Convert.ToInt32(Console.ReadLine());
    double min = Convert.ToInt32(Console.ReadLine());
    while (true){
      symbol=Console.ReadLine();
      if (symbol=="q"){
        break;
      }
      else {
        i=Convert.ToInt32(symbol);
        if (max<i){
          max=i;
        }
        if (min>i){
          min=i;
        }
      }
     
  }
  Console.WriteLine(max);
  Console.WriteLine(min);
  Console.WriteLine("marti obicha nadeto");*/


  /*string symbol;
    double number;
    int br=0;
    while (true){
      
      symbol=Console.ReadLine();
      if (symbol=="q"){
        break;
      }
      else {
        number=Convert.ToInt32(symbol);
        if (number%2==0){
          br++;
        }
      }
     
  }
  Console.WriteLine(br);*/


  /*int number=Convert.ToInt32(Console.ReadLine());
  int sum=0;
  while (number%10!=0){
    sum+=number%10;
    number/=10;
  }
  Console.WriteLine(sum);*/


  /*int number=Convert.ToInt32(Console.ReadLine());
  int sum1=0;
  int sum2=0;
  sum2=number%10+(number/10)%10;
  sum1=(number/100)%10+(number/1000)%10;
  if (sum1>sum2){
    Console.WriteLine(true);
  }
  else{
    Console.WriteLine(false);
  }*/


  /*int number = Convert.ToInt32(Console.ReadLine());
  int n1=number;
  int br=0;
  double otg=0;
  while (n1>0){
    br++;
    n1=n1/10;
  }
  while(number>0){
    otg=otg+(number%10)*Math.Pow(10, br-1);
    br--;
    number/=10;
  }
  Console.WriteLine(otg);*/


  /*int a =Convert.ToInt32(Console.ReadLine());
  int b = Convert.ToInt32(Console.ReadLine());
  if (a>b){
    Console.WriteLine(a+" e po golqmoto chilso");
  }
  else if (a<b){
    Console.WriteLine(b+" e po golqmoto chilso");
  }
  else {
    Console.WriteLine("Dvete chisla sa ravni");
  }*/


  /*int n =Convert.ToInt32(Console.ReadLine());
  int counter=1;
  for (int i=0; i<n; i++){
    for (int k=0; k<i; k++){
      Console.Write(counter%2);
      counter++;
    }
    Console.WriteLine();
  }*/


  
}
}