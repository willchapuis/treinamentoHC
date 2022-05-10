using DeskUtilDLL;


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
using UtilDLL;

namespace FabricaAutomoveis.Forms
{
    public partial class AUTO0001 : NTIForm
    {

        #region INICIALIZACAO
        public AUTO0001()
        {
            InitializeComponent();
            configuraForm();
        }
        private void DTIFormPadrao_Load(object sender, EventArgs e)
        {
            Consultar();
        }
        #endregion

        #region METODOS
        private void Consultar()
        {
            var filtros = new NTIFiltro();

            if (!String.IsNullOrEmpty(tbNomeAutomovel.Text))
                filtros.adiciona("NOME_AUTOMOVEL", tbNomeAutomovel.Text, typeof(string), NTIFiltro._permuta);

            if (!String.IsNullOrEmpty(deDataFabricacao.Text))
                filtros.adiciona("DATA_FABRICACAO", deDataFabricacao.Text, typeof(string), NTIFiltro._igual);

            dgvPrincipal.DataSource = new TerrestreDAO().Listar(filtros);
            dgvPrincipal.Refresh();

            //if (!String.IsNullOrEmpty(tbNome.Text))
            //    filtros.adiciona("nom_animal",
            //                     tbNome.Text,
            //                     typeof(string),
            //                     NTIFiltro._permuta);

            //if (!String.IsNullOrEmpty(deInicio.Text))
            //    filtros.adiciona("dat_nascimento",
            //                     deInicio.DateTime,
            //                     typeof(DateTime),
            //                     NTIFiltro._maior);

            dgvPrincipal.DataSource = new TerrestreDAO().Listar(filtros);
            dgvPrincipal.Refresh();
        }

        private void Incluir()
        {
            var Manutencao = new AUTO0001mn(null, "i");
            Manutencao.ShowDialog();
            Consultar();
        }

        private void Editar()
        {
            var lista = dgvPrincipal.DataSource as List<TerrestreDTO>;

            int indiceSelecionado = gridViewPrincipal.GetDataSourceRowIndex(gridViewPrincipal.FocusedRowHandle);

            var animalselecionado = lista[indiceSelecionado];

            var animal = new TerrestreDAO().Get(animalselecionado.id_automovel);

            var form = new AUTO0001mn(animal, "a");
            form.ShowDialog();

            Consultar();
        }

        private void Excluir()
        {
            if (!DeskUtil.getResposta("Deseja realmente excluir?"))
                return;

            var lista = dgvPrincipal.DataSource as List<TerrestreDTO>;

            int indiceSelecionado = gridViewPrincipal.GetDataSourceRowIndex(gridViewPrincipal.FocusedRowHandle);

            var animalselecionado = lista[indiceSelecionado];

            var animal = new TerrestreDAO().Get(animalselecionado.id_automovel);

            if (DTIFormsUtil.TratarRetornoPersistencia(new TerrestreDAO().delete(animal)))
                Consultar();
        }

        private void SobreOPrograma()
        {
            DeskUtil.mostrarMensagemInformativa("Este programa tem por objetivo o cadastro de Animais", "Informação");
        }

        private void MenuClick(object sender, EventArgs e)
        {
            if (sender == miEditar)
                Editar();
            else if (sender == miNovo)
                Incluir();
            else if (sender == miExcluir)
                Excluir();
            else if (sender == miSobreOPrograma)
                SobreOPrograma();
            else if (sender == miSair)
                Close();
        }

        #endregion

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void repositoryEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void repositoryExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }
    }
}
