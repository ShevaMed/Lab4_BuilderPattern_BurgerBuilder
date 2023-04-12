using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BurgerBuilderLib.Builders
{
    public interface IBuilder
    {
        IBuilder Reset();
        IBuilder FryMeat(string pathFile);
        IBuilder HeatUpBuns(string pathFile);
        IBuilder CutVegetables(string pathFile);
        IBuilder AddCondiments(string pathFile);
        IBuilder TogetherUpBurger(string pathFile);
    }

}
