namespace Bonusundervisning_del_2
{
    static class App
    {
        public static void Run()
        {
            Console.WriteLine(Contacts.ShowList());
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Contacts.GetSpesificInfo(input));

        }
    }
}
