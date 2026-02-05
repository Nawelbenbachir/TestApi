using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Models
{
    internal class LignesDocument
    {
        public int IdDocument { get; set; }
        public string Description { get; set; }

        public string CodeProduit { get; set; }
        public Double Quantite { get; set; }
        public Double PrixUnitaire { get; set; }
        public Double TauxTva { get; set; }
        public Double TotalHt { get; set; }
        public Double TotalTva { get; set; }
        public Double TotalTtc { get; set; }

        public LignesDocument(int idDocument, string description, string codeProduit, double quantite, double prixUnitaire, double tauxTva, double totalHt,
            double totalTva, double totalTtc)
        {
            IdDocument = idDocument;
            Description = description;
            CodeProduit = codeProduit;
            Quantite = quantite;
            PrixUnitaire = prixUnitaire;
            TauxTva = tauxTva;
            TotalHt = totalHt;
            TotalTva = totalTva;
            TotalTtc = totalTtc;
        }

    }
}
