
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
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(314, 168);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(79, 29);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(76, 331);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(180, 55);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Да";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(453, 331);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(180, 55);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "Нет";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // lblMessageQuestion
            // 
            this.lblMessageQuestion.AutoSize = true;
            this.lblMessageQuestion.Font = new System.Drawing.Font("Comic Sans MS", 34.2F);
            this.lblMessageQuestion.Location = new System.Drawing.Point(75, 197);
            this.lblMessageQuestion.Name = "lblMessageQuestion";
            this.lblMessageQuestion.Size = new System.Drawing.Size(558, 81);
            this.lblMessageQuestion.TabIndex = 3;
            this.lblMessageQuestion.Text = "дал верный ответ?";
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
            this.lblTimerToGiveAnAnswer.Location = new System.Drawing.Point(321, 41);
            this.lblTimerToGiveAnAnswer.Name = "lblTimerToGiveAnAnswer";
            this.lblTimerToGiveAnAnswer.Size = new System.Drawing.Size(72, 84);
            this.lblTimerToGiveAnAnswer.TabIndex = 4;
            this.lblTimerToGiveAnAnswer.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Время на ответ";
            // 
            // fMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimerToGiveAnAnswer);
            this.Controls.Add(this.lblMessageQuestion);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblMessage);
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
    }
}