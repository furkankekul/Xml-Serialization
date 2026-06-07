using System.Xml.Serialization;

namespace XML.UblTR
{
    public class UBLHelper<T> where T : class
    {

        /// <summary>
        /// XML belgesini T türünde nesneye dönüştürür
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static T GetUblTrFromString(string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using StringReader reader = new StringReader(xmlString);
            return (T)serializer.Deserialize(reader);
        }
    }
}
