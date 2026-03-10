using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace multimedialni_panel
{
    public partial class Multimedial_panel_zapas : Form
    {
        public Multimedial_panel_zapas()
        {
            InitializeComponent();
        }

        int scoreHome = 0;
        int scoreAway = 0;
        int totalMinutes;      // celková doba zápasu
        int currentMinutes;    // zobrazený èas
        int currentSeconds;
        int currentPeriod;     // èíslo tøetiny / poloèasu
        int totalPeriods;      // kolik period má sport

        void LoadLogos()
        {
            string home = Path.Combine(Application.StartupPath, "Loga", "home.png");
            string away = Path.Combine(Application.StartupPath, "Loga", "away.png");

            if (File.Exists(home))
            {
                pictureHomeTeam.Image = Image.FromFile(home);
            }

            if (File.Exists(away))
            {
                pictureAwayTeam.Image = Image.FromFile(away);
            }
        }

        void LoadTeams()
        {
            string path = Path.Combine(Application.StartupPath, "Loga", "teams.txt");

            if (File.Exists(path))
            {
                string[] teams = File.ReadAllLines(path);

                if (teams.Length >= 2)
                {
                    labelHomeTeam.Text = teams[0];
                    labelAwayTeam.Text = teams[1];
                }
            }
        }

        void ResetMatch()
        {
            scoreHome = 0;
            scoreAway = 0;

            labelScoreHome.Text = "0";
            labelScoreAway.Text = "0";

            labelTime.Text = "00:00";

            labelFoulsHome.Text = "0";
            labelFoulsAway.Text = "0";
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
            scoreHome++;
            labelScoreHome.Text = scoreHome.ToString();
            SoundPlayer player = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
        }

        private void button_goal_horn_h_Click(object sender, EventArgs e)
        {
            scoreAway++;
            labelScoreAway.Text = scoreAway.ToString();
            SoundPlayer player = new SoundPlayer(@"C:\Windows\Media\chimes.wav");
        }

        private void Moznosti_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void logaTýmuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoga form = new FormLoga();
            form.ShowDialog();

            LoadLogos();
        }

        private void Multimedial_panel_zapas_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Loga");
            Directory.CreateDirectory(path);

            LoadTeams();
            LoadLogos();
        }

        private void jménaTýmùToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeamNames form = new FormTeamNames();
            form.ShowDialog();

            LoadTeams();
        }

        private void novýZápasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Opravdu chcete zaèít nový zápas?",
        "Nový zápas",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ResetMatch();
            }
        }

        private void odebratDomácíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scoreHome > 0)
            {
                scoreHome--;
                labelScoreHome.Text = scoreHome.ToString();
            }
        }

        private void odebratHostéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scoreAway > 0)
            {
                scoreAway--;
                labelScoreAway.Text = scoreAway.ToString();
            }
        }

        private void hokejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalPeriods = 3;
            currentPeriod = 1;
            totalMinutes = 20; // hokejová tøetina 20 minut
            currentMinutes = totalMinutes;
            currentSeconds = 0;

            labelPeriod.Text = $"Tøetina: {currentPeriod}/{totalPeriods}";
            labelTime.Text = $"{currentMinutes:D2}:{currentSeconds:D2}";

            StartTimer();
        }

        private void fotbalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalPeriods = 2;
            currentPeriod = 1;
            totalMinutes = 45; // poloèas 45 minut
            currentMinutes = totalMinutes;
            currentSeconds = 0;

            labelPeriod.Text = $"Poloèas: {currentPeriod}/{totalPeriods}";
            labelTime.Text = $"{currentMinutes:D2}:{currentSeconds:D2}";

            StartTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentSeconds == 0)
            {
                if (currentMinutes == 0)
                {
                    // konec period
                    if (currentPeriod < totalPeriods)
                    {
                        currentPeriod++;
                        currentMinutes = totalMinutes;
                        currentSeconds = 0;
                        UpdatePeriodLabel();
                    }
                    else
                    {
                        // konec zápasu
                        gameTimer.Stop();
                        MessageBox.Show("Konec zápasu!");
                    }
                    return;
                }
                currentMinutes--;
                currentSeconds = 59;
            }
            else
            {
                currentSeconds--;
            }

            labelTime.Text = $"{currentMinutes:D2}:{currentSeconds:D2}";
        }
    }
}
