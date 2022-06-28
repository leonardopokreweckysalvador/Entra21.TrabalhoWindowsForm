﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.TrabalhoWindowsForm
{
    public partial class PessoaForm : Form
    {
        private PessoaServico pessoaServico;

        public PessoaForm()
        {
            InitializeComponent();
            pessoaServico = new PessoaServico();
            ListarPessoas();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarPessoa(int nome, DateTime dataNascimento, Endereco endereco, string Sexo, string Cpf, string Rg)
        {

        }

        private void EditarDados(int nome, DateTime dataNascimento, Endereco endereco, string Sexo, string Cpf, string Rg)
        {

        }

        private void ListarPessoas()
        {
            var pessoas = pessoaServico.ObterTodas();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < pessoas.Count; i++)
            {
                var pessoa = pessoas[i];
                dataGridView1.Rows.Add(new object[]
                {
                    pessoa.Codigo,
                    pessoa.Nome,
                    pessoa.DataNascimento,
                    pessoa.Endereco,
                    pessoa.Sexo,
                    pessoa.Cpf,
                    pessoa.Rg
                });
                dataGridView1.ClearSelection();
            }
        }

        private void LimparCampos()
        {

        }

        private void PessoaForm_Load(object sender, EventArgs e)
        {
            ListarPessoas();
        }

        private void labelSexo_Click(object sender, EventArgs e)
        {

        }

    }
}
