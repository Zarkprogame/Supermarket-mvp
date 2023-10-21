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
    public partial class CategoryView : Form, ICategoryView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CategoryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();

            tabControl1.TabPages.Remove(tpCategoryDetail);

            btnClose.Click += delegate { this.Close(); };
        }
        public string CategoryId
        {
            get { return txtCategoryId.Text; }
            set { txtCategoryId.Text = value; }
        }
        public string CategoryName
        {
            get { return txtCategoryName.Text; }
            set { txtCategoryName.Text = value; }
        }
        public string CategoryDescription
        {
            get { return txtCategoryDescription.Text; }
            set { txtCategoryDescription.Text = value; }
        }
        public string SearchValue
        {
            get { return txtSearchCategory.Text; }
            set { txtSearchCategory.Text = value; }
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

        public void SetCategoryListBinldingSource(BindingSource categoryList)
        {
            dgCategory.DataSource = categoryList;
        }

        private static CategoryView instance;
        public static CategoryView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoryView();
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
            btnSearchCategory.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchCategory.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Evento Boton Nuevo
            btnNewCategory.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpCategoryList);
                tabControl1.TabPages.Add(tpCategoryDetail);
                tpCategoryDetail.Text = "Add New Pay Mode";
            };
            //Evento Boton Editar
            btnEditCategory.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpCategoryList);
                tabControl1.TabPages.Add(tpCategoryDetail);
                tpCategoryDetail.Text = "Edit Pay Mode";
            };
            //Evento Boton Eliminar
            btnDeleteCategory.Click += delegate
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
                if (!isSuccessful)
                {
                    tabControl1.TabPages.Remove(tpCategoryDetail);
                    tabControl1.TabPages.Add(tpCategoryList);
                }
                MessageBox.Show(Message);
            };
            //Evento Boton Cancelar
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpCategoryDetail);
                tabControl1.TabPages.Add(tpCategoryList);
            };
        }
    }
}
