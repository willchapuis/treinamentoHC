
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
            tbNomeAutomovel.Text = _Dominio.Auto.nome_automovel;
            pickerDataFabricacao.Value = _Dominio.Auto.data_fabricacao;
            nudTanqueCombustivel.Value = _Dominio.Auto.tanque_combustivel;
            nudKMLitro.Value = _Dominio.Auto.km_por_litro;
            nudNroRodas.Value = _Dominio.nro_rodas;
            if(_Dominio.estepe)
                cbEstepe.Checked = true;
        }

        private void AtualizarObjeto()
        {
            if (_Dominio == null)
                _Dominio = new Terrestre();

            if(_Dominio.Auto == null)
                _Dominio.Auto = new Automovel();

            _Dominio.Auto.nome_automovel = tbNomeAutomovel.Text;
            _Dominio.Auto.data_fabricacao = pickerDataFabricacao.Value;
            _Dominio.Auto.tanque_combustivel = Convert.ToInt32(nudTanqueCombustivel.Value);
            _Dominio.Auto.km_por_litro = Convert.ToInt32(nudKMLitro.Value);
            _Dominio.nro_rodas = Convert.ToInt32(nudNroRodas.Value);
            if (cbEstepe.Checked)
                _Dominio.estepe = true;
        }

        private void LimparTela()
        {
            tbNomeAutomovel.Clear();
            pickerDataFabricacao.Value = DateTime.Now;
            nudTanqueCombustivel.Value = 10;
            nudKMLitro.Value = 1;
            nudNroRodas.Value = 1;
            cbEstepe.Checked = false;
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
                var dao = new TerrestreDAO();
                return dao.update(_Dominio);
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
                tbNomeAutomovel.Focus();
            }
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
