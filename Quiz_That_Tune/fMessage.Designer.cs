
namespace Quiz_That_Tune
{
    partial class fMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMessage));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblMessageQuestion = new System.Windows.Forms.Label();
            this.timerForGiveAnAnswer = new System.Windows.Forms.Timer(this.components);
            this.lblTimerToGiveAnAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowTheCorrectAnswer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(162, 287);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(97, 42);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(26, 477);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(180, 55);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(409, 477);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(180, 55);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // lblMessageQuestion
            // 
            this.lblMessageQuestion.AutoSize = true;
            this.lblMessageQuestion.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageQuestion.Location = new System.Drawing.Point(217, 348);
            this.lblMessageQuestion.Name = "lblMessageQuestion";
            this.lblMessageQuestion.Size = new System.Drawing.Size(302, 67);
            this.lblMessageQuestion.TabIndex = 3;
            this.lblMessageQuestion.Text = "earn points?";
            // 
            // timerForGiveAnAnswer
            // 
            this.timerForGiveAnAnswer.Interval = 1000;
            this.timerForGiveAnAnswer.Tick += new System.EventHandler(this.timerForGiveAnAnswer_Tick);
            // 
            // lblTimerToGiveAnAnswer
            // 
            this.lblTimerToGiveAnAnswer.AutoSize = true;
            this.lblTimerToGiveAnAnswer.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerToGiveAnAnswer.Location = new System.Drawing.Point(458, 45);
            this.lblTimerToGiveAnAnswer.Name = "lblTimerToGiveAnAnswer";
            this.lblTimerToGiveAnAnswer.Size = new System.Drawing.Size(72, 84);
            this.lblTimerToGiveAnAnswer.TabIndex = 4;
            this.lblTimerToGiveAnAnswer.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time to give the answer:";
            // 
            // lblShowTheCorrectAnswer
            // 
            this.lblShowTheCorrectAnswer.AutoSize = true;
            this.lblShowTheCorrectAnswer.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTheCorrectAnswer.Location = new System.Drawing.Point(12, 610);
            this.lblShowTheCorrectAnswer.Name = "lblShowTheCorrectAnswer";
            this.lblShowTheCorrectAnswer.Size = new System.Drawing.Size(507, 42);
            this.lblShowTheCorrectAnswer.TabIndex = 6;
            this.lblShowTheCorrectAnswer.Text = "Press here to find out the answer…";
            this.lblShowTheCorrectAnswer.Click += new System.EventHandler(this.lblShowTheCorrectAnswer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 67);
            this.label2.TabIndex = 7;
            this.label2.Text = "Does";
            // 
            // fMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShowTheCorrectAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimerToGiveAnAnswer);
            this.Controls.Add(this.lblMessageQuestion);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMessage_FormClosed);
            this.Load += new System.EventHandler(this.fMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        public System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMessageQuestion;
        private System.Windows.Forms.Timer timerForGiveAnAnswer;
        private System.Windows.Forms.Label lblTimerToGiveAnAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShowTheCorrectAnswer;
        private System.Windows.Forms.Label label2;
    }
}