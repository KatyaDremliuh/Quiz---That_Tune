
namespace Quiz_That_Tune
{
    partial class fGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btbNext = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblScorePlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblScorePlayer2 = new System.Windows.Forms.Label();
            this.btbPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblSongsCounter = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblMusicDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(12, 366);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(216, 75);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // btbNext
            // 
            this.btbNext.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbNext.Location = new System.Drawing.Point(12, 268);
            this.btbNext.Name = "btbNext";
            this.btbNext.Size = new System.Drawing.Size(216, 78);
            this.btbNext.TabIndex = 1;
            this.btbNext.Text = "Следующая";
            this.btbNext.UseVisualStyleBackColor = true;
            this.btbNext.Click += new System.EventHandler(this.btbNext_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPlayer1.Location = new System.Drawing.Point(35, 37);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(110, 31);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Игрок 1";
            // 
            // lblScorePlayer1
            // 
            this.lblScorePlayer1.AutoSize = true;
            this.lblScorePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScorePlayer1.Location = new System.Drawing.Point(70, 114);
            this.lblScorePlayer1.Name = "lblScorePlayer1";
            this.lblScorePlayer1.Size = new System.Drawing.Size(36, 39);
            this.lblScorePlayer1.TabIndex = 3;
            this.lblScorePlayer1.Text = "0";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPlayer2.Location = new System.Drawing.Point(596, 37);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(110, 31);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Игрок 2";
            // 
            // lblScorePlayer2
            // 
            this.lblScorePlayer2.AutoSize = true;
            this.lblScorePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScorePlayer2.Location = new System.Drawing.Point(638, 114);
            this.lblScorePlayer2.Name = "lblScorePlayer2";
            this.lblScorePlayer2.Size = new System.Drawing.Size(36, 39);
            this.lblScorePlayer2.TabIndex = 5;
            this.lblScorePlayer2.Text = "0";
            // 
            // btbPause
            // 
            this.btbPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btbPause.Location = new System.Drawing.Point(258, 268);
            this.btbPause.Name = "btbPause";
            this.btbPause.Size = new System.Drawing.Size(216, 78);
            this.btbPause.TabIndex = 6;
            this.btbPause.Text = "Пауза";
            this.btbPause.UseVisualStyleBackColor = true;
            this.btbPause.Click += new System.EventHandler(this.btbPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnContinue.Location = new System.Drawing.Point(513, 268);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(254, 78);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblSongsCounter
            // 
            this.lblSongsCounter.AutoSize = true;
            this.lblSongsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSongsCounter.Location = new System.Drawing.Point(351, 114);
            this.lblSongsCounter.Name = "lblSongsCounter";
            this.lblSongsCounter.Size = new System.Drawing.Size(36, 39);
            this.lblSongsCounter.TabIndex = 8;
            this.lblSongsCounter.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 204);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(755, 35);
            this.progressBar.TabIndex = 9;
            this.progressBar.Value = 50;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblMusicDuration
            // 
            this.lblMusicDuration.AutoSize = true;
            this.lblMusicDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicDuration.Location = new System.Drawing.Point(351, 37);
            this.lblMusicDuration.Name = "lblMusicDuration";
            this.lblMusicDuration.Size = new System.Drawing.Size(36, 39);
            this.lblMusicDuration.TabIndex = 10;
            this.lblMusicDuration.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Количество песен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Время на ответ";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMusicDuration);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblSongsCounter);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btbPause);
            this.Controls.Add(this.lblScorePlayer2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblScorePlayer1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btbNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "fGame";
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGame_FormClosed);
            this.Load += new System.EventHandler(this.fGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btbNext;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblScorePlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblScorePlayer2;
        private System.Windows.Forms.Button btbPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblSongsCounter;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblMusicDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}