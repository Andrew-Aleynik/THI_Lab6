using LB4.Factories;
using LB4.FlowerShop;
using System;
using System.Windows.Forms;

namespace FlowerShopDesktop
{
    public partial class WrapperEditForm : Form
    {
        WrapperFactory wrapperFactory;
        public Wrapper wrapper;
        public WrapperEditForm(Wrapper wrapper)
        {
            InitializeComponent();
            this.wrapper = wrapper;

            wrapperMaterialTextBox.Text = wrapper.getMaterial();
            wrapperPriceTextBox.Text = wrapper.getPrice().ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            String material = wrapperMaterialTextBox.Text;
            int price = int.Parse(wrapperPriceTextBox.Text);
            wrapper = wrapperFactory.CreateWrapper(material, price);
            DialogResult = DialogResult.OK;
        }

        public Wrapper getEditedWrapper()
        {
            return wrapper;
        }
    }
}
