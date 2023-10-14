
using static System.Formats.Asn1.AsnWriter;

Console.Write("What is Your Name: ");
string studentName = Console.ReadLine();

//Declaring Arrays to hold the student inputszxcvb
string[] firstCourse = new string[3]; //{ "maths", "maths", "biology" };
int[] studentScores  = new int[3];
int[] creditUnit = new int[3];


//creating the for loop to loop through the elements of the array

    for (int i = 0; i < firstCourse.Length; i++)
    {
        Console.Write($"What is your number{i + 1} course: ");
        firstCourse[i] = (Console.ReadLine());
    }

    for (int i = 0; i < studentScores.Length; i++)
    {
        Console.Write($"Your {firstCourse[i]} score is: ");
        studentScores[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < creditUnit.Length; i++)
    {
        Console.Write($"Your {firstCourse[i]} credit unit{i + 1} is: ");
        creditUnit[i] = Convert.ToInt32(Console.ReadLine());
    }

Console.WriteLine($"A Cumulative CGPA for {studentName}");
Console.WriteLine("Courses\t\tCreditUnit\tAvgScores\tGrade\t GradeUnit");

    
//Declaring and Initializing variables for the conditional construct
    
    int gradeUnit = 0;
    
    string letterGrade = " ";

    if (studentScores[0] >= 70)
    {
        letterGrade = "A";
        gradeUnit = 4;
    }
    else if ((studentScores[0] <= 69) && (studentScores[0] >= 60))
    {
        letterGrade = "B";
        gradeUnit = 3;
    }
    else if ((studentScores[0] <= 59) && (studentScores[0] >= 50))
    {
        letterGrade = "C";
        gradeUnit = 2;
    }
    else
    {
        letterGrade = "F";
        gradeUnit = 1;
    }
    double totalUnit0 = creditUnit[0] * gradeUnit;
    Console.WriteLine($"{firstCourse[0]}\t\t{creditUnit[0]}\t\t{studentScores[0]}\t\t{letterGrade}\t\t{gradeUnit}");


    if (studentScores[1] >= 70)
    {
        letterGrade = "A";
        gradeUnit = 4;
    }
    else if ((studentScores[1] <= 69) && (studentScores[1] >= 60))
    {
        letterGrade = "B";
        gradeUnit = 3;
    }
    else if ((studentScores[1] <= 59) && (studentScores[1] >= 50))
    {
        letterGrade = "C";
        gradeUnit = 2;
    }
    else
    {
        letterGrade = "F";
        gradeUnit = 1;
    }
    double totalUnit1 = creditUnit[1] * gradeUnit;
    Console.WriteLine($"{firstCourse[1]}\t\t{creditUnit[1]}\t\t{studentScores[1]}\t\t{letterGrade}\t\t{gradeUnit}");


    if (studentScores[2] >= 70)
    {
        letterGrade = "A";
        gradeUnit = 4;
    }
    else if ((studentScores[2] <= 69) && (studentScores[2] >= 60))
    {
        letterGrade = "B";
        gradeUnit = 3;
    }
    else if ((studentScores[2] <= 59) && (studentScores[2] >= 50))
    {
        letterGrade = "C";
        gradeUnit = 2;
    }
    else
    {
        letterGrade = "F";
        gradeUnit = 1;
    }
    double totalUnit2 = creditUnit[2] * gradeUnit;
    Console.WriteLine($"{firstCourse[2]}\t\t{creditUnit[2]}\t\t{studentScores[2]}\t\t{letterGrade}\t\t{gradeUnit}");


    int totalCredit = creditUnit[0] + creditUnit[1] + creditUnit[2];
    double totalUnit = totalUnit0 + totalUnit1 + totalUnit2;

    double cgpa =  totalUnit / totalCredit;

    Console.WriteLine($"Total Credit = {totalCredit}");
    Console.WriteLine($"Total Unit = {totalUnit}");
    Console.WriteLine($"Total {studentName} CGPA = {cgpa}");


//Console.WriteLine($"{studentScores[0]}\n{studentScores[1]}\n{studentScores[2]} {gradeUnit}");
