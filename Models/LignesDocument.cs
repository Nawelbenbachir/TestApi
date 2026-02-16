using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class LignesDocument
    {
        public int Id { get; set; }
        public int IdDocument { get; set; }
        public string Description { get; set; }

        public string CodeProduit { get; set; }
        public Double Quantite { get; set; }
        public Double PrixUnitaire { get; set; }
        public Double TauxTva { get; set; }
        public Double TotalHt { get; set; }
        public Double TotalTva { get; set; }
        public Double TotalTtc { get; set; }

        public LignesDocument( int id,int idDocument, string description, string codeProduit, double quantite, double prixUnitaire, double tauxTva, double totalHt,
            double totalTva, double totalTtc)
        {
            this.Id = id;
            this.IdDocument = idDocument;
            this.Description = description;
            this.CodeProduit = codeProduit;
            this.Quantite = quantite;
            this.PrixUnitaire = prixUnitaire;
            this.TauxTva = tauxTva;
            this.TotalHt = totalHt;
            this.TotalTva = totalTva;
            this.TotalTtc = totalTtc;
        }

    }
}
