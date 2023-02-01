using CookRecipesScraper.Api;

ApiClient client = new ApiClient();
var ingredientsPage = await client.GetIngredientsPageAsync();
Console.WriteLine(ingredientsPage);
