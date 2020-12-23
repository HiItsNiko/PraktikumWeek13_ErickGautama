namespace TugasWeek14
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.textBoxhuruf1 = new System.Windows.Forms.TextBox();
            this.textBoxhuruf2 = new System.Windows.Forms.TextBox();
            this.HenshinButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelhasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Kalimat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Huruf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menjadi";
            // 
            // textBoxinput
            // 
            this.textBoxinput.Location = new System.Drawing.Point(86, 45);
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(702, 20);
            this.textBoxinput.TabIndex = 3;
            // 
            // textBoxhuruf1
            // 
            this.textBoxhuruf1.Location = new System.Drawing.Point(86, 109);
            this.textBoxhuruf1.Name = "textBoxhuruf1";
            this.textBoxhuruf1.Size = new System.Drawing.Size(280, 20);
            this.textBoxhuruf1.TabIndex = 4;
            // 
            // textBoxhuruf2
            // 
            this.textBoxhuruf2.Location = new System.Drawing.Point(448, 108);
            this.textBoxhuruf2.Name = "textBoxhuruf2";
            this.textBoxhuruf2.Size = new System.Drawing.Size(340, 20);
            this.textBoxhuruf2.TabIndex = 5;
            // 
            // HenshinButton
            // 
            this.HenshinButton.Location = new System.Drawing.Point(308, 202);
            this.HenshinButton.Name = "HenshinButton";
            this.HenshinButton.Size = new System.Drawing.Size(212, 37);
            this.HenshinButton.TabIndex = 6;
            this.HenshinButton.Text = "Henshin!";
            this.HenshinButton.UseVisualStyleBackColor = true;
            this.HenshinButton.Click += new System.EventHandler(this.HenshinButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil:";
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Location = new System.Drawing.Point(64, 328);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(0, 13);
            this.labelhasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HenshinButton);
            this.Controls.Add(this.textBoxhuruf2);
            this.Controls.Add(this.textBoxhuruf1);
            this.Controls.Add(this.textBoxinput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QUIZ PANDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxinput;
        private System.Windows.Forms.TextBox textBoxhuruf1;
        private System.Windows.Forms.TextBox textBoxhuruf2;
        private System.Windows.Forms.Button HenshinButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelhasil;
    }
}

