namespace X12.Core.Shared.Enumerations
{
    using X12.Core.Shared.Attributes;

    public enum EntityTypeQualifier
    {
        [EdiFieldValue("")]
        Undefined,

        [EdiFieldValue("1")]
        Person,

        [EdiFieldValue("2")]
        NonPersonEntity,

        [EdiFieldValue("3")]
        Unknown,

        [EdiFieldValue("4")]
        Corporation,

        [EdiFieldValue("5")]
        Trust,

        [EdiFieldValue("6")]
        Organization,

        [EdiFieldValue("7")]
        LimitedLiabilityCorporation,

        [EdiFieldValue("8")]
        Partnership,

        [EdiFieldValue("9")]
        SCorporation,

        [EdiFieldValue("C")]
        Custodial,

        [EdiFieldValue("D")]
        NonProfitOrganization,

        [EdiFieldValue("E")]
        SoleProprietorship,

        [EdiFieldValue("G")]
        Government,

        [EdiFieldValue("L")]
        LimitedPartnership
    }
}
