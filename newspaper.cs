using System;
using System.Collections.Generic;
using System.Text;

namespace NewsCompany
{
    public class newspaper
    {
        Story[] _stories;
        float _price;

        public newspaper(Story[] stories, float price)
        {
            if (stories.Length == 3)
                _stories = stories;
            else
                Console.WriteLine("stories arrary don't contain enough elements");
            if (price >= 0)
                _price = price;
            else
                Console.WriteLine("price can't be negative");
         
        }

        public newspaper(float price)
        {
            GossipTeam gossipTeam=new GossipTeam();
            PoliticsTeam politicsTeam = new PoliticsTeam();
            HealthTeam healthTeam = new HealthTeam();

            gossipTeam.createStory();
            politicsTeam.createStory();
            healthTeam.createStory();

            _stories = new Story[] { gossipTeam.GetStory(), politicsTeam.GetStory(), healthTeam.GetStory() };

            
            if (price >= 0)
                _price = price;
            else
                Console.WriteLine("price can't be negative");

        }

        public Story[] GetStories()
        {
            return _stories;
        }

        public void SetStories(Story[] stories)
        {
            _stories = stories;
        }

        public float GetPrice()
        {
            return _price;
        }

        public void  SetPrice(float price)
        {
            _price = price;
        }

        public override string ToString()
        {
            string str = base.ToString() +$"_price: {_price} stories: ";
            for (int i=0;i<_stories.Length;i++)
            {
                str += _stories[i].ToString();
            }

            return str;

        }
    }
}
