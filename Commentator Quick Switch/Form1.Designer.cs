namespace Commentator_Quick_Switch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftName = new System.Windows.Forms.TextBox();
            this.LeftTwitter = new System.Windows.Forms.TextBox();
            this.RightTwitter = new System.Windows.Forms.TextBox();
            this.RightName = new System.Windows.Forms.TextBox();
            this.Switchbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SetLeftbtn = new System.Windows.Forms.Button();
            this.SetRightbtn = new System.Windows.Forms.Button();
            this.NewCommentatorbtn = new System.Windows.Forms.Button();
            this.LoadCommentatorsbtn = new System.Windows.Forms.Button();
            this.FolderDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeftName
            // 
            this.LeftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftName.Location = new System.Drawing.Point(11, 7);
            this.LeftName.Name = "LeftName";
            this.LeftName.ReadOnly = true;
            this.LeftName.Size = new System.Drawing.Size(150, 26);
            this.LeftName.TabIndex = 0;
            this.LeftName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LeftTwitter
            // 
            this.LeftTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftTwitter.Location = new System.Drawing.Point(11, 36);
            this.LeftTwitter.Name = "LeftTwitter";
            this.LeftTwitter.ReadOnly = true;
            this.LeftTwitter.Size = new System.Drawing.Size(150, 26);
            this.LeftTwitter.TabIndex = 1;
            this.LeftTwitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RightTwitter
            // 
            this.RightTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightTwitter.Location = new System.Drawing.Point(236, 36);
            this.RightTwitter.Name = "RightTwitter";
            this.RightTwitter.ReadOnly = true;
            this.RightTwitter.Size = new System.Drawing.Size(150, 26);
            this.RightTwitter.TabIndex = 2;
            this.RightTwitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RightName
            // 
            this.RightName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightName.Location = new System.Drawing.Point(236, 7);
            this.RightName.Name = "RightName";
            this.RightName.ReadOnly = true;
            this.RightName.Size = new System.Drawing.Size(150, 26);
            this.RightName.TabIndex = 3;
            this.RightName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Switchbtn
            // 
            this.Switchbtn.Location = new System.Drawing.Point(161, 23);
            this.Switchbtn.Name = "Switchbtn";
            this.Switchbtn.Size = new System.Drawing.Size(75, 23);
            this.Switchbtn.TabIndex = 4;
            this.Switchbtn.Text = "Switch";
            this.Switchbtn.UseVisualStyleBackColor = true;
            this.Switchbtn.Click += new System.EventHandler(this.Switchbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(161, 101);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(11, 68);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 95);
            this.listBox1.TabIndex = 6;
            // 
            // SetLeftbtn
            // 
            this.SetLeftbtn.AutoSize = true;
            this.SetLeftbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetLeftbtn.Location = new System.Drawing.Point(33, 169);
            this.SetLeftbtn.Name = "SetLeftbtn";
            this.SetLeftbtn.Size = new System.Drawing.Size(54, 23);
            this.SetLeftbtn.TabIndex = 7;
            this.SetLeftbtn.Text = "Set Left";
            this.SetLeftbtn.UseVisualStyleBackColor = true;
            this.SetLeftbtn.Click += new System.EventHandler(this.SetLeftbtn_Click);
            // 
            // SetRightbtn
            // 
            this.SetRightbtn.AutoSize = true;
            this.SetRightbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetRightbtn.Location = new System.Drawing.Point(87, 169);
            this.SetRightbtn.Name = "SetRightbtn";
            this.SetRightbtn.Size = new System.Drawing.Size(61, 23);
            this.SetRightbtn.TabIndex = 8;
            this.SetRightbtn.Text = "Set Right";
            this.SetRightbtn.UseVisualStyleBackColor = true;
            this.SetRightbtn.Click += new System.EventHandler(this.SetRightbtn_Click);
            // 
            // NewCommentatorbtn
            // 
            this.NewCommentatorbtn.AutoSize = true;
            this.NewCommentatorbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewCommentatorbtn.Location = new System.Drawing.Point(259, 169);
            this.NewCommentatorbtn.Name = "NewCommentatorbtn";
            this.NewCommentatorbtn.Size = new System.Drawing.Size(104, 23);
            this.NewCommentatorbtn.TabIndex = 9;
            this.NewCommentatorbtn.Text = "New Commentator";
            this.NewCommentatorbtn.UseVisualStyleBackColor = true;
            this.NewCommentatorbtn.Click += new System.EventHandler(this.NewCommentatorbtn_Click);
            // 
            // LoadCommentatorsbtn
            // 
            this.LoadCommentatorsbtn.AutoSize = true;
            this.LoadCommentatorsbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadCommentatorsbtn.Location = new System.Drawing.Point(148, 169);
            this.LoadCommentatorsbtn.Name = "LoadCommentatorsbtn";
            this.LoadCommentatorsbtn.Size = new System.Drawing.Size(111, 23);
            this.LoadCommentatorsbtn.TabIndex = 10;
            this.LoadCommentatorsbtn.Text = "Load Commentators";
            this.LoadCommentatorsbtn.UseVisualStyleBackColor = true;
            this.LoadCommentatorsbtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // FolderDirectory
            // 
            this.FolderDirectory.Location = new System.Drawing.Point(81, 198);
            this.FolderDirectory.Name = "FolderDirectory";
            this.FolderDirectory.ReadOnly = true;
            this.FolderDirectory.Size = new System.Drawing.Size(293, 20);
            this.FolderDirectory.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Directory:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(396, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderDirectory);
            this.Controls.Add(this.LoadCommentatorsbtn);
            this.Controls.Add(this.NewCommentatorbtn);
            this.Controls.Add(this.SetRightbtn);
            this.Controls.Add(this.SetLeftbtn);
            this.Controls.Add(this.Switchbtn);
            this.Controls.Add(this.RightName);
            this.Controls.Add(this.RightTwitter);
            this.Controls.Add(this.LeftTwitter);
            this.Controls.Add(this.LeftName);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Commentary Switcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LeftName;
        private System.Windows.Forms.TextBox LeftTwitter;
        private System.Windows.Forms.TextBox RightTwitter;
        private System.Windows.Forms.TextBox RightName;
        private System.Windows.Forms.Button Switchbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SetLeftbtn;
        private System.Windows.Forms.Button SetRightbtn;
        private System.Windows.Forms.Button NewCommentatorbtn;
        private System.Windows.Forms.Button LoadCommentatorsbtn;
        private System.Windows.Forms.TextBox FolderDirectory;
        private System.Windows.Forms.Label label1;
    }
}

