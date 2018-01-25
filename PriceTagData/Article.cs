using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class Article
   {
      [System.Xml.Serialization.XmlElement("idArticle")]
      public int Id { get; set; }

      [System.Xml.Serialization.XmlElement("idProduct")]
      public int ProductId { get; set; }

      [System.Xml.Serialization.XmlElement("language")]
      public Language Language { get; set; }

      [System.Xml.Serialization.XmlElement("comments")]
      public string Comments { get; set; }

      [System.Xml.Serialization.XmlElement("price")]
      public decimal Price { get; set; }

      [System.Xml.Serialization.XmlElement("count")]
      public int Count { get; set; }

      [System.Xml.Serialization.XmlElement("inShoppingCart")]
      public bool IsInShoppingCart { get; set; }

      [System.Xml.Serialization.XmlElement("product")]
      public Product Product { get; set; }

      [System.Xml.Serialization.XmlElement("condition")]
      public string Condition { get; set; }

      [System.Xml.Serialization.XmlElement("isFoil")]
      public bool IsFoil { get; set; }

      [System.Xml.Serialization.XmlElement("isSigned")]
      public bool IsSigned { get; set; }

      [System.Xml.Serialization.XmlElement("isAltered")]
      public bool IsAltered { get; set; }

      [System.Xml.Serialization.XmlElement("isPlayset")]
      public bool IsPlayset { get; set; }
   }
}
