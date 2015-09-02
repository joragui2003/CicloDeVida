using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
   
    //protected override void OnPreInit(EventArgs e)
    //{
    //    //Este es el evento que podemos manejar, para poner un master page,
    //    // o para crear controles dinamicos
    //    lblInfo.Text += "Evento Page.PreInit <br />";
    //}
    private void Page_Init(Object sender, System.EventArgs e)
    {
        //Este se dispara despues de que los controles han sido creados
        //Aqui podemos cambiar los valores de inicio de los controles
        lblInfo.Text += "Evento Page.Init <br />";
    }

    //protected override void OnInit(EventArgs e)
    //{
    //    //Este se dispara despues de que los controles han sido creados
    //    //Aqui podemos cambiar los valores de inicio de los controles
    //    lblInfo.Text += "Evento Page.Init <br />";
    //}

    protected void Page_Load(object sender, EventArgs e)
    {
        //La pagina esta creada, en este evento se puede checar 
        //Si es postback o se pidio la pagina
        lblInfo.Text += "Evento.Page.Load";
        if (IsPostBack)
        {
            lblInfo.Text += "<br>Esta no es la primera vez que se carga la pagina";
        }
        else
        {
            lblInfo.Text += "<br />Bien, esta es la pagina que solicitaste. <br /> <br />";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Se ejecutan los eventos de los controles
        //Que se disparen en la pagina
        lblInfo.Text += "Evento Button1_Click<br />";
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        //Este evento se dispara antes de guardar el Viewstate
        //podemos hacer cambios al estado y se guardara.
        lblInfo.Text += "Evento Page.PreRender <hr />";
    }
    protected void Page_Unload(object sender, EventArgs e)
    {
        //Este texto nuca se ve porque el html ya se pinto en la pagina
        //Este evento se usa para liberar recursos en el servidor.
        lblInfo.Text += "Evento Page.Unload <br />";
    }
    private void Page_PreInit(Object sender, System.EventArgs e)
    {
        //Este es el evento que podemos manejar, para poner un master page,
        // o para crear controles dinamicos
        lblInfo.Text += "Evento Page.PreInit <br />";
    }
}