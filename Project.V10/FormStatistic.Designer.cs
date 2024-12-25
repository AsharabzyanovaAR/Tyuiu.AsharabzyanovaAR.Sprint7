namespace Project.V10
{
    partial class FormStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxOrdersStatistic_AAR = new GroupBox();
            labelOrdersCount_AAR = new Label();
            labelMostPopularCity_AAR = new Label();
            labelAverageOrderValue_AAR = new Label();
            labelMinOrderValue_AAR = new Label();
            labelMaxOrderValue_AAR = new Label();
            labelMostPopularDateOfOrder_AAR = new Label();
            labelMostPopularUserID_AAR = new Label();
            groupBoxProduct_AAR = new GroupBox();
            labelAverageProductPrice_AAR = new Label();
            labelMinProductPrice_AAR = new Label();
            labelMaxProductPrice_AAR = new Label();
            labelMaxProductCount_AAR = new Label();
            labelMostPopularProduct_AAR = new Label();
            chartProductDiag_AAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelLeft_AAR = new Panel();
            groupBoxOrdersStatistic_AAR.SuspendLayout();
            groupBoxProduct_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductDiag_AAR).BeginInit();
            panelLeft_AAR.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOrdersStatistic_AAR
            // 
            groupBoxOrdersStatistic_AAR.Controls.Add(labelOrdersCount_AAR);
            groupBoxOrdersStatistic_AAR.Controls.Add(labelMostPopularCity_AAR);
            groupBoxOrdersStatistic_AAR.Controls.Add(labelAverageOrderValue_AAR);
            groupBoxOrdersStatistic_AAR.Controls.Add(labelMinOrderValue_AAR);
            groupBoxOrdersStatistic_AAR.Controls.Add(labelMaxOrderValue_AAR);
            groupBoxOrdersStatistic_AAR.Controls.Add(labelMostPopularDateOfOrder_AAR);
            groupBoxOrdersStatistic_AAR.Controls.Add(labelMostPopularUserID_AAR);
            groupBoxOrdersStatistic_AAR.Dock = DockStyle.Top;
            groupBoxOrdersStatistic_AAR.Location = new Point(10, 10);
            groupBoxOrdersStatistic_AAR.Name = "groupBoxOrdersStatistic_AAR";
            groupBoxOrdersStatistic_AAR.Size = new Size(354, 228);
            groupBoxOrdersStatistic_AAR.TabIndex = 0;
            groupBoxOrdersStatistic_AAR.TabStop = false;
            groupBoxOrdersStatistic_AAR.Text = "Заказы";
            // 
            // labelOrdersCount_AAR
            // 
            labelOrdersCount_AAR.AutoSize = true;
            labelOrdersCount_AAR.Location = new Point(6, 193);
            labelOrdersCount_AAR.Name = "labelOrdersCount_AAR";
            labelOrdersCount_AAR.Size = new Size(86, 15);
            labelOrdersCount_AAR.TabIndex = 0;
            labelOrdersCount_AAR.Text = "Заказов всего:";
            // 
            // labelMostPopularCity_AAR
            // 
            labelMostPopularCity_AAR.AutoSize = true;
            labelMostPopularCity_AAR.Location = new Point(6, 43);
            labelMostPopularCity_AAR.Name = "labelMostPopularCity_AAR";
            labelMostPopularCity_AAR.Size = new Size(157, 15);
            labelMostPopularCity_AAR.TabIndex = 0;
            labelMostPopularCity_AAR.Text = "Самый популярный город:";
            // 
            // labelAverageOrderValue_AAR
            // 
            labelAverageOrderValue_AAR.AutoSize = true;
            labelAverageOrderValue_AAR.Location = new Point(6, 121);
            labelAverageOrderValue_AAR.Name = "labelAverageOrderValue_AAR";
            labelAverageOrderValue_AAR.Size = new Size(154, 15);
            labelAverageOrderValue_AAR.TabIndex = 0;
            labelAverageOrderValue_AAR.Text = "Средняя стоимость заказа:";
            // 
            // labelMinOrderValue_AAR
            // 
            labelMinOrderValue_AAR.AutoSize = true;
            labelMinOrderValue_AAR.Location = new Point(6, 140);
            labelMinOrderValue_AAR.Name = "labelMinOrderValue_AAR";
            labelMinOrderValue_AAR.Size = new Size(187, 15);
            labelMinOrderValue_AAR.TabIndex = 0;
            labelMinOrderValue_AAR.Text = "Минимальная стоимость заказа:";
            // 
            // labelMaxOrderValue_AAR
            // 
            labelMaxOrderValue_AAR.AutoSize = true;
            labelMaxOrderValue_AAR.Location = new Point(6, 103);
            labelMaxOrderValue_AAR.Name = "labelMaxOrderValue_AAR";
            labelMaxOrderValue_AAR.Size = new Size(191, 15);
            labelMaxOrderValue_AAR.TabIndex = 0;
            labelMaxOrderValue_AAR.Text = "Максимальная стоимость заказа:";
            // 
            // labelMostPopularDateOfOrder_AAR
            // 
            labelMostPopularDateOfOrder_AAR.AutoSize = true;
            labelMostPopularDateOfOrder_AAR.Location = new Point(6, 59);
            labelMostPopularDateOfOrder_AAR.Name = "labelMostPopularDateOfOrder_AAR";
            labelMostPopularDateOfOrder_AAR.Size = new Size(184, 15);
            labelMostPopularDateOfOrder_AAR.TabIndex = 0;
            labelMostPopularDateOfOrder_AAR.Text = "Самая популярная дата заказов:";
            // 
            // labelMostPopularUserID_AAR
            // 
            labelMostPopularUserID_AAR.AutoSize = true;
            labelMostPopularUserID_AAR.Location = new Point(6, 28);
            labelMostPopularUserID_AAR.Name = "labelMostPopularUserID_AAR";
            labelMostPopularUserID_AAR.Size = new Size(213, 15);
            labelMostPopularUserID_AAR.TabIndex = 0;
            labelMostPopularUserID_AAR.Text = "Частовстречающийся пользователь: ";
            // 
            // groupBoxProduct_AAR
            // 
            groupBoxProduct_AAR.Controls.Add(labelAverageProductPrice_AAR);
            groupBoxProduct_AAR.Controls.Add(labelMinProductPrice_AAR);
            groupBoxProduct_AAR.Controls.Add(labelMaxProductPrice_AAR);
            groupBoxProduct_AAR.Controls.Add(labelMaxProductCount_AAR);
            groupBoxProduct_AAR.Controls.Add(labelMostPopularProduct_AAR);
            groupBoxProduct_AAR.Dock = DockStyle.Top;
            groupBoxProduct_AAR.Location = new Point(10, 238);
            groupBoxProduct_AAR.Name = "groupBoxProduct_AAR";
            groupBoxProduct_AAR.Size = new Size(354, 169);
            groupBoxProduct_AAR.TabIndex = 0;
            groupBoxProduct_AAR.TabStop = false;
            groupBoxProduct_AAR.Text = "Товары";
            // 
            // labelAverageProductPrice_AAR
            // 
            labelAverageProductPrice_AAR.AutoSize = true;
            labelAverageProductPrice_AAR.Location = new Point(6, 101);
            labelAverageProductPrice_AAR.Name = "labelAverageProductPrice_AAR";
            labelAverageProductPrice_AAR.Size = new Size(157, 15);
            labelAverageProductPrice_AAR.TabIndex = 0;
            labelAverageProductPrice_AAR.Text = "Средняя стоимость товара:";
            // 
            // labelMinProductPrice_AAR
            // 
            labelMinProductPrice_AAR.AutoSize = true;
            labelMinProductPrice_AAR.Location = new Point(6, 119);
            labelMinProductPrice_AAR.Name = "labelMinProductPrice_AAR";
            labelMinProductPrice_AAR.Size = new Size(190, 15);
            labelMinProductPrice_AAR.TabIndex = 0;
            labelMinProductPrice_AAR.Text = "Минимальная стоимость товара:";
            // 
            // labelMaxProductPrice_AAR
            // 
            labelMaxProductPrice_AAR.AutoSize = true;
            labelMaxProductPrice_AAR.Location = new Point(6, 83);
            labelMaxProductPrice_AAR.Name = "labelMaxProductPrice_AAR";
            labelMaxProductPrice_AAR.Size = new Size(194, 15);
            labelMaxProductPrice_AAR.TabIndex = 0;
            labelMaxProductPrice_AAR.Text = "Максимальная стоимость товара:";
            // 
            // labelMaxProductCount_AAR
            // 
            labelMaxProductCount_AAR.AutoSize = true;
            labelMaxProductCount_AAR.Location = new Point(6, 55);
            labelMaxProductCount_AAR.Name = "labelMaxProductCount_AAR";
            labelMaxProductCount_AAR.Size = new Size(201, 15);
            labelMaxProductCount_AAR.TabIndex = 0;
            labelMaxProductCount_AAR.Text = "Максимальное количество товара:";
            // 
            // labelMostPopularProduct_AAR
            // 
            labelMostPopularProduct_AAR.AutoSize = true;
            labelMostPopularProduct_AAR.Location = new Point(6, 28);
            labelMostPopularProduct_AAR.Name = "labelMostPopularProduct_AAR";
            labelMostPopularProduct_AAR.Size = new Size(156, 15);
            labelMostPopularProduct_AAR.TabIndex = 0;
            labelMostPopularProduct_AAR.Text = "Самый популярный товар:";
            // 
            // chartProductDiag_AAR
            // 
            chartArea1.Name = "ChartArea1";
            chartProductDiag_AAR.ChartAreas.Add(chartArea1);
            chartProductDiag_AAR.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartProductDiag_AAR.Legends.Add(legend1);
            chartProductDiag_AAR.Location = new Point(374, 0);
            chartProductDiag_AAR.Name = "chartProductDiag_AAR";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartProductDiag_AAR.Series.Add(series1);
            chartProductDiag_AAR.Size = new Size(520, 422);
            chartProductDiag_AAR.TabIndex = 1;
            chartProductDiag_AAR.Text = "chart1";
            title1.Name = "Title_AAR";
            title1.Text = "ОБЪЕМ ТОВАРОВ";
            chartProductDiag_AAR.Titles.Add(title1);
            // 
            // panelLeft_AAR
            // 
            panelLeft_AAR.Controls.Add(groupBoxProduct_AAR);
            panelLeft_AAR.Controls.Add(groupBoxOrdersStatistic_AAR);
            panelLeft_AAR.Dock = DockStyle.Left;
            panelLeft_AAR.Location = new Point(0, 0);
            panelLeft_AAR.Name = "panelLeft_AAR";
            panelLeft_AAR.Padding = new Padding(10);
            panelLeft_AAR.Size = new Size(374, 422);
            panelLeft_AAR.TabIndex = 2;
            // 
            // FormStatistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 422);
            Controls.Add(chartProductDiag_AAR);
            Controls.Add(panelLeft_AAR);
            MaximizeBox = false;
            MinimumSize = new Size(910, 461);
            Name = "FormStatistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += FormStatistics_Load;
            groupBoxOrdersStatistic_AAR.ResumeLayout(false);
            groupBoxOrdersStatistic_AAR.PerformLayout();
            groupBoxProduct_AAR.ResumeLayout(false);
            groupBoxProduct_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductDiag_AAR).EndInit();
            panelLeft_AAR.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOrdersStatistic_AAR;
        private Label labelMostPopularDateOfOrder_AAR;
        private Label labelMostPopularUserID_AAR;
        private Label labelMaxOrderValue_AAR;
        private Label labelMinOrderValue_AAR;
        private Label labelAverageOrderValue_AAR;
        private Label labelOrdersCount_AAR;
        private Label labelMostPopularCity_AAR;
        private GroupBox groupBoxProduct_AAR;
        private Label labelAverageProductPrice_AAR;
        private Label labelMinProductPrice_AAR;
        private Label labelMaxProductPrice_AAR;
        private Label labelMaxProductCount_AAR;
        private Label labelMostPopularProduct_AAR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductDiag_AAR;
        private Panel panelLeft_AAR;
    }
}