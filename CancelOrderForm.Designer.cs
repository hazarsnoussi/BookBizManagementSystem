namespace BookBizManagementSystem
{
    partial class CancelOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelOrderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewListOrders = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxListOrders = new System.Windows.Forms.ComboBox();
            this.BackButtton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(206, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delete Order by OrderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please select the order to cancel";
            // 
            // dataGridViewListOrders
            // 
            this.dataGridViewListOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListOrders.Location = new System.Drawing.Point(63, 187);
            this.dataGridViewListOrders.Name = "dataGridViewListOrders";
            this.dataGridViewListOrders.Size = new System.Drawing.Size(601, 150);
            this.dataGridViewListOrders.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(375, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxListOrders
            // 
            this.comboBoxListOrders.FormattingEnabled = true;
            this.comboBoxListOrders.Location = new System.Drawing.Point(234, 130);
            this.comboBoxListOrders.Name = "comboBoxListOrders";
            this.comboBoxListOrders.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListOrders.TabIndex = 8;
            this.comboBoxListOrders.SelectedIndexChanged += new System.EventHandler(this.comboBoxListOrders_SelectedIndexChanged);
            // 
            // BackButtton
            // 
            this.BackButtton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButtton.BackgroundImage")));
            this.BackButtton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButtton.Location = new System.Drawing.Point(684, 376);
            this.BackButtton.Name = "BackButtton";
            this.BackButtton.Size = new System.Drawing.Size(112, 71);
            this.BackButtton.TabIndex = 9;
            this.BackButtton.UseVisualStyleBackColor = true;
            this.BackButtton.Click += new System.EventHandler(this.BackButtton_Click);
            // 
            // CancelOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButtton);
            this.Controls.Add(this.comboBoxListOrders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewListOrders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CancelOrderForm";
            this.Text = "CancelOrderForm";
            this.Load += new System.EventHandler(this.CancelOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewListOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxListOrders;
        private System.Windows.Forms.Button BackButtton;
    }
}