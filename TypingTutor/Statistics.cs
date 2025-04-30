using System;
using System.Windows.Forms;

namespace TypingTutor
{
    class Statistics
    {
        private Timer tmr;
        public int CountSymbols { get; set; }
        public int Seconds { get; set; }
        public int CountErrors { get; set; }

        public Statistics(int countSymb)
        {
            CountSymbols = countSymb;
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += Tmr_Elapsed;
        }

        public void Start()
        {
            Seconds = 0;
            CountErrors = 0;
            tmr.Start();
        }

        public void Stop()
        {
            tmr.Stop();
            double speed = (double)CountSymbols / (double)Seconds * 60;
            MessageBox.Show($"Typed: {CountSymbols} symbols \nTime elapsed: {Seconds} sec \nMistakes: {CountErrors} \nTouch Typing Speed: {speed.ToString("N2")} sec/min"); //GetStatistics
        }

        private void Tmr_Elapsed(object sender, EventArgs e)
        {
            Seconds++;
        }
    }
}
