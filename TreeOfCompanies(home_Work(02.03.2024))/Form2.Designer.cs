﻿namespace TreeOfCompanies_home_Work_02._03._2024__
{
    partial class TreeOfCompany_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeOfCompany_2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCompanies = new System.Windows.Forms.Button();
            this.btnHq = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 368);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCompanies
            // 
            this.btnCompanies.BackColor = System.Drawing.Color.White;
            this.btnCompanies.Location = new System.Drawing.Point(12, 13);
            this.btnCompanies.Name = "btnCompanies";
            this.btnCompanies.Size = new System.Drawing.Size(114, 51);
            this.btnCompanies.TabIndex = 1;
            this.btnCompanies.Text = "Компании";
            this.btnCompanies.UseVisualStyleBackColor = false;
            this.btnCompanies.Click += new System.EventHandler(this.btnCompanies_Click);
            // 
            // btnHq
            // 
            this.btnHq.BackColor = System.Drawing.Color.White;
            this.btnHq.Location = new System.Drawing.Point(132, 13);
            this.btnHq.Name = "btnHq";
            this.btnHq.Size = new System.Drawing.Size(109, 51);
            this.btnHq.TabIndex = 2;
            this.btnHq.Text = "HQ";
            this.btnHq.UseVisualStyleBackColor = false;
            this.btnHq.Click += new System.EventHandler(this.btnHq_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(247, 13);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(109, 51);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Продукты";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(655, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 51);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TreeOfCompany_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnHq);
            this.Controls.Add(this.btnCompanies);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TreeOfCompany_2";
            this.Text = "Подробнее";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCompanies;
        private System.Windows.Forms.Button btnHq;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnClose;
    }
}