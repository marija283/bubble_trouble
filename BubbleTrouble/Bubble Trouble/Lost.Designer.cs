namespace Bubble_Trouble
{
    partial class Lost
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
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNo.Image = global::Bubble_Trouble.Properties.Resources.btnNo;
            this.btnNo.Location = new System.Drawing.Point(254, 183);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(150, 36);
            this.btnNo.TabIndex = 4;
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYes.Image = global::Bubble_Trouble.Properties.Resources.btnYes;
            this.btnYes.Location = new System.Drawing.Point(36, 183);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(150, 36);
            this.btnYes.TabIndex = 3;
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.BackColor = System.Drawing.Color.Transparent;
            this.lblPoeni.Font = new System.Drawing.Font("Papyrus", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeni.Location = new System.Drawing.Point(298, 74);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(85, 38);
            this.lblPoeni.TabIndex = 6;
            this.lblPoeni.Text = "label1";
            // 
            // Lost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bubble_Trouble.Properties.Resources.lost;
            this.ClientSize = new System.Drawing.Size(450, 251);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.MaximizeBox = false;
            this.Name = "Lost";
            this.Text = "Lost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblPoeni;

    }
}