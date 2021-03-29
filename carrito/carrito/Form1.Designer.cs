
namespace carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1crear = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonFrenar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelDatos = new System.Windows.Forms.Label();
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.labelFrenar = new System.Windows.Forms.Label();
            this.labelApagar = new System.Windows.Forms.Label();
            this.buttoncargar = new System.Windows.Forms.Button();
            this.buttonreproducir = new System.Windows.Forms.Button();
            this.buttonparar = new System.Windows.Forms.Button();
            this.buttonpausar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonviaizquierda = new System.Windows.Forms.Button();
            this.buttonviaderecha = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelizquierda = new System.Windows.Forms.Label();
            this.labelderecha = new System.Windows.Forms.Label();
            this.labelCrear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1crear
            // 
            this.button1crear.Location = new System.Drawing.Point(139, 9);
            this.button1crear.Name = "button1crear";
            this.button1crear.Size = new System.Drawing.Size(97, 23);
            this.button1crear.TabIndex = 0;
            this.button1crear.Text = "Crear Carro";
            this.button1crear.UseVisualStyleBackColor = true;
            this.button1crear.Click += new System.EventHandler(this.button1crear_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.Location = new System.Drawing.Point(139, 33);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(97, 23);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender Carro";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(139, 62);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(97, 23);
            this.buttonAcelerar.TabIndex = 2;
            this.buttonAcelerar.Text = "Acelerar Carro";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonFrenar
            // 
            this.buttonFrenar.Location = new System.Drawing.Point(139, 91);
            this.buttonFrenar.Name = "buttonFrenar";
            this.buttonFrenar.Size = new System.Drawing.Size(97, 23);
            this.buttonFrenar.TabIndex = 3;
            this.buttonFrenar.Text = "Frenar Carro";
            this.buttonFrenar.UseVisualStyleBackColor = true;
            this.buttonFrenar.Click += new System.EventHandler(this.buttonFrenar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(117, 328);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(97, 23);
            this.buttonApagar.TabIndex = 4;
            this.buttonApagar.Text = "Apagar Carro";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.Location = new System.Drawing.Point(283, 38);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(59, 13);
            this.labelDatos.TabIndex = 5;
            this.labelDatos.Text = "Encennder";
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.Location = new System.Drawing.Point(283, 62);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(54, 13);
            this.labelVelocidad.TabIndex = 6;
            this.labelVelocidad.Text = "Velocidad";
            // 
            // labelFrenar
            // 
            this.labelFrenar.AutoSize = true;
            this.labelFrenar.Location = new System.Drawing.Point(283, 91);
            this.labelFrenar.Name = "labelFrenar";
            this.labelFrenar.Size = new System.Drawing.Size(37, 13);
            this.labelFrenar.TabIndex = 7;
            this.labelFrenar.Text = "Frenar";
            // 
            // labelApagar
            // 
            this.labelApagar.AutoSize = true;
            this.labelApagar.Location = new System.Drawing.Point(283, 333);
            this.labelApagar.Name = "labelApagar";
            this.labelApagar.Size = new System.Drawing.Size(41, 13);
            this.labelApagar.TabIndex = 9;
            this.labelApagar.Text = "Apagar";
            // 
            // buttoncargar
            // 
            this.buttoncargar.Location = new System.Drawing.Point(117, 210);
            this.buttoncargar.Name = "buttoncargar";
            this.buttoncargar.Size = new System.Drawing.Size(75, 23);
            this.buttoncargar.TabIndex = 11;
            this.buttoncargar.Text = "Cargar";
            this.buttoncargar.UseVisualStyleBackColor = true;
            this.buttoncargar.Click += new System.EventHandler(this.buttoncargar_Click);
            // 
            // buttonreproducir
            // 
            this.buttonreproducir.Location = new System.Drawing.Point(215, 207);
            this.buttonreproducir.Name = "buttonreproducir";
            this.buttonreproducir.Size = new System.Drawing.Size(75, 23);
            this.buttonreproducir.TabIndex = 12;
            this.buttonreproducir.Text = "Reproducir";
            this.buttonreproducir.UseVisualStyleBackColor = true;
            this.buttonreproducir.Click += new System.EventHandler(this.buttonreproducir_Click);
            // 
            // buttonparar
            // 
            this.buttonparar.Location = new System.Drawing.Point(317, 206);
            this.buttonparar.Name = "buttonparar";
            this.buttonparar.Size = new System.Drawing.Size(75, 23);
            this.buttonparar.TabIndex = 13;
            this.buttonparar.Text = "Parar";
            this.buttonparar.UseVisualStyleBackColor = true;
            this.buttonparar.Click += new System.EventHandler(this.buttonparar_Click);
            // 
            // buttonpausar
            // 
            this.buttonpausar.Location = new System.Drawing.Point(430, 207);
            this.buttonpausar.Name = "buttonpausar";
            this.buttonpausar.Size = new System.Drawing.Size(75, 23);
            this.buttonpausar.TabIndex = 14;
            this.buttonpausar.Text = "Pausar";
            this.buttonpausar.UseVisualStyleBackColor = true;
            this.buttonpausar.Click += new System.EventHandler(this.buttonpausar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // buttonviaizquierda
            // 
            this.buttonviaizquierda.Location = new System.Drawing.Point(117, 239);
            this.buttonviaizquierda.Name = "buttonviaizquierda";
            this.buttonviaizquierda.Size = new System.Drawing.Size(119, 34);
            this.buttonviaizquierda.TabIndex = 16;
            this.buttonviaizquierda.Text = "Luz de Emergencia Izquieda";
            this.buttonviaizquierda.UseVisualStyleBackColor = true;
            this.buttonviaizquierda.Click += new System.EventHandler(this.buttonviaizquierda_Click);
            // 
            // buttonviaderecha
            // 
            this.buttonviaderecha.Location = new System.Drawing.Point(117, 279);
            this.buttonviaderecha.Name = "buttonviaderecha";
            this.buttonviaderecha.Size = new System.Drawing.Size(119, 38);
            this.buttonviaderecha.TabIndex = 17;
            this.buttonviaderecha.Text = "Luz de Emergencia Derecha";
            this.buttonviaderecha.UseVisualStyleBackColor = true;
            this.buttonviaderecha.Click += new System.EventHandler(this.buttonviaderecha_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(206, 154);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(222, 33);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            // 
            // labelizquierda
            // 
            this.labelizquierda.AutoSize = true;
            this.labelizquierda.Location = new System.Drawing.Point(283, 250);
            this.labelizquierda.Name = "labelizquierda";
            this.labelizquierda.Size = new System.Drawing.Size(50, 13);
            this.labelizquierda.TabIndex = 18;
            this.labelizquierda.Text = "Izquierda";
            // 
            // labelderecha
            // 
            this.labelderecha.AutoSize = true;
            this.labelderecha.Location = new System.Drawing.Point(283, 292);
            this.labelderecha.Name = "labelderecha";
            this.labelderecha.Size = new System.Drawing.Size(48, 13);
            this.labelderecha.TabIndex = 19;
            this.labelderecha.Text = "Derecha";
            this.labelderecha.Click += new System.EventHandler(this.labelderecha_Click);
            // 
            // labelCrear
            // 
            this.labelCrear.AutoSize = true;
            this.labelCrear.Location = new System.Drawing.Point(283, 9);
            this.labelCrear.Name = "labelCrear";
            this.labelCrear.Size = new System.Drawing.Size(168, 13);
            this.labelCrear.TabIndex = 10;
            this.labelCrear.Text = "Cree el Carro antes de encenderlo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Reproductor de Musica MP3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 363);
            this.Controls.Add(this.labelCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelderecha);
            this.Controls.Add(this.labelizquierda);
            this.Controls.Add(this.buttonviaderecha);
            this.Controls.Add(this.buttonviaizquierda);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.buttonpausar);
            this.Controls.Add(this.buttonparar);
            this.Controls.Add(this.buttonreproducir);
            this.Controls.Add(this.buttoncargar);
            this.Controls.Add(this.labelApagar);
            this.Controls.Add(this.labelFrenar);
            this.Controls.Add(this.labelVelocidad);
            this.Controls.Add(this.labelDatos);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonFrenar);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.button1crear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1crear;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Button buttonFrenar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label labelDatos;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.Label labelFrenar;
        private System.Windows.Forms.Label labelApagar;
        private System.Windows.Forms.Button buttoncargar;
        private System.Windows.Forms.Button buttonreproducir;
        private System.Windows.Forms.Button buttonparar;
        private System.Windows.Forms.Button buttonpausar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonviaizquierda;
        private System.Windows.Forms.Button buttonviaderecha;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label labelizquierda;
        private System.Windows.Forms.Label labelderecha;
        private System.Windows.Forms.Label labelCrear;
        private System.Windows.Forms.Label label1;
    }
}

