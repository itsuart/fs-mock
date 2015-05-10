namespace FsMock
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
            this.btnNewMock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewMock
            // 
            this.btnNewMock.Location = new System.Drawing.Point(54, 104);
            this.btnNewMock.Name = "btnNewMock";
            this.btnNewMock.Size = new System.Drawing.Size(170, 23);
            this.btnNewMock.TabIndex = 0;
            this.btnNewMock.Text = "New FS Mock...";
            this.btnNewMock.UseVisualStyleBackColor = true;
            this.btnNewMock.Click += new System.EventHandler(this.btnNewMock_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.btnNewMock);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FS Mock Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewMock;
    }
}

