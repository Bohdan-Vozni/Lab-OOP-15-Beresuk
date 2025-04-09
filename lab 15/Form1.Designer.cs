namespace lab_15
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
            button1 = new System.Windows.Forms.Button();
            label_harvest1 = new System.Windows.Forms.Label();
            textBox_harvest1 = new System.Windows.Forms.TextBox();
            textBox_harvest2 = new System.Windows.Forms.TextBox();
            label_harvest2 = new System.Windows.Forms.Label();
            button_area = new System.Windows.Forms.Button();
            button_delete = new System.Windows.Forms.Button();
            label_result = new System.Windows.Forms.Label();
            textBox_harvest3 = new System.Windows.Forms.TextBox();
            label_harvest3 = new System.Windows.Forms.Label();
            button_swichForm_twoProgram = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox_area3 = new System.Windows.Forms.TextBox();
            textBox_area2 = new System.Windows.Forms.TextBox();
            textBox_area1 = new System.Windows.Forms.TextBox();
            label_area3 = new System.Windows.Forms.Label();
            label_area2 = new System.Windows.Forms.Label();
            label_area1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(982, 0);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(65, 57);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_harvest1
            // 
            label_harvest1.AutoSize = true;
            label_harvest1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_harvest1.Location = new System.Drawing.Point(47, 112);
            label_harvest1.Name = "label_harvest1";
            label_harvest1.Size = new System.Drawing.Size(206, 20);
            label_harvest1.TabIndex = 1;
            label_harvest1.Text = "Введіть врожайність 1 сорту";
            // 
            // textBox_harvest1
            // 
            textBox_harvest1.Location = new System.Drawing.Point(270, 109);
            textBox_harvest1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_harvest1.Name = "textBox_harvest1";
            textBox_harvest1.Size = new System.Drawing.Size(114, 27);
            textBox_harvest1.TabIndex = 2;
            // 
            // textBox_harvest2
            // 
            textBox_harvest2.Location = new System.Drawing.Point(270, 166);
            textBox_harvest2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_harvest2.Name = "textBox_harvest2";
            textBox_harvest2.Size = new System.Drawing.Size(114, 27);
            textBox_harvest2.TabIndex = 4;
            // 
            // label_harvest2
            // 
            label_harvest2.AutoSize = true;
            label_harvest2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_harvest2.Location = new System.Drawing.Point(47, 169);
            label_harvest2.Name = "label_harvest2";
            label_harvest2.Size = new System.Drawing.Size(206, 20);
            label_harvest2.TabIndex = 3;
            label_harvest2.Text = "Введіть врожайність 2 сорту";
            // 
            // button_area
            // 
            button_area.Location = new System.Drawing.Point(759, 115);
            button_area.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_area.Name = "button_area";
            button_area.Size = new System.Drawing.Size(257, 31);
            button_area.TabIndex = 5;
            button_area.Text = "Обчистлити середнє значення";
            button_area.UseVisualStyleBackColor = true;
            button_area.Click += button_area_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new System.Drawing.Point(759, 169);
            button_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_delete.Name = "button_delete";
            button_delete.Size = new System.Drawing.Size(257, 31);
            button_delete.TabIndex = 7;
            button_delete.Text = "Видалити";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new System.Drawing.Point(200, 280);
            label_result.Name = "label_result";
            label_result.Size = new System.Drawing.Size(0, 20);
            label_result.TabIndex = 8;
            // 
            // textBox_harvest3
            // 
            textBox_harvest3.Location = new System.Drawing.Point(270, 219);
            textBox_harvest3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_harvest3.Name = "textBox_harvest3";
            textBox_harvest3.Size = new System.Drawing.Size(114, 27);
            textBox_harvest3.TabIndex = 10;
            // 
            // label_harvest3
            // 
            label_harvest3.AutoSize = true;
            label_harvest3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_harvest3.Location = new System.Drawing.Point(47, 219);
            label_harvest3.Name = "label_harvest3";
            label_harvest3.Size = new System.Drawing.Size(206, 20);
            label_harvest3.TabIndex = 9;
            label_harvest3.Text = "Введіть врожайність 3 сорту";
            // 
            // button_swichForm_twoProgram
            // 
            button_swichForm_twoProgram.Location = new System.Drawing.Point(0, 0);
            button_swichForm_twoProgram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button_swichForm_twoProgram.Name = "button_swichForm_twoProgram";
            button_swichForm_twoProgram.Size = new System.Drawing.Size(129, 57);
            button_swichForm_twoProgram.TabIndex = 11;
            button_swichForm_twoProgram.Text = "Друга програма";
            button_swichForm_twoProgram.UseVisualStyleBackColor = true;
            button_swichForm_twoProgram.Click += button_swichForm_Click;
            // 
            // textBox_area3
            // 
            textBox_area3.Location = new System.Drawing.Point(613, 206);
            textBox_area3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_area3.Name = "textBox_area3";
            textBox_area3.Size = new System.Drawing.Size(114, 27);
            textBox_area3.TabIndex = 14;
            // 
            // textBox_area2
            // 
            textBox_area2.Location = new System.Drawing.Point(613, 156);
            textBox_area2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_area2.Name = "textBox_area2";
            textBox_area2.Size = new System.Drawing.Size(114, 27);
            textBox_area2.TabIndex = 13;
            // 
            // textBox_area1
            // 
            textBox_area1.Location = new System.Drawing.Point(613, 99);
            textBox_area1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox_area1.Name = "textBox_area1";
            textBox_area1.Size = new System.Drawing.Size(114, 27);
            textBox_area1.TabIndex = 12;
            // 
            // label_area3
            // 
            label_area3.AutoSize = true;
            label_area3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_area3.Location = new System.Drawing.Point(419, 213);
            label_area3.Name = "label_area3";
            label_area3.Size = new System.Drawing.Size(151, 20);
            label_area3.TabIndex = 17;
            label_area3.Text = "Ведіть площу 3 поля";
            // 
            // label_area2
            // 
            label_area2.AutoSize = true;
            label_area2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_area2.Location = new System.Drawing.Point(419, 163);
            label_area2.Name = "label_area2";
            label_area2.Size = new System.Drawing.Size(151, 20);
            label_area2.TabIndex = 16;
            label_area2.Text = "Ведіть площу 2 поля";
            // 
            // label_area1
            // 
            label_area1.AutoSize = true;
            label_area1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_area1.Location = new System.Drawing.Point(419, 106);
            label_area1.Name = "label_area1";
            label_area1.Size = new System.Drawing.Size(151, 20);
            label_area1.TabIndex = 15;
            label_area1.Text = "Ведіть площу 1 поля";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            ClientSize = new System.Drawing.Size(1045, 301);
            Controls.Add(label_area3);
            Controls.Add(label_area2);
            Controls.Add(label_area1);
            Controls.Add(textBox_area3);
            Controls.Add(textBox_area2);
            Controls.Add(textBox_area1);
            Controls.Add(button_swichForm_twoProgram);
            Controls.Add(textBox_harvest3);
            Controls.Add(label_harvest3);
            Controls.Add(label_result);
            Controls.Add(button_delete);
            Controls.Add(button_area);
            Controls.Add(textBox_harvest2);
            Controls.Add(label_harvest2);
            Controls.Add(textBox_harvest1);
            Controls.Add(label_harvest1);
            Controls.Add(button1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_harvest1;
        private System.Windows.Forms.TextBox textBox_harvest1;
        private System.Windows.Forms.TextBox textBox_harvest2;
        private System.Windows.Forms.Label label_harvest2;
        private System.Windows.Forms.Button button_area;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_harvest3;
        private System.Windows.Forms.Label label_harvest3;
        private System.Windows.Forms.Button button_swichForm_twoProgram;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox_area3;
        private System.Windows.Forms.TextBox textBox_area2;
        private System.Windows.Forms.TextBox textBox_area1;
        private System.Windows.Forms.Label label_area3;
        private System.Windows.Forms.Label label_area2;
        private System.Windows.Forms.Label label_area1;
    }
}

