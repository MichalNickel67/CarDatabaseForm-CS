namespace Cars1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CarTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDatabaseDataSet = new Cars1.CarDatabaseDataSet();
            this.SelectCarBrand = new System.Windows.Forms.ComboBox();
            this.CarMoreInfo = new System.Windows.Forms.Button();
            this.NewBrand = new System.Windows.Forms.Label();
            this.NewBrandTextBox = new System.Windows.Forms.TextBox();
            this.NewModel = new System.Windows.Forms.Label();
            this.NewModelTextBox = new System.Windows.Forms.TextBox();
            this.NewYear = new System.Windows.Forms.Label();
            this.NewYearTextBox = new System.Windows.Forms.TextBox();
            this.NewEngineSize = new System.Windows.Forms.Label();
            this.NewEngineSizeTextBox = new System.Windows.Forms.TextBox();
            this.NewFuelType = new System.Windows.Forms.Label();
            this.AddNewCar = new System.Windows.Forms.Button();
            this.SelectCar = new System.Windows.Forms.Label();
            this.SelectCarModel = new System.Windows.Forms.ComboBox();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.radioButtonDiesel = new System.Windows.Forms.RadioButton();
            this.radioButtonElectric = new System.Windows.Forms.RadioButton();
            this.radioButtonPetrol = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.carTableTableAdapter = new Cars1.CarDatabaseDataSetTableAdapters.CarTableTableAdapter();
            this.tableAdapterManager = new Cars1.CarDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.CarTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CarTableDataGridView
            // 
            this.CarTableDataGridView.AutoGenerateColumns = false;
            this.CarTableDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CarTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.CarTableDataGridView.DataSource = this.carTableBindingSource;
            resources.ApplyResources(this.CarTableDataGridView, "CarTableDataGridView");
            this.CarTableDataGridView.Name = "CarTableDataGridView";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Car ID";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Brand";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Year";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Engine Size";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fuel Type";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // carTableBindingSource
            // 
            this.carTableBindingSource.DataMember = "CarTable";
            this.carTableBindingSource.DataSource = this.carDatabaseDataSet;
            // 
            // carDatabaseDataSet
            // 
            this.carDatabaseDataSet.DataSetName = "CarDatabaseDataSet";
            this.carDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectCarBrand
            // 
            this.SelectCarBrand.FormattingEnabled = true;
            resources.ApplyResources(this.SelectCarBrand, "SelectCarBrand");
            this.SelectCarBrand.Name = "SelectCarBrand";
            this.SelectCarBrand.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CarMoreInfo
            // 
            this.CarMoreInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.CarMoreInfo, "CarMoreInfo");
            this.CarMoreInfo.Name = "CarMoreInfo";
            this.CarMoreInfo.UseVisualStyleBackColor = true;
            // 
            // NewBrand
            // 
            resources.ApplyResources(this.NewBrand, "NewBrand");
            this.NewBrand.BackColor = System.Drawing.Color.Transparent;
            this.NewBrand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewBrand.Name = "NewBrand";
            // 
            // NewBrandTextBox
            // 
            resources.ApplyResources(this.NewBrandTextBox, "NewBrandTextBox");
            this.NewBrandTextBox.Name = "NewBrandTextBox";
            // 
            // NewModel
            // 
            resources.ApplyResources(this.NewModel, "NewModel");
            this.NewModel.BackColor = System.Drawing.Color.Transparent;
            this.NewModel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewModel.Name = "NewModel";
            // 
            // NewModelTextBox
            // 
            resources.ApplyResources(this.NewModelTextBox, "NewModelTextBox");
            this.NewModelTextBox.Name = "NewModelTextBox";
            this.NewModelTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NewYear
            // 
            resources.ApplyResources(this.NewYear, "NewYear");
            this.NewYear.BackColor = System.Drawing.Color.Transparent;
            this.NewYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewYear.Name = "NewYear";
            // 
            // NewYearTextBox
            // 
            resources.ApplyResources(this.NewYearTextBox, "NewYearTextBox");
            this.NewYearTextBox.Name = "NewYearTextBox";
            // 
            // NewEngineSize
            // 
            resources.ApplyResources(this.NewEngineSize, "NewEngineSize");
            this.NewEngineSize.BackColor = System.Drawing.Color.Transparent;
            this.NewEngineSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewEngineSize.Name = "NewEngineSize";
            // 
            // NewEngineSizeTextBox
            // 
            resources.ApplyResources(this.NewEngineSizeTextBox, "NewEngineSizeTextBox");
            this.NewEngineSizeTextBox.Name = "NewEngineSizeTextBox";
            // 
            // NewFuelType
            // 
            resources.ApplyResources(this.NewFuelType, "NewFuelType");
            this.NewFuelType.BackColor = System.Drawing.Color.Transparent;
            this.NewFuelType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewFuelType.Name = "NewFuelType";
            // 
            // AddNewCar
            // 
            this.AddNewCar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.AddNewCar, "AddNewCar");
            this.AddNewCar.Name = "AddNewCar";
            this.AddNewCar.UseVisualStyleBackColor = true;
            this.AddNewCar.Click += new System.EventHandler(this.AddNewCar_Click);
            // 
            // SelectCar
            // 
            resources.ApplyResources(this.SelectCar, "SelectCar");
            this.SelectCar.BackColor = System.Drawing.Color.Transparent;
            this.SelectCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectCar.Name = "SelectCar";
            // 
            // SelectCarModel
            // 
            this.SelectCarModel.FormattingEnabled = true;
            resources.ApplyResources(this.SelectCarModel, "SelectCarModel");
            this.SelectCarModel.Name = "SelectCarModel";
            this.SelectCarModel.SelectedIndexChanged += new System.EventHandler(this.SelectCarModel_SelectedIndexChanged);
            // 
            // TextSearch
            // 
            resources.ApplyResources(this.TextSearch, "TextSearch");
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // LogoImage
            // 
            this.LogoImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LogoImage, "LogoImage");
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.TabStop = false;
            this.LogoImage.Click += new System.EventHandler(this.LogoImage_Click);
            // 
            // radioButtonDiesel
            // 
            resources.ApplyResources(this.radioButtonDiesel, "radioButtonDiesel");
            this.radioButtonDiesel.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonDiesel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonDiesel.Name = "radioButtonDiesel";
            this.radioButtonDiesel.TabStop = true;
            this.radioButtonDiesel.UseVisualStyleBackColor = false;
            // 
            // radioButtonElectric
            // 
            resources.ApplyResources(this.radioButtonElectric, "radioButtonElectric");
            this.radioButtonElectric.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonElectric.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonElectric.Name = "radioButtonElectric";
            this.radioButtonElectric.TabStop = true;
            this.radioButtonElectric.UseVisualStyleBackColor = false;
            // 
            // radioButtonPetrol
            // 
            resources.ApplyResources(this.radioButtonPetrol, "radioButtonPetrol");
            this.radioButtonPetrol.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPetrol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonPetrol.Name = "radioButtonPetrol";
            this.radioButtonPetrol.TabStop = true;
            this.radioButtonPetrol.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Name = "label5";
            // 
            // RegisterButton
            // 
            resources.ApplyResources(this.RegisterButton, "RegisterButton");
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterLabel
            // 
            resources.ApplyResources(this.RegisterLabel, "RegisterLabel");
            this.RegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegisterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterLabel.Name = "RegisterLabel";
            // 
            // carTableTableAdapter
            // 
            this.carTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarTableTableAdapter = this.carTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cars1.CarDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonElectric);
            this.Controls.Add(this.radioButtonPetrol);
            this.Controls.Add(this.radioButtonDiesel);
            this.Controls.Add(this.LogoImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.SelectCarModel);
            this.Controls.Add(this.SelectCar);
            this.Controls.Add(this.AddNewCar);
            this.Controls.Add(this.NewFuelType);
            this.Controls.Add(this.NewEngineSizeTextBox);
            this.Controls.Add(this.NewEngineSize);
            this.Controls.Add(this.NewYearTextBox);
            this.Controls.Add(this.NewYear);
            this.Controls.Add(this.NewModelTextBox);
            this.Controls.Add(this.NewModel);
            this.Controls.Add(this.NewBrandTextBox);
            this.Controls.Add(this.NewBrand);
            this.Controls.Add(this.CarMoreInfo);
            this.Controls.Add(this.SelectCarBrand);
            this.Controls.Add(this.CarTableDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarDatabaseDataSet carDatabaseDataSet;
        private System.Windows.Forms.BindingSource carTableBindingSource;
        private CarDatabaseDataSetTableAdapters.CarTableTableAdapter carTableTableAdapter;
        private CarDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView CarTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox SelectCarBrand;
        private System.Windows.Forms.Button CarMoreInfo;
        private System.Windows.Forms.Label NewBrand;
        private System.Windows.Forms.TextBox NewBrandTextBox;
        private System.Windows.Forms.Label NewModel;
        private System.Windows.Forms.TextBox NewModelTextBox;
        private System.Windows.Forms.Label NewYear;
        private System.Windows.Forms.TextBox NewYearTextBox;
        private System.Windows.Forms.Label NewEngineSize;
        private System.Windows.Forms.TextBox NewEngineSizeTextBox;
        private System.Windows.Forms.Label NewFuelType;
        private System.Windows.Forms.Button AddNewCar;
        private System.Windows.Forms.Label SelectCar;
        private System.Windows.Forms.ComboBox SelectCarModel;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.RadioButton radioButtonDiesel;
        private System.Windows.Forms.RadioButton radioButtonElectric;
        private System.Windows.Forms.RadioButton radioButtonPetrol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label RegisterLabel;
    }
}

