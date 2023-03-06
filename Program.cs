using Day21MsTestDemo;

namespace Day21MsTest
{
    class Program
    {
        public static void Main(string[] args) {
            try
            {
                MoodAnalyse mood = MoodAnalyserFactory.CreateMoodAnalyzer();
                Console.WriteLine(mood.Analyze(""));
            }
            catch (MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
    }
}