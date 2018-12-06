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
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageAttack = new System.Windows.Forms.TabPage();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
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
			this.listBoxMyParty = new System.Windows.Forms.ListBox();
			this.listBoxEnemyParty = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxAttackPoke = new System.Windows.Forms.TextBox();
			this.textBoxDefencePoke = new System.Windows.Forms.TextBox();
			this.groupBoxAttackPoke = new System.Windows.Forms.GroupBox();
			this.textBoxIndiHP = new System.Windows.Forms.TextBox();
			this.textBoxEffortHP = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxIndiS = new System.Windows.Forms.TextBox();
			this.textBoxIndiD = new System.Windows.Forms.TextBox();
			this.textBoxIndiC = new System.Windows.Forms.TextBox();
			this.textBoxIndiB = new System.Windows.Forms.TextBox();
			this.textBoxIndiA = new System.Windows.Forms.TextBox();
			this.textBoxEffortS = new System.Windows.Forms.TextBox();
			this.textBoxEffortD = new System.Windows.Forms.TextBox();
			this.textBoxEffortC = new System.Windows.Forms.TextBox();
			this.textBoxEffortB = new System.Windows.Forms.TextBox();
			this.textBoxEffortA = new System.Windows.Forms.TextBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.NumLevel = new System.Windows.Forms.NumericUpDown();
			this.tabControl.SuspendLayout();
			this.tabPageAttack.SuspendLayout();
			this.tabPageEnvironment.SuspendLayout();
			this.groupBoxAttackPoke.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumLevel)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(151, 590);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "個体情報の入力";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxResult
			// 
			this.textBoxResult.Location = new System.Drawing.Point(475, 285);
			this.textBoxResult.Multiline = true;
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.Size = new System.Drawing.Size(346, 167);
			this.textBoxResult.TabIndex = 3;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageAttack);
			this.tabControl.Controls.Add(this.tabPageDefence);
			this.tabControl.Controls.Add(this.tabPageEnvironment);
			this.tabControl.Location = new System.Drawing.Point(475, 26);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(350, 217);
			this.tabControl.TabIndex = 4;
			// 
			// tabPageAttack
			// 
			this.tabPageAttack.Controls.Add(this.comboBox3);
			this.tabPageAttack.Controls.Add(this.comboBox2);
			this.tabPageAttack.Controls.Add(this.label5);
			this.tabPageAttack.Controls.Add(this.label4);
			this.tabPageAttack.Controls.Add(this.label3);
			this.tabPageAttack.Controls.Add(this.comboBoxSkill);
			this.tabPageAttack.Controls.Add(this.buttonAttack);
			this.tabPageAttack.Location = new System.Drawing.Point(4, 22);
			this.tabPageAttack.Name = "tabPageAttack";
			this.tabPageAttack.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAttack.Size = new System.Drawing.Size(342, 191);
			this.tabPageAttack.TabIndex = 0;
			this.tabPageAttack.Text = "攻撃側";
			this.tabPageAttack.UseVisualStyleBackColor = true;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(73, 69);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 20);
			this.comboBox3.TabIndex = 5;
			// 
			// comboBox2
			// 
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
			this.comboBox2.Text = "0";
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
			this.label4.Location = new System.Drawing.Point(18, 77);
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
			this.comboBoxSkill.FormattingEnabled = true;
			this.comboBoxSkill.Location = new System.Drawing.Point(73, 29);
			this.comboBoxSkill.Name = "comboBoxSkill";
			this.comboBoxSkill.Size = new System.Drawing.Size(121, 20);
			this.comboBoxSkill.TabIndex = 0;
			this.comboBoxSkill.Text = "わざを選択";
			// 
			// buttonAttack
			// 
			this.buttonAttack.Location = new System.Drawing.Point(250, 158);
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
			this.tabPageDefence.Size = new System.Drawing.Size(342, 191);
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
			this.tabPageEnvironment.Size = new System.Drawing.Size(342, 191);
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
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "",
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
			// listBoxMyParty
			// 
			this.listBoxMyParty.FormattingEnabled = true;
			this.listBoxMyParty.ItemHeight = 12;
			this.listBoxMyParty.Items.AddRange(new object[] {
            "リザードン",
            "ジュカイン",
            "ムクホーク",
            "ミミロップ",
            "ムウマ",
            "ピカチュウ"});
			this.listBoxMyParty.Location = new System.Drawing.Point(12, 89);
			this.listBoxMyParty.Name = "listBoxMyParty";
			this.listBoxMyParty.Size = new System.Drawing.Size(89, 88);
			this.listBoxMyParty.TabIndex = 5;
			this.listBoxMyParty.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListboxParty_MouseDown);
			// 
			// listBoxEnemyParty
			// 
			this.listBoxEnemyParty.FormattingEnabled = true;
			this.listBoxEnemyParty.ItemHeight = 12;
			this.listBoxEnemyParty.Items.AddRange(new object[] {
            "ルカリオ",
            "ギルガルド",
            "ガブリアス",
            "ハピナス",
            "イシツブテ",
            "カイオーガ"});
			this.listBoxEnemyParty.Location = new System.Drawing.Point(12, 364);
			this.listBoxEnemyParty.Name = "listBoxEnemyParty";
			this.listBoxEnemyParty.Size = new System.Drawing.Size(89, 88);
			this.listBoxEnemyParty.TabIndex = 6;
			this.listBoxEnemyParty.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListboxParty_MouseDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(469, 260);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 8;
			this.label1.Text = "結果/考察";
			// 
			// textBoxAttackPoke
			// 
			this.textBoxAttackPoke.AllowDrop = true;
			this.textBoxAttackPoke.Location = new System.Drawing.Point(151, 73);
			this.textBoxAttackPoke.Name = "textBoxAttackPoke";
			this.textBoxAttackPoke.ReadOnly = true;
			this.textBoxAttackPoke.Size = new System.Drawing.Size(100, 19);
			this.textBoxAttackPoke.TabIndex = 9;
			this.textBoxAttackPoke.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxPoke_DragDrop);
			this.textBoxAttackPoke.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxPoke_DragEnter);
			// 
			// textBoxDefencePoke
			// 
			this.textBoxDefencePoke.AllowDrop = true;
			this.textBoxDefencePoke.Location = new System.Drawing.Point(330, 73);
			this.textBoxDefencePoke.Name = "textBoxDefencePoke";
			this.textBoxDefencePoke.ReadOnly = true;
			this.textBoxDefencePoke.Size = new System.Drawing.Size(100, 19);
			this.textBoxDefencePoke.TabIndex = 10;
			this.textBoxDefencePoke.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxPoke_DragDrop);
			this.textBoxDefencePoke.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxPoke_DragEnter);
			// 
			// groupBoxAttackPoke
			// 
			this.groupBoxAttackPoke.Controls.Add(this.textBoxIndiHP);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxEffortHP);
			this.groupBoxAttackPoke.Controls.Add(this.label17);
			this.groupBoxAttackPoke.Controls.Add(this.label16);
			this.groupBoxAttackPoke.Controls.Add(this.label15);
			this.groupBoxAttackPoke.Controls.Add(this.label14);
			this.groupBoxAttackPoke.Controls.Add(this.label13);
			this.groupBoxAttackPoke.Controls.Add(this.label12);
			this.groupBoxAttackPoke.Controls.Add(this.label11);
			this.groupBoxAttackPoke.Controls.Add(this.label10);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxIndiS);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxIndiD);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxIndiC);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxIndiB);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxIndiA);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxEffortS);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxEffortD);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxEffortC);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxEffortB);
			this.groupBoxAttackPoke.Controls.Add(this.textBoxEffortA);
			this.groupBoxAttackPoke.Controls.Add(this.comboBox4);
			this.groupBoxAttackPoke.Location = new System.Drawing.Point(151, 195);
			this.groupBoxAttackPoke.Name = "groupBoxAttackPoke";
			this.groupBoxAttackPoke.Size = new System.Drawing.Size(291, 348);
			this.groupBoxAttackPoke.TabIndex = 11;
			this.groupBoxAttackPoke.TabStop = false;
			this.groupBoxAttackPoke.Text = "ステータス(攻撃側)";
			// 
			// textBoxIndiHP
			// 
			this.textBoxIndiHP.Location = new System.Drawing.Point(170, 69);
			this.textBoxIndiHP.Name = "textBoxIndiHP";
			this.textBoxIndiHP.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiHP.TabIndex = 20;
			this.textBoxIndiHP.Text = "0";
			// 
			// textBoxEffortHP
			// 
			this.textBoxEffortHP.Location = new System.Drawing.Point(51, 69);
			this.textBoxEffortHP.Name = "textBoxEffortHP";
			this.textBoxEffortHP.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortHP.TabIndex = 19;
			this.textBoxEffortHP.Text = "0";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(3, 76);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(20, 12);
			this.label17.TabIndex = 18;
			this.label17.Text = "HP";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(191, 29);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 12);
			this.label16.TabIndex = 17;
			this.label16.Text = "個体値";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(81, 30);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 12);
			this.label15.TabIndex = 16;
			this.label15.Text = "努力値";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(3, 268);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(43, 12);
			this.label14.TabIndex = 15;
			this.label14.Text = "すばやさ";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(7, 229);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(36, 12);
			this.label13.TabIndex = 14;
			this.label13.Text = "とくぼう";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 188);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(34, 12);
			this.label12.TabIndex = 13;
			this.label12.Text = "とくこう";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 149);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(39, 12);
			this.label11.TabIndex = 12;
			this.label11.Text = "ぼうぎょ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 106);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(39, 12);
			this.label10.TabIndex = 11;
			this.label10.Text = "こうげき";
			// 
			// textBoxIndiS
			// 
			this.textBoxIndiS.Location = new System.Drawing.Point(170, 268);
			this.textBoxIndiS.Name = "textBoxIndiS";
			this.textBoxIndiS.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiS.TabIndex = 10;
			this.textBoxIndiS.Text = "0";
			// 
			// textBoxIndiD
			// 
			this.textBoxIndiD.Location = new System.Drawing.Point(170, 226);
			this.textBoxIndiD.Name = "textBoxIndiD";
			this.textBoxIndiD.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiD.TabIndex = 9;
			this.textBoxIndiD.Text = "0";
			// 
			// textBoxIndiC
			// 
			this.textBoxIndiC.Location = new System.Drawing.Point(170, 188);
			this.textBoxIndiC.Name = "textBoxIndiC";
			this.textBoxIndiC.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiC.TabIndex = 8;
			this.textBoxIndiC.Text = "0";
			// 
			// textBoxIndiB
			// 
			this.textBoxIndiB.Location = new System.Drawing.Point(170, 146);
			this.textBoxIndiB.Name = "textBoxIndiB";
			this.textBoxIndiB.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiB.TabIndex = 7;
			this.textBoxIndiB.Text = "0";
			// 
			// textBoxIndiA
			// 
			this.textBoxIndiA.Location = new System.Drawing.Point(170, 103);
			this.textBoxIndiA.Name = "textBoxIndiA";
			this.textBoxIndiA.Size = new System.Drawing.Size(100, 19);
			this.textBoxIndiA.TabIndex = 6;
			this.textBoxIndiA.Text = "0";
			// 
			// textBoxEffortS
			// 
			this.textBoxEffortS.Location = new System.Drawing.Point(51, 268);
			this.textBoxEffortS.Name = "textBoxEffortS";
			this.textBoxEffortS.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortS.TabIndex = 5;
			this.textBoxEffortS.Text = "0";
			// 
			// textBoxEffortD
			// 
			this.textBoxEffortD.Location = new System.Drawing.Point(51, 226);
			this.textBoxEffortD.Name = "textBoxEffortD";
			this.textBoxEffortD.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortD.TabIndex = 4;
			this.textBoxEffortD.Text = "0";
			// 
			// textBoxEffortC
			// 
			this.textBoxEffortC.Location = new System.Drawing.Point(51, 188);
			this.textBoxEffortC.Name = "textBoxEffortC";
			this.textBoxEffortC.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortC.TabIndex = 3;
			this.textBoxEffortC.Text = "0";
			// 
			// textBoxEffortB
			// 
			this.textBoxEffortB.Location = new System.Drawing.Point(51, 146);
			this.textBoxEffortB.Name = "textBoxEffortB";
			this.textBoxEffortB.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortB.TabIndex = 2;
			this.textBoxEffortB.Text = "0";
			// 
			// textBoxEffortA
			// 
			this.textBoxEffortA.Location = new System.Drawing.Point(51, 103);
			this.textBoxEffortA.Name = "textBoxEffortA";
			this.textBoxEffortA.Size = new System.Drawing.Size(100, 19);
			this.textBoxEffortA.TabIndex = 1;
			this.textBoxEffortA.Text = "0";
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(149, 312);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 20);
			this.comboBox4.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(282, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(20, 12);
			this.label6.TabIndex = 12;
			this.label6.Text = "VS";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(28, 28);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 12);
			this.label7.TabIndex = 14;
			this.label7.Text = "Lv";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(28, 61);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 12);
			this.label8.TabIndex = 15;
			this.label8.Text = "自パーティ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(16, 340);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 12);
			this.label9.TabIndex = 16;
			this.label9.Text = "相手パーティ";
			// 
			// NumLevel
			// 
			this.NumLevel.Location = new System.Drawing.Point(51, 26);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 726);
			this.Controls.Add(this.NumLevel);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBoxAttackPoke);
			this.Controls.Add(this.textBoxDefencePoke);
			this.Controls.Add(this.textBoxAttackPoke);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxEnemyParty);
			this.Controls.Add(this.listBoxMyParty);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "ポケモン対戦ツールbyびいの";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPageAttack.ResumeLayout(false);
			this.tabPageAttack.PerformLayout();
			this.tabPageEnvironment.ResumeLayout(false);
			this.tabPageEnvironment.PerformLayout();
			this.groupBoxAttackPoke.ResumeLayout(false);
			this.groupBoxAttackPoke.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumLevel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageAttack;
		private System.Windows.Forms.Button buttonAttack;
		private System.Windows.Forms.TabPage tabPageDefence;
		private System.Windows.Forms.ListBox listBoxMyParty;
		private System.Windows.Forms.ListBox listBoxEnemyParty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPageEnvironment;
		private System.Windows.Forms.ComboBox comboBoxSkill;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAttackPoke;
		private System.Windows.Forms.TextBox textBoxDefencePoke;
		private System.Windows.Forms.GroupBox groupBoxAttackPoke;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxIndiHP;
		private System.Windows.Forms.TextBox textBoxEffortHP;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxIndiS;
		private System.Windows.Forms.TextBox textBoxIndiD;
		private System.Windows.Forms.TextBox textBoxIndiC;
		private System.Windows.Forms.TextBox textBoxIndiB;
		private System.Windows.Forms.TextBox textBoxIndiA;
		private System.Windows.Forms.TextBox textBoxEffortS;
		private System.Windows.Forms.TextBox textBoxEffortD;
		private System.Windows.Forms.TextBox textBoxEffortC;
		private System.Windows.Forms.TextBox textBoxEffortB;
		private System.Windows.Forms.TextBox textBoxEffortA;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.NumericUpDown NumLevel;
	}
}

