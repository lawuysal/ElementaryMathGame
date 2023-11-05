using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryMathGame
{

    

    public class Game
    {
        public string playerName;
        public int gameTime;
        public int currentScore;
        public Dictionary<string, int> scores;
        public int activePage;
        public List<Level> levels;
        public int selectedLevel;
        public string selectedOperator;
        public string activeCheat;


        public bool isStarted;
        public bool isDone;

        public static readonly List<string> Operators = new List<string> {"+", "-", "*", "/", "all"};
        public static readonly List<string> Cheats = new List<string> {"none", "2", "3", "4", "5", "all"};

        public Game(string playerName, ref List<Level> levels, int selectedLevel, string selectedOperator)
        {
            this.playerName = playerName;
            this.selectedOperator = selectedOperator;
            this.selectedLevel = selectedLevel;
            activeCheat = "none";
            this.levels = levels;
            for (int i = 0; i < 5; i++)
            {
                gameTime += levels[i].levelTime;
            }
            currentScore = 0;
            scores = new Dictionary<string, int>();
            scores.Add("Test", 9999);
            activePage = 0;
            isStarted = false;
            isDone = false;
        }

        public override string ToString()
        {
            return $"PlayerName:{playerName}, Levels:{string.Join(", ", levels)}, GameTime:{gameTime}, CurrentScore:{currentScore}, Scores:{string.Join(",", scores)}" +
                $", ActivePage:{activePage}, SelectedLevel:{selectedLevel}, SelectedOperator:{selectedOperator}, IsStarted:{isStarted}" +
                $", IsDone:{isDone}, Operators:{string.Join(", ", Operators)}, Cheats:{string.Join(", ", Cheats)}, ActiveCheat:{activeCheat}";
        }


    }
}
