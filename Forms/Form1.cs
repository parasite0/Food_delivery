using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodClass;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Food GetModelFromUI()
        {
            return new Food()
            {
                Filled = dateTimePicker1.Value,
                Dishes = listBox1.Items.OfType<DishesType>().ToList(),
                Price = numericUpDown1.Value
            };
        }
        private void abc_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dish = listBox1.SelectedItem as DishesType;
            if (dish == null)
                return;
            var form = new Form2(dish.Clone());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                var si = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(si);
                listBox1.Items.Insert(si, form.dish);
            }
        }
        private void RecalculatePrice()
        {
            var dto = GetModelFromUI();
            decimal price = 0;

            foreach (var e in dto.Dishes)
            {
                switch (e.Menu)
                {
                    case DishesMenu.Pizza:
                        price += 400;
                        break;
                    case DishesMenu.Sushi:
                        price += 150;
                        break;
                    case DishesMenu.Borscht:
                        price += 200;
                        break;
                    case DishesMenu.Barbecue:
                        price += 250;
                        break;
                    case DishesMenu.Chicken:
                        price += 100;
                        break;
                    case DishesMenu.Salad:
                        price += 120;
                        break;
                    case DishesMenu.Kebab:
                        price += 140;
                        break;
                    case DishesMenu.Nuggets:
                        price += 110;
                        break;
                    case DishesMenu.Humburger:
                        price += 90;
                        break;
                    case DishesMenu.Potatoes:
                        price += 70;
                        break;
                }
            }
            numericUpDown1.Value = price;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form2(new DishesType());
            var res = form.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                listBox1.Items.Add(form.dish);
                RecalculatePrice();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var si = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(si);
            RecalculatePrice();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
