namespace TechsonClient
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imageChooseButton = new System.Windows.Forms.Button();
            this.methodsChooseBox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.randomForestRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.methodBox1 = new System.Windows.Forms.GroupBox();
            this.label_1_4 = new System.Windows.Forms.Label();
            this.label_1_9 = new System.Windows.Forms.Label();
            this.label_1_3 = new System.Windows.Forms.Label();
            this.label_1_8 = new System.Windows.Forms.Label();
            this.label_1_6 = new System.Windows.Forms.Label();
            this.label_1_1 = new System.Windows.Forms.Label();
            this.label_1_7 = new System.Windows.Forms.Label();
            this.label_1_2 = new System.Windows.Forms.Label();
            this.label_1_5 = new System.Windows.Forms.Label();
            this.label_1_0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.methodsChooseBox.SuspendLayout();
            this.methodBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(258, 168);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // imageChooseButton
            // 
            this.imageChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageChooseButton.Location = new System.Drawing.Point(276, 138);
            this.imageChooseButton.Name = "imageChooseButton";
            this.imageChooseButton.Size = new System.Drawing.Size(50, 43);
            this.imageChooseButton.TabIndex = 1;
            this.imageChooseButton.Text = " ...";
            this.imageChooseButton.UseVisualStyleBackColor = true;
            this.imageChooseButton.Click += new System.EventHandler(this.chooseImage);
            // 
            // methodsChooseBox
            // 
            this.methodsChooseBox.Controls.Add(this.radioButton3);
            this.methodsChooseBox.Controls.Add(this.radioButton1);
            this.methodsChooseBox.Controls.Add(this.randomForestRadioButton);
            this.methodsChooseBox.Controls.Add(this.radioButton2);
            this.methodsChooseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodsChooseBox.Location = new System.Drawing.Point(276, 12);
            this.methodsChooseBox.Name = "methodsChooseBox";
            this.methodsChooseBox.Size = new System.Drawing.Size(155, 120);
            this.methodsChooseBox.TabIndex = 2;
            this.methodsChooseBox.TabStop = false;
            this.methodsChooseBox.Text = "Methods";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "All methods";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(332, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // randomForestRadioButton
            // 
            this.randomForestRadioButton.AutoSize = true;
            this.randomForestRadioButton.Location = new System.Drawing.Point(6, 19);
            this.randomForestRadioButton.Name = "randomForestRadioButton";
            this.randomForestRadioButton.Size = new System.Drawing.Size(130, 22);
            this.randomForestRadioButton.TabIndex = 2;
            this.randomForestRadioButton.TabStop = true;
            this.randomForestRadioButton.Text = "Random Forest";
            this.randomForestRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(145, 22);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Gradient Boosting";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(129, 22);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Neural Network";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // methodBox1
            // 
            this.methodBox1.Controls.Add(this.label_1_5);
            this.methodBox1.Controls.Add(this.label_1_0);
            this.methodBox1.Controls.Add(this.label_1_6);
            this.methodBox1.Controls.Add(this.label_1_1);
            this.methodBox1.Controls.Add(this.label_1_7);
            this.methodBox1.Controls.Add(this.label_1_2);
            this.methodBox1.Controls.Add(this.label_1_8);
            this.methodBox1.Controls.Add(this.label_1_3);
            this.methodBox1.Controls.Add(this.label_1_9);
            this.methodBox1.Controls.Add(this.label_1_4);
            this.methodBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodBox1.Location = new System.Drawing.Point(12, 199);
            this.methodBox1.Name = "methodBox1";
            this.methodBox1.Size = new System.Drawing.Size(419, 93);
            this.methodBox1.TabIndex = 4;
            this.methodBox1.TabStop = false;
            this.methodBox1.Text = "MethodName1";
            this.methodBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label_1_4
            // 
            this.label_1_4.AutoSize = true;
            this.label_1_4.Location = new System.Drawing.Point(346, 28);
            this.label_1_4.Name = "label_1_4";
            this.label_1_4.Size = new System.Drawing.Size(27, 18);
            this.label_1_4.TabIndex = 8;
            this.label_1_4.Text = "4 :";
            this.label_1_4.Click += new System.EventHandler(this.label9_Click);
            // 
            // label_1_9
            // 
            this.label_1_9.AutoSize = true;
            this.label_1_9.Location = new System.Drawing.Point(346, 52);
            this.label_1_9.Name = "label_1_9";
            this.label_1_9.Size = new System.Drawing.Size(27, 18);
            this.label_1_9.TabIndex = 9;
            this.label_1_9.Text = "9 :";
            // 
            // label_1_3
            // 
            this.label_1_3.AutoSize = true;
            this.label_1_3.Location = new System.Drawing.Point(261, 28);
            this.label_1_3.Name = "label_1_3";
            this.label_1_3.Size = new System.Drawing.Size(27, 18);
            this.label_1_3.TabIndex = 10;
            this.label_1_3.Text = "3 :";
            // 
            // label_1_8
            // 
            this.label_1_8.AutoSize = true;
            this.label_1_8.Location = new System.Drawing.Point(261, 52);
            this.label_1_8.Name = "label_1_8";
            this.label_1_8.Size = new System.Drawing.Size(27, 18);
            this.label_1_8.TabIndex = 11;
            this.label_1_8.Text = "8 :";
            // 
            // label_1_6
            // 
            this.label_1_6.AutoSize = true;
            this.label_1_6.Location = new System.Drawing.Point(86, 52);
            this.label_1_6.Name = "label_1_6";
            this.label_1_6.Size = new System.Drawing.Size(27, 18);
            this.label_1_6.TabIndex = 15;
            this.label_1_6.Text = "6 :";
            // 
            // label_1_1
            // 
            this.label_1_1.AutoSize = true;
            this.label_1_1.Location = new System.Drawing.Point(86, 28);
            this.label_1_1.Name = "label_1_1";
            this.label_1_1.Size = new System.Drawing.Size(27, 18);
            this.label_1_1.TabIndex = 14;
            this.label_1_1.Text = "1 :";
            // 
            // label_1_7
            // 
            this.label_1_7.AutoSize = true;
            this.label_1_7.Location = new System.Drawing.Point(173, 52);
            this.label_1_7.Name = "label_1_7";
            this.label_1_7.Size = new System.Drawing.Size(27, 18);
            this.label_1_7.TabIndex = 13;
            this.label_1_7.Text = "7 :";
            // 
            // label_1_2
            // 
            this.label_1_2.AutoSize = true;
            this.label_1_2.Location = new System.Drawing.Point(173, 28);
            this.label_1_2.Name = "label_1_2";
            this.label_1_2.Size = new System.Drawing.Size(27, 18);
            this.label_1_2.TabIndex = 12;
            this.label_1_2.Text = "2 :";
            // 
            // label_1_5
            // 
            this.label_1_5.AutoSize = true;
            this.label_1_5.Location = new System.Drawing.Point(6, 52);
            this.label_1_5.Name = "label_1_5";
            this.label_1_5.Size = new System.Drawing.Size(27, 18);
            this.label_1_5.TabIndex = 17;
            this.label_1_5.Text = "5 :";
            // 
            // label_1_0
            // 
            this.label_1_0.AutoSize = true;
            this.label_1_0.Location = new System.Drawing.Point(6, 28);
            this.label_1_0.Name = "label_1_0";
            this.label_1_0.Size = new System.Drawing.Size(27, 18);
            this.label_1_0.TabIndex = 16;
            this.label_1_0.Text = "0 :";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 190);
            this.Controls.Add(this.methodBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.methodsChooseBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.imageChooseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Techson";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.methodsChooseBox.ResumeLayout(false);
            this.methodsChooseBox.PerformLayout();
            this.methodBox1.ResumeLayout(false);
            this.methodBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button imageChooseButton;
        private System.Windows.Forms.GroupBox methodsChooseBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton randomForestRadioButton;
        private System.Windows.Forms.GroupBox methodBox1;
        private System.Windows.Forms.Label label_1_9;
        private System.Windows.Forms.Label label_1_4;
        private System.Windows.Forms.Label label_1_5;
        private System.Windows.Forms.Label label_1_0;
        private System.Windows.Forms.Label label_1_6;
        private System.Windows.Forms.Label label_1_1;
        private System.Windows.Forms.Label label_1_7;
        private System.Windows.Forms.Label label_1_2;
        private System.Windows.Forms.Label label_1_8;
        private System.Windows.Forms.Label label_1_3;
    }
}

