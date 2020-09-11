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
        private BLLMusicas bll = new BLLMusicas();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadGrid();
            }
        }

        protected void loadGrid()
        {
            GridCds.DataSource = bll.listarMusicas();
            GridCds.DataBind();
        }
        protected void limparCampos()
        {
            txtNome.Text = "";
            txtAutor.Text = "";
            txtGravadora.Text = "";
            txtCd.Text = "";

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                DTOMusicas dto = new DTOMusicas();

                dto.Nome = txtNome.Text;
                dto.NomeAutor = txtAutor.Text;
                dto.IdGravadora = Convert.ToInt32(txtGravadora.Text);
                dto.IdCd = Convert.ToInt32(txtCd.Text);

                bll.inserirMusica(dto);
                
                loadGrid();
                limparCampos();

                lblWarn.ForeColor = System.Drawing.Color.Green;
                lblWarn.Text = "Musica inserida corremente";
            }
            catch (FormatException ex)
            {
                lblWarn.ForeColor = System.Drawing.Color.Red;
                lblWarn.Text = "Preencha os campo de id corretamente";

            }catch (Exception ex)
            {
                lblWarn.ForeColor = System.Drawing.Color.Red;
                lblWarn.Text = ex.Message;
            }
        }

        protected void GridCds_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DTOMusicas dto = new DTOMusicas();

            dto.Id = Convert.ToInt32(e.Values[0].ToString());

            bll.deletarMusica(dto);

            loadGrid();

            lblWarn.ForeColor = System.Drawing.Color.Green;
            lblWarn.Text = "Musica deletada corremente";
        }

        protected void GridCds_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridCds.EditIndex = e.NewEditIndex;
            loadGrid();
        }

        protected void GridCds_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridCds.EditIndex = -1;
            loadGrid();
        }

        protected void GridCds_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                DTOMusicas dto = new DTOMusicas();
                dto.Id = Convert.ToInt32(e.NewValues[0].ToString());
                dto.Nome = e.NewValues[1].ToString();
                dto.NomeAutor = e.NewValues[2].ToString();
                dto.IdGravadora = Convert.ToInt32(e.NewValues[3].ToString());
                dto.IdCd = Convert.ToInt32(e.NewValues[4].ToString());
                
                bll.atualizarMusica(dto);
                GridCds.EditIndex = -1;
                loadGrid();

                lblWarn.ForeColor = System.Drawing.Color.Green;
                lblWarn.Text = "Musica atualizada corremente";
            }
            catch (FormatException ex)
            {
                lblWarn.ForeColor = System.Drawing.Color.Red;
                lblWarn.Text = "Preencha os campo de id corretamente";

            }catch (Exception ex)
            {
                lblWarn.Text = ex.Message;
                lblWarn.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}