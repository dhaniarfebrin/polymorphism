namespace LatihanPolymorphism
{
    class Epson : PrinterWindows
    {
        internal override void Show() {
            Console.WriteLine("Epson Display dimension : 10*12");
        }

        internal override void Print() {
            Console.WriteLine("Epson pirnter printing..");
        }
    }
}