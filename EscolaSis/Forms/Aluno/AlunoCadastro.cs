﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EscolaSis.Forms.Aluno
{
    public partial class AlunoCadastro : Form
    {

        public AlunoCadastro()
        {
            InitializeComponent();
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            Form childForm = new AlunoNovo();
            childForm.ShowDialog();
        }

        private void itmParcela_Click(object sender, EventArgs e)
        {
            Form childForm = new MensalidadeManter();
            childForm.ShowDialog();
        }

        private void itmParcelamento_Click(object sender, EventArgs e)
        {
            Form childForm = new MensalidadesPeriodo();
            childForm.ShowDialog();
        }

        private void txbDataNascimAluno_ValueChanged(object sender, EventArgs e)
        {
            txbDataNascimAluno.CustomFormat = "dd/MM/yyyy";
            txbIdadeAluno.Text = Model.Aluno.CalculaIdade(txbDataNascimAluno.Value).ToString();
            txbIdadeAluno.Text += Convert.ToInt16(txbIdadeAluno.Text) > 1 ? " anos" : " ano";
        }

        private void txbDataNascimAluno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txbDataNascimAluno.CustomFormat = " ";
                txbIdadeAluno.Text = "";
            }
        }

        private void mnuMudarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists("Fotos"))
                {
                    Directory.CreateDirectory("Fotos");
                }

                pbxFoto.ImageLocation = file.FileName;
                pbxFoto.Load();
            }
        }

        private void mnuLimparFoto_Click(object sender, EventArgs e)
        {
            pbxFoto.ImageLocation = "SemFoto.png";
            pbxFoto.Load();
        }

        private void pbxFoto_Click_1(object sender, EventArgs e)
        {
            mnuFoto.Show(Cursor.Position);
        }

        private void dgvListaAlunoBuscar_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Model.Aluno aluno = new Model.Aluno();

            if (dgvListaAlunoBuscar.SelectedRows.Count > 0) txbAlunoID.Text = dgvListaAlunoBuscar.SelectedRows[0].Cells[0].Value.ToString();
            else txbAlunoID.Text = "0";

            aluno.DadosAluno(Convert.ToInt16(txbAlunoID.Text));

            cbxRelacAluno.DataSource = Model.Tools.Parenteso.ListaParentesco();

            cbxAnoLetivoMatric.DataSource = Model.Tools.ListaAnoLetivo();
            //cbxPeriodoLetivoMatri.DataSource = Model.Tools.PeriodoLetivo.ListaPeriodoLetivo();

            cbxAnoLetivoMatricula.DataSource = Model.Tools.ListaAnoLetivo();
            cbxPeriodoLetivoMatricula.DataSource = Model.Tools.PeriodoLetivo.ListaPeriodoLetivo(true);
            cbxOrientadorMatricula.DataSource = (new Model.Orientador()).ListaOrientadores();
            cbxResultadoMatricula.DataSource = Model.Tools.ResultadoFinal.ListaResultadoFinal();
            cbxTurmaMatricula.DataSource = Model.Tools.ListaTurma();

            cbxAnoReferMensal.DataSource = Model.Tools.ListaAnoLetivo();
            cbxSituacMensaliade.Text = "Qualquer Situação";

            List<Model.Responsavel> listaResponsaveis = Model.Aluno.ListarResponsaveisAluno(Convert.ToInt16(txbAlunoID.Text));
            List<Model.Matricula> listaMatriculas = Model.Aluno.ListarMatriculasAluno(Convert.ToInt16(txbAlunoID.Text), cbxAnoReferMensal.SelectedValue.ToString());
            List<Model.Mensalidade> listaMensalidades = Model.Aluno.ListarMensalidadesAluno(Convert.ToInt16(txbAlunoID.Text), cbxAnoReferMensal.SelectedValue.ToString());

            // dados do aluno
            txbNumMatricAluno.Text = aluno.NumMatricula;
            txbNomeAluno.Text = aluno.Nome;
            txbIdadeAluno.Text = "";
            txbDataNascimAluno.CustomFormat = " ";
            if (aluno.DataNascim.Year > 1900)
            {
                txbDataNascimAluno.CustomFormat = "dd/MM/yyyy";
                txbDataNascimAluno.Value = aluno.DataNascim;
                txbIdadeAluno.Text = aluno.Idade.ToString();
                txbIdadeAluno.Text += Convert.ToInt16(txbIdadeAluno.Text) > 1 ? " anos" : " ano";
            }
            txbNumRGAluno.Text = aluno.RG;
            txbCPFAluno.Text = aluno.CPF;
            rbtMasc.Checked = (aluno.Sexo == "M");
            rbtFemin.Checked = !rbtMasc.Checked;
            txbEnderecoAluno.Text = aluno.Endereco;
            txbBairroAluno.Text = aluno.Bairro;
            txbCidadeAluno.Text = aluno.Cidade;
            txbCEPAluno.Text = aluno.CEP;
            txbTelefoneAluno.Text = aluno.Telefone;
            if (File.Exists(@"Fotos\Aluno" + aluno.AlunoID.ToString() + ".jpg"))
            {
                pbxFoto.ImageLocation = @"Fotos\Aluno" + aluno.AlunoID.ToString() + ".jpg";
                pbxFoto.Load();
            }
            else
            {
                pbxFoto.ImageLocation = null;
                pbxFoto.Image = pbxFoto.InitialImage;
            }

            //dados dos responsaveis
            txbNumMatricResp.Text = aluno.NumMatricula;
            txbNomeAlunoResp.Text = aluno.Nome;
            dgvAlunoResponsaveis.DataSource = listaResponsaveis;

            //dados das matrículas
            txbNumMatricMatric.Text = aluno.NumMatricula;
            txbNomeAlunoMatric.Text = aluno.Nome;
            dgvAlunoDisciplinas.DataSource = listaMatriculas;

            //dados das mensalidades
            txbNumMatricMensal.Text = aluno.NumMatricula;
            txbNomeAlunoMensal.Text = aluno.Nome;
            dgvAlunoMensalidades.DataSource = listaMensalidades;

            this.Cursor = Cursors.Default;

        }
        private void dgvAlunoResponsaveis_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlunoResponsaveis.SelectedRows.Count > 0)
            {
                Model.Responsavel responsavel = new Model.Responsavel();
                responsavel.DadosResponsavel((int)dgvAlunoResponsaveis.SelectedRows[0].Cells[0].Value);
                txbTutorAlunoID.Text = responsavel.TutorAlunoID.ToString();
                cbxResponsNome.Text = responsavel.Nome;
                txbTelefoneRespons.Text = responsavel.Telefone;
                cbxRelacAluno.Text = responsavel.RelacaoAlunoDescr;
                ckbPagador.Checked = (responsavel.Pagador == "S");
                ckbPodePegar.Checked = (responsavel.PodePegarEscola == "S");
            }

        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            List<Model.Aluno> lst = Model.Aluno.ListarAlunosPesquisa(txbBuscarAluno.Text);
            dgvListaAlunoBuscar.DataSource = lst;
            this.Cursor = Cursors.Default;
        }

        private void dgvAlunoDisciplinas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlunoDisciplinas.SelectedRows.Count > 0)
            {
                Model.Matricula matricula = new Model.Matricula();
                matricula.DadosMatricula((int)dgvAlunoDisciplinas.SelectedRows[0].Cells[0].Value);
                cbxAnoLetivoMatricula.Text = matricula.AnoLetivo;
                cbxPeriodoLetivoMatricula.Text = matricula.NomePeriodo;
                cbxOrientadorMatricula.Text = matricula.NomeOrientador;
                txbDisciplinaMatricula.Text = matricula.Disciplina;
                cbxTurmaMatricula.Text = matricula.Turma;
                cbxResultadoMatricula.Text = matricula.ResultadoFinalDescr;
                txbRelatorioMatricula.Text = matricula.RelatorioAtividade;
            }
        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            if (txbAlunoID.Text != "")
            {

                Model.Aluno alunoUpdate = new Model.Aluno();
                alunoUpdate.AlunoID = Convert.ToInt16(txbAlunoID.Text);
                alunoUpdate.Nome = txbNomeAluno.Text;
                if (txbDataNascimAluno.CustomFormat.Trim() != "") alunoUpdate.DataNascim = Convert.ToDateTime(txbDataNascimAluno.Text);
                alunoUpdate.RG = txbNumRGAluno.Text;
                alunoUpdate.CPF = txbCPFAluno.Text;
                alunoUpdate.Sexo = rbtMasc.Checked ? "M" : "F";
                alunoUpdate.Endereco = txbEnderecoAluno.Text;
                alunoUpdate.Bairro = txbBairroAluno.Text;
                alunoUpdate.Cidade = txbCidadeAluno.Text;
                alunoUpdate.CEP = txbCEPAluno.Text;
                alunoUpdate.Telefone = txbTelefoneAluno.Text;

                try
                {
                    alunoUpdate.SalvarAluno("U");

                    GravaFoto();

                    MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Aluno para gravar os dados.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void GravaFoto()
        {
            string velhaFoto = @"Fotos\Aluno" + txbAlunoID.Text + ".jpg";
            if (pbxFoto.Image == pbxFoto.InitialImage)
            {
                if (File.Exists(velhaFoto))
                    File.Delete(velhaFoto);
            }
            else
            {
                string novaFoto = pbxFoto.ImageLocation;
                if (novaFoto != velhaFoto)
                {
                    pbxFoto.ImageLocation = @"SemFoto.png";
                    pbxFoto.Load();
                    File.Copy(novaFoto, @"Fotos\Aluno" + txbAlunoID.Text + ".jpg", true);
                    pbxFoto.ImageLocation = @"Fotos\Aluno" + txbAlunoID.Text + ".jpg";
                    pbxFoto.Load();
                }

            }
        }

        public static string GirarFoto(Image ImageTransf)
        {
            ImageTransf.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ImageTransf.Save("fototemp.jpg");
            return "fototemp.jpg";
        }

        private void girarAFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image foto = pbxFoto.Image;
            pbxFoto.ImageLocation = "SemFoto.png";
            pbxFoto.Load();
            pbxFoto.ImageLocation = GirarFoto(foto);
            pbxFoto.Load();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarRespos_Click(object sender, EventArgs e)
        {
            if (txbTutorAlunoID.Text != "")
            {
                Model.Responsavel responsavelUpdate = new Model.Responsavel();
                responsavelUpdate.TutorAlunoID = Convert.ToInt16(txbTutorAlunoID.Text);
                responsavelUpdate.RelacaoAluno = cbxRelacAluno.Text;
                responsavelUpdate.Pagador = ckbPagador.Checked ? "S" : "N";
                responsavelUpdate.PodePegarEscola = ckbPodePegar.Checked ? "S" : "N";

                try
                {
                    responsavelUpdate.SalvarResponsavelAluno("U");
                    dgvAlunoResponsaveis.DataSource = Model.Aluno.ListarResponsaveisAluno(Convert.ToInt16(txbAlunoID.Text));
                    MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Responsável pelo Aluno para gravar os dados.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRespoNovo_Click(object sender, EventArgs e)
        {
            if (this.txbAlunoID.Text != "")
            {
                Form childForm = new ResponsavelNovo(txbAlunoID.Text);
                childForm.ShowDialog();
                dgvAlunoResponsaveis.DataSource = Model.Aluno.ListarResponsaveisAluno(Convert.ToInt16(txbAlunoID.Text));

            }
            else
            {
                MessageBox.Show("Selecione um Aluno para incluir o responsável.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGravarMatricula_Click(object sender, EventArgs e)
        {
            if (dgvAlunoDisciplinas.Rows.Count > 0)
            {
                if ((Convert.ToInt16("0" + cbxAnoLetivoMatricula.Text)) <= 1980 && (Convert.ToInt16("0" + cbxAnoLetivoMatricula.Text) > DateTime.Now.Year + 1))
                {
                    MessageBox.Show("Ano letivo inválido.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxAnoLetivoMatricula.Focus();
                    return;
                };

                Model.Matricula matriculaUpdate = new Model.Matricula();
                matriculaUpdate.MatriculaID = Convert.ToInt16(dgvAlunoDisciplinas.SelectedRows[0].Cells[0].Value);
                matriculaUpdate.OrientadorID = Convert.ToInt16(cbxOrientadorMatricula.SelectedValue.ToString());
                matriculaUpdate.AnoLetivo = cbxAnoLetivoMatricula.Text;
                matriculaUpdate.Disciplina = txbDisciplinaMatricula.Text;
                matriculaUpdate.CodigoPeriodo = cbxPeriodoLetivoMatricula.SelectedValue.ToString();
                matriculaUpdate.Turma = cbxTurmaMatricula.Text;
                matriculaUpdate.ResultadoFinal = cbxResultadoMatricula.SelectedValue.ToString();
                matriculaUpdate.RelatorioAtividade = txbRelatorioMatricula.Text;

                try
                {
                    matriculaUpdate.SalvarMatriculaAluno("U");
                    dgvAlunoDisciplinas.DataSource = Model.Aluno.ListarMatriculasAluno(Convert.ToInt16(txbAlunoID.Text), cbxAnoLetivoMatric.SelectedValue.ToString());
                    MessageBox.Show("Dados gravados com sucesso!", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um Matrícula do Aluno para gravar os dados.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cbxAnoLetivoMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNovaMatricula_Click(object sender, EventArgs e)
        {
            if (this.txbAlunoID.Text != "")
            {
                Form childForm = new MatricNova(txbAlunoID.Text);
                childForm.ShowDialog();
                dgvAlunoDisciplinas.DataSource = Model.Aluno.ListarMatriculasAluno(Convert.ToInt16(txbAlunoID.Text), cbxAnoLetivoMatric.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Selecione um Aluno para incluir o responsável.", "EscolaSis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxAnoLetivoMatric_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAlunoDisciplinas.DataSource = Model.Aluno.ListarMatriculasAluno(Convert.ToInt16(txbAlunoID.Text), cbxAnoLetivoMatric.SelectedValue.ToString());
        }

        private void cbxAnoReferMensal_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAlunoMensalidades.DataSource = Model.Aluno.ListarMensalidadesAluno(Convert.ToInt16(txbAlunoID.Text), cbxAnoReferMensal.SelectedValue.ToString(), codigoSitPagto(cbxSituacMensaliade.SelectedIndex) );
        }

        private void cbxSituacMensaliade_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAlunoMensalidades.DataSource = Model.Aluno.ListarMensalidadesAluno(Convert.ToInt16(txbAlunoID.Text), cbxAnoReferMensal.SelectedValue.ToString(), codigoSitPagto(cbxSituacMensaliade.SelectedIndex));
        }

        public static string codigoSitPagto(int sitPagIndex)
        {
            switch (sitPagIndex)
            {
                case 0 : return "%";
                case 1: return "%Pago";
                case 2 : return "%Aberto";
                default: return "%";
            }
        }
    }
}

