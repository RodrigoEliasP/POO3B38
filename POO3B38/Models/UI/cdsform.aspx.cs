using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using POO3B38.Models.DTO;
using POO3B38.Models.BLL;

namespace POO3B38.Models.UI
{
    public partial class cdsform : System.Web.UI.Page
    {
        private BLLCDs bll = new BLLCDs();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadGrid();
            }
        }

        protected void loadGrid()
        {
            GridCds.DataSource = bll.listarCDs();
            GridCds.DataBind();
        }
        protected void limparCampos()
        {
            txtNome.Text = "";
            txtPreco.Text = "";

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                DTOCDs dto = new DTOCDs();

                dto.Nome = txtNome.Text;
                dto.Preco = Convert.ToDouble(txtPreco.Text);
                dto.Lancamento = calLancamento.SelectedDate;

                bll.inserirCd(dto);
                
                loadGrid();
                limparCampos();
            }
            catch (FormatException ex)
            {
                lblError.Text = "Preencha o campo preço corretamente";

            }catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}