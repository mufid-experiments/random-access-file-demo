using System;
using System.Windows.Forms;

namespace TextReaderWinform
{
    public partial class MainForm : Form
    {
        private LazyTextReader lazyReader;
        private int CharacterBufferSize = 5000;
        private int ScrollLength = 100;
        private bool Updating = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }

            var data = e.Data.GetData(DataFormats.FileDrop) as string[];

            if (data.Length == 0)
            {
                return;
            }

            initLazyReader(data[0]);
        }

        private void initLazyReader(string v)
        {
            groupMain.Visible = true;

            lblInfo.Text = $"Menampilkan berkas: {v}";
            if (lazyReader != null)
            {
                lazyReader.Close();
                lazyReader.Dispose();
                lazyReader.SeekDoneEvent -= DataReceivedAfterSeek;
            }

            lazyReader = new LazyTextReader(v, CharacterBufferSize);
            lazyReader.SeekDoneEvent += DataReceivedAfterSeek;

            lazyReader.Initialize();
            lazyReader.JumpToPosition(0);
            lblFileLength.Text = $"dari {lazyReader.FileSizeBytes} bytes";
        }

        private void DataReceivedAfterSeek(object sender, LazyTextReader.ReceivedDataEventArgs e)
        {
            txtMain.Text = e.TextData;
            if (Updating)
            {
                return;
            }
            Updating = true;
            txtCurrentPos.Text = e.Offset.ToString();
            Updating = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnScrollUp_Click(object sender, EventArgs e)
        {
            lazyReader.CurrentOffset -= ScrollLength;
        }

        private void btnScrollDown_Click(object sender, EventArgs e)
        {
            lazyReader.CurrentOffset += ScrollLength;
        }

        private void txtCurrentPos_KeyPress(object sender, KeyPressEventArgs e)
        {
            long value = -1;
            try
            {
                value = long.Parse(((TextBox)sender).Text);
            } finally { }

            if (value > 0)
            {
                Updating = true;
                lazyReader.CurrentOffset = value;
                Updating = false;
            }
        }
    }
}
