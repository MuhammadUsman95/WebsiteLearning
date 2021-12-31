namespace SimpleCode
{
    partial class Simple
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
            this.MgsShow = new System.Windows.Forms.Button();
            this.lbtMgs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MgsShow
            // 
            this.MgsShow.Location = new System.Drawing.Point(58, 194);
            this.MgsShow.Name = "MgsShow";
            this.MgsShow.Size = new System.Drawing.Size(147, 52);
            this.MgsShow.TabIndex = 0;
            this.MgsShow.Text = "MgsShow";
            this.MgsShow.UseVisualStyleBackColor = true;
            this.MgsShow.Click += new System.EventHandler(this.MgsShow_Click);
            // 
            // lbtMgs
            // 
            this.lbtMgs.AutoSize = true;
            this.lbtMgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtMgs.ForeColor = System.Drawing.Color.Maroon;
            this.lbtMgs.Location = new System.Drawing.Point(53, 68);
            this.lbtMgs.Name = "lbtMgs";
            this.lbtMgs.Size = new System.Drawing.Size(0, 29);
            this.lbtMgs.TabIndex = 1;
            this.lbtMgs.Click += new System.EventHandler(this.MgsShow_Click);
            // 
            // Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(328, 308);
            this.Controls.Add(this.lbtMgs);
            this.Controls.Add(this.MgsShow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Simple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MgsShow;
        private System.Windows.Forms.Label lbtMgs;
    }
}

