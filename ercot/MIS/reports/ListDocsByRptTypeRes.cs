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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ercot.com/schema/2012-10/nodal/ListDocsByRptTypeRes")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.ercot.com/schema/2012-10/nodal/ListDocsByRptTypeRes", IsNullable = false)]
    public partial class ListDocsByRptTypeRes
    {

        private ListDocsByRptTypeResDocument[] documentListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Document", IsNullable = false)]
        public ListDocsByRptTypeResDocument[] DocumentList
        {
            get
            {
                return this.documentListField;
            }
            set
            {
                this.documentListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ercot.com/schema/2012-10/nodal/ListDocsByRptTypeRes")]
    public partial class ListDocsByRptTypeResDocument
    {

        private System.DateTime expiredDateField;

        private string iLMStatusField;

        private string securityStatusField;

        private uint contentSizeField;

        private string extensionField;

        private object fileNameField;

        private byte reportTypeIDField;

        private string prefixField;

        private string friendlyNameField;

        private string constructedNameField;

        private uint docIDField;

        private System.DateTime publishDateField;

        private string reportNameField;

        private byte dUNSField;

        private byte docCountField;

        /// <remarks/>
        public System.DateTime ExpiredDate
        {
            get
            {
                return this.expiredDateField;
            }
            set
            {
                this.expiredDateField = value;
            }
        }

        /// <remarks/>
        public string ILMStatus
        {
            get
            {
                return this.iLMStatusField;
            }
            set
            {
                this.iLMStatusField = value;
            }
        }

        /// <remarks/>
        public string SecurityStatus
        {
            get
            {
                return this.securityStatusField;
            }
            set
            {
                this.securityStatusField = value;
            }
        }

        /// <remarks/>
        public uint ContentSize
        {
            get
            {
                return this.contentSizeField;
            }
            set
            {
                this.contentSizeField = value;
            }
        }

        /// <remarks/>
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        public object FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        public byte ReportTypeID
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
        public string Prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
            }
        }

        /// <remarks/>
        public string FriendlyName
        {
            get
            {
                return this.friendlyNameField;
            }
            set
            {
                this.friendlyNameField = value;
            }
        }

        /// <remarks/>
        public string ConstructedName
        {
            get
            {
                return this.constructedNameField;
            }
            set
            {
                this.constructedNameField = value;
            }
        }

        /// <remarks/>
        public uint DocID
        {
            get
            {
                return this.docIDField;
            }
            set
            {
                this.docIDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime PublishDate
        {
            get
            {
                return this.publishDateField;
            }
            set
            {
                this.publishDateField = value;
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
        public byte DUNS
        {
            get
            {
                return this.dUNSField;
            }
            set
            {
                this.dUNSField = value;
            }
        }

        /// <remarks/>
        public byte DocCount
        {
            get
            {
                return this.docCountField;
            }
            set
            {
                this.docCountField = value;
            }
        }
    }


}
