namespace SimpleCode
{
    partial class Form2
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
            this.no1 = new System.Windows.Forms.Label();
            this.txtno1 = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Label();
            this.txtno2 = new System.Windows.Forms.TextBox();
            this.no2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnCalcu = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdbAdd = new System.Windows.Forms.RadioButton();
            this.RdbSub = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // no1
            // 
            this.no1.AutoSize = true;
            this.no1.Location = new System.Drawing.Point(21, 49);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(50, 13);
            this.no1.TabIndex = 0;
            this.no1.Text = "Number1";
            // 
            // txtno1
            // 
            this.txtno1.Location = new System.Drawing.Point(24, 79);
            this.txtno1.Multiline = true;
            this.txtno1.Name = "txtno1";
            this.txtno1.Size = new System.Drawing.Size(170, 25);
            this.txtno1.TabIndex = 0;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(100, 221);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(13, 13);
            this.equal.TabIndex = 0;
            this.equal.Text = "=";
            // 
            // txtno2
            // 
            this.txtno2.Location = new System.Drawing.Point(24, 154);
            this.txtno2.Multiline = true;
            this.txtno2.Name = "txtno2";
            this.txtno2.Size = new System.Drawing.Size(170, 25);
            this.txtno2.TabIndex = 1;
            // 
            // no2
            // 
            this.no2.AutoSize = true;
            this.no2.Location = new System.Drawing.Point(21, 138);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(50, 13);
            this.no2.TabIndex = 0;
            this.no2.Text = "Number2";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(24, 246);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(170, 25);
            this.txttotal.TabIndex = 2;
            // 
            // btnCalcu
            // 
            this.btnCalcu.Location = new System.Drawing.Point(24, 315);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Size = new System.Drawing.Size(148, 37);
            this.btnCalcu.TabIndex = 5;
            this.btnCalcu.Text = "Calcu";
            this.btnCalcu.UseVisualStyleBackColor = true;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(188, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 37);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbSub);
            this.groupBox2.Controls.Add(this.RdbAdd);
            this.groupBox2.Location = new System.Drawing.Point(310, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 99);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "opt";
            // 
            // RdbAdd
            // 
            this.RdbAdd.AutoSize = true;
            this.RdbAdd.Checked = true;
            this.RdbAdd.Location = new System.Drawing.Point(22, 30);
            this.RdbAdd.Name = "RdbAdd";
            this.RdbAdd.Size = new System.Drawing.Size(44, 17);
            this.RdbAdd.TabIndex = 3;
            this.RdbAdd.TabStop = true;
            this.RdbAdd.Text = "Add";
            this.RdbAdd.UseVisualStyleBackColor = true;
            // 
            // RdbSub
            // 
            this.RdbSub.AutoSize = true;
            this.RdbSub.Location = new System.Drawing.Point(22, 53);
            this.RdbSub.Name = "RdbSub";
            this.RdbSub.Size = new System.Drawing.Size(44, 17);
            this.RdbSub.TabIndex = 4;
            this.RdbSub.Text = "Sub";
            this.RdbSub.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcu);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtno2);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.txtno1);
            this.Controls.Add(this.no1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Form2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label no1;
        private System.Windows.Forms.TextBox txtno1;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.TextBox txtno2;
        private System.Windows.Forms.Label no2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnCalcu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdbSub;
        private System.Windows.Forms.RadioButton RdbAdd;
    }
}