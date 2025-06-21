using System.IO.Pipes;

namespace ConsoleApp1.Lists
{
    class PhoneBook
    {
        private Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

        public void AddPhoneNumber(string name, string phoneNumber)
        {
            if (phoneNumbers.ContainsKey(name))
            {
                phoneNumbers[name] = phoneNumber;
            }
            else
            {
                phoneNumbers.Add(name, phoneNumber);
            }
        }

        public void RemovePhoneNumber(string name)
        {
            phoneNumbers.Remove(name);
        }

        public string FindNumber(string name)
        {

            if (phoneNumbers.ContainsKey(name))
            {
                return phoneNumbers[name];
            }
            else
            {
                return "Not found!";
            }
        }
    }
}
