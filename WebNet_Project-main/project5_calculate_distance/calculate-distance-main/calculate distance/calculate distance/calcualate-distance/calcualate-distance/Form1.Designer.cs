namespace calcualate_distance
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.calculate = new System.Windows.Forms.Button();
            this.textpoint1X = new System.Windows.Forms.TextBox();
            this.textpoint2Y = new System.Windows.Forms.TextBox();
            this.textpoint2X = new System.Windows.Forms.TextBox();
            this.textpoint1Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(154, 4);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(339, 156);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textpoint1X
            // 
            this.textpoint1X.Location = new System.Drawing.Point(12, 27);
            this.textpoint1X.Name = "textpoint1X";
            this.textpoint1X.Size = new System.Drawing.Size(136, 22);
            this.textpoint1X.TabIndex = 1;
            this.textpoint1X.TextChanged += new System.EventHandler(this.textpointX1_TextChanged);
            // 
            // textpoint2Y
            // 
            this.textpoint2Y.Location = new System.Drawing.Point(513, 71);
            this.textpoint2Y.Name = "textpoint2Y";
            this.textpoint2Y.Size = new System.Drawing.Size(136, 22);
            this.textpoint2Y.TabIndex = 2;
            // 
            // textpoint2X
            // 
            this.textpoint2X.Location = new System.Drawing.Point(513, 27);
            this.textpoint2X.Name = "textpoint2X";
            this.textpoint2X.Size = new System.Drawing.Size(136, 22);
            this.textpoint2X.TabIndex = 3;
            // 
            // textpoint1Y
            // 
            this.textpoint1Y.Location = new System.Drawing.Point(12, 71);
            this.textpoint1Y.Name = "textpoint1Y";
            this.textpoint1Y.Size = new System.Drawing.Size(136, 22);
            this.textpoint1Y.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "y1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "x2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "y2";
            // 
            // lblresult
            // 
            this.lblresult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblresult.Location = new System.Drawing.Point(112, 172);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(431, 137);
            this.lblresult.TabIndex = 10;
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpoint1Y);
            this.Controls.Add(this.textpoint2X);
            this.Controls.Add(this.textpoint2Y);
            this.Controls.Add(this.textpoint1X);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox textpoint1X;
        private System.Windows.Forms.TextBox textpoint2Y;
        private System.Windows.Forms.TextBox textpoint2X;
        private System.Windows.Forms.TextBox textpoint1Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblresult;
    }
}

