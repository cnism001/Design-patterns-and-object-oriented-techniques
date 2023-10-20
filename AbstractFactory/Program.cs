namespace DesignPatterns
{
    // Class for Printer
    // TODO#1: Convert to use Singleton pattern
    public class Printer
    {
        private static Printer? instance;
        private Printer() { }
        public static Printer GetInstance()
        {
            if (instance == null)
            {
                instance = new Printer();
            }
            return instance;
        }
        public void Print(string message)
        {
            // Output: print out the string message 
            Console.WriteLine(message);
        }
    }

    // Class template for Exam classes
    // TODO#2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types.

    // Abstract ExamUI interface
    public interface ExamUI
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }

    // Abstract Exam Factory
    public abstract class ExamFactory
    {
        public abstract ExamUI CreateExam();
    }

    // Concrete Factory for MathExam
    public class MathExamFactory : ExamFactory
    {
        public override ExamUI CreateExam()
        {
            return new MathExam();
        }
    }
    // Concrete Factory for ScienceExam
    public class ScienceExamFactory : ExamFactory
    {
        public override ExamUI CreateExam()
        {
            return new ScienceExam();
        }
    }

    // Concrete Factory for ProgrammingExam
    public class ProgrammingExamFactory : ExamFactory
    {
        public override ExamUI CreateExam()
        {
            return new ProgrammingExam();
        }
    }
    public class MathExam: ExamUI
    {
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            Console.WriteLine("Conducting Math Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            Console.WriteLine("Evaluating Math Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            Console.WriteLine("Publishing Math Exam Results");
        }
    }

    // ScienceExam class (TODO#5)
    public class ScienceExam : ExamUI
    {
        public void Conduct()
        {
            Console.WriteLine("Conducting Science Exam");
        }

        public void Evaluate()
        {
            Console.WriteLine("Evaluating Science Exam");
        }

        public void PublishResults()
        {
            Console.WriteLine("Publishing Science Exam Results");
        }
    }

    // ProgrammingExam class (TODO#6)
    public class ProgrammingExam : ExamUI
    {
        public void Conduct()
        {
            Console.WriteLine("Conducting Programming Exam");
        }

        public void Evaluate()
        {
            Console.WriteLine("Evaluating Programming Exam");
        }

        public void PublishResults()
        {
            Console.WriteLine("Publishing Programming Exam Results");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // TODO#7: Initialize Printer that uses Singleton pattern
            Printer printer = Printer.GetInstance();
            // TODO#8: Test that the created Printer works, by calling the Print method
            printer.Print("Testing that Printer works");
            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            //         Try to create new Printer object and compare the two objects to check,
            Printer testprinter = Printer.GetInstance();
            //         that the new printer object is the same instance
            Console.WriteLine("Checking if printer equals testprinter" + (printer == testprinter));

            // TODO#10: Use Abstract Factory to create different types of exams.
        }
    }

}
