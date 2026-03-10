namespace multimedialni_panel
{
    partial class Multimedial_panel_zapas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button_start_stop = new Button();
            labelScoreHome = new Label();
            labelScoreAway = new Label();
            labelHomeTeam = new Label();
            labelAwayTeam = new Label();
            Cas = new Label();
            trest_d = new Label();
            trest_h = new Label();
            pictureAwayTeam = new PictureBox();
            pictureHomeTeam = new PictureBox();
            button_goal_horn_h = new Button();
            pause = new Button();
            button_goal_horn_d = new Button();
            lomeno = new Label();
            castZapasu = new Label();
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
            button1 = new Button();
            button2 = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureAwayTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHomeTeam).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button_start_stop
            // 
            button_start_stop.BackColor = Color.Chartreuse;
            button_start_stop.ForeColor = SystemColors.ControlText;
            button_start_stop.Location = new Point(351, 573);
            button_start_stop.Name = "button_start_stop";
            button_start_stop.Size = new Size(150, 64);
            button_start_stop.TabIndex = 1;
            button_start_stop.Text = "START";
            button_start_stop.UseVisualStyleBackColor = false;
            // 
            // labelScoreHome
            // 
            labelScoreHome.AutoSize = true;
            labelScoreHome.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelScoreHome.Location = new Point(325, 177);
            labelScoreHome.Name = "labelScoreHome";
            labelScoreHome.Size = new Size(139, 57);
            labelScoreHome.TabIndex = 5;
            labelScoreHome.Text = "Skóre";
            // 
            // labelScoreAway
            // 
            labelScoreAway.AutoSize = true;
            labelScoreAway.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelScoreAway.Location = new Point(552, 177);
            labelScoreAway.Name = "labelScoreAway";
            labelScoreAway.Size = new Size(139, 57);
            labelScoreAway.TabIndex = 6;
            labelScoreAway.Text = "Skóre";
            // 
            // labelHomeTeam
            // 
            labelHomeTeam.AutoSize = true;
            labelHomeTeam.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHomeTeam.Location = new Point(36, 314);
            labelHomeTeam.Name = "labelHomeTeam";
            labelHomeTeam.Size = new Size(283, 57);
            labelHomeTeam.TabIndex = 8;
            labelHomeTeam.Text = "NÁZEV TÝMU";
            labelHomeTeam.Click += label1_Click;
            // 
            // labelAwayTeam
            // 
            labelAwayTeam.AutoSize = true;
            labelAwayTeam.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAwayTeam.Location = new Point(697, 314);
            labelAwayTeam.Name = "labelAwayTeam";
            labelAwayTeam.Size = new Size(283, 57);
            labelAwayTeam.TabIndex = 9;
            labelAwayTeam.Text = "NÁZEV TÝMU";
            // 
            // Cas
            // 
            Cas.AutoSize = true;
            Cas.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cas.Location = new Point(457, 96);
            Cas.Name = "Cas";
            Cas.Size = new Size(105, 57);
            Cas.TabIndex = 10;
            Cas.Text = "ČAS";
            // 
            // trest_d
            // 
            trest_d.AutoSize = true;
            trest_d.Font = new Font("Swis721 BlkCn BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trest_d.Location = new Point(36, 371);
            trest_d.Name = "trest_d";
            trest_d.Size = new Size(76, 29);
            trest_d.TabIndex = 11;
            trest_d.Text = "TREST";
            // 
            // trest_h
            // 
            trest_h.AutoSize = true;
            trest_h.Font = new Font("Swis721 BlkCn BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trest_h.Location = new Point(904, 371);
            trest_h.Name = "trest_h";
            trest_h.Size = new Size(76, 29);
            trest_h.TabIndex = 12;
            trest_h.Text = "TREST";
            // 
            // pictureAwayTeam
            // 
            pictureAwayTeam.Location = new Point(697, 96);
            pictureAwayTeam.Name = "pictureAwayTeam";
            pictureAwayTeam.Size = new Size(200, 200);
            pictureAwayTeam.TabIndex = 13;
            pictureAwayTeam.TabStop = false;
            // 
            // pictureHomeTeam
            // 
            pictureHomeTeam.Location = new Point(119, 96);
            pictureHomeTeam.Name = "pictureHomeTeam";
            pictureHomeTeam.Size = new Size(200, 200);
            pictureHomeTeam.TabIndex = 14;
            pictureHomeTeam.TabStop = false;
            // 
            // button_goal_horn_h
            // 
            button_goal_horn_h.Location = new Point(697, 502);
            button_goal_horn_h.Name = "button_goal_horn_h";
            button_goal_horn_h.Size = new Size(152, 64);
            button_goal_horn_h.TabIndex = 17;
            button_goal_horn_h.Text = "GOAL";
            button_goal_horn_h.UseVisualStyleBackColor = true;
            button_goal_horn_h.Click += button_goal_horn_h_Click;
            // 
            // pause
            // 
            pause.BackColor = Color.Red;
            pause.Location = new Point(514, 573);
            pause.Name = "pause";
            pause.Size = new Size(150, 64);
            pause.TabIndex = 19;
            pause.Text = "PAUZA";
            pause.UseVisualStyleBackColor = false;
            // 
            // button_goal_horn_d
            // 
            button_goal_horn_d.Location = new Point(167, 502);
            button_goal_horn_d.Name = "button_goal_horn_d";
            button_goal_horn_d.Size = new Size(152, 64);
            button_goal_horn_d.TabIndex = 16;
            button_goal_horn_d.Text = "GOAL";
            button_goal_horn_d.UseVisualStyleBackColor = true;
            button_goal_horn_d.Click += button_goal_horn_d_Click;
            // 
            // lomeno
            // 
            lomeno.AutoSize = true;
            lomeno.Font = new Font("Swis721 BlkCn BT", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lomeno.Location = new Point(492, 177);
            lomeno.Name = "lomeno";
            lomeno.Size = new Size(39, 57);
            lomeno.TabIndex = 20;
            lomeno.Text = ":";
            // 
            // castZapasu
            // 
            castZapasu.AutoSize = true;
            castZapasu.Font = new Font("Swis721 BlkCn BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            castZapasu.Location = new Point(440, 148);
            castZapasu.Name = "castZapasu";
            castZapasu.Size = new Size(136, 29);
            castZapasu.TabIndex = 21;
            castZapasu.Text = "Část zápasu";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { možnostiToolStripMenuItem, korekceSkóreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1015, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // možnostiToolStripMenuItem
            // 
            možnostiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novýZápasToolStripMenuItem1, nastaveníToolStripMenuItem1, kONECToolStripMenuItem1 });
            možnostiToolStripMenuItem.Name = "možnostiToolStripMenuItem";
            možnostiToolStripMenuItem.Size = new Size(68, 20);
            možnostiToolStripMenuItem.Text = "Možnosti";
            // 
            // novýZápasToolStripMenuItem1
            // 
            novýZápasToolStripMenuItem1.Name = "novýZápasToolStripMenuItem1";
            novýZápasToolStripMenuItem1.Size = new Size(180, 22);
            novýZápasToolStripMenuItem1.Text = "Nový zápas";
            novýZápasToolStripMenuItem1.Click += novýZápasToolStripMenuItem1_Click;
            // 
            // nastaveníToolStripMenuItem1
            // 
            nastaveníToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { logaTýmuToolStripMenuItem, jménaTýmůToolStripMenuItem, sportToolStripMenuItem });
            nastaveníToolStripMenuItem1.Name = "nastaveníToolStripMenuItem1";
            nastaveníToolStripMenuItem1.Size = new Size(180, 22);
            nastaveníToolStripMenuItem1.Text = "Nastavení";
            // 
            // logaTýmuToolStripMenuItem
            // 
            logaTýmuToolStripMenuItem.Name = "logaTýmuToolStripMenuItem";
            logaTýmuToolStripMenuItem.Size = new Size(180, 22);
            logaTýmuToolStripMenuItem.Text = "Loga týmů";
            logaTýmuToolStripMenuItem.Click += logaTýmuToolStripMenuItem_Click;
            // 
            // jménaTýmůToolStripMenuItem
            // 
            jménaTýmůToolStripMenuItem.Name = "jménaTýmůToolStripMenuItem";
            jménaTýmůToolStripMenuItem.Size = new Size(180, 22);
            jménaTýmůToolStripMenuItem.Text = "Jména týmů";
            jménaTýmůToolStripMenuItem.Click += jménaTýmůToolStripMenuItem_Click;
            // 
            // sportToolStripMenuItem
            // 
            sportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hokejToolStripMenuItem, fotbalToolStripMenuItem });
            sportToolStripMenuItem.Name = "sportToolStripMenuItem";
            sportToolStripMenuItem.Size = new Size(180, 22);
            sportToolStripMenuItem.Text = "Sport";
            // 
            // hokejToolStripMenuItem
            // 
            hokejToolStripMenuItem.Name = "hokejToolStripMenuItem";
            hokejToolStripMenuItem.Size = new Size(180, 22);
            hokejToolStripMenuItem.Text = "Hokej";
            hokejToolStripMenuItem.Click += hokejToolStripMenuItem_Click;
            // 
            // fotbalToolStripMenuItem
            // 
            fotbalToolStripMenuItem.Name = "fotbalToolStripMenuItem";
            fotbalToolStripMenuItem.Size = new Size(180, 22);
            fotbalToolStripMenuItem.Text = "Fotbal";
            fotbalToolStripMenuItem.Click += fotbalToolStripMenuItem_Click;
            // 
            // kONECToolStripMenuItem1
            // 
            kONECToolStripMenuItem1.Name = "kONECToolStripMenuItem1";
            kONECToolStripMenuItem1.Size = new Size(180, 22);
            kONECToolStripMenuItem1.Text = "KONEC";
            // 
            // korekceSkóreToolStripMenuItem
            // 
            korekceSkóreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { odebratDomácíToolStripMenuItem, odebratHostéToolStripMenuItem });
            korekceSkóreToolStripMenuItem.Name = "korekceSkóreToolStripMenuItem";
            korekceSkóreToolStripMenuItem.Size = new Size(92, 20);
            korekceSkóreToolStripMenuItem.Text = "Korekce skóre";
            // 
            // odebratDomácíToolStripMenuItem
            // 
            odebratDomácíToolStripMenuItem.Name = "odebratDomácíToolStripMenuItem";
            odebratDomácíToolStripMenuItem.Size = new Size(185, 22);
            odebratDomácíToolStripMenuItem.Text = "Odebrat Bod Domácí";
            odebratDomácíToolStripMenuItem.Click += odebratDomácíToolStripMenuItem_Click;
            // 
            // odebratHostéToolStripMenuItem
            // 
            odebratHostéToolStripMenuItem.Name = "odebratHostéToolStripMenuItem";
            odebratHostéToolStripMenuItem.Size = new Size(185, 22);
            odebratHostéToolStripMenuItem.Text = "Odebrat Bod Hosté";
            odebratHostéToolStripMenuItem.Click += odebratHostéToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Location = new Point(12, 574);
            button1.Name = "button1";
            button1.Size = new Size(150, 64);
            button1.TabIndex = 23;
            button1.Text = "Trest";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Aqua;
            button2.Location = new Point(853, 574);
            button2.Name = "button2";
            button2.Size = new Size(150, 64);
            button2.TabIndex = 24;
            button2.Text = "Trest";
            button2.UseVisualStyleBackColor = false;
            // 
            // gameTimer
            // 
            gameTimer.Tick += this.timer1_Tick;
            // 
            // Multimedial_panel_zapas
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 650);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(castZapasu);
            Controls.Add(lomeno);
            Controls.Add(pause);
            Controls.Add(button_goal_horn_h);
            Controls.Add(button_goal_horn_d);
            Controls.Add(pictureHomeTeam);
            Controls.Add(pictureAwayTeam);
            Controls.Add(trest_h);
            Controls.Add(trest_d);
            Controls.Add(Cas);
            Controls.Add(labelAwayTeam);
            Controls.Add(labelHomeTeam);
            Controls.Add(labelScoreAway);
            Controls.Add(labelScoreHome);
            Controls.Add(button_start_stop);
            Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Multimedial_panel_zapas";
            Text = "Multimediální panel";
            Load += Multimedial_panel_zapas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureAwayTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHomeTeam).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_start_stop;
        private Label labelScoreHome;
        private Label labelScoreAway;
        private Label labelHomeTeam;
        private Label labelAwayTeam;
        private Label Cas;
        private Label trest_d;
        private Label trest_h;
        private PictureBox pictureAwayTeam;
        private PictureBox pictureHomeTeam;
        private Button button_goal_horn_h;
        private Button pause;
        private Button button_goal_horn_d;
        private Label lomeno;
        private Label castZapasu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem možnostiToolStripMenuItem;
        private ToolStripMenuItem novýZápasToolStripMenuItem1;
        private ToolStripMenuItem nastaveníToolStripMenuItem1;
        private ToolStripMenuItem kONECToolStripMenuItem1;
        private ToolStripMenuItem logaTýmuToolStripMenuItem;
        private ToolStripMenuItem jménaTýmůToolStripMenuItem;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem korekceSkóreToolStripMenuItem;
        private ToolStripMenuItem odebratDomácíToolStripMenuItem;
        private ToolStripMenuItem odebratHostéToolStripMenuItem;
        private ToolStripMenuItem sportToolStripMenuItem;
        private ToolStripMenuItem hokejToolStripMenuItem;
        private ToolStripMenuItem fotbalToolStripMenuItem;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer gameTimer;
    }
}
