using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class ShippingMethod
   {
      [System.Xml.Serialization.XmlElement("idShippingMethod")]
      public int Id { get; set; }

      [System.Xml.Serialization.XmlElement("name")]
      public string Name { get; set; }

      [System.Xml.Serialization.XmlElement("price")]
      public decimal Price { get; set; }

      [System.Xml.Serialization.XmlElement("isLetter")]
      public bool IsLetter { get; set; }

      [System.Xml.Serialization.XmlElement("isInsured")]
      public bool IsInsured { get; set; }
   }
}
