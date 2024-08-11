namespace DockerHelloWorld;

public sealed class Customer {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public override string ToString() => string.Format("Id => {0} Name => {1}", Id, Name);
}