using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace ElementaryMathGame
{

    public partial class Form1 : Form
    {
        
        List<Question> additionQuestions = new List<Question>();
        Level levelFirstAddition = new Level("levelFirstAddition", 100);
        Level levelSecondAddition = new Level("levelSecondAddition", 200);
        Level levelThirdAddition = new Level("levelThirdAdditon", 300);
        Level levelFourthAddition = new Level("levelFourthAddition", 400);
        Level levelFifthAddition = new Level("levelFifthAddition", 500);

        public Form1()
        {
            InitializeComponent();
            string additionQuestionsJSON = System.IO.File.ReadAllText("additionQuestions.json");
            Question.initializeQuestionsFromJSON(ref additionQuestionsJSON, ref additionQuestions);
            Level.initializeLevelQuestions(additionQuestions, ref levelFirstAddition, 1);
            Level.initializeLevelQuestions(additionQuestions, ref levelSecondAddition, 2);
            Level.initializeLevelQuestions(additionQuestions, ref levelThirdAddition, 3);
            Level.initializeLevelQuestions(additionQuestions, ref levelFourthAddition, 4);
            Level.initializeLevelQuestions(additionQuestions, ref levelFifthAddition, 5);

        }

        private void testButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(", ", levelFifthAddition));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void L1Btn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}