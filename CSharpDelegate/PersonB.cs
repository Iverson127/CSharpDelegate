using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDelegate1
{
    class PersonB
    {
        public PersonB(Ball ball)
        {
            ball.ballEvent += (object sender, BallEventArgs e) => //lamda
            {
                if (e.Speed > 50)
                    Console.WriteLine("PersonB: too fast, speed = " + e.Speed);
                else
                    Console.WriteLine("PersonB: too slow, speed = " + e.Speed);

                if (e.Height > 10)
                    Console.WriteLine("PersonB: too hight, height = " + e.Height);
                else
                    Console.WriteLine("PersonB: too low, height = " + e.Height);
            };
        }
    }
}
