namespace EsThread_Incre_Decre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new CheckBox();
            radioButton2 = new CheckBox();
            radioButton3 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(107, 142);
            button1.Name = "button1";
            button1.Size = new Size(136, 65);
            button1.TabIndex = 0;
            button1.Text = "THREAD -";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(107, 262);
            button2.Name = "button2";
            button2.Size = new Size(136, 66);
            button2.TabIndex = 1;
            button2.Text = "THREAD + ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(508, 166);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 19);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(508, 231);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 19);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(508, 309);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(95, 19);
            radioButton3.TabIndex = 4;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(529, 131);
            label1.Name = "label1";
            label1.Size = new Size(53, 32);
            label1.TabIndex = 5;
            label1.Text = "100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(529, 196);
            label2.Name = "label2";
            label2.Size = new Size(53, 32);
            label2.TabIndex = 6;
            label2.Text = "100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(529, 274);
            label3.Name = "label3";
            label3.Size = new Size(53, 32);
            label3.TabIndex = 7;
            label3.Text = "100";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private CheckBox radioButton1;
        private CheckBox radioButton2;
        private CheckBox radioButton3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
