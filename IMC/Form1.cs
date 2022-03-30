using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_box_Click(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string sexo = txt_sexo.Text.ToLower();
            double peso = double.Parse(txt_peso.Text);
            double alt = double.Parse(txt_altura.Text);
            double imc = peso / (alt * alt);
            string status = "";


            // Masculino
            if(imc< 20.7 & (sexo=="m" || sexo == "masculino"))
            {
                status = "Abaixo do Peso";
            }
            if (imc > 20.7 && imc < 26.4 & (sexo == "m" || sexo == "masculino"))
            {
                status = "Peso Normal";
            }
            if (imc > 26.4 && imc < 27.8 & (sexo == "m" || sexo == "masculino"))
            {
                status = "Marginalmente acima do peso";
            }
            if (imc > 27.8 && imc < 31.1 & (sexo == "m" || sexo == "masculino"))
            {
                status = "Acima do peso";
            }
            if (imc > 31.1 & (sexo == "m" || sexo == "masculino"))
            {
                status = "Obeso";
            }

            //Feminino
            if (imc < 19.1 & (sexo == "f" || sexo == "feminino"))
            {
                status = "Abaixo do Peso";
            }
            if (imc > 19.1 && imc < 25.8 & (sexo == "f" || sexo == "feminino"))
            {
                status = "Peso Normal";
            }
            if (imc > 25.8 && imc < 27.3 & (sexo == "f" || sexo == "feminino"))
            {
                status = "Marginalmente acima do peso";
            }
            if (imc > 27.3 && imc < 32.3 & (sexo == "f" || sexo == "feminino"))
            {
                status = "Acima do peso";
            }
            if (imc > 32.3 & (sexo == "f" || sexo == "feminino"))
            {
                status = "Obeso";
            }

            //Condicao normal
            double imcIdeal = 0;
            double pesoIdeal = 0;
            double pesoId = 0;
            string sts = "";

            if (sexo == "m" || sexo == "masculino")
            {
                imcIdeal = (20.7 + 26.4) / 2;
            }
            if(sexo == "f" || sexo == "feminino")
            {
                imcIdeal = (19.1 + 25.8) / 2;
            }

            //-------

            if (imc > imcIdeal & status != "Peso Normal")
            {
                pesoIdeal = imcIdeal * (alt * alt);
                pesoId = (pesoIdeal - peso)*(-1);
                sts = "Para ficar com o peso ideal, deve perder" 
                    + " " + Math.Round(pesoId, 2) + "kg";
            }
            if (imc < imcIdeal & status != "Peso Normal")
            {
                pesoIdeal = imcIdeal * (alt * alt);
                pesoId = pesoIdeal - peso;
                sts = "Para ficar com o peso ideal, deve ganhar" 
                    + " " + Math.Round(pesoId, 2) + "kg";
            }

            //----Resultado ----

            result_box.Text = 
                "Nome: " + nome +"\n"+
                "Sexo: " + sexo + "\n" +
                "Peso atual: " + peso + "\n" +
                "Altura: " + alt + "\n" +
                "IMC: " + Math.Round(imc, 2) + "\n" +
                "Status: " + status + "\n" + 
                 sts ;

            // - -
            pictureBox1.Visible = false;
            result.Visible = false;
            limpar.Visible = true;

        }

        private void txt_sexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            limpar.Visible = false;

            txt_nome.Clear();
            txt_peso.Clear();
            txt_altura.Clear();
            txt_sexo.Clear();
            result_box.Text = " ";

            pictureBox1.Visible = true;
            result.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            result.Visible = true;
            limpar.Visible = false;
        }
    }
}
