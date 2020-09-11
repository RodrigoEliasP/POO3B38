using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using POO3B38.Models.DTO;
using POO3B38.Models.DAL;

namespace POO3B38.Models.BLL
{
    public class BLLCDs
    {
        private DALGravadora daoBd = new DALGravadora();

        public DataTable listarCDs()
        {
            string sql = string.Format($@"select * from tbl_cd;");
            return daoBd.ExecutarConsulta(sql);
        }
        public void inserirCd(DTOCDs data)
        {
            string sql = string.Format($@"insert into tbl_cd values(NULL, '{data.Nome}', '{data.Preco}', '{data.Lancamento:yyyy/MM/dd}');");
            daoBd.executarComando(sql);
        }
    }
}