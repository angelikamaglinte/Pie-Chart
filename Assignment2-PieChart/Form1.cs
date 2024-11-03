using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Assignment2_PieChart
{
    public partial class Form1 : Form
    {
        private List<int> values = new List<int>();

        public Form1()
        {
            InitializeComponent();
            this.drawButton.Click += new EventHandler(this.drawButton_Click);
            pieChartPanel.Paint += new PaintEventHandler(this.pieChartPanel_Paint);
            
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            if (!inputTextBox.Text.Contains(","))
            {
                MessageBox.Show("Please enter values separated by commas.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var input = inputTextBox.Text.Split(',')
                                          .Select(s => s.Trim())
                                          .Where(s => !string.IsNullOrEmpty(s))
                                          .Select(int.Parse)
                                          .ToList();

                if (input.Count == 0) return;

                values = input;

                pieChartPanel.Invalidate();
            } catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer values separated by commas.", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pieChartPanel_Paint(object sender, PaintEventArgs e)
        {
            if (values.Count > 0)
            {
                DrawPieChart(e.Graphics, values);
            }
        }

        private void DrawPieChart(Graphics g, List<int> values)
        {
            //// Calculate total and angles for each slice
            //var total = values.Sum();
            //var angles = values.Select(v => (float)v / total * 360).ToList();

            //// Define colors for the slices
            //var colors = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange };

            //// Initialize brushes explicitly
            //List<Brush> brushes = new List<Brush>();
            //foreach (var color in colors)
            //{
            //    brushes.Add(new SolidBrush(color));
            //}

            //// Draw each slice
            //float startAngle = 0f;
            //for (int i = 0; i < angles.Count; i++)
            //{
            //    g.FillPie(brushes[i % brushes.Count], 10, 10, 200, 200, startAngle, angles[i]);
            //    startAngle += angles[i];
            //}

            //// Draw the legend
            //DrawLegend(g, values, brushes);

            //// Dispose of the brushes after use to free resources
            //foreach (var brush in brushes)
            //{
            //    brush.Dispose();
            //}

            // Get panel dimensions
            int panelWidth = pieChartPanel.Width;
            int panelHeight = pieChartPanel.Height;

            // Set the size of the pie chart (slightly smaller than the panel)
            int pieWidth = panelWidth - 20;  // Leave some padding
            int pieHeight = panelHeight - 20; // Leave some padding

            // Ensure the pie chart is square by taking the smaller dimension
            int pieSize = Math.Min(pieWidth, pieHeight);

            // Calculate total and angles for each slice
            var total = values.Sum();
            var angles = values.Select(v => (float)v / total * 360).ToList();

            // Define colors for the slices
            var colors = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange };

            // Initialize brushes explicitly
            List<Brush> brushes = new List<Brush>();
            foreach (var color in colors)
            {
                brushes.Add(new SolidBrush(color));
            }

            // Draw each slice
            float startAngle = 0f;
            for (int i = 0; i < angles.Count; i++)
            {
                g.FillPie(brushes[i % brushes.Count], 10, 10, pieSize, pieSize, startAngle, angles[i]);
                startAngle += angles[i];
            }

            // Draw the legend, placing it to the right of the pie chart
            int legendX = pieSize + 100; // Adjust based on the pie chart's size
            int legendY = 10; // Keep some padding at the top
            DrawLegend(g, values, brushes, legendX, legendY);

            // Dispose of the brushes after use to free resources
            foreach (var brush in brushes)
            {
                brush.Dispose();
            }
        }

        //private void DrawLegend(Graphics g, List<int> values, List<Brush> brushes)
        //{
        //    int legendX = 220;
        //    int legendY = 20;
        //    int legendItemHeight = 20;

        //    for (int i = 0; i < values.Count; i++)
        //    {
        //        // Use the brush for the legend color
        //        g.FillRectangle(brushes[i % brushes.Count], legendX, legendY + i * legendItemHeight, 15, 15);
        //        g.DrawString(values[i].ToString(), this.Font, Brushes.Black, legendX + 20, legendY + i * legendItemHeight);
        //    }
        //}

        private void DrawLegend(Graphics g, List<int> values, List<Brush> brushes, int legendX, int legendY)
        {
            int legendItemHeight = 20; // Height of each legend item

            for (int i = 0; i < values.Count; i++)
            {
                // Use the brush for the legend color
                g.FillRectangle(brushes[i % brushes.Count], legendX, legendY + i * legendItemHeight, 15, 15);
                g.DrawString(values[i].ToString(), this.Font, Brushes.Black, legendX + 20, legendY + i * legendItemHeight);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
