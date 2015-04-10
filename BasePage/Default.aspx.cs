using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasePage
{
    public partial class Default : BasePage
    {
        public override IRequest GetRequest()
        {
            return new DefaultRequest();
        }

        public override void GetResponse(IResponse response)
        {
            Response.Write(response.Message);
            
        }
    }
}