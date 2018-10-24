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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro Game.xaml
    /// </summary>
    public partial class Game : Page
    {
      

        private int round = 0;
        private int ans1 = 0;
        private int rightAns;
        private int points = 0;

        private Frame frame;
      
        public Game()
        {
            InitializeComponent();
            
            if (MainWindow.clicked == true)
            {
                makeQuestion();
            }

            


        }
        // DispatcherTimer
        private void makeQuestion()
        {
            answer answer1 = new answer();
            answer1 = question();

            Question.Text = (string.Format("{0} * {1}", answer1.number1, answer1.number2));
            Answer1.Content = answer1.RightAnswer;
            Answer2.Content = "997";
            ans1 = answer1.RightAnswer;
            rightAns = answer1.RightAnswer;
        }

        private answer question()
        {

            round++;
            answer Answer = new answer();
            return Answer.GetAnswer(round);

        }

        private void Answer1_Click(object sender, RoutedEventArgs e)
        {
            if ( rightAns == ans1)
            {
                points++;
                makeQuestion();
            }
            else
            {
                frame.Navigate(new Game());
            }
            points1.Content = points;
        }
    }
}
