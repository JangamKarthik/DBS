using System;

public class Customer
{
    public string Name { get; set; }
    public string ID { get; set; }
    public string Password { get; set; }
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public DateTime LastAccessDate { get; set; }

    public Customer(string name, string id, string password, int accountNumber, decimal balance, DateTime lastAccessDate)
    {
        Name = name;
        ID = id;
        Password = password;
        AccountNumber = accountNumber;
        Balance = balance;
        LastAccessDate = lastAccessDate;
    }
}
