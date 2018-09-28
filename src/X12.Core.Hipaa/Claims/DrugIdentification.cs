namespace X12.Core.Hipaa.Claims
{
    using System.Xml.Serialization;

    using X12.Core.Hipaa.Common;

    public class DrugIdentification
    {
        [XmlAttribute]
        public string Ndc { get; set; }

        [XmlAttribute]
        public decimal Quantity { get; set; }

        public Lookup UnitOfMeasure { get; set; }

        public Identification Identification { get; set; }
    }
}
