using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UploadLargeFile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post(IFormFile file)
        {
            string fileName = file.FileName;
            /* In progress
            using (var stream = System.IO.File.Create(fileName))
            {
                await file.CopyToAsync(stream);
            }*/

            return Ok();
        }
    }
}