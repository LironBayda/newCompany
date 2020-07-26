using System;
using System.Collections.Generic;
using System.Text;

namespace NewsCompany
{
    class PoliticsTeam : NewsTeam
    {
        internal override void createStory()
        {
            story = new Story("politics title", "politics body");
        }

        internal override void AddStyle()
        {
            story.SetVisualStyle("David");
        }
    }

    
}
