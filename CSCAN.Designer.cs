namespace ProyectoFinal
{
    partial class FormCSCAN
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
            labelMov = new Label();
            buttonRegresar = new Button();
            labelTitulo = new Label();
            labelPosIn = new Label();
            listBoxCola = new ListBox();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            labelPosActual = new Label();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelMov
            // 
            labelMov.AutoSize = true;
            labelMov.Location = new Point(23, 89);
            labelMov.Name = "labelMov";
            labelMov.Size = new Size(100, 15);
            labelMov.TabIndex = 5;
            labelMov.Text = "Movimiento Total";
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(645, 366);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(75, 23);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(23, 22);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(163, 15);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Resultados Algoritmo CSCAN";
            // 
            // labelPosIn
            // 
            labelPosIn.AutoSize = true;
            labelPosIn.Location = new Point(23, 185);
            labelPosIn.Margin = new Padding(2, 0, 2, 0);
            labelPosIn.Name = "labelPosIn";
            labelPosIn.Size = new Size(89, 15);
            labelPosIn.TabIndex = 6;
            labelPosIn.Text = "Posicion Inicial:";
            // 
            // listBoxCola
            // 
            listBoxCola.FormattingEnabled = true;
            listBoxCola.ItemHeight = 15;
            listBoxCola.Location = new Point(23, 215);
            listBoxCola.Margin = new Padding(2, 1, 2, 1);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(111, 169);
            listBoxCola.TabIndex = 8;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(250, 22);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(349, 228);
            formsPlot1.TabIndex = 9;
            // 
            // labelPosActual
            // 
            labelPosActual.AutoSize = true;
            labelPosActual.Location = new Point(636, 13);
            labelPosActual.Name = "labelPosActual";
            labelPosActual.Size = new Size(38, 15);
            labelPosActual.TabIndex = 15;
            labelPosActual.Text = "label1";
            // 
            // panel2
            // 
            panel2.Location = new Point(645, 35);
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
            // FormCSCAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 515);
            Controls.Add(labelPosActual);
            Controls.Add(panel2);
            Controls.Add(formsPlot1);
            Controls.Add(listBoxCola);
            Controls.Add(labelPosIn);
            Controls.Add(labelMov);
            Controls.Add(buttonRegresar);
            Controls.Add(labelTitulo);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormCSCAN";
            Text = "Form3";
            Load += FormCSCAN_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMov;
        private Button buttonRegresar;
        private Label labelTitulo;
        private Label labelPosIn;
        private ListBox listBoxCola;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Label labelPosActual;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}