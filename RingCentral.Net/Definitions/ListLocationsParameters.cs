namespace RingCentral
{
    // Query parameters for operation listLocations
    public class ListLocationsParameters
    {
        /// <summary>
        ///     Sorts results by the property specified
        ///     Default: City
        ///     Enum: Npa, City
        /// </summary>
        public string orderBy { get; set; }

        /// <summary>
        ///     Indicates the page number to retrieve. Only positive number values are accepted
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates the page size (number of items)
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Internal identifier of a state
        /// </summary>
        public string stateId { get; set; }

        /// <summary>
        ///     Specifies if nxx codes are returned
        /// </summary>
        public bool? withNxx { get; set; }
    }
}