namespace CleanArchitectureTemplate.Persistence
{
    public class DataInitializer
    {
        public static void Initialize(PersonDbcontext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }

    }
}
