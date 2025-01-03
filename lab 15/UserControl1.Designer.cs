namespace lab_15
{
    partial class UserControl_Name
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
            label_countSymbol_name = new System.Windows.Forms.Label();
            label_resultName = new System.Windows.Forms.Label();
            button_ok = new System.Windows.Forms.Button();
            textBox_name = new System.Windows.Forms.TextBox();
            label_name = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label_countSymbol_name
            // 
            label_countSymbol_name.AutoSize = true;
            label_countSymbol_name.Location = new System.Drawing.Point(24, 184);
            label_countSymbol_name.Name = "label_countSymbol_name";
            label_countSymbol_name.Size = new System.Drawing.Size(116, 15);
            label_countSymbol_name.TabIndex = 11;
            label_countSymbol_name.Text = "Кількість символів: ";
            label_countSymbol_name.Visible = false;
            // 
            // label_resultName
            // 
            label_resultName.AutoSize = true;
            label_resultName.Location = new System.Drawing.Point(24, 149);
            label_resultName.Name = "label_resultName";
            label_resultName.Size = new System.Drawing.Size(179, 15);
            label_resultName.TabIndex = 10;
            label_resultName.Text = "Слова в зворотньому порядку: ";
            label_resultName.Visible = false;
            // 
            // button_ok
            // 
            button_ok.Location = new System.Drawing.Point(304, 97);
            button_ok.Name = "button_ok";
            button_ok.Size = new System.Drawing.Size(56, 46);
            button_ok.TabIndex = 9;
            button_ok.Text = "ok";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click_1;
            // 
            // textBox_name
            // 
            textBox_name.Location = new System.Drawing.Point(161, 110);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new System.Drawing.Size(100, 23);
            textBox_name.TabIndex = 8;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new System.Drawing.Point(24, 113);
            label_name.Name = "label_name";
            label_name.Size = new System.Drawing.Size(131, 15);
            label_name.TabIndex = 7;
            label_name.Text = "Ведіть і'мя  і прізвище ";
            // 
            // UserControl_Name
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            Controls.Add(label_countSymbol_name);
            Controls.Add(label_resultName);
            Controls.Add(button_ok);
            Controls.Add(textBox_name);
            Controls.Add(label_name);
            Name = "UserControl_Name";
            Size = new System.Drawing.Size(469, 460);
            Load += UserControl_Name_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_countSymbol_name;
        private System.Windows.Forms.Label label_resultName;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
    }
}
