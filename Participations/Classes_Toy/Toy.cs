namespace Classes_Toy
{
    public class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes { get; set; }

        public Toy(string Manufacturer, string Name, double Price, string Notes)
        {
            manufacturer = Manufacturer;
            name = Name;
            price = Price;
            notes = Notes;
        }

        public Toy(double Price)
        {
            price = Price;
        }

        public Toy(string Notes)
        {
            notes = Notes;
        }

        public Toy()
        {
            manufacturer = string.Empty;
            name = string.Empty;
            price = 0;
            notes = "EXAMPLE";
        }

        public string GetAisle()
        {
            // RETURN FIRST LETTER OF MANUFACTURER
            manufacturer = Manufacturer;
            string ManuFirstLetter = Manufacturer;
            // do not know what to do after this
        }
    }
}