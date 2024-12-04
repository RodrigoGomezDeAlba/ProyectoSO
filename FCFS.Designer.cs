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
            labelResultados.Location = new Point(19, 16);
            labelResultados.Name = "labelResultados";
            labelResultados.Size = new Size(198, 32);
            labelResultados.TabIndex = 0;
            labelResultados.Text = "Resultados FCFS";
            // 
            // labelMov
            // 
            labelMov.AutoSize = true;
            labelMov.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMov.Location = new Point(217, 87);
            labelMov.Name = "labelMov";
            labelMov.Size = new Size(107, 15);
            labelMov.TabIndex = 1;
            labelMov.Text = "Movimiento Total: ";
            // 
            // labelPos
            // 
            labelPos.AutoSize = true;
            labelPos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPos.Location = new Point(33, 87);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(93, 15);
            labelPos.TabIndex = 2;
            labelPos.Text = "Posicion Inicial: ";
            // 
            // listBoxCola
            // 
            listBoxCola.BackColor = Color.White;
            listBoxCola.FormattingEnabled = true;
            listBoxCola.ItemHeight = 15;
            listBoxCola.Location = new Point(33, 105);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(162, 274);
            listBoxCola.TabIndex = 3;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.FromArgb(255, 255, 192);
            buttonRegresar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(818, 382);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(75, 23);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Location = new Point(213, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 272);
            panel1.TabIndex = 12;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.LightBlue;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(312, 272);
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
            labelPosActual.Location = new Point(547, 87);
            labelPosActual.Name = "labelPosActual";
            labelPosActual.Size = new Size(95, 15);
            labelPosActual.TabIndex = 15;
            labelPosActual.Text = "Posicion Actual: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Location = new Point(547, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 250);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(901, 412);
            Controls.Add(labelPosActual);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonRegresar);
            Controls.Add(listBoxCola);
            Controls.Add(labelPos);
            Controls.Add(labelMov);
            Controls.Add(labelResultados);
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