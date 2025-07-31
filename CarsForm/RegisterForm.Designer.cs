namespace Cars1
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.PasswordCriteria = new System.Windows.Forms.Label();
            this.CheckPassword = new System.Windows.Forms.Button();
            this.showhide = new System.Windows.Forms.Button();
            this.accountsDataSet = new Cars1.AccountsDataSet();
            this.accountsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableTableAdapter = new Cars1.AccountsDataSetTableAdapters.AccountsTableTableAdapter();
            this.tableAdapterManager = new Cars1.AccountsDataSetTableAdapters.TableAdapterManager();
            this.accountsTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username:";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(57, 80);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(173, 20);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(54, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Password: (minimum of 10 characters)";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(57, 164);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(173, 20);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(57, 280);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(97, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.Font = new System.Drawing.Font("Rockwell", 10F);
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(553, 44);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(232, 100);
            this.outputListBox.TabIndex = 6;
            // 
            // PasswordCriteria
            // 
            this.PasswordCriteria.AutoSize = true;
            this.PasswordCriteria.BackColor = System.Drawing.Color.Transparent;
            this.PasswordCriteria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordCriteria.Location = new System.Drawing.Point(54, 197);
            this.PasswordCriteria.Name = "PasswordCriteria";
            this.PasswordCriteria.Size = new System.Drawing.Size(97, 13);
            this.PasswordCriteria.TabIndex = 7;
            this.PasswordCriteria.Text = "Password Criteria";
            // 
            // CheckPassword
            // 
            this.CheckPassword.Location = new System.Drawing.Point(289, 161);
            this.CheckPassword.Name = "CheckPassword";
            this.CheckPassword.Size = new System.Drawing.Size(112, 23);
            this.CheckPassword.TabIndex = 8;
            this.CheckPassword.Text = "Check Password";
            this.CheckPassword.UseVisualStyleBackColor = true;
            this.CheckPassword.Click += new System.EventHandler(this.ADDTESTING_Click);
            // 
            // showhide
            // 
            this.showhide.Location = new System.Drawing.Point(236, 162);
            this.showhide.Name = "showhide";
            this.showhide.Size = new System.Drawing.Size(47, 23);
            this.showhide.TabIndex = 9;
            this.showhide.Text = "show";
            this.showhide.UseVisualStyleBackColor = true;
            this.showhide.Click += new System.EventHandler(this.showhide_Click);
            // 
            // accountsDataSet
            // 
            this.accountsDataSet.DataSetName = "AccountsDataSet";
            this.accountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableBindingSource
            // 
            this.accountsTableBindingSource.DataMember = "AccountsTable";
            this.accountsTableBindingSource.DataSource = this.accountsDataSet;
            // 
            // accountsTableTableAdapter
            // 
            this.accountsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountsTableTableAdapter = this.accountsTableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Cars1.AccountsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accountsTableDataGridView
            // 
            this.accountsTableDataGridView.AutoGenerateColumns = false;
            this.accountsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.accountsTableDataGridView.DataSource = this.accountsTableBindingSource;
            this.accountsTableDataGridView.Location = new System.Drawing.Point(445, 253);
            this.accountsTableDataGridView.Name = "accountsTableDataGridView";
            this.accountsTableDataGridView.Size = new System.Drawing.Size(340, 220);
            this.accountsTableDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AccountID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AccountID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(811, 505);
            this.Controls.Add(this.accountsTableDataGridView);
            this.Controls.Add(this.showhide);
            this.Controls.Add(this.CheckPassword);
            this.Controls.Add(this.PasswordCriteria);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label PasswordCriteria;
        private System.Windows.Forms.Button CheckPassword;
        private System.Windows.Forms.Button showhide;
        private AccountsDataSet accountsDataSet;
        private System.Windows.Forms.BindingSource accountsTableBindingSource;
        private AccountsDataSetTableAdapters.AccountsTableTableAdapter accountsTableTableAdapter;
        private AccountsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView accountsTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}