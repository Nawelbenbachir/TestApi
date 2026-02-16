using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class Client
    {
        public int id { get; set; }
        public string nom { get; set; }

        public Client()
        {

        }
        public Client(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }
    }


}
