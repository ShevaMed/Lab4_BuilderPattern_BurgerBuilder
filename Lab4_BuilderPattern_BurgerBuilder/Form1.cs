using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurgerBuilderLib.Builders;
using BurgerBuilderLib.Products;
using BurgerBuilderLib.Director;

namespace Lab4_BuilderPattern_BurgerBuilder
{
    public partial class Form1 : Form
    {
        Director director = new Director();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuilderHamburger builderHamburger = new BuilderHamburger();

            director.MakeHamburger(builderHamburger, "..\\..\\images\\meatHamburger.jpg", "..\\..\\images\\bunsHamburger.jpg",
               "..\\..\\images\\vegetablesHamburger.jpg", "..\\..\\images\\condimentsHamburger.jpg", "..\\..\\images\\hamburger.jpg");

            Hamburger hamburger = builderHamburger.GetResult();

            pictureBox1.Image = hamburger.meat;
            pictureBox2.Image = hamburger.buns;
            pictureBox3.Image = hamburger.vegetables;
            pictureBox4.Image = hamburger.condiments;
            pictureBox5.Image = hamburger.result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuilderMcChicken builderMcChicken = new BuilderMcChicken();

            director.MakeMcChicken(builderMcChicken, @"..\..\images\meatMcChicken.jpg", @"..\..\images\bunsHamburger.jpg",
                @"..\..\images\vegetablesMcChicken.jpg", @"..\..\images\condimentsMcChicken.jpg", @"..\..\images\mcChicken.jpg");

            McChicken mcChicken = builderMcChicken.GetResult();

            pictureBox1.Image = mcChicken.meat;
            pictureBox2.Image = mcChicken.buns;
            pictureBox3.Image = mcChicken.vegetables;
            pictureBox4.Image = mcChicken.condiments;
            pictureBox5.Image = mcChicken.result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuilderFiletOFish builderFiletOFish = new BuilderFiletOFish();

            director.MakeFiletOFish(builderFiletOFish, @"..\..\images\fishFiletOFish.jfif", @"..\..\images\bunsHamburger.jpg",
                @"..\..\images\vegetablesFiletOFish.jpg", @"..\..\images\condimentsFiletOFish.jpg", @"..\..\images\fileOFish.jpg");

            FiletOFish filetOFish = builderFiletOFish.GetResult();

            pictureBox1.Image = filetOFish.fish;
            pictureBox2.Image = filetOFish.buns;
            pictureBox3.Image = filetOFish.vegetables;
            pictureBox4.Image = filetOFish.condiments;
            pictureBox5.Image = filetOFish.result;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
