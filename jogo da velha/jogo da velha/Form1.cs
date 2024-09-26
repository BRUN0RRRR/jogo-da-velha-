using System.Reflection.Metadata.Ecma335;

namespace jogo_da_velha
{
    public partial class Form1 : Form
    {
        int x = 0, O = 0; int empates = 0, rodadas = 0;
        bool turno = true, final = false;
        string[] texto = new string[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            int botaoIndex = button1.TabIndex;
            if (button1.Text == "" && final == false)
            {
                if (turno)
                {
                    button1.Text = "X";
                    texto[botaoIndex] = button1.Text;
                    rodadas++;
                    turno = !turno;
                    checagem(1);
                }
                else
                {
                    button1.Text = "O";
                    texto[botaoIndex] = button1.Text;
                    rodadas++;
                    turno = !turno;
                    checagem(2);

                }
            }

        }


        void vencedor(int ganho)
        {
            final = true;
            if (ganho == 1)
            {
                x++;
                pontoX.Text = Convert.ToString(x);
                MessageBox.Show("Jogador X ganhou");
                turno = true;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                final = false;
                rodadas = 0;
                for (int i = 0; i < 9; i++)
                {
                    texto[i] = "";
                }
            }
            else
            {
                O++;
                pontoO.Text = Convert.ToString(O);
                MessageBox.Show("Jogador O ganhou");
                turno = false;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                final = false;
                rodadas = 0;
                for (int i = 0; i < 9; i++)
                {
                    texto[i] = "";
                }
            }
        }


        void checagem(int checagemPlayer)
        {
            string suporte;
            if (checagemPlayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }//FINAL 

            for (int hori = 0; hori < 8; hori += 3)
            {
                if (suporte == texto[hori])
                {
                    if (texto[hori] == texto[hori + 1] && texto[hori] == texto[hori + 2])
                    {
                        vencedor(checagemPlayer);
                        return;
                    }
                }
            }

            for (int veti = 0; veti < 3; veti++)
            {
                if (suporte == texto[veti])
                {
                    if (texto[veti] == texto[veti + 3] && texto[veti] == texto[veti + 6])
                    {

                        vencedor(checagemPlayer);
                        return;
                    }
                }
            }

            if (suporte == texto[0])
            {
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {

                    vencedor(checagemPlayer);
                    return;
                }
            }

            if (suporte == texto[2])
            {
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {

                    vencedor(checagemPlayer);
                    return;
                }

            }

            if (rodadas == 9 && final == false)
            {
                empates++;
                pontoV.Text = Convert.ToString(empates);
                MessageBox.Show("Empates!!");
                final = true;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                final = false;
                rodadas = 0;
                for (int i = 0; i < 9; i++)
                {
                    texto[i] = "";
                }
                return;
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            final = false;
            rodadas = 0;
            for(int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
        }
    }
}
