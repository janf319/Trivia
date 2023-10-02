using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan_TriviaGame
{
    class Question_Unit
    {
        private string question;
        private string[] answers;
        private string correctAnswer;
        private string explanation;

        public Question_Unit(string question, string[] answers, string correctAnswer, string explanation)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
            this.explanation = explanation;
        }
        public string[] Answers
        {
            get { return answers;} 
            set { answers = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        public string Explanation
        {
            get { return explanation; }
            set { explanation = value; }
        }

        public string Question
        {
            get { return question; }
            set { question = value; }

        }
        public override string ToString()
        {
            string str = "";
            str += question + "\n";
            foreach (string a in answers)
            {
                str += a + "\n";
            }
            str += correctAnswer + "\n" + explanation + "\n";
            return str;
        }
    }
}
