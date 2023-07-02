namespace WinFormsClient
{
    partial class FrmDiagnostico
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
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            TxtNroDoc = new TextBox();
            TxtNombre = new TextBox();
            label2 = new Label();
            this.TxtApellido = new TextBox();
            TxtTel = new TextBox();
            label3 = new Label();
            TxtEmail = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            TxtPeso = new TextBox();
            label5 = new Label();
            TxtAltura = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(560, 443);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(112, 34);
            BtnAceptar.TabIndex = 0;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(702, 443);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(112, 34);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtTel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtNroDoc);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 253);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Paciente";
            groupBox1.Enter += BtnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Nro Documento:";
            // 
            // TxtNroDoc
            // 
            TxtNroDoc.Location = new Point(36, 70);
            TxtNroDoc.Name = "TxtNroDoc";
            TxtNroDoc.Size = new Size(188, 31);
            TxtNroDoc.TabIndex = 1;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(36, 139);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(188, 31);
            TxtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 111);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre y apellido";
            label2.Click += label2_Click;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new Point(263, 166);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new Size(188, 31);
            this.TxtApellido.TabIndex = 5;
            // 
            // TxtTel
            // 
            TxtTel.Location = new Point(36, 206);
            TxtTel.Name = "TxtTel";
            TxtTel.Size = new Size(188, 31);
            TxtTel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 178);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 4;
            label3.Text = "Teléfono:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(239, 206);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(188, 31);
            TxtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 178);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtAltura);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtPeso);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(24, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 169);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos para el Diagnóstico";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // TxtPeso
            // 
            TxtPeso.Location = new Point(36, 66);
            TxtPeso.Name = "TxtPeso";
            TxtPeso.Size = new Size(188, 31);
            TxtPeso.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 38);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 8;
            label5.Text = "Peso:";
            label5.Click += label5_Click;
            // 
            // TxtAltura
            // 
            TxtAltura.Location = new Point(239, 66);
            TxtAltura.Name = "TxtAltura";
            TxtAltura.Size = new Size(188, 31);
            TxtAltura.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 38);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 10;
            label6.Text = "Altura:";
            // 
            // FrmDiagnostico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 528);
            Controls.Add(groupBox2);
            Controls.Add(this.TxtApellido);
            Controls.Add(groupBox1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Name = "FrmDiagnostico";
            Text = "Nuevo Diagnostico";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAceptar;
        private Button BtnCancelar;
        private GroupBox groupBox1;
        private TextBox TxtNroDoc;
        private Label label1;
        private TextBox textBox2;
        private TextBox TxtNombre;
        private Label label2;
        private TextBox TxtEmail;
        private Label label4;
        private TextBox TxtTel;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox TxtAltura;
        private Label label6;
        private TextBox TxtPeso;
        private Label label5;
    }
}