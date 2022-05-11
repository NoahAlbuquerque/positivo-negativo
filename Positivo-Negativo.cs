using System;

class Program {
  public static void Main (string[] args) {
    //Construa um algoritmo que leia um número inteiro (positivo ou negativo) e apresente o seu módulo (número sem sinal).
    double numInt;
    Console.WriteLine ("Digite um número inteiro: ");

    numInt = double.Parse(Console.ReadLine());
    Console.WriteLine("Número escolhido: {0} ", numInt);
   if(numInt >=0){
     if(numInt % 2 ==0)
       Console.WriteLine("O numero é par e positivo");
     else
         Console.WriteLine("O numero é impar e positivo");
   }
    else{
      if(numInt % 2 ==0)
        Console.WriteLine("O numero é par e negativo");
      else
        Console.WriteLine("O numero é impar e negativo");
      }
    }
    
  }
