namespace MobileStore
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
            this.teleponeInfoBox = new System.Windows.Forms.ListBox();
            this.delButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.clrButton = new System.Windows.Forms.Button();
            this.saveInFile = new System.Windows.Forms.Button();
            this.readFromFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.processor = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.os = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.option = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.saveChanges = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.optionName = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.addOption = new System.Windows.Forms.Button();
            this.deleteOption = new System.Windows.Forms.Button();
            this.clearFields = new System.Windows.Forms.Button();
            this.addTelephone = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teleponeInfoBox
            // 
            this.teleponeInfoBox.FormattingEnabled = true;
            this.teleponeInfoBox.Location = new System.Drawing.Point(13, 39);
            this.teleponeInfoBox.Name = "teleponeInfoBox";
            this.teleponeInfoBox.Size = new System.Drawing.Size(274, 290);
            this.teleponeInfoBox.TabIndex = 2;
            this.teleponeInfoBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(17, 351);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(132, 41);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Удалить текущую";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // clrButton
            // 
            this.clrButton.Location = new System.Drawing.Point(151, 351);
            this.clrButton.Name = "clrButton";
            this.clrButton.Size = new System.Drawing.Size(136, 41);
            this.clrButton.TabIndex = 3;
            this.clrButton.Text = "Очистить список";
            this.clrButton.UseVisualStyleBackColor = true;
            this.clrButton.Click += new System.EventHandler(this.clrButton_Click);
            // 
            // saveInFile
            // 
            this.saveInFile.Location = new System.Drawing.Point(13, 441);
            this.saveInFile.Name = "saveInFile";
            this.saveInFile.Size = new System.Drawing.Size(136, 41);
            this.saveInFile.TabIndex = 3;
            this.saveInFile.Text = "Записать в файл";
            this.saveInFile.UseVisualStyleBackColor = true;
            // 
            // readFromFile
            // 
            this.readFromFile.Location = new System.Drawing.Point(151, 441);
            this.readFromFile.Name = "readFromFile";
            this.readFromFile.Size = new System.Drawing.Size(136, 41);
            this.readFromFile.TabIndex = 3;
            this.readFromFile.Text = "Прочитать из файла";
            this.readFromFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список телефонов магазина";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(300, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(303, 493);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.option);
            this.tabPage1.Controls.Add(this.price);
            this.tabPage1.Controls.Add(this.processor);
            this.tabPage1.Controls.Add(this.model);
            this.tabPage1.Controls.Add(this.os);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(295, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 210);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 2;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(7, 210);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(33, 13);
            this.price.TabIndex = 1;
            this.price.Text = "Цена";
            // 
            // processor
            // 
            this.processor.AutoSize = true;
            this.processor.Location = new System.Drawing.Point(7, 182);
            this.processor.Name = "processor";
            this.processor.Size = new System.Drawing.Size(63, 13);
            this.processor.TabIndex = 1;
            this.processor.Text = "Процессор";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(7, 126);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(46, 13);
            this.model.TabIndex = 1;
            this.model.Text = "Модель";
            // 
            // os
            // 
            this.os.AutoSize = true;
            this.os.Location = new System.Drawing.Point(7, 152);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(22, 13);
            this.os.TabIndex = 1;
            this.os.Text = "ОС";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(7, 288);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(280, 134);
            this.listBox2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addTelephone);
            this.tabPage2.Controls.Add(this.clearFields);
            this.tabPage2.Controls.Add(this.deleteOption);
            this.tabPage2.Controls.Add(this.addOption);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.optionName);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.saveChanges);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.picture);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(295, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(615, 525);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 6;
            // 
            // option
            // 
            this.option.AutoSize = true;
            this.option.Location = new System.Drawing.Point(7, 263);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(39, 13);
            this.option.TabIndex = 1;
            this.option.Text = "Опции";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(86, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(86, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(86, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(199, 20);
            this.textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(86, 41);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(199, 20);
            this.textBox8.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Процессор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Модель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ОС";
            // 
            // picture
            // 
            this.picture.AutoSize = true;
            this.picture.Location = new System.Drawing.Point(6, 131);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(77, 13);
            this.picture.TabIndex = 3;
            this.picture.Text = "Изображение";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(86, 131);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(199, 20);
            this.textBox9.TabIndex = 7;
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(6, 314);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(279, 39);
            this.saveChanges.TabIndex = 12;
            this.saveChanges.Text = "Сохранить изменения";
            this.saveChanges.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 169);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(278, 139);
            this.checkedListBox1.TabIndex = 13;
            // 
            // optionName
            // 
            this.optionName.AutoSize = true;
            this.optionName.Location = new System.Drawing.Point(4, 360);
            this.optionName.Name = "optionName";
            this.optionName.Size = new System.Drawing.Size(90, 13);
            this.optionName.TabIndex = 14;
            this.optionName.Text = "Название опции";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(101, 360);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(184, 20);
            this.textBox10.TabIndex = 15;
            // 
            // addOption
            // 
            this.addOption.Location = new System.Drawing.Point(6, 390);
            this.addOption.Name = "addOption";
            this.addOption.Size = new System.Drawing.Size(132, 26);
            this.addOption.TabIndex = 16;
            this.addOption.Text = "Добавить опцию";
            this.addOption.UseVisualStyleBackColor = true;
            // 
            // deleteOption
            // 
            this.deleteOption.Location = new System.Drawing.Point(144, 390);
            this.deleteOption.Name = "deleteOption";
            this.deleteOption.Size = new System.Drawing.Size(141, 26);
            this.deleteOption.TabIndex = 16;
            this.deleteOption.Text = "Удалить опцию";
            this.deleteOption.UseVisualStyleBackColor = true;
            // 
            // clearFields
            // 
            this.clearFields.Location = new System.Drawing.Point(7, 422);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(131, 39);
            this.clearFields.TabIndex = 17;
            this.clearFields.Text = "Очистить поля";
            this.clearFields.UseVisualStyleBackColor = true;
            // 
            // addTelephone
            // 
            this.addTelephone.Location = new System.Drawing.Point(144, 422);
            this.addTelephone.Name = "addTelephone";
            this.addTelephone.Size = new System.Drawing.Size(141, 39);
            this.addTelephone.TabIndex = 17;
            this.addTelephone.Text = "Добавить новый телефон";
            this.addTelephone.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 536);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveInFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.readFromFile);
            this.Controls.Add(this.clrButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.teleponeInfoBox);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox teleponeInfoBox;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button clrButton;
        private System.Windows.Forms.Button saveInFile;
        private System.Windows.Forms.Button readFromFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label processor;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label os;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label option;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addTelephone;
        private System.Windows.Forms.Button clearFields;
        private System.Windows.Forms.Button deleteOption;
        private System.Windows.Forms.Button addOption;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label optionName;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

