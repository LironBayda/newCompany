using System;
using System.Collections.Generic;
using System.Text;

namespace NewsCompany
{
    abstract internal class NewsTeam
    {
        protected Story story;

        abstract internal void createStory();

        internal Story GetStory()
        {
            return story;
        }
        virtual internal void AddStyle()
        {
            story.SetVisualStyle("bold Ariel");
        }
        public override string ToString()
        {
            return base.ToString()+story.ToString();
        }

    }

    
}
