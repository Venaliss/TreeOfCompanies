namespace TreeOfCompanies_home_Work_02._03._2024__
{
    partial class TreeOfCompanies
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeOfCompanies));
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.BackColor = System.Drawing.Color.White;
            this.treeView.Location = new System.Drawing.Point(12, 85);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(184, 398);
            this.treeView.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(238, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(167, 49);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShow
            // 
            this.btnShow.AccessibleDescription = "";
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(411, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(156, 50);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(573, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 50);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(238, 85);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(493, 398);
            this.dataGridView.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(737, 497);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // treePicture
            // 
            this.treePicture.Image = global::TreeOfCompanies_home_Work_02._03._2024__.Properties.Resources._1678112137_papik_pro_p_dub_malen;
            this.treePicture.Location = new System.Drawing.Point(12, 12);
            this.treePicture.Name = "treePicture";
            this.treePicture.Size = new System.Drawing.Size(81, 67);
            this.treePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treePicture.TabIndex = 3;
            this.treePicture.TabStop = false;
            // 
            // TreeOfCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 497);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.treePicture);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.splitter1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TreeOfCompanies";
            this.Text = "TreeOfCompanies";
            this.Load += new System.EventHandler(this.TreeOfCompanies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PictureBox treePicture;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Splitter splitter1;
    }
}

