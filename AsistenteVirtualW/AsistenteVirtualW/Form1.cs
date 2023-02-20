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


namespace AsistenteVirtualW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine oEscucha = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-ES"));

        Boolean interruptor = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oEscucha.LoadGrammar(new DictationGrammar());
            oEscucha.SetInputToDefaultAudioDevice();
            //*nueva gramatica
            Choices lista = new Choices();
            lista.Add(new string[] { "contar chiste" , "apágate","cerrar"});
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(lista);
            Grammar g = new Grammar(gb);
            oEscucha.LoadGrammar(g);
            //fin de la nueva gramatica
            oEscucha.SpeechRecognized += Detection;
            oEscucha.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Detection(object sender, SpeechRecognizedEventArgs e)
        {


            PromptBuilder builder = new PromptBuilder();
            builder.StartVoice(VoiceGender.Male, VoiceAge.Adult);
            builder.AppendText("Hola me llamo cortana en que puedo ayudarte?");
            builder.EndVoice();
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak(builder);
            synthesizer.Dispose();

            if (e.Result.Text == "contar chiste")
            {
                PromptBuilder construir = new PromptBuilder();
                construir.StartVoice(VoiceGender.Male, VoiceAge.Adult);
                construir.AppendText("¿qué le dice un pato a otro pato?, Estamos empatados jaja ¿Puedo ayudarte nuevamente?");
                construir.EndVoice();
                SpeechSynthesizer sintetizar = new SpeechSynthesizer();
                sintetizar.Speak(construir);
                sintetizar.Dispose();

            }

            if (e.Result.Text == "apágate")
            {
                PromptBuilder construir = new PromptBuilder();
                construir.StartVoice(VoiceGender.Male, VoiceAge.Adult);
                construir.AppendText("No puedo apagarme! ¿Puedo ayudarte nuevamente?");
                construir.EndVoice();
                SpeechSynthesizer sintetizar = new SpeechSynthesizer();
                sintetizar.Speak(construir);
                sintetizar.Dispose();

            }

            if (e.Result.Text == "cerrar")
            {
                PromptBuilder construir = new PromptBuilder();
                construir.StartVoice(VoiceGender.Male, VoiceAge.Adult);
                construir.AppendText("Cerrando");
                construir.EndVoice();
                SpeechSynthesizer sintetizar = new SpeechSynthesizer();
                sintetizar.Speak(construir);
                sintetizar.Dispose();

                this.Close();

            }
            textBox1.Text = e.Result.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oEscucha.RecognizeAsyncStop();

        }
    }
    }
