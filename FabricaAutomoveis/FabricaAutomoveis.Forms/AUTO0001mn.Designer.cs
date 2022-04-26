
namespace FabricaAutomoveis.Forms
{
    partial class AUTO0001mn
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
            this.tbNomeAutomovel = new System.Windows.Forms.TextBox();
            this.lblNomeAutomovel = new System.Windows.Forms.Label();
            this.lblDataFabricacao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGravarContinuar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblTanqueCombustivel = new System.Windows.Forms.Label();
            this.lblKMLitro = new System.Windows.Forms.Label();
            this.cbEstepe = new System.Windows.Forms.CheckBox();
            this.nudNroRodas = new System.Windows.Forms.NumericUpDown();
            this.nudTanqueCombustivel = new System.Windows.Forms.NumericUpDown();
            this.nudKMLitro = new System.Windows.Forms.NumericUpDown();
            this.lblNroRodas = new System.Windows.Forms.Label();
            this.pickerDataFabricacao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroRodas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanqueCombustivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKMLitro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomeAutomovel
            // 
            this.tbNomeAutomovel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeAutomovel.Location = new System.Drawing.Point(16, 36);
            this.tbNomeAutomovel.Name = "tbNomeAutomovel";
            this.tbNomeAutomovel.Size = new System.Drawing.Size(394, 20);
            this.tbNomeAutomovel.TabIndex = 0;
            // 
            // lblNomeAutomovel
            // 
            this.lblNomeAutomovel.AutoSize = true;
            this.lblNomeAutomovel.Location = new System.Drawing.Point(13, 19);
            this.lblNomeAutomovel.Name = "lblNomeAutomovel";
            this.lblNomeAutomovel.Size = new System.Drawing.Size(103, 13);
            this.lblNomeAutomovel.TabIndex = 1;
            this.lblNomeAutomovel.Text = "Nome do Automovel";
            // 
            // lblDataFabricacao
            // 
            this.lblDataFabricacao.AutoSize = true;
            this.lblDataFabricacao.Location = new System.Drawing.Point(13, 59);
            this.lblDataFabricacao.Name = "lblDataFabricacao";
            this.lblDataFabricacao.Size = new System.Drawing.Size(101, 13);
            this.lblDataFabricacao.TabIndex = 3;
            this.lblDataFabricacao.Text = "Data de Fabricação";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Image = global::FabricaAutomoveis.Forms.Properties.Resources.ic_subdirectory_arrow_left_black_18dp;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(351, 231);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(62, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGravarContinuar
            // 
            this.btnGravarContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravarContinuar.Image = global::FabricaAutomoveis.Forms.Properties.Resources.ic_check_black_18dp;
            this.btnGravarContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarContinuar.Location = new System.Drawing.Point(147, 231);
            this.btnGravarContinuar.Name = "btnGravarContinuar";
            this.btnGravarContinuar.Size = new System.Drawing.Size(123, 23);
            this.btnGravarContinuar.TabIndex = 4;
            this.btnGravarContinuar.Text = "Gravar e &Continuar";
            this.btnGravarContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarContinuar.UseVisualStyleBackColor = true;
            this.btnGravarContinuar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.Image = global::FabricaAutomoveis.Forms.Properties.Resources.ic_check_black_18dp;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(278, 231);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(67, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblTanqueCombustivel
            // 
            this.lblTanqueCombustivel.AutoSize = true;
            this.lblTanqueCombustivel.Location = new System.Drawing.Point(13, 98);
            this.lblTanqueCombustivel.Name = "lblTanqueCombustivel";
            this.lblTanqueCombustivel.Size = new System.Drawing.Size(119, 13);
            this.lblTanqueCombustivel.TabIndex = 5;
            this.lblTanqueCombustivel.Text = "Tanque de Combustivel";
            // 
            // lblKMLitro
            // 
            this.lblKMLitro.AutoSize = true;
            this.lblKMLitro.Location = new System.Drawing.Point(291, 98);
            this.lblKMLitro.Name = "lblKMLitro";
            this.lblKMLitro.Size = new System.Drawing.Size(64, 13);
            this.lblKMLitro.TabIndex = 7;
            this.lblKMLitro.Text = "KM por Litro";
            // 
            // cbEstepe
            // 
            this.cbEstepe.AutoSize = true;
            this.cbEstepe.Location = new System.Drawing.Point(294, 154);
            this.cbEstepe.Name = "cbEstepe";
            this.cbEstepe.Size = new System.Drawing.Size(59, 17);
            this.cbEstepe.TabIndex = 9;
            this.cbEstepe.Text = "Estepe";
            this.cbEstepe.UseVisualStyleBackColor = true;
            this.cbEstepe.CheckedChanged += new System.EventHandler(this.cbEstepe_CheckedChanged);
            // 
            // nudNroRodas
            // 
            this.nudNroRodas.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNroRodas.Location = new System.Drawing.Point(16, 153);
            this.nudNroRodas.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudNroRodas.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNroRodas.Name = "nudNroRodas";
            this.nudNroRodas.Size = new System.Drawing.Size(116, 20);
            this.nudNroRodas.TabIndex = 10;
            this.nudNroRodas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudTanqueCombustivel
            // 
            this.nudTanqueCombustivel.Location = new System.Drawing.Point(16, 114);
            this.nudTanqueCombustivel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTanqueCombustivel.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTanqueCombustivel.Name = "nudTanqueCombustivel";
            this.nudTanqueCombustivel.Size = new System.Drawing.Size(116, 20);
            this.nudTanqueCombustivel.TabIndex = 12;
            this.nudTanqueCombustivel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudKMLitro
            // 
            this.nudKMLitro.Location = new System.Drawing.Point(294, 114);
            this.nudKMLitro.Name = "nudKMLitro";
            this.nudKMLitro.Size = new System.Drawing.Size(116, 20);
            this.nudKMLitro.TabIndex = 13;
            // 
            // lblNroRodas
            // 
            this.lblNroRodas.AutoSize = true;
            this.lblNroRodas.Location = new System.Drawing.Point(13, 137);
            this.lblNroRodas.Name = "lblNroRodas";
            this.lblNroRodas.Size = new System.Drawing.Size(73, 13);
            this.lblNroRodas.TabIndex = 14;
            this.lblNroRodas.Text = "Nro de Rodas";
            // 
            // pickerDataFabricacao
            // 
            this.pickerDataFabricacao.Location = new System.Drawing.Point(16, 75);
            this.pickerDataFabricacao.MaxDate = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            this.pickerDataFabricacao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.pickerDataFabricacao.Name = "pickerDataFabricacao";
            this.pickerDataFabricacao.Size = new System.Drawing.Size(394, 20);
            this.pickerDataFabricacao.TabIndex = 11;
            // 
            // AUTO0001mn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 266);
            this.Controls.Add(this.lblNroRodas);
            this.Controls.Add(this.nudKMLitro);
            this.Controls.Add(this.nudTanqueCombustivel);
            this.Controls.Add(this.pickerDataFabricacao);
            this.Controls.Add(this.nudNroRodas);
            this.Controls.Add(this.cbEstepe);
            this.Controls.Add(this.lblKMLitro);
            this.Controls.Add(this.lblTanqueCombustivel);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravarContinuar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblDataFabricacao);
            this.Controls.Add(this.lblNomeAutomovel);
            this.Controls.Add(this.tbNomeAutomovel);
            this.Name = "AUTO0001mn";
            this.Text = "AUTO0001mn";
            this.Load += new System.EventHandler(this.DTIFormManutencao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNroRodas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTanqueCombustivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKMLitro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomeAutomovel;
        private System.Windows.Forms.Label lblNomeAutomovel;
        private System.Windows.Forms.Label lblDataFabricacao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnGravarContinuar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTanqueCombustivel;
        private System.Windows.Forms.Label lblKMLitro;
        private System.Windows.Forms.CheckBox cbEstepe;
        private System.Windows.Forms.NumericUpDown nudNroRodas;
        private System.Windows.Forms.NumericUpDown nudTanqueCombustivel;
        private System.Windows.Forms.NumericUpDown nudKMLitro;
        private System.Windows.Forms.Label lblNroRodas;
        private System.Windows.Forms.DateTimePicker pickerDataFabricacao;
    }
}