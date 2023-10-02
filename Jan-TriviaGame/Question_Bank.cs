using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Jan_TriviaGame
{
    class Question_Bank
    {
        private string fileName = "Questions.txt";
        public static int NO_OF_QUESTIONS = 5;
        public static int NO_OF_ANSWERS = 4;
        private Question_Unit[] questionBank = new Question_Unit[NO_OF_QUESTIONS];


        public string[] GetAnswers(int index)
        {
            return questionBank[index].Answers;
        }

        public string GetCorrectAnswer(int index)
        {
            return questionBank[index].CorrectAnswer;
        }

        public string GetExplanation(int index)
        {
            return questionBank[index].Explanation;
        }

        public string GetQuestion(int index)
        {
            return questionBank[index].Question;
        }
        public void ReadQuestionFile()
        {
            StreamReader inFile;
            string question;
            string[] answers;
            string correct;
            string explanation;

            inFile = new StreamReader(fileName);
            

            for (int i = 0; i < questionBank.Length; i++)
            {
                question = inFile.ReadLine();
                answers = new string[NO_OF_ANSWERS];
                for (int x = 0; x < answers.Length; x++)
                {
                    answers[x] = inFile.ReadLine();
                }
                correct = inFile.ReadLine();
                explanation = inFile.ReadLine();
                questionBank[i] = new Question_Unit(question, answers, correct, explanation);
            }

            inFile.Close();
        }
        public override string ToString()
        {
            string str = "";
            for (int x = 0; x < questionBank.Length; x++)
            {
                str += questionBank[x].ToString() + "\n";
            }
            return str;
        }
    }
}
