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

namespace controle_de_sécurité
{
    public partial class Form1 : Form
    {
       
     
        private SerialPort rs232;
    
        private delegate void msgDelegate(byte[] b);
        private msgDelegate showReceivedMessage;
       





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rs232 = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);

            this.rs232.ReceivedBytesThreshold = 3;

            this.rs232.DataReceived += rs232_DataReceived;

           
            

            try
            {
                this.rs232.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rs232_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Byte[] msg = new Byte[3];
            for (int i = 0; i < 3; i++)
            {
                msg[i] = Convert.ToByte(this.rs232.ReadByte());



            }

            this.showReceivedMessage = new msgDelegate(showMsg);
            this.Invoke(showReceivedMessage, msg);


        }



        private void showMsg(byte[] b)
        {
             
          
            //0 = FENETRE , 1 = PORTE = 2= DETECTEUR M 3=DETECTEUR INCENDIE
            if(b[0]==0)
            {
              
                if (b[1] == 0)
                {
                   
                    if (b[2] == 1)
                    {
                        F1.BackColor = Color.Red;

                       
                    }
                    else
                    {
                        F1.BackColor = Color.White;

                        //Uncapteur.status = "non actif";
                        //Uncapteur.dateT = DateTime.Now;
                        //MaSecurite.capteurs.Add(Uncapteur);
                       
                    }
                   
                  
                }
                else if(b[1] == 1)
                {
                    if (b[2] == 1)
                    {
                        F2.BackColor = Color.Red;
                    }
                    else
                    {
                        F2.BackColor = Color.White;
                    }
                }
                else if (b[1] == 2)
                {
                    if (b[2] == 1)
                    {
                        F3.BackColor = Color.Red;
                    }
                    else
                    {
                        F3.BackColor = Color.White;
                    }
                }
                else if (b[1] == 3)
                {
                    if (b[2] == 1)
                    {
                        F4.BackColor = Color.Red;
                    }
                    else
                    {
                        F4.BackColor = Color.White;
                    }
                }




            }
            else if(b[0]==1)
            {
                if (b[1] == 0)
                {
                    if (b[2] == 1)
                    {
                        P1.BackColor = Color.Red;
                    }
                    else
                    {
                        P1.BackColor = Color.White;
                    }
                }
                else if (b[1] == 1)
                {
                    if (b[2] == 1)
                    {
                        P2.BackColor = Color.Red;
                    }
                    else
                    {
                        P2.BackColor = Color.White;
                    }
                }
                else if (b[1] == 2)
                {
                    if (b[2] == 1)
                    {
                        P3.BackColor = Color.Red;
                    }
                    else
                    {
                        P3.BackColor = Color.White;
                    }
                }
            }
            else if (b[0] == 2)
            {
                if (b[1] == 0)
                {
                    if (b[2] == 1)
                    {
                        DM1.BackColor = Color.Red;
                    }
                    else
                    {
                        DM1.BackColor = Color.White;
                    }
                }
            }
            else
            {
                if (b[1] == 0)
                {
                    if (b[2] == 1)
                    {
                        DI1.BackColor = Color.Red;
                    }
                    else
                    {
                        DI1.BackColor = Color.White;
                    }
                }
            }
           

        }

        private void F4_Click(object sender, EventArgs e)
        {

        }
    }
}
