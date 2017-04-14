namespace RenomearArquivo
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cboDia = new System.Windows.Forms.ComboBox();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.cboLocal = new System.Windows.Forms.ComboBox();
            this.btnFabiano = new System.Windows.Forms.Button();
            this.btnDaniel = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dlgAbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCharles = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLucasM = new System.Windows.Forms.Button();
            this.btnLucasF = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLeandro = new System.Windows.Forms.Button();
            this.btnJeffersonE = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtOutroFuncionario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRafael = new System.Windows.Forms.Button();
            this.btnLuiz = new System.Windows.Forms.Button();
            this.btnKelson = new System.Windows.Forms.Button();
            this.btnJoab = new System.Windows.Forms.Button();
            this.btnJeffersonB = new System.Windows.Forms.Button();
            this.btnHumberto = new System.Windows.Forms.Button();
            this.btnFrancisco = new System.Windows.Forms.Button();
            this.btnCarlos = new System.Windows.Forms.Button();
            this.txtOutroEvento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDia
            // 
            this.cboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDia.FormattingEnabled = true;
            this.cboDia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cboDia.Location = new System.Drawing.Point(20, 118);
            this.cboDia.Name = "cboDia";
            this.cboDia.Size = new System.Drawing.Size(84, 26);
            this.cboDia.TabIndex = 0;
            this.cboDia.SelectedIndexChanged += new System.EventHandler(this.cboDia_SelectedIndexChanged);
            // 
            // cboMes
            // 
            this.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "janeiro",
            "fevereiro",
            "março",
            "abril",
            "maio",
            "junho",
            "julho",
            "agosto",
            "setembro",
            "outubro",
            "novembro",
            "dezembro"});
            this.cboMes.Location = new System.Drawing.Point(20, 183);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(84, 26);
            this.cboMes.TabIndex = 1;
            this.cboMes.SelectedIndexChanged += new System.EventHandler(this.cboMes_SelectedIndexChanged);
            // 
            // cboAno
            // 
            this.cboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAno.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cboAno.Location = new System.Drawing.Point(20, 247);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(84, 26);
            this.cboAno.TabIndex = 2;
            this.cboAno.SelectedIndexChanged += new System.EventHandler(this.cboAno_SelectedIndexChanged);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.Location = new System.Drawing.Point(35, 95);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(41, 20);
            this.lblDia.TabIndex = 3;
            this.lblDia.Text = "Dia:";
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.White;
            this.lblNomeEvento.Location = new System.Drawing.Point(218, 107);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(134, 18);
            this.lblNomeEvento.TabIndex = 6;
            this.lblNomeEvento.Text = "Nome do Evento";
            // 
            // txtEvento
            // 
            this.txtEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvento.Location = new System.Drawing.Point(185, 143);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(212, 24);
            this.txtEvento.TabIndex = 7;
            this.txtEvento.TextChanged += new System.EventHandler(this.txtEvento_TextChanged);
            // 
            // cboLocal
            // 
            this.cboLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocal.FormattingEnabled = true;
            this.cboLocal.Items.AddRange(new object[] {
            "Auditório 600",
            "Auditório Berrini",
            "Auditório Itaú",
            "Auditório Rocha",
            "Sala 309",
            "Salão Nobre"});
            this.cboLocal.Location = new System.Drawing.Point(207, 201);
            this.cboLocal.Name = "cboLocal";
            this.cboLocal.Size = new System.Drawing.Size(157, 26);
            this.cboLocal.TabIndex = 8;
            this.cboLocal.SelectedIndexChanged += new System.EventHandler(this.cboLocal_SelectedIndexChanged);
            // 
            // btnFabiano
            // 
            this.btnFabiano.BackColor = System.Drawing.Color.Transparent;
            this.btnFabiano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFabiano.ForeColor = System.Drawing.Color.Black;
            this.btnFabiano.Location = new System.Drawing.Point(5, 28);
            this.btnFabiano.Name = "btnFabiano";
            this.btnFabiano.Size = new System.Drawing.Size(131, 31);
            this.btnFabiano.TabIndex = 17;
            this.btnFabiano.Text = "Fabiano";
            this.btnFabiano.UseVisualStyleBackColor = false;
            this.btnFabiano.Click += new System.EventHandler(this.btnFabiano_Click);
            // 
            // btnDaniel
            // 
            this.btnDaniel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaniel.ForeColor = System.Drawing.Color.Black;
            this.btnDaniel.Location = new System.Drawing.Point(142, 29);
            this.btnDaniel.Name = "btnDaniel";
            this.btnDaniel.Size = new System.Drawing.Size(141, 30);
            this.btnDaniel.TabIndex = 20;
            this.btnDaniel.Text = "Daniel";
            this.btnDaniel.UseVisualStyleBackColor = true;
            this.btnDaniel.Click += new System.EventHandler(this.btnDaniel_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(18, 45);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(392, 33);
            this.lblResultado.TabIndex = 24;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArquivo
            // 
            this.lblArquivo.BackColor = System.Drawing.Color.Transparent;
            this.lblArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivo.ForeColor = System.Drawing.Color.White;
            this.lblArquivo.Location = new System.Drawing.Point(12, 22);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(579, 23);
            this.lblArquivo.TabIndex = 25;
            this.lblArquivo.Text = "Arquivo Selecionado:";
            this.lblArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(167, 541);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(159, 44);
            this.btnFinalizar.TabIndex = 26;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dlgAbrirArquivo
            // 
            this.dlgAbrirArquivo.FileName = "[[Selecione o Arquivo a ser Renomeado]]";
            this.dlgAbrirArquivo.Title = "[[Selecione o Arquivo a ser Renomeado]]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mês:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(260, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(538, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Funcionário Responsável";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 118);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnFabiano);
            this.groupBox3.Controls.Add(this.btnDaniel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(491, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 70);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Berrini";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnCharles);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(490, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 71);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Faria Lima";
            // 
            // btnCharles
            // 
            this.btnCharles.BackColor = System.Drawing.Color.Transparent;
            this.btnCharles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharles.ForeColor = System.Drawing.Color.Black;
            this.btnCharles.Location = new System.Drawing.Point(76, 26);
            this.btnCharles.Name = "btnCharles";
            this.btnCharles.Size = new System.Drawing.Size(124, 31);
            this.btnCharles.TabIndex = 21;
            this.btnCharles.Text = "Charles";
            this.btnCharles.UseVisualStyleBackColor = false;
            this.btnCharles.Click += new System.EventHandler(this.btnCharles_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnLucasM);
            this.groupBox5.Controls.Add(this.btnLucasF);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(490, 420);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(295, 79);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Paulista";
            // 
            // btnLucasM
            // 
            this.btnLucasM.BackColor = System.Drawing.Color.Transparent;
            this.btnLucasM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLucasM.ForeColor = System.Drawing.Color.Black;
            this.btnLucasM.Location = new System.Drawing.Point(142, 33);
            this.btnLucasM.Name = "btnLucasM";
            this.btnLucasM.Size = new System.Drawing.Size(141, 31);
            this.btnLucasM.TabIndex = 22;
            this.btnLucasM.Text = "Lucas Massoline";
            this.btnLucasM.UseVisualStyleBackColor = false;
            this.btnLucasM.Click += new System.EventHandler(this.btnLucasM_Click);
            // 
            // btnLucasF
            // 
            this.btnLucasF.BackColor = System.Drawing.Color.Transparent;
            this.btnLucasF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLucasF.ForeColor = System.Drawing.Color.Black;
            this.btnLucasF.Location = new System.Drawing.Point(7, 33);
            this.btnLucasF.Name = "btnLucasF";
            this.btnLucasF.Size = new System.Drawing.Size(129, 31);
            this.btnLucasF.TabIndex = 22;
            this.btnLucasF.Text = "Lucas Faria";
            this.btnLucasF.UseVisualStyleBackColor = false;
            this.btnLucasF.Click += new System.EventHandler(this.btnLucasF_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnLeandro);
            this.groupBox6.Controls.Add(this.btnJeffersonE);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(490, 500);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(295, 79);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rocha";
            // 
            // btnLeandro
            // 
            this.btnLeandro.BackColor = System.Drawing.Color.Transparent;
            this.btnLeandro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeandro.ForeColor = System.Drawing.Color.Black;
            this.btnLeandro.Location = new System.Drawing.Point(142, 33);
            this.btnLeandro.Name = "btnLeandro";
            this.btnLeandro.Size = new System.Drawing.Size(141, 31);
            this.btnLeandro.TabIndex = 22;
            this.btnLeandro.Text = "Leandro";
            this.btnLeandro.UseVisualStyleBackColor = false;
            this.btnLeandro.Click += new System.EventHandler(this.btnLeandro_Click);
            // 
            // btnJeffersonE
            // 
            this.btnJeffersonE.BackColor = System.Drawing.Color.Transparent;
            this.btnJeffersonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJeffersonE.ForeColor = System.Drawing.Color.Black;
            this.btnJeffersonE.Location = new System.Drawing.Point(7, 33);
            this.btnJeffersonE.Name = "btnJeffersonE";
            this.btnJeffersonE.Size = new System.Drawing.Size(129, 31);
            this.btnJeffersonE.TabIndex = 22;
            this.btnJeffersonE.Text = "Jefferson Elias ";
            this.btnJeffersonE.UseVisualStyleBackColor = false;
            this.btnJeffersonE.Click += new System.EventHandler(this.btnJeffersonE_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.txtOutroFuncionario);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(490, 580);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(295, 73);
            this.groupBox7.TabIndex = 37;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Outro Funcionário";
            // 
            // txtOutroFuncionario
            // 
            this.txtOutroFuncionario.Location = new System.Drawing.Point(76, 35);
            this.txtOutroFuncionario.Name = "txtOutroFuncionario";
            this.txtOutroFuncionario.Size = new System.Drawing.Size(114, 24);
            this.txtOutroFuncionario.TabIndex = 38;
            this.txtOutroFuncionario.TextChanged += new System.EventHandler(this.txtOutroFuncionario_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRafael);
            this.groupBox2.Controls.Add(this.btnLuiz);
            this.groupBox2.Controls.Add(this.btnKelson);
            this.groupBox2.Controls.Add(this.btnJoab);
            this.groupBox2.Controls.Add(this.btnJeffersonB);
            this.groupBox2.Controls.Add(this.btnHumberto);
            this.groupBox2.Controls.Add(this.btnFrancisco);
            this.groupBox2.Controls.Add(this.btnCarlos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(491, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 186);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nove de Julho";
            // 
            // btnRafael
            // 
            this.btnRafael.BackColor = System.Drawing.Color.Transparent;
            this.btnRafael.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRafael.ForeColor = System.Drawing.Color.Black;
            this.btnRafael.Location = new System.Drawing.Point(142, 141);
            this.btnRafael.Name = "btnRafael";
            this.btnRafael.Size = new System.Drawing.Size(141, 31);
            this.btnRafael.TabIndex = 27;
            this.btnRafael.Text = "Rafael";
            this.btnRafael.UseVisualStyleBackColor = false;
            this.btnRafael.Click += new System.EventHandler(this.btnRafael_Click);
            // 
            // btnLuiz
            // 
            this.btnLuiz.BackColor = System.Drawing.Color.Transparent;
            this.btnLuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuiz.ForeColor = System.Drawing.Color.Black;
            this.btnLuiz.Location = new System.Drawing.Point(7, 141);
            this.btnLuiz.Name = "btnLuiz";
            this.btnLuiz.Size = new System.Drawing.Size(129, 31);
            this.btnLuiz.TabIndex = 28;
            this.btnLuiz.Text = "Luiz";
            this.btnLuiz.UseVisualStyleBackColor = false;
            this.btnLuiz.Click += new System.EventHandler(this.btnLuiz_Click);
            // 
            // btnKelson
            // 
            this.btnKelson.BackColor = System.Drawing.Color.Transparent;
            this.btnKelson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelson.ForeColor = System.Drawing.Color.Black;
            this.btnKelson.Location = new System.Drawing.Point(142, 103);
            this.btnKelson.Name = "btnKelson";
            this.btnKelson.Size = new System.Drawing.Size(141, 31);
            this.btnKelson.TabIndex = 25;
            this.btnKelson.Text = "Kelson";
            this.btnKelson.UseVisualStyleBackColor = false;
            this.btnKelson.Click += new System.EventHandler(this.btnKelson_Click);
            // 
            // btnJoab
            // 
            this.btnJoab.BackColor = System.Drawing.Color.Transparent;
            this.btnJoab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoab.ForeColor = System.Drawing.Color.Black;
            this.btnJoab.Location = new System.Drawing.Point(7, 103);
            this.btnJoab.Name = "btnJoab";
            this.btnJoab.Size = new System.Drawing.Size(129, 31);
            this.btnJoab.TabIndex = 26;
            this.btnJoab.Text = "Joab";
            this.btnJoab.UseVisualStyleBackColor = false;
            this.btnJoab.Click += new System.EventHandler(this.btnJoab_Click);
            // 
            // btnJeffersonB
            // 
            this.btnJeffersonB.BackColor = System.Drawing.Color.Transparent;
            this.btnJeffersonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJeffersonB.ForeColor = System.Drawing.Color.Black;
            this.btnJeffersonB.Location = new System.Drawing.Point(142, 64);
            this.btnJeffersonB.Name = "btnJeffersonB";
            this.btnJeffersonB.Size = new System.Drawing.Size(142, 31);
            this.btnJeffersonB.TabIndex = 23;
            this.btnJeffersonB.Text = "Jefferson Bernades";
            this.btnJeffersonB.UseVisualStyleBackColor = false;
            this.btnJeffersonB.Click += new System.EventHandler(this.btnJeffersonB_Click);
            // 
            // btnHumberto
            // 
            this.btnHumberto.BackColor = System.Drawing.Color.Transparent;
            this.btnHumberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHumberto.ForeColor = System.Drawing.Color.Black;
            this.btnHumberto.Location = new System.Drawing.Point(7, 64);
            this.btnHumberto.Name = "btnHumberto";
            this.btnHumberto.Size = new System.Drawing.Size(129, 31);
            this.btnHumberto.TabIndex = 24;
            this.btnHumberto.Text = "Humberto";
            this.btnHumberto.UseVisualStyleBackColor = false;
            this.btnHumberto.Click += new System.EventHandler(this.btnHumberto_Click);
            // 
            // btnFrancisco
            // 
            this.btnFrancisco.BackColor = System.Drawing.Color.Transparent;
            this.btnFrancisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrancisco.ForeColor = System.Drawing.Color.Black;
            this.btnFrancisco.Location = new System.Drawing.Point(142, 26);
            this.btnFrancisco.Name = "btnFrancisco";
            this.btnFrancisco.Size = new System.Drawing.Size(142, 31);
            this.btnFrancisco.TabIndex = 22;
            this.btnFrancisco.Text = "Francisco";
            this.btnFrancisco.UseVisualStyleBackColor = false;
            this.btnFrancisco.Click += new System.EventHandler(this.btnFrancisco_Click);
            // 
            // btnCarlos
            // 
            this.btnCarlos.BackColor = System.Drawing.Color.Transparent;
            this.btnCarlos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarlos.ForeColor = System.Drawing.Color.Black;
            this.btnCarlos.Location = new System.Drawing.Point(7, 26);
            this.btnCarlos.Name = "btnCarlos";
            this.btnCarlos.Size = new System.Drawing.Size(129, 31);
            this.btnCarlos.TabIndex = 22;
            this.btnCarlos.Text = "Carlos";
            this.btnCarlos.UseVisualStyleBackColor = false;
            this.btnCarlos.Click += new System.EventHandler(this.btnCarlos_Click);
            // 
            // txtOutroEvento
            // 
            this.txtOutroEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutroEvento.Location = new System.Drawing.Point(206, 279);
            this.txtOutroEvento.Name = "txtOutroEvento";
            this.txtOutroEvento.Size = new System.Drawing.Size(157, 24);
            this.txtOutroEvento.TabIndex = 39;
            this.txtOutroEvento.TextChanged += new System.EventHandler(this.txtOutroEvento_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(232, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Outro Evento";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 680);
            this.Controls.Add(this.txtOutroEvento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.cboLocal);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.cboMes);
            this.Controls.Add(this.cboDia);
            this.Name = "frmPrincipal";
            this.Text = "Renomear Arquivo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDia;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.ComboBox cboLocal;
        private System.Windows.Forms.Button btnFabiano;
        private System.Windows.Forms.Button btnDaniel;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.OpenFileDialog dlgAbrirArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCharles;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLucasM;
        private System.Windows.Forms.Button btnLucasF;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLeandro;
        private System.Windows.Forms.Button btnJeffersonE;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtOutroFuncionario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRafael;
        private System.Windows.Forms.Button btnLuiz;
        private System.Windows.Forms.Button btnKelson;
        private System.Windows.Forms.Button btnJoab;
        private System.Windows.Forms.Button btnJeffersonB;
        private System.Windows.Forms.Button btnHumberto;
        private System.Windows.Forms.Button btnFrancisco;
        private System.Windows.Forms.Button btnCarlos;
        private System.Windows.Forms.TextBox txtOutroEvento;
        private System.Windows.Forms.Label label5;
    }
}

