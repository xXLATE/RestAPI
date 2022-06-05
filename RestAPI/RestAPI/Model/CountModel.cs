using System.Collections.Generic;

namespace RestAPI.Model
{
    public class CountModel
    {
        public int count { get; set; }
        public List<EntryModel > entries { get; set; }
    }
}
