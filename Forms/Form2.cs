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
    public partial class Form2 : Form
    {
        public DishesType dish { get; set; }
        public Form2 (DishesType dish)
        {
            this.dish = dish;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            switch (dish.Menu)
            {
                case DishesMenu.Pizza:
                    radioButton1.Checked = true;
                    break;
                case DishesMenu.Sushi:
                    radioButton2.Checked = true;
                    break;
                case DishesMenu.Borscht:
                    radioButton3.Checked = true;
                    break;
                case DishesMenu.Barbecue:
                    radioButton4.Checked = true;
                    break;
                case DishesMenu.Chicken:
                    radioButton5.Checked = true;
                    break;
                case DishesMenu.Salad:
                    radioButton6.Checked = true;
                    break;
                case DishesMenu.Kebab:
                    radioButton7.Checked = true;
                    break;
                case DishesMenu.Nuggets:
                    radioButton8.Checked = true;
                    break;
                case DishesMenu.Humburger:
                    radioButton9.Checked = true;
                    break;
                case DishesMenu.Potatoes:
                    radioButton10.Checked = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                dish.Menu = DishesMenu.Pizza;
            else if (radioButton2.Checked)
                dish.Menu = DishesMenu.Sushi;
            else if (radioButton3.Checked)
                dish.Menu = DishesMenu.Borscht;
            else if (radioButton4.Checked)
                dish.Menu = DishesMenu.Barbecue;
            else if (radioButton5.Checked)
                dish.Menu = DishesMenu.Chicken;
            else if (radioButton6.Checked)
                dish.Menu = DishesMenu.Salad;
            else if (radioButton7.Checked)
                dish.Menu = DishesMenu.Kebab;
            else if (radioButton8.Checked)
                dish.Menu = DishesMenu.Nuggets;
            else if (radioButton9.Checked)
                dish.Menu = DishesMenu.Humburger;
            else if (radioButton10.Checked)
                dish.Menu = DishesMenu.Potatoes;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
