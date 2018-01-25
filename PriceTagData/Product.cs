using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class Product
   {
      [System.Xml.Serialization.XmlElement("enName")]
      public string Name { get; set; }

      [System.Xml.Serialization.XmlElement("locName")]
      public string LocalizedName { get; set; }

      [System.Xml.Serialization.XmlElement("image")]
      public string ImagePath { get; set; }

      [System.Xml.Serialization.XmlElement("expansion")]
      public string Expansion { get; set; }

      [System.Xml.Serialization.XmlElement("nr")]
      public string Number { get; set; }

      [System.Xml.Serialization.XmlElement("expIcon")]
      public int ExpansionIconIndex { get; set; }

      [System.Xml.Serialization.XmlElement("rarity")]
      public string Rarity { get; set; }
   }
}
