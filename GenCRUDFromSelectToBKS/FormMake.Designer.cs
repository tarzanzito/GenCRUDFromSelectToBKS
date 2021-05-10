namespace MakeCRUDFromSelect
{
    partial class FormMake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMake));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxLeft = new System.Windows.Forms.TextBox();
            this.textBoxRight = new System.Windows.Forms.TextBox();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGenerateCRUD = new System.Windows.Forms.Button();
            this.panelFill1 = new System.Windows.Forms.Panel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelButtom.SuspendLayout();
            this.panelFill1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLeft);
            this.splitContainer1.Panel1MinSize = 5;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxRight);
            this.splitContainer1.Size = new System.Drawing.Size(614, 342);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 63;
            // 
            // textBoxLeft
            // 
            this.textBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.textBoxLeft.Multiline = true;
            this.textBoxLeft.Name = "textBoxLeft";
            this.textBoxLeft.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLeft.Size = new System.Drawing.Size(306, 342);
            this.textBoxLeft.TabIndex = 3;
            this.textBoxLeft.Text = "SELECT\r\n    ZPROPOST,\r\n    ZNIVEL,\r\n    CPRDLM,\r\n    CMOEDA,\r\n    CKUTULMO,\r\n    " +
    "HTIMEST\r\nFROM \r\nDBSDESX.WIVT08A0_MOEDAS\r\n\r\n               ";
            // 
            // textBoxRight
            // 
            this.textBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRight.Location = new System.Drawing.Point(0, 0);
            this.textBoxRight.Multiline = true;
            this.textBoxRight.Name = "textBoxRight";
            this.textBoxRight.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRight.Size = new System.Drawing.Size(304, 342);
            this.textBoxRight.TabIndex = 4;
            // 
            // panelButtom
            // 
            this.panelButtom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelButtom.Controls.Add(this.buttonClose);
            this.panelButtom.Controls.Add(this.buttonGenerateCRUD);
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtom.Location = new System.Drawing.Point(5, 357);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(624, 48);
            this.panelButtom.TabIndex = 64;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonClose.Location = new System.Drawing.Point(523, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(86, 30);
            this.buttonClose.TabIndex = 54;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateCRUD
            // 
            this.buttonGenerateCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateCRUD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGenerateCRUD.Location = new System.Drawing.Point(383, 12);
            this.buttonGenerateCRUD.Name = "buttonGenerateCRUD";
            this.buttonGenerateCRUD.Size = new System.Drawing.Size(105, 30);
            this.buttonGenerateCRUD.TabIndex = 51;
            this.buttonGenerateCRUD.Text = "Generate CRUD";
            this.buttonGenerateCRUD.UseVisualStyleBackColor = true;
            this.buttonGenerateCRUD.Click += new System.EventHandler(this.buttonGenerateCRUD_Click);
            // 
            // panelFill1
            // 
            this.panelFill1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelFill1.Controls.Add(this.splitContainer1);
            this.panelFill1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill1.Location = new System.Drawing.Point(5, 5);
            this.panelFill1.Name = "panelFill1";
            this.panelFill1.Padding = new System.Windows.Forms.Padding(5);
            this.panelFill1.Size = new System.Drawing.Size(624, 352);
            this.panelFill1.TabIndex = 65;
            // 
            // FormMake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 410);
            this.Controls.Add(this.panelFill1);
            this.Controls.Add(this.panelButtom);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(280, 300);
            this.Name = "FormMake";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate CRUD from Select Statements To BankSphere SqlComponent";
            this.Load += new System.EventHandler(this.FormMake_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.panelButtom.ResumeLayout(false);
            this.panelFill1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxLeft;
        private System.Windows.Forms.TextBox textBoxRight;
        private System.Windows.Forms.Panel panelButtom;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonGenerateCRUD;
        private System.Windows.Forms.Panel panelFill1;


    }
}