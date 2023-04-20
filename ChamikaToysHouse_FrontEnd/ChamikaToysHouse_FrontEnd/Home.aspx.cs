using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChamikaToysHouse_FrontEnd.ServiceReference1;

namespace ChamikaToysHouse_FrontEnd
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceClient obj = new ServiceClient();
            string[][] item = obj.GetItem();
            string html = "";
            html += "";
            html += "<div class='row ms-3 mt-3'>";
            for (int i = 0; i < item.Length; i++)
            {
                string[] itemdetails = item[i].ToArray();

                html += "<div class='col-lg-3 col-md-3 col-sm-3 pb-3'>";
                html += "<div class='card mt-3' style='width: 18rem;'>";
                html += "<img src = '" + itemdetails[1] + "' class='card-img-top' alt='' style='height:18rem;'>";
                html += "<div class='card-body'>";
                html += "<h5 class='card-title'>" + itemdetails[0] + "</h5>";
                html += "<p class='card-text'>" + itemdetails[2] + "</p>";
                html += "</div>";
                html += "<button class='btn btn-primary'>" + "Go To Cart" + "</button>";
                html += "</div>";
                html += "</div>";


            }
            html += "</div>";
            ToyControl.Text = html;
        }
    }
}