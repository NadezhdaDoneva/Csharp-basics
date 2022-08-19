class Program {
  public static void Main (string[] args) {
    //zad1
    /*
    int size=int.Parse(Console.ReadLine());
    int [] a= new int[size];
    int [] b= new int[size];
    for (int index=0; index<size; index++){
      a[index]=int.Parse(Console.ReadLine());
    }
    for (int index=0; index<size; index++){
      b[size-1-index]=a[index];
    }
    for (int index=0; index<size; index++){
      Console.WriteLine(b[index]);
    }*/


    //zad2
    /*int size=int.Parse(Console.ReadLine());
    int [] a= new int[size];
    int sum=0;
    int proizvedenie=1;
    for (int index=0; index<size; index++){
      a[index]=int.Parse(Console.ReadLine());
    }
    for (int index=0; index<size; index++){
      sum+=a[index];
      proizvedenie*=a[index];
    }
    Console.WriteLine(sum);
    Console.WriteLine(proizvedenie);
    Console.WriteLine(sum/size);*/



    //zad3
    /*int size=int.Parse(Console.ReadLine());
    int [] a= new int[size];
    int [] b= new int[size];
    int counter=0;
     for (int index=0; index<size; index++){
       a[index]=int.Parse(Console.ReadLine());
     }
     for (int index=0; index<size; index++){
       if (a[index]%2==0 && a[index]>0){
         b[counter]=a[index];
         counter++;
       }
     }
     for (int index=0; index<counter; index++){
       Console.WriteLine(b[index]);
     }*/


     //zad4
    /* int size=int.Parse(Console.ReadLine());
    int [] a= new int[size];
    int [] b= new int[size];
    int [] c= new int[size];
    int counter1=0;
    int counter2=0;
     for (int index=0; index<size; index++){
       a[index]=int.Parse(Console.ReadLine());
     }
     for (int index=0; index<size; index++){
       if (a[index]%3==0){
         b[counter1]=a[index];
         counter1++;
       }
     }
     for (int index=0; index<size; index++){
       if (a[index]%5==0){
         c[counter2]=a[index];
         counter2++;
       }
     }
     for (int index=0; index<counter1; index++){
       Console.WriteLine(b[index]);
     }
     for (int index=0; index<counter2; index++){
       Console.WriteLine(c[index]);
     }*/


     //zad6
    /*int size=int.Parse(Console.ReadLine());
    int [] a= new int[size];
    for (int index=0; index<size; index++){
       a[index]=int.Parse(Console.ReadLine());
     }
     int max=a[0];
     int min=a[0];
    for (int index=0; index<size; index++){
      if (max<a[index]){
        max=a[index];
      }
    }
    for (int index=0; index<size; index++){
      if (min>a[index]){
        min=a[index];
      }
    }
    Console.WriteLine(min);
    Console.WriteLine(max);*/

    //zad7
    /*int [] a= new int[10];
    int [] b= new int[10];
    int [] c= new int[10];
     for (int index=0; index<10; index++){
       a[index]=int.Parse(Console.ReadLine());
     }
      for (int index=0; index<10; index++){
       b[index]=int.Parse(Console.ReadLine());
     }
    for (int index=0; index<10; index++){
      c[index]=a[index]+b[index];
      Console.WriteLine(c[index]);
    }*/


    //zad8
    /*int size =Convert.ToInt32(Console.ReadLine());
    int[] a= new int[size];
    int counter=0;
    for (int index=0; index<size; index++){
       a[index]=int.Parse(Console.ReadLine());
     }
    for (int i=0; i<size; i++){
      bool pr=false;
      for (int k=2; k*k<=a[i]; k++){
        if (a[i]%k==0){
          pr=true;
          break;
        }
      }
      if (pr==true){
        counter++;
      }
    }
    Console.WriteLine(counter);*/


    /*int size=Convert.ToInt32(Console.ReadLine());
    int[] mass=new int[size];
    for (int i=0; i<size; i++){
      mass[i]=Convert.ToInt32(Console.ReadLine());
      if (mass[i]%2==0){
        mass[i]=0;
      }
    }
    for (int i=0;i<size; i++){
      Console.Write(mass[i]+ " ");
    }
    Console.WriteLine();*/


    int[] a=new int [10];
    int[] b=new int[5];
  }
}