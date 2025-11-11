using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado {  get; set; }
        public int  QntAdultos { get; set; }

        public  int QntCrincas { get; set; }

        public DateTime DataCheckin  { get; set; }

        public DateTime DataCheckout { get; set; }

        public int Estadia {
            get => DataCheckout.Subtract(DataCheckin).Days;
                }
        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCrincas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas)* Estadia;
                return total;
            }
        }
    }
}
