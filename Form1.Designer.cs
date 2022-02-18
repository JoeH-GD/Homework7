
namespace Doubler
{
    partial class Doubler
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.lbComputerNumber = new System.Windows.Forms.Label();
            this.lbUserNumber = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.Location = new System.Drawing.Point(466, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 43);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPlus.Location = new System.Drawing.Point(466, 116);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(96, 40);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click_1);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMultiply.Location = new System.Drawing.Point(466, 172);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(96, 44);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "x2";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click_1);
            // 
            // lbComputerNumber
            // 
            this.lbComputerNumber.AutoSize = true;
            this.lbComputerNumber.Location = new System.Drawing.Point(83, 75);
            this.lbComputerNumber.Name = "lbComputerNumber";
            this.lbComputerNumber.Size = new System.Drawing.Size(125, 17);
            this.lbComputerNumber.TabIndex = 3;
            this.lbComputerNumber.Text = "Get to this number";
            // 
            // lbUserNumber
            // 
            this.lbUserNumber.AutoSize = true;
            this.lbUserNumber.Location = new System.Drawing.Point(86, 128);
            this.lbUserNumber.Name = "lbUserNumber";
            this.lbUserNumber.Size = new System.Drawing.Size(139, 17);
            this.lbUserNumber.TabIndex = 4;
            this.lbUserNumber.Text = "Your current number";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(40, 198);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 41);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(231, 102);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(138, 54);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseMnemonic = false;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(12, 9);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(72, 18);
            this.lbWelcome.TabIndex = 7;
            this.lbWelcome.Text = "Welcome";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Doubler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(632, 265);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbUserNumber);
            this.Controls.Add(this.lbComputerNumber);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnReset);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MaximumSize = new System.Drawing.Size(650, 312);
            this.MinimumSize = new System.Drawing.Size(650, 312);
            this.Name = "Doubler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doubler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label lbComputerNumber;
        private System.Windows.Forms.Label lbUserNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lbWelcome;
    }
}

