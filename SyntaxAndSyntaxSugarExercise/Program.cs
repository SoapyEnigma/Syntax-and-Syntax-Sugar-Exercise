﻿namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            //var response = answer.ToString() + (answer < 9 ? " is less than nine" : " is greater than or equal to nine");
            var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
        }
    }
}
