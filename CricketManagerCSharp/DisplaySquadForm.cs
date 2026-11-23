using System;
using System.Collections;
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
    public partial class DisplaySquadForm : Form
    {
        List<Player> squad = new List<Player>();
        public DisplaySquadForm()
        {
            for (int i = 0; i < 20; i++)
            {
                squad.Add(new Player());
            }
            InitializeComponent();
        }

        private void DisplayPlayerDetailsBtn_Click(object sender, EventArgs e)
        {
            if(squadListCmbx.Text == "")
            {
                MessageBox.Show("No Player Selected");
            }
            else
            {
                foreach (Player player in squad)
                {
                    if(player.getFullName() == squadListCmbx.Text)
                    {
                        DisplayPlayerForm form = new DisplayPlayerForm(player);
                        form.Show();
                    }
                }
            }
        }

        private void DisplaySquadForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                squadListCmbx.Items.Add(squad[i].getFullName());
            }
        }
    }
}
