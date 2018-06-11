using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcc
{
    public partial class Form1 : Form
    {
        string sp;
        string ps;
     
        SpeechRecognitionEngine gf = new SpeechRecognitionEngine();
        SpeechRecognitionEngine gff = new SpeechRecognitionEngine();
        Choices fg = new Choices(); Choices fgg = new Choices();
        System.Speech.Synthesis.SpeechSynthesizer say = new System.Speech.Synthesis.SpeechSynthesizer(); 
        public Form1()
        {
            int i = -999;
                int ii = 1;
            InitializeComponent();
            for (; ii < 999; ii++)
            {
                fg.Add(i.ToString());
            }
            for (; i <1; i++)
            {
                fgg.Add(i.ToString());
            }
            GrammarBuilder lj = new GrammarBuilder(fg);
            Grammar li = new Grammar(lj);
            GrammarBuilder ljk = new GrammarBuilder(fgg);
            Grammar lik = new Grammar(ljk);

            gff.InitialSilenceTimeout = TimeSpan.FromSeconds(12.0);
            gff.BabbleTimeout = TimeSpan.FromSeconds(6.0);
            gff.EndSilenceTimeout = TimeSpan.FromSeconds(3.0);
            gff.EndSilenceTimeoutAmbiguous = TimeSpan.FromSeconds(2.0);
            gf.InitialSilenceTimeout = TimeSpan.FromSeconds(12.0);
            gf.BabbleTimeout = TimeSpan.FromSeconds(6.0);
            gf.EndSilenceTimeout = TimeSpan.FromSeconds(3.0);
            gf.EndSilenceTimeoutAmbiguous = TimeSpan.FromSeconds(2.0);



            gf.LoadGrammar(li);
            gff.LoadGrammar(lik);
            gf.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reco);
            gff.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recoh);
            gf.SetInputToDefaultAudioDevice();
            gf.RecognizeAsync(RecognizeMode.Multiple);

            gff.SetInputToDefaultAudioDevice();
            gff.RecognizeAsync(RecognizeMode.Multiple);


        }

        private void recoh(object sender, SpeechRecognizedEventArgs e)
        {
          
            sp = e.Result.Text;
            label1.Text = sp;
        }

        private void reco(object sender, SpeechRecognizedEventArgs e)
        {
           

            ps = e.Result.Text;
            label2.Text = ps;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            say.Speak("datestver comptable open");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (label1.Text != "label1"&& label2.Text != "label2")
            {

                try
                {
                    int hf = int.Parse(label1.Text);


                    int fh = int.Parse(label2.Text);
                    int yf = hf + fh;
                    this.Text = yf.ToString();
                }
                catch { }
            }        
        
        }
    }
}
