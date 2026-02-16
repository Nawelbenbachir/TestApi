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
        public int id { get; set; }
        public string type{ get; set; }
        public string code_document { get; set; }
        public DateTime date { get; set; }
        public DateTime? date_echeance { get; set; }
        public DateTime? date_validite { get; set; }
       
        public Double total_tva { get; set; }
        public Double total_ttc { get; set; }
        public Double total_ht { get; set; }

        public Double solde { get; set; }
        public string commentaire { get; set; }

        public Client Client { get; set; }
        public Societe Societe { get; set; }
        public string statut { get; set; }
        

        public EnTeteDocument(int id, string type, string numero, DateTime date, DateTime dateecheancevalidite, 
             double totaltva, double totalttc, double totalht, double solde, 
            string commentaire,Client client, Societe societe, string statut)
        {
            id = id; 
            type = type; 
            code_document = numero;
            date = date; 
            date_echeance = dateecheancevalidite;
            date_validite = dateecheancevalidite;
            total_tva = totaltva; 
            total_ttc = totalttc; 
            total_ht = totalht; 
            solde = solde; 
            commentaire = commentaire;
            Client = client;
            Societe = societe;
            statut = statut; 
            
        }
        public EnTeteDocument(string numero)
        {
            code_document = numero;
        }
        public EnTeteDocument() { }






    }
}
