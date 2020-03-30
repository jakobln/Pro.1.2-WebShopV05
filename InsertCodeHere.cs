using System;
#pragma warning disable 219

namespace WebShopV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;
            double tax = 1.10;
            double cardFee = 1.02;
            int shippingCost = 49;

            int noOfBooksInOrder = 23;
            int noOfDVDsInOrder = 16;
            int noOfGamesInOrder = 7;

            double totalPrice = netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder; // This variable should contain the total price for the order
            double totalPriceWithTax = totalPrice * tax; 
            double totalPriceWithShippingCost = totalPriceWithTax + shippingCost; // Including tax
            double totalPriceWithCardFee = totalPriceWithShippingCost * cardFee; // Including tax and shipping
            double totalPriceFinal = totalPriceWithCardFee; // Including tax, shipping and credit card fee

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPriceFinal} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}