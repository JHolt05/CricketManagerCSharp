using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CricketManagerCSharp
{
    public class Ball
    {
        private float speed; //Speed in m/s (for calculations)
        private float swing;
        private float spin;
        private float seamAngle;
        private float bounce;
        private float startLine;
        private float length;
        private float xPos; //Position relative to line
        private float yPos; //Position relative to length
        private float currentHeight; //Height of the ball off the ground
        private bool isHit;
    }
}
