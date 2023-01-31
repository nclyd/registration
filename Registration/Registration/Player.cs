using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public class Player
    {
        private string username, password, forename, surname;
        private Image avatar;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Forename { get => forename; set => forename = value; }
        public string Surname { get => surname; set => surname = value; }
        public Image Avatar { get => avatar; set => avatar = value; }
    }
}
