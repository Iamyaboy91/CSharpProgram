﻿using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] currentStudentScores = new int[10];
string currentStudentLetterGrade = "";

Console.Clear();
Console.WriteLine("Student\t\tGrade\n");

foreach(string name in studentNames)
{
    string currentStudent = name;
    if(currentStudent == "Sophia")
        currentStudentScores = sophiaScores;
    else if(currentStudent == "Andrew")
        currentStudentScores = andrewScores;
    else if(currentStudent == "Emma")
        currentStudentScores = emmaScores;
    else if (currentStudent == "Logan")
        currentStudentScores = loganScores;
    else if (currentStudent == "Becky")
        currentStudentScores = beckyScores;
    else if (currentStudent == "Chris")
        currentStudentScores = chrisScores;
    else if (currentStudent == "Eric")
        currentStudentScores = ericScores;
    else if (currentStudent == "Gregor")
        currentStudentScores = gregorScores;
    else
        continue;
    int sumExamScores = 0;
    int gradedAssignments = 0;

    decimal currentStudentGrade = 0;

    foreach (int score in currentStudentScores)
    {
        gradedAssignments += 1;
        if(gradedAssignments <= currentAssignments)
        {
            sumExamScores = sumExamScores + score;
        }
        else
        {
            sumExamScores += score / 10;
        }

    }

    currentStudentGrade = (decimal)(sumExamScores)/currentAssignments;


    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
