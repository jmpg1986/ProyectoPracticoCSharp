using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGameCenter
{
    public class Score
    {
        //Declaro miembros
        #region Members
        private string nickname;

        public string Nickname
        {
            get { return nickname; }
        }

        private int points;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
        #endregion

        //Constructores y equals

        #region Constructors & equals
        
        public Score()
        {
            this.nickname = "unknown";
            this.points = 0;
        }
        
        public Score(string nickname, int points)
        {
            this.nickname = nickname;
            this.points = points;
        }

        public override string ToString()
        {
            string s = Nickname + " - " + Points;
            return s;
        }
        #endregion

    }
}
