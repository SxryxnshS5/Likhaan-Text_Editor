using System.Drawing.Printing;
using System.IO;
using Text_Editor.Managers;

namespace Text_Editor {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class MainForm : Form {

        private FileManager fileManager = new FileManager();
        private PrintManager printManager = new PrintManager();


        public MainForm() {
            InitializeComponent();

            // Setup PrintDocument
            printManager.PrintDocument.PrintPage +=
                new System.Drawing.Printing.PrintPageEventHandler(printManager_PrintPage);

            // Setup PrintPreviewDialog
            printManager.PrintPreviewDialog.Document = printManager.PrintDocument;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            fileManager.OpenFile(richTextBox);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            fileManager.SaveFile(richTextBox);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            fileManager.SaveFileAs(richTextBox);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e) {
            printManager.Print(richTextBox);
        }

        private void printManager_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            printManager.PrintPage(richTextBox, e);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            richTextBox.SelectAll();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
            // Display a dialog to get the search text
            string searchText = Prompt.ShowDialog("Enter search text:", "Search");
            if (!string.IsNullOrEmpty(searchText)) {
                FindText(searchText);
            }
        }

        private void FindText(string searchText) {
            int startIndex = 0;
            int index = richTextBox.Find(searchText, startIndex, RichTextBoxFinds.None);
            if (index != -1) {
                richTextBox.Select(index, searchText.Length);
                richTextBox.Focus();
            }
            else {
                MessageBox.Show("Text not found.");
            }
        }

        public static class Prompt {
            public static string ShowDialog(string text, string caption) {
                Form prompt = new Form() {
                    Width = 350,
                    Height = 220,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 120, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 70, Top = 50, Height = 60, Width = 200 };
                Button confirmation = new Button() { Text = "OK", Left = 120, Height = 40, Width = 100, Top = 90, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string url = "https://boldinprints.in/";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}


