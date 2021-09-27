using ProgrammingIII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDogHouse.Models
{
    class KennelModel
    {
        int kennelSize, kennelNo;

        public KennelModel()
        {
            this.kennelSize = 1;
            this.kennelNo = 100;
        }

        public KennelModel(int breedSize,int breedNo)
        {
            this.kennelSize = breedSize;
            this.kennelNo = breedNo;
        }

        public int KennelSize { get => kennelSize; 
            set
            {
                kennelSize = value;
            }
        }
        public int KennelNo { get => kennelNo; set => kennelNo = value; }
    }
}
