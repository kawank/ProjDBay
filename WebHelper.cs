using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace BAVDashboard.Utility
{
    public static class WebHelper
    {
        public static string HTTPPost(string url)
        {
            try
            {
                WebClient wc = new WebClient();
                string html = wc.DownloadString(url);
                return html;
            }
            catch (Exception ex)
            {
                log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType).Error(ex);
                return "";
            }
            
        }

        
        public static bool HTTPPost(Uri uri,string fileName)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(uri,fileName);
                return true;
            }
            catch (Exception ex)
            {
                log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType).Error(ex);
                return false;
            }

        }

    }
}
