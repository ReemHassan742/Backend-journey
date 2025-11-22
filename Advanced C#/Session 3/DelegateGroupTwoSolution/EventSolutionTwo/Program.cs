namespace EventSolutionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball(1);
            Ball ball2 = new Ball(2);
            Console.WriteLine($"{ball.Location}");

            Player p11 = new Player("P11", "Team1");
            Player p12 = new Player("P12", "Team1");
            Player p21 = new Player("P21", "Team2");
            Player p22 = new Player("P22", "Team2");

            Refree r11 = new Refree("R11");
            ball.OnBallChanged += p11.Run;
            ball.OnBallChanged += p12.Run;
            ball.OnBallChanged += r11.Look;
            ball2.OnBallChanged += p21.Run;
            ball2.OnBallChanged += p22.Run; //Subscribe
            ball2.OnBallChanged += r11.Look;

            ball.Location = new Location(10, 20, 30);
            ball2.Location = new Location(12, 14, 16);
            //Console.WriteLine($"{ball.Location}");

            //Console.WriteLine($"After firing P22");
            //ball.OnBallChanged -= p22.Run; //Unsubscibe
            //ball.Location = new Location(1, 2, 3);
        }

    }
}
