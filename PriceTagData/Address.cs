using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class Address
   {
      [System.Xml.Serialization.XmlElement("name")]
      public string ReceiverName { get; set; }

      [System.Xml.Serialization.XmlElement("extra")]
      public string ExtraInformation { get; set; }

      [System.Xml.Serialization.XmlElement("street")]
      public string Street { get; set; }

      [System.Xml.Serialization.XmlElement("zip")]
      public string Zip { get; set; }

      [System.Xml.Serialization.XmlElement("city")]
      public string City { get; set; }

      [System.Xml.Serialization.XmlElement("country")]
      public string Country { get; set; }
   }
}
