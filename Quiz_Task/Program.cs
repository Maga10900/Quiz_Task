using System;

string[] questions = new string[10]
    {
        "1. 5+5",

        "2. 6+6",
        
        "3. 7+7",
        
        "4. 8+8",
        
        "5. 9+9",
        
        "6. 10+10",
        
        "7. 11+11",
        
        "8. 12+12",
        
        "9. 13+13",
        
        "10. 14+14"
    };
string[,] answers = new string[10, 4]
    {
        {"10","2","3","10"},

        {"234","12","88","12"},
        
        {"0","14","22","14"},
        
        {"12","-82","16","16"},
        
        {"18","532","83","18"},
        
        {"11","44","20","20"},
        
        {"30","22","55","22"},
        
        {"24","621","45","24"},
        
        {"26","51","17","26"},
        
        {"60","28","11","28"}
    };
int Score = 0;
int DuzSay = 0;
int SehvSay = 0;
int j = 0;

Console.Write("Enter Your Name: ");
string name = Console.ReadLine();
foreach (string i in questions)
{
    int select = 0;

    for (; j < answers.Length; j++)
    {
        do
        {
            Console.Clear();
            Console.WriteLine(i);
            int k = 0;
            for (; k < 3; k++)
            {
                bool ischeck = false;
                if (k == select)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answers[j, k]);
                    Console.ForegroundColor = ConsoleColor.White;
                    ischeck = true;
                }
                if (!ischeck)
                    Console.WriteLine(answers[j, k]);
            }

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.UpArrow)
            {
                if (select == 0) select = 2;
                else select--;
            }
            else if (info.Key == ConsoleKey.DownArrow)
            {
                if (select == 2) select = 0;
                else select++;
            }
            else if (info.Key == ConsoleKey.Enter)
            {
                if (answers[j, select] == answers[j, 3])
                {
                    Score += 10;
                    DuzSay++;
                }
                else
                {
                    if (Score != 0)
                        Score -= 10;
                    SehvSay++;
                }
                j++;
                break;

            }

        } while (true);
        break;
    }

}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Your Score: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(Score);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Duz: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(DuzSay);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Sehv: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(SehvSay);

