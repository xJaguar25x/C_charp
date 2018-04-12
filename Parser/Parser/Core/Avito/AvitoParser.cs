using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace Parser.Core.Avito
{
    class AvitoParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();

            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null && item.ClassName.Contains("item_cars"));

            // счетчик
            var i = 0;
            foreach (var item in items)
            {
                list.Add(i + item.TextContent);
                i++;
            }

            return list.ToArray();
        }
    }
}
