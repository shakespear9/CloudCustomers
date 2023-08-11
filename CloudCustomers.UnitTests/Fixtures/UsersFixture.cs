using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new List<User>
        {
            new User
            {
                Id = 1,
                Name = "John Doe",
                Email = "john@example.com",
                Address = new Address
                {
                    ZipCode = "12345",
                    City = "Anytown",
                    Street = "123 Main St"
                }
            },
            new User
            {
                Id = 2,
                Name = "Jane Smith",
                Email = "jane@example.com",
                Address = new Address
                {
                    ZipCode = "67890",
                    City = "Otherville",
                    Street = "456 Elm St"
                }
            },
            new User
            {
                Id = 3,
                Name = "Geralt Rivia",
                Email = "geralt@example.com",
                Address = new Address
                {
                    ZipCode = "34145",
                    City = "Oppenheim",
                    Street = "123 asd St"
                }
            },
        };
    }
}
