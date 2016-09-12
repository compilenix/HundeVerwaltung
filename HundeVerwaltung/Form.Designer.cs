namespace HundeVerwaltung
{
    partial class HundeVerwaltung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HundeVerwaltung));
            this.buttonNewHund = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxHundName = new System.Windows.Forms.TextBox();
            this.numericUpDownHundSize = new System.Windows.Forms.NumericUpDown();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.HundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HundSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBellen = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.numericUpDownCountOfBark = new System.Windows.Forms.NumericUpDown();
            this.textBoxHundNameCurrent = new System.Windows.Forms.TextBox();
            this.numericUpDownHundSizeCurrent = new System.Windows.Forms.NumericUpDown();
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHundSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountOfBark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHundSizeCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewHund
            // 
            resources.ApplyResources(this.buttonNewHund, "buttonNewHund");
            this.buttonNewHund.Name = "buttonNewHund";
            this.buttonNewHund.UseVisualStyleBackColor = true;
            this.buttonNewHund.Click += new System.EventHandler(this.buttonNewHund_Click);
            // 
            // richTextBoxOutput
            // 
            resources.ApplyResources(this.richTextBoxOutput, "richTextBoxOutput");
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            // 
            // textBoxHundName
            // 
            resources.ApplyResources(this.textBoxHundName, "textBoxHundName");
            this.textBoxHundName.Name = "textBoxHundName";
            this.textBoxHundName.Enter += new System.EventHandler(this.textBoxHundName_Enter);
            this.textBoxHundName.Leave += new System.EventHandler(this.textBoxHundName_Leave);
            // 
            // numericUpDownHundSize
            // 
            resources.ApplyResources(this.numericUpDownHundSize, "numericUpDownHundSize");
            this.numericUpDownHundSize.Name = "numericUpDownHundSize";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HundName,
            this.HundSize});
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // HundName
            // 
            this.HundName.DataPropertyName = "Name";
            resources.ApplyResources(this.HundName, "HundName");
            this.HundName.Name = "HundName";
            this.HundName.ReadOnly = true;
            // 
            // HundSize
            // 
            this.HundSize.DataPropertyName = "Size";
            resources.ApplyResources(this.HundSize, "HundSize");
            this.HundSize.Name = "HundSize";
            this.HundSize.ReadOnly = true;
            // 
            // buttonBellen
            // 
            resources.ApplyResources(this.buttonBellen, "buttonBellen");
            this.buttonBellen.Name = "buttonBellen";
            this.buttonBellen.UseVisualStyleBackColor = true;
            this.buttonBellen.Click += new System.EventHandler(this.buttonBellen_Click);
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDel
            // 
            resources.ApplyResources(this.buttonDel, "buttonDel");
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // numericUpDownCountOfBark
            // 
            resources.ApplyResources(this.numericUpDownCountOfBark, "numericUpDownCountOfBark");
            this.numericUpDownCountOfBark.Name = "numericUpDownCountOfBark";
            this.numericUpDownCountOfBark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxHundNameCurrent
            // 
            resources.ApplyResources(this.textBoxHundNameCurrent, "textBoxHundNameCurrent");
            this.textBoxHundNameCurrent.Name = "textBoxHundNameCurrent";
            this.textBoxHundNameCurrent.Enter += new System.EventHandler(this.textBoxHundNameCurrent_Enter);
            this.textBoxHundNameCurrent.Leave += new System.EventHandler(this.textBoxHundNameCurrent_Leave);
            // 
            // numericUpDownHundSizeCurrent
            // 
            resources.ApplyResources(this.numericUpDownHundSizeCurrent, "numericUpDownHundSizeCurrent");
            this.numericUpDownHundSizeCurrent.Name = "numericUpDownHundSizeCurrent";
            // 
            // buttonUebernehmen
            // 
            resources.ApplyResources(this.buttonUebernehmen, "buttonUebernehmen");
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            this.buttonUebernehmen.Click += new System.EventHandler(this.buttonUebernehmen_Click);
            // 
            // HundeVerwaltung
            // 
            this.AcceptButton = this.buttonNewHund;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBellen);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.numericUpDownCountOfBark);
            this.Controls.Add(this.numericUpDownHundSizeCurrent);
            this.Controls.Add(this.numericUpDownHundSize);
            this.Controls.Add(this.textBoxHundNameCurrent);
            this.Controls.Add(this.textBoxHundName);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.buttonUebernehmen);
            this.Controls.Add(this.buttonNewHund);
            this.MaximizeBox = false;
            this.Name = "HundeVerwaltung";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.HundeVerwaltung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHundSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountOfBark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHundSizeCurrent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewHund;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBoxHundName;
        private System.Windows.Forms.NumericUpDown numericUpDownHundSize;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn HundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HundSize;
        private System.Windows.Forms.Button buttonBellen;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.NumericUpDown numericUpDownCountOfBark;
        private System.Windows.Forms.TextBox textBoxHundNameCurrent;
        private System.Windows.Forms.NumericUpDown numericUpDownHundSizeCurrent;
        private System.Windows.Forms.Button buttonUebernehmen;
    }
}

