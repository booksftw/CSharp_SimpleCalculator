﻿using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                // In real world we would want to log this message
                Console.WriteLine(ex.Message);
            }

        }
    }
}
