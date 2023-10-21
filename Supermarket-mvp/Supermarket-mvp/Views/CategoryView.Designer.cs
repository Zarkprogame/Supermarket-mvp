namespace Supermarket_mvp.Views
{
    partial class CategoryView
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tpCategoryList = new TabPage();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            dgCategory = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            tpCategoryDetail = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtCategoryDescription = new TextBox();
            label5 = new Label();
            txtCategoryName = new TextBox();
            label4 = new Label();
            txtCategoryId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tpCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategory).BeginInit();
            tpCategoryDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 125);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(22, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 34);
            label1.Name = "label1";
            label1.Size = new Size(272, 62);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpCategoryList);
            tabControl1.Controls.Add(tpCategoryDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(729, 391);
            tabControl1.TabIndex = 2;
            // 
            // tpCategoryList
            // 
            tpCategoryList.Controls.Add(btnClose);
            tpCategoryList.Controls.Add(btnDelete);
            tpCategoryList.Controls.Add(btnEdit);
            tpCategoryList.Controls.Add(btnNew);
            tpCategoryList.Controls.Add(dgCategory);
            tpCategoryList.Controls.Add(btnSearch);
            tpCategoryList.Controls.Add(txtSearch);
            tpCategoryList.Controls.Add(label2);
            tpCategoryList.Location = new Point(4, 29);
            tpCategoryList.Name = "tpCategoryList";
            tpCategoryList.Padding = new Padding(3);
            tpCategoryList.Size = new Size(721, 358);
            tpCategoryList.TabIndex = 0;
            tpCategoryList.Text = "Category List";
            tpCategoryList.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(547, 293);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 58);
            btnClose.TabIndex = 14;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(547, 229);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 58);
            btnDelete.TabIndex = 13;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(547, 165);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 58);
            btnEdit.TabIndex = 12;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(547, 101);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(150, 58);
            btnNew.TabIndex = 11;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dgCategory
            // 
            dgCategory.AllowUserToAddRows = false;
            dgCategory.AllowUserToDeleteRows = false;
            dgCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategory.Location = new Point(15, 101);
            dgCategory.Name = "dgCategory";
            dgCategory.ReadOnly = true;
            dgCategory.RowHeadersWidth = 51;
            dgCategory.RowTemplate.Height = 29;
            dgCategory.Size = new Size(526, 250);
            dgCategory.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Image = Properties.Resources.search_small;
            btnSearch.Location = new Point(489, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(52, 49);
            btnSearch.TabIndex = 9;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(15, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Data to Search";
            txtSearch.Size = new Size(468, 31);
            txtSearch.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(160, 28);
            label2.TabIndex = 0;
            label2.Text = "Search Category";
            // 
            // tpCategoryDetail
            // 
            tpCategoryDetail.Controls.Add(btnCancel);
            tpCategoryDetail.Controls.Add(btnSave);
            tpCategoryDetail.Controls.Add(txtCategoryDescription);
            tpCategoryDetail.Controls.Add(label5);
            tpCategoryDetail.Controls.Add(txtCategoryName);
            tpCategoryDetail.Controls.Add(label4);
            tpCategoryDetail.Controls.Add(txtCategoryId);
            tpCategoryDetail.Controls.Add(label3);
            tpCategoryDetail.Location = new Point(4, 29);
            tpCategoryDetail.Name = "tpCategoryDetail";
            tpCategoryDetail.Padding = new Padding(3);
            tpCategoryDetail.Size = new Size(721, 358);
            tpCategoryDetail.TabIndex = 1;
            tpCategoryDetail.Text = "Category Detail";
            tpCategoryDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(173, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 58);
            btnCancel.TabIndex = 7;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(63, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 58);
            btnSave.TabIndex = 6;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryDescription.Location = new Point(42, 195);
            txtCategoryDescription.Multiline = true;
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.PlaceholderText = "Category Description";
            txtCategoryDescription.Size = new Size(260, 74);
            txtCategoryDescription.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(44, 167);
            label5.Name = "label5";
            label5.Size = new Size(203, 28);
            label5.TabIndex = 4;
            label5.Text = "Category Description";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryName.Location = new Point(41, 121);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = "Category Name";
            txtCategoryName.Size = new Size(259, 31);
            txtCategoryName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 93);
            label4.Name = "label4";
            label4.Size = new Size(154, 28);
            label4.TabIndex = 2;
            label4.Text = "Category Name";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoryId.Location = new Point(42, 47);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(259, 31);
            txtCategoryId.TabIndex = 1;
            txtCategoryId.Text = "0";
            txtCategoryId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 19);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 0;
            label3.Text = "Category Id";
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 516);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoryView";
            Text = "CategoryView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tpCategoryList.ResumeLayout(false);
            tpCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategory).EndInit();
            tpCategoryDetail.ResumeLayout(false);
            tpCategoryDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tpCategoryList;
        private Label label2;
        private TabPage tpCategoryDetail;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtCategoryDescription;
        private Label label5;
        private TextBox txtCategoryName;
        private Label label4;
        private TextBox txtCategoryId;
        private Label label3;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private DataGridView dgCategory;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}