namespace finalone
{
    partial class billing
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
            System.Windows.Forms.Label idLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billing));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label dateLabel;
            this.productDataSet = new finalone.productDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new finalone.productDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new finalone.productDataSetTableAdapters.TableAdapterManager();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.ttotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Image = ((System.Drawing.Image)(resources.GetObject("idLabel1.Image")));
            idLabel1.Location = new System.Drawing.Point(176, 143);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 57;
            idLabel1.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Image = ((System.Drawing.Image)(resources.GetObject("nameLabel.Image")));
            nameLabel.Location = new System.Drawing.Point(176, 169);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 59;
            nameLabel.Text = "name:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Image = ((System.Drawing.Image)(resources.GetObject("priceLabel.Image")));
            priceLabel.Location = new System.Drawing.Point(176, 195);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 61;
            priceLabel.Text = "price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Image = ((System.Drawing.Image)(resources.GetObject("quantityLabel.Image")));
            quantityLabel.Location = new System.Drawing.Point(176, 221);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(47, 13);
            quantityLabel.TabIndex = 63;
            quantityLabel.Text = "quantity:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Image = ((System.Drawing.Image)(resources.GetObject("dateLabel.Image")));
            dateLabel.Location = new System.Drawing.Point(176, 250);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(31, 13);
            dateLabel.TabIndex = 65;
            dateLabel.Text = "date:";
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "productDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.productDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.productTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = finalone.productDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.productBindingSource;
            this.listBox1.DisplayMember = "name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 11;
            this.listBox1.ValueMember = "name";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(23, 140);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(120, 20);
            this.search.TabIndex = 12;
            this.search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold);
            this.submit.Image = global::finalone.Properties.Resources.images__1_;
            this.submit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.submit.Location = new System.Drawing.Point(272, 278);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(110, 34);
            this.submit.TabIndex = 13;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product Name";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(245, 140);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(97, 20);
            this.idTextBox1.TabIndex = 58;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(245, 166);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(203, 20);
            this.nameTextBox.TabIndex = 60;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(245, 192);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(203, 20);
            this.priceTextBox.TabIndex = 62;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(245, 218);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(203, 20);
            this.quantityTextBox.TabIndex = 64;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(245, 244);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.dateDateTimePicker.TabIndex = 66;
            // 
            // lout
            // 
            this.lout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lout.ForeColor = System.Drawing.SystemColors.Control;
            this.lout.Image = global::finalone.Properties.Resources.images__1_;
            this.lout.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lout.Location = new System.Drawing.Point(466, 63);
            this.lout.Name = "lout";
            this.lout.Size = new System.Drawing.Size(95, 27);
            this.lout.TabIndex = 67;
            this.lout.Text = "LOCK OUT";
            this.lout.UseVisualStyleBackColor = true;
            this.lout.Click += new System.EventHandler(this.lout_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::finalone.Properties.Resources.images__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::finalone.Properties.Resources.images__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(2, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 27);
            this.button1.TabIndex = 68;
            this.button1.Text = "BACK TO MAIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Image = global::finalone.Properties.Resources.images__1_;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(160, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 51);
            this.label2.TabIndex = 69;
            this.label2.Text = "BILLING SYSTEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::finalone.Properties.Resources.images__1_;
            this.label4.Location = new System.Drawing.Point(176, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Money Paid";
            // 
            // paid
            // 
            this.paid.Location = new System.Drawing.Point(245, 322);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(203, 20);
            this.paid.TabIndex = 71;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::finalone.Properties.Resources.images__1_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(272, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 72;
            this.button2.Text = "BILL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(401, 349);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 13);
            this.total.TabIndex = 73;
            // 
            // ttotal
            // 
            this.ttotal.AutoSize = true;
            this.ttotal.Font = new System.Drawing.Font("Colonna MT", 18F, System.Drawing.FontStyle.Bold);
            this.ttotal.Image = global::finalone.Properties.Resources.images__1_;
            this.ttotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttotal.Location = new System.Drawing.Point(568, 209);
            this.ttotal.Name = "ttotal";
            this.ttotal.Size = new System.Drawing.Size(0, 25);
            this.ttotal.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Colonna MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::finalone.Properties.Resources.images__1_;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(535, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 37);
            this.label5.TabIndex = 74;
            this.label5.Text = "Total";
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalone.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 432);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ttotal);
            this.Controls.Add(this.total);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lout);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.listBox1);
            this.Name = "billing";
            this.Text = "billing";
            this.Load += new System.EventHandler(this.billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private productDataSet productDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private productDataSetTableAdapters.productTableAdapter productTableAdapter;
        private productDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Button lout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label ttotal;
        private System.Windows.Forms.Label label5;
    }
}