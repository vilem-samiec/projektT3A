using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Media;

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

            labelFoulsHome.Text = "00:00";
            labelFoulsAway.Text = "00:00";
            foulHomeSeconds = 0;
            foulAwaySeconds = 0;

            // stop foul timers
            try { timer2.Stop(); } catch { }
            try { timer3.Stop(); } catch { }
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
                this.ResetMatch();
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

        }
        private void UpdatePeriodLabel()
        {
            if (totalPeriods == 3)
            {
                labelPeriod.Text = $"Tøetina: {currentPeriod}/{totalPeriods}";
            }
            else if (totalPeriods == 2)
            {
                labelPeriod.Text = $"Poloèas: {currentPeriod}/{totalPeriods}";
            }
            else
            {
                labelPeriod.Text = $"Perioda: {currentPeriod}/{totalPeriods}";
            }
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
                        timer1.Stop();
                        // Update UI to reflect finished match
                        button3.Text = "START";
                        button3.BackColor = Color.Green;

                        // stop foul timers as well
                        try { timer2.Stop(); } catch { }
                        try { timer3.Stop(); } catch { }
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

        // Ensure that match timing is set before starting the timer
        private void EnsureMatchSetup()
        {
            if (totalMinutes == 0 || totalPeriods == 0)
            {
                // default to fotbal if sport not selected
                totalPeriods = 2;
                currentPeriod = 1;
                totalMinutes = 45;
                currentMinutes = totalMinutes;
                currentSeconds = 0;
                UpdatePeriodLabel();
                labelTime.Text = $"{currentMinutes:D2}:{currentSeconds:D2}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnsureMatchSetup();

            if (!timer1.Enabled)
            {
                timer1.Start();
                button3.Text = "STOP";
                button3.BackColor = Color.Red;
                // start foul timers only if there is remaining foul time
                if (foulHomeSeconds > 0)
                    timer2.Start();
                if (foulAwaySeconds > 0)
                    timer3.Start();
            }
            else
            {
                timer1.Stop();
                button3.Text = "START";
                button3.BackColor = Color.Green;
                // pause foul timers as well
                try { timer2.Stop(); } catch { }
                try { timer3.Stop(); } catch { }
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            // Pause / Resume logic
            if (!timer1.Enabled)
            {
                // resume
                timer1.Start();
                // ensure start button shows stop
                button3.Text = "STOP";
                button3.BackColor = Color.Red;
                if (foulHomeSeconds > 0)
                    timer2.Start();
                if (foulAwaySeconds > 0)
                    timer3.Start();
            }
            else
            {
                // pause
                timer1.Stop();
                try { timer2.Stop(); } catch { }
                try { timer3.Stop(); } catch { }
            }
        }

        private void kONECToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int foulHomeSeconds = 0;
        private int foulAwaySeconds = 0;

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var help = new FormHelp()) { help.FormBorderStyle = FormBorderStyle.None; help.StartPosition = FormStartPosition.Manual; var bounds = Screen.FromControl(this).Bounds; help.Bounds = bounds; help.TopMost = true; help.ShowDialog(this); }

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var about = new FormAbout()) { about.FormBorderStyle = FormBorderStyle.None; about.StartPosition = FormStartPosition.Manual; var bounds = Screen.FromControl(this).Bounds; about.Bounds = bounds; about.TopMost = true; about.ShowDialog(this); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var faul = new FormFaul()) { faul.FormBorderStyle = FormBorderStyle.None; faul.StartPosition = FormStartPosition.Manual; var bounds = Screen.FromControl(this).Bounds; faul.Bounds = bounds; faul.TopMost = true; faul.ShowDialog(this); }
        }

        // --- nové pomocné metody pro FormFaul (minuty) ---
        public int GetFoulHomeMinutes()
        {
            return foulHomeSeconds / 60;
        }

        public int GetFoulAwayMinutes()
        {
            return foulAwaySeconds / 60;
        }

        public void SetFoulHomeMinutes(int minutes)
        {
            if (minutes < 0) minutes = 0;
            // If the foul timer is already running or a foul is already set, do not overwrite
            if ((timer2 != null && timer2.Enabled) || foulHomeSeconds > 0)
                return;

            foulHomeSeconds = minutes * 60;
            UpdateFoulsHomeLabel();
        }

        public void SetFoulAwayMinutes(int minutes)
        {
            if (minutes < 0) minutes = 0;
            // If the foul timer is already running or a foul is already set, do not overwrite
            if ((timer3 != null && timer3.Enabled) || foulAwaySeconds > 0)
                return;

            foulAwaySeconds = minutes * 60;
            UpdateFoulsAwayLabel();
        }

        private void UpdateFoulsHomeLabel()
        {
            var mm = foulHomeSeconds / 60;
            var ss = foulHomeSeconds % 60;
            labelFoulsHome.Text = $"{mm:D2}:{ss:D2}";
        }

        private void UpdateFoulsAwayLabel()
        {
            var mm = foulAwaySeconds / 60;
            var ss = foulAwaySeconds % 60;
            labelFoulsAway.Text = $"{mm:D2}:{ss:D2}";
        }

        // Tick handler for home foul timer (timer2)
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (foulHomeSeconds > 0)
            {
                foulHomeSeconds--;
                UpdateFoulsHomeLabel();

                if (foulHomeSeconds == 0)
                {
                    try { timer2.Stop(); } catch { }
                    // optional: play sound or flash label
                }
            }
            else
            {
                try { timer2.Stop(); } catch { }
            }
        }

        // Tick handler for away foul timer (timer3)
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (foulAwaySeconds > 0)
            {
                foulAwaySeconds--;
                UpdateFoulsAwayLabel();

                if (foulAwaySeconds == 0)
                {
                    try { timer3.Stop(); } catch { }
                    // optional: play sound or flash label
                }
            }
            else
            {
                try { timer3.Stop(); } catch { }
            }
        }

        private void pøidatPerioduToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // increase total number of periods and update label
            totalPeriods++;
            // ensure currentPeriod is not greater than totalPeriods
            if (currentPeriod > totalPeriods)
                currentPeriod = totalPeriods;

            UpdatePeriodLabel();
        }

        private void nastavitVyššíPerioduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // increase the displayed current period (the number before '/') up to totalPeriods
            if (totalPeriods == 0)
            {
                // default to single period if none configured
                totalPeriods = 1;
            }

            if (currentPeriod < totalPeriods)
            {
                currentPeriod++;
            }
            else if (currentPeriod == 0)
            {
                currentPeriod = 1;
            }

            UpdatePeriodLabel();
        }

        private void nastavitNižsíPerioduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // decrease the displayed current period (the number before '/') but not below 0
            if (currentPeriod > 0)
            {
                currentPeriod--;
            }

            // if currentPeriod becomes greater than totalPeriods, clamp it
            if (totalPeriods > 0 && currentPeriod > totalPeriods)
                currentPeriod = totalPeriods;

            UpdatePeriodLabel();
        }

        private void odebratPerioduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove one period from totalPeriods (but not below 0)
            if (totalPeriods > 0)
            {
                totalPeriods--;
            }

            // adjust currentPeriod if it is now out of range
            if (totalPeriods == 0)
            {
                currentPeriod = 0;
            }
            else if (currentPeriod > totalPeriods)
            {
                currentPeriod = totalPeriods;
            }

            UpdatePeriodLabel();
        }


    }
}