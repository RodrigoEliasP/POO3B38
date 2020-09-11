using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B38.Models.DTO
{
    public class DTOCDs
    {
        private int id;
        private string nome;
        private double preco;
        private DateTime lancamento;

        public int Id { get => id; set => id = value; }
        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo Email é obrigatório.");
                }
            }
            get { return this.nome; }
        }
        public double Preco {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O campo preco não pode ser menor que zero");
                }
                else
                {
                    this.preco = value;
                }
            }
            get
            {
                return preco;
            }
        }
        public DateTime Lancamento {
            set
            {
                if (value > DateTime.Now || value == DateTime.MinValue)
                {
                    throw new Exception("preencha a data corretamente");
                }
                else
                {
                    this.lancamento = value;
                }
            }
            get
            {
                return this.lancamento;
            }
        }
    }
}