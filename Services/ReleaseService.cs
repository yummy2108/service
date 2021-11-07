using ReleaseServiceDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReleaseServiceDemo.Shared;
using System;

namespace ReleaseServiceDemo.Services{
    public class ReleaseService : IReleaseService{

        private List<Release> Releases{get;}
        private int nextId;
        public ReleaseService(){
            Console.WriteLine("test debug");
            this.Releases = new List<Release>{
                new Release{ReleaseId = 1, ReleaseName = "test sample", Timestamp = "00:00"}
            };
            this.nextId = 2;
        }

        /// <summary>
        /// Creates a release.
        /// </summary>
        /// <param name="logger">Instance of <see cref="ILogger"/>.</param>
        /// <param name="release">The release to create.</param>
        /// <returns>The created release.</returns>
        public Release CreateReleaseAsync(ILogger logger, Release release){
            release.ReleaseId = this.nextId++;
            release.Timestamp = DateTime.Now.ToString();
            this.Releases.Add(release);
            logger.LogInfo($"Creat release for id: {release.ReleaseId} - Name: {release.ReleaseName}");
            return release;
        }

        /// <summary>
        /// Gets a release by id.
        /// </summary>
        /// <param name="logger">Instance of <see cref="ILogger"/>.</param>
        /// <param name="id">The id to fetch.</param>
        /// <returns>The fetched release.</returns>
        public Release GetRelease(ILogger logger, int id){
            logger.LogInfo($"Retrieving release for id: {id}");
            return this.Releases.FirstOrDefault(p => p.ReleaseId == id);
        }

        /// <summary>
        /// Gets current releases by ring and namespace.
        /// </summary>
        /// <param name="logger">Instance of <see cref="ILogger"/>.</param>
        /// <returns>The list of releases.</returns>
        public List<Release> GetALLReleases(ILogger logger){
            logger.LogInfo("Retrieving All release ");
            return this.Releases;
        }      
    }
}