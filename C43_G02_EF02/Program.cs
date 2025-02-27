using C43_G02_EF02.Data;

namespace C43_G02_EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolDBContext())
            {
                //context.Sutdents.Where(s => s.FName == "Ali").ToList();
            }
        }
    }
}
