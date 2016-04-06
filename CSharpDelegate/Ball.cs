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
            if (ballEvent != null)
                ballEvent(this, new BallEventArgs { Speed = 105, Height = 35 }); // rise event
        }

        public void BallInPlaySlow()
        {
            Debug.WriteLine("BallInPlaySlow()");
            if (ballEvent != null)
                ballEvent(this, new BallEventArgs { Speed = 105, Height = 35 }); // rise event
        }
    }
}
