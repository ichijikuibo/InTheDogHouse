using ProgrammingIII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDogHouse.Models
{
    class SizeModel
    {
        int sizeNo;
        double charge;

        public SizeModel()
        {
            sizeNo = 1;
            charge = 2.5;
        }

        public SizeModel(int sizeNo, double charge)
        {
            this.sizeNo = sizeNo;
            this.charge = charge;
        }

        public int SizeNo { get => sizeNo; set => sizeNo = value; }
        public double Charge
        {
            get => charge; set
            {
                if (value <= 10 && value >= 2.5)
                {
                    charge = value;
                }
                else
                {
                    throw new MyException("Charge must be greater than £2.50 and less than £10.00");
                }
            }
        }
    }
}
