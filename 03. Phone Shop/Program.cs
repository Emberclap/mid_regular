namespace _03._Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phoneList = Console.ReadLine()
               .Split(", ")
               .ToList();
            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> command = input
                    .Split(" - ")
                    .ToList();

                string phone = command[1];
                switch (command[0])
                {
                    case "Add":
                       
                        if (!phoneList.Contains(phone))
                        {
                            phoneList.Add(phone);
                        }
                        break;
                    case "Remove":
                        if (phoneList.Contains(phone))
                        {
                            phoneList.Remove(phone);
                        }
                        break;
                    case "Last":
                        if (phoneList.Contains(phone))
                        {
                            phoneList.Add(phone);
                            phoneList.Remove(phone);
                        }
                        break;
                    case "Bonus phone":
                        List<string> bonusPhone = command[1]
                            .Split(":")
                            .ToList();
                        for (int i = 0; i < phoneList.Count; i++)
                        {
                            if (phoneList[i] == bonusPhone[0])
                            {
                                phoneList.Insert(i+1, bonusPhone[1]);
                            }
                        }
                        break;


                }
            }
            Console.WriteLine(string.Join(", ", phoneList));
        }
    }
}