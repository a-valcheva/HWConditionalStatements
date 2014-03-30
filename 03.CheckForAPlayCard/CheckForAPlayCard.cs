using System;

class CheckForAPlayCard
{
    //Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write 
    //a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
    static void Main(string[] args)
    {
        string card = Console.ReadLine();
        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        bool isCard = false;
        for (int i = 0; i < cards.Length; i++)
        {
            isCard = card == cards[i];
            if (isCard)
            {
                Console.WriteLine("yes");
                break;
            }
        }
        if (!isCard)
        {
            Console.WriteLine("no");
        }
    }
}

