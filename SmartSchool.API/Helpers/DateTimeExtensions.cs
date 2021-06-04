using System;

namespace SmartSchool.API.Helpers
{
    public static class DateTimeExtensions
    {
        public static int GetCurrentAge(DateTime birthDate)
        {
            var age = DateTime.UtcNow.Year - birthDate.Year;
            if (DateTime.UtcNow < birthDate.AddYears(age))
                age--;

            return age;
        }

    }
}
