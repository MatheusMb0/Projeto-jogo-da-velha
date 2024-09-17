using System.Diagnostics.Eventing.Reader;

namespace Projeto_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int cont = 0,aux=0;


        private void Habilita_button()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }


        private void desabilita_button()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }
        private void BuscaVencedor(){
            if (button1.Text == button2.Text && button3.Text ==button1.Text && button1.Text != ""){
                desabilita_button();
                if (button1.Text == "X")
                {
                    MessageBox.Show("Vitoria do X");
                }
                else
                {
                    MessageBox.Show("Vitoria do 0");
                }
            }
            if(button1.Text == button4.Text && button7.Text == button1.Text && button1.Text != "")
            {
                desabilita_button();
                if (button1.Text == "X")
                {
                    MessageBox.Show("Vitoria do X");
                }
                else
                {
                    MessageBox.Show("Vitoria do 0");
                }
               

            }

            if (button5.Text == button4.Text && button6.Text == button4.Text && button5.Text != "")
            {
                desabilita_button();
                if (button5.Text == "X")
                {
                    MessageBox.Show("Vitoria do X");
                }
                else
                {
                    MessageBox.Show("Vitoria do 0");
                }

            }
            
             if (button7.Text == button8.Text && button9.Text == button7.Text && button7.Text != ""){
                desabilita_button();
                if (button7.Text == "X")
                {
                    MessageBox.Show("Vitoria do X");
                }
                else
                {
                    MessageBox.Show("Vitoria do 0");
                }

            }
             if (button2.Text == button5.Text && button8.Text == button5.Text && button5.Text != ""){
                desabilita_button();
                if (button2.Text == "X")
                {
                    MessageBox.Show("Vitoria do X");
                }
                else
                {
                    MessageBox.Show("Vitoria do 0");
                }

            }

             if (button3.Text == button6.Text && button9.Text == button6.Text && button3.Text != ""){
                desabilita_button();
                if (button3.Text == "X")
                {
                    MessageBox.Show("Vitoria do X");
                }
                else
                {
                    MessageBox.Show("Vitoria do 0");
                }

            }
            if (button3.Text == button5.Text && button7.Text == button3.Text && button3.Text != "")
            {
                desabilita_button();
                if (button3.Text == "X")
                {
                    MessageBox.Show("Vitoria do X");
                }
                else
                {
                    MessageBox.Show("Vitoria do 0");
                }

            }

            if (button9.Text == button5.Text && button1.Text == button9.Text && button5.Text != ""){
                    desabilita_button();
                if (button9.Text == "X")
                {
                    MessageBox.Show("Vitoria do X");
                }
                else
                {
                    MessageBox.Show("Vitoria do 0");
                }

            }
            

            if(aux == 9)
            {
                MessageBox.Show("Empatou");
            }
           

        }


        private void button9_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Name);
            if (((Button)sender).Text == ""){
                if (cont == 0)
                {
                    ((Button)sender).Text = "X";
                    aux++; ;
                    cont++;
                }
                else
                {
                    ((Button)sender).Text = "0";
                    aux++;
                    cont--;
                }
                 
            }

            BuscaVencedor();



        }
        private void button10_Click(object ender, EventArgs e){



            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Text = "";
                }
            }
            button10.Text = "Reinciar Jogo";
            aux = 0;
            cont = 0;
            Habilita_button();

        }

    }
}
