namespace BookBizManagementSystem
{
    partial class Profile4Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile4Form));
            this.SearchOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchOrderButton
            // 
            this.SearchOrderButton.BackColor = System.Drawing.SystemColors.Window;
            this.SearchOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchOrderButton.BackgroundImage")));
            this.SearchOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SearchOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchOrderButton.Location = new System.Drawing.Point(244, 98);
            this.SearchOrderButton.Name = "SearchOrderButton";
            this.SearchOrderButton.Size = new System.Drawing.Size(150, 166);
            this.SearchOrderButton.TabIndex = 14;
            this.SearchOrderButton.Text = "SEARCH ORDER";
            this.SearchOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchOrderButton.UseVisualStyleBackColor = false;
            this.SearchOrderButton.Click += new System.EventHandler(this.SearchOrderButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(419, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 166);
            this.button1.TabIndex = 13;
            this.button1.Text = "LIST ORDER";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.BackColor = System.Drawing.SystemColors.Window;
            this.CancelOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelOrderButton.BackgroundImage")));
            this.CancelOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOrderButton.Location = new System.Drawing.Point(596, 98);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(150, 166);
            this.CancelOrderButton.TabIndex = 12;
            this.CancelOrderButton.Text = "CANCEL ORDER";
            this.CancelOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelOrderButton.UseVisualStyleBackColor = false;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.BackColor = System.Drawing.SystemColors.Window;
            this.PlaceOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlaceOrderButton.BackgroundImage")));
            this.PlaceOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlaceOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderButton.Location = new System.Drawing.Point(63, 98);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(150, 166);
            this.PlaceOrderButton.TabIndex = 11;
            this.PlaceOrderButton.Text = "PLACE ORDER";
            this.PlaceOrderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PlaceOrderButton.UseVisualStyleBackColor = false;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Location = new System.Drawing.Point(658, 393);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 45);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Profile4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchOrderButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.PlaceOrderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile4Form";
            this.Text = "Inventory Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchOrderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CancelOrderButton;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button ExitButton;
    }
}