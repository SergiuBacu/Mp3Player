namespace Mp3Player
{
    partial class JumpToFile
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
            this.JumpListBox = new System.Windows.Forms.ListBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JumpListBox
            // 
            this.JumpListBox.FormattingEnabled = true;
            this.JumpListBox.HorizontalScrollbar = true;
            this.JumpListBox.Location = new System.Drawing.Point(12, 58);
            this.JumpListBox.Name = "JumpListBox";
            this.JumpListBox.Size = new System.Drawing.Size(260, 238);
            this.JumpListBox.TabIndex = 0;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(12, 24);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(260, 20);
            this.SearchBar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Jump To File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Jump_To_File_Button);
            // 
            // JumpToFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.JumpListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JumpToFile";
            this.Text = "JumpToFile";
            this.Load += new System.EventHandler(this.JumpToFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox JumpListBox;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Button button1;
    }
}