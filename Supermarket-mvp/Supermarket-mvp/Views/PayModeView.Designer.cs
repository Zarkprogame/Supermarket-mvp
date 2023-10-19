namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tpPayModeList = new TabPage();
            tpPayModeDetail = new TabPage();
            label2 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgPayMode = new DataGridView();
            btnNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            label3 = new Label();
            txtPayModeId = new TextBox();
            label4 = new Label();
            txtPayModeName = new TextBox();
            txtPayModeObservation = new TextBox();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tpPayModeList.SuspendLayout();
            tpPayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayMode).BeginInit();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 34);
            label1.Name = "label1";
            label1.Size = new Size(256, 62);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(22, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPayModeList);
            tabControl1.Controls.Add(tpPayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(729, 391);
            tabControl1.TabIndex = 1;
            // 
            // tpPayModeList
            // 
            tpPayModeList.Controls.Add(btnClose);
            tpPayModeList.Controls.Add(btnDelete);
            tpPayModeList.Controls.Add(btnEdit);
            tpPayModeList.Controls.Add(btnNew);
            tpPayModeList.Controls.Add(dgPayMode);
            tpPayModeList.Controls.Add(btnSearch);
            tpPayModeList.Controls.Add(txtSearch);
            tpPayModeList.Controls.Add(label2);
            tpPayModeList.Location = new Point(4, 29);
            tpPayModeList.Name = "tpPayModeList";
            tpPayModeList.Padding = new Padding(3);
            tpPayModeList.Size = new Size(721, 358);
            tpPayModeList.TabIndex = 0;
            tpPayModeList.Text = "Pay Mode List";
            tpPayModeList.UseVisualStyleBackColor = true;
            // 
            // tpPayModeDetail
            // 
            tpPayModeDetail.Controls.Add(btnCancel);
            tpPayModeDetail.Controls.Add(btnSave);
            tpPayModeDetail.Controls.Add(txtPayModeObservation);
            tpPayModeDetail.Controls.Add(label5);
            tpPayModeDetail.Controls.Add(txtPayModeName);
            tpPayModeDetail.Controls.Add(label4);
            tpPayModeDetail.Controls.Add(txtPayModeId);
            tpPayModeDetail.Controls.Add(label3);
            tpPayModeDetail.Location = new Point(4, 29);
            tpPayModeDetail.Name = "tpPayModeDetail";
            tpPayModeDetail.Padding = new Padding(3);
            tpPayModeDetail.Size = new Size(721, 358);
            tpPayModeDetail.TabIndex = 1;
            tpPayModeDetail.Text = "Pay Mode Detail";
            tpPayModeDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(18, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Data to Search";
            txtSearch.Size = new Size(468, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.search_small;
            btnSearch.Location = new Point(492, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(52, 49);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgPayMode
            // 
            dgPayMode.AllowUserToAddRows = false;
            dgPayMode.AllowUserToDeleteRows = false;
            dgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayMode.Location = new Point(18, 94);
            dgPayMode.Name = "dgPayMode";
            dgPayMode.ReadOnly = true;
            dgPayMode.RowHeadersWidth = 51;
            dgPayMode.RowTemplate.Height = 29;
            dgPayMode.Size = new Size(526, 250);
            dgPayMode.TabIndex = 3;
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources._new;
            btnNew.Location = new Point(550, 94);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(150, 58);
            btnNew.TabIndex = 4;
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.Location = new Point(550, 158);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 58);
            btnEdit.TabIndex = 5;
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(550, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 58);
            btnDelete.TabIndex = 6;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.cerrar;
            btnClose.Location = new Point(550, 286);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 58);
            btnClose.TabIndex = 7;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 16);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // txtPayModeId
            // 
            txtPayModeId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPayModeId.Location = new Point(42, 47);
            txtPayModeId.Name = "txtPayModeId";
            txtPayModeId.Size = new Size(259, 31);
            txtPayModeId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(41, 90);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // txtPayModeName
            // 
            txtPayModeName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPayModeName.Location = new Point(41, 121);
            txtPayModeName.Name = "txtPayModeName";
            txtPayModeName.PlaceholderText = "Pay Mode Name";
            txtPayModeName.Size = new Size(259, 31);
            txtPayModeName.TabIndex = 3;
            // 
            // txtPayModeObservation
            // 
            txtPayModeObservation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPayModeObservation.Location = new Point(42, 195);
            txtPayModeObservation.Multiline = true;
            txtPayModeObservation.Name = "txtPayModeObservation";
            txtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            txtPayModeObservation.Size = new Size(260, 74);
            txtPayModeObservation.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 164);
            label5.Name = "label5";
            label5.Size = new Size(219, 28);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
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
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(173, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 58);
            btnCancel.TabIndex = 7;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 516);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tpPayModeList.ResumeLayout(false);
            tpPayModeList.PerformLayout();
            tpPayModeDetail.ResumeLayout(false);
            tpPayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tpPayModeList;
        private TabPage tpPayModeDetail;
        private Label label2;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgPayMode;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNew;
        private Button btnClose;
        private TextBox txtPayModeObservation;
        private Label label5;
        private TextBox txtPayModeName;
        private Label label4;
        private TextBox txtPayModeId;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
    }
}