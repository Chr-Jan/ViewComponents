using ViewComponents.Models;

namespace ViewComponents.Data
{
    public class SeedData
    {
        // Define seed data for a human
        public static Human GetSeedHuman()
        {
            return new Human { Name = "John", Age = 25 };
        }
    }
}
