namespace TeamSourceGameShop
{
    partial class frmAddOrUpdateGames
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
            this.lblNameOfGame = new System.Windows.Forms.Label();
            this.txtNameOfGame = new System.Windows.Forms.TextBox();
            this.lblPriceOfGame = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblNumOfCopies = new System.Windows.Forms.Label();
            this.txtNumberOfCopies = new System.Windows.Forms.TextBox();
            this.lblAvailabilityOfGame = new System.Windows.Forms.Label();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.btnAddOrUpdateGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameOfGame
            // 
            this.lblNameOfGame.AutoSize = true;
            this.lblNameOfGame.Location = new System.Drawing.Point(12, 24);
            this.lblNameOfGame.Name = "lblNameOfGame";
            this.lblNameOfGame.Size = new System.Drawing.Size(69, 13);
            this.lblNameOfGame.TabIndex = 0;
            this.lblNameOfGame.Text = "Game Name:";
            // 
            // txtNameOfGame
            // 
            this.txtNameOfGame.Location = new System.Drawing.Point(120, 21);
            this.txtNameOfGame.Name = "txtNameOfGame";
            this.txtNameOfGame.Size = new System.Drawing.Size(137, 20);
            this.txtNameOfGame.TabIndex = 1;
            // 
            // lblPriceOfGame
            // 
            this.lblPriceOfGame.AutoSize = true;
            this.lblPriceOfGame.Location = new System.Drawing.Point(12, 64);
            this.lblPriceOfGame.Name = "lblPriceOfGame";
            this.lblPriceOfGame.Size = new System.Drawing.Size(34, 13);
            this.lblPriceOfGame.TabIndex = 2;
            this.lblPriceOfGame.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(120, 61);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(137, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // lblNumOfCopies
            // 
            this.lblNumOfCopies.AutoSize = true;
            this.lblNumOfCopies.Location = new System.Drawing.Point(12, 109);
            this.lblNumOfCopies.Name = "lblNumOfCopies";
            this.lblNumOfCopies.Size = new System.Drawing.Size(96, 13);
            this.lblNumOfCopies.TabIndex = 4;
            this.lblNumOfCopies.Text = "Number Of Copies:";
            // 
            // txtNumberOfCopies
            // 
            this.txtNumberOfCopies.Location = new System.Drawing.Point(120, 102);
            this.txtNumberOfCopies.Name = "txtNumberOfCopies";
            this.txtNumberOfCopies.Size = new System.Drawing.Size(137, 20);
            this.txtNumberOfCopies.TabIndex = 5;
            // 
            // lblAvailabilityOfGame
            // 
            this.lblAvailabilityOfGame.AutoSize = true;
            this.lblAvailabilityOfGame.Location = new System.Drawing.Point(12, 149);
            this.lblAvailabilityOfGame.Name = "lblAvailabilityOfGame";
            this.lblAvailabilityOfGame.Size = new System.Drawing.Size(59, 13);
            this.lblAvailabilityOfGame.TabIndex = 6;
            this.lblAvailabilityOfGame.Text = "Availability:";
            // 
            // txtAvailability
            // 
            this.txtAvailability.Location = new System.Drawing.Point(120, 146);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.Size = new System.Drawing.Size(137, 20);
            this.txtAvailability.TabIndex = 7;
            // 
            // btnAddOrUpdateGame
            // 
            this.btnAddOrUpdateGame.Location = new System.Drawing.Point(79, 189);
            this.btnAddOrUpdateGame.Name = "btnAddOrUpdateGame";
            this.btnAddOrUpdateGame.Size = new System.Drawing.Size(121, 48);
            this.btnAddOrUpdateGame.TabIndex = 8;
            this.btnAddOrUpdateGame.UseVisualStyleBackColor = true;
            this.btnAddOrUpdateGame.Click += new System.EventHandler(this.btnAddOrUpdateGame_Click);
            // 
            // frmAddOrUpdateGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAddOrUpdateGame);
            this.Controls.Add(this.txtAvailability);
            this.Controls.Add(this.lblAvailabilityOfGame);
            this.Controls.Add(this.txtNumberOfCopies);
            this.Controls.Add(this.lblNumOfCopies);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPriceOfGame);
            this.Controls.Add(this.txtNameOfGame);
            this.Controls.Add(this.lblNameOfGame);
            this.Name = "frmAddOrUpdateGames";
            this.Load += new System.EventHandler(this.frmAddOrUpdateGames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameOfGame;
        private System.Windows.Forms.TextBox txtNameOfGame;
        private System.Windows.Forms.Label lblPriceOfGame;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblNumOfCopies;
        private System.Windows.Forms.TextBox txtNumberOfCopies;
        private System.Windows.Forms.Label lblAvailabilityOfGame;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.Button btnAddOrUpdateGame;
    }
}