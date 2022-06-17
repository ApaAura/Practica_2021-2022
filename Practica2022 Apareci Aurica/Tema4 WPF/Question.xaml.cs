using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tema4_WPF
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class Question : Window
    {
        int correctAnswer;
        int questionNumber = 1;
        int score = 0;
        int percentage;
        int totalQuestions;
        public Question()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aplicatia a fost inchisa !");
            Environment.Exit(0);
        }
        private void askQuestion(int questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    label1.Content = "In ce an a fost adoptata declaratia de independenta \n                               a Republici Moldova ?";
                    button1.Content = "1991";
                    button2.Content = "2001";
                    button3.Content = "1990";
                    button4.Content = "1989";
                    correctAnswer = 1; break;
                case 2:
                    label1.Content = "Cine a fost primul presedinte al Republicii Moldova ?";
                    button1.Content = "Petru Lucinschi";
                    button2.Content = "Alexandru Mosanu";
                    button3.Content = "Mircea Snegur";
                    button4.Content = "Dumitru Motpan";
                    correctAnswer = 3; break;
                case 3:
                    label1.Content = "De la ce provine numele Moldova ?";
                    button1.Content = "Sort de vita de vie";
                    button2.Content = "Nume de catelus";
                    button3.Content = "Muntele Moldavia";
                    button4.Content = "Raul Moldova";
                    correctAnswer = 4; break;
                case 4:
                    label1.Content = "Cand este sarbatorita ziua limbii romane ?";
                    button2.Content = "14 martie";
                    button3.Content = "27 august";
                    button4.Content = "10 decembrie";
                    correctAnswer = 1; break;
                case 5:
                    label1.Content = "In ce an fost an fosta Republica Unionala RSSM este redenumita\n                                             Republica Moldova ? ";
                    button1.Content= "1991";
                    button2.Content = "1990";
                    button3.Content = "1989";
                    button4.Content = "1997";
                    correctAnswer = 2; break;
                case 6:
                    label1.Content = "In ce an a fost adoptata Constitutia Republicii Moldova ?";
                    button1.Content = "1999";
                    button2.Content = "2001";
                    button3.Content = "1991";
                    button4.Content= "1994";
                    correctAnswer = 4; break;
                case 7:
                    label1.Content = "Ce eveniment important a avut loc in data de 2 martie 1992 ?";
                    button1.Content= "Dezbateri ";
                    button2.Content= "Alegeri";
                    button3.Content = "Integrarea in ONU";
                    button4.Content = "Razboi civil";
                    correctAnswer = 3; break;
                case 8:
                    label1.Content = "Care personalitate este cunoscuta drept domnitorul cu cea mai lunga\n                                     domnie in Tara Moldovei ?";
                    button1.Content = "Stefan cel Mare";
                    button2.Content = "Mircea cel Batran";
                    button3.Content = "Alexandru cel Bun";
                    button4.Content = "Decebal";
                    correctAnswer = 1; break;
                case 9:
                    label1.Content = "In ce creatie Dimitrie Cantemir descrie caracteristica geografica,\n                                     politica si sociala a Tarii Moldovei ?";
                    button1.Content = "Tinuturi misterioase";
                    button2.Content = "Moldova";
                    button3.Content = "Descrierea Moldovei";
                    button4.Content = "Letopisetul Tarii Moldovei";
                    correctAnswer = 3; break;
                case 10:
                    label1.Content = "Cine este considerata Primadona Operei Nationale din Republica Moldova ?";
                    button1.Content = "Irina Arkhipova";
                    button2.Content = "Maria Biesu";
                    button3.Content = "Maria Cebotari";
                    button4.Content = "Bela Rudenko";
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
