namespace multimedialni_panel
{
    partial class FormLoga
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
            pictureHome = new PictureBox();
            pictureAway = new PictureBox();
            buttonHome = new Button();
            buttonAway = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAway).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureHome
            // 
            pictureHome.Anchor = AnchorStyles.None;
            pictureHome.BorderStyle = BorderStyle.FixedSingle;
            pictureHome.Location = new Point(6, 371);
            pictureHome.Margin = new Padding(6);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(923, 354);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 0;
            pictureHome.TabStop = false;
            // 
            // pictureAway
            // 
            pictureAway.Anchor = AnchorStyles.None;
            pictureAway.BorderStyle = BorderStyle.FixedSingle;
            pictureAway.Location = new Point(941, 371);
            pictureAway.Margin = new Padding(6);
            pictureAway.Name = "pictureAway";
            pictureAway.Size = new Size(923, 354);
            pictureAway.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAway.TabIndex = 1;
            pictureAway.TabStop = false;
            // 
            // buttonHome
            // 
            buttonHome.Anchor = AnchorStyles.None;
            buttonHome.Font = new Font("Reem Kufi", 25.875F, FontStyle.Bold);
            buttonHome.Location = new Point(18, 752);
            buttonHome.Margin = new Padding(6);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(704, 201);
            buttonHome.TabIndex = 3;
            buttonHome.Text = "NAHRÁT DOMÁCÍ";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonAway
            // 
            buttonAway.Anchor = AnchorStyles.None;
            buttonAway.Font = new Font("Reem Kufi", 25.875F, FontStyle.Bold);
            buttonAway.Location = new Point(1204, 752);
            buttonAway.Margin = new Padding(6);
            buttonAway.Name = "buttonAway";
            buttonAway.Size = new Size(704, 201);
            buttonAway.TabIndex = 4;
            buttonAway.Text = "NAHRÁT HOSTÉ";
            buttonAway.UseVisualStyleBackColor = true;
            buttonAway.Click += buttonAway_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureHome, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureAway, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1870, 731);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Reem Kufi", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(227, 96);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(480, 172);
            label1.TabIndex = 0;
            label1.Text = "DOMÁCÍ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1198, 96);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(408, 172);
            label2.TabIndex = 1;
            label2.Text = "HOSTÉ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Reem Kufi", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(18, 990);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(124, 75);
            button1.TabIndex = 7;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormLoga
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1920, 1080);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonAway);
            Controls.Add(buttonHome);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FormLoga";
            Text = "Loga týmů";
            WindowState = FormWindowState.Maximized;
            Load += FormLoga_Load;
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAway).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureHome;
        private PictureBox pictureAway;
        private Button buttonHome;
        private Button buttonAway;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}