using CookRecipesScraper.Api.Globals;

namespace CookRecipesScraper.Api;

public class ApiClient : IDisposable
{
    private bool _disposed;
    protected HttpClient Client { get; } = null!;

	public ApiClient()
	{
        Client = new HttpClient()
        {
            BaseAddress = new Uri(ApiConstants.BaseAddress)
        };
	}
    public async Task<string> GetIngredientsPageAsync()
    {
        return await Client.GetStringAsync(ApiConstants.Ingredients);
    }
    public virtual void Dispose(bool disposing)
    {
        if (!this._disposed)
        {
            if (disposing)
            {
                Client.Dispose();
            }
            this._disposed = true;
        }
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}