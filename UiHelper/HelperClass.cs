namespace UiHelper
{
    public class HelperClass
    {

        public List<int> ReturnNumbers(int number)
        {
            
            List<int> result = new List<int>();

            for (int i = 0; i <= number; i++)
            {
                result.Add(i);
            }

            bool isEven = false;

            if (number % 2 == 0)
            {
                isEven = true;
            }

            if (isEven) 
            {
                result = result.Where(n => n % 2 == 0).ToList();
            }
            else
            {
                result = result.Where(n => n % 2 != 0).ToList();
            }

            return result;

        }


    }
}