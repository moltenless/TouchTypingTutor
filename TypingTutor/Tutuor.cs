using System;
using System.IO;
using System.Text;

namespace TypingTutor
{
    enum Language
    {
        English,
        Russian
    }
    class Tutor
    {
        private int CountSymbols { get; set; }
        private int countErrors;
        public int CountErrors
        {
            get => countErrors;
            set
            {
                countErrors = value;
                statistics.CountErrors++;
            }
        }
        public string[] RusWords = new string[] { "Привет", "Мир", "как", "анонимные методы", "Прокачай", "мышление", "контрвариантоность", "развитие", "полиморфизм", "лямбда", "инкапсуляция", "Значимость", "этих", "проблем", "настолько", "очевидна,", "что", "выбранный", "нами", "инновационный", "путь", "позволяет", "выполнить", "важнейшие", "задания", "по", "разработке", "направлений", "прогрессивного", "развития?", "Равным", "образом", "дальнейшее", "развитие", "различных", "форм", "деятельности", "требует", "от", "нас", "анализа", "существующих", "финансовых", "и", "административных", "условий.", "Задача", "организации,", "в", "особенности", "же", "начало", "повседневной", "работы", "по", "формированию", "позиции", "представляет", "собой", };
        public string[] EngWords = new string[] { "Hello", "world", "how", "You", "Keyboard", "nearly", "bad", "already", "Aply", "Will be", "other", "serverless", "Saw", "yet", "kindness", "too", "replying", "whatever", "marianne.", "Old", "sentiments", "resolution", "admiration", "unaffected", "its", "mrs", "literature.", "Behaviour", "new", "set", "existence", "dashwoods.", "It", "satisfied", "to", "mr", "commanded", "consisted", "disposing", "engrossed.", "Tall", "snug", "do", "of", "till", "on", "easy.", "Form", "not", "calm", "new", "fail.", };

        private Statistics statistics;
        private static Random random = new Random();

        public Tutor(int countSymbols)
        {
            statistics = new Statistics(countSymbols);
            CountSymbols = countSymbols;
        }

        public string GetMixText(Language lang)
        {
            string text = ""; // return it
            //getting symbols and words of different languages

            string[] words = new string[0];
            try
            {
                if (lang == Language.Russian)
                    words = File.ReadAllText("RussianText.txt", Encoding.Default).Split(new char[] { ' ', '�' }, StringSplitOptions.RemoveEmptyEntries);
                if (lang == Language.English)
                    words = File.ReadAllText("EnglishText.txt").Split(new char[] { ' ', '�' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length < 2) throw new Exception();
            }
            catch
            {
                if (lang == Language.Russian)
                    words = RusWords;
                else
                    words = EngWords;
            }


            while (text.Length < CountSymbols)
                text += words[random.Next(words.Length)] + " ";
            text = text.Remove(CountSymbols, text.Length - CountSymbols);
            return text;
        }

        public void Start()
        {
            statistics.Start();
        }

        public void Stop()
        {
            statistics.Stop();
        }
    }
}
