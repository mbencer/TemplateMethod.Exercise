using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var startPoint = new Point(0f,0f);
            var endPoint = new Point(10f, 15f);
            var michalSpeed = 6f;
            var jakubSpeed = 6f;

            var michalGoingTime = new MichalGoingTime(michalSpeed);
            var jakubGoingTime = new JakubGoingTime(jakubSpeed);

            Console.WriteLine("Michal going time:");
            Console.WriteLine(michalGoingTime.CalculateGoingTime(startPoint, endPoint, GoingMetric.EuclideanMetric));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Jakub going time:");
            Console.WriteLine(jakubGoingTime.CalculateGoingTime(startPoint, endPoint, GoingMetric.ManhattanMetric));
            Console.Read();
        }
    }
}
