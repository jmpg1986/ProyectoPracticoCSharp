using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGameCenter
{
    public class Player
    {
        //Declarando miembros
        #region Members
        private string nickname;

        public string Nickname
        {
            get { return nickname; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private Countries country;

        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }

        public Player()
        {
        }

        #endregion

        //Constructores & Equals
        #region Constructors & Equals

        public Player(string nickname, string email, Countries country)
        {
            this.nickname = nickname;
            this.email = email;
            this.country = country;
        }

        public Player(string data)
        {

        }

        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                Player other = (Player)obj;
                return this.nickname == other.nickname;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Nickname, Email, Country);
        }


        #endregion  
    }
}
