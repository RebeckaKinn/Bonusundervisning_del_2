namespace Bonusundervisning_del_2
{
    internal class Contacts
    {
        public static List<Contact> contactsList = new List<Contact>
        {
            new("Mille", 25625556),
            new("Per Ole", 564546545),
            new("Bestevenn", 54454544)
        };

        public static string ShowList()
        {
            string text = "";
            foreach (Contact c in contactsList)
            {
                text += $" - {c.Name}\n";
            }
            return text;
        }

        public static string GetSpesificInfo(int index)
        {
            return contactsList[index].GetInfo();
        }
    }
}