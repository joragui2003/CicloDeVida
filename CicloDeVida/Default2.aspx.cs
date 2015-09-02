using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    //protected override void OnLoadComplete(EventArgs e)
    //{
    //    Label label = (Label)Master.FindControl("lblTitulo");
    //    label.Text = "Titulo desde el Default2.aspx  en OnLoadComplete<br />";
    //}
    ////Si se habilita el OnLoad se deshabilita el Load
    //protected override void OnPreInit(EventArgs e)
    //{
    //    Label label = (Label)Master.FindControl("lblTitulo");
    //    label.Text = "Titulo desde el Default2.aspx en OnLoad <br />";
    //    if (Request.QueryString["CANT"] != null)
    //    {
    //        int canti = (Convert.ToInt32(Request.QueryString["CANT"]));
    //        generarTxt(canti);
    //    }
    //}
    protected override void OnLoad(EventArgs e)
    {
        //base.OnLoad(e);
        Label label = (Label)Master.FindControl("lblTitulo");
        label.Text = "Titulo desde el Default2.aspx en OnLoad <br />";
        if (Request.QueryString["CANT"] != null)
        {
            int canti = (Convert.ToInt32(Request.QueryString["CANT"]));
            generarTxt(canti);
        }
    }

    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    Label label = (Label)Master.FindControl("lblTitulo");
    //    label.Text = "Titulo desde el Default2.aspx en Load <br />";
    //}
    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        Label label = (Label)Master.FindControl("lblTitulo");
        label.Text = "Titulo desde el Default2.aspx en OnLoad <br />";
        //if (Request.QueryString["CANT"] != null)
        //{
        //    int canti = (Convert.ToInt32(Request.QueryString["CANT"]));
        //    generarTxt(canti);
        //}
    }
    /// <summary>
    /// Resumen de método generar TextBox Dinamicos, con sumary
    /// </summary>
    /// <param name="cant"></param>
    public void generarTxt(int cant)
    {
        for (int i = 1; i <= cant; i++)
        {
            TextBox txt = new TextBox();
            txt.ID = "txt" + i;
            txt.Text = (i * 2).ToString();
            phTxt.Controls.Add(txt);
        }

        Button suma = new Button();
        suma.ID = "btnSuma";
        suma.Text = "[Sumar]";
        pnlSuma.Controls.Add(suma);
        suma.Click += suma_Click;

        Label lblRes = new Label();
        lblRes.ID = "lblResu";
        lblRes.Text = "Resultado";
        pnlSuma.Controls.Add(lblRes);
    }

    void suma_Click(object sender, EventArgs e)
    {
        int suma = 0;
        foreach (Control c in phTxt.Controls)
        {
            TextBox t = c as TextBox;
            if (t.Text != null)
                suma += Convert.ToInt32(t.Text);
        }
        Label lbl = new Label();
        lbl = (Label)pnlSuma.FindControl("lblResu");
        lbl.Text = string.Format("La suma total es: {0}", suma);
    }
    protected void lnkGene_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.CurrentExecutionFilePath + "?CANT=" + txtCant.Text);
    }
}