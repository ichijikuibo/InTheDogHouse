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
            this.customerNumber = customerNumber;
            this.title = title;
            this.surname = surname;
            this.forename = forename;
            this.street = street;
            this.town = town;
            this.county = county;
            this.postcode = postcode;
            this.telephone = telephone;
        }
        public CustomerModel(int customerNumber)
        {
            this.customerNumber = customerNumber;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        [Key]
        private int customerNumberValue = 0;
        public int customerNumber {
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
        public string title {
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
        public string surname {
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
        public string forename {
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
        public string street {
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
        public string town {
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
        public string county {
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
        public string postcode {
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
        private int v;

        public string telephone {
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
