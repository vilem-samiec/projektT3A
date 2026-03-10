namespace multimedialni_panel
{
    partial class FormTeamNames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtHomeTeam = new TextBox();
            txtAwayTeam = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 29);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Domácí tým";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(354, 29);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Hostující tým";
            // 
            // txtHomeTeam
            // 
            txtHomeTeam.Location = new Point(12, 47);
            txtHomeTeam.Name = "txtHomeTeam";
            txtHomeTeam.Size = new Size(189, 23);
            txtHomeTeam.TabIndex = 2;
            // 
            // txtAwayTeam
            // 
            txtAwayTeam.Location = new Point(307, 47);
            txtAwayTeam.Name = "txtAwayTeam";
            txtAwayTeam.Size = new Size(189, 23);
            txtAwayTeam.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(154, 327);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(254, 67);
            btnSave.TabIndex = 4;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormTeamNames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtAwayTeam);
            Controls.Add(txtHomeTeam);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTeamNames";
            Text = "FormTeamNames";
            Load += FormTeamNames_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHomeTeam;
        private TextBox txtAwayTeam;
        private Button btnSave;
    }
}