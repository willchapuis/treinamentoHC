
using DTIForms.Util;
using FabricaAutomoveis.DAO;
using FabricaAutomoveis.Domain;
using NTIComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FabricaAutomoveis.Forms
{
    public partial class AUTO0001mn : NTIForm
    {
        private string _OPERACAO;
        private Terrestre _Dominio;

        public AUTO0001mn(Terrestre dominio, string operacao)
        {
            InitializeComponent();
            configuraForm();
            _OPERACAO = operacao;
            _Dominio = dominio;
        }

        private void AtualizaTela()
        {
            //esta rotina pega os dados do objeto e joga na tela para o usuario visualizar. Tem que ser chamada quando é alteração
            /***
             * Exemplo:
             * tbNome.Text = _Dominio.Nom_Convenio;
             * */
        }

        private void AtualizarObjeto()
        {
            /*Esta rotina pega os dados da tela e alimenta o objeto.Tem que ser chamada antes da alteração e inclusao.
             * Exemplo:
             * _Dominio.Nom_Convenio = tbNome.Text;
             * */
        }

        private void LimparTela()
        {
            /*Rotina deve ser chamado quando clicado no Gravar e continuar, para limpar a tela e inserir novo*/

        }

        private void DTIFormManutencao_Load(object sender, EventArgs e)
        {
            if (_OPERACAO == "a")
            {
                AtualizaTela();
            }

        }


        private string Gravar()
        {
            if (_OPERACAO == "a")
            {
                /*var dao = new PETDominioDAO();
                return dao.update(_Dominio);*/
            }
            else if (_OPERACAO == "i")
            {
                var dao = new TerrestreDAO();
                string retorno = dao.insert(_Dominio);
                if (!String.IsNullOrEmpty(retorno))
                {
                    MessageBox.Show(retorno);
                    return retorno;
                }
                else
                    Close();
            }

            return null;

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            /*
            AtualizarObjeto();

            if (!DTIFormsUtil.ValidarDominio(_Dominio))
                return;

            if (!DTIFormsUtil.TratarRetornoPersistencia(Gravar()))
                return;

            if (sender == btnGravar)
                Close();
            else if (sender == btnGravarContinuar)
            {
                LimparTela();
                textBox1.Focus();
            }
            */
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbEstepe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
