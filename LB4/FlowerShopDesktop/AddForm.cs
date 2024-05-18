using LB4.Factories;
using LB4.FlowerShop;
using System;
using System.Windows.Forms;

namespace FlowerShopDesktop
{
    public partial class AddForm : Form
    {
        AbstractFlowerFactory flowerFactory;
        WrapperFactory wrapperFactory;
        public AbstractFlower flower;
        public Wrapper wrapper;
        public AddForm()
        {
            InitializeComponent();
            if (flowerRadioButton.Checked)
            {
                flowerGroupBox.Enabled = true;
                wrapperGroupBox.Enabled = false;
            }
            else
            {
                flowerGroupBox.Enabled = false;
                wrapperGroupBox.Enabled = true;
            }
            flowerFactory = new AbstractFlowerFactory();
            wrapperFactory = new WrapperFactory();
        }

        private void flowerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flowerGroupBox.Enabled = true;
            wrapperGroupBox.Enabled = false;
        }

        private void wrapperRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flowerGroupBox.Enabled = false;
            wrapperGroupBox.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (flowerRadioButton.Checked)
            {
                int price = int.Parse(flowerPriceTextBox.Text);
                String color = flowerColorTextBox.Text;
                switch (flowerNameComboBox.SelectedIndex)
                {
                    case 0:
                        flower = flowerFactory.CreateRose(color, price);
                        break;
                    case 1:
                        flower = flowerFactory.CreateTulpin(color, price);
                        break;
                    case 2:
                        flower = flowerFactory.CreateGladiolus(color, price);
                        break;
                    case 3:
                        flower = flowerFactory.CreateIris(color, price);
                        break;
                }
                DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else if (wrapperRadioButton.Checked)
            {
                int price = int.Parse(wrapperPriceTextBox.Text);
                String material = wrapperMaterialTextBox.Text;
                wrapper = wrapperFactory.CreateWrapper(material, price);
                DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }
    }
}
