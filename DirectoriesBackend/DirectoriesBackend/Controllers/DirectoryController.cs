using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoriesBackend.Controllers
{
    [ApiController]
    [Route("/directory")]
    public class DirectoryController : Controller
    {
        [HttpGet]
        public IActionResult HealthCheck()
        {
            return Ok();
        }

        [HttpGet]
        [Route("/info")]
        public IActionResult GetDirectoryInfo(string directory)
        {
            try
            {
                var dirInfo = new DirectoryInfo(directory);
                var directoryInfo = "";
                foreach (var dir in dirInfo.GetDirectories()) 
                {
                    directoryInfo += dir.Name + '\n';
                }
                foreach (var file in dirInfo.GetFiles()) 
                {
                    directoryInfo += file.Name + '\n';
                }
                return Ok(directoryInfo);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("/file")]
        public IActionResult GetFileInfo(string filePath)
        {
            try
            {
                return Ok(System.IO.File.ReadAllText(filePath));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            
        }

    }
}
