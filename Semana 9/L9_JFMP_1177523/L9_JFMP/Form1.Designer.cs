namespace L9_JFMP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPingresodatos = new System.Windows.Forms.TabPage();
            this.txtBxTipoDeCambio = new System.Windows.Forms.TextBox();
            this.txtBxMarca = new System.Windows.Forms.TextBox();
            this.txtBxPrecio = new System.Windows.Forms.TextBox();
            this.txtBxModelo = new System.Windows.Forms.TextBox();
            this.lblTipoDeCambio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.BtnGuardarInfo = new System.Windows.Forms.Button();
            this.tPdatosauto = new System.Windows.Forms.TabPage();
            this.btnCambiarDisponibilidad = new System.Windows.Forms.Button();
            this.txtBxDatosAutomovil = new System.Windows.Forms.TextBox();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.txtBxDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tPingresodatos.SuspendLayout();
            this.tPdatosauto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(36, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(494, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LABORATORIO CON CLASES";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPingresodatos);
            this.tabControl1.Controls.Add(this.tPdatosauto);
            this.tabControl1.Location = new System.Drawing.Point(81, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 350);
            this.tabControl1.TabIndex = 1;
            // 
            // tPingresodatos
            // 
            this.tPingresodatos.Controls.Add(this.txtBxTipoDeCambio);
            this.tPingresodatos.Controls.Add(this.txtBxMarca);
            this.tPingresodatos.Controls.Add(this.txtBxPrecio);
            this.tPingresodatos.Controls.Add(this.txtBxModelo);
            this.tPingresodatos.Controls.Add(this.lblTipoDeCambio);
            this.tPingresodatos.Controls.Add(this.lblMarca);
            this.tPingresodatos.Controls.Add(this.lblPrecio);
            this.tPingresodatos.Controls.Add(this.lblModelo);
            this.tPingresodatos.Controls.Add(this.BtnGuardarInfo);
            this.tPingresodatos.Location = new System.Drawing.Point(4, 22);
            this.tPingresodatos.Name = "tPingresodatos";
            this.tPingresodatos.Padding = new System.Windows.Forms.Padding(3);
            this.tPingresodatos.Size = new System.Drawing.Size(381, 324);
            this.tPingresodatos.TabIndex = 0;
            this.tPingresodatos.Text = "Ingreso de Datos";
            this.tPingresodatos.UseVisualStyleBackColor = true;
            // 
            // txtBxTipoDeCambio
            // 
            this.txtBxTipoDeCambio.Location = new System.Drawing.Point(203, 160);
            this.txtBxTipoDeCambio.Name = "txtBxTipoDeCambio";
            this.txtBxTipoDeCambio.Size = new System.Drawing.Size(94, 20);
            this.txtBxTipoDeCambio.TabIndex = 8;
            this.txtBxTipoDeCambio.Text = "7.50";
            // 
            // txtBxMarca
            // 
            this.txtBxMarca.Location = new System.Drawing.Point(203, 126);
            this.txtBxMarca.Name = "txtBxMarca";
            this.txtBxMarca.Size = new System.Drawing.Size(94, 20);
            this.txtBxMarca.TabIndex = 7;
            // 
            // txtBxPrecio
            // 
            this.txtBxPrecio.Location = new System.Drawing.Point(203, 90);
            this.txtBxPrecio.Name = "txtBxPrecio";
            this.txtBxPrecio.Size = new System.Drawing.Size(94, 20);
            this.txtBxPrecio.TabIndex = 6;
            // 
            // txtBxModelo
            // 
            this.txtBxModelo.Location = new System.Drawing.Point(203, 59);
            this.txtBxModelo.Name = "txtBxModelo";
            this.txtBxModelo.Size = new System.Drawing.Size(94, 20);
            this.txtBxModelo.TabIndex = 5;
            // 
            // lblTipoDeCambio
            // 
            this.lblTipoDeCambio.AutoSize = true;
            this.lblTipoDeCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeCambio.Location = new System.Drawing.Point(93, 161);
            this.lblTipoDeCambio.Name = "lblTipoDeCambio";
            this.lblTipoDeCambio.Size = new System.Drawing.Size(94, 15);
            this.lblTipoDeCambio.TabIndex = 4;
            this.lblTipoDeCambio.Text = "Tipo de Cambio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(93, 127);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 15);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(93, 91);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(93, 60);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(49, 15);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BtnGuardarInfo
            // 
            this.BtnGuardarInfo.BackColor = System.Drawing.Color.Silver;
            this.BtnGuardarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuardarInfo.Location = new System.Drawing.Point(113, 210);
            this.BtnGuardarInfo.Name = "BtnGuardarInfo";
            this.BtnGuardarInfo.Size = new System.Drawing.Size(165, 80);
            this.BtnGuardarInfo.TabIndex = 0;
            this.BtnGuardarInfo.Text = "GUARDAR INFORMACIÓN";
            this.BtnGuardarInfo.UseVisualStyleBackColor = false;
            this.BtnGuardarInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // tPdatosauto
            // 
            this.tPdatosauto.Controls.Add(this.btnCambiarDisponibilidad);
            this.tPdatosauto.Controls.Add(this.txtBxDatosAutomovil);
            this.tPdatosauto.Controls.Add(this.BtnAplicar);
            this.tPdatosauto.Controls.Add(this.txtBxDescuento);
            this.tPdatosauto.Controls.Add(this.lblDescuento);
            this.tPdatosauto.Location = new System.Drawing.Point(4, 22);
            this.tPdatosauto.Name = "tPdatosauto";
            this.tPdatosauto.Padding = new System.Windows.Forms.Padding(3);
            this.tPdatosauto.Size = new System.Drawing.Size(381, 324);
            this.tPdatosauto.TabIndex = 1;
            this.tPdatosauto.Text = "Datos Automovil";
            this.tPdatosauto.UseVisualStyleBackColor = true;
            // 
            // btnCambiarDisponibilidad
            // 
            this.btnCambiarDisponibilidad.BackColor = System.Drawing.Color.Silver;
            this.btnCambiarDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarDisponibilidad.Location = new System.Drawing.Point(84, 258);
            this.btnCambiarDisponibilidad.Name = "btnCambiarDisponibilidad";
            this.btnCambiarDisponibilidad.Size = new System.Drawing.Size(207, 56);
            this.btnCambiarDisponibilidad.TabIndex = 4;
            this.btnCambiarDisponibilidad.Text = "CAMBIAR DISPONIBILIDAD";
            this.btnCambiarDisponibilidad.UseVisualStyleBackColor = false;
            this.btnCambiarDisponibilidad.Click += new System.EventHandler(this.btnCambiarDisponibilidad_Click);
            // 
            // txtBxDatosAutomovil
            // 
            this.txtBxDatosAutomovil.Location = new System.Drawing.Point(25, 102);
            this.txtBxDatosAutomovil.Multiline = true;
            this.txtBxDatosAutomovil.Name = "txtBxDatosAutomovil";
            this.txtBxDatosAutomovil.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxDatosAutomovil.Size = new System.Drawing.Size(325, 150);
            this.txtBxDatosAutomovil.TabIndex = 3;
            this.txtBxDatosAutomovil.TextChanged += new System.EventHandler(this.txtBxDatosAutomovil_TextChanged);
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.BackColor = System.Drawing.Color.Silver;
            this.BtnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAplicar.Location = new System.Drawing.Point(230, 39);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(120, 36);
            this.BtnAplicar.TabIndex = 2;
            this.BtnAplicar.Text = "Aplicar";
            this.BtnAplicar.UseVisualStyleBackColor = false;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // txtBxDescuento
            // 
            this.txtBxDescuento.Location = new System.Drawing.Point(25, 55);
            this.txtBxDescuento.Name = "txtBxDescuento";
            this.txtBxDescuento.Size = new System.Drawing.Size(116, 20);
            this.txtBxDescuento.TabIndex = 1;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(33, 28);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(101, 24);
            this.lblDescuento.TabIndex = 0;
            this.lblDescuento.Text = "Descuento";
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnLimpiar.Location = new System.Drawing.Point(476, 348);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(84, 32);
            this.BtnLimpiar.TabIndex = 2;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSalir.Location = new System.Drawing.Point(476, 386);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(84, 34);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tPingresodatos.ResumeLayout(false);
            this.tPingresodatos.PerformLayout();
            this.tPdatosauto.ResumeLayout(false);
            this.tPdatosauto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPingresodatos;
        private System.Windows.Forms.Button BtnGuardarInfo;
        private System.Windows.Forms.TabPage tPdatosauto;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtBxTipoDeCambio;
        private System.Windows.Forms.TextBox txtBxMarca;
        private System.Windows.Forms.TextBox txtBxPrecio;
        private System.Windows.Forms.TextBox txtBxModelo;
        private System.Windows.Forms.Label lblTipoDeCambio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnCambiarDisponibilidad;
        private System.Windows.Forms.TextBox txtBxDatosAutomovil;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.TextBox txtBxDescuento;
        private System.Windows.Forms.Label lblDescuento;
    }
}

