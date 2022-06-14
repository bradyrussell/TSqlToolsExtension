using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo.RegSvrEnum;
using Microsoft.SqlServer.Management.UI.VSIntegration;
using Microsoft.SqlServer.Management.UI.VSIntegration.Editors;

namespace TSqlTools
{
    class TSqlDescriptionGenerator
    {
        public static string GenerateDescriptions(string input)
        {
            return TSqlToolsLib.TSqlTools.GenerateDescriptions(input);
        }

        public static string GenerateComments(string input)
        {
            return TSqlToolsLib.TSqlTools.GenerateCommentsFromDescriptions(input);
        }

        public static string GenerateCodeValueAnnotations(string input)
        {
            IScriptFactory scriptFactory = ServiceCache.ScriptFactory;
            CurrentlyActiveWndConnectionInfo connectionIfno = scriptFactory.CurrentlyActiveWndConnectionInfo;
            UIConnectionInfo conn = connectionIfno.UIConnectionInfo;
            Debug.WriteLine($"Server: {conn.ServerName}, Database: {conn.AdvancedOptions["DATABASE"]}");
            return TSqlToolsLib.TSqlTools.AnnotateCodeValues(conn.ServerName, conn.AdvancedOptions["DATABASE"], input);
        }
    }
}
