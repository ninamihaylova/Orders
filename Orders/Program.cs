﻿class Program
{
    static void Main()
    {
        
        string product = Console.ReadLine();

       
        int quantity = int.Parse(Console.ReadLine());

        CalculateTotalPrice(product, quantity);
    }

    static void CalculateTotalPrice(string product, int quantity)
    {
        double price = 0;

        switch (product.ToLower())
        {
            case "coffee":
                price = 1.50;
                break;
            case "water":
                price = 1.00;
                break;
            case "coke":
                price = 1.40;
                break;
            case "snacks":
                price = 2.00;
                break;
           
        }

        double totalPrice = price * quantity;
        Console.WriteLine($"{totalPrice:F2}");
    }
}