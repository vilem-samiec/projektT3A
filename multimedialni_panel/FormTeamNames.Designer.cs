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
            btnSave = new Button();
            txtHomeTeam = new TextBox();
            txtAwayTeam = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Reem Kufi", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(935, 180);
            label1.TabIndex = 0;
            label1.Text = "DOMÁCÍ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(935, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(935, 180);
            label2.TabIndex = 1;
            label2.Text = "HOSTÉ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Reem Kufi", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(18, 726);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(1864, 217);
            btnSave.TabIndex = 4;
            btnSave.Text = "ULOŽIT";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtHomeTeam
            // 
            txtHomeTeam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtHomeTeam.Cursor = Cursors.IBeam;
            txtHomeTeam.Font = new Font("Reem Kufi Medium", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            txtHomeTeam.ForeColor = Color.Black;
            txtHomeTeam.Location = new Point(6, 186);
            txtHomeTeam.Margin = new Padding(6);
            txtHomeTeam.Name = "txtHomeTeam";
            txtHomeTeam.Size = new Size(923, 79);
            txtHomeTeam.TabIndex = 2;
            txtHomeTeam.Text = "Zde napiš název";
            // 
            // txtAwayTeam
            // 
            txtAwayTeam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAwayTeam.Cursor = Cursors.IBeam;
            txtAwayTeam.Font = new Font("Reem Kufi Medium", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            txtAwayTeam.ForeColor = Color.Black;
            txtAwayTeam.Location = new Point(941, 186);
            txtAwayTeam.Margin = new Padding(6);
            txtAwayTeam.Name = "txtAwayTeam";
            txtAwayTeam.Size = new Size(923, 79);
            txtAwayTeam.TabIndex = 3;
            txtAwayTeam.Text = "Zde napiš název";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(txtAwayTeam, 1, 1);
            tableLayoutPanel1.Controls.Add(txtHomeTeam, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1870, 361);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // FormTeamNames
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1894, 1009);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FormTeamNames";
            Text = "FormTeamNames";
            WindowState = FormWindowState.Maximized;
            Load += FormTeamNames_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSave;
        private TextBox txtHomeTeam;
        private TextBox txtAwayTeam;
        private TableLayoutPanel tableLayoutPanel1;
    }
}