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
                new Router {Name = "CISCO RI4kmX",Price=23.5,BuiltInFirewall=true, Icon= new Bitmap(Image.FromFile(@"Data\Assets\Images\cisco1.jpg"),new Size(70,100)) },
                new Router {Name = "CISCO RI4MX Version 1",Price=182,BuiltInFirewall=true, Icon= new Bitmap(Image.FromFile(@"Data\Assets\Images\cisco2.jpg"),new Size(70,100)) },
                new Router {Name = "CISCO AMB6X",Price=210,BuiltInFirewall=false, Icon= new Bitmap(Image.FromFile(@"Data\Assets\Images\cisco3.jpg"),new Size(70,100)) },
                new Router {Name = "CISCO RA6mX",Price=103.5,BuiltInFirewall=false , Icon= new Bitmap(Image.FromFile(@"Data\Assets\Images\cisco1.jpg"),new Size(70,100))}
            }.OrderBy(a => a.Name).ToList();

            inventoryGrid.DataSource = _items;
            inventoryGrid.RowTemplate.Height = 100;
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



        private void inventoryGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ItemDetail itemDetail = new ItemDetail();
                DataGridViewRow row = this.inventoryGrid.Rows[e.RowIndex];
                itemDetail.detailNameTxtbox.Text = row.Cells[0].Value.ToString();
                itemDetail.detailCostTxtbox.Text = row.Cells[1].Value.ToString();
                itemDetail.detailFirewallTxtbox.Text = row.Cells[2].Value.ToString();
                itemDetail.ShowDialog();
            }
        }

        private void Shop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void inventoryGrid_SelectionChanged(object sender, EventArgs e)
        {

            MessageBox.Show("Please enter some text first", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}