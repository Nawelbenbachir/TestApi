using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace TestApi.Models
{
    public class EnTeteDocument
    {
        public int id { get; set; }
        public string type{ get; set; }
        [JsonPropertyName("numero")]
        public string code_document { get; set; }
        public DateTime date { get; set; }
        public DateTime? date_echeance { get; set; }
        public DateTime? date_validite { get; set; }
       
        public Double total_tva { get; set; }
        public Double total_ttc { get; set; }
        public Double total_ht { get; set; }

        public Double solde { get; set; }
        public string commentaire { get; set; }

        public Client client { get; set; }
        public Societe societe { get; set; }
        public string statut { get; set; }
        

        public EnTeteDocument(int id, string type, string numero, DateTime date, DateTime dateecheancevalidite, 
             double totaltva, double totalttc, double totalht, double solde, 
            string commentaire,Client client, Societe societe, string statut)
        {
            this.id = id;
            this.type = type;
            this.code_document = numero;
            this.date = date;
            this.date_echeance = dateecheancevalidite;
            this.date_validite = dateecheancevalidite;
            this.total_tva = totaltva;
            this.total_ttc = totalttc;
            this.total_ht = totalht;
            this.solde = solde;
            this.commentaire = commentaire;
            this.client = client;
            this.societe = societe;
            this.statut = statut; 
            
        }
        public EnTeteDocument(string numero)
        {
            code_document = numero;
        }
        public EnTeteDocument() 
        {
        }
    }
}
