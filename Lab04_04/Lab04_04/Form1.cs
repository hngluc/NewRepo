using Lab04_04.Entity;
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

namespace Lab04_04
{
    public partial class Form1 : Form
    {
        private ProductOrderContext context;
        public Form1()
        {
            InitializeComponent();
            context = new ProductOrderContext();
        }


        private void dgvProductOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductOrder.Columns.Add("TotalAmount", "Tổng Số Tiền");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDelivery.SelectedItem = DateTime.Now;
            cmbTo.SelectedItem = DateTime.Now;
            LoadData();
        }


        private void LoadData()
        {
            var query = context.Orders.Include("Invoice").Include("Product").AsQueryable();

            if (chkViewAll.Checked)
            {
                var startDate = new DateTime(2019, 10, 1);
                var endDate = new DateTime(2019, 10, 31);

                cmbDelivery.SelectedItem = startDate;
                cmbTo.SelectedItem = endDate;

                query = query.Where(o => o.Invoice.DeliveryDate >= startDate && o.Invoice.DeliveryDate <= endDate);
            }
            else
            {
                var fromDate = (DateTime)cmbDelivery.SelectedItem;
                var toDate = (DateTime)cmbTo.SelectedItem;
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

            dgvProductOrder.DataSource = orderViewModels;

            var totalAmount = orderViewModels.Sum(o => o.Price * o.Quantity);
            lblTotalAmount.Text = $"Tổng Số Tiền: {totalAmount:N0} VND";
        }

        private void BindGrid(List<Invoice> invoices)
        {
            
        }

        private void FillCombobox(List<Invoice> invoices)
        {
            
        }

        private void cmbDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chkViewAll.Checked) { LoadData(); }
        }

        private void chkViewAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewAll.Checked)
            {
                cmbDelivery.Enabled = false;
                cmbTo.Enabled = false;
            }
            else
            {
                cmbDelivery.Enabled = true;
                cmbTo.Enabled = true;
            }
            LoadData();
        }
    }
}
