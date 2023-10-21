namespace Supermarket_mvp.Views
{
    partial class MainView
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
            btnCategory = new Button();
            btnExit = new Button();
            btnPayMode = new Button();
            pictureBox1 = new PictureBox();
            btnProduct = new Button();
            btnProvider = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProvider);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 743);
            panel1.TabIndex = 0;
            // 
            // btnCategory
            // 
            btnCategory.BackgroundImage = Properties.Resources.categorias;
            btnCategory.BackgroundImageLayout = ImageLayout.Zoom;
            btnCategory.Location = new Point(3, 232);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(244, 123);
            btnCategory.TabIndex = 3;
            btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.Leave;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Dock = DockStyle.Bottom;
            btnExit.Location = new Point(0, 620);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(250, 123);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnPayMode
            // 
            btnPayMode.BackgroundImage = Properties.Resources.buy1;
            btnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            btnPayMode.Location = new Point(3, 490);
            btnPayMode.Name = "btnPayMode";
            btnPayMode.Size = new Size(244, 123);
            btnPayMode.TabIndex = 1;
            btnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnProduct
            // 
            btnProduct.BackgroundImage = Properties.Resources.products;
            btnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            btnProduct.Location = new Point(3, 103);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(244, 123);
            btnProduct.TabIndex = 4;
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnProvider
            // 
            btnProvider.BackgroundImage = Properties.Resources.providers;
            btnProvider.BackgroundImageLayout = ImageLayout.Zoom;
            btnProvider.Location = new Point(3, 361);
            btnProvider.Name = "btnProvider";
            btnProvider.Size = new Size(244, 123);
            btnProvider.TabIndex = 5;
            btnProvider.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 743);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPayMode;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnCategory;
        private Button btnProvider;
        private Button btnProduct;
    }
}