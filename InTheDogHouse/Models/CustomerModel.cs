using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InTheDogHouse.Models
{
    public class CustomerModel : INotifyPropertyChanged
    {
        public CustomerModel(int customerNumber, string title, string surname, string forename, string street, string town, string county, string postcode, string telephone)
        {
            this.customerNumberValue = customerNumber;
            this.titleValue = title;
            this.surnameValue = surname;
            this.forenameValue = forename;
            this.streetValue = street;
            this.townValue = town;
            this.countyValue = county;
            this.postcodeValue = postcode;
            this.telephoneValue = telephone;
        }
        public CustomerModel(int customerNumber)
        {
            this.customerNumberValue = customerNumber;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        [Key]
        private int customerNumberValue = 0;
        public int CustomerNo {
            get { return customerNumberValue; }
            set
            {
                if (value != this.customerNumberValue)
                {
                    customerNumberValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
        [Required]
        private string titleValue = "Mr";
        public string Title {
            get { return titleValue; }
            set
            {
                if (value != this.titleValue)
                {
                    this.titleValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
        [Required]
        private string surnameValue = "";
        public string Surname {
            get { return surnameValue; }
            set
            {
                if (value != this.surnameValue)
                {
                    this.surnameValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
        [Required]
        private string forenameValue = "";
        public string Forename {
            get { return forenameValue; }
            set
            {
                if (value != this.forenameValue)
                {
                    this.forenameValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
        [Required]
        private string streetValue = "";
        public string Street {
            get { return streetValue; }
            set
            {
                if (value != this.streetValue)
                {
                    this.streetValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
        [Required]
        private string townValue = "";
        public string Town {
            get { return townValue; }
            set
            {
                if (value != this.townValue)
                {
                    this.townValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
        [Required]
        private string countyValue = "";
        public string County {
            get { return countyValue; }
            set
            {
                if (value != this.countyValue)
                {
                    this.countyValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
        [Required]
        private string postcodeValue = "";
        public string PostCode {
            get { return postcodeValue; }
            set
            {
                if (value != this.postcodeValue)
                {
                    this.postcodeValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
        [Required]
        private string telephoneValue = "";

        public string TelNo {
            get { return telephoneValue; }
            set
            {
                if (value != this.telephoneValue)
                {
                    this.telephoneValue = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
