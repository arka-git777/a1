namespace a1
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
            label1 = new Label();
            answer_box = new TextBox();
            question_label = new Label();
            correct_label = new Label();
            restart_button = new Button();
            result_label = new Label();
            total_label = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(551, 161);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 0;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 163);
            label1.Name = "label1";
            label1.Size = new Size(166, 22);
            label1.TabIndex = 1;
            label1.Text = "Enter your asnwer:";
            label1.Click += label1_Click;
            label1.MouseMove += label1_MouseMove;
            // 
            // answer_box
            // 
            answer_box.Location = new Point(286, 162);
            answer_box.Name = "answer_box";
            answer_box.Size = new Size(249, 23);
            answer_box.TabIndex = 2;
            // 
            // question_label
            // 
            question_label.AutoSize = true;
            question_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            question_label.Location = new Point(305, 78);
            question_label.Name = "question_label";
            question_label.Size = new Size(52, 25);
            question_label.TabIndex = 3;
            question_label.Text = "Quiz";
            question_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // correct_label
            // 
            correct_label.AutoSize = true;
            correct_label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            correct_label.Location = new Point(50, 389);
            correct_label.Name = "correct_label";
            correct_label.Size = new Size(188, 25);
            correct_label.TabIndex = 5;
            correct_label.Text = "Correct answers: 0/3";
            correct_label.Click += label4_Click;
            // 
            // restart_button
            // 
            restart_button.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restart_button.Location = new Point(658, 389);
            restart_button.Name = "restart_button";
            restart_button.Size = new Size(107, 25);
            restart_button.TabIndex = 6;
            restart_button.Text = "Resatrt";
            restart_button.UseVisualStyleBackColor = true;
            restart_button.Click += restart_button_Click_1;
            restart_button.MouseMove += restart_button_MouseMove;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result_label.Location = new Point(338, 245);
            result_label.Name = "result_label";
            result_label.Size = new Size(0, 25);
            result_label.TabIndex = 7;
            // 
            // total_label
            // 
            total_label.AutoSize = true;
            total_label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total_label.Location = new Point(50, 364);
            total_label.Name = "total_label";
            total_label.Size = new Size(147, 25);
            total_label.TabIndex = 8;
            total_label.Text = "Total answers: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(total_label);
            Controls.Add(result_label);
            Controls.Add(restart_button);
            Controls.Add(correct_label);
            Controls.Add(question_label);
            Controls.Add(answer_box);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox answer_box;
        private Label question_label;
        private Label correct_label;
        private Button restart_button;
        private Label result_label;
        private Label total_label;
    }
}
