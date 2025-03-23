using modul6_103022330138;
class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Raffa Rizky Febryan");
        //SayaTubeVideo videoInvalid = new SayaTubeVideo("");
        //SayaTubeVideo videoInvalid1 = new SayaTubeVideo("Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean me");
        //video.IncreasePlayCount(10000001);
        
        for (int i = 0; i < 1000; i++)
        {
            video.IncreasePlayCount(2147484); 
        }

        video.PrintVideoDetails();
    }
}