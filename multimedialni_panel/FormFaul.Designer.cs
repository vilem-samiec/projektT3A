namespace multimedialni_panel
{
    partial class FormFaul
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            labelHomeTeam = new Label();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(776, 97);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Reem Kufi", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(67, 35);
            button1.TabIndex = 1;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(158, 0);
            label1.Name = "label1";
            label1.Size = new Size(459, 97);
            label1.TabIndex = 2;
            label1.Text = "TREST";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left;
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Reem Kufi", 26.25F, FontStyle.Bold);
            numericUpDown1.Location = new Point(75, 267);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 70);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // labelHomeTeam
            // 
            labelHomeTeam.Anchor = AnchorStyles.Left;
            labelHomeTeam.AutoSize = true;
            labelHomeTeam.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            labelHomeTeam.ForeColor = Color.White;
            labelHomeTeam.Location = new Point(15, 173);
            labelHomeTeam.Name = "labelHomeTeam";
            labelHomeTeam.Size = new Size(247, 91);
            labelHomeTeam.TabIndex = 16;
            labelHomeTeam.Text = "DOMÁCÍ";
            labelHomeTeam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Reem Kufi", 36F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(578, 173);
            label2.Name = "label2";
            label2.Size = new Size(210, 91);
            label2.TabIndex = 17;
            label2.Text = "HOSTÉ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Right;
            numericUpDown2.BorderStyle = BorderStyle.None;
            numericUpDown2.Font = new Font("Reem Kufi", 26.25F, FontStyle.Bold);
            numericUpDown2.Location = new Point(622, 267);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 70);
            numericUpDown2.TabIndex = 18;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // FormFaul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown2);
            Controls.Add(label2);
            Controls.Add(labelHomeTeam);
            Controls.Add(numericUpDown1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFaul";
            Text = "FormFaul";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label labelHomeTeam;
        private Label label2;
        private NumericUpDown numericUpDown2;
    }
}