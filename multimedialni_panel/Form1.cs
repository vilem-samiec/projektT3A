using System.Media;
using System.Windows.Forms;
using System.IO;

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

        private void Moznosti_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void logaTýmuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoga form = new FormLoga();
            form.ShowDialog();
        }

        private void Multimedial_panel_zapas_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Loga");
            Directory.CreateDirectory(path);
        }
    }
}
