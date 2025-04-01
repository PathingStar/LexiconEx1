using static övning_1.Program;

namespace övning_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Anstäld> anstälda = new List<Anstäld>();
            Console.WriteLine("skriv in\"förnamn mellannamn(friviligt) efternamn lön\" för att lagatill e}]n anstäld i tabelen");
            while (true)
            {
                
                try
                {
                    string[] input = Console.ReadLine().Split(" ");
                    if (input.Length < 2) break;
                    if(input.Length>3) anstälda.Add(new Anstäld(input[0], input[1],input[2], float.Parse(input[3]))); 
                    else anstälda.Add(new Anstäld(input[0], input[1], float.Parse(input[2])));
                    foreach (Anstäld a in anstälda)
                    {
                        Console.WriteLine("namn: " + a.förNamn + " " +( (a.mellanNamn!="")? a.mellanNamn + " ":"" )+ a.efterNamn + " lön: " + a.lön.ToString("n"));
                    }
                }
                catch  { Console.WriteLine("fell inmatning"); }
            }
        }

        
    }
    public class Anstäld
    {
        public string förNamn;
        public string mellanNamn="";
        public string efterNamn;
        public float lön;
        public Anstäld(string fNamn,string eNamn, float l)
        {
            förNamn = fNamn;
            efterNamn = eNamn;
            lön = l;
        } public Anstäld(string fNamn,string mNamn, string eNamn, float l)
        {
            förNamn = fNamn;
            mellanNamn = mNamn;
            efterNamn = eNamn;
            lön = l;
        }
    }
}
