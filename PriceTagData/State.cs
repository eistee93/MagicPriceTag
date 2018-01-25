using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceTagData
{
   [Serializable()]
   public class State
   {
      [System.Xml.Serialization.XmlElement("state")]
      public OrderState OrderState { get; set; }

      [System.Xml.Serialization.XmlElement("dateBought")]
      public string DateBought { get; set; }

      [System.Xml.Serialization.XmlElement("datePaid")]
      public string DatePaid { get; set; }

      [System.Xml.Serialization.XmlElement("dateSent")]
      public string DateSent { get; set; }

      [System.Xml.Serialization.XmlElement("dateReceived")]
      public string DateReceived { get; set; }

      [System.Xml.Serialization.XmlElement("dateCancelled")]
      public string DateCancelled { get; set; }

      [System.Xml.Serialization.XmlElement("reason")]
      public string CancellationReason { get; set; }

      [System.Xml.Serialization.XmlElement("wasMergedInto")]
      public string MergedOrderId { get; set; }
   }
}
