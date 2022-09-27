namespace BookBizManagementSystem
{
    partial class PlaceOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceOrderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.comboBoxEmployeeID = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomerID = new System.Windows.Forms.ComboBox();
            this.comboBoxISBN = new System.Windows.Forms.ComboBox();
            this.BackButtton = new System.Windows.Forms.Button();
            this.labeliNFO = new System.Windows.Forms.Label();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(343, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLACE ORDER FORM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CustomerID";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.Location = new System.Drawing.Point(107, 227);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(47, 20);
            this.labelISBN.TabIndex = 3;
            this.labelISBN.Text = "ISBN";
            this.labelISBN.Visible = false;
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.Location = new System.Drawing.Point(107, 279);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(68, 20);
            this.labelQty.TabIndex = 4;
            this.labelQty.Text = "Quantity";
            this.labelQty.Visible = false;
            // 
            // comboBoxEmployeeID
            // 
            this.comboBoxEmployeeID.FormattingEnabled = true;
            this.comboBoxEmployeeID.Location = new System.Drawing.Point(213, 107);
            this.comboBoxEmployeeID.Name = "comboBoxEmployeeID";
            this.comboBoxEmployeeID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployeeID.TabIndex = 5;
            // 
            // comboBoxCustomerID
            // 
            this.comboBoxCustomerID.FormattingEnabled = true;
            this.comboBoxCustomerID.Location = new System.Drawing.Point(213, 167);
            this.comboBoxCustomerID.Name = "comboBoxCustomerID";
            this.comboBoxCustomerID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustomerID.TabIndex = 6;
            // 
            // comboBoxISBN
            // 
            this.comboBoxISBN.FormattingEnabled = true;
            this.comboBoxISBN.Location = new System.Drawing.Point(213, 227);
            this.comboBoxISBN.Name = "comboBoxISBN";
            this.comboBoxISBN.Size = new System.Drawing.Size(121, 21);
            this.comboBoxISBN.TabIndex = 7;
            this.comboBoxISBN.Visible = false;
            // 
            // BackButtton
            // 
            this.BackButtton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButtton.BackgroundImage")));
            this.BackButtton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButtton.Location = new System.Drawing.Point(894, 427);
            this.BackButtton.Name = "BackButtton";
            this.BackButtton.Size = new System.Drawing.Size(112, 71);
            this.BackButtton.TabIndex = 11;
            this.BackButtton.UseVisualStyleBackColor = true;
            this.BackButtton.Click += new System.EventHandler(this.BackButtton_Click);
            // 
            // labeliNFO
            // 
            this.labeliNFO.AutoSize = true;
            this.labeliNFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeliNFO.ForeColor = System.Drawing.Color.ForestGreen;
            this.labeliNFO.Location = new System.Drawing.Point(356, 230);
            this.labeliNFO.Name = "labeliNFO";
            this.labeliNFO.Size = new System.Drawing.Size(348, 13);
            this.labeliNFO.TabIndex = 16;
            this.labeliNFO.Text = "Please select again another ISBN and quantity to add to the same order.";
            this.labeliNFO.Visible = false;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateOrder.Location = new System.Drawing.Point(380, 165);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(145, 32);
            this.buttonCreateOrder.TabIndex = 17;
            this.buttonCreateOrder.Text = "CREATE ORDER";
            this.buttonCreateOrder.UseVisualStyleBackColor = false;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // addBook
            // 
            this.addBook.BackColor = System.Drawing.Color.ForestGreen;
            this.addBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBook.Location = new System.Drawing.Point(380, 268);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(145, 30);
            this.addBook.TabIndex = 18;
            this.addBook.Text = "ADD BOOK";
            this.addBook.UseVisualStyleBackColor = false;
            this.addBook.Visible = false;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(213, 316);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.Size = new System.Drawing.Size(630, 150);
            this.dataGridViewOrder.TabIndex = 19;
            this.dataGridViewOrder.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(620, 273);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(57, 20);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.Text = "Total =";
            this.labelTotal.Visible = false;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(213, 278);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(121, 20);
            this.textBoxQty.TabIndex = 21;
            this.textBoxQty.Visible = false;
            // 
            // PlaceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1018, 510);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.labeliNFO);
            this.Controls.Add(this.BackButtton);
            this.Controls.Add(this.comboBoxISBN);
            this.Controls.Add(this.comboBoxCustomerID);
            this.Controls.Add(this.comboBoxEmployeeID);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlaceOrderForm";
            this.Text = "PlaceOrderForm";
            this.Load += new System.EventHandler(this.PlaceOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.ComboBox comboBoxEmployeeID;
        private System.Windows.Forms.ComboBox comboBoxCustomerID;
        private System.Windows.Forms.ComboBox comboBoxISBN;
        private System.Windows.Forms.Button BackButtton;
        private System.Windows.Forms.Label labeliNFO;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxQty;
    }
}