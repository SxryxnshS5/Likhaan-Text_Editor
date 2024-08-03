using System.IO;
using System.Windows.Forms;

namespace Text_Editor.Managers {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FileManager {

        private string currentFilePath = string.Empty;

        public void OpenFile(RichTextBox richTextBox) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    currentFilePath = openFileDialog.FileName;
                    richTextBox.Text = File.ReadAllText(currentFilePath);
                }
            }
        }

        public void SaveFile(RichTextBox richTextBox) {
            if (string.IsNullOrEmpty(currentFilePath)) {
                SaveFileAs(richTextBox);
            }
            else {
                File.WriteAllText(currentFilePath, richTextBox.Text);
            }
        }

        public void SaveFileAs(RichTextBox richTextBox) {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    currentFilePath = saveFileDialog.FileName;
                    File.WriteAllText(currentFilePath, richTextBox.Text);
                }
            }
        }
    }
}