using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Prodotto
    {
        private string id;
        private string name;
        private string description;
        private string prezzo;
        private string produttore;
        public Prodotto(string id, string name, string description, string prezzo, string produttore){
            this.id = id;
            this.name = name;   
            this.description = description; 
            this.prezzo = prezzo;
            this.produttore = produttore;
        }
        public string ID1
        {
            get { return id; }
            set { id = value; }
        }
        public string nome
        {
            get { return name; }
            set { name = value; }
        }
        public string descrizione
        {
            get { return description; }
            set { description = value; }
        }
        public string price
        {
            get { return prezzo; }
            set { prezzo = value; }
        }
        public string prod
        {
            get { return produttore; }
            set { produttore = value; }
        }
    }
}
