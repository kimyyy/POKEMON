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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageAttack = new System.Windows.Forms.TabPage();
			this.tabPageDefence = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPageEnvironment = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabPageAttack.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(126, 50);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(117, 111);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(283, 50);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(130, 111);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(135, 167);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "個体情報の入力";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(475, 285);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(346, 167);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "攻撃側のダメージは56で、\r\n確2(80%)です。\r\n";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageEnvironment);
			this.tabControl.Controls.Add(this.tabPageAttack);
			this.tabControl.Controls.Add(this.tabPageDefence);
			this.tabControl.Location = new System.Drawing.Point(471, 26);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(350, 217);
			this.tabControl.TabIndex = 4;
			// 
			// tabPageAttack
			// 
			this.tabPageAttack.Controls.Add(this.button2);
			this.tabPageAttack.Location = new System.Drawing.Point(4, 22);
			this.tabPageAttack.Name = "tabPageAttack";
			this.tabPageAttack.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAttack.Size = new System.Drawing.Size(342, 191);
			this.tabPageAttack.TabIndex = 0;
			this.tabPageAttack.Text = "攻撃側";
			this.tabPageAttack.UseVisualStyleBackColor = true;
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
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(250, 158);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 0;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
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
			this.listBox1.Location = new System.Drawing.Point(12, 61);
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
			this.listBox2.Location = new System.Drawing.Point(12, 335);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(89, 88);
			this.listBox2.TabIndex = 6;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(130, 220);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(113, 93);
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
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
			// tabPageEnvironment
			// 
			this.tabPageEnvironment.Location = new System.Drawing.Point(4, 22);
			this.tabPageEnvironment.Name = "tabPageEnvironment";
			this.tabPageEnvironment.Size = new System.Drawing.Size(342, 191);
			this.tabPageEnvironment.TabIndex = 2;
			this.tabPageEnvironment.Text = "環境";
			this.tabPageEnvironment.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 464);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "ポケモン対戦ツールbyびいの";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabPageAttack.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageAttack;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabPage tabPageDefence;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPageEnvironment;
	}
}

