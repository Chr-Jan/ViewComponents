using ViewComponents.Models;


// This view component is responsible for generating a greeting message.
// In this step, we create a view (`Default.cshtml`) that defines the HTML structure
// for displaying the greeting message.

// GreetingViewComponent.cs

using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsExample.ViewComponents
{
    // Inherits from ViewComponent base class
    public class GreetingViewComponent : ViewComponent
    {
        // Invoke method is called when the view component is invoked/rendered
        public IViewComponentResult Invoke(string greetingMessage)
        {
            // Returns a view with the name "Default" and passes the greetingMessage
            // This is essential as it tells the ViewComponent to use the "Default.cshtml" view
            // for rendering the HTML output, providing a customizable presentation layer.
            return View("Default", greetingMessage);
        }
    }
}