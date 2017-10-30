using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AppGameCenter
{


    public class Game
    {
        private string name;

        public string Name
        {
            get { return this.name; }
        }

        private Genres genre;

        public Genres Genre
        {
            get { return genre; }
        }

        private List<Platforms> platforms;

        public List<Platforms> Platforms
        {
            get { return platforms; }
        }

        private int releaseDate;

        public int ReleaseDate
        {
            get { return this.releaseDate; }
        }

        private Dictionary<Platforms, Ranking> rankings;


        public Dictionary<Platforms, Ranking> Rankings
        {
            get { return this.rankings; }
        }


        //criterio de Igualdad
        public override bool Equals(object obj)
        {
            bool r = false;
            if (obj is Game)
            {
                Game g = (Game)obj;
                r = g.name == this.Name;
            }
            return r;
        }

        //Cadena de texto

        public override string ToString()
        {
            string s = "";
            s = string.Format("---{0}({1}-)", this.Name, this.ReleaseDate);
            foreach (Platforms plataform in this.Platforms)
            {
                s += string.Format("{0},", plataform);
            }
            s += string.Format("-{0}---", this.Genre);
            foreach (Platforms ranking in this.Rankings.Keys)
            {
                s += string.Format("-{0}({1})", this.Rankings[ranking].Name, this.Rankings[ranking].Scores.Count);
            }
            return s;
        }




        #region Constructores
        public Game(string name, Genres genre, List<Platforms> plataforms, int releaseDate, Dictionary<Platforms, Ranking> rankings)
        {
            this.name = name;
            this.genre = genre;
            this.platforms = plataforms;
            if (releaseDate >= 1980 && releaseDate <= 2018)
            {
                this.releaseDate = releaseDate;
            }
            else
            {
                System.Console.WriteLine("La fecha no entra en el rango de valores [1980-2018]");

            }

            this.rankings = rankings;
        }

        #endregion

    }
}
