namespace X12.Core.Shared.Enumerations
{
    using X12.Core.Shared.Attributes;

    public enum RelationshipCode
    {
        [EdiFieldValue("A")]
        Add,

        [EdiFieldValue("D")]
        Delete,

        [EdiFieldValue("I")]
        Include,

        [EdiFieldValue("O")]
        InformationOnly,

        [EdiFieldValue("S")]
        Substituted
    }
}
