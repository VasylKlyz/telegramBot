namespace bot_crypto
{
    partial class mainform
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInitialize = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tpEditText = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbEditUser = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tbEditSubscribe = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpInitialize.SuspendLayout();
            this.tpEditText.SuspendLayout();
            this.tbEditUser.SuspendLayout();
            this.tbEditSubscribe.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInitialize);
            this.tabControl1.Controls.Add(this.tpEditText);
            this.tabControl1.Controls.Add(this.tbEditUser);
            this.tabControl1.Controls.Add(this.tbEditSubscribe);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tpInitialize
            // 
            this.tpInitialize.Controls.Add(this.label3);
            this.tpInitialize.Controls.Add(this.textBox3);
            this.tpInitialize.Controls.Add(this.label2);
            this.tpInitialize.Controls.Add(this.textBox2);
            this.tpInitialize.Controls.Add(this.label1);
            this.tpInitialize.Controls.Add(this.textBox1);
            this.tpInitialize.Controls.Add(this.button1);
            this.tpInitialize.Location = new System.Drawing.Point(4, 22);
            this.tpInitialize.Name = "tpInitialize";
            this.tpInitialize.Padding = new System.Windows.Forms.Padding(3);
            this.tpInitialize.Size = new System.Drawing.Size(768, 400);
            this.tpInitialize.TabIndex = 0;
            this.tpInitialize.Text = "Инициализация бота";
            this.tpInitialize.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bot Hash";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ApiHash";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Api Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tpEditText
            // 
            this.tpEditText.Controls.Add(this.button2);
            this.tpEditText.Controls.Add(this.label8);
            this.tpEditText.Controls.Add(this.textBox8);
            this.tpEditText.Controls.Add(this.label7);
            this.tpEditText.Controls.Add(this.textBox7);
            this.tpEditText.Controls.Add(this.label6);
            this.tpEditText.Controls.Add(this.textBox6);
            this.tpEditText.Controls.Add(this.label5);
            this.tpEditText.Controls.Add(this.textBox5);
            this.tpEditText.Controls.Add(this.label4);
            this.tpEditText.Controls.Add(this.textBox4);
            this.tpEditText.Location = new System.Drawing.Point(4, 22);
            this.tpEditText.Name = "tpEditText";
            this.tpEditText.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditText.Size = new System.Drawing.Size(768, 400);
            this.tpEditText.TabIndex = 1;
            this.tpEditText.Text = "Редактирование текста ответа";
            this.tpEditText.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Личный кабинет";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(610, 23);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 337);
            this.textBox8.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Текст вип доступа";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(460, 23);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 337);
            this.textBox7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Информация";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(310, 23);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 337);
            this.textBox6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Текст вип доступа";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 23);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 337);
            this.textBox5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Текст приветсвия";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 23);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 337);
            this.textBox4.TabIndex = 0;
            // 
            // tbEditUser
            // 
            this.tbEditUser.Controls.Add(this.checkedListBox1);
            this.tbEditUser.Location = new System.Drawing.Point(4, 22);
            this.tbEditUser.Name = "tbEditUser";
            this.tbEditUser.Size = new System.Drawing.Size(768, 400);
            this.tbEditUser.TabIndex = 2;
            this.tbEditUser.Text = "Редактирование подписки пользователей";
            this.tbEditUser.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Василий",
            "Пётр",
            "Антон"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(297, 394);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tbEditSubscribe
            // 
            this.tbEditSubscribe.Controls.Add(this.button3);
            this.tbEditSubscribe.Controls.Add(this.textBox9);
            this.tbEditSubscribe.Controls.Add(this.label9);
            this.tbEditSubscribe.Controls.Add(this.listBox1);
            this.tbEditSubscribe.Location = new System.Drawing.Point(4, 22);
            this.tbEditSubscribe.Name = "tbEditSubscribe";
            this.tbEditSubscribe.Size = new System.Drawing.Size(768, 400);
            this.tbEditSubscribe.TabIndex = 3;
            this.tbEditSubscribe.Text = "Добавление и редактирование каналов";
            this.tbEditSubscribe.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(239, 21);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(188, 20);
            this.textBox9.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Введите название канала";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 394);
            this.listBox1.TabIndex = 0;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainform";
            this.Text = "Бот";
            this.tabControl1.ResumeLayout(false);
            this.tpInitialize.ResumeLayout(false);
            this.tpInitialize.PerformLayout();
            this.tpEditText.ResumeLayout(false);
            this.tpEditText.PerformLayout();
            this.tbEditUser.ResumeLayout(false);
            this.tbEditSubscribe.ResumeLayout(false);
            this.tbEditSubscribe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInitialize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tpEditText;
        private System.Windows.Forms.TabPage tbEditUser;
        private System.Windows.Forms.TabPage tbEditSubscribe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
    }
}

