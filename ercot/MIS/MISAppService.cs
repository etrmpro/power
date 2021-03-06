﻿using ERCOT.MIS.reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Serialization;

namespace ERCOT.MIS
{
    public class MISAppService
    {
        string mis_url = "http://mis.ercot.com:80/misapp/";

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

        public List<ListDocsByRptTypeResDocument> FetchDocumentsByReportType(int reportTypeId)
        {
            var url = "http://mis.ercot.com/misapp/servlets/IceMktDocListWS?reportTypeId=";
            using (var webClient = new WebClient())
            {
                var xml = webClient.DownloadString(url + reportTypeId);
                XmlSerializer serializer = new XmlSerializer(typeof(ListDocsByRptTypeRes));
                ListDocsByRptTypeRes res = (ListDocsByRptTypeRes)serializer.Deserialize(new StringReader(xml));
                return res.DocumentList.ToList();
            }
        }

        public string FetchDocumentByDocId(int doclookupId)
        {
            var url = "http://mis.ercot.com/misdownload/servlets/mirDownload?doclookupId=";
            using (var webClient = new WebClient())
            {
                string fileLocation = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                webClient.DownloadFile(url + doclookupId, @fileLocation);
                return fileLocation;
            }
        }
    }
}
