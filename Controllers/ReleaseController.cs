using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ReleaseServiceDemo.Models;
using ReleaseServiceDemo.Services;
using ReleaseServiceDemo.Shared;
using System.Threading.Tasks;
using System;
namespace ReleaseServiceDemo.Controllers{
    [Route("release-service/api/[controller]")]
    [ApiController]

    public class ReleaseController : ControllerBase{
        private IReleaseService releaseService;
        private ILogger logger;
        public ReleaseController(){
            Console.WriteLine("test debug controller");
            this.releaseService = new ReleaseService();
            this.logger = new ConsoleLogger();
        }

        [HttpGet("all")]
        public ActionResult<List<Release>> GetALLReleases(){
            this.logger.LogInfo($"Received request for all releases");
            return this.releaseService.GetALLReleases(logger);
        }

        [HttpGet("{id}")]
        public ActionResult<Release> Get(int id){
            this.logger.LogInfo($"Received get request for request id: {id}");
            Release release = this.releaseService.GetRelease(this.logger, id);
            if (release != null){
                return release;
            }
            else{
                return this.NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Release> CreateReleaseAsync(Release release){
            return this.releaseService.CreateReleaseAsync(this.logger, release);
        }
    }
}