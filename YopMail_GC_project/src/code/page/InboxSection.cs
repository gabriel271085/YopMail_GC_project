using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class InboxSection
    {
        //creacion del mensaje
        public Button NewMessageButton = new Button(By.XPath("//button[@onclick=\"newm();\"]"));
        public TextBox ToTextBox = new TextBox(By.XPath("//input[@id=\"msgto\"]"));
        public TextBox SubjectTextbox = new TextBox(By.XPath("//input[@id=\"msgsubject\"]"));
        public TextBox BodyTextbox = new TextBox(By.XPath("//div[@id=\"msgbody\"]"));
        public Button SendButton = new Button(By.XPath("//button[@id=\"msgsend\"]"));

        //verificacion del mensaje
        public Button RefreshButton = new Button(By.XPath("//button[@id='refresh']"));
        public Button OpenMessage = new Button(By.XPath("(//div[@class=\"lms\"])[1]"));

        public void Switchframe(String iframeName)
        {
            session.Session.Instance().GetBrowser().SwitchTo().Frame(iframeName);
        }

        public Boolean ReadConfirmation(String message) 
        {
        Label messageConfirmation = new Label(By.XPath(" //div[text()='"+ message +"']"));
        return messageConfirmation.IsControlDisplayed();
        }

       
    }
}
