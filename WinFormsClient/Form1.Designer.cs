namespace WinFormsClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.User = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.Label();
            this.MessageLB = new System.Windows.Forms.ListBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(12, 370);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(36, 16);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            // 
            // MessageText
            // 
            this.MessageText.AutoSize = true;
            this.MessageText.Location = new System.Drawing.Point(12, 409);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(33, 16);
            this.MessageText.TabIndex = 1;
            this.MessageText.Text = "Text";
            // 
            // MessageLB
            // 
            this.MessageLB.FormattingEnabled = true;
            this.MessageLB.ItemHeight = 16;
            this.MessageLB.Location = new System.Drawing.Point(12, 12);
            this.MessageLB.Name = "MessageLB";
            this.MessageLB.Size = new System.Drawing.Size(665, 340);
            this.MessageLB.TabIndex = 2;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(684, 370);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(104, 68);
            this.SendBtn.TabIndex = 3;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(84, 370);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(256, 22);
            this.UserBox.TabIndex = 4;
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(84, 409);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(593, 22);
            this.MessageBox.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.MessageLB);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.User);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label MessageText;
        private System.Windows.Forms.ListBox MessageLB;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Timer timer1;
    }
}

