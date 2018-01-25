using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class Name
   {
      [System.Xml.Serialization.XmlElement("company")]
      public string Company { get; set; }

      [System.Xml.Serialization.XmlElement("firstName")]
      public string FirstName { get; set; }

      [System.Xml.Serialization.XmlElement("lastName")]
      public string LastName { get; set; }
   }
}
