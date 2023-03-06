using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21MsTestDemo
{
    internal class MoodAnalyserFactory
    {
        public static MoodAnalyse CreateMoodAnalyzer()
        {
            try
            {
                Type type = Type.GetType("Day21Reflections.AnalyzeMood");
                MoodAnalyse moodAnalyzer = (MoodAnalyse)Activator.CreateInstance(type);
                return moodAnalyzer;
            }
            catch (ArgumentNullException)
            {
                throw new MoodAnalysisException("Exception Raised: Class not found!");
            }
            catch (Exception)
            {
                throw new MoodAnalysisException("Exception Raised: Constructor is not found!");
            }
        }
    }
}
