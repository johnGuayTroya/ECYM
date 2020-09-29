/*
 * Autor: Johnny A.Guayanay Troya
 * 
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Media;

namespace EntrenamientoCognitivoYMas
{
    public partial class FrmEntrenamiento : Form
    {
        //----------------Datos usuario----------------------

        Jugador  ju = new Jugador();
        public string comprueba; //string para saber si hay mas de un usuario
        
        //----------------------parámetros MYSQL------------------------------

        string strServer = "localhost";
        string strBD = "ecym";
        string strUser = "root";
        string strPwd = "esne55";

        //-------------------------Ruta de archivos----------------------------
        public string ruta;
        //------------------juego1(J1)//Variables globales--------------

        public string texto;
        public int fallos = 0;
        public int totalPalabras = 0;
        ArrayList ArrayJ1 = new ArrayList();
        
        //------------------juego2(J2)//Variables globales--------------

        public int palBusca = 0;
        public int rondaJ2 = 0;
        public int cronoJ2 = 10;
        public string strCompruebaJ2 = "";
        public int p = 0;//variable para crear las palabras
        public int color = 0; //var para crear los colores
        
        //------------------juego2(J3)//Variables globales--------------

        //public int aciertosJ3= 0;
        public int cronoJ3 = 5;
        public int pal = 0;
        public int rondaJ3 = 0;

        //---------------------Sonidos----------------------------------------------------------
        SoundPlayer fallo = new SoundPlayer(Application.StartupPath + "/archivos/snd/0.wav");
        SoundPlayer acierto = new SoundPlayer(Application.StartupPath + "/archivos/snd/1.wav");
        public FrmEntrenamiento()
        {
            InitializeComponent();
        }

        private void FrmEntrenamiento_Load(object sender, EventArgs e)
        {
            GeneraEncunetraPal(); //genero el J3
            CargarImagenes();
            ju.Nick = "";
            ju.AprendeEscribiendo = 0;
            ju.PalabrasFlash = 0;
            ju.EncuentraLaPalabra = 0;
            lblJugadorAcitivo.Location = new Point(10, 10);
            pnlDatosUsuario.Visible = true;
            pnlJ3.Location = new Point(0, 0);
           
        }

        //-----------------------------------J1--------------------------------------
        private void btnJ1_Click(object sender, EventArgs e)
        {
            
            ruta = "/archivos/mix.txt";
            //se iniciliazan las variables
            ju.AprendeEscribiendo = 0;
            fallos = 0;
            totalPalabras = 0;
            //
            LimpiarMenu();
            //
            btnJ1VolverMenu.Visible = false;
            BackgroundImage = null;
            Text = "Aprende escribiendo";
            BackColor = Color.Black;
            //va lentuco
            pnlJ1.Visible = true;
            txtEntradaJ1.Visible = true;
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is Label && ctrl.ForeColor == Color.White)
                {
                    ctrl.Visible = true;
                }
            }
            EmpezarJ1();
            tmrJ1.Enabled = true;
           
        }

        private void btnJ1_MouseEnter(object sender, EventArgs e)
        {
            lblInfoJ1.Visible = true;
            lblPuntuacionActualJ1.Text = "Tú puntuación: "+ ju.AprendeEscribiendo;
            lblPuntuacionActualJ1.Visible = true;
        }

        private void btnJ1_MouseLeave(object sender, EventArgs e)
        {
            lblInfoJ1.Visible = false;
            lblPuntuacionActualJ1.Visible = false;
        }

        private void EmpezarJ1()
        {
            lblAciertosJ1.Text = "Aciertos :" + ju.AprendeEscribiendo.ToString();
            lblFallosJ1.Text = "Fallos :" + fallos.ToString();

            ArrayList ArrayJ1 = new ArrayList();
            string strPalabras = "";
            //MessageBox.Show(ruta.ToString());
            StreamReader ArchivoTexto = new StreamReader(Application.StartupPath + ruta);
            
            while (strPalabras != null)
            {
                strPalabras = ArchivoTexto.ReadLine();
                if (strPalabras != null)
                {
                  ArrayJ1.Add(strPalabras);
                }
            }
            ArchivoTexto.Close();

            totalPalabras = ArrayJ1.Count;
            lblTotalPalabrasJ1.Text = "Palabras en juego :" + totalPalabras.ToString();

            int x, y;
            int i, j;
            x = 600;
            y = 70;

            for (i = 0; i < 1; i++)
            {
                for (j = 0; j < ArrayJ1.Count; j++)
                {

                    if (y >= 400) { y = 70; }
                    Label lbl = new Label();
                    lbl.BringToFront(); //Añadido
                    lbl.AutoSize = true;
                    lbl.Location = new System.Drawing.Point(x, y);
                    lbl.Size = new System.Drawing.Size(40, 30);
                    lbl.Text = ArrayJ1[j].ToString();
                    lbl.ForeColor = Color.White;
                    lbl.BackColor = Color.Transparent;
                    lbl.Visible = true;
                    lbl.Enabled = true;
                    lbl.Font = new System.Drawing.Font("Consolas", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.Controls.Add(lbl);

                    x += 42;
                    y += 50;
                }
                x = 600;
            }

        }
        private void MovimientoPalabras()
        {
            
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    if (ctrl.Visible != false && ctrl.Enabled)
                    {
                        ctrl.Location = new Point(ctrl.Location.X - 1, ctrl.Location.Y);
                    }
                    if (ctrl.Enabled && ctrl.Visible != false)
                    {
                        if ((ctrl.Location.X + ctrl.Width) == (ctrl.Location.X + ctrl.Width) * -1)
                        {
                            fallo.Play();
                            fallos += 1;
                            lblFallosJ1.Text = "Fallos :" + fallos.ToString();
                            ctrl.Location = new Point(-800, 800);
                            ctrl.Visible = false;
                            ctrl.Enabled = false;
                            ctrl.Text = "";
                            
                        }
                    }

                }
            }

        }

        private void tmrJ1_Tick(object sender, EventArgs e)
        {
            if (ju.AprendeEscribiendo + fallos == totalPalabras)//Fin del juego
            {
                ArrayJ1.Clear();
                tmrJ1.Enabled = false;
                MessageBox.Show("Has fallado :" + fallos + "\n"
                    + "Has acertado :" + ju.AprendeEscribiendo);
                tmrJ1.Enabled = false;
                btnJ1VolverMenu.Visible = true;

            }
            MovimientoPalabras();//el juego transcurre
        }

        private void txtEntradaJ1_TextChanged(object sender, EventArgs e)
        {
             texto = txtEntradaJ1.Text;
             if (tmrJ1.Enabled == false)
             {
                    txtEntradaJ1.Enabled = false;
             }
             else { txtEntradaJ1.Enabled = true; }
             foreach (Control ctrl in this.Controls)
             {
                if (ctrl is Label)
                 {
                   if (ctrl.Text != "" && texto == ctrl.Text && ctrl.Visible != false)
                   {
                      acierto.Play();
                      ctrl.ForeColor = Color.Green;
                      ju.AprendeEscribiendo++;
                      lblAciertosJ1.Text = "Aciertos :" + ju.AprendeEscribiendo.ToString();
                      ctrl.Enabled = false;
                      ctrl.Location = new Point(-600, 600); //al acertar la palabra se desplazan fuera del form
                      ctrl.Visible = false;
                      txtEntradaJ1.Text = "";
                   }
                }
             }
        }

        private void btnJ1VolverMenu_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(Application.StartupPath + "/archivos/img/0.bmp");
            ArrayJ1.Clear();
            //Actualizacion de datos
            ActualizarBaseDatosJ1();
            //Borro los controles
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is Label)
                {
                    ctrl.Visible = false;
                }
            }
            //vuelvo a poner los controles del menu principal
           
            pnlJ1.Visible = false;
            txtEntradaJ1.Visible = false;
            MostrarMenu();
        }

        //-----------------------J2----------------------------------------------------
        private void btnJ2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(p.ToString());
            ruta = "/archivos/palabrasFlash.txt";
            BackColor = Color.DarkSeaGreen;
            Text = "Palabras Flash";
            //Inicializo vars
            p = 0;
            ju.PalabrasFlash = 0;
            rondaJ2 = 0;
            cronoJ2 = 10;
            palBusca = 0;
            lblRondaJ2.Text = "Ronda :" + rondaJ2.ToString();
            lblAciertosJ2.Text = "Aciertos :" + ju.PalabrasFlash.ToString();
            //
            BackgroundImage = null;
            LimpiarMenu();
            EmpezarJ2();
            lblInfoJ2.Visible = false;
            pnlJ2.Visible = true;
            tmrLLenarPalJ2.Enabled = true;
        }

        private void btnJ2_MouseEnter(object sender, EventArgs e)
        {
            lblInfoJ2.Visible = true;
            lblPuntuacionActualJ2.Text = "Tú puntuación: " + ju.PalabrasFlash;
            lblPuntuacionActualJ2.Visible = true;
        }

        private void btnJ2_MouseLeave(object sender, EventArgs e)
        {
            lblInfoJ2.Visible = false;
            lblPuntuacionActualJ2.Visible = false;
        }

        private void EmpezarJ2()
        {
            int x, y;
            int i, j;
            
            x = 50;
            y = 50;

            for (i = 0; i <5; i++)
            {
                for (j = 0; j <5; j++)
                {
                    Label lbl = new Label();
                    lbl.Size = new System.Drawing.Size(40, 60);
                    lbl.AutoSize = true;
                    lbl.Location = new System.Drawing.Point(x, y);
                    lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = Color.Purple;
                    lbl.Text = "";
                    lbl.Visible = true;
                    this.Controls.Add(lbl);
                    x += 150;
                   
                }
                x = 50;
                y += 60;
            }
        }
        
        private void LlenarPalsJ2()
        {
            
            //lleno los label existentes con una palabra
            string strPalabras = "";
            StreamReader ArchivoJ2 = new StreamReader(Application.StartupPath + ruta);
            ArrayList ArrayJ2 = new ArrayList();
            while (strPalabras != null)
            {
                strPalabras = ArchivoJ2.ReadLine();
                if (strPalabras != null)
                {

                    ArrayJ2.Add(strPalabras);
                }
            }
            ArchivoJ2.Close();

            foreach (Control ctrl in this.Controls)
            {

                if (ctrl is Label && ctrl.Visible == true
                    && ctrl.Name != "btnJ1" && ctrl.Name != "btnJ2"
                    && ctrl.Name != "btnJ3" && ctrl.Name!= "lblPuntuacionActualJ1"
                    && ctrl.Name != "lblPuntuacionActualJ2"
                    && ctrl.Name != "lblPuntuacionActualJ3" && ctrl.Name!= "lblJugadorAcitivo")
                {
                    try
                    {
                        ctrl.Text = ArrayJ2[p].ToString();
                    }
                    catch
                    {
                        p = 0;
                    }
                    
                    switch (color)
                    {
                        case 1:
                            ctrl.ForeColor = Color.Red;

                            break;
                        case 2:
                            ctrl.ForeColor = Color.Green;

                            break;
                        case 3:
                            ctrl.ForeColor = Color.Blue;

                            break;
                        case 4:
                            ctrl.ForeColor = Color.Black;

                            break;
                        case 5:
                            ctrl.ForeColor = Color.Purple;

                            break;
                        case 6:
                            ctrl.ForeColor = Color.Yellow;

                            break;
                        case 7:
                            ctrl.ForeColor = Color.Blue;

                            break;
                        case 8:
                            ctrl.ForeColor = Color.Red;

                            break;
                        case 9:
                            ctrl.ForeColor = Color.Yellow;

                            break;
                        case 10:
                            ctrl.ForeColor = Color.Black;

                            break;
                        case 11:
                            ctrl.ForeColor = Color.Purple;

                            break;
                        case 12:
                            ctrl.ForeColor = Color.Green;

                            color= 5;
                            break;
                    }
                    p++;
                    color++;
                }
            }

            //Generador de color aleatorio a buscar
            Random r = new Random();
            int aleat = r.Next(0, 14);
            switch (aleat)
            {
                case 1:
                    lblPalBuscarJ2.Text = "amarillo";
                    break;
                case 2:
                    lblPalBuscarJ2.Text = "azul";
                    break;
                case 3:
                    lblPalBuscarJ2.Text = "naranja";
                    break;
                case 4:
                    lblPalBuscarJ2.Text = "morado";
                    break;
                case 5:
                    lblPalBuscarJ2.Text = "verde";
                    break;
                case 6:
                    lblPalBuscarJ2.Text = "negro";
                    break;
                case 7:
                    lblPalBuscarJ2.Text = "amarillo";
                    break;
                case 8:
                    lblPalBuscarJ2.Text = "azul";
                    break;
                case 9:
                    lblPalBuscarJ2.Text = "naranja";
                    break;
                case 10:
                    lblPalBuscarJ2.Text = "verde";
                    break;
                case 11:
                    lblPalBuscarJ2.Text = "rojo";
                    break;
                case 12:
                    lblPalBuscarJ2.Text = "morado";
                    break;
                case 13:
                    lblPalBuscarJ2.Text = "negro";
                    break;

            }

            //cuenta cantidad de controles con el mismo nombre que label y la pone en el label de palabras a buscar()
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Label && ctrl.Visible && ctrl.Name != "btnJ1" && ctrl.Name != "btnJ2"
                    && ctrl.Name != "btnJ3" && ctrl.Name != "lblPuntuacionActualJ1"
                    && ctrl.Name != "lblPuntuacionActualJ2"
                    && ctrl.Name != "lblPuntuacionActualJ3" && ctrl.Name != "lblJugadorAcitivo")
                {
                    if (ctrl.Text == lblPalBuscarJ2.Text && ctrl.Visible == true)
                    {
                        palBusca++;
                        lblContadorPalJ2.Text = palBusca.ToString();
                    }
                }
            }
            
            tmrCronoJ2.Enabled = true;
            tmrLLenarPalJ2.Enabled = false;
            txtIntroJ2.Enabled = false;
          
        }

        private void tmrCronoJ2_Tick(object sender, EventArgs e)
        {
            lblCronoJ2.Text = "Tiempo :" + cronoJ2;
            cronoJ2--;
            if (rondaJ2 == 5) //rondas 
            {
                if (ju.PalabrasFlash < 0) { ju.PalabrasFlash = 0; lblAciertosJ2.Text = "Aciertos :" + ju.PalabrasFlash; }
                btnJ2VolverMenu.Visible = true;
                tmrCronoJ2.Enabled = false;
                txtIntroJ2.Enabled = false;
                MessageBox.Show("Has conseguido :" + ju.PalabrasFlash.ToString()+" aciertos");
            }
            if (cronoJ2 == -1)
            {
                tmrCronoJ2.Enabled = false;
                txtIntroJ2.Enabled = true;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Label)
                    {
                        ctrl.Visible = false;
                    }
                }
            }
        }

        private void txtIntroJ2_TextChanged(object sender, EventArgs e)
        {
            Random pAleat = new Random();
            int a = pAleat.Next(0,13); 
            strCompruebaJ2 = txtIntroJ2.Text;
            
            if (strCompruebaJ2 == lblContadorPalJ2.Text.ToString() && strCompruebaJ2 != "") //Lo compara con el recuento de palabras solicitado
            {
                acierto.Play();
                ju.PalabrasFlash++;
                lblAciertosJ2.Text = "Aciertos :" + ju.PalabrasFlash.ToString();
                rondaJ2++;
                txtIntroJ2.Enabled = false;
                txtIntroJ2.Text = "";
                foreach (Control ctrl in this.Controls)
                {
                   if (ctrl is Label && ctrl.Text!="" && ctrl.Name!= "lblInfoJ1"
                        &&ctrl.Name!= "lblInfoJ2" && ctrl.Name!="lblInfoJ3"
                        && ctrl.Name != "lblPuntuacionActualJ1"
                        && ctrl.Name != "lblPuntuacionActualJ2"
                        && ctrl.Name != "lblPuntuacionActualJ3" && ctrl.Name != "lblJugadorAcitivo")
                    {
                      ctrl.Visible = true;
                      tmrLLenarPalJ2.Enabled = true;
                      cronoJ2 = 10;
                      palBusca = 0;
                      lblRondaJ2.Text = "Ronda :" + rondaJ2.ToString();
                   }
                }
                p = a;//Cuando introdice el usuario datos,genero otro numero aleatorio
               

            }

           if (strCompruebaJ2 != lblContadorPalJ2.Text.ToString() && strCompruebaJ2 !="")
            {
               fallo.Play();
                ju.PalabrasFlash--;
               lblAciertosJ2.Text = "Aciertos :" + ju.PalabrasFlash.ToString();
                rondaJ2++;
               txtIntroJ2.Enabled = false;
               txtIntroJ2.Text = "";

               foreach (Control ctrl in this.Controls)
               {
                  if (ctrl is Label && ctrl.Text != "" && ctrl.Name != "lblInfoJ1"
                        && ctrl.Name != "lblInfoJ2" && ctrl.Name != "lblInfoJ3"
                        && ctrl.Name != "lblPuntuacionActualJ1"
                        && ctrl.Name != "lblPuntuacionActualJ2"
                        && ctrl.Name != "lblPuntuacionActualJ3" && ctrl.Name != "lblJugadorAcitivo")
                  {
                     ctrl.Visible = true;
                     tmrLLenarPalJ2.Enabled = true;
                     cronoJ2 = 10;
                     palBusca = 0;
                     lblRondaJ2.Text = "Ronda :"+ rondaJ2.ToString();
                  }
               }
                p = a;
            }
                
        }

        private void tmrLLenarPalJ2_Tick(object sender, EventArgs e)
        {
            LlenarPalsJ2();
        }

        private void btnJ2VolverMenu_Click(object sender, EventArgs e)
        {
            ActualizarBaseDatosJ2();
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is Label && ctrl.Visible)
                {
                    ctrl.Text = "";
                    ctrl.Visible = false;
                }
            }
            pnlJ2.Visible = false;
            BackgroundImage = Image.FromFile(Application.StartupPath + "/archivos/img/0.bmp");
            //
            MostrarMenu();
           //
        }

        //-----------------------J3----------------------------------------------------

        private void btnJ3_Click(object sender, EventArgs e)
        {
            ruta = "/archivos/J3.txt";
            ju.EncuentraLaPalabra = 0;
            cronoJ3 = 5;
            rondaJ3 = 0;
            BackgroundImage = null;
            BackColor = Color.White;
            Text = "Encuentra la palabra";
            lblAciertosJ3.Text = "Aciertos :" + ju.EncuentraLaPalabra;
            pnlJ3.Visible = true;
            //
            LimpiarMenu();
            //
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is Button && ctrl.Name!= "btnJ1" && ctrl.Name != "btnJ2"
                     && ctrl.Name != "btnJ3" && ctrl.Text != "Puntuaciones")
                {
                    ctrl.Visible = true;
                }
            }
            tmrNuevaPartidaJ3.Enabled = true;
        }
        private void btnJ3_MouseEnter(object sender, EventArgs e)
        {
            lblInfoJ3.Visible = true;
            lblPuntuacionActualJ3.Text = "Tú puntuación: " + ju.EncuentraLaPalabra;
            lblPuntuacionActualJ3.Visible = true;
        }

        private void btnJ3_MouseLeave(object sender, EventArgs e)
        {
            lblInfoJ3.Visible = false;
            lblPuntuacionActualJ3.Visible = false;
        }
        public void GeneraEncunetraPal()
        {
            int x, y;
            int i, j;
            x = 44;
            y = 122;
            int pal = 0;
            
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Button btn = new Button();
                    btn.UseVisualStyleBackColor = true;
                    btn.AutoSize = true;
                    btn.Location = new System.Drawing.Point(x, y);
                    btn.BackColor = Color.White;
                    btn.Size = new System.Drawing.Size(113, 63);
                    btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.Text = "";
                    pal++;
                    btn.Visible = false;
                    btn.Enabled = true;
                    btn.Click += new System.EventHandler(btnJuego);
                    this.Controls.Add(btn);
                    x += 200;
                }
                x = 44;
                y += 79;
            }
        }
        private void btnJuego(object sender, EventArgs e)
        {
            Button pinchado = (Button)sender;
            if (pinchado.Text == lblPalBuscarJ3.Text)
            {
                acierto.Play();
                ju.EncuentraLaPalabra++;
                lblAciertosJ3.Text = "Aciertos :" + ju.EncuentraLaPalabra;
                pinchado.BackColor = Color.Green;
                pinchado.Enabled = false;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button && ctrl.Text != lblPalBuscarJ3.Text)
                    { //el boton correcto lo dejo visivle por pantalla
                        ctrl.Visible = false;
                    }
                }
            }
            else
            {
                fallo.Play();
                ju.EncuentraLaPalabra--;
                lblAciertosJ3.Text = "Aciertos :" + ju.EncuentraLaPalabra;
                lblAvisoJ3.Text = "!ERROR, Prueba otra vez!";
                pinchado.Enabled = false;
                pinchado.BackColor = Color.Red;
            }

        }

        private void tmrCronoJ3_Tick(object sender, EventArgs e)
        {
           
            if (cronoJ3 >= 0)
            {
                cronoJ3--;
                lblCronoJ3.Text ="Tiempo :" +cronoJ3.ToString() + "S";
            }

            if (cronoJ3 == 0)
            {
                rondaJ3++;
                lblAvisoJ3.Text = "";
                tmrNuevaPartidaJ3.Enabled = true;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button && ctrl.Name != "btnJ1" && ctrl.Name != "btnJ2"
                    && ctrl.Name != "btnJ3" && ctrl.Text != "Puntuaciones")
                    {
                        ctrl.Text = "";
                    }
                }

            }
        }

        private void tmrNuevaPartidaJ3_Tick(object sender, EventArgs e)
        {
            cronoJ3 = 6;
            NuevaPartidaJ3();
            tmrNuevaPartidaJ3.Enabled = false;
        }

        public void NuevaPartidaJ3()
        {
            Random aleat = new Random();
            int a = aleat.Next(0, 16);
            //Busca entre el txt la palabra y aleatoriamente se elige una
            string strPalabras = "";
            StreamReader ArchivoTexto = new StreamReader(Application.StartupPath + ruta);
            ArrayList ArrayPalabra = new ArrayList();
            while (strPalabras != null)
            {
                strPalabras = ArchivoTexto.ReadLine();
                if (strPalabras != null)
                {
                    ArrayPalabra.Add(strPalabras);
                }
            }
            ArchivoTexto.Close();
            lblPalBuscarJ3.Text = ArrayPalabra[pal + a].ToString();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Name!= "btnJ1" && ctrl.Name != "btnJ2"
                    && ctrl.Name != "btnJ3" && ctrl.Text != "Puntuaciones")
                {
                    try
                    {
                        if (pal >= 103) { pal = 16; }//devuelvo la variable a este valor,porque el txt es finito
                        ctrl.Text = ArrayPalabra[pal].ToString();
                    }
                    catch
                    {
                        pal = 8;
                    }
                    pal++;
                    ctrl.BackColor = Color.White;
                    ctrl.Visible = true;
                    ctrl.Enabled = true;
                }
            }
            tmrCronoJ3.Enabled = true;
        }

        private void btnJ3VolverMenu_Click(object sender, EventArgs e)
        {
            if (ju.EncuentraLaPalabra < 0) { ju.EncuentraLaPalabra = 0; lblAciertosJ3.Text = "Aciertos :" + ju.EncuentraLaPalabra; }
            //Actualizo datos en la base de datos
            ActualizarBaseDatosJ3();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Name != "btnJ1" && ctrl.Name != "btnJ2"
                    && ctrl.Name != "btnJ3" && ctrl.Text!= "Puntuaciones")
                {
                    ctrl.Text = "";
                    ctrl.Visible = false;
                }
            }
            BackgroundImage = Image.FromFile(Application.StartupPath + "/archivos/img/0.bmp");
            pnlJ3.Visible = false;
            tmrCronoJ3.Enabled = false;
            tmrNuevaPartidaJ3.Enabled = false;

            MostrarMenu();
           
        }
        //----------------DATOS USUARIO//Gestion de puntuaciones-----------------------------------

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if (txtEntradaUsuario.Text.Trim() != "") //condicion que se  ejecuta cuando el input está lleno
            {
                ComprobarNickExiste();
                if (comprueba == "0") //si no existe
                {
                    ju.Nick = txtEntradaUsuario.Text;
                    GuardarBaseDatos();
                    lblJugadorAcitivo.Text = "Está Jugando : " + ju.Nick;
                    pnlDatosUsuario.Visible = false;
                    MostrarMenu();
                }
                else { lblAvisoDatoUsuario.Visible = true; lblAvisoDatoUsuario.Text = "*Nick existente,prueba con otro."; }
            }
            else { lblAvisoDatoUsuario.Visible = true; lblAvisoDatoUsuario.Text = "*Introduce un nick"; }
            
        }

        private void GuardarBaseDatos()
        {
            foreach (Control ctrl in this.Controls) //si encuentra este caracteer,en la consulta lo cambia a un valor qeu admita
            {
                if (ctrl is TextBox && ctrl.Name == "txtEntradaUsuario")
                {
                    if (ctrl.Text.Contains("'"))
                    {

                        ctrl.Text = ctrl.Text.Replace("'", "\'");

                    }
                }
            }
            string strQuery = "INSERT INTO puntuaciones(AprendeEscribiendo,PalabrasFlash,EncuentraLaPalabra,Nick)"
           +"VALUES ('" + ju.AprendeEscribiendo+ "','" + ju.PalabrasFlash+ "','" + ju.EncuentraLaPalabra+ "','" + ju.Nick + "')";
            MySqlConnection conexion = new MySqlConnection("Server=" + strServer +
            ";Database=" + strBD + ";Uid=" + strUser + ";Pwd='" + strPwd + "';");

            MySqlCommand comando = new MySqlCommand(strQuery, conexion);
            //Se abre y se cierra la base de datos
            //if (conexion.State != ConnectionState.Open) { TextoPlanoNcik(); } //si la base de datos no estña abierta lo guarda en txt
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Clone(); }
            }

        }

        private void ActualizarBaseDatosJ1()
        {
            //update puntuaciones set AprendeEscribiendo = '1', PalabrasFlash = '5', EncuentraLaPalabra = '8', Nick = 'JULIO'
            //where Nick = 'blo';
            string strQuery = "UPDATE puntuaciones Set AprendeEscribiendo='" + ju.AprendeEscribiendo +
                "'WHERE Nick='" + ju.Nick + "';";
            MySqlConnection conexion = new MySqlConnection("Server=" + strServer +
            ";Database=" + strBD + ";Uid=" + strUser + ";Pwd='" + strPwd + "';");
            MySqlCommand comando = new MySqlCommand(strQuery, conexion);

            if(conexion.State != ConnectionState.Open)
            {
                //Poner la Puntuacion en txt
            }
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Clone(); }
            }

        }

        private void ActualizarBaseDatosJ2()
        {
            //update puntuaciones set AprendeEscribiendo = '1', PalabrasFlash = '5', EncuentraLaPalabra = '8', Nick = 'JULIO'
            //where Nick = 'blo';
            string strQuery = "UPDATE puntuaciones Set PalabrasFlash='" + ju.PalabrasFlash +
                "'WHERE Nick='" + ju.Nick + "';";
            MySqlConnection conexion = new MySqlConnection("Server=" + strServer +
            ";Database=" + strBD + ";Uid=" + strUser + ";Pwd='" + strPwd + "';");
            MySqlCommand comando = new MySqlCommand(strQuery, conexion);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Clone(); }
            }

        }

        private void ActualizarBaseDatosJ3()
        {
            
            string strQuery = "UPDATE puntuaciones Set EncuentraLaPalabra='" + ju.EncuentraLaPalabra +
                "'WHERE Nick='" + ju.Nick + "';";
            MySqlConnection conexion = new MySqlConnection("Server=" + strServer +
            ";Database=" + strBD + ";Uid=" + strUser + ";Pwd='" + strPwd + "';");
            MySqlCommand comando = new MySqlCommand(strQuery, conexion);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Clone(); }
            }

        }

        private void ComprobarNickExiste()
        {
            string strQuery = "Select COUNT(*) FROM puntuaciones WHERE Nick Like '%" + txtEntradaUsuario.Text + "%'";
           
            MySqlConnection conexion = new MySqlConnection("Server=" + strServer +
            ";Database=" + strBD + ";Uid=" + strUser + ";Pwd='" + strPwd + "';");

            MySqlCommand comando = new MySqlCommand(strQuery, conexion);
          
            //Se abre y se cierra la base de datos
            try
            {
                conexion.Open();
                comprueba = comando.ExecuteScalar().ToString();
                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (conexion.State == ConnectionState.Open) { conexion.Clone(); }
            }


        }
        
        private void btnMostrarPuntuaciones_Click(object sender, EventArgs e)
        {
            string strQuery = "SELECT AprendeEscribiendo,PalabrasFlash,EncuentraLaPalabra,Nick FROM puntuaciones ";
            string conex = "Server=" + strServer +
               ";Database=" + strBD + ";Uid=" + strUser + ";Pwd='" + strPwd + "';";
            if (!dgvPuntuaciones.Visible) {
                btnMostrarPuntuaciones.Text = "VOLVER";
                dgvPuntuaciones.Visible = true;

                MySqlConnection conexion = new MySqlConnection("Server=" + strServer +
                ";Database=" + strBD + ";Uid=" + strUser + ";Pwd='" + strPwd + "';");
                MySqlDataAdapter adaptador = new MySqlDataAdapter(strQuery,conex);

                MySqlCommandBuilder sq = new MySqlCommandBuilder(adaptador);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                dgvPuntuaciones.ReadOnly = true;
                dgvPuntuaciones.DataSource = ds.Tables[0];

            }

            else { dgvPuntuaciones.Visible = false; btnMostrarPuntuaciones.Text = "Puntuaciones"; }
        }

        //-----------------------Métodos para ocultar y mostrar los elementos del menú----------------------

        private void LimpiarMenu()
        {
            lblJugadorAcitivo.Visible = false;
            btnJ1.Visible = false;
            btnJ2.Visible = false;
            btnJ3.Visible = false;
            btnMostrarPuntuaciones.Visible = false;
        }

        private void MostrarMenu()
        {
            lblJugadorAcitivo.Visible = true;
            btnJ1.Visible = true;
            btnJ2.Visible = true;
            btnJ3.Visible = true;
            btnMostrarPuntuaciones.Visible = true;
            Text = "Entrenamiento Cognitivo y Más";
        }

        private void CargarImagenes()
        {
            BackgroundImage = Image.FromFile(Application.StartupPath + "/archivos/img/0.bmp");
            btnJ1.Image = Image.FromFile(Application.StartupPath + "/archivos/img/btn.bmp");
            btnJ2.Image = Image.FromFile(Application.StartupPath + "/archivos/img/btn.bmp");
            btnJ3.Image = Image.FromFile(Application.StartupPath + "/archivos/img/btn.bmp");
            btnMostrarPuntuaciones.Image = Image.FromFile(Application.StartupPath + "/archivos/img/btn.bmp");
            pnlJ1.BackgroundImage = Image.FromFile(Application.StartupPath + "/archivos/img/pnl1.bmp");
            pnlJ2.BackgroundImage = Image.FromFile(Application.StartupPath + "/archivos/img/pnl2.bmp");
            pnlJ3.BackgroundImage = Image.FromFile(Application.StartupPath + "/archivos/img/pnl3.bmp");

        }

    }
}
