using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace BurgerBuilderLib
{
    public class Director
    {
        public void MakeHamburger(Builder builder, string pathFileMeat, string pathFileBuns, string pathFileVegetables, string pathFileCondiments, string pathFileBurger)
        {
            builder.Reset();
            builder.FryMeat(pathFileMeat);
            builder.HeatUpBuns(pathFileBuns);
            builder.CutVegetables(pathFileVegetables);
            builder.AddCondiments(pathFileCondiments);
            builder.TogetherUpBurger(pathFileBurger);
        }

        public void MakeMcChicken(Builder builder, string pathFileMeat, string pathFileBuns, string pathFileVegetables, string pathFileCondiments, string pathFileBurger)
        {
            builder.Reset();
            builder.FryMeat(pathFileMeat);
            builder.HeatUpBuns(pathFileBuns);
            builder.CutVegetables(pathFileVegetables);
            builder.AddCondiments(pathFileCondiments);
            builder.TogetherUpBurger(pathFileBurger);
        }

        public void MakeFiletOFish(Builder builder, string pathFileFish, string pathFileBuns, string pathFileVegetables, string pathFileCondiments, string pathFileBurger)
        {
            builder.Reset();
            builder.FryMeat(pathFileFish);
            builder.HeatUpBuns(pathFileBuns);
            builder.CutVegetables(pathFileVegetables);
            builder.AddCondiments(pathFileCondiments);
            builder.TogetherUpBurger(pathFileBurger);
        }
    }
}
