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
    public partial class CustomiseSandwich : Form
    {
        private readonly Product product;
        private readonly List<Toppings> AvailableToppings;
        private readonly BindingSource cartBindingSource;

        private readonly List<Toppings> chosenToppings = new List<Toppings>();
        private decimal price;
        internal CustomiseSandwich(Product product, List<Toppings> AvailableToppings)
        {
            this.product = product;
            this.AvailableToppings = AvailableToppings;
            this.price = this.product.price;
            InitializeComponent();
            for (int i = 0; i < AvailableToppings.Count; i++)
            {
                Toppings topping = AvailableToppings[i];
                if (this.Toppings.Controls.Count <= i) break;
                Control container = this.Toppings.Controls[i];
                container.Text = topping.name;
                foreach (Control child in container.Controls)
                {
                    if (child is Button)
                    {
                        ((Button)child).Image = topping.image;
                        child.Click += (o2, e2) => AddToToppings(topping);
                    }
                    if (child is TextBox)
                    {
                        if (((TextBox)child).Multiline)
                        {
                            ((TextBox)child).Text = topping.name + "\r\n£" + topping.price;
                            child.Enabled = false;
                        }
                    }
                }
            }
            cartBindingSource = new BindingSource();
            cartBindingSource.DataSource = this.chosenToppings;

            lstBCart.DataSource = cartBindingSource;
            lstBCart.DisplayMember = ToString();
        }
        private void AddToToppings(Toppings topping)
        {
            chosenToppings.Add(topping);
            cartBindingSource.ResetBindings(false);
            UpdatePrice();
            lblTotal.Text = "Total: " + this.price.ToString();
        }
        public Product CreateExport()
        {
            return new CustomSandwich(this.product, this.chosenToppings, this.price);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdatePrice()
        {
            this.price = this.product.price;

            for (int i = 0; i < chosenToppings.Count; i++)
            {
                this.price += this.chosenToppings[i].price;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            chosenToppings.RemoveAt(lstBCart.SelectedIndex);
            cartBindingSource.ResetBindings(false);
            UpdatePrice();
            lblTotal.Text = "Total: " + this.price.ToString();
        }
    }
}
