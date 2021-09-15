using ProgrammingIII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDogHouse.Models
{
    class Customer :Entity
    {
        int customerNo;
        string foreName, surname, title;

        public Customer(int customerNo, string foreName, string surname, string address, string town, string county, string postcode,string telNo) :base(customerNo,address, town, county, postcode, telNo)
        {
            this.customerNo = customerNo;
            ForeName = foreName;
            Surname = surname;
            Title = title;
        }

        public string ForeName
        {
            get => foreName; 
            set
            {
                if (value != foreName)
                {
                    if (Validation.validLength(value, 2, 30) && Validation.validForename(value))
                    {
                        foreName = StringManipulator.firstLetterEachWordToUpper(value); ;
                    }
                    else
                    {
                        throw new MyException("Forename must be between 2 & 30 characters and contain only letters and whitespace.");
                    }
                }
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (value != surname)
                {
                    if (Validation.validLength(value, 2, 30) && Validation.validSurname(value))
                    {
                        surname = StringManipulator.firstLetterEachWordToUpper(value);
                    }
                    else
                    {
                        throw new MyException("Surname must be between 2 & 30 characters and contain only letters and whitespace.");
                    }
                }
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if (value.ToUpper() != "MR" && value.ToUpper() != "MRS" && value.ToUpper() != "MISS" && value.ToUpper() != "MS")
                    throw new MyException("Title must be Mr, Mrs, Miss or Ms.");
                else
                    title = StringManipulator.firstLetterEachWordToUpper(value);
            }
        }
    }
}
