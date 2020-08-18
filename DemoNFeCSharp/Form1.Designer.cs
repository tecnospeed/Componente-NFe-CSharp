namespace DemoNFeCSharp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CnpjSh = new System.Windows.Forms.Label();
            this.Uf = new System.Windows.Forms.Label();
            this.tbNrProtocolo = new System.Windows.Forms.Label();
            this.TokenSh = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbCnpjSh = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbTokenSh = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cnpj = new System.Windows.Forms.Label();
            this.tbNrRecibo = new System.Windows.Forms.Label();
            this.tbUf = new System.Windows.Forms.TextBox();
            this.tbIdNota = new System.Windows.Forms.Label();
            this.tbCnpj = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbCertificado = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConfigurarIni = new System.Windows.Forms.Button();
            this.btLoadConfig = new System.Windows.Forms.Button();
            this.btVerificarStatus = new System.Windows.Forms.Button();
            this.btGerarViaRec = new System.Windows.Forms.Button();
            this.btGerarXmlDataset = new System.Windows.Forms.Button();
            this.btGerarXmlTx2 = new System.Windows.Forms.Button();
            this.btAssinarXml = new System.Windows.Forms.Button();
            this.btnEnviarNfe = new System.Windows.Forms.Button();
            this.btnEnviarSincrono = new System.Windows.Forms.Button();
            this.btnConsultarRecibo = new System.Windows.Forms.Button();
            this.btnConsultarNfe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mmXml = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btPreverDanfe = new System.Windows.Forms.Button();
            this.btEditarDanfe = new System.Windows.Forms.Button();
            this.btVisualizarDanfe = new System.Windows.Forms.Button();
            this.btImprimirDanfe = new System.Windows.Forms.Button();
            this.btExportarPDF = new System.Windows.Forms.Button();
            this.btEnviarEmail = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 263);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NFe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CnpjSh);
            this.groupBox1.Controls.Add(this.Uf);
            this.groupBox1.Controls.Add(this.tbNrProtocolo);
            this.groupBox1.Controls.Add(this.TokenSh);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.tbCnpjSh);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.tbTokenSh);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Cnpj);
            this.groupBox1.Controls.Add(this.tbNrRecibo);
            this.groupBox1.Controls.Add(this.tbUf);
            this.groupBox1.Controls.Add(this.tbIdNota);
            this.groupBox1.Controls.Add(this.tbCnpj);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 225);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // CnpjSh
            // 
            this.CnpjSh.AutoSize = true;
            this.CnpjSh.Location = new System.Drawing.Point(3, 23);
            this.CnpjSh.Name = "CnpjSh";
            this.CnpjSh.Size = new System.Drawing.Size(110, 13);
            this.CnpjSh.TabIndex = 0;
            this.CnpjSh.Text = "CNPJ SoftwareHouse";
            // 
            // Uf
            // 
            this.Uf.AutoSize = true;
            this.Uf.Location = new System.Drawing.Point(3, 69);
            this.Uf.Name = "Uf";
            this.Uf.Size = new System.Drawing.Size(21, 13);
            this.Uf.TabIndex = 4;
            this.Uf.Text = "UF";
            // 
            // tbNrProtocolo
            // 
            this.tbNrProtocolo.AutoSize = true;
            this.tbNrProtocolo.Location = new System.Drawing.Point(3, 161);
            this.tbNrProtocolo.Name = "tbNrProtocolo";
            this.tbNrProtocolo.Size = new System.Drawing.Size(69, 13);
            this.tbNrProtocolo.TabIndex = 13;
            this.tbNrProtocolo.Text = "Nr. Protocolo";
            // 
            // TokenSh
            // 
            this.TokenSh.AutoSize = true;
            this.TokenSh.Location = new System.Drawing.Point(181, 23);
            this.TokenSh.Name = "TokenSh";
            this.TokenSh.Size = new System.Drawing.Size(114, 13);
            this.TokenSh.TabIndex = 1;
            this.TokenSh.Text = "Token SoftwareHouse";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(325, 20);
            this.textBox3.TabIndex = 12;
            // 
            // tbCnpjSh
            // 
            this.tbCnpjSh.Location = new System.Drawing.Point(6, 38);
            this.tbCnpjSh.Name = "tbCnpjSh";
            this.tbCnpjSh.Size = new System.Drawing.Size(172, 20);
            this.tbCnpjSh.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 11;
            // 
            // tbTokenSh
            // 
            this.tbTokenSh.Location = new System.Drawing.Point(184, 38);
            this.tbTokenSh.Name = "tbTokenSh";
            this.tbTokenSh.Size = new System.Drawing.Size(147, 20);
            this.tbTokenSh.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Cnpj
            // 
            this.Cnpj.AutoSize = true;
            this.Cnpj.Location = new System.Drawing.Point(66, 69);
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.Size = new System.Drawing.Size(34, 13);
            this.Cnpj.TabIndex = 5;
            this.Cnpj.Text = "CNPJ";
            // 
            // tbNrRecibo
            // 
            this.tbNrRecibo.AutoSize = true;
            this.tbNrRecibo.Location = new System.Drawing.Point(181, 114);
            this.tbNrRecibo.Name = "tbNrRecibo";
            this.tbNrRecibo.Size = new System.Drawing.Size(58, 13);
            this.tbNrRecibo.TabIndex = 9;
            this.tbNrRecibo.Text = "Nr. Recibo";
            // 
            // tbUf
            // 
            this.tbUf.Location = new System.Drawing.Point(6, 85);
            this.tbUf.Name = "tbUf";
            this.tbUf.Size = new System.Drawing.Size(36, 20);
            this.tbUf.TabIndex = 6;
            // 
            // tbIdNota
            // 
            this.tbIdNota.AutoSize = true;
            this.tbIdNota.Location = new System.Drawing.Point(3, 114);
            this.tbIdNota.Name = "tbIdNota";
            this.tbIdNota.Size = new System.Drawing.Size(42, 13);
            this.tbIdNota.TabIndex = 8;
            this.tbIdNota.Text = "Id Nota";
            // 
            // tbCnpj
            // 
            this.tbCnpj.Location = new System.Drawing.Point(69, 85);
            this.tbCnpj.Name = "tbCnpj";
            this.tbCnpj.Size = new System.Drawing.Size(147, 20);
            this.tbCnpj.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Impressão";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbCertificado
            // 
            this.cbCertificado.FormattingEnabled = true;
            this.cbCertificado.Location = new System.Drawing.Point(6, 38);
            this.cbCertificado.Name = "cbCertificado";
            this.cbCertificado.Size = new System.Drawing.Size(418, 21);
            this.cbCertificado.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnConsultarNfe);
            this.groupBox2.Controls.Add(this.btnConsultarRecibo);
            this.groupBox2.Controls.Add(this.btnEnviarSincrono);
            this.groupBox2.Controls.Add(this.btnEnviarNfe);
            this.groupBox2.Controls.Add(this.btAssinarXml);
            this.groupBox2.Controls.Add(this.btGerarXmlTx2);
            this.groupBox2.Controls.Add(this.btGerarXmlDataset);
            this.groupBox2.Controls.Add(this.btGerarViaRec);
            this.groupBox2.Controls.Add(this.btVerificarStatus);
            this.groupBox2.Controls.Add(this.btLoadConfig);
            this.groupBox2.Controls.Add(this.btConfigurarIni);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbCertificado);
            this.groupBox2.Location = new System.Drawing.Point(352, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 231);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Certificado";
            // 
            // btConfigurarIni
            // 
            this.btConfigurarIni.Location = new System.Drawing.Point(6, 74);
            this.btConfigurarIni.Name = "btConfigurarIni";
            this.btConfigurarIni.Size = new System.Drawing.Size(120, 23);
            this.btConfigurarIni.TabIndex = 1;
            this.btConfigurarIni.Text = "Configurar Ini";
            this.btConfigurarIni.UseVisualStyleBackColor = true;
            // 
            // btLoadConfig
            // 
            this.btLoadConfig.Location = new System.Drawing.Point(6, 103);
            this.btLoadConfig.Name = "btLoadConfig";
            this.btLoadConfig.Size = new System.Drawing.Size(120, 23);
            this.btLoadConfig.TabIndex = 3;
            this.btLoadConfig.Text = "Load Config";
            this.btLoadConfig.UseVisualStyleBackColor = true;
            // 
            // btVerificarStatus
            // 
            this.btVerificarStatus.Location = new System.Drawing.Point(6, 132);
            this.btVerificarStatus.Name = "btVerificarStatus";
            this.btVerificarStatus.Size = new System.Drawing.Size(120, 23);
            this.btVerificarStatus.TabIndex = 4;
            this.btVerificarStatus.Text = "Verificar Status";
            this.btVerificarStatus.UseVisualStyleBackColor = true;
            // 
            // btGerarViaRec
            // 
            this.btGerarViaRec.Location = new System.Drawing.Point(6, 161);
            this.btGerarViaRec.Name = "btGerarViaRec";
            this.btGerarViaRec.Size = new System.Drawing.Size(120, 23);
            this.btGerarViaRec.TabIndex = 5;
            this.btGerarViaRec.Text = "Gerar Via Rec";
            this.btGerarViaRec.UseVisualStyleBackColor = true;
            // 
            // btGerarXmlDataset
            // 
            this.btGerarXmlDataset.Location = new System.Drawing.Point(132, 74);
            this.btGerarXmlDataset.Name = "btGerarXmlDataset";
            this.btGerarXmlDataset.Size = new System.Drawing.Size(120, 23);
            this.btGerarXmlDataset.TabIndex = 6;
            this.btGerarXmlDataset.Text = "Gerar Xml Dataset";
            this.btGerarXmlDataset.UseVisualStyleBackColor = true;
            // 
            // btGerarXmlTx2
            // 
            this.btGerarXmlTx2.Location = new System.Drawing.Point(132, 103);
            this.btGerarXmlTx2.Name = "btGerarXmlTx2";
            this.btGerarXmlTx2.Size = new System.Drawing.Size(120, 23);
            this.btGerarXmlTx2.TabIndex = 7;
            this.btGerarXmlTx2.Text = "Gerar Xml Tx2";
            this.btGerarXmlTx2.UseVisualStyleBackColor = true;
            // 
            // btAssinarXml
            // 
            this.btAssinarXml.Location = new System.Drawing.Point(132, 132);
            this.btAssinarXml.Name = "btAssinarXml";
            this.btAssinarXml.Size = new System.Drawing.Size(120, 23);
            this.btAssinarXml.TabIndex = 8;
            this.btAssinarXml.Text = "Assinar Xml";
            this.btAssinarXml.UseVisualStyleBackColor = true;
            // 
            // btnEnviarNfe
            // 
            this.btnEnviarNfe.Location = new System.Drawing.Point(132, 161);
            this.btnEnviarNfe.Name = "btnEnviarNfe";
            this.btnEnviarNfe.Size = new System.Drawing.Size(120, 23);
            this.btnEnviarNfe.TabIndex = 9;
            this.btnEnviarNfe.Text = "Enviar NFe";
            this.btnEnviarNfe.UseVisualStyleBackColor = true;
            // 
            // btnEnviarSincrono
            // 
            this.btnEnviarSincrono.Location = new System.Drawing.Point(258, 74);
            this.btnEnviarSincrono.Name = "btnEnviarSincrono";
            this.btnEnviarSincrono.Size = new System.Drawing.Size(120, 23);
            this.btnEnviarSincrono.TabIndex = 10;
            this.btnEnviarSincrono.Text = "Enviar Sincrono";
            this.btnEnviarSincrono.UseVisualStyleBackColor = true;
            // 
            // btnConsultarRecibo
            // 
            this.btnConsultarRecibo.Location = new System.Drawing.Point(258, 103);
            this.btnConsultarRecibo.Name = "btnConsultarRecibo";
            this.btnConsultarRecibo.Size = new System.Drawing.Size(120, 23);
            this.btnConsultarRecibo.TabIndex = 11;
            this.btnConsultarRecibo.Text = "Consultar Recibo";
            this.btnConsultarRecibo.UseVisualStyleBackColor = true;
            // 
            // btnConsultarNfe
            // 
            this.btnConsultarNfe.Location = new System.Drawing.Point(258, 132);
            this.btnConsultarNfe.Name = "btnConsultarNfe";
            this.btnConsultarNfe.Size = new System.Drawing.Size(120, 23);
            this.btnConsultarNfe.TabIndex = 12;
            this.btnConsultarNfe.Text = "Consultar NFe";
            this.btnConsultarNfe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(258, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ambiente de PRODUÇÃO";
            // 
            // mmXml
            // 
            this.mmXml.Location = new System.Drawing.Point(4, 265);
            this.mmXml.Name = "mmXml";
            this.mmXml.Size = new System.Drawing.Size(789, 290);
            this.mmXml.TabIndex = 1;
            this.mmXml.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btEnviarEmail);
            this.groupBox3.Controls.Add(this.btExportarPDF);
            this.groupBox3.Controls.Add(this.btImprimirDanfe);
            this.groupBox3.Controls.Add(this.btVisualizarDanfe);
            this.groupBox3.Controls.Add(this.btEditarDanfe);
            this.groupBox3.Controls.Add(this.btPreverDanfe);
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 225);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANFE";
            // 
            // btPreverDanfe
            // 
            this.btPreverDanfe.Location = new System.Drawing.Point(6, 32);
            this.btPreverDanfe.Name = "btPreverDanfe";
            this.btPreverDanfe.Size = new System.Drawing.Size(120, 23);
            this.btPreverDanfe.TabIndex = 2;
            this.btPreverDanfe.Text = "Prever Danfe";
            this.btPreverDanfe.UseVisualStyleBackColor = true;
            // 
            // btEditarDanfe
            // 
            this.btEditarDanfe.Location = new System.Drawing.Point(6, 61);
            this.btEditarDanfe.Name = "btEditarDanfe";
            this.btEditarDanfe.Size = new System.Drawing.Size(120, 23);
            this.btEditarDanfe.TabIndex = 3;
            this.btEditarDanfe.Text = "Editar Danfe";
            this.btEditarDanfe.UseVisualStyleBackColor = true;
            // 
            // btVisualizarDanfe
            // 
            this.btVisualizarDanfe.Location = new System.Drawing.Point(6, 90);
            this.btVisualizarDanfe.Name = "btVisualizarDanfe";
            this.btVisualizarDanfe.Size = new System.Drawing.Size(120, 23);
            this.btVisualizarDanfe.TabIndex = 4;
            this.btVisualizarDanfe.Text = "Visualizar Danfe";
            this.btVisualizarDanfe.UseVisualStyleBackColor = true;
            // 
            // btImprimirDanfe
            // 
            this.btImprimirDanfe.Location = new System.Drawing.Point(158, 32);
            this.btImprimirDanfe.Name = "btImprimirDanfe";
            this.btImprimirDanfe.Size = new System.Drawing.Size(120, 23);
            this.btImprimirDanfe.TabIndex = 5;
            this.btImprimirDanfe.Text = "Imprimir Danfe";
            this.btImprimirDanfe.UseVisualStyleBackColor = true;
            // 
            // btExportarPDF
            // 
            this.btExportarPDF.Location = new System.Drawing.Point(158, 61);
            this.btExportarPDF.Name = "btExportarPDF";
            this.btExportarPDF.Size = new System.Drawing.Size(120, 23);
            this.btExportarPDF.TabIndex = 6;
            this.btExportarPDF.Text = "Exportar PDF";
            this.btExportarPDF.UseVisualStyleBackColor = true;
            // 
            // btEnviarEmail
            // 
            this.btEnviarEmail.Location = new System.Drawing.Point(158, 90);
            this.btEnviarEmail.Name = "btEnviarEmail";
            this.btEnviarEmail.Size = new System.Drawing.Size(120, 23);
            this.btEnviarEmail.TabIndex = 7;
            this.btEnviarEmail.Text = "Enviar Email";
            this.btEnviarEmail.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 567);
            this.Controls.Add(this.mmXml);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Demonstração NFe";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbCnpj;
        private System.Windows.Forms.TextBox tbUf;
        private System.Windows.Forms.Label Cnpj;
        private System.Windows.Forms.Label Uf;
        private System.Windows.Forms.TextBox tbTokenSh;
        private System.Windows.Forms.TextBox tbCnpjSh;
        private System.Windows.Forms.Label TokenSh;
        private System.Windows.Forms.Label CnpjSh;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbNrRecibo;
        private System.Windows.Forms.Label tbIdNota;
        private System.Windows.Forms.Label tbNrProtocolo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultarNfe;
        private System.Windows.Forms.Button btnConsultarRecibo;
        private System.Windows.Forms.Button btnEnviarSincrono;
        private System.Windows.Forms.Button btnEnviarNfe;
        private System.Windows.Forms.Button btAssinarXml;
        private System.Windows.Forms.Button btGerarXmlTx2;
        private System.Windows.Forms.Button btGerarXmlDataset;
        private System.Windows.Forms.Button btGerarViaRec;
        private System.Windows.Forms.Button btVerificarStatus;
        private System.Windows.Forms.Button btLoadConfig;
        private System.Windows.Forms.Button btConfigurarIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCertificado;
        private System.Windows.Forms.RichTextBox mmXml;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btEnviarEmail;
        private System.Windows.Forms.Button btExportarPDF;
        private System.Windows.Forms.Button btImprimirDanfe;
        private System.Windows.Forms.Button btVisualizarDanfe;
        private System.Windows.Forms.Button btEditarDanfe;
        private System.Windows.Forms.Button btPreverDanfe;
    }
}

