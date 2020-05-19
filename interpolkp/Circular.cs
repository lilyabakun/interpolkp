using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace interpolkp
{
    public class Circular
    {

        [Key] public int ID_Circular { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Name { get; set; }

        public string Nationatly { get; set; }
        [Required]
        public char Sex { get; set; }

        public string Birthday { get; set; }

        public string Birthplace { get; set; }

        public string Features { get; set; }


        public string DateCreate { get; set; }

        public string Height { get; set; }

        public string HairColor { get; set; }

        public string EyeColor { get; set; }

        public string Languages { get; set; }
        public bool Activity { get; set; }

        public virtual ICollection<Black_Circular> Black_Circulars { get; set; }
        public virtual ICollection<Blue_Circular> Blue_Circulars { get; set; }
        public virtual ICollection<Red_Circular> Red_Circulars { get; set; }
        public virtual ICollection<Yellow_circular> Yellow_Circulars { get; set; }
        public virtual ICollection<Green_Circular> Green_Circulars { get; set; }



        public Circular(int iD_Circular, string surname, string name, string nationatly, char sex, string birthday,
                        string birthplace, string features, string dateCreate, string height, string hairColor,
                        string eyeColor, string languages, bool activity)
        {
            ID_Circular = iD_Circular;
            Surname = surname;
            Name = name;
            Nationatly = nationatly;
            Sex = sex;
            Birthday = birthday;
            Birthplace = birthplace;
            Features = features;
            DateCreate = dateCreate;
            Height = height;
            HairColor = hairColor;
            EyeColor = eyeColor;
            Languages = languages;

            Activity = activity;

        }
        public Circular()
        {
            ID_Circular = 0;
            Surname = "";
            Name = "";
            Nationatly = "";
            Sex = 'l';
            Birthday = "";
            Birthplace = "";
            Features = "";
            DateCreate = "";
            Height = "";
            HairColor = "";
            EyeColor = "";
            Languages = "";

            Activity = false;

        }
    }
}
