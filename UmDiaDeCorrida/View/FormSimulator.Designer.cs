namespace UmDiaDeCorrida
{
    partial class FormSimulator
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
            this.groupBoxApostas = new System.Windows.Forms.GroupBox();
            this.buttonRace = new System.Windows.Forms.Button();
            this.numericDog = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBetAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonBet = new System.Windows.Forms.Button();
            this.labelBettorName = new System.Windows.Forms.Label();
            this.labelBets = new System.Windows.Forms.Label();
            this.radioButtonAlfredo = new System.Windows.Forms.RadioButton();
            this.radioButtonBeto = new System.Windows.Forms.RadioButton();
            this.radioButtonJoão = new System.Windows.Forms.RadioButton();
            this.labelMinimumBet = new System.Windows.Forms.Label();
            this.pictureBoxDog4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRacetrack = new System.Windows.Forms.PictureBox();
            this.labelJoaoBet = new System.Windows.Forms.Label();
            this.labelBetoBet = new System.Windows.Forms.Label();
            this.labelAlfredoBet = new System.Windows.Forms.Label();
            this.groupBoxApostas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRacetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxApostas
            // 
            this.groupBoxApostas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxApostas.Controls.Add(this.labelAlfredoBet);
            this.groupBoxApostas.Controls.Add(this.labelBetoBet);
            this.groupBoxApostas.Controls.Add(this.labelJoaoBet);
            this.groupBoxApostas.Controls.Add(this.buttonRace);
            this.groupBoxApostas.Controls.Add(this.numericDog);
            this.groupBoxApostas.Controls.Add(this.label1);
            this.groupBoxApostas.Controls.Add(this.numericBetAmount);
            this.groupBoxApostas.Controls.Add(this.buttonBet);
            this.groupBoxApostas.Controls.Add(this.labelBettorName);
            this.groupBoxApostas.Controls.Add(this.labelBets);
            this.groupBoxApostas.Controls.Add(this.radioButtonAlfredo);
            this.groupBoxApostas.Controls.Add(this.radioButtonBeto);
            this.groupBoxApostas.Controls.Add(this.radioButtonJoão);
            this.groupBoxApostas.Controls.Add(this.labelMinimumBet);
            this.groupBoxApostas.Location = new System.Drawing.Point(12, 218);
            this.groupBoxApostas.Name = "groupBoxApostas";
            this.groupBoxApostas.Size = new System.Drawing.Size(602, 161);
            this.groupBoxApostas.TabIndex = 0;
            this.groupBoxApostas.TabStop = false;
            this.groupBoxApostas.Text = "Balcão de apostas";
            // 
            // buttonRace
            // 
            this.buttonRace.Location = new System.Drawing.Point(521, 131);
            this.buttonRace.Name = "buttonRace";
            this.buttonRace.Size = new System.Drawing.Size(75, 23);
            this.buttonRace.TabIndex = 13;
            this.buttonRace.Text = "Corram!";
            this.buttonRace.UseVisualStyleBackColor = true;
            this.buttonRace.Click += new System.EventHandler(this.buttonRace_Click);
            // 
            // numericDog
            // 
            this.numericDog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericDog.Location = new System.Drawing.Point(308, 134);
            this.numericDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDog.Name = "numericDog";
            this.numericDog.Size = new System.Drawing.Size(66, 20);
            this.numericDog.TabIndex = 12;
            this.numericDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "reais no cão numero";
            // 
            // numericBetAmount
            // 
            this.numericBetAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericBetAmount.Location = new System.Drawing.Point(127, 134);
            this.numericBetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericBetAmount.Name = "numericBetAmount";
            this.numericBetAmount.Size = new System.Drawing.Size(66, 20);
            this.numericBetAmount.TabIndex = 10;
            this.numericBetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonBet
            // 
            this.buttonBet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBet.Location = new System.Drawing.Point(46, 131);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(75, 23);
            this.buttonBet.TabIndex = 9;
            this.buttonBet.Text = "Aposta";
            this.buttonBet.UseVisualStyleBackColor = true;
            this.buttonBet.Click += new System.EventHandler(this.buttonBet_Click);
            // 
            // labelBettorName
            // 
            this.labelBettorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBettorName.AutoSize = true;
            this.labelBettorName.Location = new System.Drawing.Point(7, 136);
            this.labelBettorName.Name = "labelBettorName";
            this.labelBettorName.Size = new System.Drawing.Size(30, 13);
            this.labelBettorName.TabIndex = 8;
            this.labelBettorName.Text = "João";
            // 
            // labelBets
            // 
            this.labelBets.AutoSize = true;
            this.labelBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBets.Location = new System.Drawing.Point(302, 27);
            this.labelBets.Name = "labelBets";
            this.labelBets.Size = new System.Drawing.Size(52, 13);
            this.labelBets.TabIndex = 4;
            this.labelBets.Text = "Apostas";
            // 
            // radioButtonAlfredo
            // 
            this.radioButtonAlfredo.AutoSize = true;
            this.radioButtonAlfredo.Location = new System.Drawing.Point(10, 99);
            this.radioButtonAlfredo.Name = "radioButtonAlfredo";
            this.radioButtonAlfredo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonAlfredo.TabIndex = 3;
            this.radioButtonAlfredo.Text = "Alfredo";
            this.radioButtonAlfredo.UseVisualStyleBackColor = true;
            this.radioButtonAlfredo.CheckedChanged += new System.EventHandler(this.radioButtonAlfredo_CheckedChanged);
            // 
            // radioButtonBeto
            // 
            this.radioButtonBeto.AutoSize = true;
            this.radioButtonBeto.Location = new System.Drawing.Point(10, 76);
            this.radioButtonBeto.Name = "radioButtonBeto";
            this.radioButtonBeto.Size = new System.Drawing.Size(47, 17);
            this.radioButtonBeto.TabIndex = 2;
            this.radioButtonBeto.Text = "Beto";
            this.radioButtonBeto.UseVisualStyleBackColor = true;
            this.radioButtonBeto.CheckedChanged += new System.EventHandler(this.radioButtonBeto_CheckedChanged);
            // 
            // radioButtonJoão
            // 
            this.radioButtonJoão.AutoSize = true;
            this.radioButtonJoão.Checked = true;
            this.radioButtonJoão.Location = new System.Drawing.Point(10, 53);
            this.radioButtonJoão.Name = "radioButtonJoão";
            this.radioButtonJoão.Size = new System.Drawing.Size(48, 17);
            this.radioButtonJoão.TabIndex = 1;
            this.radioButtonJoão.TabStop = true;
            this.radioButtonJoão.Text = "João";
            this.radioButtonJoão.UseVisualStyleBackColor = true;
            this.radioButtonJoão.CheckedChanged += new System.EventHandler(this.radioButtonJoão_CheckedChanged);
            // 
            // labelMinimumBet
            // 
            this.labelMinimumBet.AutoSize = true;
            this.labelMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimumBet.Location = new System.Drawing.Point(7, 27);
            this.labelMinimumBet.Name = "labelMinimumBet";
            this.labelMinimumBet.Size = new System.Drawing.Size(97, 13);
            this.labelMinimumBet.TabIndex = 0;
            this.labelMinimumBet.Text = "Aposta Minima: ";
            // 
            // pictureBoxDog4
            // 
            this.pictureBoxDog4.Image = global::UmDiaDeCorrida.Properties.Resources.dog4;
            this.pictureBoxDog4.Location = new System.Drawing.Point(22, 174);
            this.pictureBoxDog4.Name = "pictureBoxDog4";
            this.pictureBoxDog4.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDog4.TabIndex = 5;
            this.pictureBoxDog4.TabStop = false;
            // 
            // pictureBoxDog3
            // 
            this.pictureBoxDog3.Image = global::UmDiaDeCorrida.Properties.Resources.dog3;
            this.pictureBoxDog3.Location = new System.Drawing.Point(22, 124);
            this.pictureBoxDog3.Name = "pictureBoxDog3";
            this.pictureBoxDog3.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDog3.TabIndex = 4;
            this.pictureBoxDog3.TabStop = false;
            // 
            // pictureBoxDog2
            // 
            this.pictureBoxDog2.Image = global::UmDiaDeCorrida.Properties.Resources.dog2;
            this.pictureBoxDog2.Location = new System.Drawing.Point(22, 74);
            this.pictureBoxDog2.Name = "pictureBoxDog2";
            this.pictureBoxDog2.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDog2.TabIndex = 3;
            this.pictureBoxDog2.TabStop = false;
            // 
            // pictureBoxDog1
            // 
            this.pictureBoxDog1.Image = global::UmDiaDeCorrida.Properties.Resources.dog1;
            this.pictureBoxDog1.Location = new System.Drawing.Point(22, 24);
            this.pictureBoxDog1.Name = "pictureBoxDog1";
            this.pictureBoxDog1.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDog1.TabIndex = 2;
            this.pictureBoxDog1.TabStop = false;
            // 
            // pictureBoxRacetrack
            // 
            this.pictureBoxRacetrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRacetrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxRacetrack.Image = global::UmDiaDeCorrida.Properties.Resources.racetrack;
            this.pictureBoxRacetrack.InitialImage = null;
            this.pictureBoxRacetrack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxRacetrack.Name = "pictureBoxRacetrack";
            this.pictureBoxRacetrack.Size = new System.Drawing.Size(600, 200);
            this.pictureBoxRacetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRacetrack.TabIndex = 1;
            this.pictureBoxRacetrack.TabStop = false;
            // 
            // labelJoaoBet
            // 
            this.labelJoaoBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelJoaoBet.Location = new System.Drawing.Point(305, 53);
            this.labelJoaoBet.Name = "labelJoaoBet";
            this.labelJoaoBet.Size = new System.Drawing.Size(291, 17);
            this.labelJoaoBet.TabIndex = 14;
            this.labelJoaoBet.Text = "Aposta de João";
            // 
            // labelBetoBet
            // 
            this.labelBetoBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBetoBet.Location = new System.Drawing.Point(305, 76);
            this.labelBetoBet.Name = "labelBetoBet";
            this.labelBetoBet.Size = new System.Drawing.Size(291, 17);
            this.labelBetoBet.TabIndex = 15;
            this.labelBetoBet.Text = "Aposta de Beto";
            // 
            // labelAlfredoBet
            // 
            this.labelAlfredoBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlfredoBet.Location = new System.Drawing.Point(305, 99);
            this.labelAlfredoBet.Name = "labelAlfredoBet";
            this.labelAlfredoBet.Size = new System.Drawing.Size(291, 17);
            this.labelAlfredoBet.TabIndex = 16;
            this.labelAlfredoBet.Text = "Aposta de Alfredo";
            // 
            // FormSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 391);
            this.Controls.Add(this.pictureBoxDog4);
            this.Controls.Add(this.pictureBoxDog3);
            this.Controls.Add(this.pictureBoxDog2);
            this.Controls.Add(this.pictureBoxDog1);
            this.Controls.Add(this.pictureBoxRacetrack);
            this.Controls.Add(this.groupBoxApostas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Um dia de corrida";
            this.groupBoxApostas.ResumeLayout(false);
            this.groupBoxApostas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRacetrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxApostas;
        private System.Windows.Forms.PictureBox pictureBoxRacetrack;
        private System.Windows.Forms.PictureBox pictureBoxDog1;
        private System.Windows.Forms.PictureBox pictureBoxDog2;
        private System.Windows.Forms.PictureBox pictureBoxDog3;
        private System.Windows.Forms.PictureBox pictureBoxDog4;
        private System.Windows.Forms.Button buttonRace;
        private System.Windows.Forms.NumericUpDown numericDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericBetAmount;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.Label labelBettorName;
        private System.Windows.Forms.Label labelBets;
        private System.Windows.Forms.RadioButton radioButtonAlfredo;
        private System.Windows.Forms.RadioButton radioButtonBeto;
        private System.Windows.Forms.RadioButton radioButtonJoão;
        private System.Windows.Forms.Label labelMinimumBet;
        private System.Windows.Forms.Label labelAlfredoBet;
        private System.Windows.Forms.Label labelBetoBet;
        private System.Windows.Forms.Label labelJoaoBet;
    }
}

