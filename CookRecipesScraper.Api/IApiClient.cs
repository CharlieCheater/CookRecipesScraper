namespace CookRecipesScraper.Api;

public interface IApiClient
{
    Task<string> GetIngredientsPageAsync();
    Task<string> GetIngredientPageAsync(string slug);
}
