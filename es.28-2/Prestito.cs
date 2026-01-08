using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace es._28_2
{
    public class Prestito
    {
        public Cliente Intestatario { get; set; }
        
        public double Ammontare { get; set; }
        
        public double Rata { get; set; }
        
        public System.DateTime DataInizio { get; set; }
        
        public System.DateTime DataFine { get; set; }

        public Prestito(Cliente intestatario, double ammontare, double rata, DateTime dataInizio, DateTime dataFine)
        {
            this.Intestatario = intestatario;
            this.Ammontare = ammontare;
            this.Rata = rata;
            this.DataInizio = dataInizio;
            this.DataFine = dataFine;
        }

        public override string ToString()
        {
            return $"{Intestatario}:\n {Ammontare:0.00} {Rata:0.00}% {DataInizio:d} - {DataFine:d}";
        }
    }
}