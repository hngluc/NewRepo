using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using lab04_04.models;
namespace lab04_04
{
    public partial class OrderForm : Form
    {
        private ProductOrderContext context;
        public OrderForm()
        {
            InitializeComponent();
            context = new ProductOrderContext();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now; 
            dtpTo.Value = DateTime.Now; 
            LoadData();
        }
        private void LoadData()
        {
            var query = context.Orders.Include(o => o.Invoice).Include(o => o.Product).AsQueryable();

            if (chkViewAll.Checked)
            {
                var startDate = new DateTime(2019, 10, 1); 
                var endDate = new DateTime(2019, 10, 31);
                

                dtpFrom.Value = startDate;
                dtpTo.Value = endDate;

                query = query.Where(o => o.Invoice.DeliveryDate >= startDate && o.Invoice.DeliveryDate <= endDate);
            }
            else
            {
                var fromDate = dtpFrom.Value.Date;
                var toDate = dtpTo.Value.Date;
                query = query.Where(o => o.Invoice.DeliveryDate >= fromDate && o.Invoice.DeliveryDate <= toDate);
            }

            var orders = query.ToList();
            var orderViewModels = orders.Select(o => new ViewModel
            {
                InvoiceNo = o.InvoiceNo,
                No = o.No,
                ProductID = o.ProductID,
                ProductName = o.Product.ProductName,
                Unit = o.Unit,
                Price = o.Price,
                Quantity = o.Quantity,
                InvoiceNote = o.Invoice.Note,  
            }).ToList();

            dgvOrders.DataSource = orderViewModels;

            var totalAmount = orderViewModels.Sum(o => o.Price * o.Quantity);
            lblTotalAmount.Text = $"Tổng Số Tiền: {totalAmount:N0} VND";
        }



        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrders.Columns.Add("TotalAmount", "Tổng Số Tiền");

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (!chkViewAll.Checked) { LoadData(); }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (!chkViewAll.Checked) { LoadData(); }
        }

        private void chkViewAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewAll.Checked)
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
            else
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
            LoadData();
        }
    }
}




  
  
