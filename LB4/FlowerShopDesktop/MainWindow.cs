using System;
using System.Windows.Forms;
using LB4.Factories;
using LB4.FlowerShop;


namespace FlowerShopDesktop
{
    public partial class MainWindow : Form
    {
        public Bouquet bouquet;
        AddForm addForm;
        WrapperEditForm wrapperEditForm;
        FlowerEditForm flowerEditForm;

        public MainWindow()
        {
            InitializeComponent();

            AbstractFlowerFactory flowerFactory = new AbstractFlowerFactory();
            WrapperFactory wrapperFactory = new WrapperFactory();
            BouquetFactory bouquetFactory = new BouquetFactory();
            AbstractFlower[] flowers = new AbstractFlower[] {
                flowerFactory.CreateRose("White", 100),
                flowerFactory.CreateRose("White", 100),
                flowerFactory.CreateRose("White", 100),
                flowerFactory.CreateRose("Red", 150),
                flowerFactory.CreateRose("Red", 150),
                flowerFactory.CreateRose("Red", 150)
            };
            Wrapper wrapper = wrapperFactory.CreateWrapper("Paper", 100);
            bouquet = bouquetFactory.Create(wrapper, flowers);
            listBox.Items.Add(bouquet.getWrapper());
            foreach(AbstractFlower flower in bouquet.getComposition())
            {
                listBox.Items.Add(flower);
            }
            totalSumTextBox.Text = bouquet.getPrice().ToString();
            deleteButton.Enabled = false;
            editButton.Enabled = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is AbstractFlower)
            {
                flowerEditForm = new FlowerEditForm((AbstractFlower)listBox.SelectedItem);
                flowerEditForm.ShowDialog();
                if (flowerEditForm.DialogResult == DialogResult.OK)
                {
                    int flowerIndex = bouquet.getComposition().IndexOf((AbstractFlower)listBox.Items[listBox.SelectedIndex]);
                    bouquet.getComposition().RemoveAt(flowerIndex);
                    bouquet.getComposition().Insert(flowerIndex, flowerEditForm.getEditedFlower());
                    listBox.Items[flowerIndex + 1] = bouquet.getComposition()[flowerIndex];
                    flowerEditForm.Dispose();
                }
            }
            else if (listBox.SelectedItem is Wrapper)
            {
                wrapperEditForm = new WrapperEditForm((Wrapper)listBox.SelectedItem);
                wrapperEditForm.ShowDialog();
                if (wrapperEditForm.DialogResult == DialogResult.OK)
                {
                    bouquet.setWrapper(wrapperEditForm.getEditedWrapper());
                    listBox.Items[0] = bouquet.getWrapper();
                    wrapperEditForm.Dispose();
                }
            }
            totalSumTextBox.Text = bouquet.getPrice().ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedItem is Wrapper)
            {
                bouquet.setWrapper(new Wrapper("", 0));
            }else if(listBox.SelectedItem is AbstractFlower)
            {
                bouquet.getComposition().Remove((AbstractFlower)listBox.SelectedItem);
            }
            this.listBox.Items.Remove(this.listBox.SelectedItem);
            totalSumTextBox.Text = bouquet.getPrice().ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addForm = new AddForm();
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
            {
                if (!(addForm.flower is null))
                {
                    bouquet.addFlower(addForm.flower);
                    listBox.Items.Add(addForm.flower);
                }
                else if (!(addForm.wrapper is null))
                {
                    bouquet.setWrapper(addForm.wrapper);
                    listBox.Items[0] = addForm.wrapper;
                }
                listBox.Update();
            }
            totalSumTextBox.Text = bouquet.getPrice().ToString();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                deleteButton.Enabled = true;
                editButton.Enabled = true; 
                this.Update();
            }
            else
            {
                deleteButton.Enabled = false;
                editButton.Enabled = false;
                this.Update();
            }
            totalSumTextBox.Text = bouquet.getPrice().ToString();
        }
    }
}
