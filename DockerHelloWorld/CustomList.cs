namespace DockerHelloWorld;

public sealed class CustomerList {
    private readonly List<Customer> _customers = [];

    public void Add(Customer customer) {
        _customers.Add(customer);
    }

    public void AddRange(IEnumerable<Customer> customers) {
        _customers.AddRange(customers);
    }

    public void ForEach(Action<Customer> action) {
        foreach (var customer in _customers) {
            action(customer);
        }
    }

    public Customer? Find(Func<Customer, bool> func) {
        foreach (var customer in _customers) {
            if (func(customer)) {
                return customer;
            }
        }

        return null;
    }

    public IEnumerator<Customer> GetEnumerator() => _customers.GetEnumerator();
}