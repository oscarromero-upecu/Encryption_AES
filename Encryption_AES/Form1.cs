using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            obj_encriptar = new Encriptar();
            obj_desencriptar = new Desencriptar();
        }


        Encriptar obj_encriptar;
        Desencriptar obj_desencriptar;

        private void encriptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (encriptartxt.Text != "" && keysize.Text != "")
                {
                    if (keysize.Text == "128")
                        desencriptartxt.Text = obj_encriptar.encrypt128(encriptartxt.Text);
                    else
                    {
                        desencriptartxt.Text = obj_encriptar.encrypt256(encriptartxt.Text);

                    }

                   MessageBox.Show("encriptacion exitoso","continuar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    encriptartxt.Text = "";
                }
            }
            catch (Exception )
            {
                throw;
            }
          
        }

        private void desencriptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (desencriptartxt.Text != "" && keysize.Text != "")
                {
                    if (keysize.Text == "128")
                        encriptartxt.Text = obj_desencriptar.Descrypt128(desencriptartxt.Text);
                    else
                    {
                        encriptartxt.Text = obj_desencriptar.Descrypt256(desencriptartxt.Text);

                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
                

        }

        private void salida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void keysize_SelectedIndexChanged(object sender, EventArgs e)
        {
            encriptartxt.Text = "";
            desencriptartxt.Text = "";
        }
    }
 }
