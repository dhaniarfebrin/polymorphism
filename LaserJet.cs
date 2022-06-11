namespace LatihanPolymorphism
{
    class LaserJet : PrinterWindows
    {
        internal override void Show() {
            Console.WriteLine("LaserJet Display dimension : 12*12");
        }

        internal override void Print() {
            Console.WriteLine("LaserJet pirnter printing..");
        }
    }
}