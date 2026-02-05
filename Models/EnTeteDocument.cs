using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace TestApi.Models
{
    internal class EnTeteDocument
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Numero { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateEcheanceValidite { get; set; }
       
        public Double TotalTva { get; set; }
        public Double TotalTtc { get; set; }
        public Double TotalHt { get; set; }

        public Double Solde { get; set; }
        public string Commentaire { get; set; }

        public int IdClient { get; set; }
        public string Statut { get; set; }
        

        public EnTeteDocument(int id, string type, string numero, DateTime date, DateTime dateecheancevalidite, 
             double totaltva, double totalttc, double totalht, double solde, 
            string commentaire,int idclient, string statut)
        {
            Id = id; 
            Type = type; 
            Numero = numero;
            Date = date; 
            DateEcheanceValidite = dateecheancevalidite; 
            TotalTva = totaltva; 
            TotalTtc = totalttc; 
            TotalHt = totalht; 
            Solde = solde; 
            Commentaire = commentaire; 
            IdClient = idclient; 
            Statut = statut; 
            
        }






    }
}
