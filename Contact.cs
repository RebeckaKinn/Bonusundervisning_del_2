namespace Bonusundervisning_del_2
{
    internal class Contact
    {
        public string Name { get; private set; }
        private int _phoneNumber;

        public Contact(string name, int phoneNumber)
        {
            Name = name;
            _phoneNumber = phoneNumber;
        }

        public string GetInfo()
        {
            return $"\n{Name} - {_phoneNumber}\n";
        }
    }
}
