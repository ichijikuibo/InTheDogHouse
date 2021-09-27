using ProgrammingIII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDogHouse.Models
{
    class BreedModel
    {
        string breed;
        int breedSize, breedNo;

        public BreedModel()
        {
            this.breed = "";
            this.breedSize = 1;
            this.breedNo = 200;
        }

        public BreedModel(string breed,int breedSize,int breedNo)
        {
            this.breed = breed;
            this.breedSize = breedSize;
            this.breedNo = breedNo;
        }

        public string Breed
        {
            get => breed; 
            set
            {
                if (breed != value)
                {

                    if (Validation.validLetterWhiteSpace(value) && Validation.validLength(value, 2, 30))
                        breed = StringManipulator.firstLetterEachWordToUpper(value);
                    else
                        throw new MyException("Breed must be between 2 & 30 character and be only letters and spaces");
                }
            }
        }
        public int BreedSize { get => breedSize; 
            set
            {
                breedSize = value;
            }
        }
        public int BreedNo { get => breedNo; set => breedNo = value; }
    }
}
