using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TestApi.Commands;
using TestApi.Models;
using TestApi.Services;

namespace TestApi.ViewModels
{
    internal class DocumentViewModel : INotifyPropertyChanged
    {
        private readonly DocumentService _documentService = new DocumentService();
        //Porpriété exposée à la vue

        private EnTeteDocument _selectedDocument;
        public EnTeteDocument? SelectedDocument
        {
            get => _selectedDocument;
            set
            {
                _selectedDocument = value;
                OnPropertyChanged(nameof(SelectedDocument));
            }
        }
        public ObservableCollection<EnTeteDocument> Documents { get; set; } = new ObservableCollection<EnTeteDocument>();
        
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
                MessageBox.Show($"Erreur lors du chargement des documents : {ex.Message}");
            }
        }
       
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        
    }
}
