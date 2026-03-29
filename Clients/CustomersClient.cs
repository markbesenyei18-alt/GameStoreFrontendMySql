using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class CustomersClient(HttpClient httpClient)
{
    public async Task<CustomerDetails[]> GetCustomersAsync() 
        => await httpClient.GetFromJsonAsync<CustomerDetails[]>("customers") ?? [];

    public async Task AddCustomerAsync(CustomerDetails customer)
        => await httpClient.PostAsJsonAsync("customers", customer);

    public async Task<CustomerDetails> GetCustomerAsync(int id)
        => await httpClient.GetFromJsonAsync<CustomerDetails>($"customers/{id}")
            ?? throw new Exception("Could not find customer!");

    public async Task UpdateCustomerAsync(CustomerDetails updatedCustomer)
        => await httpClient.PutAsJsonAsync($"customers/{updatedCustomer.Id}", updatedCustomer);

    public async Task DeleteCustomerAsync(int id)
        => await httpClient.DeleteAsync($"customers/{id}");
}
