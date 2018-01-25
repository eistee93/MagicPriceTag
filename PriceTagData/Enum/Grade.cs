public enum Grade
{
   [System.Xml.Serialization.XmlEnum("1")]
   VeryGood = 1,
   [System.Xml.Serialization.XmlEnum("2")]
   Good = 2,
   [System.Xml.Serialization.XmlEnum("3")]
   Neutral = 3,
   [System.Xml.Serialization.XmlEnum("4")]
   Bad = 4,
   [System.Xml.Serialization.XmlEnum("10")]
   Undefined = 10
}