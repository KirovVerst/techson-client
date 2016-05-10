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
            this.methodsChooseBox = new System.Windows.Forms.GroupBox();
            this.neuralNetworkRadioButton = new System.Windows.Forms.RadioButton();
            this.gradientBoostingRadioButton = new System.Windows.Forms.RadioButton();
            this.randomForestRadioButton = new System.Windows.Forms.RadioButton();
            this.allMethodsRadioMethod = new System.Windows.Forms.RadioButton();
            this.methodBox1 = new System.Windows.Forms.GroupBox();
            this.label_1_5 = new System.Windows.Forms.Label();
            this.label_1_0 = new System.Windows.Forms.Label();
            this.label_1_6 = new System.Windows.Forms.Label();
            this.label_1_1 = new System.Windows.Forms.Label();
            this.label_1_7 = new System.Windows.Forms.Label();
            this.label_1_2 = new System.Windows.Forms.Label();
            this.label_1_8 = new System.Windows.Forms.Label();
            this.label_1_3 = new System.Windows.Forms.Label();
            this.label_1_9 = new System.Windows.Forms.Label();
            this.label_1_4 = new System.Windows.Forms.Label();
            this.methodBox2 = new System.Windows.Forms.GroupBox();
            this.label_2_5 = new System.Windows.Forms.Label();
            this.label_2_0 = new System.Windows.Forms.Label();
            this.label_2_6 = new System.Windows.Forms.Label();
            this.label_2_1 = new System.Windows.Forms.Label();
            this.label_2_7 = new System.Windows.Forms.Label();
            this.label_2_2 = new System.Windows.Forms.Label();
            this.label_2_8 = new System.Windows.Forms.Label();
            this.label_2_3 = new System.Windows.Forms.Label();
            this.label_2_9 = new System.Windows.Forms.Label();
            this.label_2_4 = new System.Windows.Forms.Label();
            this.methodBox3 = new System.Windows.Forms.GroupBox();
            this.label_3_5 = new System.Windows.Forms.Label();
            this.label_3_0 = new System.Windows.Forms.Label();
            this.label_3_6 = new System.Windows.Forms.Label();
            this.label_3_1 = new System.Windows.Forms.Label();
            this.label_3_7 = new System.Windows.Forms.Label();
            this.label_3_2 = new System.Windows.Forms.Label();
            this.label_3_8 = new System.Windows.Forms.Label();
            this.label_3_3 = new System.Windows.Forms.Label();
            this.label_3_9 = new System.Windows.Forms.Label();
            this.label_3_4 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.imageChooseButton = new System.Windows.Forms.Button();
            this.methodsChooseBox.SuspendLayout();
            this.methodBox1.SuspendLayout();
            this.methodBox2.SuspendLayout();
            this.methodBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // methodsChooseBox
            // 
            this.methodsChooseBox.Controls.Add(this.neuralNetworkRadioButton);
            this.methodsChooseBox.Controls.Add(this.gradientBoostingRadioButton);
            this.methodsChooseBox.Controls.Add(this.randomForestRadioButton);
            this.methodsChooseBox.Controls.Add(this.allMethodsRadioMethod);
            this.methodsChooseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodsChooseBox.Location = new System.Drawing.Point(276, 12);
            this.methodsChooseBox.Name = "methodsChooseBox";
            this.methodsChooseBox.Size = new System.Drawing.Size(155, 120);
            this.methodsChooseBox.TabIndex = 2;
            this.methodsChooseBox.TabStop = false;
            this.methodsChooseBox.Text = "Methods";
            // 
            // neuralNetworkRadioButton
            // 
            this.neuralNetworkRadioButton.AutoSize = true;
            this.neuralNetworkRadioButton.Location = new System.Drawing.Point(6, 66);
            this.neuralNetworkRadioButton.Name = "neuralNetworkRadioButton";
            this.neuralNetworkRadioButton.Size = new System.Drawing.Size(129, 22);
            this.neuralNetworkRadioButton.TabIndex = 4;
            this.neuralNetworkRadioButton.TabStop = true;
            this.neuralNetworkRadioButton.Text = "Neural Network";
            this.neuralNetworkRadioButton.UseVisualStyleBackColor = true;
            // 
            // gradientBoostingRadioButton
            // 
            this.gradientBoostingRadioButton.AutoSize = true;
            this.gradientBoostingRadioButton.Location = new System.Drawing.Point(6, 43);
            this.gradientBoostingRadioButton.Name = "gradientBoostingRadioButton";
            this.gradientBoostingRadioButton.Size = new System.Drawing.Size(145, 22);
            this.gradientBoostingRadioButton.TabIndex = 3;
            this.gradientBoostingRadioButton.TabStop = true;
            this.gradientBoostingRadioButton.Text = "Gradient Boosting";
            this.gradientBoostingRadioButton.UseVisualStyleBackColor = true;
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
            // allMethodsRadioMethod
            // 
            this.allMethodsRadioMethod.AutoSize = true;
            this.allMethodsRadioMethod.Location = new System.Drawing.Point(6, 90);
            this.allMethodsRadioMethod.Name = "allMethodsRadioMethod";
            this.allMethodsRadioMethod.Size = new System.Drawing.Size(103, 22);
            this.allMethodsRadioMethod.TabIndex = 1;
            this.allMethodsRadioMethod.TabStop = true;
            this.allMethodsRadioMethod.Text = "All methods";
            this.allMethodsRadioMethod.UseVisualStyleBackColor = true;
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
            // label_1_8
            // 
            this.label_1_8.AutoSize = true;
            this.label_1_8.Location = new System.Drawing.Point(261, 52);
            this.label_1_8.Name = "label_1_8";
            this.label_1_8.Size = new System.Drawing.Size(27, 18);
            this.label_1_8.TabIndex = 11;
            this.label_1_8.Text = "8 :";
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
            // label_1_9
            // 
            this.label_1_9.AutoSize = true;
            this.label_1_9.Location = new System.Drawing.Point(346, 52);
            this.label_1_9.Name = "label_1_9";
            this.label_1_9.Size = new System.Drawing.Size(27, 18);
            this.label_1_9.TabIndex = 9;
            this.label_1_9.Text = "9 :";
            // 
            // label_1_4
            // 
            this.label_1_4.AutoSize = true;
            this.label_1_4.Location = new System.Drawing.Point(346, 28);
            this.label_1_4.Name = "label_1_4";
            this.label_1_4.Size = new System.Drawing.Size(27, 18);
            this.label_1_4.TabIndex = 8;
            this.label_1_4.Text = "4 :";
            // 
            // methodBox2
            // 
            this.methodBox2.Controls.Add(this.label_2_5);
            this.methodBox2.Controls.Add(this.label_2_0);
            this.methodBox2.Controls.Add(this.label_2_6);
            this.methodBox2.Controls.Add(this.label_2_1);
            this.methodBox2.Controls.Add(this.label_2_7);
            this.methodBox2.Controls.Add(this.label_2_2);
            this.methodBox2.Controls.Add(this.label_2_8);
            this.methodBox2.Controls.Add(this.label_2_3);
            this.methodBox2.Controls.Add(this.label_2_9);
            this.methodBox2.Controls.Add(this.label_2_4);
            this.methodBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodBox2.Location = new System.Drawing.Point(12, 307);
            this.methodBox2.Name = "methodBox2";
            this.methodBox2.Size = new System.Drawing.Size(419, 93);
            this.methodBox2.TabIndex = 18;
            this.methodBox2.TabStop = false;
            this.methodBox2.Text = "MethodName2";
            // 
            // label_2_5
            // 
            this.label_2_5.AutoSize = true;
            this.label_2_5.Location = new System.Drawing.Point(6, 52);
            this.label_2_5.Name = "label_2_5";
            this.label_2_5.Size = new System.Drawing.Size(27, 18);
            this.label_2_5.TabIndex = 17;
            this.label_2_5.Text = "5 :";
            // 
            // label_2_0
            // 
            this.label_2_0.AutoSize = true;
            this.label_2_0.Location = new System.Drawing.Point(6, 28);
            this.label_2_0.Name = "label_2_0";
            this.label_2_0.Size = new System.Drawing.Size(27, 18);
            this.label_2_0.TabIndex = 16;
            this.label_2_0.Text = "0 :";
            // 
            // label_2_6
            // 
            this.label_2_6.AutoSize = true;
            this.label_2_6.Location = new System.Drawing.Point(86, 52);
            this.label_2_6.Name = "label_2_6";
            this.label_2_6.Size = new System.Drawing.Size(27, 18);
            this.label_2_6.TabIndex = 15;
            this.label_2_6.Text = "6 :";
            // 
            // label_2_1
            // 
            this.label_2_1.AutoSize = true;
            this.label_2_1.Location = new System.Drawing.Point(86, 28);
            this.label_2_1.Name = "label_2_1";
            this.label_2_1.Size = new System.Drawing.Size(27, 18);
            this.label_2_1.TabIndex = 14;
            this.label_2_1.Text = "1 :";
            // 
            // label_2_7
            // 
            this.label_2_7.AutoSize = true;
            this.label_2_7.Location = new System.Drawing.Point(173, 52);
            this.label_2_7.Name = "label_2_7";
            this.label_2_7.Size = new System.Drawing.Size(27, 18);
            this.label_2_7.TabIndex = 13;
            this.label_2_7.Text = "7 :";
            // 
            // label_2_2
            // 
            this.label_2_2.AutoSize = true;
            this.label_2_2.Location = new System.Drawing.Point(173, 28);
            this.label_2_2.Name = "label_2_2";
            this.label_2_2.Size = new System.Drawing.Size(27, 18);
            this.label_2_2.TabIndex = 12;
            this.label_2_2.Text = "2 :";
            // 
            // label_2_8
            // 
            this.label_2_8.AutoSize = true;
            this.label_2_8.Location = new System.Drawing.Point(261, 52);
            this.label_2_8.Name = "label_2_8";
            this.label_2_8.Size = new System.Drawing.Size(27, 18);
            this.label_2_8.TabIndex = 11;
            this.label_2_8.Text = "8 :";
            // 
            // label_2_3
            // 
            this.label_2_3.AutoSize = true;
            this.label_2_3.Location = new System.Drawing.Point(261, 28);
            this.label_2_3.Name = "label_2_3";
            this.label_2_3.Size = new System.Drawing.Size(27, 18);
            this.label_2_3.TabIndex = 10;
            this.label_2_3.Text = "3 :";
            // 
            // label_2_9
            // 
            this.label_2_9.AutoSize = true;
            this.label_2_9.Location = new System.Drawing.Point(346, 52);
            this.label_2_9.Name = "label_2_9";
            this.label_2_9.Size = new System.Drawing.Size(27, 18);
            this.label_2_9.TabIndex = 9;
            this.label_2_9.Text = "9 :";
            // 
            // label_2_4
            // 
            this.label_2_4.AutoSize = true;
            this.label_2_4.Location = new System.Drawing.Point(346, 28);
            this.label_2_4.Name = "label_2_4";
            this.label_2_4.Size = new System.Drawing.Size(27, 18);
            this.label_2_4.TabIndex = 8;
            this.label_2_4.Text = "4 :";
            // 
            // methodBox3
            // 
            this.methodBox3.Controls.Add(this.label_3_5);
            this.methodBox3.Controls.Add(this.label_3_0);
            this.methodBox3.Controls.Add(this.label_3_6);
            this.methodBox3.Controls.Add(this.label_3_1);
            this.methodBox3.Controls.Add(this.label_3_7);
            this.methodBox3.Controls.Add(this.label_3_2);
            this.methodBox3.Controls.Add(this.label_3_8);
            this.methodBox3.Controls.Add(this.label_3_3);
            this.methodBox3.Controls.Add(this.label_3_9);
            this.methodBox3.Controls.Add(this.label_3_4);
            this.methodBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodBox3.Location = new System.Drawing.Point(12, 415);
            this.methodBox3.Name = "methodBox3";
            this.methodBox3.Size = new System.Drawing.Size(419, 93);
            this.methodBox3.TabIndex = 19;
            this.methodBox3.TabStop = false;
            this.methodBox3.Text = "MethodName3";
            // 
            // label_3_5
            // 
            this.label_3_5.AutoSize = true;
            this.label_3_5.Location = new System.Drawing.Point(6, 52);
            this.label_3_5.Name = "label_3_5";
            this.label_3_5.Size = new System.Drawing.Size(27, 18);
            this.label_3_5.TabIndex = 17;
            this.label_3_5.Text = "5 :";
            // 
            // label_3_0
            // 
            this.label_3_0.AutoSize = true;
            this.label_3_0.Location = new System.Drawing.Point(6, 28);
            this.label_3_0.Name = "label_3_0";
            this.label_3_0.Size = new System.Drawing.Size(27, 18);
            this.label_3_0.TabIndex = 16;
            this.label_3_0.Text = "0 :";
            // 
            // label_3_6
            // 
            this.label_3_6.AutoSize = true;
            this.label_3_6.Location = new System.Drawing.Point(86, 52);
            this.label_3_6.Name = "label_3_6";
            this.label_3_6.Size = new System.Drawing.Size(27, 18);
            this.label_3_6.TabIndex = 15;
            this.label_3_6.Text = "6 :";
            // 
            // label_3_1
            // 
            this.label_3_1.AutoSize = true;
            this.label_3_1.Location = new System.Drawing.Point(86, 28);
            this.label_3_1.Name = "label_3_1";
            this.label_3_1.Size = new System.Drawing.Size(27, 18);
            this.label_3_1.TabIndex = 14;
            this.label_3_1.Text = "1 :";
            // 
            // label_3_7
            // 
            this.label_3_7.AutoSize = true;
            this.label_3_7.Location = new System.Drawing.Point(173, 52);
            this.label_3_7.Name = "label_3_7";
            this.label_3_7.Size = new System.Drawing.Size(27, 18);
            this.label_3_7.TabIndex = 13;
            this.label_3_7.Text = "7 :";
            // 
            // label_3_2
            // 
            this.label_3_2.AutoSize = true;
            this.label_3_2.Location = new System.Drawing.Point(173, 28);
            this.label_3_2.Name = "label_3_2";
            this.label_3_2.Size = new System.Drawing.Size(27, 18);
            this.label_3_2.TabIndex = 12;
            this.label_3_2.Text = "2 :";
            // 
            // label_3_8
            // 
            this.label_3_8.AutoSize = true;
            this.label_3_8.Location = new System.Drawing.Point(261, 52);
            this.label_3_8.Name = "label_3_8";
            this.label_3_8.Size = new System.Drawing.Size(27, 18);
            this.label_3_8.TabIndex = 11;
            this.label_3_8.Text = "8 :";
            // 
            // label_3_3
            // 
            this.label_3_3.AutoSize = true;
            this.label_3_3.Location = new System.Drawing.Point(261, 28);
            this.label_3_3.Name = "label_3_3";
            this.label_3_3.Size = new System.Drawing.Size(27, 18);
            this.label_3_3.TabIndex = 10;
            this.label_3_3.Text = "3 :";
            // 
            // label_3_9
            // 
            this.label_3_9.AutoSize = true;
            this.label_3_9.Location = new System.Drawing.Point(346, 52);
            this.label_3_9.Name = "label_3_9";
            this.label_3_9.Size = new System.Drawing.Size(27, 18);
            this.label_3_9.TabIndex = 9;
            this.label_3_9.Text = "9 :";
            // 
            // label_3_4
            // 
            this.label_3_4.AutoSize = true;
            this.label_3_4.Location = new System.Drawing.Point(346, 28);
            this.label_3_4.Name = "label_3_4";
            this.label_3_4.Size = new System.Drawing.Size(27, 18);
            this.label_3_4.TabIndex = 8;
            this.label_3_4.Text = "4 :";
            // 
            // resetButton
            // 
            this.resetButton.BackgroundImage = global::TechsonClient.Properties.Resources.restart;
            this.resetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetButton.Location = new System.Drawing.Point(333, 139);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(42, 41);
            this.resetButton.TabIndex = 20;
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TechsonClient.Properties.Resources.play_xxl;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(381, 137);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(50, 43);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.startPredict);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(258, 168);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // imageChooseButton
            // 
            this.imageChooseButton.BackgroundImage = global::TechsonClient.Properties.Resources.search_engine_1;
            this.imageChooseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageChooseButton.Location = new System.Drawing.Point(276, 138);
            this.imageChooseButton.Name = "imageChooseButton";
            this.imageChooseButton.Size = new System.Drawing.Size(51, 43);
            this.imageChooseButton.TabIndex = 1;
            this.imageChooseButton.UseVisualStyleBackColor = true;
            this.imageChooseButton.Click += new System.EventHandler(this.chooseImage);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 192);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.methodBox3);
            this.Controls.Add(this.methodBox2);
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
            this.methodsChooseBox.ResumeLayout(false);
            this.methodsChooseBox.PerformLayout();
            this.methodBox1.ResumeLayout(false);
            this.methodBox1.PerformLayout();
            this.methodBox2.ResumeLayout(false);
            this.methodBox2.PerformLayout();
            this.methodBox3.ResumeLayout(false);
            this.methodBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button imageChooseButton;
        private System.Windows.Forms.GroupBox methodsChooseBox;
        private System.Windows.Forms.RadioButton allMethodsRadioMethod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton neuralNetworkRadioButton;
        private System.Windows.Forms.RadioButton gradientBoostingRadioButton;
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
        private System.Windows.Forms.GroupBox methodBox2;
        private System.Windows.Forms.Label label_2_5;
        private System.Windows.Forms.Label label_2_0;
        private System.Windows.Forms.Label label_2_6;
        private System.Windows.Forms.Label label_2_1;
        private System.Windows.Forms.Label label_2_7;
        private System.Windows.Forms.Label label_2_2;
        private System.Windows.Forms.Label label_2_8;
        private System.Windows.Forms.Label label_2_3;
        private System.Windows.Forms.Label label_2_9;
        private System.Windows.Forms.Label label_2_4;
        private System.Windows.Forms.GroupBox methodBox3;
        private System.Windows.Forms.Label label_3_5;
        private System.Windows.Forms.Label label_3_0;
        private System.Windows.Forms.Label label_3_6;
        private System.Windows.Forms.Label label_3_1;
        private System.Windows.Forms.Label label_3_7;
        private System.Windows.Forms.Label label_3_2;
        private System.Windows.Forms.Label label_3_8;
        private System.Windows.Forms.Label label_3_3;
        private System.Windows.Forms.Label label_3_9;
        private System.Windows.Forms.Label label_3_4;
        private System.Windows.Forms.Button resetButton;
    }
}

