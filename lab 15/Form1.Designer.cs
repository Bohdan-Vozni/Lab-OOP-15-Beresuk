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
            label_middleHarvest1 = new System.Windows.Forms.Label();
            label_middleHarvest2 = new System.Windows.Forms.Label();
            label_middleHarvest3 = new System.Windows.Forms.Label();
            label_resultHarvest = new System.Windows.Forms.Label();
            laberl_resultHarvestGeneral = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(859, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(57, 43);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_harvest1
            // 
            label_harvest1.AutoSize = true;
            label_harvest1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_harvest1.Location = new System.Drawing.Point(41, 84);
            label_harvest1.Name = "label_harvest1";
            label_harvest1.Size = new System.Drawing.Size(161, 15);
            label_harvest1.TabIndex = 1;
            label_harvest1.Text = "Введіть врожайність 1 сорту";
            // 
            // textBox_harvest1
            // 
            textBox_harvest1.Location = new System.Drawing.Point(236, 82);
            textBox_harvest1.Name = "textBox_harvest1";
            textBox_harvest1.Size = new System.Drawing.Size(100, 23);
            textBox_harvest1.TabIndex = 2;
            // 
            // textBox_harvest2
            // 
            textBox_harvest2.Location = new System.Drawing.Point(236, 124);
            textBox_harvest2.Name = "textBox_harvest2";
            textBox_harvest2.Size = new System.Drawing.Size(100, 23);
            textBox_harvest2.TabIndex = 4;
            // 
            // label_harvest2
            // 
            label_harvest2.AutoSize = true;
            label_harvest2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_harvest2.Location = new System.Drawing.Point(41, 127);
            label_harvest2.Name = "label_harvest2";
            label_harvest2.Size = new System.Drawing.Size(161, 15);
            label_harvest2.TabIndex = 3;
            label_harvest2.Text = "Введіть врожайність 2 сорту";
            // 
            // button_area
            // 
            button_area.Location = new System.Drawing.Point(664, 86);
            button_area.Name = "button_area";
            button_area.Size = new System.Drawing.Size(225, 23);
            button_area.TabIndex = 5;
            button_area.Text = "Обчистлити середнє значення";
            button_area.UseVisualStyleBackColor = true;
            button_area.Click += button_area_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new System.Drawing.Point(664, 127);
            button_delete.Name = "button_delete";
            button_delete.Size = new System.Drawing.Size(225, 23);
            button_delete.TabIndex = 7;
            button_delete.Text = "Видалити";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // label_result
            // 
            label_result.AutoSize = true;
            label_result.Location = new System.Drawing.Point(175, 210);
            label_result.Name = "label_result";
            label_result.Size = new System.Drawing.Size(0, 15);
            label_result.TabIndex = 8;
            // 
            // textBox_harvest3
            // 
            textBox_harvest3.Location = new System.Drawing.Point(236, 164);
            textBox_harvest3.Name = "textBox_harvest3";
            textBox_harvest3.Size = new System.Drawing.Size(100, 23);
            textBox_harvest3.TabIndex = 10;
            // 
            // label_harvest3
            // 
            label_harvest3.AutoSize = true;
            label_harvest3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_harvest3.Location = new System.Drawing.Point(41, 164);
            label_harvest3.Name = "label_harvest3";
            label_harvest3.Size = new System.Drawing.Size(161, 15);
            label_harvest3.TabIndex = 9;
            label_harvest3.Text = "Введіть врожайність 3 сорту";
            // 
            // button_swichForm_twoProgram
            // 
            button_swichForm_twoProgram.Location = new System.Drawing.Point(0, 0);
            button_swichForm_twoProgram.Name = "button_swichForm_twoProgram";
            button_swichForm_twoProgram.Size = new System.Drawing.Size(113, 43);
            button_swichForm_twoProgram.TabIndex = 11;
            button_swichForm_twoProgram.Text = "Друга програма";
            button_swichForm_twoProgram.UseVisualStyleBackColor = true;
            button_swichForm_twoProgram.Click += button_swichForm_Click;
            // 
            // textBox_area3
            // 
            textBox_area3.Location = new System.Drawing.Point(536, 154);
            textBox_area3.Name = "textBox_area3";
            textBox_area3.Size = new System.Drawing.Size(100, 23);
            textBox_area3.TabIndex = 14;
            // 
            // textBox_area2
            // 
            textBox_area2.Location = new System.Drawing.Point(536, 117);
            textBox_area2.Name = "textBox_area2";
            textBox_area2.Size = new System.Drawing.Size(100, 23);
            textBox_area2.TabIndex = 13;
            // 
            // textBox_area1
            // 
            textBox_area1.Location = new System.Drawing.Point(536, 74);
            textBox_area1.Name = "textBox_area1";
            textBox_area1.Size = new System.Drawing.Size(100, 23);
            textBox_area1.TabIndex = 12;
            // 
            // label_area3
            // 
            label_area3.AutoSize = true;
            label_area3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_area3.Location = new System.Drawing.Point(367, 162);
            label_area3.Name = "label_area3";
            label_area3.Size = new System.Drawing.Size(120, 15);
            label_area3.TabIndex = 17;
            label_area3.Text = "Ведіть площу 3 поля";
            // 
            // label_area2
            // 
            label_area2.AutoSize = true;
            label_area2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_area2.Location = new System.Drawing.Point(367, 122);
            label_area2.Name = "label_area2";
            label_area2.Size = new System.Drawing.Size(120, 15);
            label_area2.TabIndex = 16;
            label_area2.Text = "Ведіть площу 2 поля";
            // 
            // label_area1
            // 
            label_area1.AutoSize = true;
            label_area1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_area1.Location = new System.Drawing.Point(367, 80);
            label_area1.Name = "label_area1";
            label_area1.Size = new System.Drawing.Size(120, 15);
            label_area1.TabIndex = 15;
            label_area1.Text = "Ведіть площу 1 поля";
            // 
            // label_middleHarvest1
            // 
            label_middleHarvest1.AutoSize = true;
            label_middleHarvest1.Location = new System.Drawing.Point(181, 219);
            label_middleHarvest1.Name = "label_middleHarvest1";
            label_middleHarvest1.Size = new System.Drawing.Size(13, 15);
            label_middleHarvest1.TabIndex = 18;
            label_middleHarvest1.Text = "1";
            // 
            // label_middleHarvest2
            // 
            label_middleHarvest2.AutoSize = true;
            label_middleHarvest2.Location = new System.Drawing.Point(181, 248);
            label_middleHarvest2.Name = "label_middleHarvest2";
            label_middleHarvest2.Size = new System.Drawing.Size(13, 15);
            label_middleHarvest2.TabIndex = 19;
            label_middleHarvest2.Text = "2";
            // 
            // label_middleHarvest3
            // 
            label_middleHarvest3.AutoSize = true;
            label_middleHarvest3.Location = new System.Drawing.Point(181, 274);
            label_middleHarvest3.Name = "label_middleHarvest3";
            label_middleHarvest3.Size = new System.Drawing.Size(13, 15);
            label_middleHarvest3.TabIndex = 20;
            label_middleHarvest3.Text = "3";
            // 
            // label_resultHarvest
            // 
            label_resultHarvest.AutoSize = true;
            label_resultHarvest.Location = new System.Drawing.Point(79, 215);
            label_resultHarvest.Name = "label_resultHarvest";
            label_resultHarvest.Size = new System.Drawing.Size(67, 15);
            label_resultHarvest.TabIndex = 21;
            label_resultHarvest.Text = "Результати";
            // 
            // laberl_resultHarvestGeneral
            // 
            laberl_resultHarvestGeneral.AutoSize = true;
            laberl_resultHarvestGeneral.Location = new System.Drawing.Point(181, 301);
            laberl_resultHarvestGeneral.Name = "laberl_resultHarvestGeneral";
            laberl_resultHarvestGeneral.Size = new System.Drawing.Size(13, 15);
            laberl_resultHarvestGeneral.TabIndex = 23;
            laberl_resultHarvestGeneral.Text = "3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            ClientSize = new System.Drawing.Size(916, 340);
            Controls.Add(laberl_resultHarvestGeneral);
            Controls.Add(label_resultHarvest);
            Controls.Add(label_middleHarvest3);
            Controls.Add(label_middleHarvest2);
            Controls.Add(label_middleHarvest1);
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
        private System.Windows.Forms.Label label_middleHarvest1;
        private System.Windows.Forms.Label label_middleHarvest2;
        private System.Windows.Forms.Label label_middleHarvest3;
        private System.Windows.Forms.Label label_resultHarvest;
        private System.Windows.Forms.Label laberl_resultHarvestGeneral;
    }
}

