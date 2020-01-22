namespace DataStructureConvertor
{
    partial class UrlDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrlDialog));
            this.tbInputUrlDialog = new System.Windows.Forms.TextBox();
            this.lblUrlDialog = new System.Windows.Forms.Label();
            this.btnOKUrlDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInputUrlDialog
            // 
            this.tbInputUrlDialog.Location = new System.Drawing.Point(12, 33);
            this.tbInputUrlDialog.Multiline = true;
            this.tbInputUrlDialog.Name = "tbInputUrlDialog";
            this.tbInputUrlDialog.Size = new System.Drawing.Size(347, 28);
            this.tbInputUrlDialog.TabIndex = 0;
            this.tbInputUrlDialog.TextChanged += new System.EventHandler(this.tbInputUrlDialog_TextChanged);
            // 
            // lblUrlDialog
            // 
            this.lblUrlDialog.AutoSize = true;
            this.lblUrlDialog.Location = new System.Drawing.Point(12, 9);
            this.lblUrlDialog.Name = "lblUrlDialog";
            this.lblUrlDialog.Size = new System.Drawing.Size(130, 13);
            this.lblUrlDialog.TabIndex = 1;
            this.lblUrlDialog.Text = "Enter your URL(endpoint):";
            this.lblUrlDialog.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOKUrlDialog
            // 
            this.btnOKUrlDialog.Location = new System.Drawing.Point(141, 70);
            this.btnOKUrlDialog.Name = "btnOKUrlDialog";
            this.btnOKUrlDialog.Size = new System.Drawing.Size(75, 23);
            this.btnOKUrlDialog.TabIndex = 2;
            this.btnOKUrlDialog.Text = "Set URL";
            this.btnOKUrlDialog.UseVisualStyleBackColor = true;
            this.btnOKUrlDialog.Click += new System.EventHandler(this.btnOKUrlDialog_Click);
            // 
            // UrlDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 105);
            this.Controls.Add(this.btnOKUrlDialog);
            this.Controls.Add(this.lblUrlDialog);
            this.Controls.Add(this.tbInputUrlDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UrlDialog";
            this.Text = "url";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputUrlDialog;
        private System.Windows.Forms.Label lblUrlDialog;
        private System.Windows.Forms.Button btnOKUrlDialog;
    }
}