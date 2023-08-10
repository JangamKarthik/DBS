using System;

public class Customer
{
    String name;
    String id;
    String pass;
    int accno;
    int bal;
    String lad;

    public Customer(String name,String id,String pass,int accno,int bal,String lad)
	{
        this.name=name;
        this.id=id;
        this.pass=pass;
        this.accno=accno;
        this.bal=bal;
        this.lad = lad;
	}
}
