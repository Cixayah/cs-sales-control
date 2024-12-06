namespace CRUD
{
    partial class Customers
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
            dataGridViewCustomers = new DataGridView();
            btnLoadCustomers = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(14, 29);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.ReadOnly = true;
            dataGridViewCustomers.Size = new Size(887, 274);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // btnLoadCustomers
            // 
            btnLoadCustomers.Location = new Point(355, 309);
            btnLoadCustomers.Name = "btnLoadCustomers";
            btnLoadCustomers.Size = new Size(198, 27);
            btnLoadCustomers.TabIndex = 1;
            btnLoadCustomers.Text = "Carregar clientes";
            btnLoadCustomers.UseVisualStyleBackColor = true;
            btnLoadCustomers.Click += btnLoadCustomers_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(btnLoadCustomers);
            Controls.Add(dataGridViewCustomers);
            Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Customers";
            Text = "Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private Button btnLoadCustomers;
    }
}