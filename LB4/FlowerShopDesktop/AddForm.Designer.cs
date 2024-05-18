namespace FlowerShopDesktop
{
    partial class AddForm
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
            this.wrapperRadioButton = new System.Windows.Forms.RadioButton();
            this.flowerRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonsBox = new System.Windows.Forms.GroupBox();
            this.flowerName = new System.Windows.Forms.Label();
            this.flowerPrice = new System.Windows.Forms.Label();
            this.flowerPriceTextBox = new System.Windows.Forms.TextBox();
            this.flowerColor = new System.Windows.Forms.Label();
            this.flowerColorTextBox = new System.Windows.Forms.TextBox();
            this.wrapperPrice = new System.Windows.Forms.Label();
            this.wrapperPriceTextBox = new System.Windows.Forms.TextBox();
            this.wrapperMaterial = new System.Windows.Forms.Label();
            this.wrapperMaterialTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.flowerNameComboBox = new System.Windows.Forms.ComboBox();
            this.flowerGroupBox = new System.Windows.Forms.GroupBox();
            this.wrapperGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonsBox.SuspendLayout();
            this.flowerGroupBox.SuspendLayout();
            this.wrapperGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrapperRadioButton
            // 
            this.wrapperRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapperRadioButton.AutoSize = true;
            this.wrapperRadioButton.Location = new System.Drawing.Point(373, 42);
            this.wrapperRadioButton.Name = "wrapperRadioButton";
            this.wrapperRadioButton.Size = new System.Drawing.Size(81, 20);
            this.wrapperRadioButton.TabIndex = 0;
            this.wrapperRadioButton.Text = "Wrapper";
            this.wrapperRadioButton.UseVisualStyleBackColor = true;
            this.wrapperRadioButton.CheckedChanged += new System.EventHandler(this.wrapperRadioButton_CheckedChanged);
            // 
            // flowerRadioButton
            // 
            this.flowerRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerRadioButton.AutoSize = true;
            this.flowerRadioButton.Checked = true;
            this.flowerRadioButton.Location = new System.Drawing.Point(96, 42);
            this.flowerRadioButton.Name = "flowerRadioButton";
            this.flowerRadioButton.Size = new System.Drawing.Size(68, 20);
            this.flowerRadioButton.TabIndex = 1;
            this.flowerRadioButton.TabStop = true;
            this.flowerRadioButton.Text = "Flower";
            this.flowerRadioButton.UseVisualStyleBackColor = true;
            this.flowerRadioButton.CheckedChanged += new System.EventHandler(this.flowerRadioButton_CheckedChanged);
            // 
            // radioButtonsBox
            // 
            this.radioButtonsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonsBox.Controls.Add(this.flowerRadioButton);
            this.radioButtonsBox.Controls.Add(this.wrapperRadioButton);
            this.radioButtonsBox.Location = new System.Drawing.Point(0, 0);
            this.radioButtonsBox.Name = "radioButtonsBox";
            this.radioButtonsBox.Size = new System.Drawing.Size(556, 107);
            this.radioButtonsBox.TabIndex = 2;
            this.radioButtonsBox.TabStop = false;
            // 
            // flowerName
            // 
            this.flowerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerName.AutoSize = true;
            this.flowerName.Location = new System.Drawing.Point(6, 35);
            this.flowerName.Name = "flowerName";
            this.flowerName.Size = new System.Drawing.Size(44, 16);
            this.flowerName.TabIndex = 4;
            this.flowerName.Text = "Name";
            // 
            // flowerPrice
            // 
            this.flowerPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerPrice.AutoSize = true;
            this.flowerPrice.Location = new System.Drawing.Point(6, 103);
            this.flowerPrice.Name = "flowerPrice";
            this.flowerPrice.Size = new System.Drawing.Size(38, 16);
            this.flowerPrice.TabIndex = 6;
            this.flowerPrice.Text = "Price";
            // 
            // flowerPriceTextBox
            // 
            this.flowerPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerPriceTextBox.Location = new System.Drawing.Point(56, 97);
            this.flowerPriceTextBox.Name = "flowerPriceTextBox";
            this.flowerPriceTextBox.Size = new System.Drawing.Size(134, 22);
            this.flowerPriceTextBox.TabIndex = 5;
            // 
            // flowerColor
            // 
            this.flowerColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerColor.AutoSize = true;
            this.flowerColor.Location = new System.Drawing.Point(6, 169);
            this.flowerColor.Name = "flowerColor";
            this.flowerColor.Size = new System.Drawing.Size(39, 16);
            this.flowerColor.TabIndex = 8;
            this.flowerColor.Text = "Color";
            // 
            // flowerColorTextBox
            // 
            this.flowerColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerColorTextBox.Location = new System.Drawing.Point(56, 166);
            this.flowerColorTextBox.Name = "flowerColorTextBox";
            this.flowerColorTextBox.Size = new System.Drawing.Size(134, 22);
            this.flowerColorTextBox.TabIndex = 7;
            // 
            // wrapperPrice
            // 
            this.wrapperPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapperPrice.AutoSize = true;
            this.wrapperPrice.Location = new System.Drawing.Point(9, 90);
            this.wrapperPrice.Name = "wrapperPrice";
            this.wrapperPrice.Size = new System.Drawing.Size(38, 16);
            this.wrapperPrice.TabIndex = 12;
            this.wrapperPrice.Text = "Price";
            // 
            // wrapperPriceTextBox
            // 
            this.wrapperPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapperPriceTextBox.Location = new System.Drawing.Point(66, 87);
            this.wrapperPriceTextBox.Name = "wrapperPriceTextBox";
            this.wrapperPriceTextBox.Size = new System.Drawing.Size(148, 22);
            this.wrapperPriceTextBox.TabIndex = 11;
            // 
            // wrapperMaterial
            // 
            this.wrapperMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapperMaterial.AutoSize = true;
            this.wrapperMaterial.Location = new System.Drawing.Point(9, 25);
            this.wrapperMaterial.Name = "wrapperMaterial";
            this.wrapperMaterial.Size = new System.Drawing.Size(55, 16);
            this.wrapperMaterial.TabIndex = 10;
            this.wrapperMaterial.Text = "Material";
            // 
            // wrapperMaterialTextBox
            // 
            this.wrapperMaterialTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wrapperMaterialTextBox.Location = new System.Drawing.Point(66, 22);
            this.wrapperMaterialTextBox.Name = "wrapperMaterialTextBox";
            this.wrapperMaterialTextBox.Size = new System.Drawing.Size(148, 22);
            this.wrapperMaterialTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(25, 367);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(505, 51);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // flowerNameComboBox
            // 
            this.flowerNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowerNameComboBox.FormattingEnabled = true;
            this.flowerNameComboBox.Items.AddRange(new object[] {
            "Rose",
            "Tulpin",
            "Gladiolus",
            "Iris"});
            this.flowerNameComboBox.Location = new System.Drawing.Point(56, 32);
            this.flowerNameComboBox.Name = "flowerNameComboBox";
            this.flowerNameComboBox.Size = new System.Drawing.Size(134, 24);
            this.flowerNameComboBox.TabIndex = 16;
            // 
            // flowerGroupBox
            // 
            this.flowerGroupBox.Controls.Add(this.flowerName);
            this.flowerGroupBox.Controls.Add(this.flowerNameComboBox);
            this.flowerGroupBox.Controls.Add(this.flowerPriceTextBox);
            this.flowerGroupBox.Controls.Add(this.flowerPrice);
            this.flowerGroupBox.Controls.Add(this.flowerColorTextBox);
            this.flowerGroupBox.Controls.Add(this.flowerColor);
            this.flowerGroupBox.Location = new System.Drawing.Point(25, 113);
            this.flowerGroupBox.Name = "flowerGroupBox";
            this.flowerGroupBox.Size = new System.Drawing.Size(247, 248);
            this.flowerGroupBox.TabIndex = 17;
            this.flowerGroupBox.TabStop = false;
            // 
            // wrapperGroupBox
            // 
            this.wrapperGroupBox.Controls.Add(this.wrapperMaterial);
            this.wrapperGroupBox.Controls.Add(this.wrapperMaterialTextBox);
            this.wrapperGroupBox.Controls.Add(this.wrapperPriceTextBox);
            this.wrapperGroupBox.Controls.Add(this.wrapperPrice);
            this.wrapperGroupBox.Location = new System.Drawing.Point(278, 113);
            this.wrapperGroupBox.Name = "wrapperGroupBox";
            this.wrapperGroupBox.Size = new System.Drawing.Size(252, 248);
            this.wrapperGroupBox.TabIndex = 18;
            this.wrapperGroupBox.TabStop = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 430);
            this.Controls.Add(this.wrapperGroupBox);
            this.Controls.Add(this.flowerGroupBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.radioButtonsBox);
            this.Name = "AddForm";
            this.Text = "Add";
            this.radioButtonsBox.ResumeLayout(false);
            this.radioButtonsBox.PerformLayout();
            this.flowerGroupBox.ResumeLayout(false);
            this.flowerGroupBox.PerformLayout();
            this.wrapperGroupBox.ResumeLayout(false);
            this.wrapperGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton wrapperRadioButton;
        private System.Windows.Forms.RadioButton flowerRadioButton;
        private System.Windows.Forms.GroupBox radioButtonsBox;
        private System.Windows.Forms.Label flowerName;
        private System.Windows.Forms.Label flowerPrice;
        private System.Windows.Forms.TextBox flowerPriceTextBox;
        private System.Windows.Forms.Label flowerColor;
        private System.Windows.Forms.TextBox flowerColorTextBox;
        private System.Windows.Forms.Label wrapperPrice;
        private System.Windows.Forms.TextBox wrapperPriceTextBox;
        private System.Windows.Forms.Label wrapperMaterial;
        private System.Windows.Forms.TextBox wrapperMaterialTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox flowerNameComboBox;
        private System.Windows.Forms.GroupBox flowerGroupBox;
        private System.Windows.Forms.GroupBox wrapperGroupBox;
    }
}