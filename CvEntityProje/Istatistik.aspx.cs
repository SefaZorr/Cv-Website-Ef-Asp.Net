using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Istatistik : System.Web.UI.Page
    {
        DbCvEntityEntities db = new DbCvEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLYETENEKLER.Count().ToString();
            Label2.Text = db.TBLILETISIM.Count().ToString();
            Label3.Text = String.Format("{0:0.##}", db.TBLYETENEKLER.Average(x => x.DERECE));
            Label4.Text = String.Format("{0:0.##}", db.TBLYETENEKLER.Max(x => x.DERECE));

            int test = (int)db.TBLYETENEKLER.Max(x => x.DERECE);
            Label5.Text = db.TBLYETENEKLER.Where(x => x.DERECE == test).FirstOrDefault().YETENEK;
        }
    }
}