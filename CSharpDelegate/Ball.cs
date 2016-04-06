using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegate1
{
    delegate void ballInPlayHandler(object sender, BallEventArgs e); // declare delegate (method 2)
    class Ball
    {
        public event ballInPlayHandler ballEvent; // declare event (method 2)
        //public event Action<object, BallEventArgs> ballEvent;

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
                ballEvent(this, new BallEventArgs { Speed = 75, Height = 20 });
        }
    }
}
