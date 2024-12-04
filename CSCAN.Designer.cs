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
            labelMov.Location = new Point(217, 87);
            labelMov.Name = "labelMov";
            labelMov.Size = new Size(107, 15);
            labelMov.TabIndex = 5;
            labelMov.Text = "Movimiento Total: ";
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
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Leelawadee UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(19, 16);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(225, 32);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Resultados CSCAN";
            // 
            // labelPosIn
            // 
            labelPosIn.AutoSize = true;
            labelPosIn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPosIn.Location = new Point(33, 87);
            labelPosIn.Margin = new Padding(2, 0, 2, 0);
            labelPosIn.Name = "labelPosIn";
            labelPosIn.Size = new Size(93, 15);
            labelPosIn.TabIndex = 6;
            labelPosIn.Text = "Posicion Inicial: ";
            // 
            // listBoxCola
            // 
            listBoxCola.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxCola.FormattingEnabled = true;
            listBoxCola.ItemHeight = 15;
            listBoxCola.Location = new Point(33, 105);
            listBoxCola.Margin = new Padding(2, 1, 2, 1);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(162, 274);
            listBoxCola.TabIndex = 8;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.LightBlue;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formsPlot1.Location = new Point(213, 105);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(312, 272);
            formsPlot1.TabIndex = 9;
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
            // FormCSCAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(901, 412);
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