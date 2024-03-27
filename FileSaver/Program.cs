using FileSaver.Strategy;

namespace FileSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileSaverContext = new FileSaverContext();

            fileSaverContext.SetStrategy(new TxtFileSavingStrategy());
            fileSaverContext.SaveFile("TXT File", "The fallen leaves tell a story. Of how a Tarnished became Elden Lord.");

            fileSaverContext.SetStrategy(new DocFileSavingStrategy());
            fileSaverContext.SaveFile("DOC File", "Lord of Frenzied Flame, I will seek you as far as you may travel. To deliver you what is yours. Destined death.");

            fileSaverContext.SetStrategy(new RtfFileSavingStrategy());
            fileSaverContext.SaveFile("RTF File", "Foul Tarnished, in search of the Elden Ring. Emboldened by the Flame of Ambition. Someone must extinguish thy flame.");
        }
    }
}
