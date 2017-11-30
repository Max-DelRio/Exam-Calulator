// *****************************************************************************
// *                                    CS3                                    *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Max Del Rio                                               *
// *  Chapter      : CS3                                                       *
// *  Assignment   : EXAM#1                                                    *
// *  Class Name   : CS3                                                       *
// *  Date Created : 9/22/2016                                                 *
// *  Description  : This class calculates the Total number of questions       *
// *                 answered and the Percentage correct.                      *
// *                                                                           *
// *****************************************************************************

// Use System Namespace
using System;

// Begin CS3 Class
class CS3_Exam
{


    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : The operator is prompted to enter the number of       *
    // *                 Correct and Incorrect answers from the keyboard. The  *
    // *                 program will then display the Total and Percentage    *
    // *                 correct.                                              *
    // *************************************************************************

    // Begin Main ()
    static void Main()
    {
        // Define Variables: Correct Answers, Incorrect Answers, Total Questions, Percentage Correct
        int correctAnswersInt, incorrectAnswersInt, totalQuestionsInt;
        decimal percentageCorrectDecimal;

        // Display Title
        Console.WriteLine("Calculate Quiz Total and Percentage");

        // Display Blank Line
        Console.WriteLine();

        // Display Correct Answers Prompt
        Console.Write("Number of Correct Answers    : ");

        // Input Correct Answers
        correctAnswersInt = int.Parse(Console.ReadLine());

        // Display Incorrect Answers Prompt
        Console.Write("Number of Incorrect Answers  : ");

        // Input Incorrect Answers
        incorrectAnswersInt = int.Parse(Console.ReadLine());

        // Calculate Total Questions = Correct Answers + Incorrect Answers
        totalQuestionsInt = correctAnswersInt + incorrectAnswersInt;

        // Calculate Percentage Correct = Correct Answers / Total Questions
        percentageCorrectDecimal = (decimal)correctAnswersInt / totalQuestionsInt;

        // Display Blank Line
        Console.WriteLine();
        // Display Total Questions
        Console.WriteLine("You answered a Total of " + totalQuestionsInt + " questions");

        // Display Percentage Correct
        Console.WriteLine(" Your Percentage Correct is " + percentageCorrectDecimal.ToString("P1"));

        // Display Blank Line
        Console.WriteLine();

        // Display Press any key Prompt
        Console.Write("Press any key to continue . . . ");

        // Input Press Any Key
        Console.ReadKey();

    }// End Main


}// End CS3 Class

