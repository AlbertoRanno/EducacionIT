namespace WinFormsClient
{
    partial class FrmWelcome
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
            BtnComenzar = new Button();
            TxtInformativo = new Label();
            SuspendLayout();
            // 
            // BtnComenzar
            // 
            BtnComenzar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtnComenzar.ForeColor = SystemColors.MenuHighlight;
            BtnComenzar.Location = new Point(179, 200);
            BtnComenzar.Name = "BtnComenzar";
            BtnComenzar.Size = new Size(326, 124);
            BtnComenzar.TabIndex = 0;
            BtnComenzar.Text = "Comenzar";
            BtnComenzar.UseVisualStyleBackColor = true;
            BtnComenzar.Click += BtnComenzar_Click;
            // 
            // TxtInformativo
            // 
            TxtInformativo.AutoSize = true;
            TxtInformativo.Location = new Point(60, 58);
            TxtInformativo.Name = "TxtInformativo";
            TxtInformativo.Size = new Size(382, 25);
            TxtInformativo.TabIndex = 1;
            TxtInformativo.Text = "Texto informativo donde se importa contenido";
            TxtInformativo.Click += label1_Click;
            // 
            // FrmWelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtInformativo);
            Controls.Add(BtnComenzar);
            Name = "FrmWelcome";
            Text = "Bienvenido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnComenzar;
        private Label TxtInformativo;
    }
}