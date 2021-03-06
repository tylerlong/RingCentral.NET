namespace RingCentral
{
    public class ProfileImageResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string etag { get; set; }

        /// <summary>
        /// </summary>
        public string contentType { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string lastModified { get; set; }

        /// <summary>
        /// </summary>
        public ScaledProfileImageResource[] scales { get; set; }
    }
}