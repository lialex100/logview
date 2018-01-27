using System;
using System.Collections.Generic;

using System.IO;
using System.Collections;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace logview.Controllers
{
    [Route("api/[controller]")]
    public class LogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[action]")]
        public List<LogFile> ShowFiles()
        {
            string[] fileEntries = Directory.GetFileSystemEntries("./");

            var result = new List<LogFile>();

            foreach (string fileName in fileEntries)
            {
                result.Add(new LogFile() { Name = fileName });
            }

            return result;

        }

        public class LogFile
        {
            public string Name;
            public string Size;


        }
    }

}
