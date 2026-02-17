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
            button_start_stop = new Button();
            button_menu = new Button();
            Score_d = new Label();
            Score_h = new Label();
            Cast_zapasu = new Label();
            team_d = new Label();
            team_h = new Label();
            Cas = new Label();
            trest_d = new Label();
            trest_h = new Label();
            logo_team_d = new PictureBox();
            logo_team_h = new PictureBox();
            button_novy_zapas = new Button();
            button_goal_horn_d = new Button();
            button_goal_horn_h = new Button();
            ((System.ComponentModel.ISupportInitialize)logo_team_d).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_team_h).BeginInit();
            SuspendLayout();
            // 
            // button_start_stop
            // 
            button_start_stop.Location = new Point(531, 535);
            button_start_stop.Name = "button_start_stop";
            button_start_stop.Size = new Size(177, 60);
            button_start_stop.TabIndex = 1;
            button_start_stop.Text = "START";
            button_start_stop.UseVisualStyleBackColor = true;
            // 
            // button_menu
            // 
            button_menu.Location = new Point(12, 535);
            button_menu.Name = "button_menu";
            button_menu.Size = new Size(177, 60);
            button_menu.TabIndex = 4;
            button_menu.Text = "MENU";
            button_menu.UseVisualStyleBackColor = true;
            button_menu.Click += button_konec_Click;
            // 
            // Score_d
            // 
            Score_d.AutoSize = true;
            Score_d.Location = new Point(168, 168);
            Score_d.Name = "Score_d";
            Score_d.Size = new Size(46, 14);
            Score_d.TabIndex = 5;
            Score_d.Text = "Skore";
            // 
            // Score_h
            // 
            Score_h.AutoSize = true;
            Score_h.Location = new Point(921, 168);
            Score_h.Name = "Score_h";
            Score_h.Size = new Size(46, 14);
            Score_h.TabIndex = 6;
            Score_h.Text = "Skore";
            // 
            // Cast_zapasu
            // 
            Cast_zapasu.AutoSize = true;
            Cast_zapasu.Location = new Point(588, 9);
            Cast_zapasu.Name = "Cast_zapasu";
            Cast_zapasu.Size = new Size(83, 14);
            Cast_zapasu.TabIndex = 7;
            Cast_zapasu.Text = "ČÁST ZÁPASU";
            // 
            // team_d
            // 
            team_d.AutoSize = true;
            team_d.Location = new Point(168, 136);
            team_d.Name = "team_d";
            team_d.Size = new Size(76, 14);
            team_d.TabIndex = 8;
            team_d.Text = "NÁZEV TÝMU";
            team_d.Click += label1_Click;
            // 
            // team_h
            // 
            team_h.AutoSize = true;
            team_h.Location = new Point(921, 136);
            team_h.Name = "team_h";
            team_h.Size = new Size(76, 14);
            team_h.TabIndex = 9;
            team_h.Text = "Název týmu";
            // 
            // Cas
            // 
            Cas.AutoSize = true;
            Cas.Location = new Point(580, 296);
            Cas.Name = "Cas";
            Cas.Size = new Size(30, 14);
            Cas.TabIndex = 10;
            Cas.Text = "ČAS";
            // 
            // trest_d
            // 
            trest_d.AutoSize = true;
            trest_d.Location = new Point(168, 201);
            trest_d.Name = "trest_d";
            trest_d.Size = new Size(43, 14);
            trest_d.TabIndex = 11;
            trest_d.Text = "TREST";
            // 
            // trest_h
            // 
            trest_h.AutoSize = true;
            trest_h.Location = new Point(921, 201);
            trest_h.Name = "trest_h";
            trest_h.Size = new Size(43, 14);
            trest_h.TabIndex = 12;
            trest_h.Text = "TREST";
            // 
            // logo_team_d
            // 
            logo_team_d.Location = new Point(117, 30);
            logo_team_d.Name = "logo_team_d";
            logo_team_d.Size = new Size(141, 96);
            logo_team_d.TabIndex = 13;
            logo_team_d.TabStop = false;
            // 
            // logo_team_h
            // 
            logo_team_h.Location = new Point(868, 30);
            logo_team_h.Name = "logo_team_h";
            logo_team_h.Size = new Size(141, 96);
            logo_team_h.TabIndex = 14;
            logo_team_h.TabStop = false;
            // 
            // button_novy_zapas
            // 
            button_novy_zapas.Location = new Point(1019, 535);
            button_novy_zapas.Name = "button_novy_zapas";
            button_novy_zapas.Size = new Size(177, 60);
            button_novy_zapas.TabIndex = 15;
            button_novy_zapas.Text = "NOVÝ";
            button_novy_zapas.UseVisualStyleBackColor = true;
            // 
            // button_goal_horn_d
            // 
            button_goal_horn_d.Location = new Point(117, 250);
            button_goal_horn_d.Name = "button_goal_horn_d";
            button_goal_horn_d.Size = new Size(177, 60);
            button_goal_horn_d.TabIndex = 16;
            button_goal_horn_d.Text = "GOAL";
            button_goal_horn_d.UseVisualStyleBackColor = true;
            // 
            // button_goal_horn_h
            // 
            button_goal_horn_h.Location = new Point(792, 250);
            button_goal_horn_h.Name = "button_goal_horn_h";
            button_goal_horn_h.Size = new Size(177, 60);
            button_goal_horn_h.TabIndex = 17;
            button_goal_horn_h.Text = "GOAL";
            button_goal_horn_h.UseVisualStyleBackColor = true;
            // 
            // Multimedial_panel_zapas
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 607);
            Controls.Add(button_goal_horn_h);
            Controls.Add(button_goal_horn_d);
            Controls.Add(button_novy_zapas);
            Controls.Add(logo_team_h);
            Controls.Add(logo_team_d);
            Controls.Add(trest_h);
            Controls.Add(trest_d);
            Controls.Add(Cas);
            Controls.Add(team_h);
            Controls.Add(team_d);
            Controls.Add(Cast_zapasu);
            Controls.Add(Score_h);
            Controls.Add(Score_d);
            Controls.Add(button_menu);
            Controls.Add(button_start_stop);
            Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Multimedial_panel_zapas";
            Text = "Multimediální panel";
            ((System.ComponentModel.ISupportInitialize)logo_team_d).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_team_h).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_start_stop;
        private Button button_menu;
        private Label Score_d;
        private Label Score_h;
        private Label Cast_zapasu;
        private Label team_d;
        private Label team_h;
        private Label Cas;
        private Label trest_d;
        private Label trest_h;
        private PictureBox logo_team_d;
        private PictureBox logo_team_h;
        private Button button_novy_zapas;
        private Button button_goal_horn_d;
        private Button button_goal_horn_h;
    }
}
