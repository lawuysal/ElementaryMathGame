using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace ElementaryMathGame
{

    public partial class Form1 : Form
    {
        // Addition Questions
        List<Question> additionQuestions = new List<Question>();
        Level levelFirstAddition = new Level("levelFirstAddition", 100, 1);
        Level levelSecondAddition = new Level("levelSecondAddition", 200, 2);
        Level levelThirdAddition = new Level("levelThirdAdditon", 300, 3);
        Level levelFourthAddition = new Level("levelFourthAddition", 400, 4);
        Level levelFifthAddition = new Level("levelFifthAddition", 500, 5);

        //Substraction Questions
        List<Question> substractionQuestions = new List<Question>();
        Level levelFirstSubstraction = new Level("levelFirstSubstraction", 100, 1);
        Level levelSecondSubstraction = new Level("levelSecondSubstraction", 200, 2);
        Level levelThirdSubstraction = new Level("levelThirdSubstraction", 300, 3);
        Level levelFourthSubstraction = new Level("levelFourthSubstraction", 400, 4);
        Level levelFifthSubstraction = new Level("levelFifthSubstraction", 500, 5);

        //Multiplication Questions
        List<Question> multiplicationQuestions = new List<Question>();
        Level levelFirstMultiplication = new Level("levelFirstSubstraction", 100, 1);
        Level levelSecondMultiplication = new Level("levelSecondSubstraction", 200, 2);
        Level levelThirdMultiplication = new Level("levelThirdSubstraction", 300, 3);
        Level levelFourthMultiplication = new Level("levelFourthSubstraction", 400, 4);
        Level levelFifthMultiplication = new Level("levelFifthSubstraction", 500, 5);

        //Multiplication Questions
        List<Question> divisionQuestions = new List<Question>();
        Level levelFirstDivision = new Level("levelFirstDivision", 100, 1);
        Level levelSecondDivision = new Level("levelSecondDivision", 200, 2);
        Level levelThirdDivision = new Level("levelThirdDivision", 300, 3);
        Level levelFourthDivision = new Level("levelFourthDivision", 400, 4);
        Level levelFifthDivision = new Level("levelFifthDivision", 500, 5);

        //Random Questions
        List<Question> randomQuestions = new List<Question>();
        Level levelFirstRandom = new Level("levelFirstRandom", 100, 1);
        Level levelSecondRandom = new Level("levelSecondRandom", 200, 2);
        Level levelThirdRandom = new Level("levelThirdRandom", 300, 3);
        Level levelFourthRandom = new Level("levelFourthRandom", 400, 4);
        Level levelFifthRandom = new Level("levelFifthRandom", 500, 5);

        List<Level> levels = new List<Level>();

        //Game Object
        Game myGame;

        string selectedOperator = "+";
        string playerName;
        int selectedLevel = 1;


        public Form1()
        {
            InitializeComponent();


            // Addition Initializations
            string additionQuestionsJSON = System.IO.File.ReadAllText("additionQuestions.json");
            Question.initializeQuestionsFromJSON(ref additionQuestionsJSON, ref additionQuestions);
            Level.initializeLevelQuestions(additionQuestions, ref levelFirstAddition, 1);
            Level.initializeLevelQuestions(additionQuestions, ref levelSecondAddition, 2);
            Level.initializeLevelQuestions(additionQuestions, ref levelThirdAddition, 3);
            Level.initializeLevelQuestions(additionQuestions, ref levelFourthAddition, 4);
            Level.initializeLevelQuestions(additionQuestions, ref levelFifthAddition, 5);

            // Substraction Initializations
            string substractionQuestionsJSON = System.IO.File.ReadAllText("substractionQuestions.json");
            Question.initializeQuestionsFromJSON(ref substractionQuestionsJSON, ref substractionQuestions);
            Level.initializeLevelQuestions(substractionQuestions, ref levelFirstSubstraction, 1);
            Level.initializeLevelQuestions(substractionQuestions, ref levelSecondSubstraction, 2);
            Level.initializeLevelQuestions(substractionQuestions, ref levelThirdSubstraction, 3);
            Level.initializeLevelQuestions(substractionQuestions, ref levelFourthSubstraction, 4);
            Level.initializeLevelQuestions(substractionQuestions, ref levelFifthSubstraction, 5);

            // Multiplication Initializations
            string multiplicationQuestionsJSON = System.IO.File.ReadAllText("multiplicationQuestions.json");
            Question.initializeQuestionsFromJSON(ref multiplicationQuestionsJSON, ref multiplicationQuestions);
            Level.initializeLevelQuestions(multiplicationQuestions, ref levelFirstMultiplication, 1);
            Level.initializeLevelQuestions(multiplicationQuestions, ref levelSecondMultiplication, 2);
            Level.initializeLevelQuestions(multiplicationQuestions, ref levelThirdMultiplication, 3);
            Level.initializeLevelQuestions(multiplicationQuestions, ref levelFourthMultiplication, 4);
            Level.initializeLevelQuestions(multiplicationQuestions, ref levelFifthMultiplication, 5);

            // Division Initializations
            string divisionQuestionsJSON = System.IO.File.ReadAllText("divisionQuestions.json");
            Question.initializeQuestionsFromJSON(ref divisionQuestionsJSON, ref divisionQuestions);
            Level.initializeLevelQuestions(divisionQuestions, ref levelFirstDivision, 1);
            Level.initializeLevelQuestions(divisionQuestions, ref levelSecondDivision, 2);
            Level.initializeLevelQuestions(divisionQuestions, ref levelThirdDivision, 3);
            Level.initializeLevelQuestions(divisionQuestions, ref levelFourthDivision, 4);
            Level.initializeLevelQuestions(divisionQuestions, ref levelFifthDivision, 5);

            // Division Initializations
            string randomQuestionsJSON = System.IO.File.ReadAllText("randomQuestions.json");
            Question.initializeQuestionsFromJSON(ref randomQuestionsJSON, ref randomQuestions);
            Level.initializeLevelQuestions(randomQuestions, ref levelFirstRandom, 1);
            Level.initializeLevelQuestions(randomQuestions, ref levelSecondRandom, 2);
            Level.initializeLevelQuestions(randomQuestions, ref levelThirdRandom, 3);
            Level.initializeLevelQuestions(randomQuestions, ref levelFourthRandom, 4);
            Level.initializeLevelQuestions(randomQuestions, ref levelFifthRandom, 5);


        }

        private void testButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Level List Initialization
            levels.Add(levelFirstAddition);
            levels.Add(levelSecondAddition);
            levels.Add(levelThirdAddition);
            levels.Add(levelFourthAddition);
            levels.Add(levelFifthAddition);

            // Opening Screen Initializations

            playerName = nameBox.Text.ToString();

            // Game Initialization
            myGame = new Game(playerName, ref levels, selectedLevel, selectedOperator);

            MessageBox.Show(string.Join(", ", myGame));

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void L1Btn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selectedOperator = "+";
            oprtrAddSlctBtn.BackColor = Color.Green;
            oprtrSubSlctBtn.BackColor = Color.White;
            oprtrMulSlctBtn.BackColor = Color.White;
            oprtrDivSlctBtn.BackColor = Color.White;
            oprtrAllSlctBtn.BackColor = Color.White;
        }

        private void oprtrSubSlctBtn_Click(object sender, EventArgs e)
        {
            selectedOperator = "-";
            oprtrAddSlctBtn.BackColor = Color.White;
            oprtrSubSlctBtn.BackColor = Color.Green;
            oprtrMulSlctBtn.BackColor = Color.White;
            oprtrDivSlctBtn.BackColor = Color.White;
            oprtrAllSlctBtn.BackColor = Color.White;
        }

        private void oprtrMulSlctBtn_Click(object sender, EventArgs e)
        {
            selectedOperator = "*";
            oprtrAddSlctBtn.BackColor = Color.White;
            oprtrSubSlctBtn.BackColor = Color.White;
            oprtrMulSlctBtn.BackColor = Color.Green;
            oprtrDivSlctBtn.BackColor = Color.White;
            oprtrAllSlctBtn.BackColor = Color.White;
        }

        private void oprtrDivSlctBtn_Click(object sender, EventArgs e)
        {
            selectedOperator = "/";
            oprtrAddSlctBtn.BackColor = Color.White;
            oprtrSubSlctBtn.BackColor = Color.White;
            oprtrMulSlctBtn.BackColor = Color.White;
            oprtrDivSlctBtn.BackColor = Color.Green;
            oprtrAllSlctBtn.BackColor = Color.White;
        }

        private void oprtrAllSlctBtn_Click(object sender, EventArgs e)
        {
            selectedOperator = "all";
            oprtrAddSlctBtn.BackColor = Color.White;
            oprtrSubSlctBtn.BackColor = Color.White;
            oprtrMulSlctBtn.BackColor = Color.White;
            oprtrDivSlctBtn.BackColor = Color.White;
            oprtrAllSlctBtn.BackColor = Color.Green;
        }

        private void level1SlctBtn_Click(object sender, EventArgs e)
        {
            selectedLevel = 1;
            level1SlctBtn.BackColor = Color.DodgerBlue;
            level2SlctBtn.BackColor = Color.White;
            level3SlctBtn.BackColor = Color.White;
            level4SlctBtn.BackColor = Color.White;
            level5SlctBtn.BackColor = Color.White;
        }

        private void level2SlctBtn_Click(object sender, EventArgs e)
        {
            selectedLevel = 2;
            level1SlctBtn.BackColor = Color.White;
            level2SlctBtn.BackColor = Color.DodgerBlue;
            level3SlctBtn.BackColor = Color.White;
            level4SlctBtn.BackColor = Color.White;
            level5SlctBtn.BackColor = Color.White;
        }

        private void level3SlctBtn_Click(object sender, EventArgs e)
        {
            selectedLevel = 3;
            level1SlctBtn.BackColor = Color.White;
            level2SlctBtn.BackColor = Color.White;
            level3SlctBtn.BackColor = Color.DodgerBlue;
            level4SlctBtn.BackColor = Color.White;
            level5SlctBtn.BackColor = Color.White;
        }

        private void level4SlctBtn_Click(object sender, EventArgs e)
        {
            selectedLevel = 4;
            level1SlctBtn.BackColor = Color.White;
            level2SlctBtn.BackColor = Color.White;
            level3SlctBtn.BackColor = Color.White;
            level4SlctBtn.BackColor = Color.DodgerBlue;
            level5SlctBtn.BackColor = Color.White;
        }

        private void level5SlctBtn_Click(object sender, EventArgs e)
        {
            selectedLevel = 5;
            level1SlctBtn.BackColor = Color.White;
            level2SlctBtn.BackColor = Color.White;
            level3SlctBtn.BackColor = Color.White;
            level4SlctBtn.BackColor = Color.White;
            level5SlctBtn.BackColor = Color.DodgerBlue;
        }
    }
}