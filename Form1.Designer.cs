namespace WinForm02
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.btnEnviarMsg = new System.Windows.Forms.Button();
            this.lbl01 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.checkMasc = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.checkFem = new System.Windows.Forms.CheckBox();
            this.lblNasc = new System.Windows.Forms.Label();
            this.mskDateNasc = new System.Windows.Forms.MaskedTextBox();
            this.lblNascio = new System.Windows.Forms.Label();
            this.comboNascio = new System.Windows.Forms.ComboBox();
            this.groupRes = new System.Windows.Forms.GroupBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtEnder = new System.Windows.Forms.TextBox();
            this.lblEnder = new System.Windows.Forms.Label();
            this.btnEnviarLabel = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblResp = new System.Windows.Forms.Label();
            this.groupRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviarMsg
            // 
            this.btnEnviarMsg.AutoSize = true;
            this.btnEnviarMsg.Location = new System.Drawing.Point(270, 468);
            this.btnEnviarMsg.Name = "btnEnviarMsg";
            this.btnEnviarMsg.Size = new System.Drawing.Size(154, 44);
            this.btnEnviarMsg.TabIndex = 0;
            this.btnEnviarMsg.Text = "Enviar Message";
            this.btnEnviarMsg.UseVisualStyleBackColor = true;
            this.btnEnviarMsg.Click += new System.EventHandler(this.btnEnviarMsg_Click);
            // 
            // lbl01
            // 
            this.lbl01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl01.AutoSize = true;
            this.lbl01.BackColor = System.Drawing.Color.DarkViolet;
            this.lbl01.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lbl01.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl01.Location = new System.Drawing.Point(430, 45);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(413, 46);
            this.lbl01.TabIndex = 1;
            this.lbl01.Text = "Cadastro de Clientes";
            this.lbl01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl01.Click += new System.EventHandler(this.lbl01_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(267, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Digite seu nome: ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // checkMasc
            // 
            this.checkMasc.AutoSize = true;
            this.checkMasc.Location = new System.Drawing.Point(342, 269);
            this.checkMasc.Name = "checkMasc";
            this.checkMasc.Size = new System.Drawing.Size(90, 20);
            this.checkMasc.TabIndex = 3;
            this.checkMasc.Text = "Masculino";
            this.checkMasc.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(383, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(536, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(267, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(113, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Digite seu e-mail: ";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(386, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(533, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite seu telefone: ";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(397, 185);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(522, 22);
            this.txtTel.TabIndex = 8;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(267, 273);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(69, 16);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Seu sexo: ";
            // 
            // checkFem
            // 
            this.checkFem.AutoSize = true;
            this.checkFem.Location = new System.Drawing.Point(438, 269);
            this.checkFem.Name = "checkFem";
            this.checkFem.Size = new System.Drawing.Size(84, 20);
            this.checkFem.TabIndex = 10;
            this.checkFem.Text = "Feminino";
            this.checkFem.UseVisualStyleBackColor = true;
            // 
            // lblNasc
            // 
            this.lblNasc.AutoSize = true;
            this.lblNasc.Location = new System.Drawing.Point(267, 231);
            this.lblNasc.Name = "lblNasc";
            this.lblNasc.Size = new System.Drawing.Size(136, 16);
            this.lblNasc.TabIndex = 11;
            this.lblNasc.Text = "Data de Nascimento: ";
            // 
            // mskDateNasc
            // 
            this.mskDateNasc.Location = new System.Drawing.Point(409, 228);
            this.mskDateNasc.Mask = "00/00/0000";
            this.mskDateNasc.Name = "mskDateNasc";
            this.mskDateNasc.Size = new System.Drawing.Size(75, 22);
            this.mskDateNasc.TabIndex = 12;
            this.mskDateNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lblNascio
            // 
            this.lblNascio.AutoSize = true;
            this.lblNascio.Location = new System.Drawing.Point(490, 231);
            this.lblNascio.Name = "lblNascio";
            this.lblNascio.Size = new System.Drawing.Size(109, 16);
            this.lblNascio.TabIndex = 14;
            this.lblNascio.Text = "Nascionalidade: ";
            // 
            // comboNascio
            // 
            this.comboNascio.FormattingEnabled = true;
            this.comboNascio.Items.AddRange(new object[] {
            "Brasileiro",
            "Estrangeiro"});
            this.comboNascio.Location = new System.Drawing.Point(605, 223);
            this.comboNascio.Name = "comboNascio";
            this.comboNascio.Size = new System.Drawing.Size(314, 24);
            this.comboNascio.TabIndex = 15;
            // 
            // groupRes
            // 
            this.groupRes.Controls.Add(this.txtComp);
            this.groupRes.Controls.Add(this.lblComp);
            this.groupRes.Controls.Add(this.comboUF);
            this.groupRes.Controls.Add(this.lblUF);
            this.groupRes.Controls.Add(this.txtCidade);
            this.groupRes.Controls.Add(this.txtNum);
            this.groupRes.Controls.Add(this.txtBairro);
            this.groupRes.Controls.Add(this.lblCid);
            this.groupRes.Controls.Add(this.lblBairro);
            this.groupRes.Controls.Add(this.lblNum);
            this.groupRes.Controls.Add(this.txtEnder);
            this.groupRes.Controls.Add(this.lblEnder);
            this.groupRes.Location = new System.Drawing.Point(270, 295);
            this.groupRes.Name = "groupRes";
            this.groupRes.Size = new System.Drawing.Size(649, 154);
            this.groupRes.TabIndex = 16;
            this.groupRes.TabStop = false;
            this.groupRes.Text = "Dados Residenciais";
            this.groupRes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(115, 96);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(383, 22);
            this.txtComp.TabIndex = 11;
            this.txtComp.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(12, 102);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(97, 16);
            this.lblComp.TabIndex = 10;
            this.lblComp.Text = "Complemento: ";
            this.lblComp.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboUF
            // 
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Items.AddRange(new object[] {
            "AC",
            "",
            "AL",
            "",
            "AP",
            "",
            "AM",
            "",
            "BA",
            "",
            "CE",
            "",
            "DF",
            "",
            "ES",
            "",
            "GO",
            "",
            "MA",
            "",
            "MT",
            "",
            "MS",
            "",
            "MG",
            "",
            "PA",
            "",
            "PB",
            "",
            "PR",
            "",
            "PE",
            "",
            "PI",
            "",
            "RJ",
            "",
            "RN",
            "",
            "RS",
            "",
            "RO",
            "",
            "RR",
            "",
            "SC",
            "",
            "SP",
            "",
            "SE",
            "",
            "TO"});
            this.comboUF.Location = new System.Drawing.Point(554, 65);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(89, 24);
            this.comboUF.TabIndex = 9;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(504, 68);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(31, 16);
            this.lblUF.TabIndex = 8;
            this.lblUF.Text = "UF: ";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(398, 65);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 22);
            this.txtCidade.TabIndex = 7;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(398, 28);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 6;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(90, 65);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(227, 22);
            this.txtBairro.TabIndex = 5;
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Location = new System.Drawing.Point(335, 65);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(57, 16);
            this.lblCid.TabIndex = 4;
            this.lblCid.Text = "Cidade: ";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(12, 65);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(49, 16);
            this.lblBairro.TabIndex = 3;
            this.lblBairro.Text = "Bairro: ";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(335, 34);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(28, 16);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Nº: ";
            // 
            // txtEnder
            // 
            this.txtEnder.Location = new System.Drawing.Point(90, 28);
            this.txtEnder.Name = "txtEnder";
            this.txtEnder.Size = new System.Drawing.Size(227, 22);
            this.txtEnder.TabIndex = 1;
            this.txtEnder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEnder
            // 
            this.lblEnder.AutoSize = true;
            this.lblEnder.Location = new System.Drawing.Point(12, 34);
            this.lblEnder.Name = "lblEnder";
            this.lblEnder.Size = new System.Drawing.Size(72, 16);
            this.lblEnder.TabIndex = 0;
            this.lblEnder.Text = "Endereco: ";
            // 
            // btnEnviarLabel
            // 
            this.btnEnviarLabel.Location = new System.Drawing.Point(430, 469);
            this.btnEnviarLabel.Name = "btnEnviarLabel";
            this.btnEnviarLabel.Size = new System.Drawing.Size(154, 43);
            this.btnEnviarLabel.TabIndex = 17;
            this.btnEnviarLabel.Text = "Enviar Label";
            this.btnEnviarLabel.UseVisualStyleBackColor = true;
            this.btnEnviarLabel.Click += new System.EventHandler(this.btnEnviarLabel_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(590, 469);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 43);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(765, 469);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(154, 43);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(270, 536);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(0, 16);
            this.lblResp.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1322, 564);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnviarLabel);
            this.Controls.Add(this.groupRes);
            this.Controls.Add(this.comboNascio);
            this.Controls.Add(this.lblNascio);
            this.Controls.Add(this.mskDateNasc);
            this.Controls.Add(this.lblNasc);
            this.Controls.Add(this.checkFem);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.checkMasc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.btnEnviarMsg);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project2024";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupRes.ResumeLayout(false);
            this.groupRes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarMsg;
        private System.Windows.Forms.Label lbl01;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox checkMasc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.CheckBox checkFem;
        private System.Windows.Forms.Label lblNasc;
        private System.Windows.Forms.MaskedTextBox mskDateNasc;
        private System.Windows.Forms.Label lblNascio;
        private System.Windows.Forms.ComboBox comboNascio;
        private System.Windows.Forms.GroupBox groupRes;
        private System.Windows.Forms.TextBox txtEnder;
        private System.Windows.Forms.Label lblEnder;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnEnviarLabel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblResp;
    }
}

