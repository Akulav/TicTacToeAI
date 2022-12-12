namespace TicTacToeAI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.OBtn = new System.Windows.Forms.Button();
            this.XBtn = new System.Windows.Forms.Button();
            this.winLbl = new System.Windows.Forms.Label();
            this.PlayerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 85);
            this.button3.TabIndex = 2;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 85);
            this.button4.TabIndex = 3;
            this.button4.Text = ".";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(103, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 85);
            this.button5.TabIndex = 4;
            this.button5.Text = ".";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(190, 103);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 85);
            this.button6.TabIndex = 5;
            this.button6.Text = ".";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 85);
            this.button7.TabIndex = 6;
            this.button7.Text = ".";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(103, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 85);
            this.button8.TabIndex = 7;
            this.button8.Text = ".";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(190, 194);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 85);
            this.button9.TabIndex = 8;
            this.button9.Text = ".";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.board_MouseClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(12, 285);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(263, 85);
            this.ResetBtn.TabIndex = 9;
            this.ResetBtn.Text = "Reset Game";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // OBtn
            // 
            this.OBtn.Location = new System.Drawing.Point(151, 374);
            this.OBtn.Name = "OBtn";
            this.OBtn.Size = new System.Drawing.Size(123, 65);
            this.OBtn.TabIndex = 10;
            this.OBtn.Text = "Play As O";
            this.OBtn.UseVisualStyleBackColor = true;
            this.OBtn.Click += new System.EventHandler(this.OBtn_Click);
            // 
            // XBtn
            // 
            this.XBtn.Location = new System.Drawing.Point(12, 374);
            this.XBtn.Name = "XBtn";
            this.XBtn.Size = new System.Drawing.Size(123, 65);
            this.XBtn.TabIndex = 11;
            this.XBtn.Text = "Play As X";
            this.XBtn.UseVisualStyleBackColor = true;
            this.XBtn.Click += new System.EventHandler(this.XBtn_Click);
            // 
            // winLbl
            // 
            this.winLbl.AutoSize = true;
            this.winLbl.Location = new System.Drawing.Point(12, 455);
            this.winLbl.Name = "winLbl";
            this.winLbl.Size = new System.Drawing.Size(54, 13);
            this.winLbl.TabIndex = 13;
            this.winLbl.Text = "Winner is:";
            // 
            // PlayerLbl
            // 
            this.PlayerLbl.AutoSize = true;
            this.PlayerLbl.Location = new System.Drawing.Point(12, 442);
            this.PlayerLbl.Name = "PlayerLbl";
            this.PlayerLbl.Size = new System.Drawing.Size(28, 13);
            this.PlayerLbl.TabIndex = 14;
            this.PlayerLbl.Text = "PLbl";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 474);
            this.Controls.Add(this.PlayerLbl);
            this.Controls.Add(this.winLbl);
            this.Controls.Add(this.XBtn);
            this.Controls.Add(this.OBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Cătălin &  Andrei";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button OBtn;
        private System.Windows.Forms.Button XBtn;
        private System.Windows.Forms.Label winLbl;
        private System.Windows.Forms.Label PlayerLbl;
    }
}

