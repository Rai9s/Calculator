﻿using System;
using System.Xml.Schema;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        //Chamando a função menu
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Porcentagem");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("------------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());//Console.ReadLine irá ler o comando
            
            switch(res){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Porcentagem(); break;
                case 6: System.Environment.Exit(0); break; // Environment é o ambiente que estamos, 0 confirma que saiu com sucesso  
                default: Menu(); break;
            }
        
        
        }
        //Método para somar
        static void Soma()
        { 
            
            Console.Clear();
            
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado} ");
            Console.ReadKey();
            Menu();
        }

        //Método para Subtrair
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
        
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
        
            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        //Método para Divisão 
        static void Divisao(){

            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        //Método para Multiplicação
        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Porcentagem(){
            Console.Clear();

            Console.WriteLine("Valor total: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor da parte: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            if(v1 != 0)
            {
                float porcentagem = (v2 / v1) * 100;
                Console.WriteLine($"A porcentagem é: {porcentagem}%");
            }
            else
            {
                Console.WriteLine("O valor total não pode ser zero");
            }
            Console.ReadKey();
            Menu();

        }
    
    
    
    }
}

