internal partial class Program
{
    static string [] movies = {"abcdeg", "qwert", "qqqqqq"};
    const int PRICE = 30;
    const double vip_REDUCE = 0.1;
    private static void Main(string[] args)
    {
        // Hiển thị 1 menu cho người dùng chọn 3 bộ phim
        PrintMovies(movies);
        // Người dùng chọn phim
        string movie = GetMovie();
        // Người dùng chọn số lượng vé
        int nTickets = GetNumberTicket();
        // Người dùng chọn ghế
        string seats = GetSeats(nTickets);
        // Hỏi có phải VIP member không?
        bool vip = IsVIP();
        // Nếu là VIP member thì giảm giá 10%

        // In ra vé và hoá đơn
        PrintTicket(movie, nTickets, seats);
        PrintInvoice(nTickets, vip, PRICE);
        // quay lại menu lựa chọn phim
    }

    static void PrintMovies(string[] movies)
    {
        for (int i = 0; i < movies.Length; i++)
        {
            Console.WriteLine((i+1) + "." + movies[i]);
        }
    }

    static string GetMovie()
    {
        Console.Write("Your Movie: ");
        int choice = int.Parse(Console.ReadLine());
        return choice.ToString();  
    }

    static int GetNumberTicket()
    {
        Console.Write("How many tickets?");
        int nTickets = int.Parse(Console.ReadLine());
        return nTickets;
    }

    static string GetSeats(int nTickets)
    {
        string seats = "";
        //use for loop to repeat nTickets time , asking a seat then add to a string 
        //return that string
        for(int i = 0; i < nTickets; i++)
        {
            Console.Write("Choose your seat: ");
            string seat = Console.ReadLine();
            seats += seat + " ";
        }
        return seats;
    }

    static bool IsVIP()
    {
        Console.Write("are you a vip member ? (y/n): ");
        string answer = Console.ReadLine();
        return answer == "Y";
    }

    static void PrintTicket(string movie, int nTickets, string seats)
    {
        Console.WriteLine("Movie: " + movie);
        Console.WriteLine("Number of ticket: " + nTickets);
        Console.WriteLine("seats: " + seats);
    }

    static void PrintInvoice(int nTickets, bool vip, int PRICE)
    {
        double payment = nTickets * PRICE;
        if(vip) payment -= payment * vip_REDUCE;

        Console.WriteLine("Payment: " + payment);
    }
}