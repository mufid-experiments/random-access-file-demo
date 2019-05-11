using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReaderWinform
{
    class LazyTextReader : IDisposable
    {
        public class ReceivedDataEventArgs : EventArgs
        {
            public ReceivedDataEventArgs(string textData, long offset)
            {
                this.textData = textData;
                this.offset = offset;
            }
            private string textData;
            private long offset;
            public string TextData
            {
                get { return textData; }
            }

            public long Offset
            {
                get { return offset; }
            }
        }

        public event EventHandler<ReceivedDataEventArgs> SeekDoneEvent;

        private string Filename;
        private FileStream FileStream;
        private int WindowSize;
        private long InternalPosition;
        private long InternalFileSizeBytes;

        public LazyTextReader(string Filename, int WindowSize = 1000)
        {
            this.Filename = Filename;
            this.WindowSize = WindowSize;
        }

        public void Close()
        {
            
        }

        public long CurrentOffset
        {
            get { return InternalPosition; }
            set { InternalPosition = value; JumpToPosition(InternalPosition); }
        }

        public long FileSizeBytes
        {
            get { return InternalFileSizeBytes; }
        }

        public void JumpToPosition(long targetPosition)
        {
            this.FileStream.Position = targetPosition;
            this.InternalPosition = targetPosition;
            ReadAfterJumpEvent();
        }

        private void ReadAfterJumpEvent()
        {
            byte[] output = new byte[WindowSize];
            for (int i = 0; i < WindowSize; i++)
            {
                output[i] = (byte)this.FileStream.ReadByte();
            }

            var EventArgs = new ReceivedDataEventArgs(Encoding.UTF8.GetString(output), InternalPosition);
            if (SeekDoneEvent != null)
            {
                SeekDoneEvent(this, EventArgs);
            }
        }

        public void Initialize()
        {
            this.FileStream = new FileStream(Filename, FileMode.Open);
            this.InternalFileSizeBytes = new FileInfo(Filename).Length;
        }
        
        public void Dispose()
        {
            this.FileStream.Dispose();
        }
    }
}
