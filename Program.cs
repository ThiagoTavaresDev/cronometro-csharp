using System;
using System.Threading;

namespace Cronometro{

    class Program{

        static void Main(string[] args){
            Menu();
        }
        static void StartTimer(){
            Console.WriteLine("Até quanto deseja cronometrar? --- Digite o tempo em segundos");
            int tempo = int.Parse(Console.ReadLine());
            int tempoAtual = 0;
            while(tempo > tempoAtual){
                tempoAtual++;
                Console.Clear();
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
        }
        static void Menu(){
            Console.WriteLine("Bem vindo ao menu do cronômetro");
            Console.WriteLine("Digite uma opção:");
            Console.WriteLine("1 - Iniciar o cronômetro");
            Console.WriteLine("2 - Sair");
            if(Console.ReadLine() == "1"){
                StartTimer();
            }
            else{
                Environment.Exit(0);
            }
        }

    }


}
