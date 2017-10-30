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

        #region Constructores y equals

        


        public Score(string nickname, string email, Countries country, int points)
        {
            this.points = points;
        }

        public Score() : base()
        {

        }

        public Score(Player player1, int points)
        {

            this.points = points;
        }

        public override string ToString()
        {
            string res = "";
            res = string.Format("{0}-{1}", this.Nickname, this.Points);
            return res;
        }
        
        #endregion

    }
}
