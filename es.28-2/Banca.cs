using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace es._28_2
{
    public class Banca
    {
        public string Nome { get; set; }
        
        public System.Collections.Generic.List<es._28_2.Cliente> Clienti { get; set; }
        
        public System.Collections.Generic.List<Prestito> Prestiti { get; set; }

        public Banca(string nome)
        {
            this.Nome = nome;
        }

        public void AggiungiCliente(Cliente clienteDaAggiungere)
        {
            if (CercaCliente(clienteDaAggiungere) == true)
            {
                throw new Exception("Il cliente è gia nella lista");
            }
            Clienti.Add(clienteDaAggiungere);
        }

        public void ModificaCliente(Cliente clienteDaModificare, Cliente nuovoCliente)
        {
            int indiceCliente = Clienti.IndexOf(clienteDaModificare);
            if (indiceCliente == -1)
            {
                throw new Exception("Il cliente da modificare non è nella lista");
            }
            Clienti[indiceCliente] = nuovoCliente;
        }

        public void EliminaCliente(Cliente clienteDaEliminare)
        {
            if (CercaCliente(clienteDaEliminare) == false)
            {
                throw new Exception("Il cliente da eliminare non è nella lista");
            }
            Clienti.Remove(clienteDaEliminare);
        }

        public bool CercaCliente(Cliente clienteDaTrovare)
        {
            if (Clienti.IndexOf(clienteDaTrovare) != -1)
            {
                return true;
            }
            return false;
        }

        public void AggiungiPrestito(Prestito prestitoDaAggiungere)
        {
            if (Prestiti.Contains(prestitoDaAggiungere) == true)
            {
                throw new Exception("Il prestito è gia nella lista");
            }
            Prestiti.Add(prestitoDaAggiungere);
        }

        public List<Prestito> CercaPrestito(string codiceFiscaleCliente)
        {
            var prestitiCliente = new List<Prestito>();
            foreach (var prestito in this.Prestiti)
            {
                if (prestito.Intestatario.CodiceFiscale == codiceFiscaleCliente)
                {
                    prestitiCliente.Add(prestito);
                }
            }

            return prestitiCliente;
        }

        public double AmmontareTotaleCliente(string codiceFiscaleCliente)
        {
            double ammTotale = 0;
            foreach (var prestito in this.Prestiti)
            {
                if (prestito.Intestatario.CodiceFiscale == codiceFiscaleCliente)
                {
                    ammTotale += prestito.Ammontare;
                }
            }

            return ammTotale;
        }
    }
}