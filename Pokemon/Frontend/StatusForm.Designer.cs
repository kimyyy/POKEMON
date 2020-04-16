namespace Pokemon
{
	partial class StatusForm
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
			this.PictureBoxPoke = new Pokemon.PictureBoxPoke();
			this.groupBoxAttackPoke = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.comboBoxChara = new System.Windows.Forms.ComboBox();
			this.panelIndi = new System.Windows.Forms.Panel();
			this.label16 = new System.Windows.Forms.Label();
			this.textBoxIndiHP = new System.Windows.Forms.TextBox();
			this.textBoxIndiA = new System.Windows.Forms.TextBox();
			this.textBoxIndiB = new System.Windows.Forms.TextBox();
			this.textBoxIndiC = new System.Windows.Forms.TextBox();
			this.textBoxIndiD = new System.Windows.Forms.TextBox();
			this.textBoxIndiS = new System.Windows.Forms.TextBox();
			this.panelStatus = new System.Windows.Forms.Panel();
			this.labelStatusS = new System.Windows.Forms.Label();
			this.labelStatusD = new System.Windows.Forms.Label();
			this.labelStatusC = new System.Windows.Forms.Label();
			this.labelStatusB = new System.Windows.Forms.Label();
			this.labelStatusA = new System.Windows.Forms.Label();
			this.labelStatusH = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.panelEffort = new System.Windows.Forms.Panel();
			this.textBoxEffortHP = new System.Windows.Forms.TextBox();
			this.textBoxEffortA = new System.Windows.Forms.TextBox();
			this.textBoxEffortB = new System.Windows.Forms.TextBox();
			this.textBoxEffortC = new System.Windows.Forms.TextBox();
			this.textBoxEffortD = new System.Windows.Forms.TextBox();
			this.textBoxEffortS = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.buttonUpdateStatus = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.comboBoxNature = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxPoke)).BeginInit();
			this.groupBoxAttackPoke.SuspendLayout();
			this.panelIndi.SuspendLayout();
			this.panelStatus.SuspendLayout();
			this.panelEffort.SuspendLayout();
			this.SuspendLayout();
			// 
			// PictureBoxPoke
			// 
			this.PictureBoxPoke.BackColor = System.Drawing.Color.White;
			this.PictureBoxPoke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBoxPoke.IsMyPoke = false;
			this.PictureBoxPoke.Location = new System.Drawing.Point(12, 12);
			this.PictureBoxPoke.Name = "PictureBoxPoke";
			this.PictureBoxPoke.Poke = null;
			this.PictureBoxPoke.Size = new System.Drawing.Size(100, 100);
			this.PictureBoxPoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxPoke.TabIndex = 0;
			this.PictureBoxPoke.TabStop = false;
			// 
			// groupBoxAttackPoke
			// 
			this.groupBoxAttackPoke.Controls.Add(this.label20);
			this.groupBoxAttackPoke.Controls.Add(this.label19);
			this.groupBoxAttackPoke.Controls.Add(this.comboBoxChara);
			this.groupBoxAttackPoke.Controls.Add(this.panelIndi);
			this.groupBoxAttackPoke.Controls.Add(this.panelStatus);
			this.groupBoxAttackPoke.Controls.Add(this.panelEffort);
			this.groupBoxAttackPoke.Controls.Add(this.comboBoxNature);
			this.groupBoxAttackPoke.Controls.Add(this.buttonUpdateStatus);
			this.groupBoxAttackPoke.Controls.Add(this.label17);
			this.groupBoxAttackPoke.Controls.Add(this.label14);
			this.groupBoxAttackPoke.Controls.Add(this.label13);
			this.groupBoxAttackPoke.Controls.Add(this.label12);
			this.groupBoxAttackPoke.Controls.Add(this.label11);
			this.groupBoxAttackPoke.Controls.Add(this.label10);
			this.groupBoxAttackPoke.Location = new System.Drawing.Point(172, 12);
			this.groupBoxAttackPoke.Name = "groupBoxAttackPoke";
			this.groupBoxAttackPoke.Size = new System.Drawing.Size(502, 432);
			this.groupBoxAttackPoke.TabIndex = 12;
			this.groupBoxAttackPoke.TabStop = false;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(8, 387);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(39, 12);
			this.label20.TabIndex = 35;
			this.label20.Text = "とくせい";
			this.label20.Click += new System.EventHandler(this.label20_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(8, 343);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 12);
			this.label19.TabIndex = 34;
			this.label19.Text = "せいかく";
			// 
			// comboBoxChara
			// 
			this.comboBoxChara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChara.FormattingEnabled = true;
			this.comboBoxChara.Location = new System.Drawing.Point(101, 384);
			this.comboBoxChara.Name = "comboBoxChara";
			this.comboBoxChara.Size = new System.Drawing.Size(113, 20);
			this.comboBoxChara.TabIndex = 31;
			// 
			// panelIndi
			// 
			this.panelIndi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.panelIndi.Controls.Add(this.label16);
			this.panelIndi.Controls.Add(this.textBoxIndiHP);
			this.panelIndi.Controls.Add(this.textBoxIndiA);
			this.panelIndi.Controls.Add(this.textBoxIndiB);
			this.panelIndi.Controls.Add(this.textBoxIndiC);
			this.panelIndi.Controls.Add(this.textBoxIndiD);
			this.panelIndi.Controls.Add(this.textBoxIndiS);
			this.panelIndi.Location = new System.Drawing.Point(179, 48);
			this.panelIndi.Name = "panelIndi";
			this.panelIndi.Size = new System.Drawing.Size(159, 273);
			this.panelIndi.TabIndex = 19;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(25, 20);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 12);
			this.label16.TabIndex = 17;
			this.label16.Text = "個体値";
			// 
			// textBoxIndiHP
			// 
			this.textBoxIndiHP.Location = new System.Drawing.Point(18, 39);
			this.textBoxIndiHP.Name = "textBoxIndiHP";
			this.textBoxIndiHP.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiHP.TabIndex = 20;
			this.textBoxIndiHP.Tag = "H";
			this.textBoxIndiHP.Text = "0";
			// 
			// textBoxIndiA
			// 
			this.textBoxIndiA.Location = new System.Drawing.Point(18, 76);
			this.textBoxIndiA.Name = "textBoxIndiA";
			this.textBoxIndiA.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiA.TabIndex = 6;
			this.textBoxIndiA.Tag = "A";
			this.textBoxIndiA.Text = "0";
			// 
			// textBoxIndiB
			// 
			this.textBoxIndiB.Location = new System.Drawing.Point(18, 116);
			this.textBoxIndiB.Name = "textBoxIndiB";
			this.textBoxIndiB.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiB.TabIndex = 7;
			this.textBoxIndiB.Tag = "B";
			this.textBoxIndiB.Text = "0";
			// 
			// textBoxIndiC
			// 
			this.textBoxIndiC.Location = new System.Drawing.Point(18, 154);
			this.textBoxIndiC.Name = "textBoxIndiC";
			this.textBoxIndiC.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiC.TabIndex = 8;
			this.textBoxIndiC.Tag = "C";
			this.textBoxIndiC.Text = "0";
			// 
			// textBoxIndiD
			// 
			this.textBoxIndiD.Location = new System.Drawing.Point(18, 197);
			this.textBoxIndiD.Name = "textBoxIndiD";
			this.textBoxIndiD.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiD.TabIndex = 9;
			this.textBoxIndiD.Tag = "D";
			this.textBoxIndiD.Text = "0";
			// 
			// textBoxIndiS
			// 
			this.textBoxIndiS.Location = new System.Drawing.Point(18, 236);
			this.textBoxIndiS.Name = "textBoxIndiS";
			this.textBoxIndiS.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiS.TabIndex = 10;
			this.textBoxIndiS.Tag = "S";
			this.textBoxIndiS.Text = "0";
			// 
			// panelStatus
			// 
			this.panelStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.panelStatus.Controls.Add(this.labelStatusS);
			this.panelStatus.Controls.Add(this.labelStatusD);
			this.panelStatus.Controls.Add(this.labelStatusC);
			this.panelStatus.Controls.Add(this.labelStatusB);
			this.panelStatus.Controls.Add(this.labelStatusA);
			this.panelStatus.Controls.Add(this.labelStatusH);
			this.panelStatus.Controls.Add(this.label18);
			this.panelStatus.Location = new System.Drawing.Point(344, 48);
			this.panelStatus.Name = "panelStatus";
			this.panelStatus.Size = new System.Drawing.Size(142, 273);
			this.panelStatus.TabIndex = 30;
			// 
			// labelStatusS
			// 
			this.labelStatusS.AutoSize = true;
			this.labelStatusS.Location = new System.Drawing.Point(38, 236);
			this.labelStatusS.Name = "labelStatusS";
			this.labelStatusS.Size = new System.Drawing.Size(41, 12);
			this.labelStatusS.TabIndex = 34;
			this.labelStatusS.Tag = "S";
			this.labelStatusS.Text = "未設定";
			// 
			// labelStatusD
			// 
			this.labelStatusD.AutoSize = true;
			this.labelStatusD.Location = new System.Drawing.Point(40, 200);
			this.labelStatusD.Name = "labelStatusD";
			this.labelStatusD.Size = new System.Drawing.Size(41, 12);
			this.labelStatusD.TabIndex = 33;
			this.labelStatusD.Tag = "D";
			this.labelStatusD.Text = "未設定";
			// 
			// labelStatusC
			// 
			this.labelStatusC.AutoSize = true;
			this.labelStatusC.Location = new System.Drawing.Point(40, 158);
			this.labelStatusC.Name = "labelStatusC";
			this.labelStatusC.Size = new System.Drawing.Size(41, 12);
			this.labelStatusC.TabIndex = 32;
			this.labelStatusC.Tag = "C";
			this.labelStatusC.Text = "未設定";
			// 
			// labelStatusB
			// 
			this.labelStatusB.AutoSize = true;
			this.labelStatusB.Location = new System.Drawing.Point(40, 119);
			this.labelStatusB.Name = "labelStatusB";
			this.labelStatusB.Size = new System.Drawing.Size(41, 12);
			this.labelStatusB.TabIndex = 31;
			this.labelStatusB.Tag = "B";
			this.labelStatusB.Text = "未設定";
			// 
			// labelStatusA
			// 
			this.labelStatusA.AutoSize = true;
			this.labelStatusA.Location = new System.Drawing.Point(40, 79);
			this.labelStatusA.Name = "labelStatusA";
			this.labelStatusA.Size = new System.Drawing.Size(41, 12);
			this.labelStatusA.TabIndex = 30;
			this.labelStatusA.Tag = "A";
			this.labelStatusA.Text = "未設定";
			// 
			// labelStatusH
			// 
			this.labelStatusH.AutoSize = true;
			this.labelStatusH.Location = new System.Drawing.Point(40, 42);
			this.labelStatusH.Name = "labelStatusH";
			this.labelStatusH.Size = new System.Drawing.Size(41, 12);
			this.labelStatusH.TabIndex = 29;
			this.labelStatusH.Tag = "H";
			this.labelStatusH.Text = "未設定";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(38, 21);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(50, 12);
			this.label18.TabIndex = 28;
			this.label18.Text = "ステータス";
			// 
			// panelEffort
			// 
			this.panelEffort.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.panelEffort.Controls.Add(this.textBoxEffortHP);
			this.panelEffort.Controls.Add(this.textBoxEffortA);
			this.panelEffort.Controls.Add(this.textBoxEffortB);
			this.panelEffort.Controls.Add(this.textBoxEffortC);
			this.panelEffort.Controls.Add(this.textBoxEffortD);
			this.panelEffort.Controls.Add(this.textBoxEffortS);
			this.panelEffort.Controls.Add(this.label15);
			this.panelEffort.Location = new System.Drawing.Point(48, 48);
			this.panelEffort.Name = "panelEffort";
			this.panelEffort.Size = new System.Drawing.Size(133, 273);
			this.panelEffort.TabIndex = 18;
			// 
			// textBoxEffortHP
			// 
			this.textBoxEffortHP.Location = new System.Drawing.Point(20, 39);
			this.textBoxEffortHP.Name = "textBoxEffortHP";
			this.textBoxEffortHP.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortHP.TabIndex = 19;
			this.textBoxEffortHP.Tag = "H";
			this.textBoxEffortHP.Text = "0";
			// 
			// textBoxEffortA
			// 
			this.textBoxEffortA.Location = new System.Drawing.Point(20, 74);
			this.textBoxEffortA.Name = "textBoxEffortA";
			this.textBoxEffortA.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortA.TabIndex = 1;
			this.textBoxEffortA.Tag = "A";
			this.textBoxEffortA.Text = "0";
			// 
			// textBoxEffortB
			// 
			this.textBoxEffortB.Location = new System.Drawing.Point(20, 116);
			this.textBoxEffortB.Name = "textBoxEffortB";
			this.textBoxEffortB.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortB.TabIndex = 2;
			this.textBoxEffortB.Tag = "B";
			this.textBoxEffortB.Text = "0";
			// 
			// textBoxEffortC
			// 
			this.textBoxEffortC.Location = new System.Drawing.Point(20, 155);
			this.textBoxEffortC.Name = "textBoxEffortC";
			this.textBoxEffortC.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortC.TabIndex = 3;
			this.textBoxEffortC.Tag = "C";
			this.textBoxEffortC.Text = "0";
			// 
			// textBoxEffortD
			// 
			this.textBoxEffortD.Location = new System.Drawing.Point(20, 197);
			this.textBoxEffortD.Name = "textBoxEffortD";
			this.textBoxEffortD.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortD.TabIndex = 4;
			this.textBoxEffortD.Tag = "D";
			this.textBoxEffortD.Text = "0";
			// 
			// textBoxEffortS
			// 
			this.textBoxEffortS.Location = new System.Drawing.Point(20, 236);
			this.textBoxEffortS.Name = "textBoxEffortS";
			this.textBoxEffortS.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortS.TabIndex = 5;
			this.textBoxEffortS.Tag = "S";
			this.textBoxEffortS.Text = "0";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(38, 20);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 12);
			this.label15.TabIndex = 16;
			this.label15.Text = "努力値";
			// 
			// buttonUpdateStatus
			// 
			this.buttonUpdateStatus.Location = new System.Drawing.Point(344, 382);
			this.buttonUpdateStatus.Name = "buttonUpdateStatus";
			this.buttonUpdateStatus.Size = new System.Drawing.Size(137, 23);
			this.buttonUpdateStatus.TabIndex = 28;
			this.buttonUpdateStatus.Text = "ステータスを更新";
			this.buttonUpdateStatus.UseVisualStyleBackColor = true;
			this.buttonUpdateStatus.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(7, 94);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(20, 12);
			this.label17.TabIndex = 18;
			this.label17.Text = "HP";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(4, 284);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(43, 12);
			this.label14.TabIndex = 15;
			this.label14.Text = "すばやさ";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(4, 248);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(36, 12);
			this.label13.TabIndex = 14;
			this.label13.Text = "とくぼう";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(7, 210);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(34, 12);
			this.label12.TabIndex = 13;
			this.label12.Text = "とくこう";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(1, 171);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(39, 12);
			this.label11.TabIndex = 12;
			this.label11.Text = "ぼうぎょ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(2, 127);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(39, 12);
			this.label10.TabIndex = 11;
			this.label10.Text = "こうげき";
			// 
			// comboBoxNature
			// 
			this.comboBoxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNature.FormattingEnabled = true;
			this.comboBoxNature.Items.AddRange(new object[] {
            "さみしがり",
            "いじっぱり",
            "やんちゃ",
            "ゆうかん",
            "ずぶとい",
            "わんぱく",
            "のうてんき",
            "のんき",
            "ひかえめ",
            "おっとり",
            "うっかりや",
            "れいせい",
            "おだやか",
            "おとなしい",
            "しんちょう",
            "なまいき",
            "おくびょう",
            "せっかち",
            "ようき",
            "むじゃき",
            "てれや",
            "すなお",
            "まじめ",
            "きまぐれ",
            "がんばりや"});
			this.comboBoxNature.Location = new System.Drawing.Point(101, 340);
			this.comboBoxNature.Name = "comboBoxNature";
			this.comboBoxNature.Size = new System.Drawing.Size(113, 20);
			this.comboBoxNature.TabIndex = 0;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(452, 481);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 13;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(556, 481);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "キャンセル";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// StatusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 516);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.groupBoxAttackPoke);
			this.Controls.Add(this.PictureBoxPoke);
			this.Name = "StatusForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "ステータス設定";
			this.Load += new System.EventHandler(this.StatusForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxPoke)).EndInit();
			this.groupBoxAttackPoke.ResumeLayout(false);
			this.groupBoxAttackPoke.PerformLayout();
			this.panelIndi.ResumeLayout(false);
			this.panelIndi.PerformLayout();
			this.panelStatus.ResumeLayout(false);
			this.panelStatus.PerformLayout();
			this.panelEffort.ResumeLayout(false);
			this.panelEffort.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private PictureBoxPoke PictureBoxPoke;
		private System.Windows.Forms.GroupBox groupBoxAttackPoke;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox comboBoxChara;
		private System.Windows.Forms.Panel panelIndi;
		private System.Windows.Forms.Panel panelStatus;
		private System.Windows.Forms.Panel panelEffort;
		private System.Windows.Forms.Button buttonUpdateStatus;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox comboBoxNature;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBoxIndiHP;
		private System.Windows.Forms.TextBox textBoxIndiA;
		private System.Windows.Forms.TextBox textBoxIndiB;
		private System.Windows.Forms.TextBox textBoxIndiC;
		private System.Windows.Forms.TextBox textBoxIndiD;
		private System.Windows.Forms.TextBox textBoxIndiS;
		private System.Windows.Forms.Label labelStatusS;
		private System.Windows.Forms.Label labelStatusD;
		private System.Windows.Forms.Label labelStatusC;
		private System.Windows.Forms.Label labelStatusB;
		private System.Windows.Forms.Label labelStatusA;
		private System.Windows.Forms.Label labelStatusH;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox textBoxEffortHP;
		private System.Windows.Forms.TextBox textBoxEffortA;
		private System.Windows.Forms.TextBox textBoxEffortB;
		private System.Windows.Forms.TextBox textBoxEffortC;
		private System.Windows.Forms.TextBox textBoxEffortD;
		private System.Windows.Forms.TextBox textBoxEffortS;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}