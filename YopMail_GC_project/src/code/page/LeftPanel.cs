using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class LeftPanel
    {
        //message read
        public Button RefreshButton = new Button(By.Id("refresh"));
        public Button OpenMessage = new Button(By.XPath("(//div[@class=\"lms\"])[1]"));
       
        
    }
}
