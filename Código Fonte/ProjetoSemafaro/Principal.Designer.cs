namespace ProjetoSemafaro
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picSemaforoY = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picSemaforoX = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.tmCarros = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempoX = new System.Windows.Forms.TextBox();
            this.txtTempoY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chtRuaX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrGrafico = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoY)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtRuaX)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 115);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.picSemaforoY);
            this.panel3.Location = new System.Drawing.Point(9, 165);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 111);
            this.panel3.TabIndex = 5;
            // 
            // picSemaforoY
            // 
            this.picSemaforoY.Image = global::ProjetoSemafaro.Properties.Resources.semaforo_vermelho;
            this.picSemaforoY.Location = new System.Drawing.Point(111, 37);
            this.picSemaforoY.Name = "picSemaforoY";
            this.picSemaforoY.Size = new System.Drawing.Size(19, 50);
            this.picSemaforoY.TabIndex = 9;
            this.picSemaforoY.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(190, 165);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 111);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.picSemaforoX);
            this.panel2.Location = new System.Drawing.Point(190, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 115);
            this.panel2.TabIndex = 7;
            // 
            // picSemaforoX
            // 
            this.picSemaforoX.Image = global::ProjetoSemafaro.Properties.Resources.semaforo_vermelho;
            this.picSemaforoX.Location = new System.Drawing.Point(62, 62);
            this.picSemaforoX.Name = "picSemaforoX";
            this.picSemaforoX.Size = new System.Drawing.Size(19, 50);
            this.picSemaforoX.TabIndex = 8;
            this.picSemaforoX.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(361, 23);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(31, 13);
            this.label.TabIndex = 8;
            this.label.Text = "nada";
            // 
            // tmCarros
            // 
            this.tmCarros.Enabled = true;
            this.tmCarros.Interval = 200;
            this.tmCarros.Tick += new System.EventHandler(this.tmCarros_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rua X";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Av Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tempo Semaforo X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tempo Semaforo Y";
            // 
            // txtTempoX
            // 
            this.txtTempoX.Location = new System.Drawing.Point(465, 69);
            this.txtTempoX.MaxLength = 2;
            this.txtTempoX.Name = "txtTempoX";
            this.txtTempoX.Size = new System.Drawing.Size(37, 20);
            this.txtTempoX.TabIndex = 14;
            this.txtTempoX.Text = "8";
            this.txtTempoX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempoX_KeyPress);
            // 
            // txtTempoY
            // 
            this.txtTempoY.Location = new System.Drawing.Point(465, 96);
            this.txtTempoY.MaxLength = 2;
            this.txtTempoY.Name = "txtTempoY";
            this.txtTempoY.Size = new System.Drawing.Size(37, 20);
            this.txtTempoY.TabIndex = 15;
            this.txtTempoY.Text = "5";
            this.txtTempoY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempoY_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "segundos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "segundos";
            // 
            // chtRuaX
            // 
            this.chtRuaX.BorderSkin.BorderWidth = 0;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chtRuaX.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtRuaX.Legends.Add(legend1);
            this.chtRuaX.Location = new System.Drawing.Point(12, 306);
            this.chtRuaX.Name = "chtRuaX";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 0;
            series1.Name = "X";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Y";
            this.chtRuaX.Series.Add(series1);
            this.chtRuaX.Series.Add(series2);
            this.chtRuaX.Size = new System.Drawing.Size(668, 241);
            this.chtRuaX.TabIndex = 19;
            // 
            // tmrGrafico
            // 
            this.tmrGrafico.Enabled = true;
            this.tmrGrafico.Interval = 1000;
            this.tmrGrafico.Tick += new System.EventHandler(this.tmrGrafico_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Quantidade de Carros por Segundo em X e Y";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 559);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chtRuaX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTempoY);
            this.Controls.Add(this.txtTempoX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semaforo Simulator";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoY)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtRuaX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer tmCarros;
        private System.Windows.Forms.PictureBox picSemaforoX;
        private System.Windows.Forms.PictureBox picSemaforoY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempoX;
        private System.Windows.Forms.TextBox txtTempoY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRuaX;
        private System.Windows.Forms.Timer tmrGrafico;
        private System.Windows.Forms.Label label8;
    }
}

