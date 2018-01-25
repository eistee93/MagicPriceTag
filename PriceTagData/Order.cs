using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class Order
   {
      [System.Xml.Serialization.XmlElement("idOrder")]
      public int Id { get; set; }

      [System.Xml.Serialization.XmlElement("isBuyer")]
      public bool IsBuyer { get; set; }

      [System.Xml.Serialization.XmlElement("seller")]
      public User Seller { get; set; }

      [System.Xml.Serialization.XmlElement("buyer")]
      public User Buyer { get; set; }

      [System.Xml.Serialization.XmlElement("state")]
      public State State { get; set; }

      [System.Xml.Serialization.XmlElement("shippingMethod")]
      public ShippingMethod ShippingMethod { get; set; }

      [System.Xml.Serialization.XmlElement("isPresale")]
      public bool IsPresale { get; set; }

      [System.Xml.Serialization.XmlElement("shippingAddress")]
      public Address ShippingAddress { get; set; }

      [System.Xml.Serialization.XmlElement("articleCount")]
      public int ArticleCount { get; set; }

      [System.Xml.Serialization.XmlElement("note")]
      public string Note { get; set; }

      [System.Xml.Serialization.XmlElement("evaluation")]
      public Evaluation Evaluation { get; set; }

      [System.Xml.Serialization.XmlElement("article")]
      public Article[] Articles { get; set; }

      [System.Xml.Serialization.XmlElement("articleValue")]
      public decimal ArticlesValue { get; set; }

      [System.Xml.Serialization.XmlElement("serviceFeeValue")]
      public decimal ServiceFeeValue { get; set; }

      [System.Xml.Serialization.XmlElement("totalValue")]
      public decimal TotalValue { get; set; }
   }
}
