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
        public List<List<CheckBox>> checkboxesList;


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

        internal void InitQuestionPage(ref List<Panel> pages, int pageIndex)
        {
            checkboxesList = new List<List<CheckBox>>();
            List<CheckBox> checkboxes = new List<CheckBox>();  
            activePage = pageIndex;
            int i = (selectedLevel - 1)*20;
            int k = 0;
            while (i < selectedLevel*20 && k < 20)
            {
                // Place for questions
                Panel myPanel = new Panel();
                myPanel.Name = $"myPanel_{k}";
                myPanel.BackColor = Color.Gray;
                myPanel.Size = new Size(350, 300);
                myPanel.Location = new Point(40 , 40 + (k * 320));
                pages[pageIndex - 1].Controls.Add(myPanel);

                // Question Number
                Label myLabel = new Label();
                myLabel.AutoSize = true;
                myLabel.ForeColor = Color.White;
                myLabel.Text = $"{(k + 1)})";
                myLabel.Font = new Font("Sagoe UI", 12);
                myLabel.Size = new Size(60, 60);
                myLabel.Location = new Point(20, 22);
                myPanel.Controls.Add(myLabel);

                // Question Checkboxes
                CheckBox checkBox1 = new CheckBox();
                CheckBox checkBox2 = new CheckBox();
                CheckBox checkBox3 = new CheckBox();

                checkBox1.Name = $"checkBox1_{k}";
                checkBox1.ForeColor = Color.White;
                checkBox1.Size = new Size(20, 20);
                checkBox1.Location = new Point(25, 100);
                myPanel.Controls.Add(checkBox1);
                checkBox1.Name = $"checkBox2_{k}";
                checkBox2.ForeColor = Color.White;
                checkBox2.Size = new Size(20, 20);
                checkBox2.Location = new Point(25, 145);
                myPanel.Controls.Add(checkBox2);
                checkBox1.Name = $"checkBox3_{k}";
                checkBox3.ForeColor = Color.White;
                checkBox3.Size = new Size(20, 20);
                checkBox3.Location = new Point(25, 190);
                myPanel.Controls.Add(checkBox3);

                checkboxes.Add(checkBox1);
                checkboxes.Add(checkBox2);
                checkboxes.Add(checkBox3);
                checkboxesList.Add(checkboxes);

                // Question
                Label myQuestionLabel = new Label();
                myQuestionLabel.Text = levels[selectedLevel-1].questions[k].question;
                myQuestionLabel.TextAlign = ContentAlignment.TopLeft;
                myQuestionLabel.Font = new Font("Sagoe UI", 16);
                myQuestionLabel.Size = new Size(120, 60);
                myQuestionLabel.Location = new Point(85, 20);
                myPanel.Controls.Add(myQuestionLabel);

                // Choices
                Label choice1 = new Label();
                choice1.Text = $"A) {levels[selectedLevel - 1].questions[k].choices[0]}";
                choice1.TextAlign = ContentAlignment.TopLeft;
                choice1.Font = new Font("Sagoe UI", 14);
                choice1.Size = new Size(160, 40);
                choice1.Location = new Point(85, 95);
                myPanel.Controls.Add(choice1);

                Label choice2 = new Label();
                choice2.Text = $"B) {levels[selectedLevel - 1].questions[k].choices[1]}";
                choice2.TextAlign = ContentAlignment.TopLeft;
                choice2.Font = new Font("Sagoe UI", 14);
                choice2.Size = new Size(160, 40);
                choice2.Location = new Point(85, 140);
                myPanel.Controls.Add(choice2);

                Label choice3 = new Label();
                choice3.Text = $"C) {levels[selectedLevel - 1].questions[k].choices[2]}";
                choice3.TextAlign = ContentAlignment.TopLeft;
                choice3.Font = new Font("Sagoe UI", 14);
                choice3.Size = new Size(160, 40);
                choice3.Location = new Point(85, 185);
                myPanel.Controls.Add(choice3);

                i++;
                k++;
            }
        }

        public void checkAnswers(ref List<Panel> pages)
        {
            int point = 0;
            int i = activePage -1;
            int k = 0;
            int moreThan = 0;
            while (i < selectedLevel * 20 && k < 20)
            {
                
                int selected = -1;
                for (int j = 0; j<3; j++)
                {
                    if(checkboxesList[k][j].Checked == true)
                    {
                        moreThan++;
                        selected = j;
                    }
                    
                }
                
                if (selected == -1)
                {
                    //MessageBox.Show("You Forgot to Check");
                }
                if (selected !=  -1)
                {
                    if (levels[selectedLevel - 1].questions[k].rightAnswer == levels[selectedLevel - 1].questions[k].choices[selected])
                    {
                        point += 10;
                    }
                }


                i++;
                k++;

            }
            if (moreThan >= 2)
            {
                MessageBox.Show("Cant Check More Than One Choice");
            }

            MessageBox.Show(point.ToString());
        }
        
    }
}
