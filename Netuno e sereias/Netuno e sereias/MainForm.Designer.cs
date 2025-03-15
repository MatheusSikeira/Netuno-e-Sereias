/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 02/04/2024
 * Hora: 19:46
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Netuno_e_sereias
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button calcular;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textbox1;
		private System.Windows.Forms.TextBox textbox2;
		private System.Windows.Forms.TextBox textbox3;
		private System.Windows.Forms.TextBox textbox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.calcular = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textbox1 = new System.Windows.Forms.TextBox();
			this.textbox2 = new System.Windows.Forms.TextBox();
			this.textbox3 = new System.Windows.Forms.TextBox();
			this.textbox4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// calcular
			// 
			this.calcular.BackColor = System.Drawing.Color.MediumAquamarine;
			this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calcular.Location = new System.Drawing.Point(8, 227);
			this.calcular.Margin = new System.Windows.Forms.Padding(2);
			this.calcular.Name = "calcular";
			this.calcular.Size = new System.Drawing.Size(151, 28);
			this.calcular.TabIndex = 0;
			this.calcular.Text = "Calcular";
			this.calcular.UseVisualStyleBackColor = false;
			this.calcular.Click += new System.EventHandler(this.CalcularClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(213, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bem-vindo";
			// 
			// textbox1
			// 
			this.textbox1.Location = new System.Drawing.Point(9, 64);
			this.textbox1.Margin = new System.Windows.Forms.Padding(2);
			this.textbox1.Name = "textbox1";
			this.textbox1.Size = new System.Drawing.Size(151, 20);
			this.textbox1.TabIndex = 2;
			// 
			// textbox2
			// 
			this.textbox2.Location = new System.Drawing.Point(8, 129);
			this.textbox2.Margin = new System.Windows.Forms.Padding(2);
			this.textbox2.Name = "textbox2";
			this.textbox2.Size = new System.Drawing.Size(151, 20);
			this.textbox2.TabIndex = 3;
			// 
			// textbox3
			// 
			this.textbox3.Location = new System.Drawing.Point(8, 192);
			this.textbox3.Margin = new System.Windows.Forms.Padding(2);
			this.textbox3.Name = "textbox3";
			this.textbox3.Size = new System.Drawing.Size(151, 20);
			this.textbox3.TabIndex = 4;
			// 
			// textbox4
			// 
			this.textbox4.Location = new System.Drawing.Point(190, 238);
			this.textbox4.Margin = new System.Windows.Forms.Padding(2);
			this.textbox4.Name = "textbox4";
			this.textbox4.Size = new System.Drawing.Size(151, 20);
			this.textbox4.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Vivaldi", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(138, 6);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(205, 38);
			this.label2.TabIndex = 6;
			this.label2.Text = "Netuno e sereias";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(335, 14);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(38, 29);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 49);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Coloque a altura:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 114);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Coloque a largura:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 177);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Coloque o comprimento:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(239, 223);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Resultado:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(284, 79);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(209, 70);
			this.label7.TabIndex = 12;
			this.label7.Text = "Observação: cobramos R$49,99 por metro cúbico e R$250,00 por despesas gerais.\r\n";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(355, 160);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(68, 64);
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(501, 263);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textbox4);
			this.Controls.Add(this.textbox3);
			this.Controls.Add(this.textbox2);
			this.Controls.Add(this.textbox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.calcular);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Netuno e sereias";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
