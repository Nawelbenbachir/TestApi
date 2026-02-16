using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using TestApi.Services;
using TestApi.Models;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;
using System.Windows.Input;
using TestApi.Commands;

namespace TestApi.ViewModels
{
    internal class DocumentViewModel
    {
        private readonly DocumentService _documentService = new DocumentService();
        //Porpriété exposée à la vue
        public ObservableCollection<Document> Documents { get; set; } = new ObservableCollection<Document>();
        public Document? SelectedDocument { get; set; }
        public ICommand LoadCommand { get; }
        public ICommand AddCommand { get; }
        public DocumentViewModel()
        {
            LoadCommand = new RelayCommand(async _ => await LoadDocuments());
            _=LoadDocuments();
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private async Task LoadDocuments()
        {
            try
            {
                var documents = await _documentService.GetDocuments();
                Documents.Clear();
                foreach (var document in documents)
                {
                    Documents.Add(document);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des artistes : {ex.Message}");
            }
        }
    }
}
