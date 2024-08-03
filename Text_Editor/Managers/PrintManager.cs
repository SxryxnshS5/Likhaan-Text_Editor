using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace Text_Editor.Managers {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PrintManager {

        public PrintDocument PrintDocument { get; private set; } = new PrintDocument();
        public PrintPreviewDialog PrintPreviewDialog { get; private set; } = new PrintPreviewDialog();

        public void Print(RichTextBox richTextBox) {
            PrintPreviewDialog.Document = PrintDocument;
            PrintDocument.PrintPage += (sender, e) => PrintPage(richTextBox, e);
            PrintPreviewDialog.ShowDialog();
        }

        public void PrintPage(RichTextBox richTextBox, PrintPageEventArgs e) {
            e.Graphics.DrawString(richTextBox.Text, richTextBox.Font, Brushes.Black, e.MarginBounds);
        }
    }
}