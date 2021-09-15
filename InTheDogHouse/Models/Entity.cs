using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingIII;

namespace InTheDogHouse.Models
{
    class Entity
    {
        private string address, town, county, postcode,telNo;

        public Entity(string address, string town, string county, string postcode, string telNo)
        {
            Address = address;
            Town = town;
            County = county;
            Postcode = postcode;
            TelNo = telNo
        }

        public string Address {
            get => address; 
            set
            {
                if(value!=address)
                {
                    if (Validation.validLength(value, 4, 30) && Validation.validLetterWhiteSpaceNumber(value))
                    {
                        address = value;
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
                        town = value;
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
                        county = value;
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
                    if (Validation.validLength(value, 6, 8) && Validation.validLetter(value))
                    {
                        postcode = value;
                    }
                    else
                    {
                        throw new MyException("Postcode must be between 6 & 8 characters and contain only letters, numbers and whitespace.");
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
