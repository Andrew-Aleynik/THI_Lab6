using System.Windows.Forms;
namespace FlowerShopDesktop
{
    partial class FlowerEditForm
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
            this.flowerColor = new System.Windows.Forms.Label();
            this.flowerColorTextBox = new System.Windows.Forms.TextBox();
            this.flowerPrice = new System.Windows.Forms.Label();
            this.flowerPriceTextBox = new System.Windows.Forms.TextBox();
            this.flowerName = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.flowerNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowerColor
            // 
            this.flowerColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerColor.AutoSize = true;
            this.flowerColor.Location = new System.Drawing.Point(74, 251);
            this.flowerColor.Name = "flowerColor";
            this.flowerColor.Size = new System.Drawing.Size(39, 16);
            this.flowerColor.TabIndex = 21;
            this.flowerColor.Text = "Color";
            // 
            // flowerColorTextBox
            // 
            this.flowerColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerColorTextBox.Location = new System.Drawing.Point(148, 248);
            this.flowerColorTextBox.Name = "flowerColorTextBox";
            this.flowerColorTextBox.Size = new System.Drawing.Size(157, 22);
            this.flowerColorTextBox.TabIndex = 20;
            // 
            // flowerPrice
            // 
            this.flowerPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerPrice.AutoSize = true;
            this.flowerPrice.Location = new System.Drawing.Point(74, 178);
            this.flowerPrice.Name = "flowerPrice";
            this.flowerPrice.Size = new System.Drawing.Size(38, 16);
            this.flowerPrice.TabIndex = 19;
            this.flowerPrice.Text = "Price";
            // 
            // flowerPriceTextBox
            // 
            this.flowerPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerPriceTextBox.Location = new System.Drawing.Point(148, 175);
            this.flowerPriceTextBox.Name = "flowerPriceTextBox";
            this.flowerPriceTextBox.Size = new System.Drawing.Size(157, 22);
            this.flowerPriceTextBox.TabIndex = 18;
            // 
            // flowerName
            // 
            this.flowerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerName.AutoSize = true;
            this.flowerName.Location = new System.Drawing.Point(74, 107);
            this.flowerName.Name = "flowerName";
            this.flowerName.Size = new System.Drawing.Size(44, 16);
            this.flowerName.TabIndex = 17;
            this.flowerName.Text = "Name";
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(77, 390);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(228, 51);
            this.editButton.TabIndex = 23;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // flowerNameTextBox
            // 
            this.flowerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerNameTextBox.Location = new System.Drawing.Point(148, 104);
            this.flowerNameTextBox.Name = "flowerNameTextBox";
            this.flowerNameTextBox.Size = new System.Drawing.Size(157, 22);
            this.flowerNameTextBox.TabIndex = 24;
            // 
            // FlowerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.flowerNameTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.flowerColor);
            this.Controls.Add(this.flowerColorTextBox);
            this.Controls.Add(this.flowerPrice);
            this.Controls.Add(this.flowerPriceTextBox);
            this.Controls.Add(this.flowerName);
            this.Name = "FlowerEditForm";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label flowerColor;
        private System.Windows.Forms.TextBox flowerColorTextBox;
        private System.Windows.Forms.Label flowerPrice;
        private System.Windows.Forms.TextBox flowerPriceTextBox;
        private System.Windows.Forms.Label flowerName;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox flowerNameTextBox;
    }
}