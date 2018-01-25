public enum OrderState
{
   [System.Xml.Serialization.XmlEnum("bought")]
   Bought = 1,
   [System.Xml.Serialization.XmlEnum("paid")]
   Paid = 2,
   [System.Xml.Serialization.XmlEnum("sent")]
   Sent = 4,
   [System.Xml.Serialization.XmlEnum("received")]
   Received = 8,
   [System.Xml.Serialization.XmlEnum("evaluated")]
   Evaluated = 16,
   [System.Xml.Serialization.XmlEnum("lost")]
   Lost = 32,
   [System.Xml.Serialization.XmlEnum("cancelled")]
   Cancelled = 128
}