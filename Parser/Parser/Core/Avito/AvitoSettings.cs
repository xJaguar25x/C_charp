
namespace Parser.Core.Avito
{
    class AvitoSettings : IParserSettings
    {
        public AvitoSettings(string marka, string model, int start, int end)
        {
            if (marka != null)
            {
                Marka_avto = "/" + marka;
            }else
            {
                Marka_avto = marka;
            }
            if ( model != null)
            {
                Model_avto = "/" + model;
            }else
            {
                Model_avto = model;
            }
                      
            StartPage = start;
            EndPage = end;
        }

        public string BaseUrl { get; set; } = "https://www.avito.ru/rossiya/avtomobili";

        public string Prefix { get; set; } = "?p={CurrentId}";

        public string Marka_avto { get; set; }

        public string Model_avto { get; set; }

        public int StartPage { get; set; }

        public int EndPage { get; set; }
    }
}
