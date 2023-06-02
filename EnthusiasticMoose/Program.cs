
Main();
AskMoose();


void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    MooseSays("I have a few questions for you");
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();

   // Let the moose speak!
    MooseSays("Now it's my turn to enthusiastically answer your questions!");
 };

void AskMoose()
    {
        Console.Write("Ask me your YES or NO question!");
        string question = Console.ReadLine();
   
   List<string> answers = new List<string>() 
         {
"As I see it, yes.", "Ask again later.", "Better not tell you now.","Cannot predict now.","Concentrate and ask again.", "Don’t count on it.", "It is certain.", "It is decidedly so.", "Most likely.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Outlook good.", "Reply hazy, try again.", "Signs point to yes.", "Very doubtful.", "Without a doubt.", "Yes.", "no", "Yes – definitely."
};
 
    Random r = new Random();
 MooseSays(answers[r.Next(0, answers.Count)]);;

    }; 


    
//refactored for less redundancy 
void AskQuestion(string question, string yes, string no) 
{
    bool isTrue = MooseAsks(question); 
    if (isTrue)
    {
        MooseSays(yes);
    }
    else
    {
        MooseSays(no);
    }
}

void CanadaQuestion()
{
    AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I KNEW IT !!!");
}

void EnthusiasticQuestion()
{
    AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
}

void LoveCSharpQuestion() 
{ 
    AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
}

void SecretQuestion() {
    AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}


bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): "); // $ allows the calling of the question
    string answer = Console.ReadLine().ToLower(); // .ToLower() eliminates case sensitivity


    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

//message
void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |     {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
  
}
