using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSqlTools
{
    class TSqlDescriptionGenerator
    {
        public static string GenerateDescriptions(string input)
        {
            return TSqlToolsLib.TSqlTools.GenerateDescriptions(input);
        }
    }
}
