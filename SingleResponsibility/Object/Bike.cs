namespace SingleResponsibility.Object
{
    public class Bike
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Price { get; set; }

        public Bike(string name, int maxSpeed, int price)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Price = price;
        }
    }
}
