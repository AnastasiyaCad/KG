namespace KGLab3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPosX = new System.Windows.Forms.TrackBar();
            this.tbPosY = new System.Windows.Forms.TrackBar();
            this.comboSize = new System.Windows.Forms.ComboBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCubePosZ = new System.Windows.Forms.TextBox();
            this.textCubePosY = new System.Windows.Forms.TextBox();
            this.textCubePosX = new System.Windows.Forms.TextBox();
            this.buttonAddCube = new System.Windows.Forms.Button();
            this.trackRayTrDepth = new System.Windows.Forms.TrackBar();
            this.radioLight = new System.Windows.Forms.RadioButton();
            this.radioCamera = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRayTrDepth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(18, 755);
            this.tbPosX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPosX.Maximum = 50;
            this.tbPosX.Minimum = -50;
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(711, 69);
            this.tbPosX.TabIndex = 2;
            this.tbPosX.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbPosX.Value = 2;
            this.tbPosX.Scroll += new System.EventHandler(this.tbPosX_Scroll);
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(754, 18);
            this.tbPosY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPosY.Maximum = 50;
            this.tbPosY.Minimum = -50;
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbPosY.Size = new System.Drawing.Size(69, 769);
            this.tbPosY.TabIndex = 3;
            this.tbPosY.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbPosY.Value = 2;
            this.tbPosY.Scroll += new System.EventHandler(this.tbPosY_Scroll);
            // 
            // comboSize
            // 
            this.comboSize.FormattingEnabled = true;
            this.comboSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboSize.Location = new System.Drawing.Point(183, 108);
            this.comboSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboSize.Name = "comboSize";
            this.comboSize.Size = new System.Drawing.Size(156, 28);
            this.comboSize.TabIndex = 8;
            this.comboSize.Text = "размер";
            this.comboSize.SelectedIndexChanged += new System.EventHandler(this.ComboSize_SelectedIndexChanged);
            // 
            // comboColor
            // 
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Items.AddRange(new object[] {
            "красный",
            "зелёный",
            "синий",
            "жёлтый",
            "белый"});
            this.comboColor.Location = new System.Drawing.Point(9, 108);
            this.comboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(153, 28);
            this.comboColor.TabIndex = 7;
            this.comboColor.Text = "цвет";
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.ComboColor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "z:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "x:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textCubePosZ
            // 
            this.textCubePosZ.Location = new System.Drawing.Point(252, 53);
            this.textCubePosZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCubePosZ.Name = "textCubePosZ";
            this.textCubePosZ.Size = new System.Drawing.Size(87, 26);
            this.textCubePosZ.TabIndex = 3;
            this.textCubePosZ.Text = "0";
            // 
            // textCubePosY
            // 
            this.textCubePosY.Location = new System.Drawing.Point(130, 53);
            this.textCubePosY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCubePosY.Name = "textCubePosY";
            this.textCubePosY.Size = new System.Drawing.Size(87, 26);
            this.textCubePosY.TabIndex = 2;
            this.textCubePosY.Text = "0";
            // 
            // textCubePosX
            // 
            this.textCubePosX.Location = new System.Drawing.Point(11, 53);
            this.textCubePosX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCubePosX.Name = "textCubePosX";
            this.textCubePosX.Size = new System.Drawing.Size(87, 26);
            this.textCubePosX.TabIndex = 1;
            this.textCubePosX.Text = "0";
            // 
            // buttonAddCube
            // 
            this.buttonAddCube.Location = new System.Drawing.Point(84, 164);
            this.buttonAddCube.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddCube.Name = "buttonAddCube";
            this.buttonAddCube.Size = new System.Drawing.Size(185, 54);
            this.buttonAddCube.TabIndex = 0;
            this.buttonAddCube.Text = "Добавить";
            this.buttonAddCube.UseVisualStyleBackColor = true;
            this.buttonAddCube.Click += new System.EventHandler(this.buttonAddCube_Click);
            // 
            // trackRayTrDepth
            // 
            this.trackRayTrDepth.Location = new System.Drawing.Point(841, 499);
            this.trackRayTrDepth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackRayTrDepth.Minimum = 1;
            this.trackRayTrDepth.Name = "trackRayTrDepth";
            this.trackRayTrDepth.Size = new System.Drawing.Size(331, 69);
            this.trackRayTrDepth.TabIndex = 7;
            this.trackRayTrDepth.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackRayTrDepth.Value = 10;
            this.trackRayTrDepth.Scroll += new System.EventHandler(this.SetRayTracingDepth);
            // 
            // radioLight
            // 
            this.radioLight.AutoSize = true;
            this.radioLight.Checked = true;
            this.radioLight.Location = new System.Drawing.Point(8, 42);
            this.radioLight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioLight.Name = "radioLight";
            this.radioLight.Size = new System.Drawing.Size(131, 24);
            this.radioLight.TabIndex = 0;
            this.radioLight.TabStop = true;
            this.radioLight.Text = "Смена света";
            this.radioLight.UseVisualStyleBackColor = true;
            this.radioLight.CheckedChanged += new System.EventHandler(this.radioPositionChanged);
            // 
            // radioCamera
            // 
            this.radioCamera.AutoSize = true;
            this.radioCamera.Location = new System.Drawing.Point(8, 76);
            this.radioCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioCamera.Name = "radioCamera";
            this.radioCamera.Size = new System.Drawing.Size(144, 24);
            this.radioCamera.TabIndex = 1;
            this.radioCamera.Text = "Смена камеры\r\n";
            this.radioCamera.UseVisualStyleBackColor = true;
            this.radioCamera.CheckedChanged += new System.EventHandler(this.radioPositionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboSize);
            this.groupBox1.Controls.Add(this.buttonAddCube);
            this.groupBox1.Controls.Add(this.comboColor);
            this.groupBox1.Controls.Add(this.textCubePosX);
            this.groupBox1.Controls.Add(this.textCubePosY);
            this.groupBox1.Controls.Add(this.textCubePosZ);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(841, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 240);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить куб";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioLight);
            this.groupBox2.Controls.Add(this.radioCamera);
            this.groupBox2.Location = new System.Drawing.Point(841, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 127);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(845, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Глубина трассировки лучей";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1226, 825);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackRayTrDepth);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRayTrDepth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl GLView;
        private System.Windows.Forms.TrackBar tbPosX;
        private System.Windows.Forms.TrackBar tbPosY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCubePosZ;
        private System.Windows.Forms.TextBox textCubePosY;
        private System.Windows.Forms.TextBox textCubePosX;
        private System.Windows.Forms.Button buttonAddCube;
        private System.Windows.Forms.ComboBox comboSize;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.TrackBar trackRayTrDepth;
        private System.Windows.Forms.RadioButton radioLight;
        private System.Windows.Forms.RadioButton radioCamera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
    }
}

