namespace Sorting
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textRoot = new System.Windows.Forms.TextBox();
            this.textPrefix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkFileType = new System.Windows.Forms.CheckBox();
            this.FileType = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(107, 316);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(868, 127);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort!";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the auto sorting program.\r\nPlease select the type of sort requested an" +
    "d the root folder you would like to sort.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboSort
            // 
            this.comboSort.FormattingEnabled = true;
            this.comboSort.Items.AddRange(new object[] {
            "Sort JPG",
            "Sort Video (mp4)",
            "Sort PDF",
            "Sort Custom (Insert File Type)"});
            this.comboSort.Location = new System.Drawing.Point(394, 111);
            this.comboSort.Name = "comboSort";
            this.comboSort.Size = new System.Drawing.Size(253, 28);
            this.comboSort.TabIndex = 2;
            this.comboSort.SelectedIndexChanged += new System.EventHandler(this.comboSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SortType";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(667, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Root Folder";
            // 
            // textRoot
            // 
            this.textRoot.Location = new System.Drawing.Point(394, 245);
            this.textRoot.Name = "textRoot";
            this.textRoot.Size = new System.Drawing.Size(253, 26);
            this.textRoot.TabIndex = 6;
            this.textRoot.TextChanged += new System.EventHandler(this.textRoot_TextChanged);
            // 
            // textPrefix
            // 
            this.textPrefix.Location = new System.Drawing.Point(394, 172);
            this.textPrefix.Name = "textPrefix";
            this.textPrefix.Size = new System.Drawing.Size(253, 26);
            this.textPrefix.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textPrefix, "Leave empty for no prefix");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prefix (?)";
            this.toolTip1.SetToolTip(this.label4, "Leave empty for no prefix");
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // checkFileType
            // 
            this.checkFileType.AutoSize = true;
            this.checkFileType.Location = new System.Drawing.Point(667, 113);
            this.checkFileType.Name = "checkFileType";
            this.checkFileType.Size = new System.Drawing.Size(209, 24);
            this.checkFileType.TabIndex = 9;
            this.checkFileType.Text = "Ignore Other File Types?";
            this.FileType.SetToolTip(this.checkFileType, "Will not sort file types of different extensions. ");
            this.checkFileType.UseVisualStyleBackColor = true;
            this.checkFileType.CheckedChanged += new System.EventHandler(this.checkFileType_CheckedChanged);
            // 
            // Form1
            // 
            this.AccessibleDescription = "Autosort Program";
            this.AccessibleName = "Autosort Program";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 480);
            this.Controls.Add(this.checkFileType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrefix);
            this.Controls.Add(this.textRoot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoSorting Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRoot;
        private System.Windows.Forms.TextBox textPrefix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkFileType;
        private System.Windows.Forms.ToolTip FileType;
    }
}

