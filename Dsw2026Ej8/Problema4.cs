namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            if (nota1 is null && nota2 is null && nota3 is null)
                return 0;

            int?[] gradesArray = [nota1, nota2, nota3];
            List<int> validGradesArray = [];

            foreach (var grade in gradesArray)
            {
                if (grade.HasValue && grade >= 0 && grade <= 10)
                {
                    int value = (int)grade;
                    validGradesArray.Add(value);
                }
            }

            if(validGradesArray.Count == 0) return 0;

            return validGradesArray.Sum() / validGradesArray.Count;
        }
    }
}
