namespace ProyectoFinal
{
    partial class FormSCAN
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
            labelTitulo = new Label();
            buttonRegresar = new Button();
            labelMov = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            listBoxCola = new ListBox();
            labelPosIn = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(36, 21);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(155, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Resultados Algoritmo SCAN";
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(658, 365);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(75, 23);
            buttonRegresar.TabIndex = 1;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // labelMov
            // 
            labelMov.AutoSize = true;
            labelMov.Location = new Point(36, 88);
            labelMov.Name = "labelMov";
            labelMov.Size = new Size(100, 15);
            labelMov.TabIndex = 2;
            labelMov.Text = "Movimiento Total";
            labelMov.Click += labelMov_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // listBoxCola
            // 
            listBoxCola.FormattingEnabled = true;
            listBoxCola.ItemHeight = 15;
            listBoxCola.Location = new Point(36, 266);
            listBoxCola.Margin = new Padding(2, 1, 2, 1);
            listBoxCola.Name = "listBoxCola";
            listBoxCola.Size = new Size(100, 124);
            listBoxCola.TabIndex = 10;
            // 
            // labelPosIn
            // 
            labelPosIn.AutoSize = true;
            labelPosIn.Location = new Point(36, 236);
            labelPosIn.Margin = new Padding(2, 0, 2, 0);
            labelPosIn.Name = "labelPosIn";
            labelPosIn.Size = new Size(89, 15);
            labelPosIn.TabIndex = 9;
            labelPosIn.Text = "Posicion Inicial:";
            // 
            // FormSCAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxCola);
            Controls.Add(labelPosIn);
            Controls.Add(labelMov);
            Controls.Add(buttonRegresar);
            Controls.Add(labelTitulo);
            Name = "FormSCAN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += FormSCAN_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button buttonRegresar;
        private Label labelMov;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private ListBox listBoxCola;
        private Label labelPosIn;
    }
}