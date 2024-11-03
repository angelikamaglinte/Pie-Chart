namespace Assignment2_PieChart
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
            drawButton = new Button();
            pieChartPanel = new Panel();
            inputTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblInstructions = new Label();
            SuspendLayout();
            // 
            // drawButton
            // 
            drawButton.BackColor = SystemColors.ActiveCaption;
            drawButton.Location = new Point(409, 114);
            drawButton.Name = "drawButton";
            drawButton.Size = new Size(95, 31);
            drawButton.TabIndex = 0;
            drawButton.Text = "Generate";
            drawButton.UseVisualStyleBackColor = false;
            // 
            // pieChartPanel
            // 
            pieChartPanel.BorderStyle = BorderStyle.FixedSingle;
            pieChartPanel.Location = new Point(41, 167);
            pieChartPanel.Name = "pieChartPanel";
            pieChartPanel.Size = new Size(463, 320);
            pieChartPanel.TabIndex = 1;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(140, 119);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(245, 23);
            inputTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(41, 123);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 3;
            label1.Text = "Input values:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat Black", 22F, FontStyle.Bold);
            label2.Location = new Point(194, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 41);
            label2.TabIndex = 4;
            label2.Text = "Pie Chart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 65);
            label3.Name = "label3";
            label3.Size = new Size(466, 21);
            label3.TabIndex = 5;
            label3.Text = "Instructions: Please input the values and click the Generate button.";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(160, 86);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(0, 15);
            lblInstructions.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 520);
            Controls.Add(lblInstructions);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputTextBox);
            Controls.Add(pieChartPanel);
            Controls.Add(drawButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pie Chart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button drawButton;
        private Panel pieChartPanel;
        private TextBox inputTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblInstructions;
    }
}
