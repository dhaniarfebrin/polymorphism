namespace LatihanPolymorphism
{
    class Canon : PrinterWindows
    {
        internal override void Show() {
            Console.WriteLine("Canon Display dimension : 9.5*12");
        }

        internal override void Print() {
            Console.WriteLine("Canon pirnter printing..");
        }
    }
}