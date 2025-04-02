using Microsoft.AspNetCore.Mvc;

namespace MinimalisticApi
{
    public class HomeController
    {
        [HttpGet("hello")]
        public string GetHello()
        {
            return "Hello, World!!!!!!";
        }
    }
}
