namespace P05___PhoneContacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phonebook=new Dictionary<string, string>();

            while (true)
            {
                var cmd=Console.ReadLine().Split(' ').ToList();

                if (cmd[0]=="END")
                {
                    break;
                }                               

                if (cmd[0] == "A")
                {
                    var name = cmd[1];
                    var phoneNumber = cmd[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phoneNumber;
                    }
                    else
                    {
                        phonebook.Add(name, phoneNumber);
                    }
                }

                if (cmd[0] == "S")
                {
                    var name=cmd[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist!");
                    }
                }

                if(cmd[0] == "All")
                {
                    foreach (var phone in phonebook)
                    {
                        Console.WriteLine($"{phone.Key} => {phone.Value}");
                    }
                }
            }
        }
    }
}
