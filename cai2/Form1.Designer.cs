
namespace cai2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numberOfPopulation = new System.Windows.Forms.MaskedTextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.populationGrid = new System.Windows.Forms.DataGridView();
            this.Step = new System.Windows.Forms.Button();
            this.Complete = new System.Windows.Forms.Button();
            this.Perhaps = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.populationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfPopulation
            // 
            this.numberOfPopulation.Location = new System.Drawing.Point(207, 12);
            this.numberOfPopulation.Mask = "00000";
            this.numberOfPopulation.Name = "numberOfPopulation";
            this.numberOfPopulation.Size = new System.Drawing.Size(42, 20);
            this.numberOfPopulation.TabIndex = 1;
            this.numberOfPopulation.ValidatingType = typeof(int);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(12, 15);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(189, 13);
            this.lab1.TabIndex = 2;
            this.lab1.Text = "Количество индивидов в поколении";
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(12, 44);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(219, 13);
            this.functionLabel.TabIndex = 3;
            this.functionLabel.Text = "Функция: F(x) = 62 - 57 x^2 + 5 X^3; Xmin =";
            // 
            // populationGrid
            // 
            this.populationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.populationGrid.Location = new System.Drawing.Point(15, 105);
            this.populationGrid.Name = "populationGrid";
            this.populationGrid.Size = new System.Drawing.Size(301, 334);
            this.populationGrid.TabIndex = 4;
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(15, 67);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(135, 32);
            this.Step.TabIndex = 5;
            this.Step.Text = "1 шаг алгоритма";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // Complete
            // 
            this.Complete.Location = new System.Drawing.Point(166, 67);
            this.Complete.Name = "Complete";
            this.Complete.Size = new System.Drawing.Size(149, 31);
            this.Complete.TabIndex = 6;
            this.Complete.Text = "завершить алгоритм";
            this.Complete.UseVisualStyleBackColor = true;
            this.Complete.Click += new System.EventHandler(this.Complete_Click);
            // 
            // Perhaps
            // 
            this.Perhaps.Location = new System.Drawing.Point(124, 446);
            this.Perhaps.Name = "Perhaps";
            this.Perhaps.Size = new System.Drawing.Size(26, 29);
            this.Perhaps.TabIndex = 7;
            this.Perhaps.Text = "<";
            this.Perhaps.UseVisualStyleBackColor = true;
            this.Perhaps.Click += new System.EventHandler(this.Perhaps_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(255, 12);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(61, 20);
            this.Create.TabIndex = 8;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(166, 446);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(25, 28);
            this.Next.TabIndex = 9;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(337, 15);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "График функции";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Текущее поколение";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(492, 431);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(838, 482);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Perhaps);
            this.Controls.Add(this.Complete);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.populationGrid);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.numberOfPopulation);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.populationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox numberOfPopulation;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.DataGridView populationGrid;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.Button Complete;
        private System.Windows.Forms.Button Perhaps;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

