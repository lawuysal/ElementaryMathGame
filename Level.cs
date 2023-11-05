using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryMathGame
{
    public class Level
    {
        public string levelName;
        public int levelTime;
        public int remainingTime;
        public int starPoint;
        public bool isStarted;
        public bool isDone;
        public int blockNumber;
        public List<Question> questions;

        public Level(string levelName, int levelTime, int blockNumber)
        {
            this.levelName = levelName;
            this.levelTime = levelTime;
            remainingTime = this.levelTime;
            starPoint = 0;
            isStarted = false;
            isDone = false;
            this.blockNumber = blockNumber;
            questions = new List<Question>();

        }

        public static void initializeLevelQuestions( List<Question> questions, ref Level level, int levelDifficulty)
        {
            const int questionCountPerLevel = 20;
            List<Question> tempQuestions = new List<Question>();
            for (int i = 0; i < questionCountPerLevel; i++)
            {
                tempQuestions.Add(questions[i + ((levelDifficulty-1)*questionCountPerLevel)]);
            }

            level.questions = tempQuestions;
        }

        public override string ToString()
        {
            return $"LevelName:{levelName}, LevelTime:{levelTime}, RemainingTime:{remainingTime}, StarPoint:{starPoint}" +
                $", IsStarted:{isStarted}, IsDone:{isDone}, BlockNumber:{blockNumber}" +
                $", Questions:{string.Join(", ", questions)}";
        }
    }
}
