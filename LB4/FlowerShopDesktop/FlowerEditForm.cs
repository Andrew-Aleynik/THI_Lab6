using LB4.FlowerShop;
using System;
using System.Windows.Forms;

namespace FlowerShopDesktop
{
    public partial class FlowerEditForm : Form
    {
        public AbstractFlower flower;
        public FlowerEditForm(AbstractFlower flower)
        {
            this.flower = flower;
            InitializeComponent();

            flowerNameTextBox.Text = flower.getName();
            flowerNameTextBox.Enabled = false;
            flowerPriceTextBox.Text = flower.getPrice().ToString();
            flowerColorTextBox.Text = flower.getColor();
            flowerColorTextBox.Enabled = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            flower.setPrice(int.Parse(flowerPriceTextBox.Text));
            DialogResult = DialogResult.OK;
        }

        public AbstractFlower getEditedFlower()
        {
            return flower;
        }
    }
}
