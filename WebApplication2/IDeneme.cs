namespace WebApplication2
{
    public interface IDeneme
    {
        public bool sendMail(string content);
    }


    class Deneme : IDeneme
    {
        public bool sendMail(string content)
        {
            Console.WriteLine(content);
            return true;
        }
    }
}
