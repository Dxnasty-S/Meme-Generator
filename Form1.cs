using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meme_Generator
{
    public partial class Form1 : Form
    {
        OpenFileDialog abrirArquivo;
        string caminhoDoArquivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void caixaDeTextoCima_TextChanged(object sender, EventArgs e)
        {
            txtDeCima.Text = caixaDeTextoCima.Text;
        }

        private void caixaDeTextoBaixo_TextChanged(object sender, EventArgs e)
        {
            txtDeBaixo.Text = caixaDeTextoBaixo.Text;
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            abrirArquivo = new OpenFileDialog();
            abrirArquivo.InitialDirectory = "c:\\";
            abrirArquivo.Filter = "Arquivos de imgagem (*.jpg, *.jpeg, *.jpe, *.jfif, *.png )|*.jpg;*.jpeg;*.jpe;*.jfif;*png;*.bmp";
            abrirArquivo.FilterIndex = 2;
            abrirArquivo.RestoreDirectory = true;

            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imagem.Image = Image.FromFile(abrirArquivo.FileName);
                    caminhoDoArquivo = abrirArquivo.FileName;
                }
                catch(Exception excecao)
                {
                    MessageBox.Show("Erro: Não foi possivel ler oarquivo. Mensagem de erro original: " + excecao.Message);
                }
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string primeiroTxeto = txtDeCima.Text;
            string segundoTexto = txtDeBaixo.Text;

            Bitmap imagemFinal = (Bitmap)Image.FromFile(caminhoDoArquivo);

            RectangleF localTextoCima = new RectangleF((imagemFinal.Width / 2 ) - (txtDeCima.Width / 2), 10, imagemFinal.Width, 400);
            RectangleF localTextoBaixo = new RectangleF((imagemFinal.Width / 2) - (txtDeCima.Width / 2), imagemFinal.Height - 100, imagemFinal.Width, 400);

            SaveFileDialog salvarImagem = new SaveFileDialog();
            salvarImagem.FileName = "*";
            salvarImagem.DefaultExt = "bmp";
            salvarImagem.ValidateNames = true;
            salvarImagem.Filter = "Imagem Bitmap (.bmp) | *.bmp | Imagem Gif (.gif) | *.gif | Imagem JPEG (.jpeg) | *.jpeg | Imagem PNG (.png) | *.png";

            if (salvarImagem.ShowDialog() == DialogResult.OK)
            {
                using (Graphics desenhista = Graphics.FromImage(imagemFinal))
                {
                    using (Font fonteDoMeme = new Font ("Impact", 26, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        desenhista.DrawString(primeiroTxeto, fonteDoMeme, Brushes.White, localTextoCima);
                        desenhista.DrawString(segundoTexto, fonteDoMeme, Brushes.White, localTextoBaixo);
                    }
                }
                imagemFinal.Save(salvarImagem.FileName);
            }
        }
    }
}
