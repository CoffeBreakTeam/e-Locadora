﻿
namespace e_Locadora.WindowsApp.Features.DevolucaoModule
{
    partial class TelaDevolucaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlLocacao = new System.Windows.Forms.TabControl();
            this.tabPageLocacao = new System.Windows.Forms.TabPage();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdLocacao = new System.Windows.Forms.TextBox();
            this.labelPlano = new System.Windows.Forms.Label();
            this.tabPageClienteVeiculo = new System.Windows.Forms.TabPage();
            this.maskedTextBoxDataRetornoAtual = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxDataRetornoPrevisto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataLocacao = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtQtdCombustivelRetorno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuilometragemInicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuilometragemAtual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCaucao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTipoCombustivel = new System.Windows.Forms.TextBox();
            this.groupBoxVeiculo = new System.Windows.Forms.GroupBox();
            this.groupBoxLocacao = new System.Windows.Forms.GroupBox();
            this.groupBoxDatas = new System.Windows.Forms.GroupBox();
            this.tabControlLocacao.SuspendLayout();
            this.tabPageLocacao.SuspendLayout();
            this.tabPageClienteVeiculo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxVeiculo.SuspendLayout();
            this.groupBoxLocacao.SuspendLayout();
            this.groupBoxDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlLocacao
            // 
            this.tabControlLocacao.Controls.Add(this.tabPageLocacao);
            this.tabControlLocacao.Controls.Add(this.tabPageClienteVeiculo);
            this.tabControlLocacao.Controls.Add(this.tabPage1);
            this.tabControlLocacao.Controls.Add(this.tabPage2);
            this.tabControlLocacao.Location = new System.Drawing.Point(12, 12);
            this.tabControlLocacao.Name = "tabControlLocacao";
            this.tabControlLocacao.SelectedIndex = 0;
            this.tabControlLocacao.Size = new System.Drawing.Size(323, 234);
            this.tabControlLocacao.TabIndex = 87;
            // 
            // tabPageLocacao
            // 
            this.tabPageLocacao.Controls.Add(this.groupBoxLocacao);
            this.tabPageLocacao.Controls.Add(this.label2);
            this.tabPageLocacao.Controls.Add(this.txtIdLocacao);
            this.tabPageLocacao.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocacao.Name = "tabPageLocacao";
            this.tabPageLocacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocacao.Size = new System.Drawing.Size(315, 208);
            this.tabPageLocacao.TabIndex = 0;
            this.tabPageLocacao.Text = "Locação";
            this.tabPageLocacao.UseVisualStyleBackColor = true;
            // 
            // txtCondutor
            // 
            this.txtCondutor.Enabled = false;
            this.txtCondutor.Location = new System.Drawing.Point(65, 72);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.Size = new System.Drawing.Size(104, 20);
            this.txtCondutor.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Condutor";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(65, 46);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(104, 20);
            this.txtCliente.TabIndex = 31;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Enabled = false;
            this.txtVeiculo.Location = new System.Drawing.Point(65, 19);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(104, 20);
            this.txtVeiculo.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // txtIdLocacao
            // 
            this.txtIdLocacao.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtIdLocacao.Enabled = false;
            this.txtIdLocacao.Location = new System.Drawing.Point(32, 12);
            this.txtIdLocacao.Name = "txtIdLocacao";
            this.txtIdLocacao.Size = new System.Drawing.Size(77, 20);
            this.txtIdLocacao.TabIndex = 1;
            this.txtIdLocacao.Text = "0";
            // 
            // labelPlano
            // 
            this.labelPlano.AutoSize = true;
            this.labelPlano.Location = new System.Drawing.Point(17, 22);
            this.labelPlano.Name = "labelPlano";
            this.labelPlano.Size = new System.Drawing.Size(42, 13);
            this.labelPlano.TabIndex = 15;
            this.labelPlano.Text = "Veiculo";
            // 
            // tabPageClienteVeiculo
            // 
            this.tabPageClienteVeiculo.Controls.Add(this.groupBoxDatas);
            this.tabPageClienteVeiculo.Location = new System.Drawing.Point(4, 22);
            this.tabPageClienteVeiculo.Name = "tabPageClienteVeiculo";
            this.tabPageClienteVeiculo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClienteVeiculo.Size = new System.Drawing.Size(315, 208);
            this.tabPageClienteVeiculo.TabIndex = 1;
            this.tabPageClienteVeiculo.Text = "Datas";
            this.tabPageClienteVeiculo.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxDataRetornoAtual
            // 
            this.maskedTextBoxDataRetornoAtual.Location = new System.Drawing.Point(118, 71);
            this.maskedTextBoxDataRetornoAtual.Mask = "00/00/0000";
            this.maskedTextBoxDataRetornoAtual.Name = "maskedTextBoxDataRetornoAtual";
            this.maskedTextBoxDataRetornoAtual.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBoxDataRetornoAtual.TabIndex = 38;
            this.maskedTextBoxDataRetornoAtual.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Devolução Atual";
            // 
            // maskedTextBoxDataRetornoPrevisto
            // 
            this.maskedTextBoxDataRetornoPrevisto.Enabled = false;
            this.maskedTextBoxDataRetornoPrevisto.Location = new System.Drawing.Point(118, 45);
            this.maskedTextBoxDataRetornoPrevisto.Mask = "00/00/0000";
            this.maskedTextBoxDataRetornoPrevisto.Name = "maskedTextBoxDataRetornoPrevisto";
            this.maskedTextBoxDataRetornoPrevisto.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBoxDataRetornoPrevisto.TabIndex = 36;
            this.maskedTextBoxDataRetornoPrevisto.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDataLocacao
            // 
            this.maskedTextBoxDataLocacao.Enabled = false;
            this.maskedTextBoxDataLocacao.Location = new System.Drawing.Point(118, 19);
            this.maskedTextBoxDataLocacao.Mask = "00/00/0000";
            this.maskedTextBoxDataLocacao.Name = "maskedTextBoxDataLocacao";
            this.maskedTextBoxDataLocacao.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBoxDataLocacao.TabIndex = 35;
            this.maskedTextBoxDataLocacao.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Devolução Prevista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Data Locação";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxVeiculo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(315, 208);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Combustivel e km";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtQtdCombustivelRetorno
            // 
            this.txtQtdCombustivelRetorno.Location = new System.Drawing.Point(157, 97);
            this.txtQtdCombustivelRetorno.Name = "txtQtdCombustivelRetorno";
            this.txtQtdCombustivelRetorno.Size = new System.Drawing.Size(104, 20);
            this.txtQtdCombustivelRetorno.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Quantidade de Combustivel";
            // 
            // txtQuilometragemInicial
            // 
            this.txtQuilometragemInicial.Enabled = false;
            this.txtQuilometragemInicial.Location = new System.Drawing.Point(157, 19);
            this.txtQuilometragemInicial.Name = "txtQuilometragemInicial";
            this.txtQuilometragemInicial.Size = new System.Drawing.Size(104, 20);
            this.txtQuilometragemInicial.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Quilometragem Inicial";
            // 
            // txtQuilometragemAtual
            // 
            this.txtQuilometragemAtual.Location = new System.Drawing.Point(157, 45);
            this.txtQuilometragemAtual.Name = "txtQuilometragemAtual";
            this.txtQuilometragemAtual.Size = new System.Drawing.Size(104, 20);
            this.txtQuilometragemAtual.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quilometragem Atual";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCaucao);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtValorTotal);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(315, 208);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Financeiro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCaucao
            // 
            this.txtCaucao.Location = new System.Drawing.Point(118, 41);
            this.txtCaucao.Name = "txtCaucao";
            this.txtCaucao.Size = new System.Drawing.Size(104, 20);
            this.txtCaucao.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Caução";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(118, 84);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(104, 20);
            this.txtValorTotal.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Valor Total";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(256, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 89;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(175, 252);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 88;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Tipo de Combustivel";
            // 
            // txtTipoCombustivel
            // 
            this.txtTipoCombustivel.Location = new System.Drawing.Point(157, 71);
            this.txtTipoCombustivel.Name = "txtTipoCombustivel";
            this.txtTipoCombustivel.Size = new System.Drawing.Size(104, 20);
            this.txtTipoCombustivel.TabIndex = 38;
            // 
            // groupBoxVeiculo
            // 
            this.groupBoxVeiculo.Controls.Add(this.txtTipoCombustivel);
            this.groupBoxVeiculo.Controls.Add(this.txtQuilometragemInicial);
            this.groupBoxVeiculo.Controls.Add(this.label12);
            this.groupBoxVeiculo.Controls.Add(this.label5);
            this.groupBoxVeiculo.Controls.Add(this.txtQtdCombustivelRetorno);
            this.groupBoxVeiculo.Controls.Add(this.label9);
            this.groupBoxVeiculo.Controls.Add(this.txtQuilometragemAtual);
            this.groupBoxVeiculo.Controls.Add(this.label4);
            this.groupBoxVeiculo.Location = new System.Drawing.Point(6, 6);
            this.groupBoxVeiculo.Name = "groupBoxVeiculo";
            this.groupBoxVeiculo.Size = new System.Drawing.Size(303, 135);
            this.groupBoxVeiculo.TabIndex = 39;
            this.groupBoxVeiculo.TabStop = false;
            this.groupBoxVeiculo.Text = "Veículo";
            // 
            // groupBoxLocacao
            // 
            this.groupBoxLocacao.Controls.Add(this.txtCondutor);
            this.groupBoxLocacao.Controls.Add(this.txtVeiculo);
            this.groupBoxLocacao.Controls.Add(this.txtCliente);
            this.groupBoxLocacao.Controls.Add(this.labelPlano);
            this.groupBoxLocacao.Controls.Add(this.label8);
            this.groupBoxLocacao.Controls.Add(this.label3);
            this.groupBoxLocacao.Location = new System.Drawing.Point(9, 38);
            this.groupBoxLocacao.Name = "groupBoxLocacao";
            this.groupBoxLocacao.Size = new System.Drawing.Size(303, 113);
            this.groupBoxLocacao.TabIndex = 90;
            this.groupBoxLocacao.TabStop = false;
            this.groupBoxLocacao.Text = "Locação";
            // 
            // groupBoxDatas
            // 
            this.groupBoxDatas.Controls.Add(this.maskedTextBoxDataRetornoAtual);
            this.groupBoxDatas.Controls.Add(this.maskedTextBoxDataLocacao);
            this.groupBoxDatas.Controls.Add(this.maskedTextBoxDataRetornoPrevisto);
            this.groupBoxDatas.Controls.Add(this.label7);
            this.groupBoxDatas.Controls.Add(this.label6);
            this.groupBoxDatas.Controls.Add(this.label1);
            this.groupBoxDatas.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDatas.Name = "groupBoxDatas";
            this.groupBoxDatas.Size = new System.Drawing.Size(303, 109);
            this.groupBoxDatas.TabIndex = 91;
            this.groupBoxDatas.TabStop = false;
            this.groupBoxDatas.Text = "Datas";
            // 
            // TelaDevolucaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 326);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.tabControlLocacao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaDevolucaoForm";
            this.Text = "Devolução";
            this.tabControlLocacao.ResumeLayout(false);
            this.tabPageLocacao.ResumeLayout(false);
            this.tabPageLocacao.PerformLayout();
            this.tabPageClienteVeiculo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxVeiculo.ResumeLayout(false);
            this.groupBoxVeiculo.PerformLayout();
            this.groupBoxLocacao.ResumeLayout(false);
            this.groupBoxLocacao.PerformLayout();
            this.groupBoxDatas.ResumeLayout(false);
            this.groupBoxDatas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLocacao;
        private System.Windows.Forms.TabPage tabPageLocacao;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdLocacao;
        private System.Windows.Forms.Label labelPlano;
        private System.Windows.Forms.TabPage tabPageClienteVeiculo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataRetornoAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataRetornoPrevisto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataLocacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtQtdCombustivelRetorno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuilometragemInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuilometragemAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaucao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTipoCombustivel;
        private System.Windows.Forms.GroupBox groupBoxLocacao;
        private System.Windows.Forms.GroupBox groupBoxDatas;
        private System.Windows.Forms.GroupBox groupBoxVeiculo;
    }
}