using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Forms
{
    public partial class Form2 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score=0;
        int percentage;
        int totalQuestions;
        Label label1;
        Button button1, button2, button3, button4;
        public Form2()
        {
            InitializeComponent();
            Default1();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }
        private void Default1()
        {
            Size = new Size(850, 550);
            Text = "Quiz";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;

            label1 = new Label();
            label1.Text = " ";
            label1.Location = new Point(120, 110);
            label1.Size = new Size(640, 90);
            label1.Font = new Font("Cambria", 20);
            label1.BackColor = Color.White;
            Controls.Add(label1);

            button1 = new Button();
            button1.Text = "";
            button1.Tag = 1;
            button1.Location = new Point(170,260);
            button1.Size = new Size(190,40);
            button1.Font = new Font("Cambria", 14);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(34, 42, 53);
            button1.BackColor = Color.White;
            button1.Click += checkAnswerEvent;
            Controls.Add(button1);

            button2 = new Button();
            button2.Text = " ";
            button2.Tag = 2;
            button2.Size=new Size(190,40);
            button2.Location = new Point(500,260);
            button2.Font = new Font("Cambria", 14);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(34, 42, 53);
            button2.BackColor = Color.White;
            button2.Click += checkAnswerEvent;
            Controls.Add(button2);

            button3 = new Button();
            button3.Text = "";
            button3.Tag = 3;
            button3.Location = new Point(170,330); 
            button3.Size = new Size(190,40);
            button3.Font = new Font("Cambria", 14);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(34, 42, 53);
            button3.BackColor = Color.White;
            button3.Click += checkAnswerEvent;
            Controls.Add(button3);

            button4 = new Button();
            button4.Text = "";
            button4.Tag = 4;
            button4.Location = new Point(500,330);
            button4.Size = new Size(190,40);
            button4.Font = new Font("Cambria", 14);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(34, 42, 53);
            button4.BackColor = Color.White;
            button4.Click += checkAnswerEvent;
            Controls.Add(button4);

            Button button5 = new Button();
            button5.Text = "Exit";
            button5.Location = new Point(710, 20);
            button5.Size = new Size(100, 30);
            button5.Font = new Font("Cambria", 12);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(34, 42, 53);
            button5.BackColor = Color.White;
            button5.Click += Button5_Click;
            Controls.Add(button5);
        }
        private void Button5_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Aplicatia a fost inchisa !");
            Environment.Exit(0);
        }
        private void askQuestion(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    label1.Text = "In ce an a fost adoptata declaratia de independenta                                  a Republici Moldova ?";
                    button1.Text = "1991";
                    button2.Text = "2001";
                    button3.Text = "1990";
                    button4.Text = "1989";
                    correctAnswer = 1; break;
                case 2:
                    label1.Text = "Cine a fost primul presedinte al Republicii Moldova ?";
                    label1.Location = new Point(120,120);
                    label1.Size = new Size(640, 60);
                    button1.Text = "Petru Lucinschi";
                    button2.Text = "Alexandru Mosanu";
                    button3.Text = "Mircea Snegur";
                    button4.Text = "Dumitru Motpan";
                    correctAnswer = 3; break; 
                case 3:
                    label1.Text = "De la ce provine numele Moldova ?";
                    label1.Location = new Point(235, 120);
                    label1.Size = new Size(500, 60);
                    button1.Text = "Sort de vita de vie";
                    button2.Text = "Nume de catelus";
                    button3.Text = "Muntele Moldavia";
                    button4.Text = "Raul Moldova";
                    correctAnswer = 4; break;
                case 4:
                    label1.Text = "Cand este sarbatorita ziua limbii romane ?";
                    label1.Location = new Point(180, 120);
                    button1.Text = "31 august";
                    button2.Text = "14 martie";
                    button3.Text = "27 august";
                    button4.Text = "10 decembrie";
                    correctAnswer = 1; break;
                case 5:
                    label1.Text = "In ce an fost an fosta Republica Unionala RSSM este                         redenumita Republica Moldova ? ";
                    label1.Location = new Point(120, 110);
                    label1.Size = new Size(640, 90);
                    button1.Text = "1991";
                    button2.Text = "1990";
                    button3.Text = "1989";
                    button4.Text = "1997";
                    correctAnswer = 2; break;
                case 6:
                    label1.Text = "In ce an a fost adoptata Constitutia Republicii Moldova ?";
                    label1.Location = new Point(100, 120);
                    label1.Size = new Size(660, 60);
                    button1.Text = "1999";
                    button2.Text = "2001";
                    button3.Text = "1991";
                    button4.Text = "1994";
                    correctAnswer = 4; break;
                case 7:
                    label1.Text = "Ce eveniment important a avut loc in data                        de 2 martie 1992 ?";
                    label1.Location = new Point(190, 110);
                    label1.Size = new Size(500, 80);
                    button1.Text = "Dezbateri ";
                    button2.Text = "Alegeri";
                    button3.Text = "Integrarea in ONU";
                    button4.Text = "Razboi civil";
                    correctAnswer = 3; break;
                case 8:
                    label1.Text = "Care personalitate este cunoscuta drept domnitorul cu               cea mai lunga domnie in Tara Moldovei ?";
                    label1.Location = new Point(100, 110);
                    label1.Size = new Size(640, 90);
                    button1.Text = "Stefan cel Mare";
                    button2.Text = "Mircea cel Batran";
                    button3.Text = "Alexandru cel Bun";
                    button4.Text = "Decebal";
                    correctAnswer = 1; break;
                case 9:
                    label1.Text = "In ce creatie Dimitrie Cantemir descrie caracteristica           geografica, politica si sociala a Tarii Moldovei ?";
                    label1.Location = new Point(110, 110);
                    label1.Size = new Size(640, 90);
                    button1.Text = "Tinuturi misterioase";
                    button2.Text = "Moldova";
                    button3.Text = "Descrierea Moldovei";
                    button4.Text = "Letopisetul Tarii Moldovei";
                    correctAnswer = 3; break;
                case 10:
                    label1.Text = "Cine este considerata Primadona Operei Nationale                                     din Republica Moldova ?";
                    label1.Location = new Point(120, 110);
                    label1.Size = new Size(640, 90);
                    button1.Text = "Irina Arkhipova";
                    button2.Text = "Maria Biesu";
                    button3.Text = "Maria Cebotari";
                    button4.Text = "Bela Rudenko";
                    correctAnswer = 2; break;
            }
        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Jocul s-a terminat !" + Environment.NewLine +
                    "Ai raspuns corect la " + score + " intrebari." + Environment.NewLine +
                    "Procentajul tau este de " + percentage + "%" + Environment.NewLine +
                    "Click OK pentru a juca din nou !");
                score = 0;
                questionNumber = 0;
                return;
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
    }
}
