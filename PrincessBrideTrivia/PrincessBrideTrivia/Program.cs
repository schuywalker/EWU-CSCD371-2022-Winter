﻿using System;
using System.IO;
using System.Linq;


// comment just to test commit/push

// 2nd comment

// 3rd attempt in class thursday
namespace PrincessBrideTrivia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = GetFilePath();
            Question[] questions = LoadQuestions(filePath);
            
            Question[] questionsRnd = RandomizeQuestions(questions);
            
            int numberCorrect = 0;
            
            
            
            
            // randomized ( questions updated to be questionsRnd )
            for (int i = 0; i < questionsRnd.Length; i++)
            {
                bool result = AskQuestion(questionsRnd[i]);
                if (result)
                {
                    numberCorrect++;
                }
            }
            Console.WriteLine("You got " + GetPercentCorrect(numberCorrect, questionsRnd.Length) + " correct");
            
        }

        public static string GetPercentCorrect(int numberCorrectAnswers, int numberOfQuestions)
        {
            double ret = (((double)numberCorrectAnswers / (double)numberOfQuestions) * 100);
            
            if (ret == 0.0)
            {
                return "0%";
            }
            
            return ret.ToString("#.##") + "%";
        }

        public static bool AskQuestion(Question question)
        {
            DisplayQuestion(question);

            string userGuess = GetGuessFromUser();
            return DisplayResult(userGuess, question);
        }

        public static string GetGuessFromUser()
        {
            return Console.ReadLine();
        }

        public static bool DisplayResult(string userGuess, Question question)
        {
            if (userGuess == question.CorrectAnswerIndex)
            {
                Console.WriteLine("Correct");
                return true;
            }

            Console.WriteLine("Incorrect");
            return false;
        }

        public static void DisplayQuestion(Question question)
        {
            Console.WriteLine("Question: " + question.Text);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.WriteLine((i + 1) + ": " + question.Answers[i]);
            }
        }

        public static string GetFilePath()
        {
            return "Trivia.txt";
        }

        public static Question[] LoadQuestions(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            Question[] questions = new Question[lines.Length / 5];
            for (int i = 0; i < questions.Length; i++)
            {
                int lineIndex = i * 5;
                string questionText = lines[lineIndex];

                string answer1 = lines[lineIndex + 1];
                string answer2 = lines[lineIndex + 2];
                string answer3 = lines[lineIndex + 3];

                string correctAnswerIndex = lines[lineIndex + 4];

                Question question = new();
                question.Text = questionText;
                question.Answers = new string[3];
                question.Answers[0] = answer1;
                question.Answers[1] = answer2;
                question.Answers[2] = answer3;
                question.CorrectAnswerIndex = correctAnswerIndex;

                questions[i] = question;
            }
            return questions;
        }
        
        public static Question[] RandomizeQuestions(Question[] questions)
        {
           
            Random randomizer = new();
            Question[] questionsRnd = questions.OrderBy(q => randomizer.Next()).ToArray();
            
            return questionsRnd;
        }
        
    }
}
