using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MathNet.Numerics.Integration;
using MathNet.Symbolics;
using static MathNet.Symbolics.SymbolicExpression;
using OxyPlot;
using OxyPlot.Series;

namespace MetodeNumericeCalcululIntegral
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_Integrate_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_A.Text),
                   b = Convert.ToDouble(txt_B.Text);

            string Function = txt_Func.Text;

            SymbolicExpression x = Variable("x");
            Func<double, double> f = Parse(Function).Compile(nameof(x));

            double IntegrationResult = SimpsonRule.IntegrateComposite(f, a, b, 4);
            txt_Result.Text = IntegrationResult.ToString();

            // Draw area under function graph

            var model = new PlotModel { Title = "Area of f(x)" };

            var series = new AreaSeries { Title = "∫ f(x)dx" };
            
            for (double x_val = a; x_val <= b; x_val += 0.01d)
            {
                series.Points.Add(new DataPoint(x_val, f(x_val)));
                series.Points2.Add(new DataPoint(x_val, 0));
            }
            
            series.Color2 = OxyColors.Transparent;
            
            model.Series.Add(series);

            FunctionSeries func = new FunctionSeries(f, a - (1.0d/4.0d)*Math.Abs(a), b + (1.0d/4.0d)*b, 0.01d, "f(x)");

            model.Series.Add(func);

            plot1.Model = model;
        }

    }
}
