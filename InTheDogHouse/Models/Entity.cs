using ProgrammingIII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDogHouse.Models
{
    class Entity
    {
        int idNo;
        private string address, town, county, postcode,telNo;

        public Entity(int iNo,string address, string town, string county, string postcode, string telNo)
        {
            idNo = iNo;
            Address = address;
            Town = town;
            County = county;
            Postcode = postcode;
            TelNo = telNo;
        }
        public Entity()
        {
            idNo = 0;
            address = "";
            town = "";
            county = "";
            postcode = "";
            telNo = "";
        }
        public int IDNo
        {
            get => idNo;
            set => idNo = value;
        }
        public string Address {
            get => address; 
            set
            {
                if(value!=address)
                {
                    if (Validation.validLength(value, 4, 30) && Validation.validLetterWhiteSpaceNumber(value))
                    {
                        address = StringManipulator.firstLetterEachWordToUpper(value); 
                    }
                    else
                    {
                        throw new MyException("Address must be between 4 & 30 characters and contain only letters numbers and spaces");
                    }
                }

            }

        }
        public string Town
        {
            get => town;
            set 
            {
                if (value != town)
                {
                    if (Validation.validLength(value, 2, 20) && Validation.validLetter(value))
                    {
                        town = StringManipulator.firstLetterEachWordToUpper(value);
                    }
                    else
                    {
                        throw new MyException("Town must be between 2 & 20 characters and contain only letters.");
                    }
                }
            }
        }
        public string County 
        {
            get => county;
            set 
            {
                if (value != county)
                {
                    if (Validation.validLength(value, 4, 20) && Validation.validLetter(value))
                    {
                        county = StringManipulator.firstLetterEachWordToUpper(value);
                    }
                    else
                    {
                        throw new MyException("County must be between 4 & 20 characters and contain only letters.");
                    }
                }
            }
        }
        public string Postcode 
        { 
            get => postcode;
            set 
            {
                if (value != postcode)
                {
                    if (Validation.validLength(value, 6, 9) && Validation.validLetterWhiteSpaceNumber(value))
                    {
                        postcode = value;
                    }
                    else
                    {
                        throw new MyException("Postcode must be between 6 & 9 characters and contain only letters, numbers and whitespace.");
                    }
                }
            } 
        }

        public string TelNo 
        { 
            get => telNo;
            set
            {
                if (value != telNo)
                {
                    if (Validation.validLength(value,8, 11) && Validation.validNumber(value))
                    {
                        telNo = value;
                    }
                    else
                    {
                        throw new MyException("Postcode must be between 8 & 11 characters and contain only numbers.");
                    }
                }
            }
        }
    }
}
