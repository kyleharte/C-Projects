using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplicationTwo
{
    [Serializable]
    class Player
    {
        public String Username;
        public int Score;

        public Player(string name)
        {
            Username = name;
            Score = 0;
        }

        public void ResetPlayer()
        {
            Username = "";
            Score = 0;
        }
        public void IncreaseScore()
        {
            Score++;
        }
    }
}
