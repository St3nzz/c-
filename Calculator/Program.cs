using System;

namespace Calculator
{
    class Calculator
    {
        public static string Calc(double num1, double num2, string op)
        {
            double result = 0;
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "b":
                    result = num1 - num2;
                    break;
                case "c":
                    result = num1 * num2;
                    break;
                case "e":
                    result = num1 % num2;
                    break;
                case "d":
                    while(num2 == 0)
                    {
                        Console.Write("На ноль делить нельзя, введите другое число: ");
                        num2 = double.Parse(Console.ReadLine());
                    }
                    result = num1 / num2;
                    break;
            }
            return result.ToString(); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("Добро пожаловать в консольный калькулятор на C#");
                Console.WriteLine("-----------------------------------------------\n");
                Console.Write("Введите первое число: ");
                double num1;
                bool notErrorNum1 = double.TryParse(Console.ReadLine(), out num1);
                while(!notErrorNum1){
                    Console.Write("Вы ввели неверное число, введите заново: ");
                    notErrorNum1 = double.TryParse(Console.ReadLine(), out num1);
                }
                Console.Write("Введите второе число: ");
                double num2;
                bool notErrorNum2 = double.TryParse(Console.ReadLine(), out num2);
                while (!notErrorNum2){
                    Console.Write("Вы ввели неверное число, введите заново: ");
                    notErrorNum2 = double.TryParse(Console.ReadLine(), out num2);
                }
                Console.WriteLine("Выберите операцию из списка:");
                Console.WriteLine("    a - сложение\n    b - вычитание\n    c - умножение\n    d - деление\n    e - остаток от деления");
                Console.Write("Ваш выбор: ");
                string op = Console.ReadLine();
                Console.WriteLine($"Ваш результат: " + Calculator.Calc(num1, num2, op));
                Console.WriteLine("-----------------------------------------------\n");
                Console.WriteLine("Если вы хотите продолжить вычисления, нажмите S и Enter");
                string a = Console.ReadLine();
                if (a == "S")
                    isWorking = true;
                else
                    isWorking = false;
                Console.Clear();
            }
        }
    }
}
