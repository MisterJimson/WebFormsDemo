using System;
using System.Collections.Generic;
using System.Text;

namespace WebForms.ViewModels
{
    public class HomeViewModel
    {
        public string WelcomeMessage = "test";

        public HomeViewModel()
        {
            WelcomeMessage = "Welcome!";
        }
    }
}
