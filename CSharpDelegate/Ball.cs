using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegate1
{
    class Ball
    {
        public event Action<object, BallEventArgs> ballEvent;

        public void BallInPlayFast()
        {
            Debug.WriteLine("BallInPlayFast()");
        }

        public void BallInPlaySlow()
        {
            Debug.WriteLine("BallInPlaySlow()");
        }
    }
}
