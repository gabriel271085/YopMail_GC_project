using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class CreateMailSection
    {
        public TextBox newemailtextbox = new TextBox(By.Id("login"));
        public Button enterbutton = new Button(By.XPath("//button[@class=\"md\"]"));

        public void Login(String user) 
        {
            newemailtextbox.SetText(user);
            enterbutton.Click();
        }
    }
}
