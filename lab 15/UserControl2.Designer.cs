namespace lab_15
{
    partial class UserControl_String
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_inputText = new System.Windows.Forms.Label();
            textBox_inputText = new System.Windows.Forms.TextBox();
            textBox_nameFile = new System.Windows.Forms.TextBox();
            button_changeName_file = new System.Windows.Forms.Button();
            button_readFile = new System.Windows.Forms.Button();
            textBox_resultRead = new System.Windows.Forms.TextBox();
            button_addFile = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label_inputText
            // 
            label_inputText.AutoSize = true;
            label_inputText.Location = new System.Drawing.Point(14, 9);
            label_inputText.Name = "label_inputText";
            label_inputText.Size = new System.Drawing.Size(194, 15);
            label_inputText.TabIndex = 0;
            label_inputText.Text = "Ведіть текст для додавання в файл";
            // 
            // textBox_inputText
            // 
            textBox_inputText.Location = new System.Drawing.Point(14, 32);
            textBox_inputText.Multiline = true;
            textBox_inputText.Name = "textBox_inputText";
            textBox_inputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_inputText.Size = new System.Drawing.Size(478, 68);
            textBox_inputText.TabIndex = 1;
            // 
            // textBox_nameFile
            // 
            textBox_nameFile.Location = new System.Drawing.Point(214, 6);
            textBox_nameFile.Name = "textBox_nameFile";
            textBox_nameFile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            textBox_nameFile.Size = new System.Drawing.Size(173, 23);
            textBox_nameFile.TabIndex = 2;
            // 
            // button_changeName_file
            // 
            button_changeName_file.Location = new System.Drawing.Point(393, 5);
            button_changeName_file.Name = "button_changeName_file";
            button_changeName_file.Size = new System.Drawing.Size(99, 23);
            button_changeName_file.TabIndex = 3;
            button_changeName_file.Text = "Змінити файл";
            button_changeName_file.UseVisualStyleBackColor = true;
            button_changeName_file.Click += button_changeName_file_Click;
            // 
            // button_readFile
            // 
            button_readFile.Location = new System.Drawing.Point(13, 159);
            button_readFile.Name = "button_readFile";
            button_readFile.Size = new System.Drawing.Size(156, 32);
            button_readFile.TabIndex = 4;
            button_readFile.Text = "Зчитати вміст файлу";
            button_readFile.UseVisualStyleBackColor = true;
            button_readFile.Click += button_readFile_Click;
            // 
            // textBox_resultRead
            // 
            textBox_resultRead.Location = new System.Drawing.Point(14, 190);
            textBox_resultRead.Multiline = true;
            textBox_resultRead.Name = "textBox_resultRead";
            textBox_resultRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox_resultRead.Size = new System.Drawing.Size(478, 207);
            textBox_resultRead.TabIndex = 5;
            // 
            // button_addFile
            // 
            button_addFile.Location = new System.Drawing.Point(14, 100);
            button_addFile.Name = "button_addFile";
            button_addFile.Size = new System.Drawing.Size(129, 28);
            button_addFile.TabIndex = 6;
            button_addFile.Text = "Додати в файл";
            button_addFile.UseVisualStyleBackColor = true;
            button_addFile.Click += button_addFile_Click;
            // 
            // UserControl_String
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(button_addFile);
            Controls.Add(textBox_resultRead);
            Controls.Add(button_readFile);
            Controls.Add(button_changeName_file);
            Controls.Add(textBox_nameFile);
            Controls.Add(textBox_inputText);
            Controls.Add(label_inputText);
            Name = "UserControl_String";
            Size = new System.Drawing.Size(510, 411);
            Load += UserControl2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_inputText;
        private System.Windows.Forms.TextBox textBox_inputText;
        private System.Windows.Forms.TextBox textBox_nameFile;
        private System.Windows.Forms.Button button_changeName_file;
        private System.Windows.Forms.Button button_readFile;
        private System.Windows.Forms.TextBox textBox_resultRead;
        private System.Windows.Forms.Button button_addFile;
    }
}
