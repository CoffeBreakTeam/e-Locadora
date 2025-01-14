﻿using e_Locadora.Controladores.LocacaoModule;
using e_Locadora.Dominio.LocacaoModule;
using e_Locadora.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Locadora.WindowsApp.Features.LocacaoModule
{
    public partial class TabelaLocacaoControl : UserControl
    {

        public ControladorLocacao controladorLocacao = new ControladorLocacao();


        public TabelaLocacaoControl()
        {
            InitializeComponent();
            gridLocacao.ConfigurarGridZebrado();
            gridLocacao.ConfigurarGridSomenteLeitura();
            gridLocacao.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
{
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "funcionario", HeaderText = "Funcionário"},

                new DataGridViewTextBoxColumn { DataPropertyName = "cliente", HeaderText = "Cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "veiculo", HeaderText = "Veículo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "condutor", HeaderText = "Condutor"},

                new DataGridViewTextBoxColumn { DataPropertyName = "dataLocacao", HeaderText = "Data de Locação"},

                new DataGridViewTextBoxColumn { DataPropertyName = "dataDevolucao", HeaderText = "Data de Devolução"},

                new DataGridViewTextBoxColumn { DataPropertyName = "emAberto", HeaderText = "Em Aberto"},

};

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridLocacao.SelecionarId<int>();
        }

        public void AtualizarRegistros()
        {
            var locacao = controladorLocacao.SelecionarTodos();

            CarregarTabela(locacao);
        }

        public void AtualizarLocacoesEmailsPendentes()
        {
            var locacao = controladorLocacao.SelecionarLocacoesEmailPendente();

            CarregarTabela(locacao);
        }

        public void CarregarTabela(List<Locacao> locacaos)
        {
            gridLocacao.DataSource = locacaos;
        }
    }
}
