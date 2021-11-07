using ReleaseServiceDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReleaseServiceDemo.Shared;
namespace ReleaseServiceDemo.Services
{

    /// <summary>
    /// The Release service.
    /// </summary>
    public interface IReleaseService
    {
        /// <summary>
        /// Creates a release.
        /// </summary>
        /// <param name="logger">Instance of <see cref="ILogger"/>.</param>
        /// <param name="release">The release to create.</param>
        /// <returns>The created release.</returns>
        Release CreateReleaseAsync(ILogger logger, Release release);

        /// <summary>
        /// Gets a release by id.
        /// </summary>
        /// <param name="logger">Instance of <see cref="ILogger"/>.</param>
        /// <param name="id">The id to fetch.</param>
        /// <returns>The fetched release.</returns>
        Release GetRelease(ILogger logger, int id);

        /// <summary>
        /// Gets current releases by ring and namespace.
        /// </summary>
        /// <param name="logger">Instance of <see cref="ILogger"/>.</param>
        /// <returns>The list of releases.</returns>
        List<Release> GetALLReleases(ILogger logger);

    }
}
