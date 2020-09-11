using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POO3B38.Models.DTO
{
    public class DTOMusicas
    {
        private int id;
        private string nome;
        private string nomeAutor;
        private int idGravadora;
        private int idCd;

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
                    throw new Exception("O campo Nome é obrigatório.");
                }
            }
            get { return this.nome; }
        }
        public string NomeAutor
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeAutor = value;
                }
                else
                {
                    throw new Exception("O campo Nome Autor é obrigatório.");
                }
            }
            get { return this.nomeAutor; }
        }

        public int IdGravadora { get => idGravadora; set => idGravadora = value; }
        public int IdCd { get => idCd; set => idCd = value; }
    }
}