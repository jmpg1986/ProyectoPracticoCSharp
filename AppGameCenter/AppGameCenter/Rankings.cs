using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGameCenter
{
    public class Ranking
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

        public override string ToString()
        {
            string res = "";
            res = string.Format("Ranking:{0}\n", this.Name);
            for (int i = 0; i < Scores.Count; i++)
            {
                res += string.Format("{0}.{1}\n", Scores[i].ToString());
            }
            return res;
        }

        
        public Ranking(string name, List<Score> scores)
        {
            this.name = name;
            this.scores = scores;
        }
        public Ranking()
        {
            this.name = "";
            this.scores = null;
        }
        
        #endregion
    }
}
