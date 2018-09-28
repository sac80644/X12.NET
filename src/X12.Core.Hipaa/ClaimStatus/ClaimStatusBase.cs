namespace X12.Core.Hipaa.ClaimStatus
{
    using X12.Core.Hipaa.Common;

    public class ClaimStatusBase
    {
        public EntityName Source { get; set; }

        public EntityName Receiver { get; set; }

        public EntityName ServiceProvider { get; set; }

        public Member Subscriber { get; set; }

        public Member Dependent { get; set; }
    }
}
