using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class Profile
    {
        public ProfileType ProfileType { get; private set; }
        public GridDataType ProfileDataType { get; private set; }
        public Product Product { get; private set; }
        public long ProfileId { get; private set; }
        public string ProfileName { get; private set; }
        public List<GridRuleBase> ProfileGrid { get; private set; } = new();
        public PricingTool Perimeter { get; private set; }

        public Profile(ProfileType profileType, GridDataType profileDataType, Product product, long profileId, string profileName, PricingTool perimeter)
        {
            ProfileType = profileType;
            ProfileDataType = profileDataType;
            Product = product;
            ProfileId = profileId;
            ProfileName = profileName;
            Perimeter = perimeter;
        }

        public void AddGridRule(GridRuleBase gridRule)
        {
            ProfileGrid.Add(gridRule);
        }
    }

}
