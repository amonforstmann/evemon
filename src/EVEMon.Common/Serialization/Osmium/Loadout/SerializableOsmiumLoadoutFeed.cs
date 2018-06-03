using System;
using EVEMon.Common.Constants;

namespace EVEMon.Common.Serialization.Osmium.Loadout
{
    public sealed class SerializableOsmiumLoadoutFeed
    {
        public long id => System.Int64.Parse(uri.Replace($"{NetworkConstants.OsmiumBaseUrl}/loadout/", String.Empty));

        public string uri { get; set; }

        public string name { get; set; }

        public int shiptypeid { get; set; }

        public string shiptypename { get; set; }

        public SerializableOsmiumLoadoutAuthor author { get; set; }

        public long creationdate { get; set; }

        public string rawdescription { get; set; }

        public int upvotes { get; set; }

        public int downvotes { get; set; }

        public int rating => upvotes - downvotes;
    }
}
