namespace Bubble_Trouble
{
    partial class Main
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlay.Image = global::Bubble_Trouble.Properties.Resources.btnPlay;
            this.btnPlay.Location = new System.Drawing.Point(49, 217);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 36);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHowToPlay.Image = global::Bubble_Trouble.Properties.Resources.btnhowtoplay;
            this.btnHowToPlay.Location = new System.Drawing.Point(49, 272);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(150, 36);
            this.btnHowToPlay.TabIndex = 1;
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuit.Image = global::Bubble_Trouble.Properties.Resources.btnQuit;
            this.btnQuit.Location = new System.Drawing.Point(49, 328);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(150, 36);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bubble_Trouble.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(498, 396);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnPlay);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Bubble trouble";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnQuit;
    }
}