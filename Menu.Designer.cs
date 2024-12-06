namespace ProyectoFinal
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitulo = new Label();
            textBoxPosicion = new TextBox();
            textBoxSolicitudes = new TextBox();
            buttonEjecutar = new Button();
            groupBoxAlgoritmo = new GroupBox();
            radioButtonCSCAN = new RadioButton();
            radioButtonSCAN = new RadioButton();
            radioButtonFCFS = new RadioButton();
            buttonSalir = new Button();
            groupBoxAlgoritmo.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Leelawadee UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(304, 97);
            labelTitulo.Margin = new Padding(6, 0, 6, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(829, 156);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "PLANIFICACIÓN DE ACCESO \r\nAL DISCO DURO ";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            labelTitulo.Click += label1_Click;
            // 
            // textBoxPosicion
            // 
            textBoxPosicion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPosicion.Location = new Point(328, 409);
            textBoxPosicion.Margin = new Padding(6);
            textBoxPosicion.Name = "textBoxPosicion";
            textBoxPosicion.PlaceholderText = "Ingresa la posición del cabezal";
            textBoxPosicion.Size = new Size(356, 39);
            textBoxPosicion.TabIndex = 1;
            textBoxPosicion.TextAlign = HorizontalAlignment.Center;
            textBoxPosicion.TextChanged += textBoxPosicion_TextChanged;
            // 
            // textBoxSolicitudes
            // 
            textBoxSolicitudes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSolicitudes.Location = new Point(328, 495);
            textBoxSolicitudes.Margin = new Padding(6);
            textBoxSolicitudes.Name = "textBoxSolicitudes";
            textBoxSolicitudes.PlaceholderText = "¿Cuantas solicitudes quieres?";
            textBoxSolicitudes.Size = new Size(356, 39);
            textBoxSolicitudes.TabIndex = 3;
            textBoxSolicitudes.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonEjecutar
            // 
            buttonEjecutar.BackColor = Color.FromArgb(192, 255, 192);
            buttonEjecutar.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEjecutar.Location = new Point(1177, 752);
            buttonEjecutar.Margin = new Padding(6);
            buttonEjecutar.Name = "buttonEjecutar";
            buttonEjecutar.Size = new Size(245, 109);
            buttonEjecutar.TabIndex = 4;
            buttonEjecutar.Text = "Ejecutar";
            buttonEjecutar.UseVisualStyleBackColor = false;
            buttonEjecutar.Click += buttonEjecutar_Click;
            // 
            // groupBoxAlgoritmo
            // 
            groupBoxAlgoritmo.BackColor = Color.WhiteSmoke;
            groupBoxAlgoritmo.Controls.Add(radioButtonCSCAN);
            groupBoxAlgoritmo.Controls.Add(radioButtonSCAN);
            groupBoxAlgoritmo.Controls.Add(radioButtonFCFS);
            groupBoxAlgoritmo.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxAlgoritmo.Location = new Point(773, 394);
            groupBoxAlgoritmo.Margin = new Padding(6);
            groupBoxAlgoritmo.Name = "groupBoxAlgoritmo";
            groupBoxAlgoritmo.Padding = new Padding(6);
            groupBoxAlgoritmo.Size = new Size(321, 203);
            groupBoxAlgoritmo.TabIndex = 5;
            groupBoxAlgoritmo.TabStop = false;
            groupBoxAlgoritmo.Text = "Algoritmo a usar:";
            // 
            // radioButtonCSCAN
            // 
            radioButtonCSCAN.AutoSize = true;
            radioButtonCSCAN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonCSCAN.Location = new Point(12, 155);
            radioButtonCSCAN.Margin = new Padding(6);
            radioButtonCSCAN.Name = "radioButtonCSCAN";
            radioButtonCSCAN.Size = new Size(132, 36);
            radioButtonCSCAN.TabIndex = 3;
            radioButtonCSCAN.TabStop = true;
            radioButtonCSCAN.Text = "C-SCAN";
            radioButtonCSCAN.UseVisualStyleBackColor = true;
            // 
            // radioButtonSCAN
            // 
            radioButtonSCAN.AutoSize = true;
            radioButtonSCAN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonSCAN.Location = new Point(12, 107);
            radioButtonSCAN.Margin = new Padding(6);
            radioButtonSCAN.Name = "radioButtonSCAN";
            radioButtonSCAN.Size = new Size(107, 36);
            radioButtonSCAN.TabIndex = 2;
            radioButtonSCAN.TabStop = true;
            radioButtonSCAN.Text = "SCAN";
            radioButtonSCAN.UseVisualStyleBackColor = true;
            // 
            // radioButtonFCFS
            // 
            radioButtonFCFS.AutoSize = true;
            radioButtonFCFS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonFCFS.Location = new Point(12, 59);
            radioButtonFCFS.Margin = new Padding(6);
            radioButtonFCFS.Name = "radioButtonFCFS";
            radioButtonFCFS.Size = new Size(97, 36);
            radioButtonFCFS.TabIndex = 1;
            radioButtonFCFS.TabStop = true;
            radioButtonFCFS.Text = "FCFS";
            radioButtonFCFS.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.FromArgb(255, 192, 192);
            buttonSalir.Font = new Font("Franklin Gothic Demi", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(15, 799);
            buttonSalir.Margin = new Padding(6);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(168, 62);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1437, 876);
            Controls.Add(buttonSalir);
            Controls.Add(groupBoxAlgoritmo);
            Controls.Add(buttonEjecutar);
            Controls.Add(textBoxSolicitudes);
            Controls.Add(textBoxPosicion);
            Controls.Add(labelTitulo);
            Margin = new Padding(6);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            groupBoxAlgoritmo.ResumeLayout(false);
            groupBoxAlgoritmo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textBoxPosicion;
        private TextBox textBoxSolicitudes;
        private Button buttonEjecutar;
        private GroupBox groupBoxAlgoritmo;
        private RadioButton radioButtonCSCAN;
        private RadioButton radioButtonSCAN;
        private RadioButton radioButtonFCFS;
        private Button buttonSalir;
    }
}
