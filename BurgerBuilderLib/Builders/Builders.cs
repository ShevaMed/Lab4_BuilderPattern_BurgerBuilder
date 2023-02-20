using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BurgerBuilderLib
{
    public abstract class Builder
    {
        public abstract void Reset();
        public abstract void FryMeat(string pathFile);
        public abstract void HeatUpBuns(string pathFile);
        public abstract void CutVegetables(string pathFile);
        public abstract void AddCondiments(string pathFile);
        public abstract void TogetherUpBurger(string pathFile);
    }

    public class BuilderHamburger : Builder
    {
        Hamburger hamburger;

        public override void Reset() { hamburger = new Hamburger(); }
        public override void FryMeat(string pathFile) { hamburger.meat = new Bitmap(pathFile); }
        public override void HeatUpBuns(string pathFile) { hamburger.buns = new Bitmap(pathFile); }
        public override void CutVegetables(string pathFile) { hamburger.vegetables = new Bitmap(pathFile); }
        public override void AddCondiments(string pathFile) { hamburger.condiments = new Bitmap(pathFile); }
        public override void TogetherUpBurger(string pathFile) { hamburger.result = new Bitmap(pathFile); }
        public Hamburger GetResult() { return hamburger; }
    }

    public class BuilderMcChicken : Builder
    {
        McChicken mcChicken;

        public override void Reset() { mcChicken = new McChicken(); }
        public override void FryMeat(string pathFile) { mcChicken.meat = new Bitmap(pathFile); }
        public override void HeatUpBuns(string pathFile) { mcChicken.buns = new Bitmap(pathFile); }
        public override void CutVegetables(string pathFile) { mcChicken.vegetables = new Bitmap(pathFile); }
        public override void AddCondiments(string pathFile) { mcChicken.condiments = new Bitmap(pathFile); }
        public override void TogetherUpBurger(string pathFile) { mcChicken.result = new Bitmap(pathFile); }
        public McChicken GetResult() { return mcChicken; }
    }

    public class BuilderFiletOFish : Builder
    {
        FiletOFish filetOFish;

        public override void Reset() { filetOFish = new FiletOFish(); }
        public override void FryMeat(string pathFile) { filetOFish.fish = new Bitmap(pathFile); }
        public override void HeatUpBuns(string pathFile) { filetOFish.buns = new Bitmap(pathFile); }
        public override void CutVegetables(string pathFile) { filetOFish.vegetables = new Bitmap(pathFile); }
        public override void AddCondiments(string pathFile) { filetOFish.condiments = new Bitmap(pathFile); }
        public override void TogetherUpBurger(string pathFile) { filetOFish.result = new Bitmap(pathFile); }
        public FiletOFish GetResult() { return filetOFish; }
    }

}
