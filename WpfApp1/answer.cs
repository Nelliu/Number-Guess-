using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class answer
    {
        public int round { get; set; }
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int RightAnswer { get; set; }


        Random rand = new Random();

        public answer GetAnswer(int round)
        {
            answer answer1 = new answer();

            

            if (round == 0)
            {
                answer1.round = round;
                answer1.number1 = rand.Next(round, 10);
                answer1.number2 = rand.Next(round, 10);
                answer1.RightAnswer = answer1.number1 * answer1.number2;
            }
            else
            {
                answer1.round = round;
                answer1.number1 = rand.Next((round * round - 1), (round * (10 + round*2)));
                int number1 = (answer1.number1 * round);
                int number2 = (round * round * round * round);
                if (number1 >= number2)
                {
                    number2 = number2 + number1;
                }

                answer1.number2 = rand.Next(number1,  number2);
                answer1.RightAnswer = answer1.number1 * answer1.number2;
            }
            


            return answer1;
            
            


        }


    }
}
