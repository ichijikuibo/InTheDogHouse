using ProgrammingIII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDogHouse.Models
{
    class Dog
    {
        private int idNo, breedNo,customerNo;
        private string name, colour,gender;
        private DateTime dob;

        public Dog()
        {
            this.idNo = 0;
            this.breedNo = 5000;
            this.customerNo = 10000;
            this.name = "";
            this.colour = "";
            this.gender = "Male";
            this.dob = new DateTime(2000,1,1);
        }

        public Dog(int idNo, int breedNo, int customerNo, string name, string colour, string gender, DateTime dob)
        {
            this.idNo = idNo;
            this.breedNo = breedNo;
            this.customerNo = customerNo;
            this.name = name;
            this.colour = colour;
            this.gender = gender;
            this.dob = dob;
        }

        public int IdNo { get => idNo; 
            set 
            { 
                idNo = value;
            } 
        }
        public int BreedNo { get => breedNo; 
            set 
            {
                breedNo = value; 
            } 
        }
        public int CustomerNo { get => customerNo;
            set 
            { 
                customerNo = value;
            } 
        }
        public string Name { get => name;
            set 
            {
                if (Validation.validForename(value)&&Validation.validLength(value,2,30))
                {
                    name = value;
                }
                else
                {
                    throw new MyException("Must be a valid name and between 2 and 30 letters");
                }

            } 
        }
        public string Colour { get => colour; 
            set 
            {
                if (Validation.validLetterWhiteSpace(value) && Validation.validLength(value, 2, 20))
                {
                    name = value;
                }
                else
                {
                    throw new MyException("Must be a valid color and between 2 and 20 letters");
                }
            }
        }
        public string Gender { get => gender;
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                {
                    gender = value;
                }
                else
                {
                    throw new MyException("Gender must be male or female");
                }
            }
        }
        public DateTime Dob { get => dob; 
            set
            {
                if (Validation.validDOBDays(value.ToString(), 56))
                {
                    dob = value;
                }
            }
        }
    }
}
