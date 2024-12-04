namespace ProyectoFinal
{
    partial class Principal
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
            groupBoxDireccion = new GroupBox();
            radioButtonIzquierda = new RadioButton();
            radioButtonDerecha = new RadioButton();
            textBoxSolicitudes = new TextBox();
            buttonEjecutar = new Button();
            groupBoxAlgoritmo = new GroupBox();
            radioButtonCSCAN = new RadioButton();
            radioButtonSCAN = new RadioButton();
            radioButtonFCFS = new RadioButton();
            buttonSalir = new Button();
            groupBoxDireccion.SuspendLayout();
            groupBoxAlgoritmo.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(351, 19);
            labelTitulo.Margin = new Padding(6, 0, 6, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(915, 56);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Planificación de acceso a disco duro";
            labelTitulo.Click += label1_Click;
            // 
            // textBoxPosicion
            // 
            textBoxPosicion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPosicion.Location = new Point(22, 117);
            textBoxPosicion.Margin = new Padding(6, 6, 6, 6);
            textBoxPosicion.Name = "textBoxPosicion";
            textBoxPosicion.PlaceholderText = "Ingresa la posición del cabezal";
            textBoxPosicion.Size = new Size(318, 39);
            textBoxPosicion.TabIndex = 1;
            textBoxPosicion.TextAlign = HorizontalAlignment.Center;
            textBoxPosicion.TextChanged += textBoxPosicion_TextChanged;
            // 
            // groupBoxDireccion
            // 
            groupBoxDireccion.Controls.Add(radioButtonIzquierda);
            groupBoxDireccion.Controls.Add(radioButtonDerecha);
            groupBoxDireccion.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDireccion.Location = new Point(22, 621);
            groupBoxDireccion.Margin = new Padding(6, 6, 6, 6);
            groupBoxDireccion.Name = "groupBoxDireccion";
            groupBoxDireccion.Padding = new Padding(6, 6, 6, 6);
            groupBoxDireccion.Size = new Size(321, 203);
            groupBoxDireccion.TabIndex = 2;
            groupBoxDireccion.TabStop = false;
            groupBoxDireccion.Text = "Dirección del cabezal";
            // 
            // radioButtonIzquierda
            // 
            radioButtonIzquierda.AutoSize = true;
            radioButtonIzquierda.Location = new Point(39, 126);
            radioButtonIzquierda.Margin = new Padding(6, 6, 6, 6);
            radioButtonIzquierda.Name = "radioButtonIzquierda";
            radioButtonIzquierda.Size = new Size(153, 35);
            radioButtonIzquierda.TabIndex = 1;
            radioButtonIzquierda.TabStop = true;
            radioButtonIzquierda.Text = "Izquierda";
            radioButtonIzquierda.UseVisualStyleBackColor = true;
            // 
            // radioButtonDerecha
            // 
            radioButtonDerecha.AutoSize = true;
            radioButtonDerecha.Location = new Point(39, 70);
            radioButtonDerecha.Margin = new Padding(6, 6, 6, 6);
            radioButtonDerecha.Name = "radioButtonDerecha";
            radioButtonDerecha.Size = new Size(141, 35);
            radioButtonDerecha.TabIndex = 0;
            radioButtonDerecha.TabStop = true;
            radioButtonDerecha.Text = "Derecha";
            radioButtonDerecha.UseVisualStyleBackColor = true;
            radioButtonDerecha.CheckedChanged += radioButtonDerecha_CheckedChanged;
            // 
            // textBoxSolicitudes
            // 
            textBoxSolicitudes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSolicitudes.Location = new Point(22, 203);
            textBoxSolicitudes.Margin = new Padding(6, 6, 6, 6);
            textBoxSolicitudes.Name = "textBoxSolicitudes";
            textBoxSolicitudes.PlaceholderText = "Cuantas solicitudes quieres?";
            textBoxSolicitudes.Size = new Size(318, 39);
            textBoxSolicitudes.TabIndex = 3;
            textBoxSolicitudes.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonEjecutar
            // 
            buttonEjecutar.Location = new Point(1376, 966);
            buttonEjecutar.Margin = new Padding(6, 6, 6, 6);
            buttonEjecutar.Name = "buttonEjecutar";
            buttonEjecutar.Size = new Size(199, 79);
            buttonEjecutar.TabIndex = 4;
            buttonEjecutar.Text = "Ejecutar";
            buttonEjecutar.UseVisualStyleBackColor = true;
            buttonEjecutar.Click += buttonEjecutar_Click;
            // 
            // groupBoxAlgoritmo
            // 
            groupBoxAlgoritmo.Controls.Add(radioButtonCSCAN);
            groupBoxAlgoritmo.Controls.Add(radioButtonSCAN);
            groupBoxAlgoritmo.Controls.Add(radioButtonFCFS);
            groupBoxAlgoritmo.Location = new Point(22, 294);
            groupBoxAlgoritmo.Margin = new Padding(6, 6, 6, 6);
            groupBoxAlgoritmo.Name = "groupBoxAlgoritmo";
            groupBoxAlgoritmo.Padding = new Padding(6, 6, 6, 6);
            groupBoxAlgoritmo.Size = new Size(321, 294);
            groupBoxAlgoritmo.TabIndex = 5;
            groupBoxAlgoritmo.TabStop = false;
            groupBoxAlgoritmo.Text = "Selecciona un algoritmo";
            // 
            // radioButtonCSCAN
            // 
            radioButtonCSCAN.AutoSize = true;
            radioButtonCSCAN.Location = new Point(39, 222);
            radioButtonCSCAN.Margin = new Padding(6, 6, 6, 6);
            radioButtonCSCAN.Name = "radioButtonCSCAN";
            radioButtonCSCAN.Size = new Size(131, 36);
            radioButtonCSCAN.TabIndex = 3;
            radioButtonCSCAN.TabStop = true;
            radioButtonCSCAN.Text = "C-SCAN";
            radioButtonCSCAN.UseVisualStyleBackColor = true;
            // 
            // radioButtonSCAN
            // 
            radioButtonSCAN.AutoSize = true;
            radioButtonSCAN.Location = new Point(39, 145);
            radioButtonSCAN.Margin = new Padding(6, 6, 6, 6);
            radioButtonSCAN.Name = "radioButtonSCAN";
            radioButtonSCAN.Size = new Size(106, 36);
            radioButtonSCAN.TabIndex = 2;
            radioButtonSCAN.TabStop = true;
            radioButtonSCAN.Text = "SCAN";
            radioButtonSCAN.UseVisualStyleBackColor = true;
            // 
            // radioButtonFCFS
            // 
            radioButtonFCFS.AutoSize = true;
            radioButtonFCFS.Location = new Point(39, 70);
            radioButtonFCFS.Margin = new Padding(6, 6, 6, 6);
            radioButtonFCFS.Name = "radioButtonFCFS";
            radioButtonFCFS.Size = new Size(97, 36);
            radioButtonFCFS.TabIndex = 1;
            radioButtonFCFS.TabStop = true;
            radioButtonFCFS.Text = "FCFS";
            radioButtonFCFS.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(1005, 943);
            buttonSalir.Margin = new Padding(6, 6, 6, 6);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(139, 49);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1597, 1071);
            Controls.Add(buttonSalir);
            Controls.Add(groupBoxAlgoritmo);
            Controls.Add(buttonEjecutar);
            Controls.Add(textBoxSolicitudes);
            Controls.Add(groupBoxDireccion);
            Controls.Add(textBoxPosicion);
            Controls.Add(labelTitulo);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxDireccion.ResumeLayout(false);
            groupBoxDireccion.PerformLayout();
            groupBoxAlgoritmo.ResumeLayout(false);
            groupBoxAlgoritmo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textBoxPosicion;
        private GroupBox groupBoxDireccion;
        private RadioButton radioButtonDerecha;
        private RadioButton radioButtonIzquierda;
        private TextBox textBoxSolicitudes;
        private Button buttonEjecutar;
        private GroupBox groupBoxAlgoritmo;
        private RadioButton radioButtonCSCAN;
        private RadioButton radioButtonSCAN;
        private RadioButton radioButtonFCFS;
        private Button buttonSalir;
    }
}
