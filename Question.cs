using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryMathGame
{
    public class Question
    {
        public int id;
        public string question;
        public List<int> choices;
        public int rightAnswer;
        public string qOperator;
        public int difficultyLevel;
        public bool isPassed;
        public bool isCorrect;

        public Question() 
        {
            
            
            
            
            
        }

        public static void initializeQuestionsFromJSON (ref string jsonString, ref List<Question> questions)
        {
            //const int questionCountPerFile = 100;
            questions = JsonConvert.DeserializeObject<List<Question>>(jsonString);
        }

        public override string ToString()
        {
            return $"Id:{id}, Question:{question}, Choices:{string.Join(", ", choices)}, RightAnswer:{rightAnswer}" +
                $", qOperator:{qOperator}, DifficultyLevel:{difficultyLevel}" +
                $", IsPassed:{isPassed}, IsCorrect:{isCorrect}";
        }
    }
}
