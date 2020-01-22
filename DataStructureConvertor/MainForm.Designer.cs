namespace DataStructureConvertor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.cbInput = new System.Windows.Forms.ComboBox();
            this.cbOutput = new System.Windows.Forms.ComboBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOuput = new System.Windows.Forms.Label();
            this.btnSetInput = new System.Windows.Forms.Button();
            this.btnSetOutput = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.gbInput.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.btnSetInput);
            this.gbInput.Controls.Add(this.lblInput);
            this.gbInput.Controls.Add(this.cbInput);
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(346, 100);
            this.gbInput.TabIndex = 0;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.btnSetOutput);
            this.gbOutput.Controls.Add(this.lblOuput);
            this.gbOutput.Controls.Add(this.cbOutput);
            this.gbOutput.Location = new System.Drawing.Point(364, 12);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(346, 100);
            this.gbOutput.TabIndex = 1;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Output";
            // 
            // cbInput
            // 
            this.cbInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInput.FormattingEnabled = true;
            this.cbInput.Location = new System.Drawing.Point(6, 19);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(334, 21);
            this.cbInput.TabIndex = 0;
            this.cbInput.SelectedIndexChanged += new System.EventHandler(this.cbInput_SelectedIndexChanged);
            // 
            // cbOutput
            // 
            this.cbOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutput.FormattingEnabled = true;
            this.cbOutput.Location = new System.Drawing.Point(6, 19);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(334, 21);
            this.cbOutput.TabIndex = 0;
            this.cbOutput.SelectedIndexChanged += new System.EventHandler(this.cbOutput_SelectedIndexChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(7, 81);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(35, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "label1";
            // 
            // lblOuput
            // 
            this.lblOuput.AutoSize = true;
            this.lblOuput.Location = new System.Drawing.Point(7, 81);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(35, 13);
            this.lblOuput.TabIndex = 1;
            this.lblOuput.Text = "label2";
            // 
            // btnSetInput
            // 
            this.btnSetInput.Location = new System.Drawing.Point(195, 46);
            this.btnSetInput.Name = "btnSetInput";
            this.btnSetInput.Size = new System.Drawing.Size(145, 23);
            this.btnSetInput.TabIndex = 2;
            this.btnSetInput.Text = "Set input";
            this.btnSetInput.UseVisualStyleBackColor = true;
            this.btnSetInput.Click += new System.EventHandler(this.btnSetInput_Click);
            // 
            // btnSetOutput
            // 
            this.btnSetOutput.Location = new System.Drawing.Point(204, 46);
            this.btnSetOutput.Name = "btnSetOutput";
            this.btnSetOutput.Size = new System.Drawing.Size(136, 23);
            this.btnSetOutput.TabIndex = 2;
            this.btnSetOutput.Text = "Set output";
            this.btnSetOutput.UseVisualStyleBackColor = true;
            this.btnSetOutput.Click += new System.EventHandler(this.btnSetOutput_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(462, 131);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(242, 50);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 196);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataConvertor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.ComboBox cbInput;
        private System.Windows.Forms.GroupBox gbOutput;
        private System.Windows.Forms.ComboBox cbOutput;
        private System.Windows.Forms.Button btnSetInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnSetOutput;
        private System.Windows.Forms.Label lblOuput;
        private System.Windows.Forms.Button btnConvert;
    }
}