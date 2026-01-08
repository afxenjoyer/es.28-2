using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace es._28_2
{
    public class Cliente
    {
        public string Nome { get; set; }
        
        public string Cognome { get; set; }
        
        public string CodiceFiscale { get; set; }
        
        public double Stipendio { get; set; }

        public Cliente(string nome, string cognome, string codiceFiscale, double stipendio)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.CodiceFiscale = codiceFiscale;
            this.Stipendio = stipendio;
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome} {CodiceFiscale}:{Stipendio:0.00}";
        }
    }
}