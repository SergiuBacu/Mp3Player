namespace Mp3Player
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
            this.Playlist = new System.Windows.Forms.ListBox();
            this.ClearList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Playlist
            // 
            this.Playlist.FormattingEnabled = true;
            this.Playlist.HorizontalScrollbar = true;
            this.Playlist.Location = new System.Drawing.Point(287, 24);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(208, 251);
            this.Playlist.TabIndex = 0;
            // 
            // ClearList
            // 
            this.ClearList.Location = new System.Drawing.Point(366, 281);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(57, 40);
            this.ClearList.TabIndex = 2;
            this.ClearList.Text = "Clear";
            this.ClearList.UseVisualStyleBackColor = true;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // button3
            // 
            this.button3.Image = global::Mp3Player.Properties.Resources.Stop_Button;
            this.button3.Location = new System.Drawing.Point(164, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 33);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Stop_Button);
            // 
            // button2
            // 
            this.button2.Image = global::Mp3Player.Properties.Resources.Backwards_Button_3;
            this.button2.Location = new System.Drawing.Point(23, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 33);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Backwards_Button);
            // 
            // button1
            // 
            this.button1.Image = global::Mp3Player.Properties.Resources.Forward_Button;
            this.button1.Location = new System.Drawing.Point(211, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 33);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Forward_Button);
            // 
            // PauseButton
            // 
            this.PauseButton.Image = global::Mp3Player.Properties.Resources.Pause_Button_15;
            this.PauseButton.Location = new System.Drawing.Point(117, 40);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(41, 33);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // Load
            // 
            this.Load.Image = global::Mp3Player.Properties.Resources.Load_Button_5122;
            this.Load.Location = new System.Drawing.Point(287, 281);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(57, 40);
            this.Load.TabIndex = 3;
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Image = global::Mp3Player.Properties.Resources.Play_Button_15;
            this.PlayButton.Location = new System.Drawing.Point(70, 40);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(41, 33);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 327);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Playlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

