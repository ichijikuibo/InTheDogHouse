using System;

namespace ProgrammingIII
{
    public static class Validation
    {
        /// <summary>
        /// Check if a string has a length between 2 sizes(inclusive)
        /// </summary>
        /// <param name="txt">The String to test</param>
        /// <param name="min">The minimum length the string should be</param>
        /// <param name="max">The maximum length the string should be</param>
        /// <Author>Teresa Deeny</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if string length is between the 2 values, false if it isn't</returns>
        public static bool validLength(string txt,int min,int max)
        {
            bool ok = true;
            if (string.IsNullOrEmpty(txt))
                ok = false;
            else if (txt.Length < min || txt.Length > max)
                ok = false;
            return ok;
        }

        /// <summary>
        /// Check if a string is a valid number
        /// </summary>
        /// <param name="txt">The String to test</param>
        /// <Author>Teresa Deeny</Author>
        /// <ModifiedBy>Colm Canavan</ModifiedBy>
        /// <returns>true if the string is a number, false if it isn't</returns>
        public static bool validNumber(string txt)
        {
            bool ok = true;
            bool containsNumber = false;
            foreach(char c in txt)
            {
                if (char.IsNumber(c))
                {
                    containsNumber = true;
                }
                else if(c!='-'&&c!=','&&c!='.') ok = false;
            }
            if (!containsNumber) ok = false;
            return ok;
        }

        /// <summary>
        /// Check if a string is only letters
        /// </summary>
        /// <param name="txt">The String to test</param>
        /// <Author>Teresa Deeny</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the string is all letters, false if it isn't</returns>
        public static bool validLetter(string txt)
        {
            bool ok = true;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                foreach (char c in txt)
                {
                    if (!char.IsLetter(c)) ok = false;
                }
            }
            return ok;
        }

        /// <summary>
        /// Check if a string is letters or whitespace
        /// </summary>
        /// <param name="txt">The String to test</param>
        /// <Author>Teresa Deeny</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the string is letters or whitespace false if it isn't</returns>
        public static bool validLetterWhiteSpace(string txt)
        {
            bool ok = true;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                foreach (char c in txt)
                {
                    if (!char.IsLetter(c)&&!char.IsWhiteSpace(c)) ok = false;
                }
            }
            return ok;
        }

        /// <summary>
        /// Check if a string is letters, whitespace or numbers
        /// </summary>
        /// <param name="txt">The String to test</param>
        /// <Author>Teresa Deeny</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the string is letters, whitespace or numbers, false if it isn't</returns>
        public static bool validLetterWhiteSpaceNumber(string txt)
        {
            bool ok = true;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                foreach (char c in txt)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && !char.IsNumber(c)) ok = false;
                }
            }
            return ok;
        }

        /// <summary>
        /// Check if a string is a valid forename
        /// </summary>
        /// <param name="txt">The String to test</param>
        /// <Author>Teresa Deeny</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the string is a valid forename, false if it isn't</returns>
        public static bool validForename(string txt)
        {
            bool ok = true;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                foreach (char c in txt)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c!='-') ok = false;
                }
            }
            return ok;
        }

        /// <summary>
        /// Check if a string is a valid forename
        /// </summary>
        /// <param name="txt">The String to test</param>
        /// <Author>Teresa Deeny</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the string is a valid surname, false if it isn't</returns>
        public static bool validSurname(string txt)
        {
            bool ok = true;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                foreach (char c in txt)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c) && c != '-'&&c!='/' && c != '\'') ok = false;
                }
            }
            return ok;
        }

        /// <summary>
        /// Check if a date if within min and max number of years of the specified date
        /// </summary>
        /// <param name="txt">The date in string format</param>
        /// <param name="currentDate">The date to measure from</param>
        /// <param name="min">The minimum number of days away from the specified date should be</param>
        /// <param name="max">The maximum number of days away from the specified date should be</param>
        /// <Author>Colm Canavan</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the date is within min and max, false if not</returns>
        public static bool validDOBDays(string txt, DateTime currentDate, int min = 0, int max = int.MaxValue)
        {
            bool ok = true;
            TimeSpan span = currentDate - Convert.ToDateTime(txt);
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                if (span.TotalDays < min || span.TotalDays > max) ok = false;
            }
            return ok;
        }

        /// <summary>
        /// Check if a date if within min and max number of days of the current date
        /// </summary>
        /// <param name="txt">The date in string format</param>
        /// <param name="min">The minimum number of days away from the current date should be</param>
        /// <param name="max">The maximum number of days away from the current date should be</param>
        /// <Author>Colm Canavan</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the date is within min and max, false if not</returns>
        public static bool validDOBDays(string txt, int min = 0, int max = int.MaxValue)
        {
            return validDOBDays(txt, DateTime.Now, min, max);
        }
        /// <summary>
        /// Check if a date if within min and max number of years of the specified date
        /// </summary>
        /// <param name="txt">The date in string format</param>
        /// <param name="currentDate">The date to measure from</param>
        /// <param name="min">The minimum number of years away from the specified date should be</param>
        /// <param name="max">The maximum number of years away from the specified date should be</param>
        /// <Author>Colm Canavan</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the date is within min and max, false if not</returns>
        public static bool validDOBYears(string txt, DateTime currentDate, int min = 0, int max = int.MaxValue)
        {
            bool ok = true;
            TimeSpan span = currentDate - Convert.ToDateTime(txt);
            double years = span.TotalDays / 365;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                if (years < min || years > max) ok = false;
            }
            return ok;
        }
        /// <summary>
        /// Check if a date if within min and max number of years of the current date
        /// </summary>
        /// <param name="txt">The date in string format</param>
        /// <param name="min">The minimum number of years away from the current date should be</param>
        /// <param name="max">The maximum number of years away from the current date should be</param>
        /// <Author>Colm Canavan</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the date is within min and max, false if not</returns>
        public static bool validDOBYears(string txt, int min = 0, int max = int.MaxValue)
        {
            return validDOBYears(txt, DateTime.Now, min, max);
        }

        /// <summary>
        /// Check id an email address is valid
        /// </summary>
        /// <param name="txt">The email address to check</param>
        /// <Author>Colm Canavan</Author>
        /// <ModifiedBy></ModifiedBy>
        /// <returns>true if the text is a valid email, false if it is invlaid</returns>
        public static bool validEmail(string txt)
        {
            int at = txt.IndexOf("@");
            int lastDot = txt.LastIndexOf(".");
            if (at < 1) return false;
            if (lastDot < at || txt.Contains("..")|| txt.EndsWith(".")) return false;
            string local = txt.Substring(0,at);
            if (local.StartsWith(".") || local.EndsWith("."))return false;
            if (local.StartsWith(".") || local.EndsWith(".")) return false;
            string domain = txt.Substring(at + 1, lastDot - at - 1);
            if (domain.StartsWith(".") || local.EndsWith(".")) return false;
            if (domain.StartsWith("-") || local.EndsWith("-")) return false;
            string topLevelDomain = txt.Substring(lastDot + 1);

            foreach(char c in local)
            {
                if (!validLocalChar(c)) return false;
            }
            foreach (char c in domain)
            {
                if (!validDomainChar(c)) return false;
            }
            foreach (char c in topLevelDomain)
            {
                if (!char.IsLetter(c)) return false;
            }
            return true;

        }
        private static bool validLocalChar(char c)
        {
            if (char.IsLetter(c)) return true;
            if (char.IsNumber(c)) return true;
            if ("!#$%&'*+-/=?^_`{|}~.".Contains(c.ToString())) return true;
            return false;
        }
        private static bool validDomainChar(char c)
        {
            if (char.IsLetter(c)) return true;
            if (char.IsNumber(c)) return true;
            if ( c == '-'|| c == '.') return true;
            return false;
        }
    }
}
