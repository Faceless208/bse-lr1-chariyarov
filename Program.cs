using System;
using System.Collections.Generic;

namespace EmpathixProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Empathix: Система аналізу емоцій ===");
            
            // Створюємо екземпляр сервісу
            var analyzer = new EmotionAnalyzer();
            
            Console.Write("Введіть текст для аналізу: ");
            string userInput = Console.ReadLine();

            // Виклик методу аналізу
            string result = analyzer.AnalyzeText(userInput);

            Console.WriteLine($"\nРезультат аналізу: {result}");
            Console.WriteLine("Дякуємо за використання Empathix!");
        }
    }

    public class EmotionAnalyzer
    {
        public string AnalyzeText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "Текст порожній. Неможливо визначити емоцію.";

            // Базова логіка (placeholder для майбутньої інтеграції з AI)
            text = text.ToLower();
            
            if (text.Contains("радий") || text.Contains("добре") || text.Contains("супер"))
                return "Емоційний фон: Позитивний 😊";
            
            if (text.Contains("сумно") || text.Contains("погано") || text.Contains("жах"))
                return "Емоційний фон: Негативний 😔";

            return "Емоційний фон: Нейтральний 😐";
        }
    }
}