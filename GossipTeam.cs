using System;
using System.Collections.Generic;
using System.Text;

namespace NewsCompany
{
    class GossipTeam:NewsTeam
    {
        internal override void createStory()
        {
            story = new Story("Gossip title", "Gossip body");
        }
    }
}
