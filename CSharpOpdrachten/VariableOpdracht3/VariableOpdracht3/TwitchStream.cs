namespace VariableOpdracht3
{
    //vul de ??? in
    internal class TwitchStream
    {
        private const string V = "tag";
        private string tag;

        internal TwitchStream(string tag)
        {
            this.tag = tag;
        }
        internal string GetTag()
        {
            return tag;
        }

        internal void SetTag(string name = "tag")//maak hier een variable: type: string, name: tag
        {
            this.tag = tag;
        }
    }
}