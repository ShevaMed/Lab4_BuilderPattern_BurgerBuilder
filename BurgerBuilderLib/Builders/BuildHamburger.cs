using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerBuilderLib.Products;

namespace BurgerBuilderLib.Builders
{
    public class BuilderHamburger : IBuilder
    {
        Hamburger hamburger;

        public IBuilder Reset() { hamburger = new Hamburger(); return this; }
        public IBuilder FryMeat(string pathFile) { hamburger.meat = new Bitmap(pathFile); return this; }
        public IBuilder HeatUpBuns(string pathFile) { hamburger.buns = new Bitmap(pathFile); return this; }
        public IBuilder CutVegetables(string pathFile) { hamburger.vegetables = new Bitmap(pathFile); return this; }
        public IBuilder AddCondiments(string pathFile) { hamburger.condiments = new Bitmap(pathFile); return this; }
        public IBuilder TogetherUpBurger(string pathFile) { hamburger.result = new Bitmap(pathFile); return this; }
        public Hamburger GetResult() { return hamburger; }
    }
}
