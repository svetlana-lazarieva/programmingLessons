using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class ReceiptData
    {
        public string UserName { get; set; }
        public string TimeOfPurchase { get; set; }
        public List<Product> PurchasedOrders { get; set; }
        public string Summ { get; set; }
    }
    public class Receipt
    {
        protected const string FilePath = "Temp//Receipt.txt";

        public void CreateReceipt(ReceiptData receiptData)
        {
            string receipt = string.Empty;
            receipt += $"Покупатель: {receiptData.UserName} Дата покупки: {receiptData.TimeOfPurchase} {Environment.NewLine}";

            foreach (var product in receiptData.PurchasedOrders)
            {
                receipt += $"Товар: {product.productName} Стоимость: {product.productPrice} грн {Environment.NewLine}";
            }

            receipt += $"{receiptData.Summ}";

            if (!Directory.Exists("Temp"))
            {
                Directory.CreateDirectory("Temp");
            }

            File.WriteAllText(FilePath, receipt);
            Process.Start("notepad.exe", FilePath);
        }
    }
}
