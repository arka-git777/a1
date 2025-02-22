using System;
using System.Linq;
using System.Windows.Forms;
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

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (result == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        //private void button3_MouseHover(object sender, EventArgs e)
        //{
        //    Random random = new Random();
        //    int newX = random.Next(0, this.ClientSize.Width - button3.Width);
        //    int newY = random.Next(0, this.ClientSize.Height - button3.Height);

        //    button3.Location = new Point(newX, newY);
        //}

        private void restart_button_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                restart_button.Location = new Point(
                    Cursor.Position.X - restart_button.Parent.PointToScreen(Point.Empty).X - restart_button.Width / 2,
                    Cursor.Position.Y - restart_button.Parent.PointToScreen(Point.Empty).Y - restart_button.Height / 2
                );
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                label1.Location = new Point(
                    Cursor.Position.X - label1.Parent.PointToScreen(Point.Empty).X - label1.Width / 2,
                    Cursor.Position.Y - label1.Parent.PointToScreen(Point.Empty).Y - label1.Height / 2
                );
            }
        }
    }
}
