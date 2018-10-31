using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStore
{
    public partial class Form1 : Form
    {
        BindingList<Phone> phone;
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phone = new BindingList<Phone>()
            {
                new Phone() {Model = "Iphone" , System = "Ios", SystemUpdate = "10.2.3" , Price = 650 },
                new Phone() {Model = "Samsung" , System = "Android", SystemUpdate = "7.1" , Price = 600 },
                new Phone() {Model = "Nokia" , System = "WindowsPhone", SystemUpdate = "2.7" , Price = 500 },
                new Phone() {Model = "OnePlus" , System = "Android", SystemUpdate = "7.2" , Price = 380 },
            };

            teleponeInfoBox.DataSource = phone;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (teleponeInfoBox.SelectedItem != null)
            {
                Phone delPhone = (Phone)teleponeInfoBox.SelectedItem;
                phone.Remove(delPhone);
            }
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            while (teleponeInfoBox.SelectedItem != null)
            {
                Phone delPhone = (Phone)teleponeInfoBox.SelectedItem;
                phone.Remove(delPhone);
            }
        }
    }
}
