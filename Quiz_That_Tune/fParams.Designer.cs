
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
            this.gbGameSettings = new System.Windows.Forms.GroupBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbGameSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMusicList
            // 
            this.lbMusicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbMusicList.FormattingEnabled = true;
            this.lbMusicList.ItemHeight = 16;
            this.lbMusicList.Location = new System.Drawing.Point(0, 0);
            this.lbMusicList.Name = "lbMusicList";
            this.lbMusicList.Size = new System.Drawing.Size(883, 244);
            this.lbMusicList.TabIndex = 0;
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.ForeColor = System.Drawing.Color.Blue;
            this.btnClearList.Location = new System.Drawing.Point(308, 256);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(244, 58);
            this.btnClearList.TabIndex = 1;
            this.btnClearList.Text = "Очистить список";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // btbSelectFolder
            // 
            this.btbSelectFolder.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSelectFolder.ForeColor = System.Drawing.Color.Blue;
            this.btbSelectFolder.Location = new System.Drawing.Point(12, 256);
            this.btbSelectFolder.Name = "btbSelectFolder";
            this.btbSelectFolder.Size = new System.Drawing.Size(225, 58);
            this.btbSelectFolder.TabIndex = 2;
            this.btbSelectFolder.Text = "Выбрать папку";
            this.btbSelectFolder.UseVisualStyleBackColor = true;
            this.btbSelectFolder.Click += new System.EventHandler(this.btbSelectFolder_Click);
            // 
            // cbAllDirectories
            // 
            this.cbAllDirectories.AutoSize = true;
            this.cbAllDirectories.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllDirectories.Location = new System.Drawing.Point(594, 268);
            this.cbAllDirectories.Name = "cbAllDirectories";
            this.cbAllDirectories.Size = new System.Drawing.Size(247, 37);
            this.cbAllDirectories.TabIndex = 3;
            this.cbAllDirectories.Text = "Вложенные папки";
            this.cbAllDirectories.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(734, 339);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 48);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(734, 561);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbGameSettings
            // 
            this.gbGameSettings.Controls.Add(this.cbRandomStart);
            this.gbGameSettings.Controls.Add(this.cbMusicDuration);
            this.gbGameSettings.Controls.Add(this.cbGameDuration);
            this.gbGameSettings.Controls.Add(this.label2);
            this.gbGameSettings.Controls.Add(this.label1);
            this.gbGameSettings.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGameSettings.Location = new System.Drawing.Point(12, 339);
            this.gbGameSettings.Name = "gbGameSettings";
            this.gbGameSettings.Size = new System.Drawing.Size(511, 283);
            this.gbGameSettings.TabIndex = 6;
            this.gbGameSettings.TabStop = false;
            this.gbGameSettings.Text = "Настройки игры";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(497, 501);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(101, 29);
            this.lblPlayer2.TabIndex = 10;
            this.lblPlayer2.Text = "Игрок 2";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbRandomStart.Location = new System.Drawing.Point(12, 222);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(389, 37);
            this.cbRandomStart.TabIndex = 7;
            this.cbRandomStart.Text = "Начинать со случайного места";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.cbMusicDuration.Location = new System.Drawing.Point(358, 156);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(121, 39);
            this.cbMusicDuration.TabIndex = 8;
            this.cbMusicDuration.Text = "20";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cbGameDuration.Location = new System.Drawing.Point(358, 86);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(121, 39);
            this.cbGameDuration.TabIndex = 7;
            this.cbGameDuration.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время на ответ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность игры";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(497, 431);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(101, 29);
            this.lblPlayer1.TabIndex = 9;
            this.lblPlayer1.Text = "Игрок 1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(604, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 34);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Q";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(604, 500);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 34);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "P";
            // 
            // fParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(882, 623);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gbGameSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbAllDirectories);
            this.Controls.Add(this.btbSelectFolder);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.lbMusicList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fParams";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fParams_Load);
            this.gbGameSettings.ResumeLayout(false);
            this.gbGameSettings.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbGameSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}