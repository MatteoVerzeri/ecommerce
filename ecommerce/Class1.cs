using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    internal class Carrello
    {
        private string id;
        private Prodotto[] carrello;
        
        private int a;
        public Carrello(string id){
            this.id = id;
            carrello = new Prodotto[100];
            
            a = 0;
        }
        public string ID
        {
            get { return id; }
            private set { id = value; }
        }
        public void aggiungiProdotto(Prodotto prodotto)
        {
            carrello[a] = prodotto;
            a++;
        }
        public void rimuovi(Prodotto prodotto)
        {
           int pos=cercaprodotto(prodotto);
            if (pos != -1)
            {
                for(int i=pos; i<a-1; i++)
                {
                     carrello[i] = carrello[i + 1];
                }
            }
            else
            {
                throw new Exception("prodotto non trovato");
            }
            
        }
        public int cercaprodotto (Prodotto prodotto){
            for(int i=0; i<a; i++)
            {
                if (prodotto.ID1 == carrello[a].ID1)
                {
                    return a;
                }
            }
            return -1;
        }
        public void svuota()
        {
          
            for(int i=0; i<a; i++)
            {
               
               carrello[i] = null;
                
            }
        }
        
    }
}
