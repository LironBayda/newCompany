using System;
using System.Collections.Generic;
using System.Text;

namespace NewsCompany
{
    class HealthTeam:NewsTeam
    {

        internal override void createStory()
        {
            story = new Story("Health title", "Health body");
        }

        internal override void AddStyle()
        {
            story.SetVisualStyle("bold David");
        }
    }
}
