using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using AIMLbot;
/// <summary>
/// Robert AI created by Jurijus Pacalovas
/// </summary>


namespace Robert
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SpeechSynthesizer s = new SpeechSynthesizer();
			s.SelectVoiceByHints(VoiceGender.Male);
			textBox3.Text = textBox1.Text;
			Bot Robert = new Bot();
			Robert.loadSettings();
			Robert.loadAIMLFromFiles();
			Robert.isAcceptingUserInput = false;
			User user = new User("user", Robert);
			Robert.isAcceptingUserInput = true;
			Request r = new Request(textBox1.Text, user, Robert);
			Result result = Robert.Chat(r);
			textBox2.Text = result.Output;
			string a = textBox2.Text;
			s.SpeakAsync(a);




		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
