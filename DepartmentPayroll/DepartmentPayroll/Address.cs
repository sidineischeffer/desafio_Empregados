public class Address
{
    public string email { get; set; }
    public string phone { get; set; }

    public Address()
    {
    }

    public Address(string emails, string phones)
    {
        email = emails;
        phone = phones;
    }
}