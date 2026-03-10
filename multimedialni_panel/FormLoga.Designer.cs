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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureAway).BeginInit();
            SuspendLayout();
            // 
            // pictureHome
            // 
            pictureHome.BorderStyle = BorderStyle.FixedSingle;
            pictureHome.Location = new Point(107, 57);
            pictureHome.Name = "pictureHome";
            pictureHome.Size = new Size(200, 200);
            pictureHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHome.TabIndex = 0;
            pictureHome.TabStop = false;
            // 
            // pictureAway
            // 
            pictureAway.BorderStyle = BorderStyle.FixedSingle;
            pictureAway.Location = new Point(494, 57);
            pictureAway.Name = "pictureAway";
            pictureAway.Size = new Size(200, 200);
            pictureAway.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAway.TabIndex = 1;
            pictureAway.TabStop = false;
            // 
            // buttonHome
            // 
            buttonHome.Location = new Point(132, 375);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(175, 63);
            buttonHome.TabIndex = 3;
            buttonHome.Text = "Nahrát domácí";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonAway
            // 
            buttonAway.Location = new Point(494, 375);
            buttonAway.Name = "buttonAway";
            buttonAway.Size = new Size(175, 63);
            buttonAway.TabIndex = 4;
            buttonAway.Text = "Nahrát hosté";
            buttonAway.UseVisualStyleBackColor = true;
            buttonAway.Click += buttonAway_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 242);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 5;
            label1.Text = "Loga musí být 200x200 px!";
            // 
            // FormLoga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonAway);
            Controls.Add(buttonHome);
            Controls.Add(pictureAway);
            Controls.Add(pictureHome);
            Name = "FormLoga";
            Text = "Loga týmů";
            Load += FormLoga_Load;
            ((System.ComponentModel.ISupportInitialize)pictureHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureAway).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureHome;
        private PictureBox pictureAway;
        private Button buttonHome;
        private Button buttonAway;
        private Label label1;
    }
}