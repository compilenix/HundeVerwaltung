using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HundeVerwaltung {
    public partial class HundeVerwaltung : Form {
        public const String cTextBoxHundName = "Name";
        public const int cNumericUpDown = 0;
        private BindingList<Hund> listHunde = new BindingList<Hund>();
        DataGridViewSelectedRowCollection dataGridSelectedRowsCollection;

        public HundeVerwaltung() {
            InitializeComponent();
        }

        private void buttonNewHund_Click(object sender, EventArgs e) {
            if (!textBoxHundName.Text.Equals(cTextBoxHundName)) {
                listHunde.Add(new Hund((int)numericUpDownHundSize.Value, textBoxHundName.Text));
                richTextBoxOutput.AppendText("\nEin neuer Hund wurde konstruiert:" + textBoxHundName.Text +" Größe:" +numericUpDownHundSize.Value);
                numericUpDownHundSize.Value = cNumericUpDown;
                textBoxHundName.Text = cTextBoxHundName;
            }
        }

        private void textBoxHundName_Enter(object sender, EventArgs e) {
            if (textBoxHundName.Text.Equals(cTextBoxHundName)) {
                textBoxHundName.Text = "";
            }
        }

        private void textBoxHundName_Leave(object sender, EventArgs e) {
            if (textBoxHundName.Text.Equals("")) {
                textBoxHundName.Text = cTextBoxHundName;
            }
        }

        private void HundeVerwaltung_Load(object sender, EventArgs e) {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = listHunde;
        }

        private void buttonBellen_Click(object sender, EventArgs e) {
            dataGridSelectedRowsCollection = dataGridView.SelectedRows;
            if (numericUpDownCountOfBark.Value > 0 & dataGridSelectedRowsCollection.Count > 0) {
                for (int i = 0; i < numericUpDownCountOfBark.Value; i++) {
                    bark();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            richTextBoxOutput.Clear();
        }

        private void buttonDel_Click(object sender, EventArgs e) {
            dataGridSelectedRowsCollection = dataGridView.SelectedRows;
            if (dataGridSelectedRowsCollection.Count > 0) {
                try {
                    foreach (DataGridViewRow tmpSelRow in dataGridSelectedRowsCollection) {
                        Hund tmpHund = (Hund)tmpSelRow.DataBoundItem;
                        richTextBoxOutput.AppendText("\n" + tmpHund.Name + ": dieser Hund wurde dekonstruiert");
                        listHunde.Remove(tmpHund);
                    }
                } catch (Exception ex) {
                    System.Console.Write(ex.StackTrace);
                }
            }
        }
        private void bark() {
            try {
                foreach (DataGridViewRow tmpSelRow in dataGridSelectedRowsCollection) {
                    Hund tmpHund = (Hund)tmpSelRow.DataBoundItem;
                    richTextBoxOutput.AppendText("\n" + tmpHund.Name + ":" + tmpHund.Bellen());
                }
            } catch (Exception ex) {
                System.Console.Write(ex.StackTrace);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void buttonUebernehmen_Click(object sender, EventArgs e) {
            dataGridSelectedRowsCollection = dataGridView.SelectedRows;
            int tmpHundRow;
            try {
                tmpHundRow = dataGridSelectedRowsCollection[0].Cells[0].RowIndex;
                Hund tmpHund = (Hund)dataGridSelectedRowsCollection[0].DataBoundItem;
                listHunde.Insert(tmpHundRow + 1, new Hund((int)numericUpDownHundSizeCurrent.Value, textBoxHundNameCurrent.Text));
                listHunde.Remove(tmpHund);
            } catch (Exception ex) {
                System.Console.Write(ex.StackTrace);
            }
        }

        private void textBoxHundNameCurrent_Enter(object sender, EventArgs e) {
            if (textBoxHundNameCurrent.Text.Equals(cTextBoxHundName)) {
                textBoxHundNameCurrent.Text = "";
            }
        }

        private void textBoxHundNameCurrent_Leave(object sender, EventArgs e) {
            if (textBoxHundNameCurrent.Text.Equals("")) {
                textBoxHundNameCurrent.Text = cTextBoxHundName;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) {
            dataGridSelectedRowsCollection = dataGridView.SelectedRows;
            if (dataGridSelectedRowsCollection.Count == 1) {
                try {
                    Hund tmpHund = (Hund)dataGridSelectedRowsCollection[0].DataBoundItem;
                    if (!tmpHund.Name.Equals(Hund.cName) || !tmpHund.Size.Equals(Hund.cSize)) {
                        textBoxHundNameCurrent.Text = tmpHund.Name;
                        numericUpDownHundSizeCurrent.Value = tmpHund.Size;
                    } else {
                        textBoxHundNameCurrent.Text = "";
                        numericUpDownHundSizeCurrent.Value = cNumericUpDown;

                    }
                } catch (Exception ex) {
                    System.Console.Write(ex.StackTrace);
                }
            }
        }
    }
}
