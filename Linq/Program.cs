using Linq.Service;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            ILinqService service = new LinqService();
            service.JoinLists();
        }
    }
}
