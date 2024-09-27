using OpenQA.Selenium.BiDi.Modules.Script;
using System;
using System.Diagnostics.Metrics;
using System.Security.Policy;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace EmployeementManagementAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {

        [Given(@"I have browser with OrangeHRM application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {

        }



        [When(@"I enter user name as '(.*)'")]
        public void WhenIEnterUserNameAs(string Username)
        {

        }


        [When(@"I enter password as '(.*)'")]
        public void WhenIEnterPasswordAs(string Password)
        {

        }


        [When(@"I click on LogIn")]
        public void WhenIClickOnLogIn()
        {

        }


        [Then(@"I should get access to dashboard page with '(.*)'")]
        public void ThenIShouldGetAccessToDashboardPageWith(string ExpectedText)
        {

        }
        public void ThenIShouldNotGetAccessToDashboardWithErrorAs(string ExpectedError)
        {
           
        }
    }



namespace MyNamespace
    {
        [Binding]
        public class StepDefinitions
        {
            private readonly ScenarioContext _scenarioContext;

            public StepDefinitions(ScenarioContext scenarioContext)
            {
                _scenarioContext = scenarioContext;
            }
            [Given(@"I have browser with OrangeHRM application")]
            public void GivenIHaveBrowserWithOrangeHRMApplication()
            {
                _scenarioContext.Pending();
            }

            [When(@"I enter user name as '(.*)'")]
            public void WhenIEnterUserNameAs(string admin0)
            {
                _scenarioContext.Pending();
            }

            [When(@"I enter password as '(.*)'")]
            public void WhenIEnterPasswordAs(string p0)
            {
                _scenarioContext.Pending();
            }

            [When(@"I click on LogIn")]
            public void WhenIClickOnLogIn()
            {
                _scenarioContext.Pending();
            }

            [Then(@"I should get access to dashboard page with '(.*)'")]
            public void ThenIShouldGetAccessToDashboardPageWith(string p0)
            {
                _scenarioContext.Pending();
            }
        }
    }
}
