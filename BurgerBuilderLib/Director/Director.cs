using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BurgerBuilderLib.Builders;

namespace BurgerBuilderLib.Director
{
    public class Director
    {
        public void MakeHamburger(IBuilder builder, string pathFileMeat, string pathFileBuns, string pathFileVegetables, string pathFileCondiments, string pathFileBurger)
        {
            builder.Reset()
                .FryMeat(pathFileMeat)
                .HeatUpBuns(pathFileBuns)
                .CutVegetables(pathFileVegetables)
                .AddCondiments(pathFileCondiments)
                .TogetherUpBurger(pathFileBurger);
        }

        public void MakeMcChicken(IBuilder builder, string pathFileMeat, string pathFileBuns, string pathFileVegetables, string pathFileCondiments, string pathFileBurger)
        {
            builder.Reset()
                .FryMeat(pathFileMeat)
                .HeatUpBuns(pathFileBuns)
                .CutVegetables(pathFileVegetables)
                .AddCondiments(pathFileCondiments)
                .TogetherUpBurger(pathFileBurger);
        }

        public void MakeFiletOFish(IBuilder builder, string pathFileFish, string pathFileBuns, string pathFileVegetables, string pathFileCondiments, string pathFileBurger)
        {
            builder.Reset()
                .FryMeat(pathFileFish)
                .HeatUpBuns(pathFileBuns)
                .CutVegetables(pathFileVegetables)
                .AddCondiments(pathFileCondiments)
                .TogetherUpBurger(pathFileBurger);
        }
    }
}
