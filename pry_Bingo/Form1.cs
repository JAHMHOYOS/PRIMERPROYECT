using pry_Bingo.Bmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnGardar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtentrada.Text);

            switch (valor)
            {

                case 1:
                    btn1c.BackColor = Color.Red;
                    btn1d.BackColor = Color.Red;
                    btn1e.BackColor = Color.Red;
                    btn1f.BackColor = Color.Red;

                    break;
                case 2:
                    btn2.BackColor = Color.Red;
                    btn2d.BackColor = Color.Red;
                    btn2h.BackColor = Color.Red;

                    break;
                case 3:
                    btn3f.BackColor = Color.Red;
                    btn3h.BackColor = Color.Red;

                    break;
                case 4:
                    btn4b.BackColor = Color.Red;
                    btn4f.BackColor = Color.Red;
                    btn4g.BackColor = Color.Red;
                    btn4h.BackColor = Color.Red;

                    break;
                case 5:
                    btn5b.BackColor = Color.Red;
                    btn5c.BackColor = Color.Red;
                    btn5e.BackColor = Color.Red;

                    break;
                case 7:

                    btn7.BackColor = Color.Red;
                    btn7c.BackColor = Color.Red;
                    break;
                case 8:
                    btn8.BackColor = Color.Red;
                    btn8g.BackColor = Color.Red;
                    break;
                case 9:
                    btn9b.BackColor = Color.Red;
                    btn9e.BackColor = Color.Red;
                    btn9g.BackColor = Color.Red;
                    break;
                case 10:
                    btn10c.BackColor = Color.Red;
                    btn10d.BackColor = Color.Red;
                    btn10g.BackColor = Color.Red;
                    btn10h.BackColor = Color.Red;
                    break;
                case 11:
                    
                    break;
                case 12:
                    btn12b.BackColor = Color.Red;
                    btn12d  .BackColor= Color.Red;
                    break;

                case 13:
                    btn13.BackColor = Color.Red;
                    btn13b.BackColor = Color.Red;
                    btn13d.BackColor= Color.Red;
                    btn13e.BackColor = Color.Red;
                    btn13f.BackColor = Color.Red;
                    btn13h.BackColor = Color.Red;
                    break;

                case 14:
                    btn14.BackColor = Color.Red;
                    btn14c.BackColor = Color.Red;
                    btn14e.BackColor = Color.Red;
                    btn14f.BackColor= Color.Red;
                    break;

                case 15:
                    btn15g.BackColor = Color.Red;
                    break;

                case 16:
                    btn16.BackColor = Color.Red;
                    btn16h.BackColor= Color.Red;
                    break;

                case 17:
                    btn17d.BackColor = Color.Red;
                    btn17g.BackColor = Color.Red;
                    btn17h.BackColor = Color.Red;
                    break;
                case 18:
                    btn18.BackColor = Color.Red;
                    btn18b.BackColor= Color.Red;    
                    btn18c.BackColor= Color.Red;
                    btn18d.BackColor=Color.Red;
                    btn18e.BackColor= Color.Red;
                    btn18h.BackColor= Color.Red;
                    break;
                case 19:
                    btn19f.BackColor = Color.Red;
                    btn19e.BackColor=Color.Red;
                    break;
                case 20:
                    btn20d.BackColor = Color.Red;
                   
                    break;
                case 21:
                    btn21c.BackColor = Color.Red;
                    btn21f.BackColor = Color.Red;
                    btn21g.BackColor = Color.Red;
                    break;
                case 22:
                    btn22b.BackColor = Color.Red;
                    btn22c.BackColor=Color.Red;
                    
                    break;

                case 23:
                    btn23.BackColor = Color.Red;
                    btn23e.BackColor = Color.Red;
                    btn23f.BackColor= Color.Red;
                    btn22g.BackColor= Color.Red;
                    break;
                case 24:
                    btn24b.BackColor = Color.Red;
                    btn24f.BackColor= Color.Red;
                    break;
                case 25:
                    btn25.BackColor = Color.Red;
                    btn25g.BackColor = Color.Red;
                    btn25d.BackColor= Color.Red;
                    break;
                case 26:
                    btn26b.BackColor = Color.Red;
                    btn26g.BackColor= Color.Red;
                    break;
                case 27:
                    btn27b.BackColor = Color.Red;
                    btn27f.BackColor=Color.Red;
                    btn27h.BackColor=Color.Red;
                    break;

                case 28:
                    btn28.BackColor = Color.Red;
                    btn28e.BackColor = Color.Red;
                    
                    break;
                case 29:
                    btn29b.BackColor = Color.Red;
                    btn29c.BackColor = Color.Red;
                    btn29d.BackColor = Color.Red;
                    btn29e.BackColor = Color.Red;
                    btn29h.BackColor = Color.Red;
                    break;
                case 30:
                    
                    break;
                case 31:
                    btn31g.BackColor = Color.Red;
                    break;
                case 32:
                    btn32d.BackColor = Color.Red;
                    break;
                case 33:
                    btn33c.BackColor = Color.Red;
                    btn33f.BackColor = Color.Red;
                    break;

                case 34:
                    btn34.BackColor = Color.Red;
                    btn34b.BackColor = Color.Red;
                    btn34d.BackColor = Color.Red;
                    btn34g.BackColor = Color.Red;
                    break;
                case 35:
                    btn35c.BackColor = Color.Red;
                    btn35f.BackColor= Color.Red;
                    btn35g.BackColor= Color.Red;
                    btn35h.BackColor= Color.Red;
                    break;
                case 36:
                    btn36b.BackColor = Color.Red;
                    btn36e.BackColor = Color.Red;
                    btn36h.BackColor= Color.Red;
                    break;
                case 37:
                    btn37d.BackColor = Color.Red;
                    btn37h.BackColor= Color.Red;
                    break;
                case 38:
                    break;
                case 39:
                    btn39f.BackColor = Color.Red;
                    btn39g.BackColor= Color.Red;
                    btn39c.BackColor= Color.Red;
                    
                    break;

                case 40:
                    btn40.BackColor = Color.Red;
                    btn40b.BackColor= Color.Red;
                    btn40c.BackColor= Color.Red;
                    btn40e.BackColor= Color.Red;
                    btn40f.BackColor= Color.Red;
                    break;

                case 41:
                    btn41.BackColor = Color.Red;
                    btn41e.BackColor= Color.Red;
                    
                    break;
                case 42:
                    btn42d.BackColor = Color.Red;
                    break;
                case 43:
                    btn43h.BackColor = Color.Red;
                    break;
                case 44:
                    btn44b.BackColor = Color.Red;
                    btn44e.BackColor= Color.Red;
                    break;
                case 45:
                    btn45.BackColor = Color.Red;
                   
                    break;
                case 46:
                    btn46.BackColor = Color.Red;
                    btn46b.BackColor= Color.Red;
                    btn46c.BackColor= Color.Red;
                    btn46d.BackColor= Color.Red;
                    btn46h.BackColor= Color.Red;
                    break;
                case 47:
                    btn47.BackColor = Color.Red;
                    btn47c.BackColor= Color.Red;
                    btn47f.BackColor= Color.Red;
                    btn47g.BackColor= Color.Red;
                    
                    break;
                case 48:
                    btn48d.BackColor = Color.Red;
                    btn48h.BackColor = Color.Red;
                    btn48g.BackColor= Color.Red;
                    break;
                case 49:
                    btn49h.BackColor = Color.Red;
                    break;
                case 50:
                    btn50b.BackColor = Color.Red;
                    btn50c.BackColor= Color.Red;
                    btn50e.BackColor= Color.Red;
                    break;
                case 51:
                    
                    break;
                case 52:
                    btn52b.BackColor = Color.Red;
                    btn52e.BackColor= Color.Red;
                    break;
                case 53:
                   
                    break;
                case 54:
                    btn54d.BackColor = Color.Red;
                    btn54e.BackColor = Color.Red;
                    btn54g.BackColor = Color.Red;
                    break;

                case 55:
                    btn55.BackColor = Color.Red;
                    btn55b.BackColor = Color.Red;
                    btn55c.BackColor= Color.Red;
                    btn55f.BackColor= Color.Red;
                    break;


                case 56:
                    btn56.BackColor = Color.Red;
                    btn56h.BackColor = Color.Red;
                    break;
                case 57:
                    btn57f.BackColor = Color.Red;
                    btn57h.BackColor = Color.Red;
                    break;
                case 58:
                    btn58.BackColor = Color.Red;
                    btn58d.BackColor = Color.Red;
                    btn58e.BackColor = Color.Red;
                    btn58g.BackColor = Color.Red;
                    break;

                case 59:
                    btn59b.BackColor = Color.Red;
                    btn59c.BackColor = Color.Red;
                    btn59f.BackColor = Color.Red;
                    break;

                case 60:
                    btn60.BackColor = Color.Red;
                    btn60d.BackColor = Color.Red;
                    btn60f.BackColor = Color.Red;
                    btn60g.BackColor = Color.Red;
                    break;
                case 61:
                    btn61e.BackColor = Color.Red;
                    btn61g.BackColor = Color.Red;
                    btn61h.BackColor = Color.Red;
                    break;
                case 62:
                    btn62.BackColor = Color.Red;
                    btn62c.BackColor = Color.Red;
                    btn62d.BackColor = Color.Red;
                    btn62e.BackColor = Color.Red;
                    btn62g.BackColor = Color.Red;
                    break;


                case 63:
                    btn63.BackColor = Color.Red;
                    
                    break;
                case 64:
                    btn64b.BackColor = Color.Red;
                    btn64c.BackColor = Color.Red;
                    btn64h.BackColor = Color.Red;
                    break;
                case 65:
                    btn65f.BackColor = Color.Red;
                    break;
                case 66:
                    btn66f.BackColor = Color.Red;
                    btn66h.BackColor = Color.Red;
                    btn66g.BackColor = Color.Red;
                    break;
                case 67:
                    btn67e.BackColor = Color.Red;
                    btn67f.BackColor = Color.Red;
                    break;
                case 68:
                    btn68b.BackColor = Color.Red;
                    btn68g.BackColor = Color.Red;
                   
                    break;
                case 69:
                    btn69.BackColor = Color.Red;
                    btn69b.BackColor = Color.Red;
                    btn69e.BackColor = Color.Red;
                    btn69g.BackColor = Color.Red;
                    break;

                case 70:
                    btn70.BackColor = Color.Red;
                    btn70c.BackColor = Color.Red;
                    break;
                case 71:
                    btn71.BackColor = Color.Red;
                    btn71d.BackColor= Color.Red;
                    break;
                case 72:
                    btn72d.BackColor = Color.Red;
                    break;
                case 73:
                    btn73b.BackColor = Color.Red;
                    btn73d.BackColor = Color.Red;
                    btn73h.BackColor = Color.Red;
                    break;
                case 74:
                    btn74.BackColor = Color.Red;
                    btn74b.BackColor = Color.Red;
                    btn74e.BackColor = Color.Red;
                    btn74f.BackColor = Color.Red;
                    break;
                case 75:
                    btn75c.BackColor = Color.Red;
                    btn75d.BackColor = Color.Red;
                    btn75f.BackColor = Color.Red;
                    btn75h.BackColor = Color.Red;
                    break;
                default:
                    break;
            }

            txtentrada.Clear();
            Bingo bin = new Bingo();
            bin.Valor = valor;
            bin.CartonA();

            if (bin.respu == true)
            {
              
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
