namespace CRUD
{
    partial class Employees
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            txtMaskPhone = new MaskedTextBox();
            btnSave = new Button();
            btnSearch = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            txtNumber = new TextBox();
            label5 = new Label();
            imageList1 = new ImageList(components);
            label7 = new Label();
            txtNeighborhood = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtMaskRg = new MaskedTextBox();
            txtMaskCpf = new MaskedTextBox();
            txtSearch = new TextBox();
            label6 = new Label();
            label8 = new Label();
            lblId = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F);
            label1.ForeColor = Color.FromArgb(80, 250, 123);
            label1.Location = new Point(122, 66);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtName
            // 
            txtName.Location = new Point(191, 68);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "NOME COMPLETO";
            txtName.Size = new Size(356, 23);
            txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Cascadia Code", 9F);
            btnAdd.ForeColor = Color.FromArgb(255, 121, 198);
            btnAdd.ImageKey = "add.png";
            btnAdd.Location = new Point(207, 255);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 23);
            btnAdd.TabIndex = 2;
            btnAdd.TabStop = false;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtMaskPhone
            // 
            txtMaskPhone.Location = new Point(191, 97);
            txtMaskPhone.Mask = "(00)00000-0000";
            txtMaskPhone.Name = "txtMaskPhone";
            txtMaskPhone.Size = new Size(94, 23);
            txtMaskPhone.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Cascadia Code", 9F);
            btnSave.ForeColor = Color.FromArgb(255, 121, 198);
            btnSave.Location = new Point(300, 255);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.TabStop = false;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Cascadia Code", 9F);
            btnSearch.ForeColor = Color.FromArgb(255, 121, 198);
            btnSearch.Location = new Point(550, 284);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 23);
            btnSearch.TabIndex = 5;
            btnSearch.TabStop = false;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Cascadia Code", 9F);
            btnEdit.ForeColor = Color.FromArgb(255, 121, 198);
            btnEdit.Location = new Point(381, 255);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.TabStop = false;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Cascadia Code", 9F);
            btnDelete.ForeColor = Color.FromArgb(255, 121, 198);
            btnDelete.Location = new Point(462, 255);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.TabStop = false;
            btnDelete.Text = "Apagar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F);
            label2.ForeColor = Color.FromArgb(80, 250, 123);
            label2.Location = new Point(90, 94);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 8;
            label2.Text = "Celular:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F);
            label3.ForeColor = Color.FromArgb(80, 250, 123);
            label3.Location = new Point(101, 124);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 9;
            label3.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-MAIL DE CONTATO";
            txtEmail.Size = new Size(356, 23);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F);
            label4.ForeColor = Color.FromArgb(80, 250, 123);
            label4.Location = new Point(80, 153);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 11;
            label4.Text = "Endereço:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(191, 155);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "NOME DA RUA";
            txtAddress.Size = new Size(356, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(191, 184);
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "Nº";
            txtNumber.Size = new Size(49, 23);
            txtNumber.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 12F);
            label5.ForeColor = Color.FromArgb(80, 250, 123);
            label5.Location = new Point(101, 182);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 13;
            label5.Text = "Número:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 12F);
            label7.ForeColor = Color.FromArgb(80, 250, 123);
            label7.Location = new Point(143, 215);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 17;
            label7.Text = "RG:";
            // 
            // txtNeighborhood
            // 
            txtNeighborhood.Location = new Point(335, 184);
            txtNeighborhood.Name = "txtNeighborhood";
            txtNeighborhood.PlaceholderText = "NOME DO BAIRRO";
            txtNeighborhood.Size = new Size(222, 23);
            txtNeighborhood.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code", 12F);
            label10.ForeColor = Color.FromArgb(80, 250, 123);
            label10.Location = new Point(244, 184);
            label10.Name = "label10";
            label10.Size = new Size(73, 21);
            label10.TabIndex = 21;
            label10.Text = "Bairro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code", 12F);
            label9.ForeColor = Color.FromArgb(80, 250, 123);
            label9.Location = new Point(300, 213);
            label9.Name = "label9";
            label9.Size = new Size(46, 21);
            label9.TabIndex = 23;
            label9.Text = "CPF:";
            // 
            // txtMaskRg
            // 
            txtMaskRg.Location = new Point(190, 213);
            txtMaskRg.Mask = "00.000.000-0";
            txtMaskRg.Name = "txtMaskRg";
            txtMaskRg.Size = new Size(100, 23);
            txtMaskRg.TabIndex = 25;
            // 
            // txtMaskCpf
            // 
            txtMaskCpf.Location = new Point(358, 213);
            txtMaskCpf.Mask = "000.000.000-00";
            txtMaskCpf.Name = "txtMaskCpf";
            txtMaskCpf.Size = new Size(100, 23);
            txtMaskCpf.TabIndex = 26;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(190, 284);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "BUSQUE PELO NOME OU CPF";
            txtSearch.Size = new Size(356, 23);
            txtSearch.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F);
            label6.ForeColor = Color.FromArgb(80, 250, 123);
            label6.Location = new Point(70, 284);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 28;
            label6.Text = "Pesquisar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 12F);
            label8.ForeColor = Color.FromArgb(80, 250, 123);
            label8.Location = new Point(48, 28);
            label8.Name = "label8";
            label8.Size = new Size(118, 21);
            label8.TabIndex = 29;
            label8.Text = "Employee id:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Cascadia Code", 12F);
            lblId.ForeColor = Color.FromArgb(255, 121, 198);
            lblId.Location = new Point(185, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 21);
            lblId.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Cascadia Code", 9F);
            btnCancel.ForeColor = Color.FromArgb(255, 121, 198);
            btnCancel.Location = new Point(543, 255);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 23);
            btnCancel.TabIndex = 31;
            btnCancel.TabStop = false;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 42, 54);
            ClientSize = new Size(673, 331);
            Controls.Add(btnCancel);
            Controls.Add(lblId);
            Controls.Add(label8);
            Controls.Add(txtSearch);
            Controls.Add(label6);
            Controls.Add(txtMaskCpf);
            Controls.Add(txtMaskRg);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtNeighborhood);
            Controls.Add(label7);
            Controls.Add(txtNumber);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(txtMaskPhone);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(80, 250, 123);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Button btnAdd;
        private MaskedTextBox txtMaskPhone;
        private Button btnSave;
        private Button btnSearch;
        private Button btnEdit;
        private Button btnDelete;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtAddress;
        private TextBox txtNumber;
        private Label label5;
        private ImageList imageList1;
        private Label label7;
        private TextBox txtNeighborhood;
        private Label label10;
        private Label label9;
        private MaskedTextBox txtMaskRg;
        private MaskedTextBox txtMaskCpf;
        private TextBox txtSearch;
        private Label label6;
        private Label label8;
        private Label lblId;
        private Button btnCancel;
    }
}