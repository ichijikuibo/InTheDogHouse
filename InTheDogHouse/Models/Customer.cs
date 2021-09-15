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
        string foreName, surname;

        public Customer(int customerNo, string foreName, string surname, string address, string town, string county, string postcode,string telNo) :base(address, town, county, postcode, telNo)
        {
            this.customerNo = customerNo;
            ForeName = foreName;
            Surname = surname;
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
                        foreName = value;
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
                if (value != foreName)
                {
                    if (Validation.validLength(value, 2, 30) && Validation.validSurname(value))
                    {
                        foreName = value;
                    }
                    else
                    {
                        throw new MyException("Surname must be between 2 & 30 characters and contain only letters and whitespace.");
                    }
                }
            }
        }
        public int CustomerNo
        {
            get => customerNo;
            set => customerNo = value;  
        }
    }
}
