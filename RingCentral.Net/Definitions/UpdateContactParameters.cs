namespace RingCentral
{
    // Query parameters for operation updateContact
    public class UpdateContactParameters
    {
        /// <summary>
        ///     A country code value complying with the [ISO 3166-1 alpha-2](https://ru.wikipedia.org/wiki/ISO_3166-1_alpha-2)
        ///     format. The default value is home country of the current extension
        /// </summary>
        public string dialingPlan { get; set; }
    }
}