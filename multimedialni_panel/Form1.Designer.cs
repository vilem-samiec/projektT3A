namespace multimedialni_panel
{
    partial class Multimedial_panel
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
            button_start = new Button();
            button_konec = new Button();
            SuspendLayout();
            // 
            // button_start
            // 
            button_start.Location = new Point(531, 396);
            button_start.Name = "button_start";
            button_start.Size = new Size(177, 60);
            button_start.TabIndex = 1;
            button_start.Text = "START";
            button_start.UseVisualStyleBackColor = true;
            // 
            // button_konec
            // 
            button_konec.Location = new Point(531, 525);
            button_konec.Name = "button_konec";
            button_konec.Size = new Size(177, 60);
            button_konec.TabIndex = 4;
            button_konec.Text = "KONEC";
            button_konec.UseVisualStyleBackColor = true;
            button_konec.Click += button_konec_Click;
            // 
            // Multimedial_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 607);
            Controls.Add(button_konec);
            Controls.Add(button_start);
            Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Multimedial_panel";
            Text = "Multimediální panel";
            ResumeLayout(false);
        }

        #endregion
        private Button button_start;
        private Button button_konec;
    }
}
