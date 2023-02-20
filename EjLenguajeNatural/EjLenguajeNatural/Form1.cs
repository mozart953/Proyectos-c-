using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace EjLenguajeNatural
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine oEscucha = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-ES"));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oEscucha.SetInputToDefaultAudioDevice();
            oEscucha.LoadGrammar(new DictationGrammar());
            //*nueva gramatica
            Choices colors = new Choices();
            colors.Add(new string[] { "negro", "rojo", "azul", "verde", "naranja","mover izquierda","mover derecha","mover abajo", "mover arriba", "cerrar programa", "Apagar computadora"});
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(colors);
            Grammar g = new Grammar(gb);
            oEscucha.LoadGrammar(g);
            //fin de la nueva gramatica
            oEscucha.SpeechRecognized += Detection;
            oEscucha.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Detection(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "mover izquierda")
            {
                button3.Left = button3.Left - 100;

                PromptBuilder builder = new PromptBuilder();
                builder.StartVoice(VoiceGender.Female, VoiceAge.Adult);
                builder.AppendText("moviendo a la izquierda");
                builder.EndVoice();
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Speak(builder);
                synthesizer.Dispose();
            }
            if (e.Result.Text == "mover abajo")
            {
                button3.Top = button3.Top + 100;
                PromptBuilder builder = new PromptBuilder();
                builder.StartVoice(VoiceGender.Female, VoiceAge.Adult);
                builder.AppendText("moviendo para abajo");
                builder.EndVoice();
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Speak(builder);
                synthesizer.Dispose();
            }
            if (e.Result.Text == "mover arriba")
            {
                button3.Top = button3.Top - 100;
                PromptBuilder builder = new PromptBuilder();
                builder.StartVoice(VoiceGender.Female, VoiceAge.Adult);
                builder.AppendText("moviendo para arriba");
                builder.EndVoice();
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Speak(builder);
                synthesizer.Dispose();
            }
            if (e.Result.Text == "mover derecha")
            {
                PromptBuilder builder = new PromptBuilder();
                builder.StartVoice(VoiceGender.Male, VoiceAge.Adult);
                builder.AppendText("moviendo a la derecha");
                builder.EndVoice();
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Speak(builder);
                synthesizer.Dispose();

                button3.Left = button3.Left + 100;
            }
            if (e.Result.Text == "cerrar programa")
            {
                PromptBuilder builder = new PromptBuilder();
                builder.StartVoice(VoiceGender.Male, VoiceAge.Adult);
                builder.AppendText("cerrando programa");
                builder.EndVoice();
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Speak(builder);
                synthesizer.Dispose();

                this.Close();
            }
            if (e.Result.Text == "Apagar computadora")
            {
                PromptBuilder builder = new PromptBuilder();
                builder.StartVoice(VoiceGender.Male, VoiceAge.Adult);
                builder.AppendText("Apagando computadora");
                builder.EndVoice();
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Speak(builder);
                synthesizer.Dispose();

                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown -s -t 60");
                System.Diagnostics.Process proceso = new System.Diagnostics.Process();
                proceso.StartInfo = info;
                proceso.Start();

            }
            if (e.Result.Text == "negro") button3.BackColor = Color.Black;
            if (e.Result.Text == "rojo") button3.BackColor = Color.Red;
            if (e.Result.Text == "azul") button3.BackColor = Color.Blue;
            if (e.Result.Text == "verde") button3.BackColor = Color.Green;
            textBox1.Text = e.Result.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oEscucha.RecognizeAsyncStop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown -a");
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            proceso.StartInfo = info;
            proceso.Start();

        }
    }
}
