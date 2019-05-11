namespace TextReaderWinform
{
    partial class MainForm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentPos = new System.Windows.Forms.TextBox();
            this.btnScrollUp = new System.Windows.Forms.Button();
            this.btnScrollDown = new System.Windows.Forms.Button();
            this.lblFileLength = new System.Windows.Forms.Label();
            this.groupMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(495, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Tidak sedang membuka berkas apapun. Seret sembarang berkas ke jendela ini untuk m" +
    "embuka berkas";
            // 
            // txtMain
            // 
            this.txtMain.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.Location = new System.Drawing.Point(6, 19);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(761, 359);
            this.txtMain.TabIndex = 1;
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.lblFileLength);
            this.groupMain.Controls.Add(this.label1);
            this.groupMain.Controls.Add(this.txtCurrentPos);
            this.groupMain.Controls.Add(this.btnScrollUp);
            this.groupMain.Controls.Add(this.btnScrollDown);
            this.groupMain.Controls.Add(this.txtMain);
            this.groupMain.Location = new System.Drawing.Point(15, 25);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(773, 413);
            this.groupMain.TabIndex = 2;
            this.groupMain.TabStop = false;
            this.groupMain.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menampilkan:";
            // 
            // txtCurrentPos
            // 
            this.txtCurrentPos.Location = new System.Drawing.Point(86, 386);
            this.txtCurrentPos.Name = "txtCurrentPos";
            this.txtCurrentPos.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPos.TabIndex = 3;
            this.txtCurrentPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPos_KeyPress);
            // 
            // btnScrollUp
            // 
            this.btnScrollUp.Location = new System.Drawing.Point(610, 384);
            this.btnScrollUp.Name = "btnScrollUp";
            this.btnScrollUp.Size = new System.Drawing.Size(75, 23);
            this.btnScrollUp.TabIndex = 2;
            this.btnScrollUp.Text = "Ke Atas";
            this.btnScrollUp.UseVisualStyleBackColor = true;
            this.btnScrollUp.Click += new System.EventHandler(this.btnScrollUp_Click);
            // 
            // btnScrollDown
            // 
            this.btnScrollDown.Location = new System.Drawing.Point(691, 384);
            this.btnScrollDown.Name = "btnScrollDown";
            this.btnScrollDown.Size = new System.Drawing.Size(75, 23);
            this.btnScrollDown.TabIndex = 2;
            this.btnScrollDown.Text = "Ke Bawah";
            this.btnScrollDown.UseVisualStyleBackColor = true;
            this.btnScrollDown.Click += new System.EventHandler(this.btnScrollDown_Click);
            // 
            // lblFileLength
            // 
            this.lblFileLength.AutoSize = true;
            this.lblFileLength.Location = new System.Drawing.Point(192, 389);
            this.lblFileLength.Name = "lblFileLength";
            this.lblFileLength.Size = new System.Drawing.Size(68, 13);
            this.lblFileLength.TabIndex = 5;
            this.lblFileLength.Text = "dari %s bytes";
            this.lblFileLength.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupMain);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pembaca Teks";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentPos;
        private System.Windows.Forms.Button btnScrollUp;
        private System.Windows.Forms.Button btnScrollDown;
        private System.Windows.Forms.Label lblFileLength;
    }
}

