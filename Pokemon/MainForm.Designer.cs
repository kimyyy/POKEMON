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
			this.tabPageEnvironment = new System.Windows.Forms.TabPage();
			this.comboBoxSkill = new System.Windows.Forms.ComboBox();
			this.tabPageAttack = new System.Windows.Forms.TabPage();
			this.buttonAttack = new System.Windows.Forms.Button();
			this.tabPageDefence = new System.Windows.Forms.TabPage();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxAttackPoke = new System.Windows.Forms.TextBox();
			this.textBoxDefencePoke = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.BoxLevel = new System.Windows.Forms.DomainUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tabControl.SuspendLayout();
			this.tabPageEnvironment.SuspendLayout();
			this.tabPageAttack.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(151, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "個体情報の入力";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBoxResult
			// 
			this.textBoxResult.Location = new System.Drawing.Point(475, 285);
			this.textBoxResult.Multiline = true;
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.Size = new System.Drawing.Size(346, 167);
			this.textBoxResult.TabIndex = 3;
			this.textBoxResult.Text = "攻撃側のダメージは56で、\r\n確2(80%)です。\r\n";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageAttack);
			this.tabControl.Controls.Add(this.tabPageDefence);
			this.tabControl.Controls.Add(this.tabPageEnvironment);
			this.tabControl.Location = new System.Drawing.Point(471, 26);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(350, 217);
			this.tabControl.TabIndex = 4;
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
			// comboBoxSkill
			// 
			this.comboBoxSkill.FormattingEnabled = true;
			this.comboBoxSkill.Location = new System.Drawing.Point(73, 29);
			this.comboBoxSkill.Name = "comboBoxSkill";
			this.comboBoxSkill.Size = new System.Drawing.Size(121, 20);
			this.comboBoxSkill.TabIndex = 0;
			this.comboBoxSkill.Text = "わざを選択";
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
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Items.AddRange(new object[] {
            "リザードン",
            "ジュカイン",
            "ムクホーク",
            "ミミロップ",
            "ムウマ",
            "ピカチュウ"});
			this.listBox1.Location = new System.Drawing.Point(12, 89);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(89, 88);
			this.listBox1.TabIndex = 5;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 12;
			this.listBox2.Items.AddRange(new object[] {
            "ルカリオ",
            "ギルガルド",
            "ガブリアス",
            "ハピナス",
            "イシツブテ",
            "カイオーガ"});
			this.listBox2.Location = new System.Drawing.Point(12, 364);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(89, 88);
			this.listBox2.TabIndex = 6;
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
			this.textBoxAttackPoke.Location = new System.Drawing.Point(151, 73);
			this.textBoxAttackPoke.Name = "textBoxAttackPoke";
			this.textBoxAttackPoke.Size = new System.Drawing.Size(100, 19);
			this.textBoxAttackPoke.TabIndex = 9;
			// 
			// textBoxDefencePoke
			// 
			this.textBoxDefencePoke.Location = new System.Drawing.Point(330, 73);
			this.textBoxDefencePoke.Name = "textBoxDefencePoke";
			this.textBoxDefencePoke.Size = new System.Drawing.Size(100, 19);
			this.textBoxDefencePoke.TabIndex = 10;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "天候";
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "もちもの";
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
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(73, 69);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 20);
			this.comboBox3.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(151, 206);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(291, 223);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ステータス(攻撃側)";
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
			// BoxLevel
			// 
			this.BoxLevel.Location = new System.Drawing.Point(60, 26);
			this.BoxLevel.Name = "BoxLevel";
			this.BoxLevel.ReadOnly = true;
			this.BoxLevel.Size = new System.Drawing.Size(41, 19);
			this.BoxLevel.TabIndex = 13;
			this.BoxLevel.Text = "50";
			this.BoxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 464);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.BoxLevel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBoxDefencePoke);
			this.Controls.Add(this.textBoxAttackPoke);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "ポケモン対戦ツールbyびいの";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPageEnvironment.ResumeLayout(false);
			this.tabPageEnvironment.PerformLayout();
			this.tabPageAttack.ResumeLayout(false);
			this.tabPageAttack.PerformLayout();
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
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DomainUpDown BoxLevel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}

