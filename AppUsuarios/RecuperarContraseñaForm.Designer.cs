namespace AppUsuarios
{
    partial class RecuperarContraseñaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNuevaPass = new System.Windows.Forms.Label();
            this.labelConfirmar = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEnviarCodigo = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Registrado";
            // 
            // labelCodigo
            // 
            this.labelCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(43, 102);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(113, 13);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Codigo de Verificación";
            // 
            // labelNuevaPass
            // 
            this.labelNuevaPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNuevaPass.AutoSize = true;
            this.labelNuevaPass.Location = new System.Drawing.Point(52, 164);
            this.labelNuevaPass.Name = "labelNuevaPass";
            this.labelNuevaPass.Size = new System.Drawing.Size(96, 13);
            this.labelNuevaPass.TabIndex = 2;
            this.labelNuevaPass.Text = "Nueva Contraseña";
            this.labelNuevaPass.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelConfirmar
            // 
            this.labelConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirmar.AutoSize = true;
            this.labelConfirmar.Location = new System.Drawing.Point(46, 226);
            this.labelConfirmar.Name = "labelConfirmar";
            this.labelConfirmar.Size = new System.Drawing.Size(108, 13);
            this.labelConfirmar.TabIndex = 3;
            this.labelConfirmar.Text = "Confirmar Contraseña";
            this.labelConfirmar.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(50, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviarCodigo.Location = new System.Drawing.Point(50, 66);
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.Size = new System.Drawing.Size(100, 23);
            this.btnEnviarCodigo.TabIndex = 5;
            this.btnEnviarCodigo.Text = "Enviar Codigo";
            this.btnEnviarCodigo.UseVisualStyleBackColor = true;
            this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Location = new System.Drawing.Point(50, 129);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNuevaPass.Location = new System.Drawing.Point(50, 191);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaPass.TabIndex = 7;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmar.Location = new System.Drawing.Point(50, 253);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmar.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(26, 283);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar nueva contraseña";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEnviarCodigo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtConfirmar, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelConfirmar, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtNuevaPass, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelNuevaPass, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCodigo, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(297, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 310);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // RecuperarContraseñaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RecuperarContraseñaForm";
            this.Text = "Recupero de contraseña";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNuevaPass;
        private System.Windows.Forms.Label labelConfirmar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}