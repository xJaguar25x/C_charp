using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Parser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}{settings.Marka_avto}{settings.Model_avto}{settings.Prefix}";
            Console.WriteLine("Наш url " + (string) url);
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            Console.WriteLine("Наш currentUrl " + currentUrl);
            var response = await client.GetAsync(currentUrl);
            string source = null;

            Console.WriteLine("Наш response " + response);

            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
                //Console.WriteLine("Наш source " + source);
            }

            return source;
        }
    }
}
