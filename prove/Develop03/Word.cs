using System.Formats.Asn1;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.XPath;

public class Word
//creates Word class
{
    private string _text;
    //creates private member variable _text


    public List<string> GetList()
    //takes the _text string variable and splits it into a list using each word as one element in the list
    {
        string splitter = " ";
        //sets the spaces between words to be used to split the words into elements
        List<string> splitScripture = _text.Split(splitter).ToList();
        //splits _text string into list and stores the list in variable splitScripture
        return splitScripture;
        //returns the list
    }


    public void HideWords()
    //looks at each word in the list and hides them randomly
    {
        int count = 0;
        List<string> firstList = new List<string> {};
        List<string> splitScripture = GetList();
        //gets the list from the GetList function and stores it in a variable 
        Random rnd = new Random();
        //creates new instance of Ramdom class to generate random numbers
        char underscore = '_';
        //sets variable to store the _ character to be used in place of letters in hidden words
        string result = "jack";
        //sets the initial value of the result variable to something meaningless
        

        while (count == 0)
        {
            foreach (string i in splitScripture)
            //loop to iterate through each word in the list of words derived from the given verse of scripture, randomly picks which words to hide, and then hides those words
            {
                int length = i.Length;
                //measures the length of each word in the list
                string listWord = i;
                //sets variable to store each word
                string wordReplace = new string(underscore, length);
                //sets variable for calling funtion to replace each letter in that word with an _
                int hideOrShow = rnd.Next(1,3);
                //generates reandom number between 1 and 2

                if (hideOrShow == 1)
                //checks if random number is 1
                {
                    listWord = wordReplace;
                    //replaces the chosen word with an equal number of _'s
                    result = $"{listWord} ";
                    //stores new _ version of the word in variable 
                    Console.Write(result);
                    firstList.Add(result);
                    count = count + 1;
                }

                else
                //checks if random number is 2
                {
                    result = $"{i} ";
                    //leaves the word as it is in the list and stores it in a variable
                    Console.Write(result);
                    firstList.Add(result);
                    count = count + 1;
                }
                
            }
        }

        Console.WriteLine("\n");
        Console.Write("Press the 'Enter' key to continue or type 'quit' to end.\n\nResponse: ");
        string userEntry = Console.ReadLine();

        List<string> secondList = new List<string> {};

        while (userEntry != "quit" && userEntry != "Quit")
        {

            
            if (count % 2 != 0)
            {
                Console.Clear();
                secondList.Clear();
                foreach (string i in firstList)
                //loop to iterate through each word in the list of words derived from the given verse of scripture, randomly picks which words to hide, and then hides those words
                {
                    int length = i.Length;
                    //measures the length of each word in the list
                    string listWord = i;
                    //sets variable to store each word
                    string wordReplace = new string(underscore, length);
                    //sets variable for calling funtion to replace each letter in that word with an _
                    int hideOrShow = rnd.Next(1,3);
                    //generates reandom number between 1 and 2

                    // string currentState = string('_', length);

                    if (hideOrShow == 1)
                    //checks if random number is 1
                    {

                        if (i == wordReplace)
                        {
                            result = $"{i} ";
                            //leaves the word as it is in the list and stores it in a variable
                            Console.Write(result);
                            secondList.Add(result);
                            count = count + 1;
                        }

                        else
                        {
                             listWord = wordReplace;
                            //replaces the chosen word with an equal number of _'s
                            result = $"{listWord} ";
                            //stores new _ version of the word in variable 
                            Console.Write(result);
                            secondList.Add(result);
                            count = count + 1;
                        }
                    }

                    else
                    //checks if random number is 2
                    {
                        result = $"{i} ";
                        //leaves the word as it is in the list and stores it in a variable
                        Console.Write(result);
                        secondList.Add(result);
                        count = count + 1;
                    }
                }
                Console.WriteLine("\n");
                Console.Write("Press the 'Enter' key to continue or type 'quit' to end.\n\nResponse: ");
                userEntry = Console.ReadLine();
            }


            else if (count % 2 == 0)
            {
                Console.Clear();
                firstList.Clear();
                foreach (string i in secondList)
                //loop to iterate through each word in the list of words derived from the given verse of scripture, randomly picks which words to hide, and then hides those words
                {
                    int length = i.Length;
                    //measures the length of each word in the list
                    string listWord = i;
                    //sets variable to store each word
                    string wordReplace = new string(underscore, length);
                    //sets variable for calling funtion to replace each letter in that word with an _
                    int hideOrShow = rnd.Next(1,3);
                    //generates reandom number between 1 and 2

                    if (hideOrShow == 1)
                    //checks if random number is 1
                    {

                        if (i == wordReplace)
                        {
                            result = $"{i} ";
                            //leaves the word as it is in the list and stores it in a variable
                            Console.Write(result);
                            firstList.Add(result);
                            count = count + 1;
                        }

                        else
                        {
                            listWord = wordReplace;
                            //replaces the chosen word with an equal number of _'s
                            result = $"{listWord} ";
                            //stores new _ version of the word in variable 
                            Console.Write(result);
                            firstList.Add(result);
                            count = count + 1;
                        }


                        
                    }

                    else
                    //checks if random number is 2
                    {
                        result = $"{i} ";
                        //leaves the word as it is in the list and stores it in a variable
                        Console.Write(result);
                        firstList.Add(result);
                        count = count + 1;
                    }
                    
                }
                Console.WriteLine("\n");
                Console.Write("Press the 'Enter' key to continue or type 'quit' to end.\n\nResponse: ");
                userEntry = Console.ReadLine();
            }

            // Console.WriteLine();
            // Console.Write("Press the 'Enter' key to continue or type 'quit' to end.\n\nResponse: ");
            // userEntry = Console.ReadLine();
        }
    }






    public void DisplayList()
    //function to display the list in sentence form
    {
        List<string> listDisplay = GetList();
        //sets variable to store the list

        foreach (string i in listDisplay)
        //loop to iterate through the list and display each element in sentence form
        {
            Console.Write($"{i} ");
            //displays each element
        }
    }


    public Word()
    //basic constructor sets every new instance of Word class to be a default text string. This can be changed later by the user if the user chooses to
    {
        _text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    }

}