using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo_CS
{
    class Person
    {

        private float _weight;
        private float _height;
        private string _ethnicity;
        private string _gender;

        #region Properties
        public float Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    this._weight = value;
                }
            }
        }

        public float Height
        {
            get { return _height; }
            set
            {
                if (value > 0)
                {
                   this._height = value;
                }
            }
        }

        public string Ethnicity
        {
            get { return _ethnicity; }
            set { this._ethnicity = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value == "male" || value == "female")
                {
                    this._gender = value;
                }
            }
        }
        #endregion

        public Person(float weight, float height, string ethnicity, string gender)
        {
            this._weight = weight;
            this._height = height;
            this._ethnicity = ethnicity;
            this._gender = gender;
        }

        
    }
}
