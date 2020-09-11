﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace UI.UisSubFrm
{
    public partial class FrmSubHome : Form
    {

        int quantLiner = 2;
        int topCard = 20;
        int leftCard = 50;

        public FrmSubHome()
        {
            InitializeComponent();
        }

        private void FrmSubProdutos_Load(object sender, EventArgs e)
        {

            #region Insert Values Firebase DataGrid
            /*
            connect con = new connect();

            FirebaseResponse result = con.client.Get("Produtos/");

            List<Produtos> Produtos = result.ResultAs<List<Produtos>>();

            for (int i = 0; i < Produtos.Count; i++)
            {

                dgvDados.Rows.Add(Produtos[i].Id.ToString(), Produtos[i].Nome.ToString(), Produtos[i].Valor.ToString(), Produtos[i].DataValidade.ToString(), Produtos[i].Quantidade.ToString());
            }
            */
            #endregion

            // Get List de produtos no firebase.
            DataAcess.ControlDatabase bd = new DataAcess.ControlDatabase();

            List<DataAcess.Produtos> prods = bd.GetList("Produtos/");
            //

            for (int i = 0; i < prods.Count; i++)
            {
                quantLiner--;

                CardProd card = new CardProd();

                // Adicionar valores no card
                card.lblNome.Text = prods[i].Nome;
                card.lblStatus.Text = prods[i].Status;
                card.quantProd = prods[i].Quantidade;
                card.lblValor.Text = prods[i].Valor;
                //

                //Convert Byte Image

                byte[] b = Convert.FromBase64String(prods[i].img);

                MemoryStream ms = new MemoryStream();
                ms.Write(b, 0, Convert.ToInt32(b.Length));
                Bitmap bm = new Bitmap(ms,false);
                ms.Dispose();

                //Adicionar a imagem no card
                card.ptbProduto.Image = bm;

                //

                pnlContainer.Controls.Add(card);

                card.Left = leftCard;
                card.Top = topCard;

                topCard += (card.Height + 10);


                /*
                //Caso o limide de cada linha de card
                if(quantLiner == 0)
                {
                    topCard += card.Height + 20;
                    leftCard = 20;
                    quantLiner = 2;

                }
                //
                */

                card.Show();

            }

            ControlStaticFrm.subHome = this;

        }
    }
}
