namespace LinqToEntity
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnDatePart = new System.Windows.Forms.Button();
            this.btnAddBeverage = new System.Windows.Forms.Button();
            this.btn2050Price = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnExpensiveProduct = new System.Windows.Forms.Button();
            this.btnJoin1 = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContains);
            this.groupBox1.Controls.Add(this.btnDatePart);
            this.groupBox1.Controls.Add(this.btnAddBeverage);
            this.groupBox1.Controls.Add(this.btn2050Price);
            this.groupBox1.Controls.Add(this.btnStock);
            this.groupBox1.Controls.Add(this.btnOrders);
            this.groupBox1.Controls.Add(this.btnExpensiveProduct);
            this.groupBox1.Controls.Add(this.btnJoin1);
            this.groupBox1.Controls.Add(this.btnEmployees);
            this.groupBox1.Controls.Add(this.btnGetProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons";
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(47, 127);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(136, 58);
            this.btnContains.TabIndex = 0;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnDatePart
            // 
            this.btnDatePart.Location = new System.Drawing.Point(529, 127);
            this.btnDatePart.Name = "btnDatePart";
            this.btnDatePart.Size = new System.Drawing.Size(136, 58);
            this.btnDatePart.TabIndex = 0;
            this.btnDatePart.Text = "DatePart";
            this.btnDatePart.UseVisualStyleBackColor = true;
            this.btnDatePart.Click += new System.EventHandler(this.btnDatePart_Click);
            // 
            // btnAddBeverage
            // 
            this.btnAddBeverage.Location = new System.Drawing.Point(688, 19);
            this.btnAddBeverage.Name = "btnAddBeverage";
            this.btnAddBeverage.Size = new System.Drawing.Size(136, 58);
            this.btnAddBeverage.TabIndex = 0;
            this.btnAddBeverage.Text = "Add beverage";
            this.btnAddBeverage.UseVisualStyleBackColor = true;
            this.btnAddBeverage.Click += new System.EventHandler(this.btnAddBeverage_Click);
            // 
            // btn2050Price
            // 
            this.btn2050Price.Location = new System.Drawing.Point(207, 127);
            this.btn2050Price.Name = "btn2050Price";
            this.btn2050Price.Size = new System.Drawing.Size(136, 58);
            this.btn2050Price.TabIndex = 0;
            this.btn2050Price.Text = ">20 <50 Unit price";
            this.btn2050Price.UseVisualStyleBackColor = true;
            this.btn2050Price.Click += new System.EventHandler(this.btn2050Price_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(529, 19);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(136, 58);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Unit in stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(367, 127);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(136, 58);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Orders info";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnExpensiveProduct
            // 
            this.btnExpensiveProduct.Location = new System.Drawing.Point(367, 19);
            this.btnExpensiveProduct.Name = "btnExpensiveProduct";
            this.btnExpensiveProduct.Size = new System.Drawing.Size(136, 58);
            this.btnExpensiveProduct.TabIndex = 0;
            this.btnExpensiveProduct.Text = "The most expensive product";
            this.btnExpensiveProduct.UseVisualStyleBackColor = true;
            this.btnExpensiveProduct.Click += new System.EventHandler(this.btnExpensiveProduct_Click);
            // 
            // btnJoin1
            // 
            this.btnJoin1.Location = new System.Drawing.Point(688, 127);
            this.btnJoin1.Name = "btnJoin1";
            this.btnJoin1.Size = new System.Drawing.Size(136, 58);
            this.btnJoin1.TabIndex = 0;
            this.btnJoin1.Text = "Join 1";
            this.btnJoin1.UseVisualStyleBackColor = true;
            this.btnJoin1.Click += new System.EventHandler(this.btnJoin1_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(207, 19);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(136, 58);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Employees info";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(47, 19);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(136, 58);
            this.btnGetProducts.TabIndex = 0;
            this.btnGetProducts.Text = "Products";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "LinqToEntity";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnDatePart;
        private System.Windows.Forms.Button btnAddBeverage;
        private System.Windows.Forms.Button btn2050Price;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnExpensiveProduct;
        private System.Windows.Forms.Button btnJoin1;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnGetProducts;
    }
}

