using Carros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        //Console.WriteLine(resposta);
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);
        foreach(var carro in carros)
        {
            Console.WriteLine(carro.Informacoes);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um erro: {ex.Message}");
    }
}
