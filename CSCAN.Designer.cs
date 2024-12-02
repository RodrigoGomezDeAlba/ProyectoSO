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
            labelMov = new Label();
            buttonRegresar = new Button();
            labelTitulo = new Label();
            labelPosIn = new Label();
            listBoxCola = new ListBox();
            SuspendLayout();
            // 
            // labelMov
            // 
            labelMov.AutoSize = true;
            labelMov.Location = new Point(42, 189);
            labelMov.Margin = new Padding(6, 0, 6, 0);
            labelMov.Name = "labelMov";
            labelMov.Size = new Size(202, 32);
            labelMov.TabIndex = 5;
            labelMov.Text = "Movimiento Total";
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(1197, 780);
            buttonRegresar.Margin = new Padding(6);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(139, 49);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(42, 46);
            labelTitulo.Margin = new Padding(6, 0, 6, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(324, 32);
            labelTitulo.TabIndex = 3;
            labelTitulo.Text = "Resultados Algoritmo CSCAN";
            // 
            // labelPosIn
            // 
            labelPosIn.AutoSize = true;
            labelPosIn.Location = new Point(42, 395);
            labelPosIn.Name = "labelPosIn";
            labelPosIn.Size = new Size(174, 32);
            labelPosIn.TabIndex = 6;
            labelPosIn.Text = "Posicion Inicial:";
            // 
            // listBoxCola
            // 
            listBoxCola.FormattingEnabled = true;
            listBoxCola.Location = new Point(42, 458);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(202, 164);
            listBoxCola.TabIndex = 8;
            // 
            // FormCSCAN
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 866);
            Controls.Add(listBoxCola);
            Controls.Add(labelPosIn);
            Controls.Add(labelMov);
            Controls.Add(buttonRegresar);
            Controls.Add(labelTitulo);
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
    }
}