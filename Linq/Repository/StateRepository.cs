using Linq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Repository
{
    public class StateRepository : IStateRepository
    {
        public List<State> GetAll()
        {
            return new List<State>()
            {
                new State() { Id = 1, Name = "Abia", Capital = "Umuahia" },
                new State() { Id = 2, Name = "Adamawa", Capital = "Yola" },
                new State() { Id = 3, Name = "Akwa Ibom", Capital = "Uyo" },
                new State() { Id = 4, Name = "Anambra", Capital = "Awka" },
                new State() { Id = 5, Name = "Bauchi", Capital = "Bauchi" },
                new State() { Id = 6, Name = "Bayelsa", Capital = "Yenagoa" },
                new State() { Id = 7, Name = "Benue", Capital = "Makurdi" },
                new State() { Id = 8, Name = "Borno", Capital = "Maiduguri" },
                new State() { Id = 9, Name = "Cross River", Capital = "Calabar" },
                new State() { Id = 10, Name = "Delta", Capital = "Asaba" },
                new State() { Id = 11, Name = "Ebonyi", Capital = "Abakaliki" },
                new State() { Id = 12, Name = "Edo", Capital = "Benin City" },
                new State() { Id = 13, Name = "Ekiti", Capital = "Ado Ekiti" },
                new State() { Id = 14, Name = "Enugu", Capital = "Enugu" },
                new State() { Id = 15, Name = "Gombe", Capital = "Gombe" },
                new State() { Id = 16, Name = "Imo", Capital = "Owerri" },
                new State() { Id = 17, Name = "Jigawa", Capital = "Dutse" },
                new State() { Id = 18, Name = "Kaduna", Capital = "Kaduna" },
                new State() { Id = 19, Name = "Kano", Capital = "Kano" },
                new State() { Id = 20, Name = "Katsina", Capital = "Katsina" },
                new State() { Id = 21, Name = "Kebbi", Capital = "Birnin Kebbi" },
                new State() { Id = 22, Name = "Kogi", Capital = "Lokoja" },
                new State() { Id = 23, Name = "Kwara", Capital = "Ilorin" },
                new State() { Id = 24, Name = "Lagos", Capital = "Lagos" },
                new State() { Id = 25, Name = "Nasarawa", Capital = "Lafia" },
                new State() { Id = 26, Name = "Niger", Capital = "Minna" },
                new State() { Id = 27, Name = "Ogun", Capital = "Abeokuta" },
                new State() { Id = 28, Name = "Ondo", Capital = "Akure" },
                new State() { Id = 29, Name = "Osun", Capital = "Osogbo" },
                new State() { Id = 30, Name = "Oyo", Capital = "Ibadan" },
                new State() { Id = 31, Name = "Plateau", Capital = "Jos" },
                new State() { Id = 32, Name = "Rivers", Capital = "Port Harcourt" },
                new State() { Id = 33, Name = "Sokoto", Capital = "Sokoto" },
                new State() { Id = 34, Name = "Taraba", Capital = "Jalingo" },
                new State() { Id = 35, Name = "Yobe", Capital = "Damaturu" },
                new State() { Id = 36, Name = "Zamfara", Capital = "Gusau" }
            };
        }

    }
}
