namespace finalone
{
    partial class print
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
            this.totalpay = new System.Windows.Forms.Label();
            this.use = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Amound Pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Amound Pay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Amound Pay";
            // 
            // totalpay
            // 
            this.totalpay.AutoSize = true;
            this.totalpay.Location = new System.Drawing.Point(176, 66);
            this.totalpay.Name = "totalpay";
            this.totalpay.Size = new System.Drawing.Size(0, 13);
            this.totalpay.TabIndex = 0;
            // 
            // use
            // 
            this.use.AutoSize = true;
            this.use.Location = new System.Drawing.Point(176, 113);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(0, 13);
            this.use.TabIndex = 0;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(176, 165);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(0, 13);
            this.balance.TabIndex = 0;
            // 
            // print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 394);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.use);
            this.Controls.Add(this.totalpay);
            this.Controls.Add(this.label1);
            this.Name = "print";
            this.Text = "print";
            this.Load += new System.EventHandler(this.print_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalpay;
        private System.Windows.Forms.Label use;
        private System.Windows.Forms.Label balance;
    }
}