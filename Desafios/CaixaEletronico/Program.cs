using System;
using System.Collections.Generic;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int cem = 100;
            int resto1 = 0;
            int resto2 =0;
            int resto3 = 0;
            int resto4 = 0;
            int resto5 =0;
            int cinquenta = 0;
            int vinte = 0;
            int dez = 0;
            int cinco = 0;
            List<int> notas100 = new List<int>();
            List<int> notas50 = new List<int>();
            List<int> notas20 = new List<int>();
            List<int> notas10 = new List<int>();
            List<int> notas5 = new List<int>();
            System.Console.WriteLine("Quanto você deseja sacar?");
            int saque = int.Parse(Console.ReadLine());

            if(saque % 100 >= 0){
                cem = saque /100;
                resto1 = saque-(cem*100);
                notas100.Add(cem);
            foreach (var item in notas100)
            {
            System.Console.WriteLine($" {item} nota de 100");
            }

                cinquenta = resto1 /50;
                resto2 = resto1-(cinquenta*50);
                notas50.Add(cinquenta);
            foreach (var item in notas50)
            {
            System.Console.WriteLine($" {item} nota de 50");
            }

            vinte = resto2 /20;
            resto3 = resto2-(vinte*20);
            notas20.Add(vinte);
            foreach (var item in notas20)
            {
            System.Console.WriteLine($" {item} nota de 20");
            }

            dez = resto3 /10;
            resto4 = resto3-(dez*10);
            notas10.Add(dez);
            foreach (var item in notas10)
            {
            System.Console.WriteLine($" {item} nota de 10");
            }

            cinco = resto4 /5;
            resto5 = resto4-(cinco*5);
            notas5.Add(cinco);
            foreach (var item in notas5)
            {
            System.Console.WriteLine($" {item} nota de 5");
            }
            }
        }
    }
}
