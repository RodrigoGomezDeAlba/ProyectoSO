namespace ProyectoFinal
{
    partial class Form1
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
            radioButtonAbajo = new RadioButton();
            radioButtonArriba = new RadioButton();
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
            labelTitulo.Location = new Point(189, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(453, 29);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Planificación de acceso a disco duro";
            labelTitulo.Click += label1_Click;
            // 
            // textBoxPosicion
            // 
            textBoxPosicion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPosicion.Location = new Point(12, 55);
            textBoxPosicion.Name = "textBoxPosicion";
            textBoxPosicion.PlaceholderText = "Ingresa la posición del cabezal";
            textBoxPosicion.Size = new Size(173, 23);
            textBoxPosicion.TabIndex = 1;
            textBoxPosicion.TextAlign = HorizontalAlignment.Center;
            textBoxPosicion.TextChanged += textBoxPosicion_TextChanged;
            // 
            // groupBoxDireccion
            // 
            groupBoxDireccion.Controls.Add(radioButtonAbajo);
            groupBoxDireccion.Controls.Add(radioButtonArriba);
            groupBoxDireccion.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxDireccion.Location = new Point(12, 291);
            groupBoxDireccion.Name = "groupBoxDireccion";
            groupBoxDireccion.Size = new Size(173, 95);
            groupBoxDireccion.TabIndex = 2;
            groupBoxDireccion.TabStop = false;
            groupBoxDireccion.Text = "Dirección del cabezal";
            // 
            // radioButtonAbajo
            // 
            radioButtonAbajo.AutoSize = true;
            radioButtonAbajo.Location = new Point(21, 59);
            radioButtonAbajo.Name = "radioButtonAbajo";
            radioButtonAbajo.Size = new Size(58, 20);
            radioButtonAbajo.TabIndex = 1;
            radioButtonAbajo.TabStop = true;
            radioButtonAbajo.Text = "Abajo";
            radioButtonAbajo.UseVisualStyleBackColor = true;
            // 
            // radioButtonArriba
            // 
            radioButtonArriba.AutoSize = true;
            radioButtonArriba.Location = new Point(21, 33);
            radioButtonArriba.Name = "radioButtonArriba";
            radioButtonArriba.Size = new Size(60, 20);
            radioButtonArriba.TabIndex = 0;
            radioButtonArriba.TabStop = true;
            radioButtonArriba.Text = "Arriba";
            radioButtonArriba.UseVisualStyleBackColor = true;
            radioButtonArriba.CheckedChanged += radioButtonArriba_CheckedChanged;
            // 
            // textBoxSolicitudes
            // 
            textBoxSolicitudes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSolicitudes.Location = new Point(12, 95);
            textBoxSolicitudes.Name = "textBoxSolicitudes";
            textBoxSolicitudes.PlaceholderText = "Cuantas solicitudes quieres?";
            textBoxSolicitudes.Size = new Size(173, 23);
            textBoxSolicitudes.TabIndex = 3;
            textBoxSolicitudes.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonEjecutar
            // 
            buttonEjecutar.Location = new Point(741, 453);
            buttonEjecutar.Name = "buttonEjecutar";
            buttonEjecutar.Size = new Size(107, 37);
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
            groupBoxAlgoritmo.Location = new Point(12, 138);
            groupBoxAlgoritmo.Name = "groupBoxAlgoritmo";
            groupBoxAlgoritmo.Size = new Size(173, 138);
            groupBoxAlgoritmo.TabIndex = 5;
            groupBoxAlgoritmo.TabStop = false;
            groupBoxAlgoritmo.Text = "Selecciona un algoritmo";
            // 
            // radioButtonCSCAN
            // 
            radioButtonCSCAN.AutoSize = true;
            radioButtonCSCAN.Location = new Point(21, 104);
            radioButtonCSCAN.Name = "radioButtonCSCAN";
            radioButtonCSCAN.Size = new Size(69, 19);
            radioButtonCSCAN.TabIndex = 3;
            radioButtonCSCAN.TabStop = true;
            radioButtonCSCAN.Text = "C-SCAN";
            radioButtonCSCAN.UseVisualStyleBackColor = true;
            // 
            // radioButtonSCAN
            // 
            radioButtonSCAN.AutoSize = true;
            radioButtonSCAN.Location = new Point(21, 68);
            radioButtonSCAN.Name = "radioButtonSCAN";
            radioButtonSCAN.Size = new Size(56, 19);
            radioButtonSCAN.TabIndex = 2;
            radioButtonSCAN.TabStop = true;
            radioButtonSCAN.Text = "SCAN";
            radioButtonSCAN.UseVisualStyleBackColor = true;
            // 
            // radioButtonFCFS
            // 
            radioButtonFCFS.AutoSize = true;
            radioButtonFCFS.Location = new Point(21, 33);
            radioButtonFCFS.Name = "radioButtonFCFS";
            radioButtonFCFS.Size = new Size(51, 19);
            radioButtonFCFS.TabIndex = 1;
            radioButtonFCFS.TabStop = true;
            radioButtonFCFS.Text = "FCFS";
            radioButtonFCFS.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(541, 442);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(75, 23);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 502);
            Controls.Add(buttonSalir);
            Controls.Add(groupBoxAlgoritmo);
            Controls.Add(buttonEjecutar);
            Controls.Add(textBoxSolicitudes);
            Controls.Add(groupBoxDireccion);
            Controls.Add(textBoxPosicion);
            Controls.Add(labelTitulo);
            Name = "Form1";
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
        private RadioButton radioButtonArriba;
        private RadioButton radioButtonAbajo;
        private TextBox textBoxSolicitudes;
        private Button buttonEjecutar;
        private GroupBox groupBoxAlgoritmo;
        private RadioButton radioButtonCSCAN;
        private RadioButton radioButtonSCAN;
        private RadioButton radioButtonFCFS;
        private Button buttonSalir;
    }
}
