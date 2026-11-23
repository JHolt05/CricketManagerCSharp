namespace CricketManagerCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateTestSquadBtn_Click(object sender, EventArgs e)
        {
            DisplaySquadForm newForm = new DisplaySquadForm();
            newForm.Show();
        }
    }
}
