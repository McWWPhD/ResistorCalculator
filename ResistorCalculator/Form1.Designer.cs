namespace ResistorCalculator
{
    partial class Form1
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
            this.comBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBox4 = new System.Windows.Forms.ComboBox();
            this.comBox3 = new System.Windows.Forms.ComboBox();
            this.comBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblResValue = new System.Windows.Forms.Label();
            this.lblTol = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBox1
            // 
            this.comBox1.FormattingEnabled = true;
            this.comBox1.Items.AddRange(new object[] {
            "brak",
            "srebrny",
            "złoty",
            "czarny",
            "brązowy",
            "czerwony",
            "pomarańczowy",
            "żółty",
            "zielony",
            "niebieski",
            "fioletowy",
            "szary",
            "biały"});
            this.comBox1.Location = new System.Drawing.Point(50, 118);
            this.comBox1.Name = "comBox1";
            this.comBox1.Size = new System.Drawing.Size(116, 21);
            this.comBox1.TabIndex = 0;
            this.comBox1.SelectedIndexChanged += new System.EventHandler(this.MakingChoice1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.comBox4);
            this.groupBox1.Controls.Add(this.comBox3);
            this.groupBox1.Controls.Add(this.comBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(58, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(50, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 132);
            this.panel1.TabIndex = 4;
            // 
            // comBox4
            // 
            this.comBox4.FormattingEnabled = true;
            this.comBox4.Items.AddRange(new object[] {
            "brak",
            "srebrny",
            "złoty",
            "czarny",
            "brązowy",
            "czerwony",
            "pomarańczowy",
            "żółty",
            "zielony",
            "niebieski",
            "fioletowy",
            "szary",
            "biały"});
            this.comBox4.Location = new System.Drawing.Point(520, 118);
            this.comBox4.Name = "comBox4";
            this.comBox4.Size = new System.Drawing.Size(116, 21);
            this.comBox4.TabIndex = 3;
            this.comBox4.SelectedIndexChanged += new System.EventHandler(this.MakingChoice4);
            // 
            // comBox3
            // 
            this.comBox3.FormattingEnabled = true;
            this.comBox3.Items.AddRange(new object[] {
            "brak",
            "srebrny",
            "złoty",
            "czarny",
            "brązowy",
            "czerwony",
            "pomarańczowy",
            "żółty",
            "zielony",
            "niebieski",
            "fioletowy",
            "szary",
            "biały"});
            this.comBox3.Location = new System.Drawing.Point(365, 118);
            this.comBox3.Name = "comBox3";
            this.comBox3.Size = new System.Drawing.Size(116, 21);
            this.comBox3.TabIndex = 2;
            this.comBox3.SelectedIndexChanged += new System.EventHandler(this.MakingChoice3);
            // 
            // comBox2
            // 
            this.comBox2.FormattingEnabled = true;
            this.comBox2.Items.AddRange(new object[] {
            "brak",
            "srebrny",
            "złoty",
            "czarny",
            "brązowy",
            "czerwony",
            "pomarańczowy",
            "żółty",
            "zielony",
            "niebieski",
            "fioletowy",
            "szary",
            "biały"});
            this.comBox2.Location = new System.Drawing.Point(206, 118);
            this.comBox2.Name = "comBox2";
            this.comBox2.Size = new System.Drawing.Size(116, 21);
            this.comBox2.TabIndex = 1;
            this.comBox2.SelectedIndexChanged += new System.EventHandler(this.MakingChoice2);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(206, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 132);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(365, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 132);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(520, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(116, 132);
            this.panel4.TabIndex = 5;
            // 
            // lblResValue
            // 
            this.lblResValue.AutoSize = true;
            this.lblResValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResValue.Location = new System.Drawing.Point(353, 286);
            this.lblResValue.Name = "lblResValue";
            this.lblResValue.Size = new System.Drawing.Size(100, 37);
            this.lblResValue.TabIndex = 2;
            this.lblResValue.Text = "label1";
            // 
            // lblTol
            // 
            this.lblTol.AutoSize = true;
            this.lblTol.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTol.Location = new System.Drawing.Point(318, 354);
            this.lblTol.Name = "lblTol";
            this.lblTol.Size = new System.Drawing.Size(167, 37);
            this.lblTol.TabIndex = 3;
            this.lblTol.Text = "Tolerancja";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.lblTol);
            this.Controls.Add(this.lblResValue);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comBox4;
        private System.Windows.Forms.ComboBox comBox3;
        private System.Windows.Forms.ComboBox comBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblResValue;
        private System.Windows.Forms.Label lblTol;
    }
}

