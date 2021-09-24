using System;

namespace PolinomiosQuadrados{

    class Program{

        static void Main(string[] args){
            int opcao = 0;

            while(opcao != 2){

                Console.WriteLine("\n(1)Calcular Raizes De Um Polinomio de Grau 2\n(2)Sair");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1){

                    Polinomio polinomio = new Polinomio();
                    Console.WriteLine("Todo Polinomio de Grau 2 pode ser escrito na forma Ax^2 + Bx + C");

                    Console.Write("Digite o valor de A: ");
                    polinomio.SetA(double.Parse(Console.ReadLine()));

                    Console.Write("Digite o valor de B: ");
                    polinomio.SetB(double.Parse(Console.ReadLine()));

                    Console.Write("Digite o valor de C: ");
                    polinomio.SetC(double.Parse(Console.ReadLine()));

                    if(polinomio.DeltaIsNegativo()){
                        Console.WriteLine("\nDelta Negativo!\nNao existem raizes reais");
                    }

                    else if(polinomio.DeltaIsZero()){
                        Console.WriteLine("\nDelta = 0\nSo existe apenas uma raiz real");
                        Console.WriteLine("Raiz = " + polinomio.Raiz1().ToString("F4"));
                    }

                    else{
                        Console.WriteLine("\nDelta Positivo\nExistem duas raizes Reais");
                        Console.WriteLine("Raiz 1 = " + polinomio.Raiz1().ToString("F4"));
                        Console.WriteLine("Raiz 2 = " + polinomio.Raiz2().ToString("F4"));
                    }
                }

                else if(opcao == 2){
                    continue;
                }

                else{
                    Console.WriteLine("\nVoce Digitou uma Opcao Invalida\nTente Novamente");
                }

            }
        }
    }
}
