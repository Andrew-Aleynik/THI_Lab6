namespace FlowerShopDesktop
{
    partial class WrapperEditForm
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
            this.editButton = new System.Windows.Forms.Button();
            this.wrapperPrice = new System.Windows.Forms.Label();
            this.wrapperPriceTextBox = new System.Windows.Forms.TextBox();
            this.wrapperMaterial = new System.Windows.Forms.Label();
            this.wrapperMaterialTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(77, 381);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(228, 51);
            this.editButton.TabIndex = 20;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // wrapperPrice
            // 
            this.wrapperPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapperPrice.AutoSize = true;
            this.wrapperPrice.Location = new System.Drawing.Point(74, 138);
            this.wrapperPrice.Name = "wrapperPrice";
            this.wrapperPrice.Size = new System.Drawing.Size(38, 16);
            this.wrapperPrice.TabIndex = 19;
            this.wrapperPrice.Text = "Price";
            // 
            // wrapperPriceTextBox
            // 
            this.wrapperPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapperPriceTextBox.Location = new System.Drawing.Point(148, 135);
            this.wrapperPriceTextBox.Name = "wrapperPriceTextBox";
            this.wrapperPriceTextBox.Size = new System.Drawing.Size(157, 22);
            this.wrapperPriceTextBox.TabIndex = 18;
            // 
            // wrapperMaterial
            // 
            this.wrapperMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapperMaterial.AutoSize = true;
            this.wrapperMaterial.Location = new System.Drawing.Point(74, 67);
            this.wrapperMaterial.Name = "wrapperMaterial";
            this.wrapperMaterial.Size = new System.Drawing.Size(55, 16);
            this.wrapperMaterial.TabIndex = 17;
            this.wrapperMaterial.Text = "Material";
            // 
            // wrapperMaterialTextBox
            // 
            this.wrapperMaterialTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapperMaterialTextBox.Location = new System.Drawing.Point(148, 64);
            this.wrapperMaterialTextBox.Name = "wrapperMaterialTextBox";
            this.wrapperMaterialTextBox.Size = new System.Drawing.Size(157, 22);
            this.wrapperMaterialTextBox.TabIndex = 16;
            // 
            // WrapperEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.wrapperPrice);
            this.Controls.Add(this.wrapperPriceTextBox);
            this.Controls.Add(this.wrapperMaterial);
            this.Controls.Add(this.wrapperMaterialTextBox);
            this.Name = "WrapperEditForm";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label wrapperPrice;
        private System.Windows.Forms.TextBox wrapperPriceTextBox;
        private System.Windows.Forms.Label wrapperMaterial;
        private System.Windows.Forms.TextBox wrapperMaterialTextBox;
    }
}