namespace multimedialni_panel
{
    partial class FormAbout
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(67, 35);
            button1.TabIndex = 1;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "O programu";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(233, 15);
            label2.TabIndex = 3;
            label2.Text = "Vývojové prostředí: Microsoft Visual Studio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Jazyk: C#";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(243, 15);
            label4.TabIndex = 5;
            label4.Text = "Použité AI nástroje: GitHub Copilot, ChatGPT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 396);
            label5.Name = "label5";
            label5.Size = new Size(370, 15);
            label5.TabIndex = 6;
            label5.Text = "Program byl vytvořen jako školní projekt do předmětu Programování";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(604, 426);
            label6.Name = "label6";
            label6.Size = new Size(184, 15);
            label6.TabIndex = 7;
            label6.Text = "Autor: Vilém Samiec, T3A, FrenGP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 411);
            label7.Name = "label7";
            label7.Size = new Size(168, 15);
            label7.TabIndex = 8;
            label7.Text = "Projekt obsahuje dokumentaci";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 182);
            label8.Name = "label8";
            label8.Size = new Size(152, 15);
            label8.TabIndex = 9;
            label8.Text = "Dokument: Microsoft Word";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(736, 12);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 10;
            label9.Text = "Verze 1.0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 426);
            label10.Name = "label10";
            label10.Size = new Size(348, 15);
            label10.TabIndex = 11;
            label10.Text = "Celý projekt včetně dokumentace je nahrán na platformě GitHub";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormAbout";
            Text = "FormAbout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}