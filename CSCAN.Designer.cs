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
            labelMov.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMov.Location = new Point(403, 186);
            labelMov.Margin = new Padding(6, 0, 6, 0);
            labelMov.Name = "labelMov";
            labelMov.Size = new Size(218, 32);
            labelMov.TabIndex = 5;
            labelMov.Text = "Movimiento Total: ";
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.FromArgb(255, 255, 192);
            buttonRegresar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresar.Location = new Point(1519, 815);
            buttonRegresar.Margin = new Padding(6, 6, 6, 6);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(139, 49);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(35, 34);
            labelTitulo.Margin = new Padding(6, 0, 6, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(446, 65);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Resultados CSCAN";
            // 
            // labelPosIn
            // 
            labelPosIn.AutoSize = true;
            labelPosIn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPosIn.Location = new Point(61, 186);
            labelPosIn.Margin = new Padding(4, 0, 4, 0);
            labelPosIn.Name = "labelPosIn";
            labelPosIn.Size = new Size(185, 32);
            labelPosIn.TabIndex = 6;
            labelPosIn.Text = "Posicion Inicial: ";
            // 
            // listBoxCola
            // 
            listBoxCola.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxCola.FormattingEnabled = true;
            listBoxCola.Location = new Point(61, 224);
            listBoxCola.Margin = new Padding(4, 2, 4, 2);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(297, 580);
            listBoxCola.TabIndex = 8;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.LightBlue;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formsPlot1.Location = new Point(396, 224);
            formsPlot1.Margin = new Padding(6, 6, 6, 6);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(580, 580);
            formsPlot1.TabIndex = 9;
            // 
            // labelPosActual
            // 
            labelPosActual.AutoSize = true;
            labelPosActual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPosActual.Location = new Point(1016, 186);
            labelPosActual.Margin = new Padding(6, 0, 6, 0);
            labelPosActual.Name = "labelPosActual";
            labelPosActual.Size = new Size(191, 32);
            labelPosActual.TabIndex = 15;
            labelPosActual.Text = "Posicion Actual: ";
            // 
            // panel2
            // 
            panel2.Location = new Point(1016, 224);
            panel2.Margin = new Padding(6, 6, 6, 6);
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
            // FormCSCAN
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1673, 879);
            Controls.Add(labelPosActual);
            Controls.Add(panel2);
            Controls.Add(formsPlot1);
            Controls.Add(listBoxCola);
            Controls.Add(labelPosIn);
            Controls.Add(labelMov);
            Controls.Add(buttonRegresar);
            Controls.Add(labelTitulo);
            Margin = new Padding(4, 2, 4, 2);
            Name = "FormCSCAN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C-SCAN";
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