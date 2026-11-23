using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medallion;

namespace CricketManagerCSharp
{
    public class Player
    {
        #region Player Details
        private string forename;
        private string surname;
        private string fullName;
        private int age;
        private string bowlStyle;
        private string role;
        private bool isRightHanded;
        #endregion
        #region Simulation Details
        //misc
        private int bowlStyleInt;
        //physical
        private float avgBowlSpeed;
        private float height;
        private float runSpeed;
        private float power;
        //bowling
        private float bowlAbility;
        private float lengthAccuracy;
        private float lineAccuracy;
        private float swing;
        private float seam;
        private float spin;
        private float bounce;
        private float paceVariation;
        #endregion
        public Player(string role, float baseAbility)
        {
            Random rnd = new Random();
            forename = Globals.engFNames[rnd.Next(Globals.engFNames.Length)];
            surname = Globals.engSNames[rnd.Next(Globals.engSNames.Length)];
            fullName = forename + " " + surname;
        }
        public Player()
        {
            Random rnd = new Random();
            forename = Globals.engFNames[rnd.Next(Globals.engFNames.Length)];
            surname = Globals.engSNames[rnd.Next(Globals.engSNames.Length)];
            fullName = forename + " " + surname;
            role = Globals.roles[rnd.NextInt64(Globals.roles.Length)];
            age = rnd.Next(17, 46);
            int temp = rnd.Next(1, 6);
            if (temp == 1)
            {
                isRightHanded = false;
                bowlStyle = Globals.leftHandBowlStyles[rnd.Next(Globals.leftHandBowlStyles.Length)];
                if (bowlStyle == "LSeam")
                {
                    avgBowlSpeed = (float)Globals.NextGaussian(rnd, 83, 4);
                    if (avgBowlSpeed > 95)
                    {
                        avgBowlSpeed = 95;
                    }
                    else if (avgBowlSpeed < 65)
                    {
                        avgBowlSpeed = 65;
                    }
                    if (avgBowlSpeed <= 78)
                    {
                        bowlStyle = "LM";
                    }
                    else if (avgBowlSpeed <= 83)
                    {
                        bowlStyle = "LFM";
                    }
                    else if (avgBowlSpeed <= 87)
                    {
                        bowlStyle = "LMF";
                    }
                    else
                    {
                        bowlStyle = "LF";
                    }
                }
                else
                {
                    avgBowlSpeed = (float)Globals.NextGaussian(rnd, 50, 5);
                    if (avgBowlSpeed > 65)
                    {
                        avgBowlSpeed = 65;
                    }
                    else if (avgBowlSpeed < 40)
                    {
                        avgBowlSpeed = 40;
                    }
                }
            }
            else
            {
                isRightHanded = true;
                bowlStyle = Globals.rightHandBowlStyles[rnd.Next(Globals.rightHandBowlStyles.Length)];
                if (bowlStyle == "RSeam")
                {
                    avgBowlSpeed = (float)Globals.NextGaussian(rnd, 83, 4);
                    if (avgBowlSpeed > 95)
                    {
                        avgBowlSpeed = 95;
                    }
                    else if (avgBowlSpeed < 65)
                    {
                        avgBowlSpeed = 65;
                    }
                    if (avgBowlSpeed <= 78)
                    {
                        bowlStyle = "RM";
                    }
                    else if (avgBowlSpeed <= 83)
                    {
                        bowlStyle = "RFM";
                    }
                    else if (avgBowlSpeed <= 87)
                    {
                        bowlStyle = "RMF";
                    }
                    else
                    {
                        bowlStyle = "RF";
                    }
                }
                else
                {
                    avgBowlSpeed = (float)Globals.NextGaussian(rnd, 50, 5);
                    if (avgBowlSpeed > 65)
                    {
                        avgBowlSpeed = 65;
                    }
                    else if (avgBowlSpeed < 40)
                    {
                        avgBowlSpeed = 40;
                    }
                }
            }
            bowlStyleInt = Globals.bowlStyleToInt(bowlStyle);
        }
        #region getters
        public string getFullName()
        {
            return fullName;
        }
        public int getAge()
        {
            return age;
        }
        public string getBowlStyle()
        {
            return bowlStyle;
        }
        public string getRole()
        {
            return role;
        }
        #endregion
        #region Match Actions
        public Ball bowlBall(Player batter)
        {
            return new Ball();
        }
        #endregion
    }
}
