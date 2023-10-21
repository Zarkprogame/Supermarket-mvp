using Microsoft.Data.SqlClient;
using Supermarket_mvp._repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProductView : Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();

            tabControl1.TabPages.Remove(tpProductDetail);

            btnClose.Click += delegate { this.Close(); };
        }

        public string ProductId
        {
            get { return txtProductId.Text; }
            set { txtProductId.Text = value; }
        }
        string IProductView.ProductName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }
        public string ProductPrice
        {
            get { return txtProductPrice.Text; }
            set { txtProductPrice.Text = value; }
        }
        public string ProductStock
        {
            get { return txtProductStock.Text; }
            set { txtProductStock.Text = value; }
        }
        public string CategoryId
        {
            get { return comboBoxCategoryId.Text; }
            set { comboBoxCategoryId.Text = value; }
        }
        public string SearchValue
        {
            get { return txtSearchProduct.Text; }
            set { txtSearchProduct.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBinldingSource(BindingSource productList)
        {
            dgProduct.DataSource = productList;
        }

        private static ProductView instance;
        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void AssociateAndRaiseViewEvent()
        {
            //Evento Boton Buscar o Enter
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Evento Boton Nuevo
            btnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpProductList);
                tabControl1.TabPages.Add(tpProductDetail);
                tpProductDetail.Text = "Add New Product";
            };
            //Evento Boton Editar
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpProductList);
                tabControl1.TabPages.Add(tpProductDetail);
                tpProductDetail.Text = "Edit Product";
            };
            //Evento Boton Eliminar
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                        "Are you Sure you Want to Delete the Selected Product?",
                        "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            //Evento Boton Guardar
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (!isSuccessful)
                {
                    tabControl1.TabPages.Remove(tpProductDetail);
                    tabControl1.TabPages.Add(tpProductList);
                }
                MessageBox.Show(Message);
            };
            //Evento Boton Cancelar
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpProductDetail);
                tabControl1.TabPages.Add(tpProductList);
            };
        }
    }
}
