using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_program
{
    class Program
    {
        static void Main(string[] args)
        {

            NewsCompany.newspaper newspaper = new NewsCompany.newspaper(10);

            NewsCompany.Story story1 = new NewsCompany.Story("t", "b");
            NewsCompany.Story story2 = new NewsCompany.Story("t", "b");
            NewsCompany.Story story3 = new NewsCompany.Story("t", "b");

            NewsCompany.Story[] stories = new NewsCompany.Story[3] { story1, story2, story3 };
            NewsCompany.newspaper newspaper2 = new NewsCompany.newspaper(stories,20);

            Store.Seller seller = new Store.Seller();
            seller.SellNewspaper(newspaper);
            seller.SellNewspaper(newspaper2);

            Console.WriteLine(seller.ToString());
            Console.WriteLine(newspaper.ToString());
            Console.WriteLine(newspaper2.ToString());

            Console.ReadLine();
        }
    }
}
