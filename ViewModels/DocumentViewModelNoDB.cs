using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.ViewModels
{
    internal class DocumentViewModelNoDB : INotifyPropertyChanged
    {
        private EnTeteDocument _selectedDocument;
        public LignesDocument _selectedLigne { get; set; }
        public ObservableCollection<EnTeteDocument> Documents { get; set; }

        public ObservableCollection<LignesDocument> Lignes { get; set; }

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
                 new EnTeteDocument(1, "Facture", "00001",  DateTime.Parse("05/01/2026"), DateTime.Parse("05/02/2026"), 1563.2, 125.3, 1688.5, 1688.5, "test1", 0, "En cours"),
                 new EnTeteDocument(2, "Facture", "00002",  DateTime.Parse("17/10/2025"), DateTime.Parse("17/11/2025"), 4025.2, 355.3, 4800.5, 0, "test2", 0, "Payée/Validé"),
                 new EnTeteDocument(3, "Facture", "00003",  DateTime.Parse("05/12/2026"), DateTime.Parse("25/01/2026"), 652.5, 60.3, 712.8, 325.1,"test3", 0, "En cours")
            };
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
                if (ligne.IdDocument == _selectedDocument.Id)
                {
                    Lignes.Add(ligne);
                }
            }
        }
       

        
        

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
