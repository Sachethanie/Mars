using OpenQA.Selenium;
using ProjectMars.Helpers;
using ProjectMars.Models;
using ProjectMars.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMars.Pages
{
    public class AboutMeProfilePage : Driver
    {
        private static IWebElement NameDropdownButton => driver.FindElement(By.XPath("//div[@id='account-profile-section']//div[@class='title']//i[@class='dropdown icon']"));
        private static IWebElement FirstNameButton => driver.FindElement(By.XPath("//input[@type='text' and @name='firstName']"));
        private static IWebElement LastNameButton => driver.FindElement(By.XPath("//input[@type='text' and @name='lastName']"));
        private static IWebElement SaveButton => driver.FindElement(By.XPath("//button[@class='ui teal button']"));

        public static string FirstName = "//input[@type='text' and @name='firstName']";

        public void ViewProfileName(AboutMeProfile profileName)
        {
            var firstNameRaw = driver.FindElement(By.XPath($"//input[@type='text' and @name='firstName' and @value='{profileName.FirstName}']"));
            var lastNameRaw = driver.FindElement(By.XPath($"//input[@type='text' and @name='lastName' and @value='{profileName.LastName}']"));
            Assert.That(firstNameRaw, Is.Not.Null, "$FirstName {firstName} was not found in the list");
            Assert.That(lastNameRaw, Is.Not.Null, "$LastName {lastName} was not found in the list");
        }


        public void SuccessfullyEditProfileName(AboutMeProfile editProfileName)
        {
            NameDropdownButton.Click();
            Thread.Sleep(1000);
            FirstNameButton.Clear();
            FirstNameButton.SendKeys(editProfileName.FirstName);
            LastNameButton.Clear();
            LastNameButton.SendKeys(editProfileName.LastName);
            SaveButton.Click();

        }

        public void CannotBeAbleToEditProfileNameWithoutAddingFirstName(AboutMeProfile editProfileName)
        { NameDropdownButton.Click();
        Thread.Sleep(1000);
        FirstNameButton.Clear();
        SaveButton.Click();
        }


        

    }
}
