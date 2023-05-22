using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTraining.src.code.factoryBrowser;
using SeleniumTraining.src.code.page;
using SeleniumTraining.src.code.session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class SendMailAndVerify : TestBase
    {
        
        CreateMailSection CreateMailSection = new CreateMailSection();
        InboxSection InboxSection = new InboxSection();

        [TestMethod]
        public void CreateAndVerifyMail()
        {

            CreateMailSection.Login("gabrielC");
            
            //send a new message

            InboxSection.NewMessageButton.Click();

            InboxSection.Switchframe("ifmail");
            
            InboxSection.ToTextBox.SetText("gabrielC@yopmail.com");
            InboxSection.SubjectTextbox.SetText("test");
            InboxSection.BodyTextbox.SetText("This is a test message for Mojix projects");
            InboxSection.SendButton.Click();

            //assert of the sent message

            Assert.IsTrue(InboxSection.ReadConfirmation("Tu mensaje ha sido enviado"), "Error, message was not created");


            //verify the message
            Session.Instance().GetBrowser().SwitchTo().DefaultContent();
            InboxSection.RefreshButton.Click();
            

            InboxSection.Switchframe("ifinbox");
            InboxSection.OpenMessage.Click();


            //assert 
            Session.Instance().GetBrowser().SwitchTo().DefaultContent();
            InboxSection.Switchframe("ifmail");
            Assert.IsTrue(InboxSection.ReadConfirmation("This is a test message for Mojix projects"), "Error, message was not in inbox");
            Thread.Sleep(1000);
            
          




        }
    }
}

