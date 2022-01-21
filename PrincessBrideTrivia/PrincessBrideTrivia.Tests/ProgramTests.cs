using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;



namespace PrincessBrideTrivia.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void LoadQuestions_RetrievesQuestionsFromFile()
    {
        string filePath = Path.GetRandomFileName();
        try
        {
            // Arrange
            GenerateQuestionsFile(filePath, 2);

            // Act
            Question[] questions = Program.LoadQuestions(filePath);

            // Assert 
            Assert.AreEqual(2, questions.Length);
        }
        finally
        {
            File.Delete(filePath);
        }
    }

    [TestMethod]
    [DataRow("1", true)]
    [DataRow("2", false)]
    public void DisplayResult_ReturnsTrueIfCorrect(string userGuess, bool expectedResult)
    {
        // Arrange
        Question question = new Question();
        question.CorrectAnswerIndex = "1";

        // Act
        bool displayResult = Program.DisplayResult(userGuess, question);

        // Assert
        Assert.AreEqual(expectedResult, displayResult);
    }

    [TestMethod]
    public void GetFilePath_ReturnsFileThatExists()
    {
        // Arrange

        // Act
        string filePath = Program.GetFilePath();

        // Assert
        Assert.IsTrue(File.Exists(filePath));
    }

    [TestMethod]
    [DataRow(1, 1, "100%")]
    [DataRow(5, 10, "50%")]
    [DataRow(1, 10, "10%")]
    [DataRow(0, 10, "0%")]

    public void GetPercentCorrect_ReturnsExpectedPercentage(int numberOfCorrectGuesses,
        int numberOfQuestions, string expectedString)
    {
        // Arrange

        // Act
        string percentage = Program.GetPercentCorrect(numberOfCorrectGuesses, numberOfQuestions);

        // Assert
        Assert.AreEqual(expectedString, percentage);
    }

    [TestMethod]
    private static void GenerateQuestionsFile(string filePath, int numberOfQuestions)
    {
        for (int i = 0; i < numberOfQuestions; i++)
        {
            string[] lines = new string[5];
            lines[0] = "Question " + i + " this is the question text";
            lines[1] = "Answer 1";
            lines[2] = "Answer 2";
            lines[3] = "Answer 3";
            lines[4] = "2";
            File.AppendAllLines(filePath, lines);
        }
    }

    
    [TestMethod]
    public void RandomizeQuestions_ReturnsTrueIfArrayHasBeenChanged()
    {
        
       // Arrange
       string filePath = Program.GetFilePath();
       Question[] qOriginal = Program.LoadQuestions(filePath);
       Question[] qRandom = Program.RandomizeQuestions(qOriginal);
       
        bool different = false;
        
        // Act
        for (int i = 0; i < qOriginal.Length; i++)
        {
            if (qOriginal[i] != qRandom[i]) // 1/(7!) chance they are the same if Randomize method is succesful
            {
                different = true;
            }
        }

        if (different == false) // 2nd attempt in case 1/(7!) chance occurred
        {
            Question[] qR2 = Program.RandomizeQuestions(qOriginal);


            for (int i = 0; i < qOriginal.Length; i++)
            {
                if (qOriginal[i] != qR2[i])
                {
                    different = true;
                }
            }
            if (different == false) // 3rd attempt
            {

                Question[] qR3 = Program.RandomizeQuestions(qRandom);

                for (int i = 0; i < qOriginal.Length; i++)
                {
                    if (qRandom[i] != qR3[i])
                    {
                        different = true;
                    }
                }

            }

        }
        
        // Assert
        Assert.IsTrue(different);

    }

}

