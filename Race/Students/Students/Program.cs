using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
    private static List<Student> students = new List<Student>();
        private static string dataFile = "students.csv";

        static void Main(string[] args)
        {
            LoadStudentsFromFile();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== СИСТЕМА УПРАВЛЕНИЯ СТУДЕНТАМИ ===");
                Console.WriteLine("1. Показать всех студентов");
                Console.WriteLine("2. Редактировать студента по номеру");
                Console.WriteLine("3. Выйти");
                Console.Write("Выберите действие: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowAllStudents();
                        break;
                    case "2":
                        EditStudentByNumber();
                        break;
                    case "3":
                        SaveStudentsToFile();
                        Console.WriteLine("Данные сохранены. Выход из программы.");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void LoadStudentsFromFile()
        {
            try
            {
                if (!File.Exists(dataFile))
                {
                    // Создаем демонстрационные данные, если файл не существует
                    CreateSampleData();
                    return;
                }

                var lines = File.ReadAllLines(dataFile);
                students.Clear();

                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        students.Add(new Student
                        {
                            LastName = parts[0],
                            FirstName = parts[1],
                            MiddleName = parts[2],
                            GroupNumber = parts[3]
                        });
                    }
                }

                Console.WriteLine($"Загружено {students.Count} студентов из файла.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке файла: {ex.Message}");
            }
        }

        static void CreateSampleData()
        {
            students.AddRange(new[]
            {
            new Student { LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", GroupNumber = "П-11" },
            new Student { LastName = "Петрова", FirstName = "Мария", MiddleName = "Сергеевна", GroupNumber = "М-10" },
            new Student { LastName = "Сидоров", FirstName = "Алексей", MiddleName = "Петрович", GroupNumber = "Г-21" },
            new Student { LastName = "Козлова", FirstName = "Анна", MiddleName = "Владимировна", GroupNumber = "ФИ-20" }
        });

            SaveStudentsToFile();
            Console.WriteLine("Создан файл с демонстрационными данными.");
        }

        static void SaveStudentsToFile()
        {
            try
            {
                var lines = students.Select(s => s.ToCsvString()).ToArray();
                File.WriteAllLines(dataFile, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении файла: {ex.Message}");
            }
        }

        static void ShowAllStudents()
        {
            Console.Clear();
            Console.WriteLine("=== СПИСОК СТУДЕНТОВ ===");

            if (students.Count == 0)
            {
                Console.WriteLine("Студентов не найдено.");
            }
            else
            {
                Console.WriteLine("№  Фамилия       Имя           Отчество        Группа");
                Console.WriteLine("------------------------------------------------------");

                for (int i = 0; i < students.Count; i++)
                {
                    var student = students[i];
                    Console.WriteLine($"{i + 1,-2} {student.LastName,-12} {student.FirstName,-12} {student.MiddleName,-15} {student.GroupNumber,-8}");
                }
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }

        static void EditStudentByNumber()
        {
            Console.Clear();
            Console.WriteLine("=== РЕДАКТИРОВАНИЕ СТУДЕНТА ===");

            if (students.Count == 0)
            {
                Console.WriteLine("Нет студентов для редактирования.");
                Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
                return;
            }

            ShowAllStudents();
            Console.Write("\nВведите номер студента для редактирования: ");

            if (int.TryParse(Console.ReadLine(), out int studentNumber) && studentNumber >= 1 && studentNumber <= students.Count)
            {
                var student = students[studentNumber - 1];

                Console.WriteLine($"\nРедактирование студента: {student}");
                Console.WriteLine("(Оставьте поле пустым, чтобы не изменять значение)");

                Console.Write($"Новая фамилия [{student.LastName}]: ");
                var newLastName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newLastName))
                    student.LastName = newLastName;

                Console.Write($"Новое имя [{student.FirstName}]: ");
                var newFirstName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newFirstName))
                    student.FirstName = newFirstName;

                Console.Write($"Новое отчество [{student.MiddleName}]: ");
                var newMiddleName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newMiddleName))
                    student.MiddleName = newMiddleName;

                Console.Write($"Новый номер группы [{student.GroupNumber}]: ");
                var newGroupNumber = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newGroupNumber))
                    student.GroupNumber = newGroupNumber;

                SaveStudentsToFile();
                Console.WriteLine("\nДанные студента успешно обновлены!");
            }
            else
            {
                Console.WriteLine("Неверный номер студента!");
            }

            Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}

