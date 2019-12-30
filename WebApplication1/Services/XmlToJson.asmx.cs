using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace WebApplication1.Services
{
    /// <summary>
    /// Description résumée de XmlToJson
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class XmlToJson : System.Web.Services.WebService
    {

        [WebMethod (Description = "Xml To Json parser")]
        public string Xml2Json(string xml)
        {
            string json = "Bad Xml format";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                json = JsonConvert.SerializeXmlNode(doc);
            }
            catch (Exception)
            {
                // The xml input string is not a well-formed xml
            }
            return json;
        }
    }
}
