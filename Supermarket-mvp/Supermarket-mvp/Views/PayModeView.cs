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
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public PayModeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();

            tabControl1.TabPages.Remove(tpPayModeDetail);

            btnClose.Click += delegate { this.Close(); };
        }

        public string PayModeId
        {
            get { return txtPayModeId.Text; }
            set { txtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return txtPayModeName.Text; }
            set { txtPayModeName.Text = value; }
        }
        public string PayModeObservation
        {
            get { return txtPayModeObservation.Text; }
            set { txtPayModeObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
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

        public void SetPayModeListBinldingSource(BindingSource payModeList)
        {
            dgPayMode.DataSource = payModeList;
        }

        private static PayModeView instance;
        public static PayModeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeView();
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
            txtSearch.KeyDown += (s, e) =>
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
                tabControl1.TabPages.Remove(tpPayModeList);
                tabControl1.TabPages.Add(tpPayModeDetail);
                tpPayModeDetail.Text = "Add New Pay Mode";
            };
            //Evento Boton Editar
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpPayModeList);
                tabControl1.TabPages.Add(tpPayModeDetail);
                tpPayModeDetail.Text = "Edit Pay Mode";
            };
            //Evento Boton Eliminar
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                        "Are you Sure you Want to Delete the Selected Pay Mode?",
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
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tpPayModeDetail);
                    tabControl1.TabPages.Add(tpPayModeList);
                }
                MessageBox.Show(Message);
            };
            //Evento Boton Cancelar
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpPayModeDetail);
                tabControl1.TabPages.Add(tpPayModeList);
            };
        }
    }
}
