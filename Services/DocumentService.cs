using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Services
{
    internal class DocumentService
    {
        private readonly HttpClient _httpClient;

        public DocumentService()
        {
            //_httpClient = new HttpClient { BaseAddress = new Uri("http://api.example.com/") };

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://127.0.0.1:8000/api/documents");
        }

        public async Task<List<EnTeteDocument>> GetDocuments()
        {
            //Appel asynchrone à l'API pour récup&rer la liste des documents
            var response = await _httpClient.GetAsync("http://127.0.0.1:8000/api/documents");
            //Vérification que l'appel à réussi (200-299)
            response.EnsureSuccessStatusCode();
            //Extraire la liste des documents du contenu de la réponse en utilisant la déserialisation JSON
            var documents= await response.Content.ReadFromJsonAsync<List<EnTeteDocument>>();
            return documents;
        }
    }
}
