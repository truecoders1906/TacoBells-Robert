namespace LoggingKata
{
    public struct Point
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Point GetPoint(double Latitude, double Longitude)
        {
            return this;
        }
    }
}