using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class TechnicalAlias
    {
        public int AliasId { get; private set; }
        public string Alias { get; private set; }
        public string Media { get; private set; }
        public string Region { get; private set; }

        public TechnicalAlias(int aliasId, string alias, string media, string region)
        {
            AliasId = aliasId;
            Alias = alias;
            Media = media;
            Region = region;
        }
    }

}
