using System.IO.Pipes;

namespace Trabalho2bim
{
    public partial class Form1 : Form
    {
        private List<Cartatrunfo> jogadores, cartajogador, cartamaquina;
        public Form1()
        {
            InitializeComponent();
            jogadores = new List<Cartatrunfo>();
            criarcarta();
        }
        private void criarcarta()
        {
            Cartatrunfo jogador1 = new Cartatrunfo()
            {
                Nome = "Ayrton Lucas",
                Velocidade = 90,
                Chute = 86,
                Passe = 80,
                Defesa = 85,
                Imagem = "C:\\Users\\madei\\OneDrive\\Documentos\\Aula Rosen\\Trabalho2bim\\Trabalho2bim\\Fotos\\ayrton.jpg"
            };
            jogadores.Add(jogador1);

            Cartatrunfo jogador2 = new Cartatrunfo()
            {
                Nome = "Rony Rustico",
                Velocidade = 60,
                Chute = 60,
                Passe = 48,
                Defesa = 60,
                Imagem = "C:\\Users\\madei\\OneDrive\\Documentos\\Aula Rosen\\Trabalho2bim\\Trabalho2bim\\Fotos\\rony.jpg"
            };
            jogadores.Add(jogador2);

            Cartatrunfo jogador3 = new Cartatrunfo()
            {
                Nome = "Gabigol",
                Velocidade = 50,
                Chute = 88,
                Passe = 55,
                Defesa = 20,
                Imagem = "C:\\Users\\madei\\OneDrive\\Documentos\\Aula Rosen\\Trabalho2bim\\Trabalho2bim\\Fotos\\gabi.jpg"
            };
            jogadores.Add(jogador3);

            Cartatrunfo jogador4 = new Cartatrunfo()
            {
                Nome = "Felipe Melo",
                Velocidade = 35,
                Chute = 5,
                Passe = 50,
                Defesa = 85,
                Imagem = "C:\\Users\\madei\\OneDrive\\Documentos\\Aula Rosen\\Trabalho2bim\\Trabalho2bim\\Fotos\\felipe.jpg"
            };
            jogadores.Add(jogador4);

            Cartatrunfo jogador5 = new Cartatrunfo()
            {
                Nome = "Roger Guedes",
                Velocidade = 65,
                Chute = 75,
                Passe = 50,
                Defesa = 42,
                Imagem = "C:\\Users\\madei\\OneDrive\\Documentos\\Aula Rosen\\Trabalho2bim\\Trabalho2bim\\Fotos\\roger.jpg"
            };
            jogadores.Add(jogador5);

            Cartatrunfo jogador6 = new Cartatrunfo()
            {
                Nome = "Gustavo Gomez",
                Velocidade = 45,
                Chute = 45,
                Passe = 76,
                Defesa = 90,
                Imagem = "C:\\Users\\madei\\OneDrive\\Documentos\\Aula Rosen\\Trabalho2bim\\Trabalho2bim\\Fotos\\gustavogomes.jpg"
            };
            jogadores.Add(jogador6);



        }
        private void numerodecartas()
        {
            foreach (var carta in cartamaquina)
            {
                int cont1 = cartamaquina.Count;
                numcartamaqui.Text = cont1.ToString();
            }
            foreach (var carta in cartajogador)
            {
                int cont2 = cartajogador.Count;
                numcartjog.Text = cont2.ToString();
            }
        }
        private void sorteio()
        {
            cartamaquina = new List<Cartatrunfo>();
            cartajogador = new List<Cartatrunfo>();
            Random random = new Random();
            bool jogadajogador = true;
            while (jogadores.Count > 0)
            {
                int alocacao = random.Next(jogadores.Count);
                if (jogadajogador)
                {
                    cartajogador.Add(jogadores[alocacao]);
                    jogadores.Remove(jogadores[alocacao]);
                    jogadajogador = false;
                    continue;
                }
                cartamaquina.Add(jogadores[alocacao]);
                jogadores.Remove(jogadores[alocacao]);
                jogadajogador = true;
            }
        }

        private void passarrodada()
        {
            Random random = new Random();
            int cont1 = random.Next(cartajogador.Count);
            int cont2 = random.Next(cartamaquina.Count);
            if (cartamaquina.Count == 0)
            {
                MessageBox.Show("Você Venceu O Game");
                Application.Exit();
            }
            if (cartajogador.Count == 0)
            {
                MessageBox.Show("Você Perdeu o Jogo");
                Application.Exit();
            }
            Cartatrunfo cartajog = cartajogador[cont1];
            Cartatrunfo cartajog1 = cartamaquina[cont2];
           pictureBox1.Image = Image.FromFile(cartajog.Imagem);
            pictureBox1.Tag = cont1;
            pictureBox2.Image = Image.FromFile("C:\\Users\\madei\\OneDrive\\Documentos\\Aula Rosen\\Trabalho2bim\\Trabalho2bim\\Fotos\\fifatela.png");
        }

        private void compare()
        {
            int cont1 = (int)pictureBox1.Tag;
            int cont2 = (int)pictureBox2.Tag;

            Cartatrunfo cartajog1 = cartajogador[cont1];
            Cartatrunfo cartajog2 = cartamaquina[cont2];

            List<RadioButton> listaAtributois = new List<RadioButton>
            {
                Atributo1,
                Atributo2,
                Atributo3,
                Atributo4,
            };

            if (listaAtributois[0].Checked)
            {
                if (cartajog1.Velocidade > cartajog2.Velocidade)
                {
                    pictureBox2.Image = Image.FromFile(cartajog2.Imagem);
                    MessageBox.Show("Venceu a Rodada");
                    cartajogador.Add(cartamaquina[cont2]);
                    cartamaquina.Remove(cartamaquina[cont2]);
                    numerodecartas();
                    passarrodada();

                }
                else if (cartajog1.Velocidade > cartajog2.Velocidade)
                {
                    MessageBox.Show("Empatou");
                    passarrodada();
                }
                else
                {
                    MessageBox.Show("Perdeu A rodada");
                    cartamaquina.Add(cartajogador[cont1]);
                    cartajogador.Remove(cartajogador[cont1]);
                    numerodecartas();
                    passarrodada();
                }
            }


            if (listaAtributois[1].Checked)
            {
                if (cartajog1.Chute > cartajog2.Chute)
                {
                    pictureBox2.Image = Image.FromFile(cartajog2.Imagem);
                    MessageBox.Show("Venceu a Rodada");
                    cartajogador.Add(cartamaquina[cont2]);
                    cartamaquina.Remove(cartamaquina[cont2]);
                    numerodecartas();
                    passarrodada();

                }
                else if (cartajog1.Chute > cartajog2.Chute)
                {
                    MessageBox.Show("Empatou");
                    passarrodada();
                }
                else
                {
                    MessageBox.Show("Perdeu a rodada");
                    cartamaquina.Add(cartajogador[cont1]);
                    cartajogador.Remove(cartajogador[cont1]);
                    numerodecartas();
                    passarrodada();
                }
            }

            if (listaAtributois[2].Checked)
            {
                if (cartajog1.Passe > cartajog2.Passe)
                {
                    pictureBox2.Image = Image.FromFile(cartajog2.Imagem);
                    MessageBox.Show("Venceu a Rodada");
                    cartajogador.Add(cartamaquina[cont2]);
                    cartamaquina.Remove(cartamaquina[cont2]);
                    numerodecartas();
                    passarrodada();

                }
                else if (cartajog1.Passe > cartajog2.Passe)
                {
                    MessageBox.Show("Empatou");
                    passarrodada();
                }
                else
                {
                    MessageBox.Show("Perdeu a rodada");
                    cartamaquina.Add(cartajogador[cont1]);
                    cartajogador.Remove(cartajogador[cont1]);
                    numerodecartas();
                    passarrodada();
                }
            }


            if (listaAtributois[3].Checked)
            {
                if (cartajog1.Defesa > cartajog2.Defesa)
                {
                    pictureBox2.Image = Image.FromFile(cartajog2.Imagem);
                    MessageBox.Show("Venceu a Rodada");
                    cartajogador.Add(cartamaquina[cont2]);
                    cartamaquina.Remove(cartamaquina[cont2]);
                    numerodecartas();
                    passarrodada();

                }
                else if (cartajog1.Defesa > cartajog2.Defesa)
                {
                    MessageBox.Show("Empatou");
                    passarrodada();
                }
                else
                {
                    MessageBox.Show("Perdeu a rodada");
                    cartamaquina.Add(cartajogador[cont1]);
                    cartajogador.Remove(cartajogador[cont1]);
                    numerodecartas();
                    passarrodada();
                }
            }
        }

        private void escolherjogada()
        {
            Random random = new Random();
            int cont = random.Next(jogadores.Count);
            int cont1 = random.Next(jogadores.Count);

            Cartatrunfo cartajog1 = cartajogador[cont];
            Cartatrunfo cartajog2 = cartamaquina[cont1];

            pictureBox1.Image = Image.FromFile(cartajog1.Imagem);
            pictureBox1.Tag = cont;

            pictureBox2.Tag = cont1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sortear_Click(object sender, EventArgs e)
        {
            sorteio();
            numerodecartas();
            sortear.Enabled = false;
        }


        private void comparar_Click(object sender, EventArgs e)
        {
            if (pictureBox1 == null)
            {
                MessageBox.Show("Inicie a Rodada para comparar");
                return;
            }
            else
            {
                compare();
            }
        }

        private void comecar_Click(object sender, EventArgs e)
        {

            escolherjogada();
            comecar.Enabled = false;
        }
    }
}