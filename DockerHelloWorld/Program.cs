namespace DockerHelloWorld;

internal class Program {
    static void Main(string[] args) {
        var customers = new[] {
                new Customer {
                    Id = 1,
                    Name = "DragonicK"
                },
                new Customer {
                    Id = 2,
                    Name = "Sereste"
                }
            };

        var list = new CustomerList();

        list.AddRange(customers);

        var s = list.Find(x => x.Id == 1);

        list.ForEach(x => x.Id = 999);

        list.ForEach(x => Console.WriteLine(x));

        foreach (var customer in customers) {
            Console.WriteLine(customer.Name);
        }
    }
}