using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class User
   {
      [System.Xml.Serialization.XmlElement("idUser")]
      public int Id { get; set; }

      [System.Xml.Serialization.XmlElement("username")]
      public string Username { get; set; }

      [System.Xml.Serialization.XmlElement("registrationDate")]
      public string RegistrationDate { get; set; }

      [System.Xml.Serialization.XmlElement("isCommercial")]
      public UserType Type { get; set; }

      [System.Xml.Serialization.XmlElement("isSeller")]
      public bool IsSeller { get; set; }

      [System.Xml.Serialization.XmlElement("name")]
      public Name Name { get; set; }
      
      [System.Xml.Serialization.XmlElement("address")]
      public Address Address { get; set; }

      [System.Xml.Serialization.XmlElement("phone")]
      public string PhoneNumber { get; set; }

      [System.Xml.Serialization.XmlElement("email")]
      public string EMail { get; set; }

      [System.Xml.Serialization.XmlElement("vat")]
      public string Vat { get; set; }

      [System.Xml.Serialization.XmlElement("legalInformation")]
      public string LegalInformation { get; set; }

      [System.Xml.Serialization.XmlElement("riskGroup")]
      public RiskGroup RiskGroup { get; set; }

      [System.Xml.Serialization.XmlElement("lossPercentage")]
      public string LostShipments { get; set; }

      [System.Xml.Serialization.XmlElement("unsentShipments")]
      public int UnsentShippments { get; set; }

      [System.Xml.Serialization.XmlElement("reputation")]
      public Reputation Reputation { get; set; }

      [System.Xml.Serialization.XmlElement("shipsFast")]
      public int ShipsFast { get; set; }

      [System.Xml.Serialization.XmlElement("sellCount")]
      public int SellCount { get; set; }

      [System.Xml.Serialization.XmlElement("soldItems")]
      public int SoldItems { get; set; }

      [System.Xml.Serialization.XmlElement("avgShippingTime")]
      public int AverageShippingTime { get; set; }

      [System.Xml.Serialization.XmlElement("onVacation")]
      public bool IsOnVacation { get; set; }
   }
}
