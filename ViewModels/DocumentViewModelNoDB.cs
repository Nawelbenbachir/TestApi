using System.Collections.ObjectModel;
using System.ComponentModel;
using TestApi.Commands;
using System.Runtime.CompilerServices;
using TestApi.Models;
using System.Windows.Input;

namespace TestApi.ViewModels
{
    internal class DocumentViewModelNoDB : INotifyPropertyChanged
    {
        private EnTeteDocument _selectedDocument;
        public LignesDocument _selectedLigne { get; set; }
        public ObservableCollection<EnTeteDocument> Documents { get; set; }

        public ObservableCollection<LignesDocument> Lignes { get; set; }

        public ICommand AjouterCommand { get; set; }
        public ICommand SupprimerCommand { get; set; }


        public EnTeteDocument SelectedDocument
        {
            get { return _selectedDocument; }
            set
            {
                _selectedDocument = value;
                OnPropertyChanged(nameof(SelectedDocument));
                ChargerLignes();

            }
        }
        


        public DocumentViewModelNoDB()
        {
            Lignes = new ObservableCollection<LignesDocument>();
            Documents = new ObservableCollection<EnTeteDocument>
            {
                new EnTeteDocument
                {
                    id = 1,
                    type = "Facture",
                    code_document = "00001",
                    date = DateTime.Parse("05/01/2026"),
                    date_echeance = DateTime.Parse("05/02/2026"),
                    total_ht = 1563.2,
                    total_tva = 125.3,
                    total_ttc = 1688.5,
                    solde = 1688.5,
                    commentaire = "test1",
                    Client = null,
                    Societe = null,
                    statut = "En cours"
                },
                new EnTeteDocument
                {
                    id = 2,
                    type = "Facture",
                    code_document = "00002",
                    date = DateTime.Parse("17/10/2025"),
                    date_echeance = DateTime.Parse("17/11/2025"),
                    total_ht = 4025.2,
                    total_tva = 355.3,
                    total_ttc = 4800.5,
                    solde = 0,
                    commentaire = "test2",
                    Client = null,
                    Societe = null,
                    statut = "Payée/Validé"
                },
                new EnTeteDocument
                {
                    id = 3,
                    type = "Facture",
                    code_document = "00003",
                    date = DateTime.Parse("05/12/2026"),
                    date_echeance = DateTime.Parse("25/01/2026"),
                    total_ht = 652.5,
                    total_tva = 60.3,
                    total_ttc = 712.8,
                    solde = 325.1,
                    commentaire = "test3",
                    Client = null,
                    Societe = null,
                    statut = "En cours"
                }
            };
            AjouterCommand = new RelayCommand(AjouterDocument);
            SupprimerCommand = new RelayCommand(SupprimerDocument);
        }
        public void ChargerLignes()
        {
            //On vide les lignes du document sélectionné 
            Lignes.Clear();
            var LignesDocuments= new List<LignesDocument>
            {
                new LignesDocument(1,1, "Description 1", "P001", 2, 100, 20, 200, 40, 240),
                new LignesDocument(2,1,"Test", "P005", 2, 100, 20, 200, 40, 240),
                new LignesDocument(3,2, "Description 2", "P002", 1, 300, 20, 300, 60, 360),
                new LignesDocument(4,2, "Description 3", "P003", 5, 50, 20, 250, 50, 300),
                new LignesDocument(5,3, "Description 4", "P004", 3, 150, 20, 450, 90, 540),
                new LignesDocument(6,3, "Test", "P006", 3, 150, 20, 450, 90, 540)
            };
            //On ajoute les lignes correspondantes au document sélectionné
            foreach (var ligne in LignesDocuments)
            {
                if (ligne.IdDocument == _selectedDocument.id)
                {
                    Lignes.Add(ligne);
                }
            }
        }

     
        private void AjouterDocument(object parameter)
        {
            var newDocument = new EnTeteDocument("00004");
            Documents.Add(newDocument);
            _selectedDocument = newDocument;
        }

        private void SupprimerDocument(object parameter)
        {
            Documents.Remove(_selectedDocument);
            _selectedDocument = null;

        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
