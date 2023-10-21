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
    public partial class ProviderView : Form, IProviderView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProviderView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();

            tabControl1.TabPages.Remove(tpProviderDetail);

            btnClose.Click += delegate { this.Close(); };
        }

        public string ProviderNit
        {
            get { return txtProviderNit.Text; }
            set { txtProviderNit.Text = value; }
        }
        string IProviderView.ProviderName
        {
            get { return txtProviderName.Text; }
            set { txtProviderName.Text = value; }
        }
        public string ProviderAddress
        {
            get { return txtProviderAddress.Text; }
            set { txtProviderAddress.Text = value; }
        }
        public string ProviderNumber
        {
            get { return txtProviderNumber.Text; }
            set { txtProviderNumber.Text = value; }
        }
        public string SearchValue
        {
            get { return txtSearchProvider.Text; }
            set { txtSearchProvider.Text = value; }
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

        public void SetProviderListBinldingSource(BindingSource providerList)
        {
            dgProvider.DataSource = providerList;
        }

        private static ProviderView instance;
        public static ProviderView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProviderView();
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
            txtSearchProvider.KeyDown += (s, e) =>
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
                txtProviderNit.Enabled = true;
                tabControl1.TabPages.Remove(tpProviderList);
                tabControl1.TabPages.Add(tpProviderDetail);
                tpProviderDetail.Text = "Add New Provider";
            };
            //Evento Boton Editar
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                txtProviderNit.Enabled = false;
                tabControl1.TabPages.Remove(tpProviderList);
                tabControl1.TabPages.Add(tpProviderDetail);
                tpProviderDetail.Text = "Edit Provider";
            };
            //Evento Boton Eliminar
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                        "Are you Sure you Want to Delete the Selected Provider?",
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
                    tabControl1.TabPages.Remove(tpProviderDetail);
                    tabControl1.TabPages.Add(tpProviderList);
                }
                MessageBox.Show(Message);
            };
            //Evento Boton Cancelar
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpProviderDetail);
                tabControl1.TabPages.Add(tpProviderList);
            };
        }
    }
}
