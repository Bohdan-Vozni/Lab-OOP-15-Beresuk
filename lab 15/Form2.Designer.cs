namespace lab_15
{
    partial class Form2
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
            button1 = new System.Windows.Forms.Button();
            button_switchForm_firstProgram = new System.Windows.Forms.Button();
            userControl11 = new UserControl_Name();
            userControl_Name = new UserControl_Name();
            button_switchName = new System.Windows.Forms.Button();
            button_switchString = new System.Windows.Forms.Button();
            userControl_String1 = new UserControl_String();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(456, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(57, 43);
            button1.TabIndex = 0;
            button1.Text = "Х";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_switchForm_firstProgram
            // 
            button_switchForm_firstProgram.Location = new System.Drawing.Point(0, 0);
            button_switchForm_firstProgram.Name = "button_switchForm_firstProgram";
            button_switchForm_firstProgram.Size = new System.Drawing.Size(113, 43);
            button_switchForm_firstProgram.TabIndex = 1;
            button_switchForm_firstProgram.Text = "Перша програма";
            button_switchForm_firstProgram.UseVisualStyleBackColor = true;
            button_switchForm_firstProgram.Click += button_swichForm_firstProgram_Click;
            // 
            // userControl11
            // 
            userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            userControl11.Location = new System.Drawing.Point(278, 274);
            userControl11.Name = "userControl11";
            userControl11.Size = new System.Drawing.Size(8, 8);
            userControl11.TabIndex = 7;
            // 
            // userControl_Name
            // 
            userControl_Name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            userControl_Name.Location = new System.Drawing.Point(0, 39);
            userControl_Name.Name = "userControl_Name";
            userControl_Name.Size = new System.Drawing.Size(510, 411);
            userControl_Name.TabIndex = 8;
            // 
            // button_switchName
            // 
            button_switchName.Location = new System.Drawing.Point(119, -1);
            button_switchName.Name = "button_switchName";
            button_switchName.Size = new System.Drawing.Size(153, 43);
            button_switchName.TabIndex = 9;
            button_switchName.Text = "Обробка імя і прізвища";
            button_switchName.UseVisualStyleBackColor = true;
            button_switchName.Click += button_switchName_Click;
            // 
            // button_switchString
            // 
            button_switchString.Location = new System.Drawing.Point(281, -1);
            button_switchString.Name = "button_switchString";
            button_switchString.Size = new System.Drawing.Size(127, 44);
            button_switchString.TabIndex = 10;
            button_switchString.Text = "Обробка рядка ";
            button_switchString.UseVisualStyleBackColor = true;
            button_switchString.Click += button_switchString_Click;
            // 
            // userControl_String1
            // 
            userControl_String1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            userControl_String1.Location = new System.Drawing.Point(0, 39);
            userControl_String1.Name = "userControl_String1";
            userControl_String1.Size = new System.Drawing.Size(510, 411);
            userControl_String1.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(512, 450);
            Controls.Add(userControl_String1);
            Controls.Add(userControl_Name);
            Controls.Add(userControl11);
            Controls.Add(button_switchForm_firstProgram);
            Controls.Add(button1);
            Controls.Add(button_switchName);
            Controls.Add(button_switchString);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_switchForm_firstProgram;
        private UserControl_Name userControl11;
        private UserControl_Name userControl12;
        private UserControl_Name userControl_Name;
        private System.Windows.Forms.Button button_switchName;
        private System.Windows.Forms.Button button_switchString;
        private UserControl_String userControl_String1;
    }
}