namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if (Math.Sign(a) == Math.Sign(b) && Math.Sign(b) == Math.Abs(c))
            {
                answer = true;
            }

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            if (Math.Max(a, b) % Math.Min(a, b) == 0)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (Math.Pow(Math.Min(a, b), 2) == Math.Max(a, b) ||  Math.Pow(Math.Min(a, b), 3) == Math.Max(a, b))
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = -f + 4 * d * g;

            

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
            {
                answer = 1;
            }
            else
            {
                if (x <= 1)
                {
                    answer = -x;
                }
                else
                {
                    answer = -1;
                }
            }

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            
            // end

            return answer;
        }
    }
}