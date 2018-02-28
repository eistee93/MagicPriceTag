public enum Condition
{
    [System.Xml.Serialization.XmlEnum("MT")]
    Mint = 0,
    [System.Xml.Serialization.XmlEnum("NM")]
    NearMint = 1,
    [System.Xml.Serialization.XmlEnum("EX")]
    Excellent = 2,
    [System.Xml.Serialization.XmlEnum("GD")]
    Good = 3,
    [System.Xml.Serialization.XmlEnum("LP")]
    LightPlayed = 4,
    [System.Xml.Serialization.XmlEnum("PL")]
    Played = 5,
    [System.Xml.Serialization.XmlEnum("PO")]
    Poor = 6
}