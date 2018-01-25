using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class Evaluation
   {
      [System.Xml.Serialization.XmlElement("evaluationGrade")]
      public Grade TotalGrade { get; set; }

      [System.Xml.Serialization.XmlElement("itemDescription")]
      public Grade ItemDescriptionGrade { get; set; }

      [System.Xml.Serialization.XmlElement("packaging")]
      public Grade PackagingGrade { get; set; }

      [System.Xml.Serialization.XmlElement("comment")]
      public string Comment { get; set; }

      [System.Xml.Serialization.XmlElement("complaint")]
      public Complaint[] Complaints { get; set; }
   }
}
