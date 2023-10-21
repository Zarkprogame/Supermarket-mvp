namespace Supermarket_mvp.Views
{
    partial class ProviderView
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
            tpProviderList = new TabPage();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnNew = new Button();
            dgProvider = new DataGridView();
            btnSearch = new Button();
            txtSearchProvider = new TextBox();
            label2 = new Label();
            tpProviderDetail = new TabPage();
            txtProviderNumber = new TextBox();
            label6 = new Label();
            txtProviderAddress = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label5 = new Label();
            txtProviderName = new TextBox();
            label4 = new Label();
            txtProviderNit = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tpProviderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProvider).BeginInit();
            tpProviderDetail.SuspendLayout();
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
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers1;
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
            label1.Size = new Size(249, 62);
            label1.TabIndex = 0;
            label1.Text = "Providers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpProviderList);
            tabControl1.Controls.Add(tpProviderDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(729, 437);
            tabControl1.TabIndex = 3;
            // 
            // tpProviderList
            // 
            tpProviderList.Controls.Add(btnClose);
            tpProviderList.Controls.Add(btnDelete);
            tpProviderList.Controls.Add(btnEdit);
            tpProviderList.Controls.Add(btnNew);
            tpProviderList.Controls.Add(dgProvider);
            tpProviderList.Controls.Add(btnSearch);
            tpProviderList.Controls.Add(txtSearchProvider);
            tpProviderList.Controls.Add(label2);
            tpProviderList.Location = new Point(4, 29);
            tpProviderList.Name = "tpProviderList";
            tpProviderList.Padding = new Padding(3);
            tpProviderList.Size = new Size(721, 404);
            tpProviderList.TabIndex = 0;
            tpProviderList.Text = "Provider List";
            tpProviderList.UseVisualStyleBackColor = true;
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
            // dgProvider
            // 
            dgProvider.AllowUserToAddRows = false;
            dgProvider.AllowUserToDeleteRows = false;
            dgProvider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgProvider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProvider.Location = new Point(19, 97);
            dgProvider.Name = "dgProvider";
            dgProvider.ReadOnly = true;
            dgProvider.RowHeadersWidth = 51;
            dgProvider.RowTemplate.Height = 29;
            dgProvider.Size = new Size(526, 250);
            dgProvider.TabIndex = 18;
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
            // txtSearchProvider
            // 
            txtSearchProvider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchProvider.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchProvider.Location = new Point(19, 51);
            txtSearchProvider.Name = "txtSearchProvider";
            txtSearchProvider.PlaceholderText = "Data to Search";
            txtSearchProvider.Size = new Size(468, 31);
            txtSearchProvider.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 11);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 15;
            label2.Text = "Search Provider";
            // 
            // tpProviderDetail
            // 
            tpProviderDetail.Controls.Add(txtProviderNumber);
            tpProviderDetail.Controls.Add(label6);
            tpProviderDetail.Controls.Add(txtProviderAddress);
            tpProviderDetail.Controls.Add(btnCancel);
            tpProviderDetail.Controls.Add(btnSave);
            tpProviderDetail.Controls.Add(label5);
            tpProviderDetail.Controls.Add(txtProviderName);
            tpProviderDetail.Controls.Add(label4);
            tpProviderDetail.Controls.Add(txtProviderNit);
            tpProviderDetail.Controls.Add(label3);
            tpProviderDetail.Location = new Point(4, 29);
            tpProviderDetail.Name = "tpProviderDetail";
            tpProviderDetail.Padding = new Padding(3);
            tpProviderDetail.Size = new Size(721, 404);
            tpProviderDetail.TabIndex = 1;
            tpProviderDetail.Text = "Provider Detail";
            tpProviderDetail.UseVisualStyleBackColor = true;
            // 
            // txtProviderNumber
            // 
            txtProviderNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProviderNumber.Location = new Point(41, 271);
            txtProviderNumber.Name = "txtProviderNumber";
            txtProviderNumber.PlaceholderText = "Provider Number";
            txtProviderNumber.Size = new Size(259, 31);
            txtProviderNumber.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(41, 240);
            label6.Name = "label6";
            label6.Size = new Size(169, 28);
            label6.TabIndex = 9;
            label6.Text = "Provider Number";
            // 
            // txtProviderAddress
            // 
            txtProviderAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProviderAddress.Location = new Point(42, 195);
            txtProviderAddress.Name = "txtProviderAddress";
            txtProviderAddress.PlaceholderText = "Provider Address";
            txtProviderAddress.Size = new Size(259, 31);
            txtProviderAddress.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(168, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 58);
            btnCancel.TabIndex = 7;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(58, 328);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 58);
            btnSave.TabIndex = 6;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(42, 164);
            label5.Name = "label5";
            label5.Size = new Size(167, 28);
            label5.TabIndex = 4;
            label5.Text = "Provider Address";
            // 
            // txtProviderName
            // 
            txtProviderName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProviderName.Location = new Point(42, 121);
            txtProviderName.Name = "txtProviderName";
            txtProviderName.PlaceholderText = "Provider Name";
            txtProviderName.Size = new Size(259, 31);
            txtProviderName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 90);
            label4.Name = "label4";
            label4.Size = new Size(148, 28);
            label4.TabIndex = 2;
            label4.Text = "Provider Name";
            // 
            // txtProviderNit
            // 
            txtProviderNit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtProviderNit.Location = new Point(42, 47);
            txtProviderNit.Name = "txtProviderNit";
            txtProviderNit.PlaceholderText = "Provider Nit";
            txtProviderNit.Size = new Size(259, 31);
            txtProviderNit.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 16);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 0;
            label3.Text = "Provider Nit";
            // 
            // ProviderView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 562);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProviderView";
            Text = "ProviderView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tpProviderList.ResumeLayout(false);
            tpProviderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProvider).EndInit();
            tpProviderDetail.ResumeLayout(false);
            tpProviderDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tpProviderList;
        private TabPage tpProviderDetail;
        private Button btnCancel;
        private Button btnSave;
        private Label label5;
        private TextBox txtProviderName;
        private Label label4;
        private TextBox txtProviderNit;
        private Label label3;
        private Button btnClose;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private DataGridView dgProvider;
        private Button btnSearch;
        private TextBox txtSearchProvider;
        private Label label2;
        private TextBox txtProviderAddress;
        private TextBox txtProviderNumber;
        private Label label6;
    }
}