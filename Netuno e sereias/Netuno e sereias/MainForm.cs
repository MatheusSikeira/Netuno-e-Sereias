
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Netuno_e_sereias
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			
			
			
			
			

		
	
		}
		void CalcularClick(object sender, EventArgs e)
		{
		
		//Declaração de variavel	
		double al,lar,com,vol,resultado;
			
			
			
		//altura:	
	 	al = double.Parse(textbox1.Text);
			
			
		//largura:
		lar = double.Parse(textbox2.Text);
		
		//comprimento
		com = double.Parse(textbox3.Text);
		
		//Formula e calculo do volume
		vol = al*lar*com;
		
		//volume + custos adicionais
		resultado = (vol*49.99f)+250.00f;
		
		//converter o resultado em texto
		textbox4.Text = resultado.ToString("C");
			
			
			
			
		
	
	
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
	}
}
