
namespace Quiz_That_Tune
{
    partial class fParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fParams));
            this.lbMusicList = new System.Windows.Forms.ListBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btbSelectFolder = new System.Windows.Forms.Button();
            this.cbAllDirectories = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMusicList
            // 
            this.lbMusicList.FormattingEnabled = true;
            this.lbMusicList.ItemHeight = 16;
            this.lbMusicList.Location = new System.Drawing.Point(0, 0);
            this.lbMusicList.Name = "lbMusicList";
            this.lbMusicList.Size = new System.Drawing.Size(800, 244);
            this.lbMusicList.TabIndex = 0;
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.ForeColor = System.Drawing.Color.Blue;
            this.btnClearList.Location = new System.Drawing.Point(12, 256);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(232, 77);
            this.btnClearList.TabIndex = 1;
            this.btnClearList.Text = "Очистить список";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // btbSelectFolder
            // 
            this.btbSelectFolder.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSelectFolder.ForeColor = System.Drawing.Color.Blue;
            this.btbSelectFolder.Location = new System.Drawing.Point(281, 256);
            this.btbSelectFolder.Name = "btbSelectFolder";
            this.btbSelectFolder.Size = new System.Drawing.Size(225, 77);
            this.btbSelectFolder.TabIndex = 2;
            this.btbSelectFolder.Text = "Выбрать папку";
            this.btbSelectFolder.UseVisualStyleBackColor = true;
            // 
            // cbAllDirectories
            // 
            this.cbAllDirectories.AutoSize = true;
            this.cbAllDirectories.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllDirectories.Location = new System.Drawing.Point(543, 277);
            this.cbAllDirectories.Name = "cbAllDirectories";
            this.cbAllDirectories.Size = new System.Drawing.Size(247, 37);
            this.cbAllDirectories.TabIndex = 3;
            this.cbAllDirectories.Text = "Вложенные папки";
            this.cbAllDirectories.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Green;
            this.btnOK.Location = new System.Drawing.Point(489, 372);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 48);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(643, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // fParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(802, 432);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbAllDirectories);
            this.Controls.Add(this.btbSelectFolder);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.lbMusicList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fParams";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMusicList;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btbSelectFolder;
        private System.Windows.Forms.CheckBox cbAllDirectories;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}