using Livros;

using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");

        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta);
        foreach(var livro in livros)
        {
            Console.WriteLine(livro.Informacoes);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Parece que ocorreu um erro: {ex.Message}");
    }
}
