using NAudio.Wave;
using System.Runtime.InteropServices;

namespace Lab_1_Numbers
{
    class Program
    {
        public static List<string> lecksems = new List<string>(){ "мо", "ро", "зи", "во", "ма",
            "три", "га", "зин", "ва", "вун", "де", "ре", "на", "ка" };
        static void Main(string[] args)
        {
            //ParseNPlaySlo("морозиво");

            //ParseNPlaySlo("зима");

            //ParseNPlaySlo("тривога");

            //ParseNPlaySlo("магазин");

            //ParseNPlaySlo("мова");

            //ParseNPlaySlo("кава");

            //ParseNPlaySlo("кавун");

            //ParseNPlaySlo("дерево");

            //ParseNPlaySlo("резина");

            //PlayMP3("мо");
            //PlayMP3("ро");
            //PlayMP3("зи");
            //PlayMP3("во");
        }

        public static void ParseNPlaySlo(string slovo)
        {
            string n = null;
            foreach (var i in slovo)
            {
                n += i;
                if (lecksems.Contains(n))
                {
                    PlayMP3(n);
                    n = null;
                }
            }
        }

        public static void PlayMP3(string name)
        {
            AudioFileReader audioFile = new($"F:/4-й курс/RPZ/RPZ_lab_2_textspeech/Sounds/mp3/{name}.mp3");
            WaveOutEvent outputDevice = new();

            outputDevice.Init(audioFile);
            outputDevice.Play();

            while (outputDevice.PlaybackState == PlaybackState.Playing)
                continue;
        }
    }
}
