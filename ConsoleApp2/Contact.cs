namespace MyNamespace;

public class Contact
{
    public string Name;
    public string Address;
    public string Phone;

    public Contact(
        string Name,
        string Address,
        string Phone)
    {
        this.Name = Name;
        this.Address = Address;
        this.Phone = Phone;
    }

    public void DisplayContact()
    {   
        Console.WriteLine($"Nome:{Name}\tMorada:{Address}\tTelefone:{Phone}");
    }
}