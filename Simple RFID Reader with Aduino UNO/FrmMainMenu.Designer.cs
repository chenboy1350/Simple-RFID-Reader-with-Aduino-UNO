
namespace Simple_RFID_Reader_with_Aduino_UNO
{
    partial class FrmMainMenu
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
            this.btnDetect = new System.Windows.Forms.Button();
            this.listBoxOutPut = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDetect
            // 
            this.btnDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetect.Location = new System.Drawing.Point(198, 224);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(117, 43);
            this.btnDetect.TabIndex = 0;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // listBoxOutPut
            // 
            this.listBoxOutPut.FormattingEnabled = true;
            this.listBoxOutPut.Location = new System.Drawing.Point(155, 29);
            this.listBoxOutPut.Name = "listBoxOutPut";
            this.listBoxOutPut.Size = new System.Drawing.Size(219, 134);
            this.listBoxOutPut.TabIndex = 1;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 462);
            this.Controls.Add(this.listBoxOutPut);
            this.Controls.Add(this.btnDetect);
            this.Name = "FrmMainMenu";
            this.Text = "RFID Manager";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.ListBox listBoxOutPut;
    }
}

