using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public bool ChkLogin(string user_name, string password)
    {
        String path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Toys_Xml/UserLists.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(path);
        XmlNodeList nodeListDetails = xmlDoc.DocumentElement.SelectNodes("/Login/User");
        bool valid = false;
        foreach (XmlNode node in nodeListDetails)
        {
            if (user_name == node.SelectSingleNode("Username").InnerText.Trim() && password == node.SelectSingleNode("Password").InnerText.Trim())
            {
                valid = true;
                break;
            }
        }
        return valid;
    }
    public List<List<string>> GetItem()
    {
        String path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Toys_Xml/ItemLists.xml");
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(path);
        XmlNodeList nodeListDetails = xmlDoc.DocumentElement.SelectNodes("/ChamikaToyHouse/toy");

        List<List<string>> Toys = new List<List<string>>();
        string baseUrl = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + HttpContext.Current.Request.ApplicationPath.TrimEnd('/') + "/";
        foreach (XmlNode node in nodeListDetails)
        {
            List<string> ToyLists = new List<string>();
            ToyLists.Add(node.SelectSingleNode("title").InnerText.Trim());
            ToyLists.Add(baseUrl + "image/" + node.SelectSingleNode("image").InnerText.Trim());
            ToyLists.Add(node.SelectSingleNode("price").InnerText.Trim());
            Toys.Add(ToyLists);
        }
        return Toys;
    }   
}
