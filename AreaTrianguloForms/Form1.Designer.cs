namespace AreaTrianguloForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(17, 50);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 15);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Base:";
            this.lblBase.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(53, 46);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 23);
            this.txtBase.TabIndex = 2;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(53, 84);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);
            this.txtAltura.TabIndex = 3;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(9, 86);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(42, 15);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(195, 26);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(66, 98);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(82, 142);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(126, 23);
            this.txtResultado.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(37, 147);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(34, 15);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Área:";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 191);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora de Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblBase;
        private TextBox txtBase;
        private TextBox txtAltura;
        private Label lblAltura;
        private Button btnCalcular;
        private TextBox txtResultado;
        private Label lblResultado;
    }
}