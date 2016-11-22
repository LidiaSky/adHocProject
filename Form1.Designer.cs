namespace adHoc
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.progressBarCurrentCount = new System.Windows.Forms.ProgressBar();
            this.progressBarTotal = new System.Windows.Forms.ProgressBar();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.groupBoxGeneration = new System.Windows.Forms.GroupBox();
            this.numericUpDownVerticesStep = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownVerticesMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVerticesMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxAdvanced = new System.Windows.Forms.GroupBox();
            this.textBoxRadiusMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRadiusMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownIterationsCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxBasic = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton3D = new System.Windows.Forms.RadioButton();
            this.radioButton2D = new System.Windows.Forms.RadioButton();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxTotalTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTipTestWarning = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAvgRadius = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.groupBoxGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesMin)).BeginInit();
            this.groupBoxAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationsCount)).BeginInit();
            this.groupBoxBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInput);
            this.tabControl1.Controls.Add(this.tabResults);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.label13);
            this.tabInput.Controls.Add(this.label12);
            this.tabInput.Controls.Add(this.progressBarCurrentCount);
            this.tabInput.Controls.Add(this.progressBarTotal);
            this.tabInput.Controls.Add(this.buttonLaunch);
            this.tabInput.Controls.Add(this.groupBoxGeneration);
            this.tabInput.Controls.Add(this.groupBoxAdvanced);
            this.tabInput.Controls.Add(this.groupBoxBasic);
            this.tabInput.Location = new System.Drawing.Point(4, 29);
            this.tabInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabInput.Size = new System.Drawing.Size(574, 451);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Исходные данные";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Прогресс для текущего кол-ва вершин";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Общий прогресс";
            // 
            // progressBarCurrentCount
            // 
            this.progressBarCurrentCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarCurrentCount.Location = new System.Drawing.Point(308, 347);
            this.progressBarCurrentCount.Name = "progressBarCurrentCount";
            this.progressBarCurrentCount.Size = new System.Drawing.Size(266, 25);
            this.progressBarCurrentCount.TabIndex = 12;
            // 
            // progressBarTotal
            // 
            this.progressBarTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarTotal.Location = new System.Drawing.Point(308, 316);
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(266, 25);
            this.progressBarTotal.TabIndex = 11;
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLaunch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLaunch.Location = new System.Drawing.Point(0, 403);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(574, 48);
            this.buttonLaunch.TabIndex = 10;
            this.buttonLaunch.Text = "Начать тестирование";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // groupBoxGeneration
            // 
            this.groupBoxGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeneration.Controls.Add(this.numericUpDownVerticesStep);
            this.groupBoxGeneration.Controls.Add(this.label2);
            this.groupBoxGeneration.Controls.Add(this.numericUpDownVerticesMax);
            this.groupBoxGeneration.Controls.Add(this.numericUpDownVerticesMin);
            this.groupBoxGeneration.Controls.Add(this.label4);
            this.groupBoxGeneration.Controls.Add(this.label3);
            this.groupBoxGeneration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGeneration.Location = new System.Drawing.Point(301, 3);
            this.groupBoxGeneration.Name = "groupBoxGeneration";
            this.groupBoxGeneration.Size = new System.Drawing.Size(270, 134);
            this.groupBoxGeneration.TabIndex = 9;
            this.groupBoxGeneration.TabStop = false;
            this.groupBoxGeneration.Text = "Число вершин в графе";
            // 
            // numericUpDownVerticesStep
            // 
            this.numericUpDownVerticesStep.Location = new System.Drawing.Point(126, 99);
            this.numericUpDownVerticesStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVerticesStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVerticesStep.Name = "numericUpDownVerticesStep";
            this.numericUpDownVerticesStep.Size = new System.Drawing.Size(131, 27);
            this.numericUpDownVerticesStep.TabIndex = 6;
            this.numericUpDownVerticesStep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шаг";
            // 
            // numericUpDownVerticesMax
            // 
            this.numericUpDownVerticesMax.Location = new System.Drawing.Point(126, 66);
            this.numericUpDownVerticesMax.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownVerticesMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVerticesMax.Name = "numericUpDownVerticesMax";
            this.numericUpDownVerticesMax.Size = new System.Drawing.Size(131, 27);
            this.numericUpDownVerticesMax.TabIndex = 4;
            this.numericUpDownVerticesMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownVerticesMin
            // 
            this.numericUpDownVerticesMin.Location = new System.Drawing.Point(126, 33);
            this.numericUpDownVerticesMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVerticesMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVerticesMin.Name = "numericUpDownVerticesMin";
            this.numericUpDownVerticesMin.Size = new System.Drawing.Size(131, 27);
            this.numericUpDownVerticesMin.TabIndex = 3;
            this.numericUpDownVerticesMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Минимум";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Максимум";
            // 
            // groupBoxAdvanced
            // 
            this.groupBoxAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAdvanced.Controls.Add(this.textBoxRadiusMax);
            this.groupBoxAdvanced.Controls.Add(this.label9);
            this.groupBoxAdvanced.Controls.Add(this.textBoxRadiusMin);
            this.groupBoxAdvanced.Controls.Add(this.label8);
            this.groupBoxAdvanced.Controls.Add(this.label6);
            this.groupBoxAdvanced.Controls.Add(this.numericUpDownIterationsCount);
            this.groupBoxAdvanced.Controls.Add(this.label7);
            this.groupBoxAdvanced.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdvanced.Location = new System.Drawing.Point(3, 143);
            this.groupBoxAdvanced.Name = "groupBoxAdvanced";
            this.groupBoxAdvanced.Size = new System.Drawing.Size(568, 167);
            this.groupBoxAdvanced.TabIndex = 8;
            this.groupBoxAdvanced.TabStop = false;
            this.groupBoxAdvanced.Text = "Дополнительные параметры";
            // 
            // textBoxRadiusMax
            // 
            this.textBoxRadiusMax.Location = new System.Drawing.Point(424, 123);
            this.textBoxRadiusMax.Name = "textBoxRadiusMax";
            this.textBoxRadiusMax.Size = new System.Drawing.Size(131, 27);
            this.textBoxRadiusMax.TabIndex = 11;
            this.textBoxRadiusMax.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "до";
            // 
            // textBoxRadiusMin
            // 
            this.textBoxRadiusMin.Location = new System.Drawing.Point(424, 90);
            this.textBoxRadiusMin.Name = "textBoxRadiusMin";
            this.textBoxRadiusMin.Size = new System.Drawing.Size(131, 27);
            this.textBoxRadiusMin.TabIndex = 9;
            this.textBoxRadiusMin.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "от";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Радиус покрытия одной вершины лежит в границах";
            // 
            // numericUpDownIterationsCount
            // 
            this.numericUpDownIterationsCount.Location = new System.Drawing.Point(424, 33);
            this.numericUpDownIterationsCount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownIterationsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIterationsCount.Name = "numericUpDownIterationsCount";
            this.numericUpDownIterationsCount.Size = new System.Drawing.Size(131, 27);
            this.numericUpDownIterationsCount.TabIndex = 7;
            this.numericUpDownIterationsCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(395, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Количество итераций для каждого количества вершин:";
            // 
            // groupBoxBasic
            // 
            this.groupBoxBasic.Controls.Add(this.label5);
            this.groupBoxBasic.Controls.Add(this.radioButton3D);
            this.groupBoxBasic.Controls.Add(this.radioButton2D);
            this.groupBoxBasic.Controls.Add(this.numericUpDownRadius);
            this.groupBoxBasic.Controls.Add(this.label1);
            this.groupBoxBasic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBasic.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBasic.Name = "groupBoxBasic";
            this.groupBoxBasic.Size = new System.Drawing.Size(292, 134);
            this.groupBoxBasic.TabIndex = 7;
            this.groupBoxBasic.TabStop = false;
            this.groupBoxBasic.Text = "Область генерации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип области:";
            // 
            // radioButton3D
            // 
            this.radioButton3D.AutoSize = true;
            this.radioButton3D.Location = new System.Drawing.Point(148, 99);
            this.radioButton3D.Name = "radioButton3D";
            this.radioButton3D.Size = new System.Drawing.Size(71, 24);
            this.radioButton3D.TabIndex = 3;
            this.radioButton3D.TabStop = true;
            this.radioButton3D.Text = "Сфера";
            this.radioButton3D.UseVisualStyleBackColor = true;
            // 
            // radioButton2D
            // 
            this.radioButton2D.AutoSize = true;
            this.radioButton2D.Checked = true;
            this.radioButton2D.Location = new System.Drawing.Point(148, 69);
            this.radioButton2D.Name = "radioButton2D";
            this.radioButton2D.Size = new System.Drawing.Size(58, 24);
            this.radioButton2D.TabIndex = 2;
            this.radioButton2D.TabStop = true;
            this.radioButton2D.Text = "Круг";
            this.radioButton2D.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Location = new System.Drawing.Point(148, 33);
            this.numericUpDownRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(111, 27);
            this.numericUpDownRadius.TabIndex = 1;
            this.numericUpDownRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Радиус области:";
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.chart);
            this.tabResults.Controls.Add(this.textBoxTotalTime);
            this.tabResults.Controls.Add(this.textBoxAvgRadius);
            this.tabResults.Controls.Add(this.label11);
            this.tabResults.Controls.Add(this.label10);
            this.tabResults.Location = new System.Drawing.Point(4, 29);
            this.tabResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabResults.Size = new System.Drawing.Size(574, 451);
            this.tabResults.TabIndex = 1;
            this.tabResults.Text = "Результаты";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(7, 41);
            this.chart.Name = "chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(567, 405);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // textBoxTotalTime
            // 
            this.textBoxTotalTime.Location = new System.Drawing.Point(471, 8);
            this.textBoxTotalTime.Name = "textBoxTotalTime";
            this.textBoxTotalTime.ReadOnly = true;
            this.textBoxTotalTime.Size = new System.Drawing.Size(100, 27);
            this.textBoxTotalTime.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Время работы:";
            // 
            // toolTipTestWarning
            // 
            this.toolTipTestWarning.ToolTipTitle = "Перед началом тестирования убедитесь, что у вас введены значения минимума и макси" +
                "мума радиуса покрытия вершин.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = " ";
            // 
            // textBoxAvgRadius
            // 
            this.textBoxAvgRadius.Location = new System.Drawing.Point(471, 8);
            this.textBoxAvgRadius.Name = "textBoxAvgRadius";
            this.textBoxAvgRadius.ReadOnly = true;
            this.textBoxAvgRadius.Size = new System.Drawing.Size(100, 27);
            this.textBoxAvgRadius.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 484);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form";
            this.tabControl1.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.groupBoxGeneration.ResumeLayout(false);
            this.groupBoxGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticesMin)).EndInit();
            this.groupBoxAdvanced.ResumeLayout(false);
            this.groupBoxAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterationsCount)).EndInit();
            this.groupBoxBasic.ResumeLayout(false);
            this.groupBoxBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            this.tabResults.ResumeLayout(false);
            this.tabResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.GroupBox groupBoxGeneration;
        private System.Windows.Forms.NumericUpDown numericUpDownVerticesStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownVerticesMax;
        private System.Windows.Forms.NumericUpDown numericUpDownVerticesMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxAdvanced;
        private System.Windows.Forms.GroupBox groupBoxBasic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton3D;
        private System.Windows.Forms.RadioButton radioButton2D;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownIterationsCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRadiusMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRadiusMax;
        private System.Windows.Forms.ToolTip toolTipTestWarning;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTotalTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar progressBarCurrentCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAvgRadius;
        private System.Windows.Forms.Label label10;
    }
}

