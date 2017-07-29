namespace finalone
{
    partial class bill
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bill));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.productDataSet = new finalone.productDataSet();
            this.productDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new finalone.productDataSetTableAdapters.productTableAdapter();
            this.txtname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "Product Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "Product Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Product Name";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(225, 175);
            this.txtprice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(290, 20);
            this.txtprice.TabIndex = 62;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(225, 221);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(290, 20);
            this.txtquantity.TabIndex = 61;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "productDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productDataSetBindingSource
            // 
            this.productDataSetBindingSource.DataSource = this.productDataSet;
            this.productDataSetBindingSource.Position = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.productDataSetBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(225, 127);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(290, 20);
            this.txtname.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalone.Properties.Resources.vista_wallpaper_background_cool_photo_color_87175;
            this.ClientSize = new System.Drawing.Size(579, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtquantity);
            this.Name = "bill";
            this.Text = "bill";
            this.Load += new System.EventHandler(this.bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private productDataSet productDataSet;
        private System.Windows.Forms.BindingSource productDataSetBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private productDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}