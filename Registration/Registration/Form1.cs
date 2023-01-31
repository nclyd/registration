using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {

        private static List<Player> players;
        private Image[] avatar;
        public Form1()
        {
            InitializeComponent();
            Players = new List<Player>();
            
        }

        private void PopulateAvatars()
        {
            avatar = new Image[2];
            avatar[0] = Properties.Resources.avatar1;
            avatar[1] = Properties.Resources.avatar2;

        }

        public static List<Player> Players { get => players; set => players = value; }

       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Player currentPlayer = new Player();
            try
            {


                currentPlayer.Avatar = pBoxAvatar.Image;
                currentPlayer.Username = Convert.ToString(tboxUsername);
                currentPlayer.Password = Convert.ToString(tboxPassword);
                currentPlayer.Forename = Convert.ToString(tboxForename);
                currentPlayer.Surname = Convert.ToString(tboxSurname);
                MessageBox.Show("Created!");
                players.Add(currentPlayer);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLeftCycle_Click(object sender, EventArgs e)
        {
            pBoxAvatar.Image = Properties.Resources.avatar1;
        }

        private void btnRightCycle_Click(object sender, EventArgs e)
        {
            pBoxAvatar.Image = Properties.Resources.avatar2;
        }
    }
}
