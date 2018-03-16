using System;
using Ooui;
using WebForms.Pages;
using Xamarin.Forms;

namespace WebForms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Xamarin.Forms
            Forms.Init();

            // Publish a root element to be displayed
            UI.Publish("/", new HomePage().GetOouiElement());
        }
    }
}