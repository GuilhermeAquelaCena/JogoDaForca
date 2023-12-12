using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace jogoforca
{
    public partial class Form1 : Form
    {

        //variaveis globais à classe
        string[] palavras; //arrays para guardar as palavras do dicionário
        string palavra;
        char[] palescondido;
        bool acertou = false;
        string grau = "fácil";
        short nImg = 0;
        bool soundON = false;
       

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Iniciarjogo();
        }
        private void Iniciarjogo()
        {
            SomInicial();
            this.StartPosition = FormStartPosition.CenterScreen;
            botaostart.Visible = true;
            botaoSOM.Visible = true;
            groupBoxDificuldade.Visible = false;
            botaoDificuldade.Visible = true;
            grupoteclado.Visible = false;
            labelletra.Visible = false;
            pictureboxFORCA.Visible = false;
            pictureBoxPerdeu.Visible = false;
            pictureBoxGanhou.Visible = false;
            buttonrest.Visible = false;
            acertou = false;
            pal.Visible = false;
            palabra.Visible = false;

           
            nImg = 0;
            ApresentarImg(nImg);
        }
        private void ApresentarImg(short nI)
        {
            try
            {
                if (nI == 0)
                    pictureboxFORCA.Image = Properties.Resources.forca0;
                else if (nI == 1)
                    pictureboxFORCA.Image = Properties.Resources.forca1;
                else if (nI == 2)
                    pictureboxFORCA.Image = Properties.Resources.forca2;
                else if (nI == 3)
                    pictureboxFORCA.Image = Properties.Resources.forca3;
                else if (nI == 4)
                    pictureboxFORCA.Image = Properties.Resources.forca4;
                else if (nI == 5)
                    pictureboxFORCA.Image = Properties.Resources.forca5;
                else if (nI == 6)
                    pictureboxFORCA.Image = Properties.Resources.forca6;
                else if (nI == 7)
                    pictureboxFORCA.Image = Properties.Resources.forca7;
                else if (nI == 8)
                    pictureboxFORCA.Image = Properties.Resources.forca8;
                else if (nI == 9)
                    pictureboxFORCA.Image = Properties.Resources.forcaMorto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }

        }
        private void IniciarDicionario()
        {
            palavras = new string[131];                                  
                
            try
            {
                if (grau == "facil")
                {
                    palavras[0] = "Banana";
                    palavras[1] = "Melão";
                    palavras[2] = "Maça";
                    palavras[3] = "Ananás";
                    palavras[4] = "Papaia";
                    palavras[5] = "Mamão";
                    palavras[6] = "Cereja";
                    palavras[7] = "Laranja";
                    palavras[8] = "Tangerina";
                    palavras[9] = "Tângera";
                    palavras[10] = "Pera";
                    palavras[11] = "Kiwi";
                    palavras[12] = "Pêssego";
                    palavras[13] = "Ameixa";
                    palavras[14] = "Abacate";
                    palavras[15] = "Melância";
                    palavras[16] = "Damasco";
                    palavras[17] = "Uvas";
                    palavras[18] = "Morango";
                    palavras[19] = "Limão";
                    palavras[20] = "Manga";
                    palavras[21] = "Nêspera";
                    palavras[22] = "Marmelo";
                    palavras[23] = "Framboesa";
                    palavras[24] = "Amora";
                    palavras[25] = "Mirtilio";
                    palavras[26] = "Romã";
                    palavras[27] = "Tâmara";
                    palavras[28] = "Figo";
                    palavras[29] = "Lima";
                }
                else if (grau == "medio")
                {
                    palavras[0] = "Botswana";
                    palavras[1] = "Angola";
                    palavras[2] = "Libéria";
                    palavras[3] = "Tanzânia";
                    palavras[4] = "Serra Leoa";
                    palavras[5] = "Zimbabwe";
                    palavras[6] = "Moçambique";
                    palavras[7] = "Afeganistão";
                    palavras[8] = "Zâmbia";
                    palavras[9] = "Malawi";
                    palavras[10] = "Namíbia";
                    palavras[11] = "Nigéria";
                    palavras[12] = "Somália";
                    palavras[13] = "Guiné Bissau";
                    palavras[14] = "Ruanda";
                    palavras[15] = "Etiópia";
                    palavras[16] = "Rússia";
                    palavras[17] = "Ucrânia";
                    palavras[18] = "Bulgária";
                    palavras[19] = "Bielorrúsia";
                    palavras[20] = "Quénia";
                    palavras[21] = "Letônia";
                    palavras[22] = "Camarões";
                    palavras[23] = "Burundi";
                    palavras[24] = "Estónia";
                    palavras[25] = "Gâmbia";
                    palavras[26] = "Moldávia";
                    palavras[27] = "Eslovénia";
                    palavras[28] = "Gabão";
                    palavras[29] = "Uganda";
                }
                else if (grau == "dificil")
                {
                    palavras[0] = "Butão";
                    palavras[1] = "Guernsey";
                    palavras[2] = "Mianmar";
                    palavras[3] = "Azerbaijão";
                    palavras[4] = "Eritreia";
                    palavras[5] = "Cazaquistão";
                    palavras[6] = "Gana";
                    palavras[7] = "Togo";
                    palavras[8] = "Senegal";
                    palavras[9] = "Jersey";
                    palavras[10] = "Belize";
                    palavras[11] = "Comboja";
                    palavras[12] = "Bahamas";
                    palavras[13] = "Turquemenistão";
                    palavras[14] = "Lêmen";
                    palavras[15] = "Kiribati";
                    palavras[16] = "Bangladesh";
                    palavras[17] = "Tajiquistão";
                    palavras[18] = "Uzbequistão";
                    palavras[19] = "Vanuatu";
                    palavras[20] = "Mayotte";
                    palavras[21] = "Suriname";
                    palavras[22] = "Papua nova Guiné";
                    palavras[23] = "Liechtenstein";
                    palavras[24] = "Tuvalu";
                    palavras[25] = "Quirguistão";
                    palavras[26] = "Palau";
                    palavras[27] = "Nauru";
                    palavras[28] = "Samoa";
                    palavras[29] = "Seicheles";

                }
                else if (grau == "marcas")
                {
                    palavras[0] = "Abarth";
                    palavras[1] = "Alfa Romeo";
                    palavras[2] = "Aston Martin";
                    palavras[3] = "Bently";
                    palavras[4] = "Bmw";
                    palavras[5] = "Cupra";
                    palavras[6] = "Dacia";
                    palavras[7] = "Ds";
                    palavras[8] = "Ferrari";
                    palavras[9] = "Fiat";
                    palavras[10] = "Ford";
                    palavras[11] = "Honda";
                    palavras[12] = "Hyundai";
                    palavras[13] = "Jaguar";
                    palavras[14] = "Jeep";
                    palavras[15] = "Kia";
                    palavras[16] = "Lamborghini";
                    palavras[17] = "Lexux";
                    palavras[18] = "Lotus";
                    palavras[19] = "Maserati";
                    palavras[20] = "Mazda";
                    palavras[21] = "Mercedes";
                    palavras[22] = "Mini";
                    palavras[23] = "Mitsubishi";
                    palavras[24] = "Nissan";
                    palavras[25] = "Opel";
                    palavras[26] = "Peugeot";
                    palavras[27] = "Porsche";
                    palavras[28] = "Renault";
                    palavras[29] = "Seat";
                    palavras[30] = "Toyota";
                    palavras[31] = "Tesla";
                    palavras[32] = "Volvo";
                }
                else if (grau == "pilotosGp")
                {
                    palavras[0] = "Johann Zarco";
                    palavras[1] = "Luca Marini";
                    palavras[2] = "Maverick Viñales";
                    palavras[3] = "Fabio Quartararo";
                    palavras[4] = "Franco Morbidelli";
                    palavras[5] = "Enea Bastianini";
                    palavras[6] = "Raul Fernandez";
                    palavras[7] = "Takaaki Nakagami";
                    palavras[8] = "Brad Binder";
                    palavras[9] = "Joan Mir";
                    palavras[10] = "Augusto Fernandez";
                    palavras[11] = "Aleix Espargaro";
                    palavras[12] = "Alex Rins";
                    palavras[13] = "Jack Miller";
                    palavras[14] = "Pol Espargaro";
                    palavras[15] = "Fabio Di Giannantonio";
                    palavras[16] = "Francesco Bagnaia";
                    palavras[17] = "Marco Bezzecchi";
                    palavras[18] = "Alex Marquez";
                    palavras[19] = "Miguel Oliveira";
                    palavras[20] = "Jorge Martin";
                    palavras[21] = "Marc Marquez";
                    palavras[22] = "Valentino Rossi";
                    palavras[23] = "Andrea Iannone";
                    palavras[24] = "Dani Pedrosa";
                    palavras[25] = "Alvaro Bautista";
                    palavras[26] = "Franco Morbidelli";
                    palavras[27] = "Maverick Viñales";
                    palavras[28] = "Xavier Simeon";
                    palavras[29] = "Thomas Luthi";


                }
                else if (grau == "pilotosF1")
                {
                    palavras[0] = "Max Verstappen";
                    palavras[1] = "Logan Sargeant";
                    palavras[2] = "Mianmar";
                    palavras[3] = "Lando Norris";
                    palavras[4] = "Pierre Gasly";
                    palavras[5] = "Sergio Perez";
                    palavras[6] = "Fernando Alonso";
                    palavras[7] = "Charles Leclerc";
                    palavras[8] = "Lance Stroll";
                    palavras[9] = "Kevin Magnussen";
                    palavras[10] = "Nyck de Vries";
                    palavras[11] = "Yuki Tsunoda";
                    palavras[12] = "Alex Albon";
                    palavras[13] = "Zhou Guanyu";
                    palavras[14] = "Nico Hulkenberg";
                    palavras[15] = "Esteban Ocon";
                    palavras[16] = "Lewis Hamilton";
                    palavras[17] = "Carlos Sainz";
                    palavras[18] = "George Russell";
                    palavras[19] = "Valtteri Bottas";
                    palavras[20] = "Oscar Piastri";
                    palavras[21] = "Stoffel Vandoorne";
                    palavras[22] = "Daniel Ricciardo";
                    palavras[23] = "Sebastian Vettel";
                    palavras[24] = "Kimi Raikkonen";
                    palavras[25] = "Romain Grosjean";
                    palavras[26] = "Marcus Ericsson";
                    palavras[27] = "Pierre Gasly";
                    palavras[28] = "Sergio Perez";
                    palavras[29] = "Charles Leclerc";
                }
                else if (grau == "jogos")
                {
                    palavras[0] = "Grand Theft Auto";
                    palavras[1] = "Doom";
                    palavras[2] = "Minecraft";
                    palavras[3] = "The Witcher";
                    palavras[4] = "God of War";
                    palavras[5] = "The Legend of Zelda";
                    palavras[6] = "Red Dead Redemption";
                    palavras[7] = "Super Mario World";
                    palavras[8] = "Skyrim";
                    palavras[9] = "League of Legends";
                    palavras[10] = "Valorant";
                    palavras[11] = "Nier Automata";
                    palavras[12] = "Overwatch";
                    palavras[13] = "Portal 2";
                    palavras[14] = "Undertale";
                    palavras[15] = "The Last of Us";
                    palavras[16] = "Street Fight";
                    palavras[17] = "Fallout";
                    palavras[18] = "Uncharted";
                    palavras[19] = "Dota 2";
                    palavras[20] = "Counter Strike";
                    palavras[21] = "Forza Horizon";
                    palavras[22] = "Fortnite";
                    palavras[23] = "The Walking Dead";
                    palavras[24] = "Bornout Paradise";
                    palavras[25] = "Ride 4";
                    palavras[26] = "Rocket League";
                    palavras[27] = "Pierre Gasly";
                    palavras[28] = "Among Us";
                    palavras[29] = "Grand Turismo";
                    palavras[30] = "Five Night at Freedy";
                }
                else if (grau == "motas")
                {
                    palavras[0] = "AJS";
                    palavras[1] = "BMW";
                    palavras[2] = "Daelim";
                    palavras[3] = "Fantic";
                    palavras[4] = "Indian";
                    palavras[5] = "Keeway";
                    palavras[6] = "Kymco";
                    palavras[7] = "Moto Guzzi";
                    palavras[8] = "Royal Enfield";
                    palavras[9] = "Suzuki";
                    palavras[10] = "Aprilia";
                    palavras[11] = "Ducati";
                    palavras[12] = "Harley Davidson";
                    palavras[13] = "Mv Agusta";
                    palavras[14] = "Yamaha";
                    palavras[15] = "Benelli";
                    palavras[16] = "CF MOTO";
                    palavras[17] = "Kawasaki";
                    palavras[18] = "KTM";
                    palavras[19] = "Zontes";
                    palavras[20] = "Triumph";
                    palavras[21] = "Honda";
                    palavras[22] = "Husqvarna";
                    palavras[23] = "Mondial";
                    palavras[24] = "Moto Guzzi";
                    palavras[25] = "Peugeot";
                    palavras[26] = "Moto Morini";
                    palavras[27] = "Piaggio";
                    palavras[28] = "Royal Enfield";
                    palavras[29] = "UM Motorcycles";
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no carregamento do dicionario: " + ex.Message);
            }
        }
        private void botaostart_Click(object sender, EventArgs e)
        {
            botaostart.Visible = false;
            botaoDificuldade.Visible = false;
            IniciarDicionario();           
            groupBoxDificuldade.Visible = false;
            botaoSOM.Visible = true;
            labelletra.Visible = false;
            MostrarLetras();
            string word = SelecionarPalavra();
            ApresentarPalavra(word);
            SomInicial();
        }
        private void MostrarLetras()
        {
            grupoteclado.Visible = true;
            labelletra.Visible = true;
            pictureboxFORCA.Visible = true;
        }
        private string SelecionarPalavra()
        {
            Random rnd = new Random();
            int n = rnd.Next(30);
            return (palavras[n]);
        }
        private void ApresentarPalavra(string s)
        {
            int t = s.Length;
            palescondido = new char[t];
            for (int i = 0; i < t; i++)
                palescondido[i] = '-';
            string sf = new string(palescondido);
            labelletra.Text = sf;
            palavra = s;
        }
        private void SomInicial()
        {
            Stream st = Properties.Resources.silent;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);
            sp.PlayLooping();
            soundON = true;
        }
        private void botaoSOM_Click(object sender, EventArgs e)
        {
            Stream st = Properties.Resources.silent;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);
            if (soundON)
            {

                sp.Stop();
                soundON = false;
            }
            else
            {
                sp.PlayLooping();
                soundON = true;
                botaoSOM.BackgroundImage = Properties.Resources.iconVolume;
            }
        }
        private void VerificarLetra(char c)
        {
            char[] pal = palavra.ToCharArray();
            for (int i = 0; i < palavra.Length; i++)
            {
                if (pal[i] == c)
                {
                    acertou = true;
                    palescondido[i] = c;
                }
            }
            string s = new string(palescondido);
            labelletra.Text = s;
        }
        private void AtualizarJogo()
        {
            if(!acertou)
            {
                nImg++;
                ApresentarImg(nImg);
                if(nImg==9)
                {
                    FimJogo(false);
                }
            }
            VerificarSeGanhou();
        }
        private void VerificarSeGanhou()
        {
            string s = new string(palescondido);
            if (string.Compare(s, palavra) == 0)
            {
                FimJogo(true);
                Stream st = Properties.Resources.silent;
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);
                sp.Stop();
                st = Properties.Resources.ganhou;
                sp = new System.Media.SoundPlayer(st);
                sp.Play();
                pal.Visible = false;
                palabra.Visible = false;                
            }       
        }
        private void FimJogo(bool gh)
        {           
            grupoteclado.Visible = false;
            groupBoxDificuldade.Visible = false;
            pictureboxFORCA.Visible = false;
            botaoDificuldade.Visible = false;
            botaostart.Visible = false;
            labelletra.Visible = false;
            Titulo.Visible = false;
            botaoSOM.Visible = false;
            buttonrest.Visible = true;
            pal.Text = palavra;
            pal.Visible = true;
            palabra.Visible = true;
            if (gh)
                pictureBoxGanhou.Visible = true;            
            else
                Perdeu();
        }
        private void Perdeu()
        {
            Stream st = Properties.Resources.silent;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);
            sp.Stop();
            st = Properties.Resources.perdeu;
            sp = new System.Media.SoundPlayer(st);
            sp.Play();
            soundON = true;
            grupoteclado.Visible = false;
            groupBoxDificuldade.Visible = false;
            pictureboxFORCA.Visible = false;
            pictureBoxPerdeu.Visible = true;
            groupBoxDificuldade.Visible = false;
            

        }
        private void botaoA_Click(object sender, EventArgs e)
        {
            botaoA.Visible = false;
            acertou = false;
            VerificarLetra('A');
            VerificarLetra('a');
            VerificarLetra('á');
            VerificarLetra('à');
            VerificarLetra('ã');
            AtualizarJogo();
        }
        private void botaoB_Click(object sender, EventArgs e)
        {
            botaoB.Visible = false;
            acertou = false;
            VerificarLetra('b');
            VerificarLetra('B');            
            AtualizarJogo();
        }
        private void botaoC_Click(object sender, EventArgs e)
        {
            botaoC.Visible = false;
            acertou = false;
            VerificarLetra('C');
            VerificarLetra('c');            
            AtualizarJogo();
        }
        private void botaoD_Click(object sender, EventArgs e)
        {
            botaoD.Visible = false;
            acertou = false;
            VerificarLetra('D');
            VerificarLetra('d');            
            AtualizarJogo();
        }
        private void botaoE_Click(object sender, EventArgs e)
        {
            botaoE.Visible = false;
            acertou = false;
            VerificarLetra('e');
            VerificarLetra('E');
            VerificarLetra('é');
            VerificarLetra('è');
            
            AtualizarJogo();
        }
        private void botaoF_Click(object sender, EventArgs e)
        {
            botaoF.Visible = false;
            acertou = false;
            VerificarLetra('F');
            VerificarLetra('f');            
            AtualizarJogo();
        }
        private void botaoG_Click(object sender, EventArgs e)
        {
            botaoG.Visible = false;
            acertou = false;
            VerificarLetra('G');
            VerificarLetra('g');            
            AtualizarJogo();
        }
        private void botaoH_Click(object sender, EventArgs e)
        {
            botaoH.Visible = false;
            acertou = false;
            VerificarLetra('H');
            VerificarLetra('h');            
            AtualizarJogo();
        }
        private void botaoI_Click(object sender, EventArgs e)
        {
            botaoI.Visible = false;
            acertou = false;
            VerificarLetra('I');
            VerificarLetra('i');
            VerificarLetra('í');            
            AtualizarJogo();
        }
        private void botaoJ_Click(object sender, EventArgs e)
        {
            botaoJ.Visible = false;
            acertou = false;
            VerificarLetra('J');
            VerificarLetra('j');            
            AtualizarJogo();
        }
        private void botaoK_Click(object sender, EventArgs e)
        {
            botaoK.Visible = false;
            acertou = false;
            VerificarLetra('K');
            VerificarLetra('k');            
            AtualizarJogo();
        }
        private void botaoL_Click(object sender, EventArgs e)
        {
            botaoL.Visible = false;
            acertou = false;
            VerificarLetra('L');
            VerificarLetra('l');            
            AtualizarJogo();
        }
        private void botaoM_Click(object sender, EventArgs e)
        {
            botaoM.Visible = false;
            acertou = false;
            VerificarLetra('M');
            VerificarLetra('m');            
            AtualizarJogo();
        }
        private void botaoN_Click(object sender, EventArgs e)
        {
            botaoN.Visible = false;
            acertou = false;
            VerificarLetra('N');
            VerificarLetra('n');            
            AtualizarJogo();
        }
        private void botaoO_Click(object sender, EventArgs e)
        {
            botaoO.Visible = false;
            acertou = false;
            VerificarLetra('O');
            VerificarLetra('o');
            VerificarLetra('ó');            
            AtualizarJogo();
        }
        private void botaoP_Click(object sender, EventArgs e)
        {
            botaoP.Visible = false;
            acertou = false;
            VerificarLetra('P');
            VerificarLetra('p');            
            AtualizarJogo();
        }
        private void botaoQ_Click(object sender, EventArgs e)
        {
            botaoQ.Visible = false;
            acertou = false;
            VerificarLetra('Q');
            VerificarLetra('q');            
            AtualizarJogo();
        }
        private void botaoR_Click(object sender, EventArgs e)
        {
            botaoR.Visible = false;
            acertou = false;
            VerificarLetra('R');
            VerificarLetra('r');            
            AtualizarJogo();
        }
        private void botaoS_Click(object sender, EventArgs e)
        {
            botaoS.Visible = false;
            acertou = false;
            VerificarLetra('S');
            VerificarLetra('s');            
            AtualizarJogo();
        }
        private void botaoT_Click(object sender, EventArgs e)
        {
            botaoT.Visible = false;
            acertou = false;
            VerificarLetra('T');
            VerificarLetra('t');           
            AtualizarJogo();
        }
        private void botaoU_Click(object sender, EventArgs e)
        {
            botaoU.Visible = false;
            acertou = false;
            VerificarLetra('U');
            VerificarLetra('u');
            VerificarLetra('ú');            
            AtualizarJogo();
        }
        private void botaoV_Click(object sender, EventArgs e)
        {
            botaoV.Visible = false;
            acertou = false;
            VerificarLetra('V');
            VerificarLetra('v');            
            AtualizarJogo();
        }
        private void botaoW_Click(object sender, EventArgs e)
        {
            botaoW.Visible = false;
            acertou = false;
            VerificarLetra('W');
            VerificarLetra('w');           
            AtualizarJogo();
        }
        private void botaoX_Click(object sender, EventArgs e)
        {
            botaoX.Visible = false;
            acertou = false;
            VerificarLetra('X');
            VerificarLetra('x');            
            AtualizarJogo();
        }
        private void botaoY_Click(object sender, EventArgs e)
        {
            botaoY.Visible = false;
            acertou = false;
            VerificarLetra('y');
            VerificarLetra('Y');            
            AtualizarJogo();
        }
        private void botaoZ_Click(object sender, EventArgs e)
        {
            botaoZ.Visible = false;
            acertou = false;
            VerificarLetra('Z');
            VerificarLetra('z');            
            AtualizarJogo();
        }                
        private void botaoDificuldade_Click(object sender, EventArgs e)
        {
         groupBoxDificuldade.Visible = true;
        }
        private void botaofacil_Click(object sender, EventArgs e)
        {
            botaofacil.Visible = true;
            grau = "facil";
        }
        private void botaomedio_Click(object sender, EventArgs e)
        {
            botaomedio.Visible = true;
            grau = "medio";
        }
        private void botaodificil_Click(object sender, EventArgs e)
        {
            botaoDificuldade.Visible = true;
            grau = "dificil";
        }
        private void buttonrest_Click(object sender, EventArgs e)
        {
            Iniciarjogo();
            
            botaoA.Visible = true;
            botaoB.Visible = true;
            botaoC.Visible = true;
            botaoD.Visible = true;
            botaoE.Visible = true;
            botaoF.Visible = true;
            botaoG.Visible = true;
            botaoH.Visible = true;
            botaoI.Visible = true;
            botaoJ.Visible = true;
            botaoK.Visible = true;
            botaoL.Visible = true;
            botaoM.Visible = true;
            botaoN.Visible = true;
            botaoO.Visible = true;
            botaoP.Visible = true;
            botaoQ.Visible = true;
            botaoR.Visible = true;
            botaoS.Visible = true;
            botaoT.Visible = true;
            botaoU.Visible = true;
            botaoV.Visible = true;
            botaoW.Visible = true;
            botaoX.Visible = true;
            botaoY.Visible = true;
            botaoZ.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            grau = "marcas";
        }
        private void pilotosGp_Click(object sender, EventArgs e)
        {
            grau = "pilotosGp";
        }
        private void pilotosF1_Click(object sender, EventArgs e)
        {
            grau = "pilotosF1";
        }
        private void botaoespaco_Click(object sender, EventArgs e)
        {
            botaoespaco.Visible = true;
            acertou = false;
            VerificarLetra(' ');
            AtualizarJogo();
        }
        private void buttonjogos_Click(object sender, EventArgs e)
        {
            grau = "jogos";
        }
        private void motas_Click(object sender, EventArgs e)
        {
            grau = "motas";
        }

        private void groupBoxDificuldade_Enter(object sender, EventArgs e)
        {

        }
    }
    }

