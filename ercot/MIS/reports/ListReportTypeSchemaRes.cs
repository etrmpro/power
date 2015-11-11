using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERCOT.MIS.reports
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ercot.com/schema/2012-10/nodal/ListReportTypeSchemaRes")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.ercot.com/schema/2012-10/nodal/ListReportTypeSchemaRes", IsNullable = false)]
    public partial class ListReportTypeSchemaRes
    {

        private ListReportTypeSchemaResReport[] reportTypeListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Report", IsNullable = false)]
        public ListReportTypeSchemaResReport[] ReportTypeList
        {
            get
            {
                return this.reportTypeListField;
            }
            set
            {
                this.reportTypeListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ercot.com/schema/2012-10/nodal/ListReportTypeSchemaRes")]
    public partial class ListReportTypeSchemaResReport
    {

        private ushort reportTypeIDField;

        private string reportNameField;

        private string securityClassificationField;

        /// <remarks/>
        public ushort ReportTypeID
        {
            get
            {
                return this.reportTypeIDField;
            }
            set
            {
                this.reportTypeIDField = value;
            }
        }

        /// <remarks/>
        public string ReportName
        {
            get
            {
                return this.reportNameField;
            }
            set
            {
                this.reportNameField = value;
            }
        }

        /// <remarks/>
        public string SecurityClassification
        {
            get
            {
                return this.securityClassificationField;
            }
            set
            {
                this.securityClassificationField = value;
            }
        }
    }



}
