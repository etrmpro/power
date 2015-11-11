using ERCOT.MIS.reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ERCOT.MIS
{
    public class MISAppService
    {
        public List<ListReportTypeSchemaResReport> FetchReportTypes()
        {
            var url = "http://mis.ercot.com/misapp/servlets/IceMktRepListWS?";
            using (var webClient = new WebClient())
            {
                var xml = webClient.DownloadString(url);
                XmlSerializer serializer = new XmlSerializer(typeof(ListReportTypeSchemaRes));
                ListReportTypeSchemaRes res = (ListReportTypeSchemaRes)serializer.Deserialize(new StringReader(xml));
                return res.ReportTypeList.ToList();
            }
        }
    }
}
