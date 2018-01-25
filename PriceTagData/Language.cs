using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class Language
   {
      [System.Xml.Serialization.XmlElement("idLanguage")]
      public int Id { get; set; }

      [System.Xml.Serialization.XmlElement("languageName")]
      public string Name { get; set; }

   }
}
