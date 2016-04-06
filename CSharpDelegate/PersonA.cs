using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegate1
{
    class PersonA
    {
        public PersonA(Ball ball)
        {
            ball.ballEvent += DoSomething;
        }

        public void DoSomething(object sender, BallEventArgs e)
        {
            if(e.Speed > 100)
                Console.WriteLine("PersonA: too fast, speed = " + e.Speed);
            else
                Console.WriteLine("PersonA: too slow, speed = " + e.Speed);

            if(e.Height > 30)
                Console.WriteLine("PersonA: too hight, height = " + e.Height);
            else
                Console.WriteLine("PersonA: too low, height = " + e.Height);
        }
    }
}
