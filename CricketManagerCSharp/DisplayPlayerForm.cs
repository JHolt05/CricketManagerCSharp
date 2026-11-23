using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricketManagerCSharp
{
    public partial class DisplayPlayerForm : Form
    {
        Player player;
        public DisplayPlayerForm(Player iPlayer)
        {
            player = iPlayer;
            InitializeComponent();
        }

        private void DisplayPlayerForm_Load(object sender, EventArgs e)
        {
            NameLbl.Text = player.getFullName();
            AgeLbl.Text = Convert.ToString(player.getAge());
            BowlStyleLbl.Text = player.getBowlStyle();
            RoleLbl.Text = player.getRole();
        }
    }
}
