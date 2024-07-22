namespace _2D_Array_Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged array (array of arrays)
            string[] studentsFNames = {"John", "Sue", "Mark", "Jason"};
            string[] studentsLNames = { "Wick", "Abbot", "Shuttleworth", "Derulo" };
            string[][] studentsFullNames = {studentsFNames, studentsLNames};

            //2D array
            int[,] results = { { 81, 76, 84 }, { 72, 75, 70 }, { 50, 55, 52 }, { 30, 35, 42 } };

            //1D array
            int[] averages = { 0, 0, 0, 0 };
            string[] subjects = { "Maths", "IT", "English" };

            //loops through 4 records (All student names/lastnames)
            for (int c = 0; c < studentsFNames.Length; c++)
            {
                int temp = 0;
                //write student name
                Console.WriteLine("______________________________");
                Console.WriteLine(studentsFullNames[0][c] + " " + studentsFullNames[1][c] + " : ");
                Console.WriteLine("------------------------------");
                //loops through 3 records (3 results per student)
                for (int c2 = 0; c2 < subjects.Length; c2++)
                {
                    //writes each results on new line
                    Console.WriteLine(subjects[c2] + "\t: " + results[c, c2]);
                    //adds results together for average calculation
                    temp += results[c, c2];
                }
                //calculates average
                temp = temp / subjects.Length;
                //adds result to new array
                averages[c] = temp;
                //displays average at the end
                Console.WriteLine();
                Console.WriteLine("Average : " + averages[c]);
                Console.WriteLine("==============================");
            }
        }
    }
}
