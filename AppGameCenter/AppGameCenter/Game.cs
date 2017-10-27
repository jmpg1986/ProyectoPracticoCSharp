using System;
using System.Collections.Generic;

namespace AppGameCenter
{
    public class Game
    {

        //declaro los miembros de la clase Game
        #region Members

        private string name;

        public string Name
        {
            get { return name; }
        }

        private Genres genres;

        public Genres Genres
        {
            get { return genres; }
        }

        private List<Platforms> platforms;

        public List<Platforms> Platforms
        {
            get { return platforms; }
        }

        private int releasedate;

        public int Releasedate
        {
            get { return releasedate; }
        }

        private Dictionary<List<Platforms>, List<Score>> rankings;

        public Dictionary<List<Platforms>, List<Score>> Rankings
        {
            get { return rankings; }
        }

        #endregion

        //Constructores & Equals
        #region Constructors & equals

        public Game(string name, int releasedate, List<Platforms> platforms, Genres genres, Dictionary<List<Platforms>, List<Score>> rankings)
        {
            this.name = name;
            if (releasedate > 1980 && releasedate < 2018)
            {
                this.releasedate = releasedate;
            }
            else
            {
                this.releasedate = 0000;
            }
            this.platforms = platforms;
            this.genres = genres;
            this.rankings = rankings;
        }

        public override bool Equals(object obj)
        {
            if (obj is Game aux)
            {
                return this.name == aux.name;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string s = "---" + Name + "(" + Releasedate + ") - " + Platforms + " - " + Genres + " ---\n" + "Rankings:\n";
            return s;
        }



        #endregion
    }
}
