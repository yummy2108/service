namespace ReleaseServiceDemo.Models
{
    public class Release{
        /// <summary>
        /// The release id.
        /// </summary>
        public int ReleaseId { get; set; }

        /// <summary>
        /// The release name.
        /// </summary>
        public string ReleaseName { get; set; }


        /// <summary>
        /// The timestamp of the release.
        /// </summary>
        public string Timestamp { get; set; }
    }
}