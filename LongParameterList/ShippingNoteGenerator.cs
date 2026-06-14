namespace LongParameterList;

public class ShippingNoteGenerator
{
    public string GenerateShippingNote(
        string customerFirstName,
        string customerLastName,

        string addressLine1,
        string addressLine2,
        string city,
        string postcode,
        string country,

        string orderId,
        string itemDescription,
        int quantity
    )
    {
        string fullName = customerFirstName + " " + customerLastName;

        string address = addressLine1 + ", "
                                      + (addressLine2 != null ? addressLine2 + ", " : "")
                                      + city + ", "
                                      + postcode + ", "
                                      + country;

        return "SHIPPING NOTE\n"
               + "Order: " + orderId + "\n"
               + "Customer: " + fullName + "\n"
               + "Ship To: " + address + "\n"
               + "Item: " + itemDescription + "\n"
               + "Quantity: " + quantity;
    }
}