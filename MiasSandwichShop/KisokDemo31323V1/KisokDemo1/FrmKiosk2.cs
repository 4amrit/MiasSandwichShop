using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisokDemo1
{
    public partial class FrmKiosk2 : Form
    {
        //Product sandwich, sandwich1;
        Cart cart;
        CSVFileReader myCSVReader;
        List<Product> sandwiches;
        List<Toppings> toppings;

        BindingSource cartBindingSource;
        public FrmKiosk2()
        {
            InitializeComponent();

            //Initialise cheese snadwich
            //sandwich = new Product(1, "Cheese Sandwich", 2.99m);
            //sandwich1 = new Product(1, "triple Cheese Sandwich", 2.99m);
            //sandwich.image = Image.FromFile("CheeseSandwich.jfif");

            cart = new Cart();

            //Setup cart binding
            cartBindingSource = new BindingSource();
            cartBindingSource.DataSource = cart.GetAllProducts();

            lstBCart.DataSource = cartBindingSource;
            lstBCart.DisplayMember = ToString();

            myCSVReader = new CSVFileReader("sandwiches.txt");

            sandwiches = myCSVReader.GetAllProducts();

            myCSVReader = new CSVFileReader("toppings.txt");

            toppings = myCSVReader.GetAllProducts().ConvertAll(s => (Toppings)s);
        }

        private void FrmKiosk2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sandwiches.Count; i++)
            {
                Product product = sandwiches[i];
                if (this.Sandwiches.Controls.Count <= i) break;
                Control container = this.Sandwiches.Controls[i];
                container.Text = product.name;
                foreach (Control child in container.Controls)
                {
                    if (child is Button)
                    {
                        ((Button)child).Image = product.image;
                        child.Click += (o2, e2) => AddToCart(product);
                    }
                    if (child is TextBox)
                    {
                        if (((TextBox)child).Multiline)
                        {
                            ((TextBox)child).Text = product.name+ "\r\n£" + product.price;
                            child.Enabled = false;
                        }
                    }
                }
            }
        }
        private void AddToCart(Product product)
        {
            if (MessageBox.Show(product.name, "Would you like to modify this sandwich?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CustomiseSandwich form = new CustomiseSandwich(product, this.toppings);
                this.Hide();
                form.Show();
                form.FormClosing += (s, e) => {
                    this.Show();
                    cart.AddToCart(form.CreateExport());
                    cartBindingSource.ResetBindings(false);
                    lblTotal.Text = "Total: " + cart.Total().ToString();
                };
            }
            else
            {
                cart.AddToCart(product);
                cartBindingSource.ResetBindings(false);
                lblTotal.Text = "Total: " + cart.Total().ToString();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            cart.RemoveFromCart((Product)lstBCart.SelectedItem);
            cartBindingSource.ResetBindings(false);
            lblTotal.Text = "Total: " + cart.Total().ToString();
        }
        private void Sandwiches_Click(object sender, EventArgs e)
        {

        }
        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("order.txt", cart.GetOrder());
            MessageBox.Show("Done!");
            Application.Restart();
        }
    }
}
