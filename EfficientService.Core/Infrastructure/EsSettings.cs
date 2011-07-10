using System;
using System.Configuration;

namespace EfficientService.Core.Infrastructure
{
    public class EsSettings
    {
        public bool IsJabberNotifyEnabled
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["JabberEnabled"]); }
            set { ConfigurationManager.AppSettings["JabberEnabled"] = value.ToString(); }
        }
    }
}