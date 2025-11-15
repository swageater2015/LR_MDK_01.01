using System;

class Sale
{
    public DateTime Date;      
    public string PhoneName;   
    public int Quantity;      
    public decimal Price;   

    public Sale(DateTime date, string phoneName, int quantity, decimal price)
    {
        Date = date;
        PhoneName = phoneName;
        Quantity = quantity;
        Price = price;
    }
}