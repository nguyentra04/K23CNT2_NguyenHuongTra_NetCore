using Microsoft.AspNetCore.Mvc;
using NHTLesson04.Models;

namespace NHTLesson04.Controllers
{
    public class NHTBookController : Controller
    {
        private List<NHTBook> nhtBooks = new List<NHTBook>
        {
            new NHTBook { NHTId = "B001", NHTTitle = "The Silent World", NHTDes = "A journey into the quiet corners of the Earth.", NHTImage = "Image/nhtbook-1.jpg", NHTPrice = 25.99f, NHTPage = 320 },
            new NHTBook { NHTId = "B002", NHTTitle = "Journey Beyond", NHTDes = "Explore the universe and your imagination.", NHTImage = "Image/nhtbook-2.jpg", NHTPrice = 30.50f, NHTPage = 285 },
            new NHTBook { NHTId = "B003", NHTTitle = "C# Mastery", NHTDes = "Master the art of C# programming.", NHTImage = "Image/nhtbook-3.jpg", NHTPrice = 42.75f, NHTPage = 410 },
            new NHTBook { NHTId = "B004", NHTTitle = "The Code Whisperer", NHTDes = "Improve your coding intuition.", NHTImage = "Image/nhtbook-4.jpg", NHTPrice = 35.00f, NHTPage = 370 },
            new NHTBook { NHTId = "B005", NHTTitle = "Dreaming Data", NHTDes = "Data analysis from basics to advanced.", NHTImage = "Image/nhtbook-5.jpg", NHTPrice = 27.45f, NHTPage = 330 },
            new NHTBook { NHTId = "B006", NHTTitle = "Design Patterns", NHTDes = "Timeless solutions to common problems.", NHTImage = "Image/nhtbook-6.jpg", NHTPrice = 50.00f, NHTPage = 450 },
            new NHTBook { NHTId = "B007", NHTTitle = "Algorithms Unlocked", NHTDes = "An introduction to algorithms and their uses.", NHTImage = "Image/nhtbook-7.jpg", NHTPrice = 33.20f, NHTPage = 380 },
            new NHTBook { NHTId = "B008", NHTTitle = "Blazor in Action", NHTDes = "Create interactive web UIs using C#.", NHTImage = "Image/nhtbook-8.jpg", NHTPrice = 39.99f, NHTPage = 350 },
            new NHTBook { NHTId = "B009", NHTTitle = "ASP.NET Core Deep Dive", NHTDes = "Advanced ASP.NET Core concepts.", NHTImage = "Image/nhtbook-9.jpg", NHTPrice = 45.50f, NHTPage = 400 },
            new NHTBook { NHTId = "B010", NHTTitle = "Entity Framework Secrets", NHTDes = "Master data access with EF Core.", NHTImage = "Image/nhtbook-10.jpg", NHTPrice = 28.95f, NHTPage = 290 },
            new NHTBook { NHTId = "B011", NHTTitle = "Clean Architecture", NHTDes = "Build maintainable and scalable systems.", NHTImage = "Image/nhtbook-11.jpg", NHTPrice = 44.00f, NHTPage = 360 },
            new NHTBook { NHTId = "B012", NHTTitle = "Domain-Driven Design", NHTDes = "Modeling complex software systems effectively.", NHTImage = "Image/nhtbook-12.jpg", NHTPrice = 41.25f, NHTPage = 430 },
            new NHTBook { NHTId = "B013", NHTTitle = "Modern UI with MAUI", NHTDes = "Cross-platform apps with .NET MAUI.", NHTImage = "Image/nhtbook-13.jpg", NHTPrice = 38.75f, NHTPage = 340 },
            new NHTBook { NHTId = "B014", NHTTitle = "Pro LINQ", NHTDes = "Powerful data querying with LINQ.", NHTImage = "Image/nhtbook-14.jpg", NHTPrice = 29.90f, NHTPage = 305 },
            new NHTBook { NHTId = "B015", NHTTitle = "The Art of Unit Testing", NHTDes = "Write reliable and maintainable tests.", NHTImage = "Image/nhtbook-15.jpg", NHTPrice = 37.20f, NHTPage = 310 },
            new NHTBook { NHTId = "B016", NHTTitle = "Software Craftsmanship", NHTDes = "Be a professional software developer.", NHTImage = "Image/nhtbook-16.jpg", NHTPrice = 32.45f, NHTPage = 275 },
            new NHTBook { NHTId = "B017", NHTTitle = "Agile Principles Explained", NHTDes = "Understand Agile with clarity.", NHTImage = "Image/nhtbook-17.jpg", NHTPrice = 26.99f, NHTPage = 260 },
            new NHTBook { NHTId = "B018", NHTTitle = "Learning Microservices", NHTDes = "Architect your app into services.", NHTImage = "Image/nhtbook-18.jpg", NHTPrice = 36.00f, NHTPage = 385 },
            new NHTBook { NHTId = "B019", NHTTitle = "Docker for .NET Devs", NHTDes = "Containers and Docker for C#.", NHTImage = "Image/nhtbook-19.jpg", NHTPrice = 31.10f, NHTPage = 310 },
            new NHTBook { NHTId = "B020", NHTTitle = "AI with C#", NHTDes = "Practical AI solutions in C#.", NHTImage = "Image/nhtbook-20.jpg", NHTPrice = 46.99f, NHTPage = 370 },
            new NHTBook { NHTId = "B021", NHTTitle = "Neural Networks in Practice", NHTDes = "Deep learning with real-world projects.", NHTImage = "Image/nhtbook-21.jpg", NHTPrice = 48.50f, NHTPage = 450 },
            new NHTBook { NHTId = "B022", NHTTitle = "Refactoring Guru", NHTDes = "Improve existing code with confidence.", NHTImage = "Image/nhtbook-22.jpg", NHTPrice = 34.95f, NHTPage = 310 },
            new NHTBook { NHTId = "B023", NHTTitle = "Test-Driven C#", NHTDes = "Develop with tests first.", NHTImage = "Image/nhtbook-23.jpg", NHTPrice = 36.75f, NHTPage = 325 },
            new NHTBook { NHTId = "B024", NHTTitle = "Effective C#", NHTDes = "Best practices for modern C#.", NHTImage = "Image/nhtbook-24.jpg", NHTPrice = 40.10f, NHTPage = 360 },
            new NHTBook { NHTId = "B025", NHTTitle = "Concurrency in .NET", NHTDes = "Multithreading and async made easy.", NHTImage = "Image/nhtbook-25.jpg", NHTPrice = 43.90f, NHTPage = 370 },
            new NHTBook { NHTId = "B026", NHTTitle = "Pro REST API Development", NHTDes = "Build scalable REST APIs.", NHTImage = "Image/nhtbook-26.jpg", NHTPrice = 33.60f, NHTPage = 340 },
            new NHTBook { NHTId = "B027", NHTTitle = "ASP.NET MVC in Depth", NHTDes = "Complete guide to ASP.NET MVC.", NHTImage = "Image/nhtbook-27.jpg", NHTPrice = 39.80f, NHTPage = 380 },
            new NHTBook { NHTId = "B028", NHTTitle = "The Pragmatic Programmer", NHTDes = "Journey to mastery in software development.", NHTImage = "Image/nhtbook-28.jpg", NHTPrice = 41.75f, NHTPage = 320 },
            new NHTBook { NHTId = "B029", NHTTitle = "Head First C#", NHTDes = "Fun and engaging introduction to C#.", NHTImage = "Image/nhtbook-29.jpg", NHTPrice = 35.50f, NHTPage = 310 },
            new NHTBook { NHTId = "B030", NHTTitle = "Professional Xamarin", NHTDes = "Develop cross-platform mobile apps.", NHTImage = "Image/nhtbook-30.jpg", NHTPrice = 38.40f, NHTPage = 330 },
            new NHTBook { NHTId = "B031", NHTTitle = "LINQ Pocket Reference", NHTDes = "Quick syntax and usage guide.", NHTImage = "Image/nhtbook-31.jpg", NHTPrice = 20.00f, NHTPage = 150 },
            new NHTBook { NHTId = "B032", NHTTitle = "C# in Depth", NHTDes = "Detailed exploration of C# language features.", NHTImage = "Image/nhtbook-32.jpg", NHTPrice = 45.60f, NHTPage = 420 },
            new NHTBook { NHTId = "B033", NHTTitle = "Pro Entity Framework Core", NHTDes = "Data access with EF Core.", NHTImage = "Image/nhtbook-33.jpg", NHTPrice = 39.99f, NHTPage = 365 },
            new NHTBook { NHTId = "B034", NHTTitle = "Effective Unit Testing", NHTDes = "Write better unit tests.", NHTImage = "Image/nhtbook-34.jpg", NHTPrice = 27.95f, NHTPage = 280 },
            new NHTBook { NHTId = "B035", NHTTitle = "Practical Machine Learning", NHTDes = "Implement ML algorithms with C#.", NHTImage = "Image/nhtbook-35.jpg", NHTPrice = 47.00f, NHTPage = 410 },
            new NHTBook { NHTId = "B036", NHTTitle = "Clean Code", NHTDes = "A Handbook of Agile Software Craftsmanship.", NHTImage = "Image/nhtbook-36.jpg", NHTPrice = 42.99f, NHTPage = 464 },
            new NHTBook { NHTId = "B037", NHTTitle = "Mastering Blazor", NHTDes = "Build interactive web apps with Blazor.", NHTImage = "Image/nhtbook-37.jpg", NHTPrice = 38.50f, NHTPage = 350 },
            new NHTBook { NHTId = "B038", NHTTitle = "Microservices Patterns", NHTDes = "Designing and managing microservices.", NHTImage = "Image/nhtbook-38.jpg", NHTPrice = 44.20f, NHTPage = 420 },
            new NHTBook { NHTId = "B039", NHTTitle = "C# 11 Cookbook", NHTDes = "Recipes for modern C# programming.", NHTImage = "Image/nhtbook-39.jpg", NHTPrice = 36.90f, NHTPage = 340 },
            new NHTBook { NHTId = "B040", NHTTitle = "ASP.NET Core in Action", NHTDes = "Comprehensive guide to ASP.NET Core.", NHTImage = "Image/nhtbook-40.jpg", NHTPrice = 45.00f, NHTPage = 400 },
            new NHTBook { NHTId = "B041", NHTTitle = "Introduction to Docker", NHTDes = "Containers for modern apps.", NHTImage = "Image/nhtbook-41.jpg", NHTPrice = 29.95f, NHTPage = 300 },
            new NHTBook { NHTId = "B042", NHTTitle = "Kafka for Developers", NHTDes = "Real-time data streaming.", NHTImage = "Image/nhtbook-42.jpg", NHTPrice = 39.50f, NHTPage = 350 },
            new NHTBook { NHTId = "B043", NHTTitle = "Kubernetes Basics", NHTDes = "Orchestrate your containers.", NHTImage = "Image/nhtbook-43.jpg", NHTPrice = 43.00f, NHTPage = 375 },
            new NHTBook { NHTId = "B044", NHTTitle = "Azure DevOps Essentials", NHTDes = "CI/CD for modern apps.", NHTImage = "Image/nhtbook-44.jpg", NHTPrice = 37.99f, NHTPage = 320 },
            new NHTBook { NHTId = "B045", NHTTitle = "Cloud Native C#", NHTDes = "Build cloud-ready .NET apps.", NHTImage = "Image/nhtbook-45.jpg", NHTPrice = 41.50f, NHTPage = 380 },
            new NHTBook { NHTId = "B046", NHTTitle = "SQL Server Fundamentals", NHTDes = "Database essentials for developers.", NHTImage = "Image/nhtbook-46.jpg", NHTPrice = 30.00f, NHTPage = 280 },
            new NHTBook { NHTId = "B047", NHTTitle = "React with C#", NHTDes = "Frontend with Blazor and React.", NHTImage = "Image/nhtbook-47.jpg", NHTPrice = 35.80f, NHTPage = 330 },
            new NHTBook { NHTId = "B048", NHTTitle = "SignalR in Depth", NHTDes = "Real-time web apps with SignalR.", NHTImage = "Image/nhtbook-48.jpg", NHTPrice = 34.25f, NHTPage = 310 },
            new NHTBook { NHTId = "B049", NHTTitle = "XUnit Testing Guide", NHTDes = "Unit testing with xUnit framework.", NHTImage = "Image/nhtbook-49.jpg", NHTPrice = 29.99f, NHTPage = 290 },
            new NHTBook { NHTId = "B050", NHTTitle = "Security Best Practices", NHTDes = "Protect your .NET applications.", NHTImage = "Image/nhtbook-50.jpg", NHTPrice = 38.00f, NHTPage = 360 },
            new NHTBook { NHTId = "B051", NHTTitle = "Performance Tuning .NET", NHTDes = "Optimize your .NET apps.", NHTImage = "Image/nhtbook-51.jpg", NHTPrice = 42.00f, NHTPage = 400 },
            new NHTBook { NHTId = "B052", NHTTitle = "DevOps for .NET", NHTDes = "Integrate DevOps in .NET projects.", NHTImage = "Image/nhtbook-52.jpg", NHTPrice = 39.50f, NHTPage = 350 },
            new NHTBook { NHTId = "B053", NHTTitle = "Cloud Architecture Patterns", NHTDes = "Design resilient cloud apps.", NHTImage = "Image/nhtbook-53.jpg", NHTPrice = 44.99f, NHTPage = 420 },
            new NHTBook { NHTId = "B054", NHTTitle = "Effective Debugging", NHTDes = "Strategies to debug faster and better.", NHTImage = "Image/nhtbook-54.jpg", NHTPrice = 28.99f, NHTPage = 270 },
            new NHTBook { NHTId = "B055", NHTTitle = "Clean Code", NHTDes = "A Handbook of Agile Software Craftsmanship.", NHTImage = "Image/nhtbook-55.jpg", NHTPrice = 42.99f, NHTPage = 464 }
        };

        // GET: nhtbook/nhtindex - lấy tất cả các cuốn sách
        public IActionResult NHTIndex()
        {
            return View(nhtBooks);
        }
        // GET: NHTCreate - Hiển thị form tạo sách mới
        public IActionResult NHTCreate()
        {
            return View();
        }

        // POST: NHTCreatesubmit - Nhận dữ liệu tạo sách mới từ form
        [HttpPost]
        public IActionResult NHTCreatesubmit(NHTBook nhtbook)
        {
            if (ModelState.IsValid)
            {
                nhtBooks.Add(nhtbook);
                return RedirectToAction("NHTIndex");
            }
            return View("NHTCreate", nhtbook);
        }

        // GET: NHTEdit/{id} - Hiển thị form sửa sách theo id
        public IActionResult NHTEdit(string id)
        {
            var nhtbook = nhtBooks.FirstOrDefault(b => b.NHTId == id);
            if (nhtbook == null)
            {
                return NotFound();
            }
            return View(nhtbook);
        }

        // POST: NHTEditSubmit - Nhận dữ liệu sửa sách

        public IActionResult NHTEditSubmit(NHTBook nhtbook)
        {
            if (ModelState.IsValid)
            {
                var existingBook = nhtBooks.FirstOrDefault(b => b.NHTId == nhtbook.NHTId);
                if (existingBook != null)
                {
                    existingBook.NHTTitle = nhtbook.NHTTitle;
                    existingBook.NHTDes = nhtbook.NHTDes;
                    existingBook.NHTImage = nhtbook.NHTImage;
                    existingBook.NHTPrice = nhtbook.NHTPrice;
                    existingBook.NHTPage = nhtbook.NHTPage;
                }
                return RedirectToAction("NHTIndex");
            }
            return View("NHTEdit", nhtbook);
        }
    }
}
