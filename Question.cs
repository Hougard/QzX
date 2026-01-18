using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QzX
{
    public class Question
    {
            public int No;
            public int Level;
            public string Type;
            public string Theme;
            public string Text;
            public string[] Answers;
            public string Hint;
            public int CorrectAnswer;
            public string CorrectAnswerTxt;
            public int Value;
            public bool Used;
            public string FilePath;

            public static Question Quest(List<Question> questions, string selectedTheme, int levelChoise)
            {
                //var filteredQuestion = questions.FirstOrDefault(q => q.Theme == selectedTheme && q.Level == levelChoise && q.Used != true);

                var temp = questions.Where(q => q.Theme == selectedTheme && q.Level == levelChoise && q.Used != true).ToList();

                if (temp.Count == 0)
                {
                    return null;
                }
                Random rnd = new Random();
                var filteredQuestion = temp[rnd.Next(temp.Count)];

                return filteredQuestion;
            }
            /// <summary>
            /// Возвращает массив уникальных тем из списка вопросов.
            /// </summary>
            public static string[] GetThemes(List<Question> questions)
            {

                return questions
            .Where(q => !q.Used)
            .Select(q => q.Theme)
            .Distinct()
            .ToArray();

            }

            public static void PrintSummary(List<Question> questions, string[] themes)
            {
                Console.WriteLine("{0,-5} {1,-15} {2,5} {3,5} {4,5}", "No", "Theme", "Easy", "Med", "Hard");

                var grouped = questions
            .Where(q => !q.Used)
            .GroupBy(q => q.Theme);
                int no = 1;
                foreach (var theme in themes)
                {
                    var g = grouped.FirstOrDefault(gr => gr.Key == theme);

                    int lvl1 = g?.Count(q => q.Level == 1) ?? 0;
                    int lvl2 = g?.Count(q => q.Level == 2) ?? 0;
                    int lvl3 = g?.Count(q => q.Level == 3) ?? 0;

                    Console.WriteLine("{0,-5} {1,-15} {2,5} {3,5} {4,5}", no, theme, lvl1, lvl2, lvl3);
                    no++;
                }

                Console.WriteLine();
            }

    }
}

