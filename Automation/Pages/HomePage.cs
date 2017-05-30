﻿using OpenQA.Selenium;

namespace Automation
{
    public class HomePage
    {
        public static void Search(string searchInput)
        {
            var searchBar = Driver.Instance.FindElement(By.Id("search-input"));
            searchBar.SendKeys(searchInput);
            var searchButton = Driver.Instance.FindElement(By.Id("search-button"));
            searchButton.Click();
        }

        public class GoTo
        {
            public static void SignIn()
            {
                var signIn = Driver.Instance.FindElement(By.ClassName("sign-in"));
                signIn.Click();
            }

            public static void Register()
            {
                var register = Driver.Instance.FindElement(By.ClassName("register"));
                register.Click();
            }

            public static void HomePage()
            {
                var mainLogo = Driver.Instance.FindElement(By.Id("logo"));
                mainLogo.Click();
            }
        }
    }
}