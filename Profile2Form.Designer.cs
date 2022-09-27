namespace BookBizManagementSystem
{
    partial class Profile2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile2Form));
            this.SearchCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.ListCustomersButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchCustomerButton
            // 
            this.SearchCustomerButton.BackColor = System.Drawing.SystemColors.Window;
            this.SearchCustomerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchCustomerButton.BackgroundImage")));
            this.SearchCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerButton.Location = new System.Drawing.Point(327, 142);
            this.SearchCustomerButton.Name = "SearchCustomerButton";
            this.SearchCustomerButton.Size = new System.Drawing.Size(150, 166);
            this.SearchCustomerButton.TabIndex = 8;
            this.SearchCustomerButton.Text = "SEARCH CUSTOMER";
            this.SearchCustomerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchCustomerButton.UseVisualStyleBackColor = false;
            this.SearchCustomerButton.Click += new System.EventHandler(this.SearchCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackColor = System.Drawing.SystemColors.Window;
            this.AddCustomerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCustomerButton.BackgroundImage")));
            this.AddCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddCustomerButton.Location = new System.Drawing.Point(158, 142);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(150, 166);
            this.AddCustomerButton.TabIndex = 7;
            this.AddCustomerButton.Text = "ADD CUSTOMER";
            this.AddCustomerButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // ListCustomersButton
            // 
            this.ListCustomersButton.BackColor = System.Drawing.SystemColors.Window;
            this.ListCustomersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListCustomersButton.BackgroundImage")));
            this.ListCustomersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ListCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCustomersButton.Location = new System.Drawing.Point(493, 142);
            this.ListCustomersButton.Name = "ListCustomersButton";
            this.ListCustomersButton.Size = new System.Drawing.Size(150, 166);
            this.ListCustomersButton.TabIndex = 6;
            this.ListCustomersButton.Text = "LIST CUSTOMERS";
            this.ListCustomersButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ListCustomersButton.UseVisualStyleBackColor = false;
            this.ListCustomersButton.Click += new System.EventHandler(this.ListCustomersButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Location = new System.Drawing.Point(658, 393);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 45);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Profile2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.ListCustomersButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile2Form";
            this.Text = "SalesManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button ListCustomersButton;
        private System.Windows.Forms.Button ExitButton;
    }
}