using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasePage
{
    public abstract class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {
            this.Load += BasePage_Load;         
        }

        void BasePage_Load(object sender, EventArgs e)
        {
            CustomerService service = new CustomerService();
            IResponse response = service.GetResponse(GetRequest());
            GetResponse(response);
        }


        public abstract IRequest GetRequest();

        public abstract void GetResponse(IResponse request);
     
    }
}