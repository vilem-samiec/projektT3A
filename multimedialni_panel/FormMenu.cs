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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            // Wire up buttons defined in designer
            button1.Click += Button1_Click; // NOVÝ ZÁPAS
            button2.Click += Button2_Click; // KONEC
            button3.Click += Button3_Click; // O PROGRAMU
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Open main match form and hide this menu
            var matchForm = new Multimedial_panel_zapas();
            matchForm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // Show About dialog
            using (var about = new FormAbout())
            {
                about.ShowDialog();
            }
        }
    }
}
