namespace Adresbuch
{
    partial class Startseite
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
            this.components = new System.ComponentModel.Container();
            this.btnHunzufuegen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hausnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postleitzahlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailadresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handynummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anmerkungenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressbuchtabelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adressbuchprogrammDataSet = new Adresbuch.adressbuchprogrammDataSet();
            this.adressbuchtabelleTableAdapter = new Adresbuch.adressbuchprogrammDataSetTableAdapters.adressbuchtabelleTableAdapter();
            this.btnAktualisieren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressbuchtabelleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressbuchprogrammDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHunzufuegen
            // 
            this.btnHunzufuegen.Location = new System.Drawing.Point(660, 380);
            this.btnHunzufuegen.Name = "btnHunzufuegen";
            this.btnHunzufuegen.Size = new System.Drawing.Size(91, 37);
            this.btnHunzufuegen.TabIndex = 0;
            this.btnHunzufuegen.Text = "Hinzufügen";
            this.btnHunzufuegen.UseVisualStyleBackColor = true;
            this.btnHunzufuegen.Click += new System.EventHandler(this.btnHunzufuegen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vornameDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.strasseDataGridViewTextBoxColumn,
            this.hausnummerDataGridViewTextBoxColumn,
            this.postleitzahlDataGridViewTextBoxColumn,
            this.ortDataGridViewTextBoxColumn,
            this.eMailadresseDataGridViewTextBoxColumn,
            this.telefonnummerDataGridViewTextBoxColumn,
            this.handynummerDataGridViewTextBoxColumn,
            this.anmerkungenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adressbuchtabelleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 354);
            this.dataGridView1.TabIndex = 2;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            // 
            // strasseDataGridViewTextBoxColumn
            // 
            this.strasseDataGridViewTextBoxColumn.DataPropertyName = "Strasse";
            this.strasseDataGridViewTextBoxColumn.HeaderText = "Strasse";
            this.strasseDataGridViewTextBoxColumn.Name = "strasseDataGridViewTextBoxColumn";
            // 
            // hausnummerDataGridViewTextBoxColumn
            // 
            this.hausnummerDataGridViewTextBoxColumn.DataPropertyName = "Hausnummer";
            this.hausnummerDataGridViewTextBoxColumn.HeaderText = "Hausnummer";
            this.hausnummerDataGridViewTextBoxColumn.Name = "hausnummerDataGridViewTextBoxColumn";
            // 
            // postleitzahlDataGridViewTextBoxColumn
            // 
            this.postleitzahlDataGridViewTextBoxColumn.DataPropertyName = "Postleitzahl";
            this.postleitzahlDataGridViewTextBoxColumn.HeaderText = "Postleitzahl";
            this.postleitzahlDataGridViewTextBoxColumn.Name = "postleitzahlDataGridViewTextBoxColumn";
            // 
            // ortDataGridViewTextBoxColumn
            // 
            this.ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            // 
            // eMailadresseDataGridViewTextBoxColumn
            // 
            this.eMailadresseDataGridViewTextBoxColumn.DataPropertyName = "EMailadresse";
            this.eMailadresseDataGridViewTextBoxColumn.HeaderText = "EMailadresse";
            this.eMailadresseDataGridViewTextBoxColumn.Name = "eMailadresseDataGridViewTextBoxColumn";
            // 
            // telefonnummerDataGridViewTextBoxColumn
            // 
            this.telefonnummerDataGridViewTextBoxColumn.DataPropertyName = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.HeaderText = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.Name = "telefonnummerDataGridViewTextBoxColumn";
            // 
            // handynummerDataGridViewTextBoxColumn
            // 
            this.handynummerDataGridViewTextBoxColumn.DataPropertyName = "Handynummer";
            this.handynummerDataGridViewTextBoxColumn.HeaderText = "Handynummer";
            this.handynummerDataGridViewTextBoxColumn.Name = "handynummerDataGridViewTextBoxColumn";
            // 
            // anmerkungenDataGridViewTextBoxColumn
            // 
            this.anmerkungenDataGridViewTextBoxColumn.DataPropertyName = "Anmerkungen";
            this.anmerkungenDataGridViewTextBoxColumn.HeaderText = "Anmerkungen";
            this.anmerkungenDataGridViewTextBoxColumn.Name = "anmerkungenDataGridViewTextBoxColumn";
            // 
            // adressbuchtabelleBindingSource
            // 
            this.adressbuchtabelleBindingSource.DataMember = "adressbuchtabelle";
            this.adressbuchtabelleBindingSource.DataSource = this.adressbuchprogrammDataSet;
            // 
            // adressbuchprogrammDataSet
            // 
            this.adressbuchprogrammDataSet.DataSetName = "adressbuchprogrammDataSet";
            this.adressbuchprogrammDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adressbuchtabelleTableAdapter
            // 
            this.adressbuchtabelleTableAdapter.ClearBeforeFill = true;
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Location = new System.Drawing.Point(338, 380);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(91, 37);
            this.btnAktualisieren.TabIndex = 3;
            this.btnAktualisieren.Text = "Aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = true;
            this.btnAktualisieren.Click += new System.EventHandler(this.button1_Click);
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHunzufuegen);
            this.Name = "Startseite";
            this.Load += new System.EventHandler(this.Startseite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressbuchtabelleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressbuchprogrammDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHunzufuegen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private adressbuchprogrammDataSet adressbuchprogrammDataSet;
        private System.Windows.Forms.BindingSource adressbuchtabelleBindingSource;
        private adressbuchprogrammDataSetTableAdapters.adressbuchtabelleTableAdapter adressbuchtabelleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hausnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postleitzahlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailadresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handynummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anmerkungenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAktualisieren;
    }
}

