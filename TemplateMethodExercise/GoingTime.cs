using System;

namespace TemplateMethodExercise
{
    class Point
    {
        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; }
        public float Y { get; }
    }

    enum GoingMetric
    {
        EuclideanMetric,
        ManhattanMetric
    }
    interface IGoingTime
    {
        float CalculateGoingTime(Point startPoint, Point endPoint, GoingMetric metric);
    }
    class GoingTime : IGoingTime
    {
        private readonly float _speed;

        public GoingTime(float speed)
        {
            _speed = speed;
        }

        public float CalculateGoingTime(Point startPoint, Point endPoint, GoingMetric metric)
        {
            var calculatedDistance = 0f;
            switch (metric)
            {
                case GoingMetric.EuclideanMetric:
                    calculatedDistance = CalculateEuclideanMetric(startPoint, endPoint);
                    break;
                case GoingMetric.ManhattanMetric:
                    calculatedDistance = CalculateManhattanMetric(startPoint, endPoint);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(metric), metric, null);
            }

            var time = calculatedDistance / _speed;
            return time;
        }

        private float CalculateEuclideanMetric(Point startPoint, Point endPoint)
        {
            return (float)Math.Sqrt(Math.Pow(startPoint.X + endPoint.X, 2) + Math.Pow(startPoint.Y + endPoint.Y, 2));
        }

        private float CalculateManhattanMetric(Point startPoint, Point endPoint)
        {
            return Math.Abs(endPoint.X - startPoint.X) + Math.Abs(endPoint.Y - startPoint.Y);
        }
    }
}
