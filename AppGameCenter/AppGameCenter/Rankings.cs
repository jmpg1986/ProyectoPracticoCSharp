using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGameCenter
{
    public class Rankings
    {
        //declarando members
        #region Members

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Score> scores;

        public List<Score> Scores
        {
            get { return scores; }
            set { scores = value; }
        }

        #endregion
        //Constructores y equals

        #region Constructors & equals

        public Rankings(string name, List<Score> scores)
        {
            this.name = name;
            this.scores = scores;
        }

        public override string ToString()
        {
            string s = "Ranking: " + Name;
            string k = Score.Nickname + Score.Points;
            foreach (Score score in scores)
            {
                k += 
            }
            
        }

        #endregion  
    }
}
