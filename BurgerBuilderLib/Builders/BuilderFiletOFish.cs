using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerBuilderLib.Products;

namespace BurgerBuilderLib.Builders
{
    public class BuilderFiletOFish : IBuilder
    {
        FiletOFish filetOFish;

        public IBuilder Reset() { filetOFish = new FiletOFish(); return this; }
        public IBuilder FryMeat(string pathFile) { filetOFish.fish = new Bitmap(pathFile); return this; }
        public IBuilder HeatUpBuns(string pathFile) { filetOFish.buns = new Bitmap(pathFile); return this; }
        public IBuilder CutVegetables(string pathFile) { filetOFish.vegetables = new Bitmap(pathFile); return this; }
        public IBuilder AddCondiments(string pathFile) { filetOFish.condiments = new Bitmap(pathFile); return this; }
        public IBuilder TogetherUpBurger(string pathFile) { filetOFish.result = new Bitmap(pathFile); return this; }
        public FiletOFish GetResult() { return filetOFish; }
    }
}
