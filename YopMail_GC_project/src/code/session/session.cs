using OpenQA.Selenium;
using SeleniumTraining.src.code.factoryBrowser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.session
{
    public class Session
    {
        //atributo del mismo tipo
        private static Session instance = null;
        private IWebDriver browser;
        
        //constructor privado
        private Session() {
            browser = FactoryBrowser.Make("chrome").Create();     //aqui cambias el tipo de navegador
        }

        //metodo estatico publico para su acceso global
        public static Session Instance() { 
        
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }
        public void CloseBrowser ()
        {
            instance = null; //al cerrar la sesion se destruye el sigleton
            browser.Quit();
        }

        public IWebDriver GetBrowser() 
        {
            return browser;
        }

    }
}
