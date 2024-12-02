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
            SuspendLayout();
            // 
            // labelResultados
            // 
            labelResultados.AutoSize = true;
            labelResultados.Location = new Point(33, 18);
            labelResultados.Name = "labelResultados";
            labelResultados.Size = new Size(150, 15);
            labelResultados.TabIndex = 0;
            labelResultados.Text = "Resultados Algoritmo FCFS";
            // 
            // labelMov
            // 
            labelMov.AutoSize = true;
            labelMov.Location = new Point(33, 84);
            labelMov.Name = "labelMov";
            labelMov.Size = new Size(100, 15);
            labelMov.TabIndex = 1;
            labelMov.Text = "Movimiento Total";
            // 
            // labelPos
            // 
            labelPos.AutoSize = true;
            labelPos.Location = new Point(33, 185);
            labelPos.Name = "labelPos";
            labelPos.Size = new Size(92, 15);
            labelPos.TabIndex = 2;
            labelPos.Text = "Posicion Inicial: ";
            // 
            // listBoxCola
            // 
            listBoxCola.FormattingEnabled = true;
            listBoxCola.ItemHeight = 15;
            listBoxCola.Location = new Point(37, 240);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(120, 94);
            listBoxCola.TabIndex = 3;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(691, 400);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(75, 23);
            buttonRegresar.TabIndex = 4;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // FCFS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegresar);
            Controls.Add(listBoxCola);
            Controls.Add(labelPos);
            Controls.Add(labelMov);
            Controls.Add(labelResultados);
            Name = "FCFS";
            Text = "Form4";
            Load += FCFS_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultados;
        private Label labelMov;
        private Label labelPos;
        private ListBox listBoxCola;
        private Button buttonRegresar;
    }
}