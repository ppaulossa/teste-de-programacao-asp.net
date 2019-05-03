using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace teste_de_programacao_asp.net
{
    public partial class ciatécnica : Form
    {
        private int tudoCerto;
        private String mensagem;
        private Regex validacao;
        private DateTime data;

        public ciatécnica()
        {
            data = new System.DateTime(DateTime.Today.Year - 19, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0, 0);
            InitializeComponent(data);
          
        }

        private void ButtonConfirmaPessoaFisica_Click(object sender, EventArgs e)
        {
            mensagem = string.Empty;
            tudoCerto = 0;
            validacao = new Regex(expressaoRegularCpf());
            mensagem += " * *****O FORMULÁRIO CONTÉM ERROS * ***** \n\n";

            if (validacao.IsMatch(maskedTextBoxCPF.Text))
            {
                labelCPF.ForeColor = Color.Black;
                tudoCerto++; // 1
            }
            else
            {
                labelCPF.ForeColor = Color.Red;
                mensagem += "- O CPF está incompleto ou em branco. \n";
            }

            // A idade permitida para cadastro de uma pessoa física deverá ser no mínimo de 19 anos.
            // A excessão está feita no desing.
            tudoCerto++; //2 Data de Nascimento.

                        validacao = new Regex(expressaoRegularSoNumeros());

            if(textBoxNome.TextLength == 0)
            {
                labelNome.ForeColor = Color.Red;
                mensagem += "- Preencha o nome da pessoa. \n";
            }else if (validacao.IsMatch(textBoxNome.Text))
            {
                labelNome.ForeColor = Color.Red;
                mensagem += "- Nome da pessoa Incorreta. \n";
            }
            else
            {
                labelNome.ForeColor = Color.Black;
                tudoCerto++; // 3
            }

            if(textBoxSobreNome.TextLength == 0)
            {
                labelSobreNome.ForeColor = Color.Red;
                mensagem += "- Preencha o sobrenome da pessoa. \n";
            }
            else if (validacao.IsMatch(textBoxSobreNome.Text))
            {
                labelSobreNome.ForeColor = Color.Red;
                mensagem += "- Sobrenome da pessoa Incorreta. \n";
            }
            else
            {
                labelSobreNome.ForeColor = Color.Black;
                tudoCerto++; // 4
            }

            validacao = new Regex(expressaoRegularSoNumeros());

            if(textBoxCEPFisica.TextLength == 0)
            {
                labelCEPFisica.ForeColor = Color.Red;
                mensagem += "- Preencha o CEP. \n";
            }else if (validacao.IsMatch(textBoxCEPFisica.Text))
            {
                if (textBoxCEPFisica.TextLength == 8)
                {
                    labelCEPFisica.ForeColor = Color.Black;
                    tudoCerto++; //5
                }
                else
                {
                    labelCEPFisica.ForeColor = Color.Red;
                    mensagem += "- CEP incompleto. \n";
                }
            }
            else
            {
                labelCEPFisica.ForeColor = Color.Red;
                mensagem += "- CEP incorreto. \n";
            }

            if(textBoxLogradouroFisica.TextLength == 0)
            {
                labelLogradouroFisica.ForeColor = Color.Red;
                mensagem += "- Preencha o logradouro. \n";

            }
            else
            {
                labelLogradouroFisica.ForeColor = Color.Black;
                tudoCerto++; //6
            }

            // Não tem o que tratar no numero de endereço.
            // Todos os campos devem ser de preenchimento obrigatório, exceto o campo complemento.

            if(textBoxBairroFisica.TextLength == 0)
            {
                labelBairroFisica.ForeColor = Color.Red;
                mensagem += "- Preencha o Bairro. \n";
            }
            else
            {
                labelBairroFisica.ForeColor = Color.Black;
                tudoCerto++; //7
            }

            if(textBoxCidadeFisica.TextLength == 0)
            {
                labelCidadeFisica.ForeColor = Color.Red;
                mensagem += "- Preencha a Cidade. \n";
            }
            else
            {
                labelCidadeFisica.ForeColor = Color.Black;
                tudoCerto++;//8
            }

            validacao = new Regex(expressaoRegularSoLetras());

            /*
             * Normalmente o UF tem (2 caracteres) mas como foi especificado com (8 caracteres) deixei assim.
             */

            if(textBoxUFFisica.TextLength == 0)
            {
                labelUFFisica.ForeColor = Color.Red;
                mensagem += "- Preencha o UF. \n";
            }
            else if(validacao.IsMatch(textBoxUFFisica.Text))
            {
                if (textBoxUFFisica.TextLength > 1)
                {
                    labelUFFisica.ForeColor = Color.Black;
                    tudoCerto++; //9
                }
                else
                {
                    labelUFFisica.ForeColor = Color.Red;
                    mensagem += "- Preencha o UF a cima de 2 caracteres. \n";
                }
            }
            else
            {
                labelUFFisica.ForeColor = Color.Red;
                mensagem += "- Preencha o UF com apenas letras. \n";
            }

            if(tudoCerto == 9)
            {
                maskedTextBoxCPF.Text = string.Empty;
                dateTimePickerDataNasimento.Value = DateTime.Now;
                textBoxNome.Text = string.Empty;
                textBoxSobreNome.Text = string.Empty;
                textBoxCEPFisica.Text = string.Empty;
                textBoxLogradouroFisica.Text = string.Empty;
                numericUpDownNumeroFisica.Value = 0;
                textBoxComplementoFisica.Text = string.Empty;
                textBoxBairroFisica.Text = string.Empty;
                textBoxCidadeFisica.Text = string.Empty;
                textBoxUFFisica.Text = string.Empty;

                MessageBox.Show("Dados Cadastrados Com Sucesso !!!","CONFIRMADO",MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                MessageBox.Show(mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }


        }

        private void ButtonConfirmaPessoaJuridica_Click(object sender, EventArgs e)
        {

            mensagem = string.Empty;
            tudoCerto = 0;
            validacao = new Regex(expressaoRegularCnpj());
            mensagem += " * *****O FORMULÁRIO CONTÉM ERROS * ***** \n\n";

            if (validacao.IsMatch(maskedTextBoxCNPJ.Text))
            {
                labelCNPJ.ForeColor = Color.Black;
                tudoCerto++; // 1
            }
            else
            {
                labelCNPJ.ForeColor = Color.Red;
                mensagem += "- O CNPJ está incompleto ou em branco. \n";
            }


            if(textBoxRazaoSocial.TextLength == 0)
            {
                labelRazaoSocial.ForeColor = Color.Red;
                mensagem += "- Preencha a Razão Social. \n";
            }
            else
            {
                labelRazaoSocial.ForeColor = Color.Black;
                tudoCerto++; //2
            }

            if(textBoxNomeFantasia.TextLength == 0)
            {
                labelNomeFantasia.ForeColor = Color.Red;
                mensagem += "- Preencha o nome fantasia. \n";
            }
            else
            {
                labelNomeFantasia.ForeColor = Color.Black;
                tudoCerto++; //3
            }

            validacao = new Regex(expressaoRegularSoNumeros());

            if (textBoxCEPJuridica.TextLength == 0)
            {
                labelCEPJuridica.ForeColor = Color.Red;
                mensagem += "- Preencha o CEP. \n";
            }
            else if (validacao.IsMatch(textBoxCEPJuridica.Text))
            {
                if (textBoxCEPJuridica.TextLength == 8)
                {
                    labelCEPJuridica.ForeColor = Color.Black;
                    tudoCerto++; //4
                }
                else
                {
                    labelCEPJuridica.ForeColor = Color.Red;
                    mensagem += "- CEP incompleto. \n";
                }
            }
            else
            {
                labelCEPJuridica.ForeColor = Color.Red;
                mensagem += "- CEP incorreto. \n";
            }

            if (textBoxLogradouroJuridica.TextLength == 0)
            {
                labelLogradouroJuridica.ForeColor = Color.Red;
                mensagem += "- Preencha o logradouro. \n";

            }
            else
            {
                labelLogradouroJuridica.ForeColor = Color.Black;
                tudoCerto++; //5
            }

            // Não tem o que tratar no numero de endereço.
            // Todos os campos devem ser de preenchimento obrigatório, exceto o campo complemento.

            if (textBoxBairroJuridica.TextLength == 0)
            {
                labelBairroJuridica.ForeColor = Color.Red;
                mensagem += "- Preencha o Bairro. \n";
            }
            else
            {
                labelBairroJuridica.ForeColor = Color.Black;
                tudoCerto++; //6
            }

            if (textBoxCidadeJuridica.TextLength == 0)
            {
                labelCidadeJuridica.ForeColor = Color.Red;
                mensagem += "- Preencha a Cidade. \n";
            }
            else
            {
                labelCidadeJuridica.ForeColor = Color.Black;
                tudoCerto++;//7
            }

            validacao = new Regex(expressaoRegularSoLetras());

            /*
             * Normalmente o UF tem (2 caracteres) mas como foi especificado com (8 caracteres) deixei assim.
             */

            if (textBoxUFJuridica.TextLength == 0)
            {
                labelUFJuridica.ForeColor = Color.Red;
                mensagem += "- Preencha o UF. \n";
            }
            else if (validacao.IsMatch(textBoxUFJuridica.Text))
            {
                if (textBoxUFJuridica.TextLength > 1)
                {
                    labelUFJuridica.ForeColor = Color.Black;
                    tudoCerto++; //8
                }
                else
                {
                    labelUFJuridica.ForeColor = Color.Red;
                    mensagem += "- Preencha o UF a cima de 2 caracteres. \n";
                }
            }
            else
            {
                labelUFJuridica.ForeColor = Color.Red;
                mensagem += "- Preencha o UF com apenas letras. \n";
            }

            if (tudoCerto == 8)
            {
                maskedTextBoxCNPJ.Text = string.Empty;
                textBoxRazaoSocial.Text = string.Empty;
                textBoxNomeFantasia.Text = string.Empty;
                textBoxCEPJuridica.Text = string.Empty;
                textBoxLogradouroJuridica.Text = string.Empty;
                numericUpDownNumeroJuridica.Value = 0;
                textBoxComplementoJuridica.Text = string.Empty;
                textBoxBairroJuridica.Text = string.Empty;
                textBoxCidadeJuridica.Text = string.Empty;
                textBoxUFJuridica.Text = string.Empty;
                MessageBox.Show("Dados Cadastrados Com Sucesso !!!", "CONFIRMADO", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button3, MessageBoxOptions.DefaultDesktopOnly);

            }
            else
            {
                MessageBox.Show(mensagem, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

        }

    
        public string expressaoRegularCpf()
        {
            return @"^[0-9]{3}\,[0-9]{3}\,[0-9]{3}\-[0-9]{2}$";
        }

        public string expressaoRegularCnpj()
        {
            return @"^[0-9]{2}\,[0-9]{3}\,[0-9]{3}\/[0-9]{4}\-[0-9]{2}$";
        }

        public string expressaoRegularSoNumeros()
        {
            return @"^[0-9]+$";
        }

        public string expressaoRegularSoLetras()
        {
            return @"^[a-zA-Z\s]+$";
        }


    }
}
