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
            label_side = new System.Windows.Forms.Label();
            textBox_side = new System.Windows.Forms.TextBox();
            textBox_small_basis = new System.Windows.Forms.TextBox();
            label_small_basis = new System.Windows.Forms.Label();
            button_area = new System.Windows.Forms.Button();
            button_perimeter = new System.Windows.Forms.Button();
            button_delete = new System.Windows.Forms.Button();
            label_result = new System.Windows.Forms.Label();
            textBox_large_basis = new System.Windows.Forms.TextBox();
            label_large_basis = new System.Windows.Forms.Label();
            button_swichForm_twoProgram = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(456, 0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(57, 43);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_side
            // 
            label_side.AutoSize = true;
            label_side.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_side.Location = new System.Drawing.Point(41, 84);
            label_side.Name = "label_side";
            label_side.Size = new System.Drawing.Size(121, 15);
            label_side.TabIndex = 1;
            label_side.Text = "Ведіть бічну сторону";
            // 
            // textBox_side
            // 
            textBox_side.Location = new System.Drawing.Point(175, 81);
            textBox_side.Name = "textBox_side";
            textBox_side.Size = new System.Drawing.Size(100, 23);
            textBox_side.TabIndex = 2;
            // 
            // textBox_small_basis
            // 
            textBox_small_basis.Location = new System.Drawing.Point(175, 124);
            textBox_small_basis.Name = "textBox_small_basis";
            textBox_small_basis.Size = new System.Drawing.Size(100, 23);
            textBox_small_basis.TabIndex = 4;
            // 
            // label_small_basis
            // 
            label_small_basis.AutoSize = true;
            label_small_basis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_small_basis.Location = new System.Drawing.Point(41, 127);
            label_small_basis.Name = "label_small_basis";
            label_small_basis.Size = new System.Drawing.Size(124, 15);
            label_small_basis.TabIndex = 3;
            label_small_basis.Text = "Ведіть меншу основу";
            // 
            // button_area
            // 
            button_area.Location = new System.Drawing.Point(308, 124);
            button_area.Name = "button_area";
            button_area.Size = new System.Drawing.Size(174, 23);
            button_area.TabIndex = 5;
            button_area.Text = "Обчистлити площу";
            button_area.UseVisualStyleBackColor = true;
            button_area.Click += button_area_Click;
            // 
            // button_perimeter
            // 
            button_perimeter.Location = new System.Drawing.Point(308, 81);
            button_perimeter.Name = "button_perimeter";
            button_perimeter.Size = new System.Drawing.Size(174, 23);
            button_perimeter.TabIndex = 6;
            button_perimeter.Text = "Обчислити периметер";
            button_perimeter.UseVisualStyleBackColor = true;
            button_perimeter.Click += button_perimeter_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new System.Drawing.Point(308, 164);
            button_delete.Name = "button_delete";
            button_delete.Size = new System.Drawing.Size(174, 23);
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
            // textBox_large_basis
            // 
            textBox_large_basis.Location = new System.Drawing.Point(175, 161);
            textBox_large_basis.Name = "textBox_large_basis";
            textBox_large_basis.Size = new System.Drawing.Size(100, 23);
            textBox_large_basis.TabIndex = 10;
            // 
            // label_large_basis
            // 
            label_large_basis.AutoSize = true;
            label_large_basis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label_large_basis.Location = new System.Drawing.Point(41, 164);
            label_large_basis.Name = "label_large_basis";
            label_large_basis.Size = new System.Drawing.Size(125, 15);
            label_large_basis.TabIndex = 9;
            label_large_basis.Text = "Ведіть більшу основу";
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
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveBorder;
            ClientSize = new System.Drawing.Size(512, 450);
            Controls.Add(button_swichForm_twoProgram);
            Controls.Add(textBox_large_basis);
            Controls.Add(label_large_basis);
            Controls.Add(label_result);
            Controls.Add(button_delete);
            Controls.Add(button_perimeter);
            Controls.Add(button_area);
            Controls.Add(textBox_small_basis);
            Controls.Add(label_small_basis);
            Controls.Add(textBox_side);
            Controls.Add(label_side);
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
        private System.Windows.Forms.Label label_side;
        private System.Windows.Forms.TextBox textBox_side;
        private System.Windows.Forms.TextBox textBox_small_basis;
        private System.Windows.Forms.Label label_small_basis;
        private System.Windows.Forms.Button button_area;
        private System.Windows.Forms.Button button_perimeter;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_large_basis;
        private System.Windows.Forms.Label label_large_basis;
        private System.Windows.Forms.Button button_swichForm_twoProgram;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

