using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.control
{
    public class Button : ControlSelenium  //herencia de controlSelenium
    {
        public Button(By locator) : base(locator)
        {
        }


    }
}
