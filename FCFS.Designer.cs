namespace ProyectoFinal
{
    partial class FCFS
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
            components = new System.ComponentModel.Container();
            labelResultados = new Label();
            labelMov = new Label();
            labelPos = new Label();
            listBoxCola = new ListBox();
            buttonRegresar = new Button();
            panel1 = new Panel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            skglControl1 = new SkiaSharp.Views.Desktop.SKGLControl();
            skglControl2 = new SkiaSharp.Views.Desktop.SKGLControl();
            labelPosActual = new Label();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelResultados
            // 
            labelResultados.AutoSize = true;
            labelResultados.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultados.Location = new Point(35, 35);
            labelResultados.Margin = new Padding(6, 0, 6, 0);
            labelResultados.Name = "labelResultados";
            labelResultados.Size = new Size(394, 65);
            labelResultados.TabIndex = 0;
            labelResultados.Text = "Resultados FCFS";
            // 
            // labelMov
            // 
            labelMov.AutoSize = true;
            labelMov.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMov.Location = new Point(403, 185);
            labelMov.Margin = new Padding(6, 0, 6, 0);
            labelMov.Name = "labelMov";
            labelMov.Size = new Size(218, 32);
            labelMov.TabIndex = 1;
            labelMov.Text = "Movimiento Total: ";
            // 
            // labelPos
            // 
            labelPos.AutoSize = true;
            labelPos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPos.Location = new Point(61, 185);
            labelPos.Margin = new Padding(6, 0, 6, 0);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(185, 32);
            labelPos.TabIndex = 2;
            labelPos.Text = "Posicion Inicial: ";
            // 
            // listBoxCola
            // 
            listBoxCola.BackColor = Color.White;
            listBoxCola.FormattingEnabled = true;
            listBoxCola.Location = new Point(61, 223);
            listBoxCola.Margin = new Padding(6);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(297, 580);
            listBoxCola.TabIndex = 3;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.FromArgb(255, 255, 192);
            buttonRegresar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(1520, 815);
            buttonRegresar.Margin = new Padding(6);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(139, 49);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Location = new Point(396, 223);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 580);
            panel1.TabIndex = 12;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.LightBlue;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Margin = new Padding(6);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(580, 580);
            formsPlot1.TabIndex = 0;
            // 
            // skglControl1
            // 
            skglControl1.BackColor = Color.Black;
            skglControl1.Location = new Point(0, 0);
            skglControl1.Margin = new Padding(6, 7, 6, 7);
            skglControl1.Name = "skglControl1";
            skglControl1.Size = new Size(325, 369);
            skglControl1.TabIndex = 0;
            skglControl1.VSync = true;
            // 
            // skglControl2
            // 
            skglControl2.BackColor = Color.Black;
            skglControl2.Location = new Point(0, 0);
            skglControl2.Margin = new Padding(6, 7, 6, 7);
            skglControl2.Name = "skglControl2";
            skglControl2.Size = new Size(325, 369);
            skglControl2.TabIndex = 0;
            skglControl2.VSync = true;
            // 
            // labelPosActual
            // 
            labelPosActual.AutoSize = true;
            labelPosActual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPosActual.Location = new Point(1015, 185);
            labelPosActual.Margin = new Padding(6, 0, 6, 0);
            labelPosActual.Name = "labelPosActual";
            labelPosActual.Size = new Size(191, 32);
            labelPosActual.TabIndex = 15;
            labelPosActual.Text = "Posicion Actual: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Location = new Point(1015, 223);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 580);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FCFS
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1674, 879);
            Controls.Add(labelPosActual);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonRegresar);
            Controls.Add(listBoxCola);
            Controls.Add(labelPos);
            Controls.Add(labelMov);
            Controls.Add(labelResultados);
            Margin = new Padding(6);
            Name = "FCFS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCFS";
            Load += FCFS_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultados;
        private Label labelMov;
        private Label labelPos;
        private ListBox listBoxCola;
        private Button buttonRegresar;
        private Panel panel1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private SkiaSharp.Views.Desktop.SKGLControl skglControl1;
        private SkiaSharp.Views.Desktop.SKGLControl skglControl2;
        private Label labelPosActual;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}