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
            labelResultados = new Label();
            labelMov = new Label();
            labelPos = new Label();
            listBoxCola = new ListBox();
            buttonRegresar = new Button();
            panel1 = new Panel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            skglControl1 = new SkiaSharp.Views.Desktop.SKGLControl();
            skglControl2 = new SkiaSharp.Views.Desktop.SKGLControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelResultados
            // 
            labelResultados.AutoSize = true;
            labelResultados.Location = new Point(61, 38);
            labelResultados.Margin = new Padding(6, 0, 6, 0);
            labelResultados.Name = "labelResultados";
            labelResultados.Size = new Size(300, 32);
            labelResultados.TabIndex = 0;
            labelResultados.Text = "Resultados Algoritmo FCFS";
            // 
            // labelMov
            // 
            labelMov.AutoSize = true;
            labelMov.Location = new Point(61, 179);
            labelMov.Margin = new Padding(6, 0, 6, 0);
            labelMov.Name = "labelMov";
            labelMov.Size = new Size(202, 32);
            labelMov.TabIndex = 1;
            labelMov.Text = "Movimiento Total";
            // 
            // labelPos
            // 
            labelPos.AutoSize = true;
            labelPos.Location = new Point(61, 395);
            labelPos.Margin = new Padding(6, 0, 6, 0);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(181, 32);
            labelPos.TabIndex = 2;
            labelPos.Text = "Posicion Inicial: ";
            // 
            // listBoxCola
            // 
            listBoxCola.FormattingEnabled = true;
            listBoxCola.Location = new Point(69, 512);
            listBoxCola.Margin = new Padding(6, 6, 6, 6);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(268, 324);
            listBoxCola.TabIndex = 3;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(1283, 853);
            buttonRegresar.Margin = new Padding(6, 6, 6, 6);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(139, 49);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Location = new Point(672, 96);
            panel1.Margin = new Padding(6, 6, 6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 486);
            panel1.TabIndex = 12;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(0, 0);
            formsPlot1.Margin = new Padding(6, 6, 6, 6);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(648, 486);
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
            // FCFS
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(panel1);
            Controls.Add(buttonRegresar);
            Controls.Add(listBoxCola);
            Controls.Add(labelPos);
            Controls.Add(labelMov);
            Controls.Add(labelResultados);
            Margin = new Padding(6, 6, 6, 6);
            Name = "FCFS";
            Text = "Form4";
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
    }
}