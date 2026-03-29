using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStore.Frontend.Converters;

namespace GameStore.Frontend.Models;

public class OrderDetails
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public int GameId { get; set; }

    public DateTime PurchaseDate { get; set; }

    public int Quantity { get; set; }
    
    public bool IsOrderComplete { get; set; }
}