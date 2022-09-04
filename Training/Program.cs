using System;
using Training;

class Train
{
    static void Main(string[] args)
    {
        List<string> answers = new List<string>();
        answers.Append(ArithmeticTasks.sumF(5, 1).ToString());

        foreach (string Answers in answers)
        {
            Console.WriteLine($"{Answers}") ;
        }
    }
}