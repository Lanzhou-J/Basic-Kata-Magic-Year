namespace Magic.Year
{
    public class Calculator
    {
        public int CalculateMagicYear(int startYear)
        {
            int addend = 65;
            int magicYear = startYear + addend;
            return magicYear;
        }

    }
}