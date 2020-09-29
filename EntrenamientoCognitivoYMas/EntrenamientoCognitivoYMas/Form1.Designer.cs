namespace EntrenamientoCognitivoYMas
{
    partial class FrmEntrenamiento
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
            this.components = new System.ComponentModel.Container();
            this.tmrJ1 = new System.Windows.Forms.Timer(this.components);
            this.btnJ1 = new System.Windows.Forms.Button();
            this.lblInfoJ1 = new System.Windows.Forms.Label();
            this.pnlJ1 = new System.Windows.Forms.Panel();
            this.btnJ1VolverMenu = new System.Windows.Forms.Button();
            this.lblTotalPalabrasJ1 = new System.Windows.Forms.Label();
            this.lblFallosJ1 = new System.Windows.Forms.Label();
            this.lblAciertosJ1 = new System.Windows.Forms.Label();
            this.txtEntradaJ1 = new System.Windows.Forms.TextBox();
            this.btnJ2 = new System.Windows.Forms.Button();
            this.pnlJ2 = new System.Windows.Forms.Panel();
            this.btnJ2VolverMenu = new System.Windows.Forms.Button();
            this.lblContadorPalJ2 = new System.Windows.Forms.Label();
            this.lblAciertosJ2 = new System.Windows.Forms.Label();
            this.txtIntroJ2 = new System.Windows.Forms.TextBox();
            this.lblPalBuscarJ2 = new System.Windows.Forms.Label();
            this.lblPreguntaJ2 = new System.Windows.Forms.Label();
            this.lblRondaJ2 = new System.Windows.Forms.Label();
            this.lblCronoJ2 = new System.Windows.Forms.Label();
            this.tmrCronoJ2 = new System.Windows.Forms.Timer(this.components);
            this.lblInfoJ2 = new System.Windows.Forms.Label();
            this.tmrLLenarPalJ2 = new System.Windows.Forms.Timer(this.components);
            this.btnJ3 = new System.Windows.Forms.Button();
            this.pnlJ3 = new System.Windows.Forms.Panel();
            this.btnJ3VolverMenu = new System.Windows.Forms.Button();
            this.lblAvisoJ3 = new System.Windows.Forms.Label();
            this.lblCronoJ3 = new System.Windows.Forms.Label();
            this.lblPalBuscarJ3 = new System.Windows.Forms.Label();
            this.lblPreguntaJ3 = new System.Windows.Forms.Label();
            this.lblAciertosJ3 = new System.Windows.Forms.Label();
            this.tmrCronoJ3 = new System.Windows.Forms.Timer(this.components);
            this.tmrNuevaPartidaJ3 = new System.Windows.Forms.Timer(this.components);
            this.lblInfoJ3 = new System.Windows.Forms.Label();
            this.pnlDatosUsuario = new System.Windows.Forms.Panel();
            this.lblAvisoDatoUsuario = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtEntradaUsuario = new System.Windows.Forms.TextBox();
            this.lblNickUsuario = new System.Windows.Forms.Label();
            this.lblJugadorAcitivo = new System.Windows.Forms.Label();
            this.lblPuntuacionActualJ1 = new System.Windows.Forms.Label();
            this.lblPuntuacionActualJ2 = new System.Windows.Forms.Label();
            this.lblPuntuacionActualJ3 = new System.Windows.Forms.Label();
            this.btnMostrarPuntuaciones = new System.Windows.Forms.Button();
            this.dgvPuntuaciones = new System.Windows.Forms.DataGridView();
            this.pnlJ1.SuspendLayout();
            this.pnlJ2.SuspendLayout();
            this.pnlJ3.SuspendLayout();
            this.pnlDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntuaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrJ1
            // 
            this.tmrJ1.Interval = 35;
            this.tmrJ1.Tick += new System.EventHandler(this.tmrJ1_Tick);
            // 
            // btnJ1
            // 
            this.btnJ1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ1.Location = new System.Drawing.Point(103, 74);
            this.btnJ1.Margin = new System.Windows.Forms.Padding(4);
            this.btnJ1.Name = "btnJ1";
            this.btnJ1.Size = new System.Drawing.Size(147, 59);
            this.btnJ1.TabIndex = 0;
            this.btnJ1.Text = "Aprende Escribiendo";
            this.btnJ1.UseVisualStyleBackColor = true;
            this.btnJ1.Visible = false;
            this.btnJ1.Click += new System.EventHandler(this.btnJ1_Click);
            this.btnJ1.MouseEnter += new System.EventHandler(this.btnJ1_MouseEnter);
            this.btnJ1.MouseLeave += new System.EventHandler(this.btnJ1_MouseLeave);
            // 
            // lblInfoJ1
            // 
            this.lblInfoJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoJ1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoJ1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfoJ1.Location = new System.Drawing.Point(64, 181);
            this.lblInfoJ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoJ1.Name = "lblInfoJ1";
            this.lblInfoJ1.Size = new System.Drawing.Size(279, 113);
            this.lblInfoJ1.TabIndex = 3;
            this.lblInfoJ1.Text = "Escribe con el teclado\r\nlas palabras que aparezen por pantalla. \r\n\r\n\r\n";
            this.lblInfoJ1.Visible = false;
            // 
            // pnlJ1
            // 
            this.pnlJ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlJ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlJ1.Controls.Add(this.btnJ1VolverMenu);
            this.pnlJ1.Controls.Add(this.lblTotalPalabrasJ1);
            this.pnlJ1.Controls.Add(this.lblFallosJ1);
            this.pnlJ1.Controls.Add(this.lblAciertosJ1);
            this.pnlJ1.Location = new System.Drawing.Point(0, 0);
            this.pnlJ1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlJ1.Name = "pnlJ1";
            this.pnlJ1.Size = new System.Drawing.Size(1077, 86);
            this.pnlJ1.TabIndex = 4;
            this.pnlJ1.Visible = false;
            // 
            // btnJ1VolverMenu
            // 
            this.btnJ1VolverMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnJ1VolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnJ1VolverMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnJ1VolverMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJ1VolverMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnJ1VolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJ1VolverMenu.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ1VolverMenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnJ1VolverMenu.Location = new System.Drawing.Point(976, 0);
            this.btnJ1VolverMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJ1VolverMenu.Name = "btnJ1VolverMenu";
            this.btnJ1VolverMenu.Size = new System.Drawing.Size(99, 34);
            this.btnJ1VolverMenu.TabIndex = 8;
            this.btnJ1VolverMenu.Text = "Volver";
            this.btnJ1VolverMenu.UseVisualStyleBackColor = false;
            this.btnJ1VolverMenu.Visible = false;
            this.btnJ1VolverMenu.Click += new System.EventHandler(this.btnJ1VolverMenu_Click);
            // 
            // lblTotalPalabrasJ1
            // 
            this.lblTotalPalabrasJ1.AutoSize = true;
            this.lblTotalPalabrasJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPalabrasJ1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPalabrasJ1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTotalPalabrasJ1.Location = new System.Drawing.Point(437, 31);
            this.lblTotalPalabrasJ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPalabrasJ1.Name = "lblTotalPalabrasJ1";
            this.lblTotalPalabrasJ1.Size = new System.Drawing.Size(227, 23);
            this.lblTotalPalabrasJ1.TabIndex = 7;
            this.lblTotalPalabrasJ1.Text = "Palabras en juego:";
            // 
            // lblFallosJ1
            // 
            this.lblFallosJ1.AutoSize = true;
            this.lblFallosJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblFallosJ1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallosJ1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFallosJ1.Location = new System.Drawing.Point(16, 59);
            this.lblFallosJ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFallosJ1.Name = "lblFallosJ1";
            this.lblFallosJ1.Size = new System.Drawing.Size(98, 23);
            this.lblFallosJ1.TabIndex = 6;
            this.lblFallosJ1.Text = "Fallos :";
            // 
            // lblAciertosJ1
            // 
            this.lblAciertosJ1.AutoSize = true;
            this.lblAciertosJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblAciertosJ1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciertosJ1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAciertosJ1.Location = new System.Drawing.Point(16, 15);
            this.lblAciertosJ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAciertosJ1.Name = "lblAciertosJ1";
            this.lblAciertosJ1.Size = new System.Drawing.Size(121, 23);
            this.lblAciertosJ1.TabIndex = 5;
            this.lblAciertosJ1.Text = "Aciertos :";
            // 
            // txtEntradaJ1
            // 
            this.txtEntradaJ1.Location = new System.Drawing.Point(343, 519);
            this.txtEntradaJ1.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntradaJ1.Name = "txtEntradaJ1";
            this.txtEntradaJ1.Size = new System.Drawing.Size(373, 22);
            this.txtEntradaJ1.TabIndex = 5;
            this.txtEntradaJ1.Visible = false;
            this.txtEntradaJ1.TextChanged += new System.EventHandler(this.txtEntradaJ1_TextChanged);
            // 
            // btnJ2
            // 
            this.btnJ2.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ2.Location = new System.Drawing.Point(461, 74);
            this.btnJ2.Margin = new System.Windows.Forms.Padding(4);
            this.btnJ2.Name = "btnJ2";
            this.btnJ2.Size = new System.Drawing.Size(147, 59);
            this.btnJ2.TabIndex = 6;
            this.btnJ2.Text = "Palabras Flash";
            this.btnJ2.UseVisualStyleBackColor = true;
            this.btnJ2.Visible = false;
            this.btnJ2.Click += new System.EventHandler(this.btnJ2_Click);
            this.btnJ2.MouseEnter += new System.EventHandler(this.btnJ2_MouseEnter);
            this.btnJ2.MouseLeave += new System.EventHandler(this.btnJ2_MouseLeave);
            // 
            // pnlJ2
            // 
            this.pnlJ2.BackColor = System.Drawing.Color.Yellow;
            this.pnlJ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlJ2.Controls.Add(this.btnJ2VolverMenu);
            this.pnlJ2.Controls.Add(this.lblContadorPalJ2);
            this.pnlJ2.Controls.Add(this.lblAciertosJ2);
            this.pnlJ2.Controls.Add(this.txtIntroJ2);
            this.pnlJ2.Controls.Add(this.lblPalBuscarJ2);
            this.pnlJ2.Controls.Add(this.lblPreguntaJ2);
            this.pnlJ2.Controls.Add(this.lblRondaJ2);
            this.pnlJ2.Controls.Add(this.lblCronoJ2);
            this.pnlJ2.Location = new System.Drawing.Point(0, 464);
            this.pnlJ2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlJ2.Name = "pnlJ2";
            this.pnlJ2.Size = new System.Drawing.Size(1077, 94);
            this.pnlJ2.TabIndex = 7;
            this.pnlJ2.Visible = false;
            // 
            // btnJ2VolverMenu
            // 
            this.btnJ2VolverMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnJ2VolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnJ2VolverMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnJ2VolverMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJ2VolverMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnJ2VolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJ2VolverMenu.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ2VolverMenu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnJ2VolverMenu.Location = new System.Drawing.Point(971, 56);
            this.btnJ2VolverMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJ2VolverMenu.Name = "btnJ2VolverMenu";
            this.btnJ2VolverMenu.Size = new System.Drawing.Size(99, 34);
            this.btnJ2VolverMenu.TabIndex = 9;
            this.btnJ2VolverMenu.Text = "Volver";
            this.btnJ2VolverMenu.UseVisualStyleBackColor = false;
            this.btnJ2VolverMenu.Visible = false;
            this.btnJ2VolverMenu.Click += new System.EventHandler(this.btnJ2VolverMenu_Click);
            // 
            // lblContadorPalJ2
            // 
            this.lblContadorPalJ2.AutoSize = true;
            this.lblContadorPalJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblContadorPalJ2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorPalJ2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblContadorPalJ2.Location = new System.Drawing.Point(243, 12);
            this.lblContadorPalJ2.Name = "lblContadorPalJ2";
            this.lblContadorPalJ2.Size = new System.Drawing.Size(22, 23);
            this.lblContadorPalJ2.TabIndex = 6;
            this.lblContadorPalJ2.Text = "0";
            this.lblContadorPalJ2.Visible = false;
            // 
            // lblAciertosJ2
            // 
            this.lblAciertosJ2.AutoSize = true;
            this.lblAciertosJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblAciertosJ2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciertosJ2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAciertosJ2.Location = new System.Drawing.Point(829, 38);
            this.lblAciertosJ2.Name = "lblAciertosJ2";
            this.lblAciertosJ2.Size = new System.Drawing.Size(109, 23);
            this.lblAciertosJ2.TabIndex = 5;
            this.lblAciertosJ2.Text = "Aciertos :";
            // 
            // txtIntroJ2
            // 
            this.txtIntroJ2.Location = new System.Drawing.Point(604, 38);
            this.txtIntroJ2.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntroJ2.Name = "txtIntroJ2";
            this.txtIntroJ2.Size = new System.Drawing.Size(164, 22);
            this.txtIntroJ2.TabIndex = 4;
            this.txtIntroJ2.TextChanged += new System.EventHandler(this.txtIntroJ2_TextChanged);
            // 
            // lblPalBuscarJ2
            // 
            this.lblPalBuscarJ2.AutoSize = true;
            this.lblPalBuscarJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblPalBuscarJ2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalBuscarJ2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPalBuscarJ2.Location = new System.Drawing.Point(489, 41);
            this.lblPalBuscarJ2.Name = "lblPalBuscarJ2";
            this.lblPalBuscarJ2.Size = new System.Drawing.Size(0, 23);
            this.lblPalBuscarJ2.TabIndex = 3;
            // 
            // lblPreguntaJ2
            // 
            this.lblPreguntaJ2.AutoSize = true;
            this.lblPreguntaJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblPreguntaJ2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntaJ2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPreguntaJ2.Location = new System.Drawing.Point(243, 41);
            this.lblPreguntaJ2.Name = "lblPreguntaJ2";
            this.lblPreguntaJ2.Size = new System.Drawing.Size(210, 23);
            this.lblPreguntaJ2.TabIndex = 2;
            this.lblPreguntaJ2.Text = "¿Cuantas Palabras ?";
            // 
            // lblRondaJ2
            // 
            this.lblRondaJ2.AutoSize = true;
            this.lblRondaJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblRondaJ2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRondaJ2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRondaJ2.Location = new System.Drawing.Point(15, 59);
            this.lblRondaJ2.Name = "lblRondaJ2";
            this.lblRondaJ2.Size = new System.Drawing.Size(86, 23);
            this.lblRondaJ2.TabIndex = 1;
            this.lblRondaJ2.Text = "Ronda :";
            // 
            // lblCronoJ2
            // 
            this.lblCronoJ2.AutoSize = true;
            this.lblCronoJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblCronoJ2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronoJ2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCronoJ2.Location = new System.Drawing.Point(16, 12);
            this.lblCronoJ2.Name = "lblCronoJ2";
            this.lblCronoJ2.Size = new System.Drawing.Size(97, 23);
            this.lblCronoJ2.TabIndex = 0;
            this.lblCronoJ2.Text = "Tiempo :";
            // 
            // tmrCronoJ2
            // 
            this.tmrCronoJ2.Interval = 1000;
            this.tmrCronoJ2.Tick += new System.EventHandler(this.tmrCronoJ2_Tick);
            // 
            // lblInfoJ2
            // 
            this.lblInfoJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoJ2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoJ2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfoJ2.Location = new System.Drawing.Point(413, 181);
            this.lblInfoJ2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoJ2.Name = "lblInfoJ2";
            this.lblInfoJ2.Size = new System.Drawing.Size(311, 185);
            this.lblInfoJ2.TabIndex = 8;
            this.lblInfoJ2.Text = "Tendrás 10 segundos para contar el número de palabras solicitado.\r\n\r\nDespués escr" +
    "ibe el número por teclado.";
            this.lblInfoJ2.Visible = false;
            // 
            // tmrLLenarPalJ2
            // 
            this.tmrLLenarPalJ2.Interval = 350;
            this.tmrLLenarPalJ2.Tick += new System.EventHandler(this.tmrLLenarPalJ2_Tick);
            // 
            // btnJ3
            // 
            this.btnJ3.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ3.Location = new System.Drawing.Point(828, 74);
            this.btnJ3.Margin = new System.Windows.Forms.Padding(4);
            this.btnJ3.Name = "btnJ3";
            this.btnJ3.Size = new System.Drawing.Size(147, 59);
            this.btnJ3.TabIndex = 9;
            this.btnJ3.Text = "Encuentra La Palabra";
            this.btnJ3.UseVisualStyleBackColor = true;
            this.btnJ3.Visible = false;
            this.btnJ3.Click += new System.EventHandler(this.btnJ3_Click);
            this.btnJ3.MouseEnter += new System.EventHandler(this.btnJ3_MouseEnter);
            this.btnJ3.MouseLeave += new System.EventHandler(this.btnJ3_MouseLeave);
            // 
            // pnlJ3
            // 
            this.pnlJ3.BackColor = System.Drawing.Color.Gold;
            this.pnlJ3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlJ3.Controls.Add(this.btnJ3VolverMenu);
            this.pnlJ3.Controls.Add(this.lblAvisoJ3);
            this.pnlJ3.Controls.Add(this.lblCronoJ3);
            this.pnlJ3.Controls.Add(this.lblPalBuscarJ3);
            this.pnlJ3.Controls.Add(this.lblPreguntaJ3);
            this.pnlJ3.Controls.Add(this.lblAciertosJ3);
            this.pnlJ3.Location = new System.Drawing.Point(1019, 332);
            this.pnlJ3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlJ3.Name = "pnlJ3";
            this.pnlJ3.Size = new System.Drawing.Size(1087, 124);
            this.pnlJ3.TabIndex = 10;
            this.pnlJ3.Visible = false;
            // 
            // btnJ3VolverMenu
            // 
            this.btnJ3VolverMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnJ3VolverMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnJ3VolverMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnJ3VolverMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnJ3VolverMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnJ3VolverMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJ3VolverMenu.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ3VolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJ3VolverMenu.Location = new System.Drawing.Point(976, 2);
            this.btnJ3VolverMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJ3VolverMenu.Name = "btnJ3VolverMenu";
            this.btnJ3VolverMenu.Size = new System.Drawing.Size(99, 34);
            this.btnJ3VolverMenu.TabIndex = 10;
            this.btnJ3VolverMenu.Text = "Volver";
            this.btnJ3VolverMenu.UseVisualStyleBackColor = false;
            this.btnJ3VolverMenu.Click += new System.EventHandler(this.btnJ3VolverMenu_Click);
            // 
            // lblAvisoJ3
            // 
            this.lblAvisoJ3.AutoSize = true;
            this.lblAvisoJ3.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoJ3.Location = new System.Drawing.Point(381, 92);
            this.lblAvisoJ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvisoJ3.Name = "lblAvisoJ3";
            this.lblAvisoJ3.Size = new System.Drawing.Size(0, 21);
            this.lblAvisoJ3.TabIndex = 4;
            // 
            // lblCronoJ3
            // 
            this.lblCronoJ3.AutoSize = true;
            this.lblCronoJ3.BackColor = System.Drawing.Color.Transparent;
            this.lblCronoJ3.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronoJ3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCronoJ3.Location = new System.Drawing.Point(868, 92);
            this.lblCronoJ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCronoJ3.Name = "lblCronoJ3";
            this.lblCronoJ3.Size = new System.Drawing.Size(93, 21);
            this.lblCronoJ3.TabIndex = 3;
            this.lblCronoJ3.Text = "Tiempo :";
            // 
            // lblPalBuscarJ3
            // 
            this.lblPalBuscarJ3.AutoSize = true;
            this.lblPalBuscarJ3.BackColor = System.Drawing.Color.Transparent;
            this.lblPalBuscarJ3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalBuscarJ3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPalBuscarJ3.Location = new System.Drawing.Point(615, 63);
            this.lblPalBuscarJ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalBuscarJ3.Name = "lblPalBuscarJ3";
            this.lblPalBuscarJ3.Size = new System.Drawing.Size(70, 23);
            this.lblPalBuscarJ3.TabIndex = 2;
            this.lblPalBuscarJ3.Text = "PEPE";
            // 
            // lblPreguntaJ3
            // 
            this.lblPreguntaJ3.AutoSize = true;
            this.lblPreguntaJ3.BackColor = System.Drawing.Color.Transparent;
            this.lblPreguntaJ3.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntaJ3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPreguntaJ3.Location = new System.Drawing.Point(385, 63);
            this.lblPreguntaJ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreguntaJ3.Name = "lblPreguntaJ3";
            this.lblPreguntaJ3.Size = new System.Drawing.Size(207, 21);
            this.lblPreguntaJ3.TabIndex = 1;
            this.lblPreguntaJ3.Text = "Palabra a buscar :";
            // 
            // lblAciertosJ3
            // 
            this.lblAciertosJ3.AutoSize = true;
            this.lblAciertosJ3.BackColor = System.Drawing.Color.Transparent;
            this.lblAciertosJ3.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciertosJ3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAciertosJ3.Location = new System.Drawing.Point(27, 92);
            this.lblAciertosJ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAciertosJ3.Name = "lblAciertosJ3";
            this.lblAciertosJ3.Size = new System.Drawing.Size(118, 21);
            this.lblAciertosJ3.TabIndex = 0;
            this.lblAciertosJ3.Text = "Aciertos :";
            // 
            // tmrCronoJ3
            // 
            this.tmrCronoJ3.Interval = 1000;
            this.tmrCronoJ3.Tick += new System.EventHandler(this.tmrCronoJ3_Tick);
            // 
            // tmrNuevaPartidaJ3
            // 
            this.tmrNuevaPartidaJ3.Tick += new System.EventHandler(this.tmrNuevaPartidaJ3_Tick);
            // 
            // lblInfoJ3
            // 
            this.lblInfoJ3.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoJ3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoJ3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfoJ3.Location = new System.Drawing.Point(811, 181);
            this.lblInfoJ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfoJ3.Name = "lblInfoJ3";
            this.lblInfoJ3.Size = new System.Drawing.Size(220, 80);
            this.lblInfoJ3.TabIndex = 11;
            this.lblInfoJ3.Text = "Tienes 5 segundos para encontrar la palabra solicitda.\r\n\r\n\r\n";
            this.lblInfoJ3.Visible = false;
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.BackColor = System.Drawing.Color.DimGray;
            this.pnlDatosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosUsuario.Controls.Add(this.lblAvisoDatoUsuario);
            this.pnlDatosUsuario.Controls.Add(this.btnCrearUsuario);
            this.pnlDatosUsuario.Controls.Add(this.txtEntradaUsuario);
            this.pnlDatosUsuario.Controls.Add(this.lblNickUsuario);
            this.pnlDatosUsuario.Location = new System.Drawing.Point(281, 139);
            this.pnlDatosUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(515, 243);
            this.pnlDatosUsuario.TabIndex = 12;
            this.pnlDatosUsuario.Visible = false;
            // 
            // lblAvisoDatoUsuario
            // 
            this.lblAvisoDatoUsuario.AutoSize = true;
            this.lblAvisoDatoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoDatoUsuario.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAvisoDatoUsuario.Location = new System.Drawing.Point(35, 127);
            this.lblAvisoDatoUsuario.Name = "lblAvisoDatoUsuario";
            this.lblAvisoDatoUsuario.Size = new System.Drawing.Size(0, 25);
            this.lblAvisoDatoUsuario.TabIndex = 12;
            this.lblAvisoDatoUsuario.Visible = false;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(196, 162);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(133, 34);
            this.btnCrearUsuario.TabIndex = 11;
            this.btnCrearUsuario.Text = "ACEPTAR";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // txtEntradaUsuario
            // 
            this.txtEntradaUsuario.Location = new System.Drawing.Point(303, 87);
            this.txtEntradaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntradaUsuario.Name = "txtEntradaUsuario";
            this.txtEntradaUsuario.Size = new System.Drawing.Size(164, 22);
            this.txtEntradaUsuario.TabIndex = 10;
            // 
            // lblNickUsuario
            // 
            this.lblNickUsuario.AutoSize = true;
            this.lblNickUsuario.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickUsuario.Location = new System.Drawing.Point(33, 85);
            this.lblNickUsuario.Name = "lblNickUsuario";
            this.lblNickUsuario.Size = new System.Drawing.Size(251, 22);
            this.lblNickUsuario.TabIndex = 0;
            this.lblNickUsuario.Text = "Nick/Apodo/Nombre";
            // 
            // lblJugadorAcitivo
            // 
            this.lblJugadorAcitivo.AutoSize = true;
            this.lblJugadorAcitivo.BackColor = System.Drawing.Color.Transparent;
            this.lblJugadorAcitivo.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadorAcitivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblJugadorAcitivo.Location = new System.Drawing.Point(28, 433);
            this.lblJugadorAcitivo.Name = "lblJugadorAcitivo";
            this.lblJugadorAcitivo.Size = new System.Drawing.Size(175, 24);
            this.lblJugadorAcitivo.TabIndex = 13;
            this.lblJugadorAcitivo.Text = "Está Jugando :";
            this.lblJugadorAcitivo.Visible = false;
            // 
            // lblPuntuacionActualJ1
            // 
            this.lblPuntuacionActualJ1.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntuacionActualJ1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacionActualJ1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuntuacionActualJ1.Location = new System.Drawing.Point(77, 336);
            this.lblPuntuacionActualJ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntuacionActualJ1.Name = "lblPuntuacionActualJ1";
            this.lblPuntuacionActualJ1.Size = new System.Drawing.Size(212, 30);
            this.lblPuntuacionActualJ1.TabIndex = 14;
            this.lblPuntuacionActualJ1.Text = "Tú puntuación :\r\n\r\n\r\n\r\n";
            this.lblPuntuacionActualJ1.Visible = false;
            // 
            // lblPuntuacionActualJ2
            // 
            this.lblPuntuacionActualJ2.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntuacionActualJ2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacionActualJ2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuntuacionActualJ2.Location = new System.Drawing.Point(457, 336);
            this.lblPuntuacionActualJ2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntuacionActualJ2.Name = "lblPuntuacionActualJ2";
            this.lblPuntuacionActualJ2.Size = new System.Drawing.Size(212, 30);
            this.lblPuntuacionActualJ2.TabIndex = 15;
            this.lblPuntuacionActualJ2.Text = "Tú puntuación :\r\n\r\n\r\n\r\n";
            this.lblPuntuacionActualJ2.Visible = false;
            // 
            // lblPuntuacionActualJ3
            // 
            this.lblPuntuacionActualJ3.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntuacionActualJ3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacionActualJ3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuntuacionActualJ3.Location = new System.Drawing.Point(819, 336);
            this.lblPuntuacionActualJ3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntuacionActualJ3.Name = "lblPuntuacionActualJ3";
            this.lblPuntuacionActualJ3.Size = new System.Drawing.Size(212, 30);
            this.lblPuntuacionActualJ3.TabIndex = 16;
            this.lblPuntuacionActualJ3.Text = "Tú puntuación :\r\n\r\n\r\n\r\n";
            this.lblPuntuacionActualJ3.Visible = false;
            // 
            // btnMostrarPuntuaciones
            // 
            this.btnMostrarPuntuaciones.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPuntuaciones.Location = new System.Drawing.Point(875, 478);
            this.btnMostrarPuntuaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarPuntuaciones.Name = "btnMostrarPuntuaciones";
            this.btnMostrarPuntuaciones.Size = new System.Drawing.Size(165, 64);
            this.btnMostrarPuntuaciones.TabIndex = 18;
            this.btnMostrarPuntuaciones.Text = "Puntuaciones";
            this.btnMostrarPuntuaciones.UseVisualStyleBackColor = true;
            this.btnMostrarPuntuaciones.Visible = false;
            this.btnMostrarPuntuaciones.Click += new System.EventHandler(this.btnMostrarPuntuaciones_Click);
            // 
            // dgvPuntuaciones
            // 
            this.dgvPuntuaciones.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPuntuaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntuaciones.GridColor = System.Drawing.Color.DimGray;
            this.dgvPuntuaciones.Location = new System.Drawing.Point(102, 70);
            this.dgvPuntuaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPuntuaciones.Name = "dgvPuntuaciones";
            this.dgvPuntuaciones.RowTemplate.Height = 24;
            this.dgvPuntuaciones.Size = new System.Drawing.Size(895, 385);
            this.dgvPuntuaciones.TabIndex = 19;
            this.dgvPuntuaciones.Visible = false;
            // 
            // FrmEntrenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvPuntuaciones);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Controls.Add(this.pnlJ3);
            this.Controls.Add(this.lblPuntuacionActualJ3);
            this.Controls.Add(this.lblPuntuacionActualJ2);
            this.Controls.Add(this.lblPuntuacionActualJ1);
            this.Controls.Add(this.lblJugadorAcitivo);
            this.Controls.Add(this.btnJ1);
            this.Controls.Add(this.btnJ3);
            this.Controls.Add(this.btnMostrarPuntuaciones);
            this.Controls.Add(this.lblInfoJ2);
            this.Controls.Add(this.pnlJ2);
            this.Controls.Add(this.lblInfoJ3);
            this.Controls.Add(this.btnJ2);
            this.Controls.Add(this.pnlJ1);
            this.Controls.Add(this.lblInfoJ1);
            this.Controls.Add(this.txtEntradaJ1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEntrenamiento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrenamiento Cognitivo y Más";
            this.Load += new System.EventHandler(this.FrmEntrenamiento_Load);
            this.pnlJ1.ResumeLayout(false);
            this.pnlJ1.PerformLayout();
            this.pnlJ2.ResumeLayout(false);
            this.pnlJ2.PerformLayout();
            this.pnlJ3.ResumeLayout(false);
            this.pnlJ3.PerformLayout();
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntuaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrJ1;
        private System.Windows.Forms.Button btnJ1;
        private System.Windows.Forms.Label lblInfoJ1;
        private System.Windows.Forms.Panel pnlJ1;
        private System.Windows.Forms.Label lblTotalPalabrasJ1;
        private System.Windows.Forms.Label lblFallosJ1;
        private System.Windows.Forms.Label lblAciertosJ1;
        private System.Windows.Forms.TextBox txtEntradaJ1;
        private System.Windows.Forms.Button btnJ1VolverMenu;
        private System.Windows.Forms.Button btnJ2;
        private System.Windows.Forms.Panel pnlJ2;
        private System.Windows.Forms.Label lblCronoJ2;
        private System.Windows.Forms.Timer tmrCronoJ2;
        private System.Windows.Forms.Label lblContadorPalJ2;
        private System.Windows.Forms.Label lblAciertosJ2;
        private System.Windows.Forms.TextBox txtIntroJ2;
        private System.Windows.Forms.Label lblPalBuscarJ2;
        private System.Windows.Forms.Label lblPreguntaJ2;
        private System.Windows.Forms.Label lblRondaJ2;
        private System.Windows.Forms.Button btnJ2VolverMenu;
        private System.Windows.Forms.Label lblInfoJ2;
        private System.Windows.Forms.Timer tmrLLenarPalJ2;
        private System.Windows.Forms.Button btnJ3;
        private System.Windows.Forms.Panel pnlJ3;
        private System.Windows.Forms.Label lblPreguntaJ3;
        private System.Windows.Forms.Label lblAciertosJ3;
        private System.Windows.Forms.Label lblAvisoJ3;
        private System.Windows.Forms.Label lblCronoJ3;
        private System.Windows.Forms.Label lblPalBuscarJ3;
        private System.Windows.Forms.Timer tmrCronoJ3;
        private System.Windows.Forms.Timer tmrNuevaPartidaJ3;
        private System.Windows.Forms.Label lblInfoJ3;
        private System.Windows.Forms.Button btnJ3VolverMenu;
        private System.Windows.Forms.Panel pnlDatosUsuario;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.TextBox txtEntradaUsuario;
        private System.Windows.Forms.Label lblNickUsuario;
        private System.Windows.Forms.Label lblJugadorAcitivo;
        private System.Windows.Forms.Label lblAvisoDatoUsuario;
        private System.Windows.Forms.Label lblPuntuacionActualJ1;
        private System.Windows.Forms.Label lblPuntuacionActualJ2;
        private System.Windows.Forms.Label lblPuntuacionActualJ3;
        private System.Windows.Forms.Button btnMostrarPuntuaciones;
        private System.Windows.Forms.DataGridView dgvPuntuaciones;
    }
}

