namespace Pokemon
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageAttack = new System.Windows.Forms.TabPage();
			this.comboBoxItem = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxSkill = new System.Windows.Forms.ComboBox();
			this.buttonAttack = new System.Windows.Forms.Button();
			this.tabPageDefence = new System.Windows.Forms.TabPage();
			this.tabPageEnvironment = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.NumLevel = new System.Windows.Forms.NumericUpDown();
			this.panelResult = new System.Windows.Forms.Panel();
			this.panelBattleZone = new System.Windows.Forms.Panel();
			this.panelDefencePoke = new System.Windows.Forms.Panel();
			this.PictureBoxDefencePoke = new Pokemon.PictureBoxPoke();
			this.panelAttackPoke = new System.Windows.Forms.Panel();
			this.pictureBoxAttackPoke = new Pokemon.PictureBoxPoke();
			this.progressBarDefence = new System.Windows.Forms.ProgressBar();
			this.progressBarAttack = new System.Windows.Forms.ProgressBar();
			this.panelLevel = new System.Windows.Forms.Panel();
			this.PanelEnemyParty = new Pokemon.PartyPanel();
			this.PanelMyParty = new Pokemon.PartyPanel();
			this.tabControl.SuspendLayout();
			this.tabPageAttack.SuspendLayout();
			this.tabPageEnvironment.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumLevel)).BeginInit();
			this.panelResult.SuspendLayout();
			this.panelBattleZone.SuspendLayout();
			this.panelDefencePoke.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxDefencePoke)).BeginInit();
			this.panelAttackPoke.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackPoke)).BeginInit();
			this.panelLevel.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxResult
			// 
			this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxResult.Location = new System.Drawing.Point(7, 32);
			this.textBoxResult.Multiline = true;
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.Size = new System.Drawing.Size(366, 166);
			this.textBoxResult.TabIndex = 3;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageAttack);
			this.tabControl.Controls.Add(this.tabPageDefence);
			this.tabControl.Controls.Add(this.tabPageEnvironment);
			this.tabControl.Location = new System.Drawing.Point(19, 358);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(391, 233);
			this.tabControl.TabIndex = 4;
			// 
			// tabPageAttack
			// 
			this.tabPageAttack.Controls.Add(this.comboBoxItem);
			this.tabPageAttack.Controls.Add(this.comboBox2);
			this.tabPageAttack.Controls.Add(this.label5);
			this.tabPageAttack.Controls.Add(this.label4);
			this.tabPageAttack.Controls.Add(this.label3);
			this.tabPageAttack.Controls.Add(this.comboBoxSkill);
			this.tabPageAttack.Controls.Add(this.buttonAttack);
			this.tabPageAttack.Location = new System.Drawing.Point(4, 22);
			this.tabPageAttack.Name = "tabPageAttack";
			this.tabPageAttack.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAttack.Size = new System.Drawing.Size(383, 207);
			this.tabPageAttack.TabIndex = 0;
			this.tabPageAttack.Text = "攻撃側";
			this.tabPageAttack.UseVisualStyleBackColor = true;
			// 
			// comboBoxItem
			// 
			this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxItem.FormattingEnabled = true;
			this.comboBoxItem.Items.AddRange(new object[] {
            "いのちのたま",
            "こだわりハチマキ",
            "こだわりメガネ",
            "こだわりスカーフ",
            "たつじんのおび",
            "ちからのハチマキ"});
			this.comboBoxItem.Location = new System.Drawing.Point(73, 61);
			this.comboBoxItem.Name = "comboBoxItem";
			this.comboBoxItem.Size = new System.Drawing.Size(121, 20);
			this.comboBoxItem.TabIndex = 5;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "0",
            "+2",
            "+1",
            "-1",
            "-2"});
			this.comboBox2.Location = new System.Drawing.Point(73, 103);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 20);
			this.comboBox2.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 12);
			this.label5.TabIndex = 3;
			this.label5.Text = "ランク";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "もちもの";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "わざ";
			// 
			// comboBoxSkill
			// 
			this.comboBoxSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSkill.FormattingEnabled = true;
			this.comboBoxSkill.Location = new System.Drawing.Point(73, 29);
			this.comboBoxSkill.Name = "comboBoxSkill";
			this.comboBoxSkill.Size = new System.Drawing.Size(121, 20);
			this.comboBoxSkill.TabIndex = 0;
			this.comboBoxSkill.TextChanged += new System.EventHandler(this.comboBoxSkill_TextChanged);
			// 
			// buttonAttack
			// 
			this.buttonAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAttack.Location = new System.Drawing.Point(302, 178);
			this.buttonAttack.Name = "buttonAttack";
			this.buttonAttack.Size = new System.Drawing.Size(75, 23);
			this.buttonAttack.TabIndex = 0;
			this.buttonAttack.Text = "攻撃！";
			this.buttonAttack.UseVisualStyleBackColor = true;
			this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
			// 
			// tabPageDefence
			// 
			this.tabPageDefence.Location = new System.Drawing.Point(4, 22);
			this.tabPageDefence.Name = "tabPageDefence";
			this.tabPageDefence.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDefence.Size = new System.Drawing.Size(383, 207);
			this.tabPageDefence.TabIndex = 1;
			this.tabPageDefence.Text = "防御側";
			this.tabPageDefence.UseVisualStyleBackColor = true;
			// 
			// tabPageEnvironment
			// 
			this.tabPageEnvironment.Controls.Add(this.label2);
			this.tabPageEnvironment.Controls.Add(this.comboBox1);
			this.tabPageEnvironment.Location = new System.Drawing.Point(4, 22);
			this.tabPageEnvironment.Name = "tabPageEnvironment";
			this.tabPageEnvironment.Size = new System.Drawing.Size(383, 207);
			this.tabPageEnvironment.TabIndex = 2;
			this.tabPageEnvironment.Text = "環境";
			this.tabPageEnvironment.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "天候";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "はれ",
            "あめ",
            "ひでり",
            "あられ",
            "すなあらし"});
			this.comboBox1.Location = new System.Drawing.Point(87, 18);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 8;
			this.label1.Text = "結果/考察";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(176, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(20, 12);
			this.label6.TabIndex = 12;
			this.label6.Text = "VS";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 12);
			this.label7.TabIndex = 14;
			this.label7.Text = "Lv";
			// 
			// NumLevel
			// 
			this.NumLevel.Location = new System.Drawing.Point(39, 6);
			this.NumLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumLevel.Name = "NumLevel";
			this.NumLevel.ReadOnly = true;
			this.NumLevel.Size = new System.Drawing.Size(49, 19);
			this.NumLevel.TabIndex = 17;
			this.NumLevel.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// panelResult
			// 
			this.panelResult.Controls.Add(this.label1);
			this.panelResult.Controls.Add(this.textBoxResult);
			this.panelResult.Location = new System.Drawing.Point(432, 369);
			this.panelResult.Name = "panelResult";
			this.panelResult.Size = new System.Drawing.Size(376, 212);
			this.panelResult.TabIndex = 18;
			// 
			// panelBattleZone
			// 
			this.panelBattleZone.Controls.Add(this.panelDefencePoke);
			this.panelBattleZone.Controls.Add(this.panelAttackPoke);
			this.panelBattleZone.Controls.Add(this.progressBarDefence);
			this.panelBattleZone.Controls.Add(this.progressBarAttack);
			this.panelBattleZone.Controls.Add(this.label6);
			this.panelBattleZone.Location = new System.Drawing.Point(227, 60);
			this.panelBattleZone.Name = "panelBattleZone";
			this.panelBattleZone.Size = new System.Drawing.Size(366, 187);
			this.panelBattleZone.TabIndex = 19;
			// 
			// panelDefencePoke
			// 
			this.panelDefencePoke.AllowDrop = true;
			this.panelDefencePoke.Controls.Add(this.PictureBoxDefencePoke);
			this.panelDefencePoke.Location = new System.Drawing.Point(257, 7);
			this.panelDefencePoke.Name = "panelDefencePoke";
			this.panelDefencePoke.Size = new System.Drawing.Size(80, 80);
			this.panelDefencePoke.TabIndex = 26;
			this.panelDefencePoke.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDefencePoke_DragDrop);
			this.panelDefencePoke.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDefencePoke_DragEnter);
			// 
			// PictureBoxDefencePoke
			// 
			this.PictureBoxDefencePoke.BackColor = System.Drawing.Color.White;
			this.PictureBoxDefencePoke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBoxDefencePoke.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PictureBoxDefencePoke.Location = new System.Drawing.Point(0, 0);
			this.PictureBoxDefencePoke.Name = "PictureBoxDefencePoke";
			this.PictureBoxDefencePoke.Poke = null;
			this.PictureBoxDefencePoke.Size = new System.Drawing.Size(80, 80);
			this.PictureBoxDefencePoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxDefencePoke.TabIndex = 26;
			this.PictureBoxDefencePoke.TabStop = false;
			// 
			// panelAttackPoke
			// 
			this.panelAttackPoke.AllowDrop = true;
			this.panelAttackPoke.Controls.Add(this.pictureBoxAttackPoke);
			this.panelAttackPoke.Location = new System.Drawing.Point(20, 7);
			this.panelAttackPoke.Name = "panelAttackPoke";
			this.panelAttackPoke.Size = new System.Drawing.Size(80, 80);
			this.panelAttackPoke.TabIndex = 26;
			this.panelAttackPoke.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAttackPoke_DragDrop);
			this.panelAttackPoke.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAttackPoke_DragEnter);
			// 
			// pictureBoxAttackPoke
			// 
			this.pictureBoxAttackPoke.BackColor = System.Drawing.Color.White;
			this.pictureBoxAttackPoke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxAttackPoke.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxAttackPoke.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxAttackPoke.Name = "pictureBoxAttackPoke";
			this.pictureBoxAttackPoke.Poke = null;
			this.pictureBoxAttackPoke.Size = new System.Drawing.Size(80, 80);
			this.pictureBoxAttackPoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAttackPoke.TabIndex = 25;
			this.pictureBoxAttackPoke.TabStop = false;
			this.pictureBoxAttackPoke.DragDrop += new System.Windows.Forms.DragEventHandler(this.PokePicAttackPoke_DragEnter);
			// 
			// progressBarDefence
			// 
			this.progressBarDefence.Location = new System.Drawing.Point(244, 140);
			this.progressBarDefence.Name = "progressBarDefence";
			this.progressBarDefence.Size = new System.Drawing.Size(116, 23);
			this.progressBarDefence.TabIndex = 24;
			// 
			// progressBarAttack
			// 
			this.progressBarAttack.ForeColor = System.Drawing.Color.Lime;
			this.progressBarAttack.Location = new System.Drawing.Point(10, 140);
			this.progressBarAttack.Name = "progressBarAttack";
			this.progressBarAttack.Size = new System.Drawing.Size(112, 23);
			this.progressBarAttack.TabIndex = 23;
			// 
			// panelLevel
			// 
			this.panelLevel.Controls.Add(this.label7);
			this.panelLevel.Controls.Add(this.NumLevel);
			this.panelLevel.Location = new System.Drawing.Point(19, 26);
			this.panelLevel.Name = "panelLevel";
			this.panelLevel.Size = new System.Drawing.Size(124, 30);
			this.panelLevel.TabIndex = 22;
			// 
			// PanelEnemyParty
			// 
			this.PanelEnemyParty.Location = new System.Drawing.Point(615, 62);
			this.PanelEnemyParty.Name = "PanelEnemyParty";
			this.PanelEnemyParty.Party = new Pokemon.Poke[] {
        null,
        null,
        null,
        null,
        null,
        null};
			this.PanelEnemyParty.Size = new System.Drawing.Size(160, 240);
			this.PanelEnemyParty.TabIndex = 25;
			// 
			// PanelMyParty
			// 
			this.PanelMyParty.Location = new System.Drawing.Point(58, 62);
			this.PanelMyParty.Name = "PanelMyParty";
			this.PanelMyParty.Party = new Pokemon.Poke[] {
        null,
        null,
        null,
        null,
        null,
        null};
			this.PanelMyParty.Size = new System.Drawing.Size(160, 240);
			this.PanelMyParty.TabIndex = 23;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 610);
			this.Controls.Add(this.PanelEnemyParty);
			this.Controls.Add(this.PanelMyParty);
			this.Controls.Add(this.panelLevel);
			this.Controls.Add(this.panelBattleZone);
			this.Controls.Add(this.panelResult);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "ポケモン対戦ツールbyびいの";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
			this.tabControl.ResumeLayout(false);
			this.tabPageAttack.ResumeLayout(false);
			this.tabPageAttack.PerformLayout();
			this.tabPageEnvironment.ResumeLayout(false);
			this.tabPageEnvironment.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumLevel)).EndInit();
			this.panelResult.ResumeLayout(false);
			this.panelResult.PerformLayout();
			this.panelBattleZone.ResumeLayout(false);
			this.panelBattleZone.PerformLayout();
			this.panelDefencePoke.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxDefencePoke)).EndInit();
			this.panelAttackPoke.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttackPoke)).EndInit();
			this.panelLevel.ResumeLayout(false);
			this.panelLevel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageAttack;
		private System.Windows.Forms.Button buttonAttack;
		private System.Windows.Forms.TabPage tabPageDefence;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPageEnvironment;
		private System.Windows.Forms.ComboBox comboBoxSkill;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBoxItem;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown NumLevel;
		private System.Windows.Forms.Panel panelResult;
		private System.Windows.Forms.Panel panelBattleZone;
		private System.Windows.Forms.Panel panelLevel;
		private System.Windows.Forms.ProgressBar progressBarDefence;
		private System.Windows.Forms.ProgressBar progressBarAttack;
		private PartyPanel PanelMyParty;
		private PartyPanel PanelEnemyParty;
		private PictureBoxPoke pictureBoxAttackPoke;
		private PictureBoxPoke PictureBoxDefencePoke;
		private System.Windows.Forms.Panel panelAttackPoke;
		private System.Windows.Forms.Panel panelDefencePoke;
	}
}

