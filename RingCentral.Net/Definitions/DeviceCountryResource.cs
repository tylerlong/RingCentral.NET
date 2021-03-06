namespace RingCentral
{
    // Brief information on a phone number country
    public class DeviceCountryResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Format: int64
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        /// </summary>
        public string callingCode { get; set; }

        /// <summary>
        /// </summary>
        public bool? emergencyCalling { get; set; }

        /// <summary>
        /// </summary>
        public bool? numberSelling { get; set; }

        /// <summary>
        /// </summary>
        public bool? loginAllowed { get; set; }
    }
}