using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections;



namespace Maison
{
    public partial class Form1 : Form
    {
        static securiteBDEntities MaSecurite;
        static Capteur unCapteur;
        private SerialPort myComPort;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'securiteBDDataSet.Capteurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.capteursTableAdapter.Fill(this.securiteBDDataSet.Capteurs);
            MaSecurite = new securiteBDEntities();
            unCapteur = new Capteur();
            unCapteur.dateT = DateTime.Now;
            unCapteur.status = "ouverture de la console ";

            MaSecurite.Capteurs.Add(unCapteur);
            MaSecurite.SaveChanges();
             grpHistorique.Visible = false;

            //var table = MaSecurite.Set<Capteur>();
            //table.RemoveRange(table);
            //MaSecurite.SaveChanges();
         

            string[] myPortList = SerialPort.GetPortNames();
            string a = " ";
            Array.Sort(myPortList);
            string b = "";
            status.Text = " COM1 est  ouvert...";


            try
            {

                myComPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
                this.myComPort.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void F1_Click(object sender, EventArgs e)
        {
            unCapteur = new Capteur();

            Byte[] dataToSend = new Byte[3];

            dataToSend[0] = 0;
            dataToSend[1] = 0;
            if (F1.BackColor == Color.White)
            {
                dataToSend[2] = 1;
                unCapteur.type = "fenetre";
                unCapteur.id = "1";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = "fenetre 1 activee";

                F1.BackColor = Color.Red;

                MaSecurite.Capteurs.Add(unCapteur);
            }
            else
            {
                dataToSend[2] = 0;
                unCapteur.type = "fenetre";
                unCapteur.id = "1";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = "fenetre 1 deactivee";

                F1.BackColor = Color.White;

                MaSecurite.Capteurs.Add(unCapteur);
            }

         


            MaSecurite.SaveChanges();


            //byte[] dataToSend = new byte[3];

            //dataToSend[0] = Convert.ToByte("87");
            //dataToSend[1] = Convert.ToByte("87");
            //dataToSend[2] = Convert.ToByte("87");
            myComPort.Write(dataToSend, 0, 3);
        }

        private void F2_Click(object sender, EventArgs e)
        {
            unCapteur = new Capteur();


            Byte[] dataToSend = new Byte[3];

            dataToSend[0] = 0;
            dataToSend[1] = 1;
            if (F2.BackColor == Color.White)
            {
                
                dataToSend[2] = 1;
                unCapteur.type = "fenetre";
                unCapteur.id = "2";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " fenetre 2 activee ";
                F2.BackColor = Color.Red;
                MaSecurite.Capteurs.Add(unCapteur);
            }
            else
            {
                
                dataToSend[2] = 0;
                unCapteur.type = "fenetre";
                unCapteur.id = "2";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " fenetre 2 desactivee ";
                F2.BackColor = Color.White;
                MaSecurite.Capteurs.Add(unCapteur);
            }
            MaSecurite.SaveChanges();
            myComPort.Write(dataToSend, 0, 3);
        }

        private void F3_Click(object sender, EventArgs e)
        {
            unCapteur = new Capteur();
            byte[] dataToSend = new byte[3];

            dataToSend[0] = 0;
            dataToSend[1] = 2;
            if (F3.BackColor == Color.Red) 
            {
                F3.BackColor = Color.White;
                dataToSend[2] = 0;

                unCapteur.type = "fenetre";
                unCapteur.id = "3";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " fenetre 3 desactivee ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            else
            {
                F3.BackColor = Color.Red;
                dataToSend[2] = 1;

                unCapteur.type = "fenetre";
                unCapteur.id = "3";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " fenetre 3 activee ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            MaSecurite.SaveChanges();
            myComPort.Write(dataToSend, 0, 3);
        }

        private void F4_Click(object sender, EventArgs e)
        {
            unCapteur = new Capteur();

            Byte[] dataToSend = new Byte[3];
            
            dataToSend[0] = 0;
            dataToSend[1] = 3;
            if (F4.BackColor == Color.Red)
            {
                F4.BackColor = Color.White;
                dataToSend[2] = 0;
                unCapteur.type = "fenetre";
                unCapteur.id = "4";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " fenetre 4 desactivee ";
                MaSecurite.Capteurs.Add(unCapteur);


            }
            else
            {
                F4.BackColor = Color.Red;
                dataToSend[2] = 1;

                unCapteur.type = "fenetre";
                unCapteur.id = "4";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " fenetre 4 activee ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            MaSecurite.SaveChanges();
            myComPort.Write(dataToSend, 0, 3);
        }

        private void P1_Click(object sender, EventArgs e)
        {
           

            unCapteur = new Capteur();

            byte[] dataToSend = new byte[3];

            dataToSend[0] = 1;
            dataToSend[1] = 0;
            if (P1.BackColor == Color.Red)
            {
                P1.BackColor = Color.White;
                dataToSend[2] = 0;

                unCapteur.type = "porte";
                unCapteur.id = "1";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " porte 1 desactivee ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            else
            {
                P1.BackColor = Color.Red;
                dataToSend[2] = 1;
                unCapteur.type = "porte";
                unCapteur.id = "1";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " porte 1 activee ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            MaSecurite.SaveChanges();
            myComPort.Write(dataToSend, 0, 3);
        }

        private void P2_Click(object sender, EventArgs e)
        {
            unCapteur = new Capteur();
            byte[] dataToSend = new byte[3];

            dataToSend[0] = 1;
            dataToSend[1] = 1;
            if (P2.BackColor == Color.Red)
            {
                P2.BackColor = Color.White;
                dataToSend[2] = 0;

                unCapteur.type = "porte";
                unCapteur.id = "2";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " porte 2 desactivee ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            else
            {
                P2.BackColor = Color.Red;
                dataToSend[2] = 1;

                unCapteur.type = "porte";
                unCapteur.id = "2";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " porte 2 activee ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            MaSecurite.SaveChanges();
            myComPort.Write(dataToSend, 0, 3);
        }

        private void P3_Click(object sender, EventArgs e)
        {
            unCapteur = new Capteur();

            byte[] dataToSend = new byte[3];

            dataToSend[0] = 1;
            dataToSend[1] = 2;
            if (P3.BackColor == Color.Red)
            {
                P3.BackColor = Color.White;
                dataToSend[2] = 0;

                unCapteur.type = "porte";
                unCapteur.id = "3";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " porte 3 desactivee ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            else
            {
                P3.BackColor = Color.Red;
                dataToSend[2] = 1;
                unCapteur.type = "porte";
                unCapteur.id = "3";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " porte 3 activee ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            MaSecurite.SaveChanges();
            myComPort.Write(dataToSend, 0, 3);
        }

        private void DM1_Click(object sender, EventArgs e)
        {

            unCapteur = new Capteur();
            byte[] dataToSend = new byte[3];
  

            dataToSend[0] = 2;
            dataToSend[1] = 0;
            if (DM1.BackColor == Color.Red)
            {
                DM1.BackColor = Color.White;
                dataToSend[2] = 0;

                unCapteur.type = "detecteur Mouvement ";
                unCapteur.id = "1";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " detecteur Mouv 1 desactive ";

                MaSecurite.Capteurs.Add(unCapteur);
            }
            else
            {
                DM1.BackColor = Color.Red;
                dataToSend[2] = 1;

                unCapteur.type = "detecteur Mouvement ";
                unCapteur.id = "1";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " detecteur Mouv 1 active ";
                MaSecurite.Capteurs.Add(unCapteur);
            }
            MaSecurite.SaveChanges();
            myComPort.Write(dataToSend, 0, 3);
        }

        private void cboPort_Click(object sender, EventArgs e)
        {

        }

        private void btnSplit_ButtonClick(object sender, EventArgs e)
        {
            

            
        }

      

        private void DI1_Click(object sender, EventArgs e)
        {
            unCapteur = new Capteur();
            byte[] dataToSend = new byte[3];

            dataToSend[0] = 3;
            dataToSend[1] = 0;
            if(DI1.BackColor == Color.Red)
            {

                dataToSend[2] = 0;

                unCapteur.type = "detecteur Incendie ";
                unCapteur.id = "1";
                unCapteur.dateT = DateTime.Now;
               
                unCapteur.status = " detecteur Inc 1 desactivee ";
                MaSecurite.Capteurs.Add(unCapteur);

                DI1.BackColor = Color.White;

            }
            else
            {
                dataToSend[2] = 0;
                unCapteur.type = "detecteur Incendie ";
                unCapteur.id = "1";
                unCapteur.dateT = DateTime.Now;
                unCapteur.status = " detecteur Inc 1 activee ";
                MaSecurite.Capteurs.Add(unCapteur);
                DI1.BackColor = Color.Red;
            }


          
            MaSecurite.SaveChanges();
            myComPort.Write(dataToSend, 0, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grpHistorique.Visible == false)
            {
                grpHistorique.Visible = true;
            }
            else if (grpHistorique.Visible == true)
            {
                grpHistorique.Visible = false;
            }


           

            var test = MaSecurite.Capteurs
                .OrderByDescending(enregistrement => enregistrement.dateT)
                .Take(10)
                .ToList();
            lstHist.Items.Clear();





           
            var histo = (from Capteur cap in MaSecurite.Capteurs
                         select new { stat = cap.status, dateN = cap.dateT });


            var lhisto = histo.ToList();

            //version boucle



            foreach (Capteur capteur in MaSecurite.Capteurs)
            {

                lstHist.Items.Add(capteur.dateT + "   " + capteur.status);


            }




        }

        private void lstHist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
