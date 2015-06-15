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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.tmCarros = new System.Windows.Forms.Timer(this.components);
            this.picSemaforoX = new System.Windows.Forms.PictureBox();
            this.picSemaforoY = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoY)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 115);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.picSemaforoY);
            this.panel3.Location = new System.Drawing.Point(9, 165);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 111);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(190, 165);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 111);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.picSemaforoX);
            this.panel2.Location = new System.Drawing.Point(190, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 115);
            this.panel2.TabIndex = 7;
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
            // picSemaforoX
            // 
            this.picSemaforoX.Image = global::ProjetoSemafaro.Properties.Resources.semaforo_vermelho;
            this.picSemaforoX.Location = new System.Drawing.Point(62, 62);
            this.picSemaforoX.Name = "picSemaforoX";
            this.picSemaforoX.Size = new System.Drawing.Size(19, 50);
            this.picSemaforoX.TabIndex = 8;
            this.picSemaforoX.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semaforo Simulator";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSemaforoY)).EndInit();
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
    }
}

