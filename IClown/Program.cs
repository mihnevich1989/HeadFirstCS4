namespace IClown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.CarDescription());

            IClown fingersTheClown = new ScaryScary("Big red noise", 14);
            fingersTheClown.Honk();

            //вариант 1 с понижающим приведением типа, безопасное
            if (fingersTheClown is IScaryClown iScareClownReference)
            {
                iScareClownReference.ScareAdults();
            }

            //вариант 2 с понижающим приведением типа не безопасное
            /*IScaryClown iScareClownReference = (IScaryClown)fingersTheClown;
            iScareClownReference.ScareLittleChildren();*/
        }
    }
}