<<<<<<< HEAD
﻿Console.WriteLine("Enter a sentence"); 
string uPrompt = Console.ReadLine(); 

// split string at " " aka at a space to give desired result
string[] lBl = uPrompt.Split(" "); //lBl == line by line, this will split user sentece line by line, as defined by each space btween word

    foreach (string word in lBl) //word is basically word by word
    {
    Console.WriteLine(word);
    }

//second part of lab
//Console.WriteLine("Enter some text");
List<string> joinWord = new List<string>(); //list works as an array in that it splits line by line
string uP2 = "y";

while (uP2 == "y")
{
    Console.WriteLine("Enter some text");
    string uP0 = Console.ReadLine(); //second user prompt
    joinWord.Add(uP0);

    Console.WriteLine($"You have entered {uP0}");
    Console.WriteLine($"Continue? y/n");
 
    string uP1 = Console.ReadLine();
    string together = string.Join(" ", joinWord);
    Console.WriteLine(together);
   
}

=======
﻿Console.WriteLine("Enter a sentence"); 
string uPrompt = Console.ReadLine(); 

// split string at " " aka at a space to give desired result
string[] lBl = uPrompt.Split(" "); //lBl == line by line, this will split user sentece line by line, as defined by each space btween word

    foreach (string word in lBl) //word is basically word by word
    {
    Console.WriteLine(word);
    }

//second part of lab
//Console.WriteLine("Enter some text");
List<string> joinWord = new List<string>(); //list works as an array in that it splits line by line
string uP2 = "y";

while (uP2 == "y")
{
    Console.WriteLine("Enter some text");
    string uP0 = Console.ReadLine(); //second user prompt
    joinWord.Add(uP0);

    Console.WriteLine($"You have entered {uP0}");
    Console.WriteLine($"Continue? y/n");
 
    string uP1 = Console.ReadLine();
    string together = string.Join(" ", joinWord);
    Console.WriteLine(together);
   
}

>>>>>>> 8db6c8002cf5989b1d9317496f33982cfca5989e
