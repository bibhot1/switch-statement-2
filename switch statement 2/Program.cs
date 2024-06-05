// making a quiz app

// in order to first do it we need to have couple of questions and declare them as a string so does the answer.

string question1 = "What is the capital of newzealand?";
string answer1 = "wellington";
string question2 = "Whst is the best city in the world?";
string answer2 = "bhairahawa";
string question3 = "What is your favourite color";
string answer3 = "blue";

//Now as the questions and answers are dont we gonna declare a score integer and set it upto zero.

int score = 0;

//now we gonna use if and else statement to ask the user a questions and set the score accordingly.

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();    

if (userAnswer1 == answer1)
{
    Console.WriteLine("Its a correct answer");
    score = score +1;
}
else
{
    Console.WriteLine("wrong answer");
}
Console.WriteLine(question2);
string  userAnswer2 = Console.ReadLine();

if (userAnswer2 == answer2)
{
    Console.WriteLine("correct answer"); score = score +1;
}
else
{
    Console.WriteLine("Wrong answer");

}
Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();    
if(userAnswer3 == answer3)
{
    Console.WriteLine("correct answer");
    score = score +1;
}
else
{
    Console.WriteLine("Wrong answer");
}
Console.WriteLine("Your total acore is " + score);