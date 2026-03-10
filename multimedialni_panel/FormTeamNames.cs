using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multimedialni_panel
{
    public partial class FormTeamNames : Form
    {
        public FormTeamNames()
        {
            InitializeComponent();
        }

        private void FormTeamNames_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Loga", "teams.txt");

            if (File.Exists(path))
            {
                string[] teams = File.ReadAllLines(path);

                if (teams.Length >= 2)
                {
                    txtHomeTeam.Text = teams[0];
                    txtAwayTeam.Text = teams[1];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Loga", "teams.txt");

            string[] teams =
            {
                txtHomeTeam.Text,
                txtAwayTeam.Text
            };

            File.WriteAllLines(path, teams);

            MessageBox.Show("Jména týmů byla uložena.");
        }
    }
}
