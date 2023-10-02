using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
namespace Jan_TriviaGame
{
    internal class Controller
    {
        public void Play()
        {
            Question_Bank qBank = new Question_Bank();
            string[] options;
            int correct;
            Welcome();

            try
            {
                qBank.ReadQuestionFile();
            }
            catch (FileNotFoundException ex)
            {
               
                Error.WriteLine("File not found: " + ex.Message);
            }
            
            do
            {
                correct = 0;
                Clear();
                for (int i = 0; i < 5; i++)
                {
                    string response;
                    WriteLine("\n\n\n\nQuestion " + (i + 1) + ":");
                    WriteLine("\n" + qBank.GetQuestion(i) + "\n");
                    options = qBank.GetAnswers(i);
                    WriteLine("  A. " + options[0] + "\tB. " + options[1]);
                    WriteLine("  C. " + options[2] + "\tD. " + options[3]);
                    Write("\n\nWhat is your answer: ");

                    response = ReadLine();

                    if (!string.IsNullOrEmpty(response) && response.ToUpper() == qBank.GetCorrectAnswer(i))
                    {
                        WriteLine("\nYou are correct!");
                        correct++;
                    }
                    else
                    {
                        WriteLine("\nSorry you are wrong");
                        WriteLine("The correct answer is " + qBank.GetCorrectAnswer(i));
                    }
                    WriteLine("\n" + qBank.GetExplanation(i));
                    WriteLine("\n\n\nPlease press the Enter key when you are ready to continue");
                    ReadKey();
                    Clear();
                }
                WriteLine("\n\n\n\nYou had " + correct + " correct answers out of 5");
                
            } while (PlayAgain() == true);
        }
        public bool PlayAgain()
        {
            bool again = false;
            string response;

            Write("\n\nWould you like to play again? (Y or N): ");
            response = ReadLine();

            if (!string.IsNullOrEmpty(response))
            {
                if (response.ToUpper()[0] == 'Y')
                {
                    again = true;
                }
                else 
                {
                    again = false;
                }
            }
            return again;
        }

        public void Welcome()
        {
            WriteLine("\n\n\n\tLet's play a game of trivia. You will be shown a series of questions," +
                "\n\tone at a time. Each question will have four possible answers, only one" +
                "\n\tis the correct answer. Your job is to pick the correct answer.");
            Write("\n\nPress the Enter key when you are ready to begin. \t");
            ReadKey();
        }
    }
}
