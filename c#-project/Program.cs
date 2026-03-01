using System;
using System.Collections.Generic;
using System.IO;
namespace C_Project
{


    #region Enums
    public enum ExamMode
    {
        Queued,
        Starting,
        Finished
    }
    #endregion

    #region Answer
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Answer() : this(0, "") { }

        public Answer(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Id}. {Text}";
        }
    }

    public class AnswerList : List<Answer> { }
    #endregion

    #region Question
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Answers { get; set; }
        public List<int> CorrectAnswers { get; set; }

        protected Question() : this("", "", 0) { }

        protected Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = new AnswerList();
            CorrectAnswers = new List<int>();
        }

        public abstract void Show();

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Question other)
        {
            return Marks.CompareTo(other.Marks);
        }

        public override string ToString()
        {
            return $"{Header}\n{Body} (Marks: {Marks})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Question q)
                return Body == q.Body;
            return false;
        }

        public override int GetHashCode()
        {
            return Body.GetHashCode();
        }
    }
    #endregion

    #region Question Types
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string body, int marks)
            : base("True / False", body, marks)
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }

        public override void Show()
        {
            Console.WriteLine(this);
            foreach (var a in Answers)
                Console.WriteLine(a);
        }
    }

    public class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string body, int marks)
            : base("Choose One", body, marks) { }

        public override void Show()
        {
            Console.WriteLine(this);
            foreach (var a in Answers)
                Console.WriteLine(a);
        }
    }

    public class ChooseAllQuestion : Question
    {
        public ChooseAllQuestion(string body, int marks)
            : base("Choose All (enter answers separated by comma)", body, marks) { }

        public override void Show()
        {
            Console.WriteLine(this);
            foreach (var a in Answers)
                Console.WriteLine(a);
        }
    }
    #endregion

    #region QuestionList (Generic + File Logging)
    public class QuestionList : List<Question>
    {
        private string filePath;

        public QuestionList(string path)
        {
            filePath = path;
        }

        public new void Add(Question q)
        {
            base.Add(q); // default behavior

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(q.ToString());
                sw.WriteLine("-----------");
            }
        }
    }
    #endregion

    #region Student + Subject + Events
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }

        public void OnExamStarted(string message)
        {
            Console.WriteLine($"Notification to {Name}: {message}");
        }
    }

    public class Subject
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public event Action<string> ExamStarted;

        public Subject(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void Notify()
        {
            ExamStarted?.Invoke($"Exam for {Name} is starting!");
        }
    }
    #endregion

    #region Exam Base
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public int NumberOfQuestions => Questions.Count;
        public QuestionList Questions { get; set; }
        public Subject Subject { get; set; }
        public ExamMode Mode { get; set; }

        protected Dictionary<Question, List<int>> StudentAnswers;

        protected Exam(int time, Subject subject, string filePath)
        {
            Time = time;
            Subject = subject;
            Questions = new QuestionList(filePath);
            Mode = ExamMode.Queued;
            StudentAnswers = new Dictionary<Question, List<int>>();
        }

        public void Start()
        {
            Mode = ExamMode.Starting;
            Subject.Notify();

            ShowExam();

            Mode = ExamMode.Finished;
            ShowResult();
        }

        protected List<int> ReadAnswers()
        {
            string input = Console.ReadLine();
            List<int> answers = new List<int>();

            foreach (var s in input.Split(','))
                answers.Add(int.Parse(s.Trim()));

            return answers;
        }

        public abstract void ShowExam();
        public abstract void ShowResult();

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            return Time.CompareTo(other.Time);
        }

        public override string ToString()
        {
            return $"Subject: {Subject.Name} - Time: {Time}";
        }
    }
    #endregion

    #region Practice Exam
    public class PracticeExam : Exam
    {
        public PracticeExam(int time, Subject subject)
            : base(time, subject, "PracticeQuestions.txt") { }

        public override void ShowExam()
        {
            foreach (var q in Questions)
            {
                q.Show();
                Console.Write("Your Answer: ");
                StudentAnswers[q] = ReadAnswers();
                Console.WriteLine();
            }
        }

        public override void ShowResult()
        {
            int total = 0;

            Console.WriteLine("\nCorrect Answers:");
            foreach (var item in StudentAnswers)
            {
                if (IsCorrect(item.Key.CorrectAnswers, item.Value))
                    total += item.Key.Marks;

                Console.WriteLine(item.Key.Body);
                Console.WriteLine("Correct: " + string.Join(",", item.Key.CorrectAnswers));
            }

            Console.WriteLine($"Total Score: {total}");
        }

        private bool IsCorrect(List<int> correct, List<int> student)
        {
            if (correct.Count != student.Count) return false;
            correct.Sort();
            student.Sort();
            for (int i = 0; i < correct.Count; i++)
                if (correct[i] != student[i]) return false;
            return true;
        }
    }
    #endregion

    #region Final Exam
    public class FinalExam : Exam
    {
        public FinalExam(int time, Subject subject)
            : base(time, subject, "FinalQuestions.txt") { }

        public override void ShowExam()
        {
            foreach (var q in Questions)
            {
                q.Show();
                Console.Write("Your Answer: ");
                StudentAnswers[q] = ReadAnswers();
                Console.WriteLine();
            }
        }

        public override void ShowResult()
        {
            int total = 0;

            foreach (var item in StudentAnswers)
            {
                if (IsCorrect(item.Key.CorrectAnswers, item.Value))
                    total += item.Key.Marks;
            }

            Console.WriteLine($"\nFinal Score: {total}");
        }

        private bool IsCorrect(List<int> correct, List<int> student)
        {
            if (correct.Count != student.Count) return false;
            correct.Sort();
            student.Sort();
            for (int i = 0; i < correct.Count; i++)
                if (correct[i] != student[i]) return false;
            return true;
        }
    }
    #endregion

    #region Program

    class Program
    {
        static void Main()
        {
            // Subject
            Subject subject = new Subject("OOP");

            // Students
            var s1 = new Student("Ahmed");
            var s2 = new Student("Sara");

            subject.ExamStarted += s1.OnExamStarted;
            subject.ExamStarted += s2.OnExamStarted;

            Console.WriteLine("Select Exam Type:");
            Console.WriteLine("1. Practice");
            Console.WriteLine("2. Final");

            int choice = int.Parse(Console.ReadLine());

            Exam exam = choice == 1
                ? new PracticeExam(30, subject)
                : new FinalExam(30, subject);

            // Questions
            var q1 = new TrueFalseQuestion("C# is OOP?", 5);
            q1.CorrectAnswers.Add(1);

            var q2 = new ChooseOneQuestion("2 + 2 = ?", 5);
            q2.Answers.Add(new Answer(1, "3"));
            q2.Answers.Add(new Answer(2, "4"));
            q2.Answers.Add(new Answer(3, "5"));
            q2.CorrectAnswers.Add(2);

            var q3 = new ChooseAllQuestion("Select OOP principles", 10);
            q3.Answers.Add(new Answer(1, "Encapsulation"));
            q3.Answers.Add(new Answer(2, "Inheritance"));
            q3.Answers.Add(new Answer(3, "Loop"));
            q3.Answers.Add(new Answer(4, "Polymorphism"));
            q3.CorrectAnswers.AddRange(new[] { 1, 2, 4 });

            exam.Questions.Add(q1);
            exam.Questions.Add(q2);
            exam.Questions.Add(q3);

            exam.Start();
        }
    }
}
#endregion