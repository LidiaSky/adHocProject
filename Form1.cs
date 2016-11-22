using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace adHoc
{
    public partial class Form1 : Form
    {
        private double radiusMax, radiusMin;
        private string buttonLaunchOldCaption = string.Empty;
        private const double eps = 1e-5;
        private bool isRunning = false;
        private BackgroundWorker worker;
        public Form1()
        {
            InitializeComponent();

            const string tooltip = @"Перед началом тестирования убедитесь, что у вас введены значения минимума и максимума радиуса покрытия вершин.
Введенные значения не должны превышать значения радиуса области";
            foreach (var c in new Control[] { buttonLaunch, textBoxRadiusMax, textBoxRadiusMin })
            {
                toolTipTestWarning.SetToolTip(c, tooltip);
            }
            toolTipTestWarning.SetToolTip(progressBarTotal, "Прогресс тестирования");
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            try
            {
                radiusMin = Convert.ToDouble(textBoxRadiusMax.Text);
                radiusMax = Convert.ToDouble(textBoxRadiusMax.Text);
                bool launch = (radiusMin > eps) && (radiusMin <= radiusMax)
                    && (radiusMax <= Convert.ToDouble(numericUpDownRadius.Value));
                if (!launch)
                {
                    MessageBox.Show("Ошибка. Проверьте введенные параметры");
                }
            }
            catch
            {
                MessageBox.Show("Введены нечисловые значения интервала радиуса покрытия");
            }
          
            var iterations = Convert.ToInt32(numericUpDownIterationsCount.Value);
            var verticesMin = Convert.ToInt32(numericUpDownVerticesMin.Value);
            var verticesMax = Convert.ToInt32(numericUpDownVerticesMax.Value);
            var verticesStep = Convert.ToInt32(numericUpDownVerticesStep.Value);

            int progressCount = 0;
            for (int verticesCurrent = verticesMin; verticesCurrent <= verticesMax; verticesCurrent += verticesStep)
            {
                progressCount += verticesCurrent;
            }
            progressBarTotal.Maximum = progressCount;
            progressBarCurrentCount.Maximum = iterations;
            int threadsToWait = progressCount;
            progressBarTotal.Minimum = progressBarTotal.Value = 0;
            progressCount = 0;
            worker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            if (isRunning)
            {
                worker.CancelAsync();
                return;
            }
            isRunning = true;
            buttonLaunchOldCaption = buttonLaunch.Text;
            buttonLaunch.Text = "Остановить тестирование";

            worker.DoWork += (obj, args) =>
            {
                int progressCurrent = 0;
                var radiiAvgTotal = new Dictionary<int, double>();
                DateTime time1 = DateTime.Now;
                for (int verticesCurrent = verticesMin; verticesCurrent <= verticesMax; verticesCurrent += verticesStep)
                {
                    double sum = 0;
                    int iter = 0;
                    var generator = new NetworkGenerator(Convert.ToDouble(numericUpDownRadius.Value), verticesCurrent);
                    var graph = new Graph(verticesCurrent);
                    for (int i = 0; i < iterations; i++)
                    {
                        float r = graph.AverageDegree(generator.Generate(
                            Convert.ToDouble(textBoxRadiusMin.Text),
                            Convert.ToDouble(textBoxRadiusMax.Text),
                            radioButton3D.Checked));
                        if (r != 0)
                        {
                            sum += r;
                            iter++;
                        }
                        if (worker.CancellationPending)
                        {
                            args.Cancel = true;
                            args.Result = null;
                            return;
                        }
                        worker.ReportProgress(progressCurrent, new WorkerProgress(i + 1, verticesCurrent));

                    }

                    radiiAvgTotal.Add(verticesCurrent, (iter == 0) ? 0 : sum * 1.0 / iter);
                    progressCurrent += verticesCurrent;

                }
                worker.ReportProgress(progressCurrent, new WorkerProgress(iterations, verticesMax)); 
                System.Threading.Thread.Sleep(1000); 
                args.Result = new WorkerResult(radiiAvgTotal, DateTime.Now - time1);
            };
            worker.RunWorkerCompleted += (obj, args) =>
            {
                isRunning = false;
                buttonLaunch.Text = buttonLaunchOldCaption;
                if (args.Cancelled)
                {
                    MessageBox.Show("Тестирование остановлено по запросу пользователя");
                }
                else
                {
                    var res = args.Result as WorkerResult;
                    Chart(res.RadiiAvgTotal);
                    textBoxAvgRadius.Text = Math.Round(res.RadiiAvgTotal.Average(pair => pair.Value), 5).ToString();
                    textBoxTotalTime.Text = (res.WorkTime).ToString(@"h\:mm\:ss");
                    tabControl1.SelectedTab = tabResults;
                }
            };
            worker.ProgressChanged += (obj, args) =>
            {
                progressBarTotal.Value = args.ProgressPercentage;
                var state = args.UserState as WorkerProgress;
                toolTipTestWarning.SetToolTip(progressBarTotal, string.Format("Текущее кол-во вершин: {0}", state.VerticesCurrent));
                progressBarCurrentCount.Value = state.CurrentCount;
                toolTipTestWarning.SetToolTip(progressBarCurrentCount, string.Format("Обработано итераций: {0} из {1}", state.CurrentCount, iterations));
            };

            worker.RunWorkerAsync();
        }
        private void Chart(Dictionary<int, double> data)
        {
            chart.Series.Clear();
            chart.Series.Add(new Series
            {
                IsVisibleInLegend = false, 
                ChartType = SeriesChartType.Spline,
                Color = Color.BlueViolet
            });
            chart.Series.Add(new Series
            {
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Point,
                Color = Color.BlueViolet
            });
            chart.ChartAreas[0].AxisX.Title = "Количество вершин";
            chart.ChartAreas[0].AxisY.Title = "Мат. ожидание средней степени вершины";
            chart.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart.ChartAreas[0].AxisY.Maximum = data.Max(pair => pair.Value) * 1.05;
            foreach (var point in data)
            {
                chart.Series[0].Points.AddXY(point.Key.ToString(), point.Value);
                chart.Series[1].Points.AddXY(point.Key.ToString(), point.Value);
            }
            chart.ChartAreas[0].RecalculateAxesScale();
        }
    }
    class WorkerResult
    {
        public readonly Dictionary<int, double> RadiiAvgTotal;
        public readonly TimeSpan WorkTime;
        public WorkerResult(Dictionary<int, double> radiiAvgTotal, TimeSpan workTime)
        {
            RadiiAvgTotal = radiiAvgTotal;
            WorkTime = workTime;
        }
    }
    class WorkerProgress
    {
        public readonly int CurrentCount, VerticesCurrent;
        public WorkerProgress(int currentCount, int verticesCurrent)
        {
            CurrentCount = currentCount;
            VerticesCurrent = verticesCurrent;
        }
    }
}
