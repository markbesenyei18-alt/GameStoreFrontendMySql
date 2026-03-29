using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class OrdersClient(HttpClient httpClient)
{
    public async Task<OrderDetails[]> GetOrdersAsync() 
        => await httpClient.GetFromJsonAsync<OrderDetails[]>("orders") ?? [];

    public async Task AddOrderAsync(OrderDetails order)
        => await httpClient.PostAsJsonAsync("orders", order);

    public async Task<OrderDetails> GetOrderAsync(int id)
        => await httpClient.GetFromJsonAsync<OrderDetails>($"orders/{id}")
            ?? throw new Exception("Could not find order!");

    public async Task UpdateOrderAsync(OrderDetails updatedOrder)
        => await httpClient.PutAsJsonAsync($"orders/{updatedOrder.Id}", updatedOrder);

    public async Task DeleteOrderAsync(int id)
        => await httpClient.DeleteAsync($"orders/{id}");
}
