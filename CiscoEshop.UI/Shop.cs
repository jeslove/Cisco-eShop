using shopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiscoEshop.UI
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            var items = new List<Router>
            {
                new Router {Name = "CISCO RI4MX",Price=23.5,BuiltInFirewall=true },
                new Router {Name = "CISCO RI4MX Version 1",Price=182,BuiltInFirewall=true },
                new Router {Name = "CISCO AMB6X",Price=210,BuiltInFirewall=false },
                new Router {Name = "CISCO RA6mX",Price=103.5,BuiltInFirewall=false }
            };
            inventoryGrid.DataSource = items.OrderBy(a => a.Name).ToList();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
        }
    }
}
