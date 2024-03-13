using ConsoleTables;
using Linq.Model;
using Linq.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Service
{
    public class LinqService : ILinqService
    {
        private static readonly List<string> nigerianStates = new List<string>
        {
            "Abia",
            "Adamawa",
            "Akwa Ibom",
            "Anambra",
            "Bauchi",
            "Bayelsa",
            "Benue",
            "Borno",
            "Cross River",
            "Delta",
            "Ebonyi",
            "Edo",
            "Ekiti",
            "Enugu",
            "Gombe",
            "Imo",
            "Jigawa",
            "Kaduna",
            "Kano",
            "Katsina",
            "Kebbi",
            "Kogi",
            "Kwara",
            "Lagos",
            "Nasarawa",
            "Niger",
            "Ogun",
            "Ondo",
            "Osun",
            "Oyo",
            "Plateau",
            "Rivers",
            "Sokoto",
            "Taraba",
            "Yobe",
            "Zamfara"
        };
        private IStateRepository stateRepository = new StateRepository();
        private static List<char> alphabet = [
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            ];

        #region StatesAsString
        public void GroupByN(int n)
        {
            int groupNum = 0;
            // groups elements according to a specified key
            var groupedList = nigerianStates.GroupBy(
                x => groupNum++ / n,
                (state) => new
                {
                    states = state
                });

            foreach (var group in groupedList)
            {
                Console.Write(group.Key + ": ");
                group.ToList().ForEach(x => Console.Write(x.states + " "));
                Console.WriteLine();
            }
        }
        public void GroupByAlphabet() 
        {
            // create a mapping of a key in the first list to a  group in the second list with the same key.
            var groupedList = alphabet.GroupJoin(nigerianStates, a => a, b => b.ToLower()[0],
                (a, stateList) =>
                new
                {
                    letter = a,
                    states = stateList
                });

            foreach (var group in groupedList)
            {
                Console.Write($"{group.letter}: ");
                group.states.ToList().ForEach(x => Console.Write(x + " "));
                Console.WriteLine();
            }

        }
        public void JoinLists()
        {
            List<Item> itemlist = new List<Item>
            {

            new Item { ItemId = 1, ItemDes = "Bag" },

            new Item { ItemId = 2, ItemDes = "Pen" },

            new Item { ItemId = 3, ItemDes = "Book " },

            new Item { ItemId = 4, ItemDes = "Shoe " },

            new Item { ItemId = 5, ItemDes = "Pin " }

            };

            List<Sales> saleslist = new List<Sales> {

                new Sales{ InvNo=1, ItemId = 3, Qty = 10 },

                new Sales{ InvNo=2, ItemId = 2, Qty = 20 },

                new Sales{ InvNo=3, ItemId = 3, Qty = 500 },

                new Sales{ InvNo=4, ItemId = 4, Qty = 20 },

                new Sales{ InvNo=5, ItemId = 3, Qty = 100 },

                new Sales{ InvNo=6, ItemId = 1, Qty = 50 }

            };
            // join elements based on matching keys
            var joinedList = itemlist.Join(saleslist, item => item.ItemId, sale => sale.ItemId,
                (item, sale) => new 
                {
                    ItemId = item.ItemId,
                    ItemName = item.ItemDes,
                    Quantity = sale.Qty
                });

            var newTable = new ConsoleTable("Id", " Description", "Quantity");
            foreach (var item in joinedList)
            {
                newTable.AddRow(item.ItemId, item.ItemName, item.Quantity);
            }
            newTable.Write();
        }
        #endregion

        #region StatesAsState
        public void GroupStatesByN(int n)
        {
            // key = the resultant value of the state's Id/n since its an int it will divide the states
            // into groups based on their Id's relative multiple of n
            var groupedStates = GetStates().GroupBy(state => (state.Id - 1) / n);

            Console.WriteLine($"Groups of states in sets of {n}");
            Console.WriteLine(new string('=', 40));
            foreach (var group in groupedStates)
            {
                Console.Write($"Group {group.Key + 1}: ");
                group.ToList().ForEach(x => Console.Write(x.Name + " "));
                Console.WriteLine();
            }
        }

        public void GroupStatesByAlphabet()
        {
            var groupedStates = alphabet.GroupJoin(GetStates(), a => a, state => state.Name.ToLower()[0],
                (a, stateList) => new
                {
                    letter = a,
                    states = stateList
                });

            foreach (var group in groupedStates)
            {
                Console.WriteLine($"Group {group.letter.ToString().ToUpper()} - {group.states.Count()}");
                Console.WriteLine(new string('-', 11));
                group.states.ToList().ForEach(x => Console.Write(x.Name + " "));
                Console.WriteLine("\n");
            }
        }
        #endregion

        private List<State> GetStates()
        {
            return stateRepository.GetAll();
        }
    }
}
