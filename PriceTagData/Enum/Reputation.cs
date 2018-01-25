public enum Reputation
{
   [System.Xml.Serialization.XmlEnum("0")]
   NotEnoughSells = 0,
   [System.Xml.Serialization.XmlEnum("1")]
   Outstanding = 1,
   [System.Xml.Serialization.XmlEnum("2")]
   VeryGood = 2,
   [System.Xml.Serialization.XmlEnum("3")]
   Good = 3,
   [System.Xml.Serialization.XmlEnum("4")]
   Average = 4,
   [System.Xml.Serialization.XmlEnum("5")]
   Bad = 5
}