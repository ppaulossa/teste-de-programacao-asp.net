using System;

namespace teste_de_programacao_asp.net
{
    partial class ciatécnica
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent(DateTime data)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ciatécnica));
            this.buttonConfirmaPessoaJuridica = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePessoaFisica = new System.Windows.Forms.TabPage();
            this.textBoxSobreNome = new System.Windows.Forms.TextBox();
            this.buttonConfirmaPessoaFisica = new System.Windows.Forms.Button();
            this.textBoxUFFisica = new System.Windows.Forms.TextBox();
            this.labelUFFisica = new System.Windows.Forms.Label();
            this.textBoxCidadeFisica = new System.Windows.Forms.TextBox();
            this.labelCidadeFisica = new System.Windows.Forms.Label();
            this.textBoxBairroFisica = new System.Windows.Forms.TextBox();
            this.labelBairroFisica = new System.Windows.Forms.Label();
            this.textBoxComplementoFisica = new System.Windows.Forms.TextBox();
            this.labelComplementoFisica = new System.Windows.Forms.Label();
            this.numericUpDownNumeroFisica = new System.Windows.Forms.NumericUpDown();
            this.labelNumeroFisica = new System.Windows.Forms.Label();
            this.textBoxLogradouroFisica = new System.Windows.Forms.TextBox();
            this.labelLogradouroFisica = new System.Windows.Forms.Label();
            this.textBoxCEPFisica = new System.Windows.Forms.TextBox();
            this.labelCEPFisica = new System.Windows.Forms.Label();
            this.labelSobreNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.dateTimePickerDataNasimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.tabPagePessoaJuridica = new System.Windows.Forms.TabPage();
            this.textBoxUFJuridica = new System.Windows.Forms.TextBox();
            this.labelUFJuridica = new System.Windows.Forms.Label();
            this.textBoxCidadeJuridica = new System.Windows.Forms.TextBox();
            this.labelCidadeJuridica = new System.Windows.Forms.Label();
            this.textBoxBairroJuridica = new System.Windows.Forms.TextBox();
            this.labelBairroJuridica = new System.Windows.Forms.Label();
            this.textBoxComplementoJuridica = new System.Windows.Forms.TextBox();
            this.labelComplementoJuridica = new System.Windows.Forms.Label();
            this.numericUpDownNumeroJuridica = new System.Windows.Forms.NumericUpDown();
            this.labelNumeroJuridica = new System.Windows.Forms.Label();
            this.textBoxLogradouroJuridica = new System.Windows.Forms.TextBox();
            this.labelLogradouroJuridica = new System.Windows.Forms.Label();
            this.textBoxCEPJuridica = new System.Windows.Forms.TextBox();
            this.labelCEPJuridica = new System.Windows.Forms.Label();
            this.textBoxNomeFantasia = new System.Windows.Forms.TextBox();
            this.labelNomeFantasia = new System.Windows.Forms.Label();
            this.textBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.labelRazaoSocial = new System.Windows.Forms.Label();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPagePessoaFisica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroFisica)).BeginInit();
            this.tabPagePessoaJuridica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroJuridica)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmaPessoaJuridica
            // 
            this.buttonConfirmaPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmaPessoaJuridica.Location = new System.Drawing.Point(220, 291);
            this.buttonConfirmaPessoaJuridica.Name = "buttonConfirmaPessoaJuridica";
            this.buttonConfirmaPessoaJuridica.Size = new System.Drawing.Size(171, 26);
            this.buttonConfirmaPessoaJuridica.TabIndex = 11;
            this.buttonConfirmaPessoaJuridica.Text = "CONFIRMA";
            this.buttonConfirmaPessoaJuridica.UseVisualStyleBackColor = true;
            this.buttonConfirmaPessoaJuridica.Click += new System.EventHandler(this.ButtonConfirmaPessoaJuridica_Click);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPagePessoaFisica);
            this.tabControl.Controls.Add(this.tabPagePessoaJuridica);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(414, 379);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabPagePessoaFisica
            // 
            this.tabPagePessoaFisica.Controls.Add(this.textBoxSobreNome);
            this.tabPagePessoaFisica.Controls.Add(this.buttonConfirmaPessoaFisica);
            this.tabPagePessoaFisica.Controls.Add(this.textBoxUFFisica);
            this.tabPagePessoaFisica.Controls.Add(this.labelUFFisica);
            this.tabPagePessoaFisica.Controls.Add(this.textBoxCidadeFisica);
            this.tabPagePessoaFisica.Controls.Add(this.labelCidadeFisica);
            this.tabPagePessoaFisica.Controls.Add(this.textBoxBairroFisica);
            this.tabPagePessoaFisica.Controls.Add(this.labelBairroFisica);
            this.tabPagePessoaFisica.Controls.Add(this.textBoxComplementoFisica);
            this.tabPagePessoaFisica.Controls.Add(this.labelComplementoFisica);
            this.tabPagePessoaFisica.Controls.Add(this.numericUpDownNumeroFisica);
            this.tabPagePessoaFisica.Controls.Add(this.labelNumeroFisica);
            this.tabPagePessoaFisica.Controls.Add(this.textBoxLogradouroFisica);
            this.tabPagePessoaFisica.Controls.Add(this.labelLogradouroFisica);
            this.tabPagePessoaFisica.Controls.Add(this.textBoxCEPFisica);
            this.tabPagePessoaFisica.Controls.Add(this.labelCEPFisica);
            this.tabPagePessoaFisica.Controls.Add(this.labelSobreNome);
            this.tabPagePessoaFisica.Controls.Add(this.textBoxNome);
            this.tabPagePessoaFisica.Controls.Add(this.labelNome);
            this.tabPagePessoaFisica.Controls.Add(this.dateTimePickerDataNasimento);
            this.tabPagePessoaFisica.Controls.Add(this.labelDataNascimento);
            this.tabPagePessoaFisica.Controls.Add(this.maskedTextBoxCPF);
            this.tabPagePessoaFisica.Controls.Add(this.labelCPF);
            this.tabPagePessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePessoaFisica.Location = new System.Drawing.Point(4, 25);
            this.tabPagePessoaFisica.Name = "tabPagePessoaFisica";
            this.tabPagePessoaFisica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePessoaFisica.Size = new System.Drawing.Size(406, 350);
            this.tabPagePessoaFisica.TabIndex = 0;
            this.tabPagePessoaFisica.Text = "Pessoa Física";
            this.tabPagePessoaFisica.UseVisualStyleBackColor = true;
            // 
            // textBoxSobreNome
            // 
            this.textBoxSobreNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobreNome.Location = new System.Drawing.Point(120, 111);
            this.textBoxSobreNome.MaxLength = 15;
            this.textBoxSobreNome.Name = "textBoxSobreNome";
            this.textBoxSobreNome.Size = new System.Drawing.Size(265, 26);
            this.textBoxSobreNome.TabIndex = 4;
            // 
            // buttonConfirmaPessoaFisica
            // 
            this.buttonConfirmaPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmaPessoaFisica.Location = new System.Drawing.Point(214, 314);
            this.buttonConfirmaPessoaFisica.Name = "buttonConfirmaPessoaFisica";
            this.buttonConfirmaPessoaFisica.Size = new System.Drawing.Size(171, 26);
            this.buttonConfirmaPessoaFisica.TabIndex = 12;
            this.buttonConfirmaPessoaFisica.Text = "CONFIRMA";
            this.buttonConfirmaPessoaFisica.UseVisualStyleBackColor = true;
            this.buttonConfirmaPessoaFisica.Click += new System.EventHandler(this.ButtonConfirmaPessoaFisica_Click);
            // 
            // textBoxUFFisica
            // 
            this.textBoxUFFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUFFisica.Location = new System.Drawing.Point(79, 313);
            this.textBoxUFFisica.MaxLength = 8;
            this.textBoxUFFisica.Name = "textBoxUFFisica";
            this.textBoxUFFisica.Size = new System.Drawing.Size(117, 26);
            this.textBoxUFFisica.TabIndex = 11;
            // 
            // labelUFFisica
            // 
            this.labelUFFisica.AutoSize = true;
            this.labelUFFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUFFisica.Location = new System.Drawing.Point(22, 320);
            this.labelUFFisica.Name = "labelUFFisica";
            this.labelUFFisica.Size = new System.Drawing.Size(38, 17);
            this.labelUFFisica.TabIndex = 0;
            this.labelUFFisica.Text = "UF : ";
            // 
            // textBoxCidadeFisica
            // 
            this.textBoxCidadeFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidadeFisica.Location = new System.Drawing.Point(79, 281);
            this.textBoxCidadeFisica.Name = "textBoxCidadeFisica";
            this.textBoxCidadeFisica.Size = new System.Drawing.Size(306, 26);
            this.textBoxCidadeFisica.TabIndex = 10;
            // 
            // labelCidadeFisica
            // 
            this.labelCidadeFisica.AutoSize = true;
            this.labelCidadeFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidadeFisica.Location = new System.Drawing.Point(19, 287);
            this.labelCidadeFisica.Name = "labelCidadeFisica";
            this.labelCidadeFisica.Size = new System.Drawing.Size(60, 17);
            this.labelCidadeFisica.TabIndex = 0;
            this.labelCidadeFisica.Text = "Cidade :";
            // 
            // textBoxBairroFisica
            // 
            this.textBoxBairroFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairroFisica.Location = new System.Drawing.Point(79, 244);
            this.textBoxBairroFisica.Name = "textBoxBairroFisica";
            this.textBoxBairroFisica.Size = new System.Drawing.Size(306, 26);
            this.textBoxBairroFisica.TabIndex = 9;
            // 
            // labelBairroFisica
            // 
            this.labelBairroFisica.AutoSize = true;
            this.labelBairroFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairroFisica.Location = new System.Drawing.Point(19, 250);
            this.labelBairroFisica.Name = "labelBairroFisica";
            this.labelBairroFisica.Size = new System.Drawing.Size(54, 17);
            this.labelBairroFisica.TabIndex = 0;
            this.labelBairroFisica.Text = "Bairro :";
            // 
            // textBoxComplementoFisica
            // 
            this.textBoxComplementoFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComplementoFisica.Location = new System.Drawing.Point(281, 210);
            this.textBoxComplementoFisica.Name = "textBoxComplementoFisica";
            this.textBoxComplementoFisica.Size = new System.Drawing.Size(104, 26);
            this.textBoxComplementoFisica.TabIndex = 8;
            // 
            // labelComplementoFisica
            // 
            this.labelComplementoFisica.AutoSize = true;
            this.labelComplementoFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplementoFisica.Location = new System.Drawing.Point(173, 216);
            this.labelComplementoFisica.Name = "labelComplementoFisica";
            this.labelComplementoFisica.Size = new System.Drawing.Size(102, 17);
            this.labelComplementoFisica.TabIndex = 0;
            this.labelComplementoFisica.Text = "Complemento :";
            // 
            // numericUpDownNumeroFisica
            // 
            this.numericUpDownNumeroFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNumeroFisica.Location = new System.Drawing.Point(91, 211);
            this.numericUpDownNumeroFisica.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownNumeroFisica.Name = "numericUpDownNumeroFisica";
            this.numericUpDownNumeroFisica.Value = 1;
            this.numericUpDownNumeroFisica.Size = new System.Drawing.Size(76, 26);
            this.numericUpDownNumeroFisica.TabIndex = 7;
            // 
            // labelNumeroFisica
            // 
            this.labelNumeroFisica.AutoSize = true;
            this.labelNumeroFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroFisica.Location = new System.Drawing.Point(19, 216);
            this.labelNumeroFisica.Name = "labelNumeroFisica";
            this.labelNumeroFisica.Size = new System.Drawing.Size(66, 17);
            this.labelNumeroFisica.TabIndex = 0;
            this.labelNumeroFisica.Text = "Número :";
            // 
            // textBoxLogradouroFisica
            // 
            this.textBoxLogradouroFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogradouroFisica.Location = new System.Drawing.Point(121, 176);
            this.textBoxLogradouroFisica.Name = "textBoxLogradouroFisica";
            this.textBoxLogradouroFisica.Size = new System.Drawing.Size(264, 26);
            this.textBoxLogradouroFisica.TabIndex = 6;
            // 
            // labelLogradouroFisica
            // 
            this.labelLogradouroFisica.AutoSize = true;
            this.labelLogradouroFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogradouroFisica.Location = new System.Drawing.Point(19, 182);
            this.labelLogradouroFisica.Name = "labelLogradouroFisica";
            this.labelLogradouroFisica.Size = new System.Drawing.Size(90, 17);
            this.labelLogradouroFisica.TabIndex = 0;
            this.labelLogradouroFisica.Text = "Logradouro :";
            // 
            // textBoxCEPFisica
            // 
            this.textBoxCEPFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCEPFisica.Location = new System.Drawing.Point(75, 144);
            this.textBoxCEPFisica.MaxLength = 8;
            this.textBoxCEPFisica.Name = "textBoxCEPFisica";
            this.textBoxCEPFisica.Size = new System.Drawing.Size(121, 26);
            this.textBoxCEPFisica.TabIndex = 5;
            // 
            // labelCEPFisica
            // 
            this.labelCEPFisica.AutoSize = true;
            this.labelCEPFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEPFisica.Location = new System.Drawing.Point(19, 150);
            this.labelCEPFisica.Name = "labelCEPFisica";
            this.labelCEPFisica.Size = new System.Drawing.Size(47, 17);
            this.labelCEPFisica.TabIndex = 0;
            this.labelCEPFisica.Text = "CEP : ";
            // 
            // labelSobreNome
            // 
            this.labelSobreNome.AutoSize = true;
            this.labelSobreNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobreNome.Location = new System.Drawing.Point(19, 117);
            this.labelSobreNome.Name = "labelSobreNome";
            this.labelSobreNome.Size = new System.Drawing.Size(93, 17);
            this.labelSobreNome.TabIndex = 0;
            this.labelSobreNome.Text = "Sobrenome : ";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(75, 75);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(310, 26);
            this.textBoxNome.TabIndex = 3;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(19, 81);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(53, 17);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome :";
            // 
            // dateTimePickerDataNasimento
            // 
            this.dateTimePickerDataNasimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDataNasimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataNasimento.Location = new System.Drawing.Point(168, 43);
            this.dateTimePickerDataNasimento.Name = "dateTimePickerDataNasimento";
            this.dateTimePickerDataNasimento.Size = new System.Drawing.Size(107, 26);
            this.dateTimePickerDataNasimento.TabIndex = 2;
            this.dateTimePickerDataNasimento.Value = data;
            this.dateTimePickerDataNasimento.MinDate = data;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimento.Location = new System.Drawing.Point(19, 51);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(144, 17);
            this.labelDataNascimento.TabIndex = 0;
            this.labelDataNascimento.Text = "Data de Nascimento :";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(75, 11);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(129, 26);
            this.maskedTextBoxCPF.TabIndex = 1;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.Location = new System.Drawing.Point(19, 17);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(42, 17);
            this.labelCPF.TabIndex = 0;
            this.labelCPF.Text = "CPF :";
            // 
            // tabPagePessoaJuridica
            // 
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxUFJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.buttonConfirmaPessoaJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.labelUFJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxCidadeJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.labelCidadeJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxBairroJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.labelBairroJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxComplementoJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.labelComplementoJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.numericUpDownNumeroJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.labelNumeroJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxLogradouroJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.labelLogradouroJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxCEPJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.labelCEPJuridica);
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxNomeFantasia);
            this.tabPagePessoaJuridica.Controls.Add(this.labelNomeFantasia);
            this.tabPagePessoaJuridica.Controls.Add(this.textBoxRazaoSocial);
            this.tabPagePessoaJuridica.Controls.Add(this.labelRazaoSocial);
            this.tabPagePessoaJuridica.Controls.Add(this.maskedTextBoxCNPJ);
            this.tabPagePessoaJuridica.Controls.Add(this.labelCNPJ);
            this.tabPagePessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePessoaJuridica.Location = new System.Drawing.Point(4, 25);
            this.tabPagePessoaJuridica.Name = "tabPagePessoaJuridica";
            this.tabPagePessoaJuridica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePessoaJuridica.Size = new System.Drawing.Size(406, 350);
            this.tabPagePessoaJuridica.TabIndex = 0;
            this.tabPagePessoaJuridica.Text = "Pessoa Jurídica";
            this.tabPagePessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // textBoxUFJuridica
            // 
            this.textBoxUFJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUFJuridica.Location = new System.Drawing.Point(77, 291);
            this.textBoxUFJuridica.MaxLength = 8;
            this.textBoxUFJuridica.Name = "textBoxUFJuridica";
            this.textBoxUFJuridica.Size = new System.Drawing.Size(127, 26);
            this.textBoxUFJuridica.TabIndex = 10;
            // 
            // labelUFJuridica
            // 
            this.labelUFJuridica.AutoSize = true;
            this.labelUFJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUFJuridica.Location = new System.Drawing.Point(20, 298);
            this.labelUFJuridica.Name = "labelUFJuridica";
            this.labelUFJuridica.Size = new System.Drawing.Size(38, 17);
            this.labelUFJuridica.TabIndex = 0;
            this.labelUFJuridica.Text = "UF : ";
            // 
            // textBoxCidadeJuridica
            // 
            this.textBoxCidadeJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidadeJuridica.Location = new System.Drawing.Point(77, 259);
            this.textBoxCidadeJuridica.Name = "textBoxCidadeJuridica";
            this.textBoxCidadeJuridica.Size = new System.Drawing.Size(314, 26);
            this.textBoxCidadeJuridica.TabIndex = 9;
            // 
            // labelCidadeJuridica
            // 
            this.labelCidadeJuridica.AutoSize = true;
            this.labelCidadeJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidadeJuridica.Location = new System.Drawing.Point(17, 265);
            this.labelCidadeJuridica.Name = "labelCidadeJuridica";
            this.labelCidadeJuridica.Size = new System.Drawing.Size(60, 17);
            this.labelCidadeJuridica.TabIndex = 0;
            this.labelCidadeJuridica.Text = "Cidade :";
            // 
            // textBoxBairroJuridica
            // 
            this.textBoxBairroJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairroJuridica.Location = new System.Drawing.Point(77, 222);
            this.textBoxBairroJuridica.Name = "textBoxBairroJuridica";
            this.textBoxBairroJuridica.Size = new System.Drawing.Size(314, 26);
            this.textBoxBairroJuridica.TabIndex = 8;
            // 
            // labelBairroJuridica
            // 
            this.labelBairroJuridica.AutoSize = true;
            this.labelBairroJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairroJuridica.Location = new System.Drawing.Point(17, 228);
            this.labelBairroJuridica.Name = "labelBairroJuridica";
            this.labelBairroJuridica.Size = new System.Drawing.Size(54, 17);
            this.labelBairroJuridica.TabIndex = 0;
            this.labelBairroJuridica.Text = "Bairro :";
            // 
            // textBoxComplementoJuridica
            // 
            this.textBoxComplementoJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComplementoJuridica.Location = new System.Drawing.Point(279, 188);
            this.textBoxComplementoJuridica.Name = "textBoxComplementoJuridica";
            this.textBoxComplementoJuridica.Size = new System.Drawing.Size(112, 26);
            this.textBoxComplementoJuridica.TabIndex = 7;
            // 
            // labelComplementoJuridica
            // 
            this.labelComplementoJuridica.AutoSize = true;
            this.labelComplementoJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplementoJuridica.Location = new System.Drawing.Point(171, 194);
            this.labelComplementoJuridica.Name = "labelComplementoJuridica";
            this.labelComplementoJuridica.Size = new System.Drawing.Size(102, 17);
            this.labelComplementoJuridica.TabIndex = 0;
            this.labelComplementoJuridica.Text = "Complemento :";
            // 
            // numericUpDownNumeroJuridica
            // 
            this.numericUpDownNumeroJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNumeroJuridica.Location = new System.Drawing.Point(89, 189);
            this.numericUpDownNumeroJuridica.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownNumeroJuridica.Name = "numericUpDownNumeroJuridica";
            this.numericUpDownNumeroJuridica.Value = 1;
            this.numericUpDownNumeroJuridica.Size = new System.Drawing.Size(76, 26);
            this.numericUpDownNumeroJuridica.TabIndex = 6;
            // 
            // labelNumeroJuridica
            // 
            this.labelNumeroJuridica.AutoSize = true;
            this.labelNumeroJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroJuridica.Location = new System.Drawing.Point(17, 194);
            this.labelNumeroJuridica.Name = "labelNumeroJuridica";
            this.labelNumeroJuridica.Size = new System.Drawing.Size(66, 17);
            this.labelNumeroJuridica.TabIndex = 0;
            this.labelNumeroJuridica.Text = "Número :";
            // 
            // textBoxLogradouroJuridica
            // 
            this.textBoxLogradouroJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogradouroJuridica.Location = new System.Drawing.Point(119, 154);
            this.textBoxLogradouroJuridica.Name = "textBoxLogradouroJuridica";
            this.textBoxLogradouroJuridica.Size = new System.Drawing.Size(272, 26);
            this.textBoxLogradouroJuridica.TabIndex = 5;
            // 
            // labelLogradouroJuridica
            // 
            this.labelLogradouroJuridica.AutoSize = true;
            this.labelLogradouroJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogradouroJuridica.Location = new System.Drawing.Point(17, 160);
            this.labelLogradouroJuridica.Name = "labelLogradouroJuridica";
            this.labelLogradouroJuridica.Size = new System.Drawing.Size(90, 17);
            this.labelLogradouroJuridica.TabIndex = 0;
            this.labelLogradouroJuridica.Text = "Logradouro :";
            // 
            // textBoxCEPJuridica
            // 
            this.textBoxCEPJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCEPJuridica.Location = new System.Drawing.Point(67, 122);
            this.textBoxCEPJuridica.MaxLength = 8;
            this.textBoxCEPJuridica.Name = "textBoxCEPJuridica";
            this.textBoxCEPJuridica.Size = new System.Drawing.Size(121, 26);
            this.textBoxCEPJuridica.TabIndex = 4;
            // 
            // labelCEPJuridica
            // 
            this.labelCEPJuridica.AutoSize = true;
            this.labelCEPJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEPJuridica.Location = new System.Drawing.Point(14, 128);
            this.labelCEPJuridica.Name = "labelCEPJuridica";
            this.labelCEPJuridica.Size = new System.Drawing.Size(47, 17);
            this.labelCEPJuridica.TabIndex = 0;
            this.labelCEPJuridica.Text = "CEP : ";
            // 
            // textBoxNomeFantasia
            // 
            this.textBoxNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeFantasia.Location = new System.Drawing.Point(130, 90);
            this.textBoxNomeFantasia.Name = "textBoxNomeFantasia";
            this.textBoxNomeFantasia.Size = new System.Drawing.Size(262, 26);
            this.textBoxNomeFantasia.TabIndex = 3;
            // 
            // labelNomeFantasia
            // 
            this.labelNomeFantasia.AutoSize = true;
            this.labelNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeFantasia.Location = new System.Drawing.Point(13, 96);
            this.labelNomeFantasia.Name = "labelNomeFantasia";
            this.labelNomeFantasia.Size = new System.Drawing.Size(111, 17);
            this.labelNomeFantasia.TabIndex = 0;
            this.labelNomeFantasia.Text = "Nome Fantasia :";
            // 
            // textBoxRazaoSocial
            // 
            this.textBoxRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRazaoSocial.Location = new System.Drawing.Point(111, 55);
            this.textBoxRazaoSocial.Name = "textBoxRazaoSocial";
            this.textBoxRazaoSocial.Size = new System.Drawing.Size(281, 26);
            this.textBoxRazaoSocial.TabIndex = 2;
            // 
            // labelRazaoSocial
            // 
            this.labelRazaoSocial.AutoSize = true;
            this.labelRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazaoSocial.Location = new System.Drawing.Point(13, 61);
            this.labelRazaoSocial.Name = "labelRazaoSocial";
            this.labelRazaoSocial.Size = new System.Drawing.Size(103, 17);
            this.labelRazaoSocial.TabIndex = 0;
            this.labelRazaoSocial.Text = "Razão Social : ";
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(77, 23);
            this.maskedTextBoxCNPJ.Mask = "00.000.000/0000-00";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(175, 26);
            this.maskedTextBoxCNPJ.TabIndex = 1;
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCNPJ.Location = new System.Drawing.Point(13, 29);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(51, 17);
            this.labelCNPJ.TabIndex = 0;
            this.labelCNPJ.Text = "CNPJ :";
            // 
            // ciatécnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 384);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ciatécnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ciatécnica teste de programação asp.net";
            this.tabControl.ResumeLayout(false);
            this.tabPagePessoaFisica.ResumeLayout(false);
            this.tabPagePessoaFisica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroFisica)).EndInit();
            this.tabPagePessoaJuridica.ResumeLayout(false);
            this.tabPagePessoaJuridica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroJuridica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonConfirmaPessoaJuridica;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePessoaFisica;
        private System.Windows.Forms.Button buttonConfirmaPessoaFisica;
        private System.Windows.Forms.TextBox textBoxUFFisica;
        private System.Windows.Forms.Label labelUFFisica;
        private System.Windows.Forms.TextBox textBoxCidadeFisica;
        private System.Windows.Forms.Label labelCidadeFisica;
        private System.Windows.Forms.TextBox textBoxBairroFisica;
        private System.Windows.Forms.Label labelBairroFisica;
        private System.Windows.Forms.TextBox textBoxComplementoFisica;
        private System.Windows.Forms.Label labelComplementoFisica;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroFisica;
        private System.Windows.Forms.Label labelNumeroFisica;
        private System.Windows.Forms.TextBox textBoxLogradouroFisica;
        private System.Windows.Forms.Label labelLogradouroFisica;
        private System.Windows.Forms.TextBox textBoxCEPFisica;
        private System.Windows.Forms.Label labelCEPFisica;
        private System.Windows.Forms.Label labelSobreNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasimento;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TabPage tabPagePessoaJuridica;
        private System.Windows.Forms.TextBox textBoxUFJuridica;
        private System.Windows.Forms.Label labelUFJuridica;
        private System.Windows.Forms.TextBox textBoxCidadeJuridica;
        private System.Windows.Forms.Label labelCidadeJuridica;
        private System.Windows.Forms.TextBox textBoxBairroJuridica;
        private System.Windows.Forms.Label labelBairroJuridica;
        private System.Windows.Forms.TextBox textBoxComplementoJuridica;
        private System.Windows.Forms.Label labelComplementoJuridica;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroJuridica;
        private System.Windows.Forms.Label labelNumeroJuridica;
        private System.Windows.Forms.TextBox textBoxLogradouroJuridica;
        private System.Windows.Forms.Label labelLogradouroJuridica;
        private System.Windows.Forms.TextBox textBoxCEPJuridica;
        private System.Windows.Forms.Label labelCEPJuridica;
        private System.Windows.Forms.TextBox textBoxNomeFantasia;
        private System.Windows.Forms.Label labelNomeFantasia;
        private System.Windows.Forms.TextBox textBoxRazaoSocial;
        private System.Windows.Forms.Label labelRazaoSocial;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCNPJ;
        private System.Windows.Forms.Label labelCNPJ;
        private System.Windows.Forms.TextBox textBoxSobreNome;
    }
}

