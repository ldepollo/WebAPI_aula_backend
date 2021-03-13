using System;
using System.Collections.Generic;
using System.Text;
namespace Imobiliaria.Models
{
    public class Imovel
    {
        public int Id { get; set; }
        public int Tipo { get; set; } // Enum
        public double Preco { get; set; }
        public double Premio { get; set; }
        public string Bairro { get; set; } // Classe endereco
        public string Cep { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
    }
}
