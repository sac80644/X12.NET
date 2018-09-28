namespace X12.Core.Validation
{
    using X12.Core.Specifications.Finders;

    /// <summary>
    /// Represents the institutional claims extension of the <see cref="X12AcknowledgmentService"/>
    /// </summary>
    public class InstitutionalClaimAcknowledgmentService : X12AcknowledgmentService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionalClaimAcknowledgmentService"/> class
        /// </summary>
        public InstitutionalClaimAcknowledgmentService()
            : base(new InstitutionalClaimSpecificationFinder())
        {
        }
    }
}
