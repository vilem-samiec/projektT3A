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
            button1.Click += Button1_Click; // NOVÝ ZÁPAS -> otevře Form1
            button2.Click += Button2_Click; // KONEC
            button3.Click += Button3_Click; // O PROGRAMU
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Otevře hlavní formulář zápasu a skryje menu
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

        private void button1_Click(object sender, EventArgs e)
        {
            // (designer může volat tuto metodu; necháváme prázdnou nebo odstranit v designeru)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
