﻿using System;

namespace CheckPoint_du_16._10._2020___Calculator__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Int32[] integers = { 1, 2, 3, 4 };
            Int32 sum = calculator.Somme(integers);
            Console.WriteLine("La somme des entiers du tableau est égale à " + sum + ".");

            float average = calculator.Moyenne(integers);
            Console.WriteLine("La moyenne des entiers du tableau est égale à " + average + ".");
        }
    }
    public class Calculator
    {
        public Int32 Somme(Int32[] integers)
        {
            Int32 resultat = 0;
            foreach (Int32 value in integers)
            {
                resultat = resultat + value;
            }
            return resultat;
        }
        public Int32 Moyenne(Int32[] integers)
        {
            Int32 sum = Somme(integers);
            return sum / integers.Length;
        }
    }
}
