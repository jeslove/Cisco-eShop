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
        public readonly List<Router> _items ;
        public Shop()
        {
            InitializeComponent();
            _items = new List<Router>
            {
                new Router {Name = "CISCO RI4MX",Price=23.5,BuiltInFirewall=true },
                new Router {Name = "CISCO RI4MX Version 1",Price=182,BuiltInFirewall=true },
                new Router {Name = "CISCO AMB6X",Price=210,BuiltInFirewall=false },
                new Router {Name = "CISCO RA6mX",Price=103.5,BuiltInFirewall=false }
            }.OrderBy(a => a.Name).ToList();
            inventoryGrid.DataSource = _items;
        }

        private void Shop_Load(object sender, EventArgs e)
        {
        }

        private void inventorySearchBtn_Click(object sender, EventArgs e)
        {
            if(inventorySearchTxtbox.Text.Length>1)
            {
                string searchText = inventorySearchTxtbox.Text;
                inventoryGrid.DataSource = _items.Where(a => a.Name.Contains(searchText,StringComparison.InvariantCultureIgnoreCase)).OrderBy(e=>e.Name).ToList();
            }
            else
            {
                inventoryGrid.DataSource = _items;
                MessageBox.Show("Please enter some text first", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
