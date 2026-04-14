using System;
using System.Windows.Forms;
namespace multimedialni_panel
{
    public partial class FormFaul : Form
    {
        public FormFaul()
        {
            InitializeComponent();
            // wire events
            button1.Click += Button1_Click;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            numericUpDown2.ValueChanged += NumericUpDown2_ValueChanged;
            Load += FormFaul_Load;

            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 999;
            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 999;
        }

        private void FormFaul_Load(object sender, EventArgs e)
        {
            if (this.Owner is Multimedial_panel_zapas main)
            {
                numericUpDown1.Value = main.GetFoulHomeMinutes();
                numericUpDown2.Value = main.GetFoulAwayMinutes();
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (this.Owner is Multimedial_panel_zapas main)
                main.SetFoulHomeMinutes((int)numericUpDown1.Value);
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (this.Owner is Multimedial_panel_zapas main)
                main.SetFoulAwayMinutes((int)numericUpDown2.Value);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.Owner is Multimedial_panel_zapas main)
            {
                main.SetFoulHomeMinutes((int)numericUpDown1.Value);
                main.SetFoulAwayMinutes((int)numericUpDown2.Value);
            }

            this.Close();
        }


    }
}