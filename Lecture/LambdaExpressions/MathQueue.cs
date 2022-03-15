namespace LambdaExpressions
{
    public delegate double MathOperation<TLeft>(TLeft left, double right, double output);

    public class MathQueue
    {
        List<( Func<int, double, double> Operation, int Left, double Right)> InternalQueue { get;  } = new();

        public void Queue(int left, double right, Func<int, double, double> operation)
        {
            InternalQueue.Add((operation, left, right));
        }

        public void Queue(int left, double right, MathOperation<double> operation)
        {
            InternalQueue.Add(( (left, right) => operation(left, right, right), left, right));
        }

        public double Calculate()
        {
            double result = 0;
            foreach(
                (Func<int, double, double> Operation, int Left, double Right) in InternalQueue)
            {
                result += Operation(Left, Right);
            }
            return result;
        }
    }
}