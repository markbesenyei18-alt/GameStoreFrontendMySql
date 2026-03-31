using System;
using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class Film_castClients(HttpClient httpClient)
{
    public async Task<Film_castDetails[]> GetFilmekAsync() 
        => await httpClient.GetFromJsonAsync<Film_castDetails[]>("Film_cast") ?? [];

    public async Task AddFilmAsync(Film_castDetails film)
        => await httpClient.PostAsJsonAsync("Film_cast", film);

    public async Task<Film_castDetails> GetFilmAsync(int id)
        => await httpClient.GetFromJsonAsync<Film_castDetails>($"Film_cast/{id}")
            ?? throw new Exception("Could not find film!");

    public async Task UpdateFilmAsync(Film_castDetails updatedFilm)
        => await httpClient.PutAsJsonAsync($"Film_cast/{updatedFilm.id}", updatedFilm);

    public async Task DeleteFilmAsync(int id)
        => await httpClient.DeleteAsync($"Film_cast/{id}");
}

