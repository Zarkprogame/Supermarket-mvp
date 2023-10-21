namespace Supermarket_mvp.Views
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            tpProductDetail = new TabPage();
            txtProductStock = new TextBox();
            label7 = new Label();
            comboBoxCategoryId = new ComboBox();
            label6 = new Label();
            txtProductPrice = new TextBox();
            label5 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            tpProductList = new TabPage();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            dgProduct = new DataGridView();
            btnSearch = new Button();
            txtSearchProduct = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tpProductDetail.SuspendLayout();
            tabControl1.SuspendLayout();
            tpProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 34);
            label1.Name = "label1";
            label1.Size = new Size(233, 62);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(22, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 125);
            panel1.TabIndex = 2;
            // 
            // tpProductDetail
            // 
            tpProductDetail.Controls.Add(txtProductStock);
            tpProductDetail.Controls.Add(label7);
            tpProductDetail.Controls.Add(comboBoxCategoryId);
            tpProductDetail.Controls.Add(label6);
            tpProductDetail.Controls.Add(txtProductPrice);
            tpProductDetail.Controls.Add(label5);
            tpProductDetail.Controls.Add(btnCancel);
            tpProductDetail.Controls.Add(btnSave);
            tpProductDetail.Controls.Add(txtProductName);
            tpProductDetail.Controls.Add(txtProductId);
            tpProductDetail.Controls.Add(label4);
            tpProductDetail.Controls.Add(label3);
            tpProductDetail.Location = new Point(4, 29);
            tpProductDetail.Name = "tpProductDetail";
            tpProductDetail.Padding = new Padding(3);
            tpProductDetail.Size = new Size(721, 487);
            tpProductDetail.TabIndex = 1;
            tpProductDetail.Text = "Product Detail";
            tpProductDetail.UseVisualStyleBackColor = true;
            // 
            // txtProductStock
            // 
            txtProductStock.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductStock.Location = new Point(42, 367);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.PlaceholderText = "Product Stock";
            txtProductStock.Size = new Size(259, 31);
            txtProductStock.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(42, 336);
            label7.Name = "label7";
            label7.Size = new Size(138, 28);
            label7.TabIndex = 12;
            label7.Text = "Product Stock";
            // 
            // comboBoxCategoryId
            // 
            comboBoxCategoryId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCategoryId.FormattingEnabled = true;
            comboBoxCategoryId.Location = new Point(41, 121);
            comboBoxCategoryId.Name = "comboBoxCategoryId";
            comboBoxCategoryId.Size = new Size(260, 33);
            comboBoxCategoryId.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(41, 90);
            label6.Name = "label6";
            label6.Size = new Size(118, 28);
            label6.TabIndex = 10;
            label6.Text = "Category Id";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductPrice.Location = new Point(42, 285);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.PlaceholderText = "Product Price";
            txtProductPrice.Size = new Size(259, 31);
            txtProductPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(42, 254);
            label5.Name = "label5";
            label5.Size = new Size(133, 28);
            label5.TabIndex = 8;
            label5.Text = "Product Price";
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(174, 413);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 58);
            btnCancel.TabIndex = 7;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(64, 413);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 58);
            btnSave.TabIndex = 6;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(41, 203);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.Size = new Size(259, 31);
            txtProductName.TabIndex = 3;
            // 
            // txtProductId
            // 
            txtProductId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductId.Location = new Point(42, 47);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(259, 31);
            txtProductId.TabIndex = 1;
            txtProductId.Text = "0";
            txtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(41, 172);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 2;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 16);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 0;
            label3.Text = "Produc Id";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpProductList);
            tabControl1.Controls.Add(tpProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(729, 520);
            tabControl1.TabIndex = 3;
            // 
            // tpProductList
            // 
            tpProductList.Controls.Add(btnClose);
            tpProductList.Controls.Add(btnDelete);
            tpProductList.Controls.Add(btnEdit);
            tpProductList.Controls.Add(btnNew);
            tpProductList.Controls.Add(dgProduct);
            tpProductList.Controls.Add(btnSearch);
            tpProductList.Controls.Add(txtSearchProduct);
            tpProductList.Controls.Add(label2);
            tpProductList.Location = new Point(4, 29);
            tpProductList.Name = "tpProductList";
            tpProductList.Padding = new Padding(3);
            tpProductList.Size = new Size(721, 487);
            tpProductList.TabIndex = 0;
            tpProductList.Text = "Product List";
            tpProductList.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(551, 289);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 58);
            btnClose.TabIndex = 22;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(551, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 58);
            btnDelete.TabIndex = 21;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(551, 161);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 58);
            btnEdit.TabIndex = 20;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(551, 97);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(150, 58);
            btnNew.TabIndex = 19;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dgProduct
            // 
            dgProduct.AllowUserToAddRows = false;
            dgProduct.AllowUserToDeleteRows = false;
            dgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(19, 97);
            dgProduct.Name = "dgProduct";
            dgProduct.ReadOnly = true;
            dgProduct.RowHeadersWidth = 51;
            dgProduct.RowTemplate.Height = 29;
            dgProduct.Size = new Size(526, 379);
            dgProduct.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Image = Properties.Resources.search_small;
            btnSearch.Location = new Point(493, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(52, 49);
            btnSearch.TabIndex = 17;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchProduct.Location = new Point(19, 51);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.PlaceholderText = "Data to Search";
            txtSearchProduct.Size = new Size(468, 31);
            txtSearchProduct.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 11);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 15;
            label2.Text = "Search Product";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 645);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tpProductDetail.ResumeLayout(false);
            tpProductDetail.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpProductList.ResumeLayout(false);
            tpProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TabPage tpProductDetail;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private Label label4;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tpProductList;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private DataGridView dgProduct;
        private Button btnSearch;
        private TextBox txtSearchProduct;
        private Label label2;
        private ComboBox comboBoxCategoryId;
        private Label label6;
        private TextBox txtProductPrice;
        private Label label5;
        private TextBox txtProductStock;
        private Label label7;
    }
}