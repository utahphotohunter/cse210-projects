using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise> {};
//-----------------------------------------------------
        Running running1 = new Running();

        running1.SetDate("02 Nov 2022");
        running1.SetDistance(23625);
        running1.SetDuration(40);
        running1.SetMiles(running1.GetDistance(), 000, 0);
        running1.SetSpeed(running1.GetDuration(), running1.GetMiles());
        running1.SetPace(running1.GetDuration(), running1.GetMiles());

        exercises.Add(running1);
//-----------------------------------------------------
        Biking biking1 = new Biking();

        biking1.SetDate("12 June 2015");
        biking1.SetDuration(80);
        biking1.SetMiles(000, 23, 0);
        biking1.SetSpeed(biking1.GetDuration(), biking1.GetMiles());
        biking1.SetPace(biking1.GetDuration(), biking1.GetMiles());

        exercises.Add(biking1);
//-----------------------------------------------------
        Swimming swimming1 = new Swimming();

        swimming1.SetDate("31 Oct 2023");
        swimming1.SetDuration(17);
        swimming1.SetLaps(19);
        swimming1.SetMiles(0, 00, swimming1.GetLaps());
        swimming1.SetSpeed(swimming1.GetDuration(), swimming1.GetMiles());
        swimming1.SetPace(swimming1.GetDuration(), swimming1.GetMiles());

        exercises.Add(swimming1);
//-----------------------------------------------------
        foreach (Exercise i in exercises)
        {
            Console.WriteLine();
            Console.WriteLine(i.GetSummary(i.GetDate(), i.GetDuration(), i.GetMiles(), i.GetSpeed(), i.GetPace(), i.GetExerciseType()));
            Console.WriteLine();
        }


        
    
    
    }
}