using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedInterface
{
    public class Invoice : IPayable
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }

        private int _quantity;
        public int Quantity { get => _quantity; set => _quantity = value <= 0 ? throw new ArgumentException("Quantity should be positive or zero") : value; }

        private decimal _pricePerItem;
        public decimal PricePerItem { get => _pricePerItem; set => _pricePerItem = value <= 0 ? throw new ArgumentException("PricePerItem should be positive or zero") : value; }

        public Invoice() { }

        public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }

        public override string ToString() => $"Part Number: {PartNumber} Part Description: {PartDescription}\n" +
            $"Quantity: {Quantity} Price Per Item: {PricePerItem}\n";

        public decimal GetPaymentAmount() => PricePerItem * Quantity;
    }
}

