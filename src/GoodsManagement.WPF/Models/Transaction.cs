public class Transaction
{
    public int TransactionId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime TransactionDate { get; set; }
    public string TransactionType { get; set; } // "Inbound" or "Outbound"
    
    public Transaction(int productId, int quantity, string transactionType)
    {
        ProductId = productId;
        Quantity = quantity;
        TransactionDate = DateTime.Now;
        TransactionType = transactionType;
    }
}