using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using POO3B38.Models.DTO;
using POO3B38.Models.DAL;

namespace POO3B38.Models.BLL
{
    public class BLLMusicas
    {
        private DALGravadora daoBd = new DALGravadora();

        public DataTable listarMusicas()
        {
            string sql = string.Format($@"select * from tbl_musica;");
            return daoBd.ExecutarConsulta(sql);
        }
        public void inserirMusica(DTOMusicas data)
        {
            string sql = string.Format($@"insert into tbl_musica values(NULL, '{data.Nome}', '{data.NomeAutor}', '{data.IdGravadora}', '{data.IdCd}');");
            daoBd.executarComando(sql);
        }
        public void deletarMusica(DTOMusicas data)
        {
            string sql = string.Format($@"delete from tbl_musica where idMusica = '{data.Id}' limit 1;");
            daoBd.executarComando(sql);
        }
        public void atualizarMusica(DTOMusicas data)
        {
            string sql = string.Format($@"update tbl_musica set nome = '{data.Nome}', nomeAutor = '{data.NomeAutor}', idGravadora = '{data.IdGravadora}', idCd = '{data.IdCd}'  where idMusica = '{data.Id}' limit 1;");
            daoBd.executarComando(sql);
        }
    }
}