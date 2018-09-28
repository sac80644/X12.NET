namespace X12.Core.Hipaa.Eligibility
{
    using X12.Core.Hipaa.Common;

    public class RelatedEntity : Entity
    {
        /// <summary>
        /// Gets or sets the provider information
        /// </summary>
        public ProviderInformation ProviderInfo { get; set; }
    }
}
