using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerBuilderLib.Products;

namespace BurgerBuilderLib.Builders
{
    public class BuilderMcChicken : IBuilder
    {
        McChicken mcChicken;

        public IBuilder Reset() { mcChicken = new McChicken(); return this; }
        public IBuilder FryMeat(string pathFile) { mcChicken.meat = new Bitmap(pathFile); return this; }
        public IBuilder HeatUpBuns(string pathFile) { mcChicken.buns = new Bitmap(pathFile); return this; }
        public IBuilder CutVegetables(string pathFile) { mcChicken.vegetables = new Bitmap(pathFile); return this; }
        public IBuilder AddCondiments(string pathFile) { mcChicken.condiments = new Bitmap(pathFile); return this; }
        public IBuilder TogetherUpBurger(string pathFile) { mcChicken.result = new Bitmap(pathFile); return this; }
        public McChicken GetResult() { return mcChicken; }
    }
}
