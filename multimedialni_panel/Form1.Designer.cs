namespace multimedialni_panel
{
    partial class Multimedial_panel_zapas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelScoreHome = new Label();
            labelScoreAway = new Label();
            labelHomeTeam = new Label();
            labelAwayTeam = new Label();
            labelTime = new Label();
            labelFoulsHome = new Label();
            labelFoulsAway = new Label();
            pictureAwayTeam = new PictureBox();
            pictureHomeTeam = new PictureBox();
            button_goal_horn_h = new Button();
            button_goal_horn_d = new Button();
            lomeno = new Label();
            labelPeriod = new Label();
            menuStrip1 = new MenuStrip();
            možnostiToolStripMenuItem = new ToolStripMenuItem();
            novýZápasToolStripMenuItem1 = new ToolStripMenuItem();
            nastaveníToolStripMenuItem1 = new ToolStripMenuItem();
            logaTýmuToolStripMenuItem = new ToolStripMenuItem();
            jménaTýmůToolStripMenuItem = new ToolStripMenuItem();
            sportToolStripMenuItem = new ToolStripMenuItem();
            hokejToolStripMenuItem = new ToolStripMenuItem();
            fotbalToolStripMenuItem = new ToolStripMenuItem();
            kONECToolStripMenuItem1 = new ToolStripMenuItem();
            korekceSkóreToolStripMenuItem = new ToolStripMenuItem();
            odebratDomácíToolStripMenuItem = new ToolStripMenuItem();
            odebratHostéToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            oProgramuToolStripMenuItem = new ToolStripMenuItem();
            korekcePeriodyToolStripMenuItem = new ToolStripMenuItem();
            nastavitVyššíPerioduToolStripMenuItem = new ToolStripMenuItem();
            nastavitNižsíPerioduToolStripMenuItem = new ToolStripMenuItem();
            přidatPerioduToolStripMenuItem = new ToolStripMenuItem();
            odebratPerioduToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureAwayTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHomeTeam).BeginInit();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelScoreHome
            // 
            labelScoreHome.AutoSize = true;
            labelScoreHome.Dock = DockStyle.Fill;
            labelScoreHome.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            labelScoreHome.ForeColor = Color.White;
            labelScoreHome.Location = new Point(3, 0);
            labelScoreHome.Name = "labelScoreHome";
            labelScoreHome.Size = new Size(882, 136);
            labelScoreHome.TabIndex = 5;
            labelScoreHome.Text = "0";
            labelScoreHome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelScoreAway
            // 
            labelScoreAway.AutoSize = true;
            labelScoreAway.Dock = DockStyle.Fill;
            labelScoreAway.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            labelScoreAway.ForeColor = Color.White;
            labelScoreAway.Location = new Point(1088, 0);
            labelScoreAway.Name = "labelScoreAway";
            labelScoreAway.Size = new Size(883, 136);
            labelScoreAway.TabIndex = 6;
            labelScoreAway.Text = "0";
            labelScoreAway.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHomeTeam
            // 
            labelHomeTeam.AutoSize = true;
            labelHomeTeam.Dock = DockStyle.Fill;
            labelHomeTeam.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            labelHomeTeam.ForeColor = Color.White;
            labelHomeTeam.Location = new Point(3, 0);
            labelHomeTeam.Name = "labelHomeTeam";
            labelHomeTeam.Size = new Size(1285, 151);
            labelHomeTeam.TabIndex = 8;
            labelHomeTeam.Text = "NÁZEV TÝMU";
            labelHomeTeam.TextAlign = ContentAlignment.MiddleCenter;
            labelHomeTeam.Click += label1_Click;
            // 
            // labelAwayTeam
            // 
            labelAwayTeam.AutoSize = true;
            labelAwayTeam.Dock = DockStyle.Fill;
            labelAwayTeam.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            labelAwayTeam.ForeColor = Color.White;
            labelAwayTeam.Location = new Point(1294, 0);
            labelAwayTeam.Name = "labelAwayTeam";
            labelAwayTeam.Size = new Size(1285, 151);
            labelAwayTeam.TabIndex = 9;
            labelAwayTeam.Text = "NÁZEV TÝMU";
            labelAwayTeam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            labelTime.Dock = DockStyle.Fill;
            labelTime.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(3, 0);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(1968, 134);
            labelTime.TabIndex = 10;
            labelTime.Text = "ČAS";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFoulsHome
            // 
            labelFoulsHome.AutoSize = true;
            labelFoulsHome.Dock = DockStyle.Fill;
            labelFoulsHome.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            labelFoulsHome.ForeColor = Color.White;
            labelFoulsHome.Location = new Point(3, 151);
            labelFoulsHome.Name = "labelFoulsHome";
            labelFoulsHome.Size = new Size(1285, 151);
            labelFoulsHome.TabIndex = 11;
            labelFoulsHome.Text = "TREST";
            labelFoulsHome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFoulsAway
            // 
            labelFoulsAway.AutoSize = true;
            labelFoulsAway.Dock = DockStyle.Fill;
            labelFoulsAway.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            labelFoulsAway.ForeColor = Color.White;
            labelFoulsAway.Location = new Point(1294, 151);
            labelFoulsAway.Name = "labelFoulsAway";
            labelFoulsAway.Size = new Size(1285, 151);
            labelFoulsAway.TabIndex = 12;
            labelFoulsAway.Text = "TREST";
            labelFoulsAway.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureAwayTeam
            // 
            pictureAwayTeam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureAwayTeam.Location = new Point(2311, 96);
            pictureAwayTeam.Name = "pictureAwayTeam";
            pictureAwayTeam.Size = new Size(200, 200);
            pictureAwayTeam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAwayTeam.TabIndex = 13;
            pictureAwayTeam.TabStop = false;
            // 
            // pictureHomeTeam
            // 
            pictureHomeTeam.Location = new Point(95, 96);
            pictureHomeTeam.Name = "pictureHomeTeam";
            pictureHomeTeam.Size = new Size(200, 200);
            pictureHomeTeam.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHomeTeam.TabIndex = 14;
            pictureHomeTeam.TabStop = false;
            // 
            // button_goal_horn_h
            // 
            button_goal_horn_h.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_goal_horn_h.BackColor = Color.White;
            button_goal_horn_h.Cursor = Cursors.Hand;
            button_goal_horn_h.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            button_goal_horn_h.Location = new Point(1714, 776);
            button_goal_horn_h.Name = "button_goal_horn_h";
            button_goal_horn_h.Size = new Size(880, 213);
            button_goal_horn_h.TabIndex = 17;
            button_goal_horn_h.Text = "GOAL";
            button_goal_horn_h.UseVisualStyleBackColor = false;
            button_goal_horn_h.Click += button_goal_horn_h_Click;
            // 
            // button_goal_horn_d
            // 
            button_goal_horn_d.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_goal_horn_d.BackColor = Color.White;
            button_goal_horn_d.Cursor = Cursors.Hand;
            button_goal_horn_d.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            button_goal_horn_d.Location = new Point(12, 776);
            button_goal_horn_d.Name = "button_goal_horn_d";
            button_goal_horn_d.Size = new Size(882, 213);
            button_goal_horn_d.TabIndex = 16;
            button_goal_horn_d.Text = "GOAL";
            button_goal_horn_d.UseVisualStyleBackColor = false;
            button_goal_horn_d.Click += button_goal_horn_d_Click;
            // 
            // lomeno
            // 
            lomeno.AutoSize = true;
            lomeno.Dock = DockStyle.Fill;
            lomeno.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lomeno.ForeColor = Color.White;
            lomeno.Location = new Point(891, 0);
            lomeno.Name = "lomeno";
            lomeno.Size = new Size(191, 136);
            lomeno.TabIndex = 20;
            lomeno.Text = ":";
            lomeno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPeriod
            // 
            labelPeriod.AutoSize = true;
            labelPeriod.Dock = DockStyle.Fill;
            labelPeriod.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            labelPeriod.ForeColor = Color.White;
            labelPeriod.Location = new Point(3, 134);
            labelPeriod.Name = "labelPeriod";
            labelPeriod.Size = new Size(1968, 134);
            labelPeriod.TabIndex = 21;
            labelPeriod.Text = "PERIODA";
            labelPeriod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { možnostiToolStripMenuItem, korekceSkóreToolStripMenuItem, helpToolStripMenuItem, oProgramuToolStripMenuItem, korekcePeriodyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2606, 42);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // možnostiToolStripMenuItem
            // 
            možnostiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novýZápasToolStripMenuItem1, nastaveníToolStripMenuItem1, kONECToolStripMenuItem1 });
            možnostiToolStripMenuItem.Name = "možnostiToolStripMenuItem";
            možnostiToolStripMenuItem.Size = new Size(133, 38);
            možnostiToolStripMenuItem.Text = "Možnosti";
            // 
            // novýZápasToolStripMenuItem1
            // 
            novýZápasToolStripMenuItem1.Name = "novýZápasToolStripMenuItem1";
            novýZápasToolStripMenuItem1.Size = new Size(269, 44);
            novýZápasToolStripMenuItem1.Text = "Nový zápas";
            novýZápasToolStripMenuItem1.Click += novýZápasToolStripMenuItem1_Click;
            // 
            // nastaveníToolStripMenuItem1
            // 
            nastaveníToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { logaTýmuToolStripMenuItem, jménaTýmůToolStripMenuItem, sportToolStripMenuItem });
            nastaveníToolStripMenuItem1.Name = "nastaveníToolStripMenuItem1";
            nastaveníToolStripMenuItem1.Size = new Size(269, 44);
            nastaveníToolStripMenuItem1.Text = "Nastavení";
            // 
            // logaTýmuToolStripMenuItem
            // 
            logaTýmuToolStripMenuItem.Name = "logaTýmuToolStripMenuItem";
            logaTýmuToolStripMenuItem.Size = new Size(278, 44);
            logaTýmuToolStripMenuItem.Text = "Loga týmů";
            logaTýmuToolStripMenuItem.Click += logaTýmuToolStripMenuItem_Click;
            // 
            // jménaTýmůToolStripMenuItem
            // 
            jménaTýmůToolStripMenuItem.Name = "jménaTýmůToolStripMenuItem";
            jménaTýmůToolStripMenuItem.Size = new Size(278, 44);
            jménaTýmůToolStripMenuItem.Text = "Jména týmů";
            jménaTýmůToolStripMenuItem.Click += jménaTýmůToolStripMenuItem_Click;
            // 
            // sportToolStripMenuItem
            // 
            sportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hokejToolStripMenuItem, fotbalToolStripMenuItem });
            sportToolStripMenuItem.Name = "sportToolStripMenuItem";
            sportToolStripMenuItem.Size = new Size(278, 44);
            sportToolStripMenuItem.Text = "Sport";
            // 
            // hokejToolStripMenuItem
            // 
            hokejToolStripMenuItem.Name = "hokejToolStripMenuItem";
            hokejToolStripMenuItem.Size = new Size(213, 44);
            hokejToolStripMenuItem.Text = "Hokej";
            hokejToolStripMenuItem.Click += hokejToolStripMenuItem_Click;
            // 
            // fotbalToolStripMenuItem
            // 
            fotbalToolStripMenuItem.Name = "fotbalToolStripMenuItem";
            fotbalToolStripMenuItem.Size = new Size(213, 44);
            fotbalToolStripMenuItem.Text = "Fotbal";
            fotbalToolStripMenuItem.Click += fotbalToolStripMenuItem_Click;
            // 
            // kONECToolStripMenuItem1
            // 
            kONECToolStripMenuItem1.Name = "kONECToolStripMenuItem1";
            kONECToolStripMenuItem1.Size = new Size(269, 44);
            kONECToolStripMenuItem1.Text = "KONEC";
            kONECToolStripMenuItem1.Click += kONECToolStripMenuItem1_Click;
            // 
            // korekceSkóreToolStripMenuItem
            // 
            korekceSkóreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { odebratDomácíToolStripMenuItem, odebratHostéToolStripMenuItem });
            korekceSkóreToolStripMenuItem.Name = "korekceSkóreToolStripMenuItem";
            korekceSkóreToolStripMenuItem.Size = new Size(182, 38);
            korekceSkóreToolStripMenuItem.Text = "Korekce skóre";
            // 
            // odebratDomácíToolStripMenuItem
            // 
            odebratDomácíToolStripMenuItem.Name = "odebratDomácíToolStripMenuItem";
            odebratDomácíToolStripMenuItem.Size = new Size(371, 44);
            odebratDomácíToolStripMenuItem.Text = "Odebrat Bod Domácí";
            odebratDomácíToolStripMenuItem.Click += odebratDomácíToolStripMenuItem_Click;
            // 
            // odebratHostéToolStripMenuItem
            // 
            odebratHostéToolStripMenuItem.Name = "odebratHostéToolStripMenuItem";
            odebratHostéToolStripMenuItem.Size = new Size(371, 44);
            odebratHostéToolStripMenuItem.Text = "Odebrat Bod Hosté";
            odebratHostéToolStripMenuItem.Click += odebratHostéToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(84, 38);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // oProgramuToolStripMenuItem
            // 
            oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            oProgramuToolStripMenuItem.Size = new Size(164, 38);
            oProgramuToolStripMenuItem.Text = "O programu";
            oProgramuToolStripMenuItem.Click += oProgramuToolStripMenuItem_Click;
            // 
            // korekcePeriodyToolStripMenuItem
            // 
            korekcePeriodyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nastavitVyššíPerioduToolStripMenuItem, nastavitNižsíPerioduToolStripMenuItem, přidatPerioduToolStripMenuItem, odebratPerioduToolStripMenuItem });
            korekcePeriodyToolStripMenuItem.Name = "korekcePeriodyToolStripMenuItem";
            korekcePeriodyToolStripMenuItem.Size = new Size(206, 38);
            korekcePeriodyToolStripMenuItem.Text = "Korekce periody";
            // 
            // nastavitVyššíPerioduToolStripMenuItem
            // 
            nastavitVyššíPerioduToolStripMenuItem.Name = "nastavitVyššíPerioduToolStripMenuItem";
            nastavitVyššíPerioduToolStripMenuItem.Size = new Size(380, 44);
            nastavitVyššíPerioduToolStripMenuItem.Text = "Nastavit vyšší periodu";
            nastavitVyššíPerioduToolStripMenuItem.Click += nastavitVyššíPerioduToolStripMenuItem_Click;
            // 
            // nastavitNižsíPerioduToolStripMenuItem
            // 
            nastavitNižsíPerioduToolStripMenuItem.Name = "nastavitNižsíPerioduToolStripMenuItem";
            nastavitNižsíPerioduToolStripMenuItem.Size = new Size(380, 44);
            nastavitNižsíPerioduToolStripMenuItem.Text = "Nastavit nižsí periodu";
            nastavitNižsíPerioduToolStripMenuItem.Click += nastavitNižsíPerioduToolStripMenuItem_Click;
            // 
            // přidatPerioduToolStripMenuItem
            // 
            přidatPerioduToolStripMenuItem.Name = "přidatPerioduToolStripMenuItem";
            přidatPerioduToolStripMenuItem.Size = new Size(380, 44);
            přidatPerioduToolStripMenuItem.Text = "Přidat periodu";
            přidatPerioduToolStripMenuItem.Click += přidatPerioduToolStripMenuItem_Click_1;
            // 
            // odebratPerioduToolStripMenuItem
            // 
            odebratPerioduToolStripMenuItem.Name = "odebratPerioduToolStripMenuItem";
            odebratPerioduToolStripMenuItem.Size = new Size(380, 44);
            odebratPerioduToolStripMenuItem.Text = "Odebrat periodu";
            odebratPerioduToolStripMenuItem.Click += odebratPerioduToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Reem Kufi", 10F, FontStyle.Bold);
            button1.Location = new Point(12, 995);
            button1.Name = "button1";
            button1.Size = new Size(2582, 64);
            button1.TabIndex = 23;
            button1.Text = "TREST";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.BackColor = Color.Green;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Reem Kufi", 26.25F, FontStyle.Bold);
            button3.Location = new Point(1114, 1131);
            button3.Name = "button3";
            button3.Size = new Size(383, 165);
            button3.TabIndex = 25;
            button3.Text = "START";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(labelTime, 0, 0);
            tableLayoutPanel1.Controls.Add(labelPeriod, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Location = new Point(318, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1974, 404);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(labelScoreHome, 0, 0);
            tableLayoutPanel2.Controls.Add(labelScoreAway, 2, 0);
            tableLayoutPanel2.Controls.Add(lomeno, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 268);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1974, 136);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(labelHomeTeam, 0, 0);
            tableLayoutPanel3.Controls.Add(labelAwayTeam, 1, 0);
            tableLayoutPanel3.Controls.Add(labelFoulsAway, 1, 1);
            tableLayoutPanel3.Controls.Add(labelFoulsHome, 0, 1);
            tableLayoutPanel3.Location = new Point(12, 468);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(2582, 302);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // Multimedial_panel_zapas
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2606, 1308);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(button_goal_horn_h);
            Controls.Add(button_goal_horn_d);
            Controls.Add(pictureHomeTeam);
            Controls.Add(pictureAwayTeam);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Multimedial_panel_zapas";
            Text = "MULTIMEDIÁLNÍ PANEL PRO ZÁPASY";
            WindowState = FormWindowState.Maximized;
            Load += Multimedial_panel_zapas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureAwayTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHomeTeam).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        // soubor: multimedialni_panel\Form1.cs
        // (nahraďte nebo doplňte tyto metody / části)


        #endregion
        private Label labelScoreHome;
        private Label labelScoreAway;
        private Label labelHomeTeam;
        private Label labelAwayTeam;
        private Label labelTime;
        private Label labelFoulsHome;
        private Label labelFoulsAway;
        private PictureBox pictureAwayTeam;
        private PictureBox pictureHomeTeam;
        private Button button_goal_horn_h;
        private Button button_goal_horn_d;
        private Label lomeno;
        private Label labelPeriod;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem možnostiToolStripMenuItem;
        private ToolStripMenuItem novýZápasToolStripMenuItem1;
        private ToolStripMenuItem nastaveníToolStripMenuItem1;
        private ToolStripMenuItem kONECToolStripMenuItem1;
        private ToolStripMenuItem logaTýmuToolStripMenuItem;
        private ToolStripMenuItem jménaTýmůToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem korekceSkóreToolStripMenuItem;
        private ToolStripMenuItem odebratDomácíToolStripMenuItem;
        private ToolStripMenuItem odebratHostéToolStripMenuItem;
        private ToolStripMenuItem sportToolStripMenuItem;
        private ToolStripMenuItem hokejToolStripMenuItem;
        private ToolStripMenuItem fotbalToolStripMenuItem;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem oProgramuToolStripMenuItem;
        private ToolStripMenuItem korekcePeriodyToolStripMenuItem;
        private ToolStripMenuItem nastavitVyššíPerioduToolStripMenuItem;
        private ToolStripMenuItem nastavitNižsíPerioduToolStripMenuItem;
        private ToolStripMenuItem přidatPerioduToolStripMenuItem;
        private ToolStripMenuItem odebratPerioduToolStripMenuItem;
    }
}
