using System.Media;
using System.Windows.Forms;

namespace multimedialni_panel
{
    public partial class Multimedial_panel_zapas : Form
    {
        public Multimedial_panel_zapas()
        {
            InitializeComponent();
        }

        private void button_konec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cast_zapasu_Click(object sender, EventArgs e)
        {

        }

        private void button_goal_horn_d_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
        }

        private void button_goal_horn_h_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
        }
    }
}
