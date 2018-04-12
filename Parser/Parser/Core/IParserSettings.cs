using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    interface IParserSettings
    {
        string BaseUrl { get; set; }

        string Prefix { get; set; }

        string Marka_avto { get; set; }

        string Model_avto { get; set; }

        int StartPage { get; set; }

        int EndPage { get; set; }
    }
}