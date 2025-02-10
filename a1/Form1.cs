using System.Linq;

namespace a1
{
    public partial class Form1 : Form
    {
        private string[] questions = { "2 + 2 * 2 = ?", "What is the capital city of Ukraine?", "Who is the president of USA?" };
        private string[] answers = { "6", "Kyiv", "Donald Trump" };
        private int question = 0;
        private int CorrectAnswers = 0;
        private int TotalAnswers = 0;
        private int TotalQuestions = 3;
        private List<string> history = new List<string>();
        public Form1()
        {
            InitializeComponent();
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (question < questions.Length)
            {
                question_label.Text = questions[question];
                answer_box.Text = "";
            }
            else
            {
                var result = MessageBox.Show($"Quiz over!\nCorrect Answers: {CorrectAnswers}/{TotalAnswers}\nDo you want to do it again?", "Quiz Completed", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    question = 0;
                    TotalQuestions += 3;
                    correct_label.Text = $"Correct answers: {CorrectAnswers}/{TotalAnswers + questions.Length}";
                    result_label.Text = "";
                    total_label.Text = $"Total answers: {TotalAnswers}";
                    LoadQuestion();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TotalAnswers++;
            if (string.Equals(answer_box.Text, answers[question], StringComparison.OrdinalIgnoreCase))
            {
                result_label.Text = "Correct!";
                result_label.ForeColor = Color.Green;
                CorrectAnswers++;
            }
            else
            {
                result_label.Text = "Wrong!";
                result_label.ForeColor = Color.Red;
            }

            history.Add($"Q: {questions[question]} | Your Answer: {answer_box.Text} | Correct Answer: {answers[question]}");

            correct_label.Text = $"Correct answers: {CorrectAnswers}/{TotalQuestions}";
            total_label.Text = $"Total answers: {TotalAnswers}";
            question++;
            LoadQuestion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void restart_button_Click_1(object sender, EventArgs e)
        {
            question = 0;
            CorrectAnswers = 0;
            TotalAnswers = 0;
            TotalQuestions = 3;
            history.Clear();
            correct_label.Text = "Correct answers: 0/3";
            result_label.Text = "";
            total_label.Text = "Total answers: 0";
            LoadQuestion();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
