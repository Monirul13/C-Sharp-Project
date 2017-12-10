using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EntityLayer
{
    public class UserInfo
    {
        private string name;
        private string contact;
        private string email;
        private string bloodGroup;
        private string religion;
        private string gender;
        private string lastDateOfBloodDonation;
        private string division;
        private string area;
        private string passWord;


        public string Name {

            get { return  this.name; }

            set { this.name = value; }

        }

        public string Contact {

            get {return this.contact;}

            set { this.contact = value;}

        }

        public string Email {

            get { return this.email; }

            set { this.email = value; }

        }

        public string BloodGroup {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }

        public string Religion {
            get { return this.religion; }
            set { this.religion = value; }
        }

        public string Gender {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public string LastDateOfBloodDonatin {
            get { return this.lastDateOfBloodDonation; }
            set { this.lastDateOfBloodDonation = value; }
        }

        public string Division {
            get { return this.division; }
            set { this.division = value; }
        }

        public string Area {
            get { return this.area; }
            set { this.area = value; }
        }

        public string PassWord {
            get { return this.passWord; }
           set { this.passWord = value; }
        }
    }
}
