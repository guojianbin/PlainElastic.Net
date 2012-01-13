namespace PlainElastic.Net
{
    /// <summary>
    /// Provides shortcuts to Elastic Search command builders.
    /// </summary>
    public class ElasticCommands
    {

        public static GetCommandBuilder Get(string index = null, string type = null, string id = null)
        {
            return new GetCommandBuilder(index, type, id);
        }

        public static IndexCommandBuilder Index(string index, string type = null, string id = null)
        {
            return new IndexCommandBuilder(index, type, id);
        }

        public static SearchCommandBuilder Search()
        {
            return new SearchCommandBuilder();
        }
    }
}