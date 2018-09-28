namespace X12.Core.Hipaa.Common
{
    using System.Xml.Serialization;

    public class QualifiedAmount
    {
        [XmlAttribute]
        public string Qualifier { get; set; }

        [XmlAttribute]
        public decimal Amount { get; set; }

        [XmlText]
        public string Description { get; set; }
    }
}
