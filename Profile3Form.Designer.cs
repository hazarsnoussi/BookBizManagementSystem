namespace BookBizManagementSystem
{
    partial class Profile3Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile3Form));
            this.buttonListBook = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListBook
            // 
            this.buttonListBook.BackColor = System.Drawing.SystemColors.Window;
            this.buttonListBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonListBook.BackgroundImage")));
            this.buttonListBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonListBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListBook.Location = new System.Drawing.Point(492, 142);
            this.buttonListBook.Name = "buttonListBook";
            this.buttonListBook.Size = new System.Drawing.Size(150, 166);
            this.buttonListBook.TabIndex = 19;
            this.buttonListBook.Text = "LIST BOOK";
            this.buttonListBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonListBook.UseVisualStyleBackColor = false;
            this.buttonListBook.Click += new System.EventHandler(this.buttonListBook_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSearchBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearchBook.BackgroundImage")));
            this.buttonSearchBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchBook.Location = new System.Drawing.Point(325, 142);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(150, 166);
            this.buttonSearchBook.TabIndex = 18;
            this.buttonSearchBook.Text = "SEARCH BOOK";
            this.buttonSearchBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearchBook.UseVisualStyleBackColor = false;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAddBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddBook.BackgroundImage")));
            this.buttonAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.Location = new System.Drawing.Point(158, 142);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(150, 166);
            this.buttonAddBook.TabIndex = 17;
            this.buttonAddBook.Text = "ADD BOOK";
            this.buttonAddBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Location = new System.Drawing.Point(658, 393);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 45);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Profile3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.buttonListBook);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.buttonAddBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile3Form";
            this.Text = "Inventory Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListBook;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button ExitButton;
    }
}