namespace ScientificCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.quadEqSolver1 = new ScientificCalculator.QuadEqSolver();
            this.calculator1 = new ScientificCalculator.Calculator();
            this.simEqSolver1 = new ScientificCalculator.SimEqSolver();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 509);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(199, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 45);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(199, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 45);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(199, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 45);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 45);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuText;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(0, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 45);
            this.button3.TabIndex = 1;
            this.button3.Text = "Simultaneous Equation";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuText;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(0, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "Quadratic Equation";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuText;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Scientific Calculator\r\n";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculator";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.simEqSolver1);
            this.panel6.Controls.Add(this.quadEqSolver1);
            this.panel6.Controls.Add(this.calculator1);
            this.panel6.Location = new System.Drawing.Point(215, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(626, 508);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel6_Paint);
            // 
            // quadEqSolver1
            // 
            this.quadEqSolver1.BackColor = System.Drawing.SystemColors.WindowText;
            this.quadEqSolver1.Location = new System.Drawing.Point(0, 0);
            this.quadEqSolver1.Name = "quadEqSolver1";
            this.quadEqSolver1.Size = new System.Drawing.Size(626, 506);
            this.quadEqSolver1.TabIndex = 1;
            // 
            // calculator1
            // 
            this.calculator1.BackColor = System.Drawing.SystemColors.WindowText;
            this.calculator1.Location = new System.Drawing.Point(-3, 3);
            this.calculator1.Name = "calculator1";
            this.calculator1.Size = new System.Drawing.Size(626, 506);
            this.calculator1.TabIndex = 0;
            this.calculator1.Load += new System.EventHandler(this.Calculator1_Load);
            // 
            // simEqSolver1
            // 
            this.simEqSolver1.BackColor = System.Drawing.SystemColors.WindowText;
            this.simEqSolver1.Location = new System.Drawing.Point(0, 3);
            this.simEqSolver1.Name = "simEqSolver1";
            this.simEqSolver1.Size = new System.Drawing.Size(626, 506);
            this.simEqSolver1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(855, 521);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private Calculator calculator1;
        private QuadEqSolver quadEqSolver1;
        private SimEqSolver simEqSolver1;
    }
}

