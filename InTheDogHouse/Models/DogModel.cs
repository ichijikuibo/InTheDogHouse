using ProgrammingIII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDogHouse.Models
{
    class DogModel
    {
        private int idNo, breedNo, customerNo;
        private string colour, name;
        private char gender;
        private DateTime dob;

        public DogModel()
        {
            this.idNo = 0;
            this.breedNo = 200;
            this.customerNo = 10000;
            this.colour = "";
            this.gender = 'm';
            this.name = "";
            this.dob = new DateTime(2010,1,1);
        }

        public DogModel(int idNo, int breedNo, int customerNo, string colour, char gender, string name, DateTime dob)
        {
            this.idNo = idNo;
            this.breedNo = breedNo;
            this.customerNo = customerNo;
            this.colour = colour;
            this.gender = gender;
            this.name = name;
            this.dob = dob;
        }

        public int IdNo 
        {
            get => idNo; 
            set 
            {

                    idNo = value;

            } 
        }
        public int BreedNo
        {
            get => breedNo; set
            {
                breedNo = value;
            }
        }
        public int CustomerNo
        {
            get => customerNo;
            set 
            { 
                customerNo = value;
            }
        }
        public string Colour 
        { 
            get => colour; 
            set
            {
                if (Validation.validLetterWhiteSpace(value, "&,")&&Validation.validLength(value,2,20))
                {
                    colour = value;
                }
                else
                {
                    throw new MyException("Colour must be all letters, spaces or & and between 2 and 20 characters");
                }
            } 
        }
        public char Gender
        {
            get => gender;
            set
            {
                if (gender == 'm' || gender == 'f' || gender == 'M' || gender == 'F')
                {
                    gender = value;
                }
                else
                {
                    throw new MyException("Gender must be m or f");
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (Validation.validLetterWhiteSpace(value) && Validation.validLength(value, 2, 15))
                {
                    name = value;
                }
                else
                {
                    throw new MyException("Colour must be all letters or spaces  and between 2 and 15 characters");
                }
            }
        }
        public DateTime Dob
        {

            get => dob; set
            {
                if (Validation.validDOBDays(value,56,(int)(365.25*17.00)))
                {
                    dob = value;
                }
                else
                {
                    throw new MyException("Date of birth must be at least 56 days int he past and no more than 17 years");
                }

            }
        }
    }
}
