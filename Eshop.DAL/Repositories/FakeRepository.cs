using Bogus;

namespace Eshop.DAL.Repositories
{
    //https://github.com/bchavez/Bogus

    public class GoodsRepository
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
    }

    public class FakeRepository
    {
        public IEnumerable<GoodsRepository> GetDataAsync()
        {
            //in progress
            Randomizer.Seed = new Random(10000);

            var clothes = new[] {"dress", "Ts-shirt", "skirt", "trousers", "sweater"};
            var orderId = 0;
            var testGetAllAsync = new Faker<GoodsRepository>()
                .StrictMode(true)
                .RuleFor(o => o.Id, f => orderId++)
                .RuleFor(o => o.Name, f => f.Name.FirstName())
                .RuleFor(o => o.Description, f => f.Commerce.ProductAdjective());

            var items = testGetAllAsync.Generate(10);
            return items.AsEnumerable();
        }

        public IEnumerable<GoodsRepository> GetDataById()
        {
            var faker = new Faker<GoodsRepository>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Name, f => f.Name.FirstName())
                .RuleFor(o => o.Description, f => f.Commerce.ProductAdjective());

            var items = faker.Generate(10);
            return items.AsEnumerable();
        }

        public IEnumerable<GoodsRepository> CreateData()
        {
            var faker = new Faker<GoodsRepository>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Name, f => f.Name.FirstName())
                .RuleFor(o => o.Description, f => f.Commerce.ProductAdjective());

            var items = faker.Generate(10);
            return items.AsEnumerable();
        }

        public IEnumerable<GoodsRepository> UpdateData()
        {
            var faker = new Faker<GoodsRepository>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Name, f => f.Name.FirstName())
                .RuleFor(o => o.Description, f => f.Commerce.ProductAdjective());

            var items = faker.Generate(10);
            return items.AsEnumerable();
        }

        public IEnumerable<GoodsRepository> DeleteDataById()
        {
            var faker = new Faker<GoodsRepository>()
                .RuleFor(o => o.Id, f => f.UniqueIndex)
                .RuleFor(o => o.Name, f => f.Name.FirstName())
                .RuleFor(o => o.Description, f => f.Commerce.ProductAdjective());

            var items = faker.Generate(10);
            return items.AsEnumerable();
        }
    }
}