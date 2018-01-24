using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PriceTagData
{
   public static class Serialization
   {
      public static response SerializeOrder(XmlDocument xdoc)
      {
         response retVal;
         using (XmlReader reader = XmlReader.Create(new StringReader(xdoc.OuterXml)))
         {
            reader.MoveToContent();
            switch (reader.Name)
            {
               case "response":
                  retVal = (response)new XmlSerializer(typeof(response)).Deserialize(reader);
                  break;
               default:
                  throw new NotSupportedException("Unexpected: " + reader.Name);
            }
         }
         return retVal;
      }
   }
}
