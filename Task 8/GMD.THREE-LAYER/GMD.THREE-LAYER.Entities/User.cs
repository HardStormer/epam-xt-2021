using System;
using System.Collections.Generic;

namespace GMD.THREE_LAYER.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value > DateTime.Now.AddYears(-150) & value < DateTime.Now)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new Exception("Not vaild date of birth");
                }
            }
        }
        public int Age
        {
            get
            {
                return CountAge(DateOfBirth);
            }
        }
        private int CountAge(DateTime date)
        {
            var currentDate = DateTime.Now;
            int range = currentDate.Year - date.Year;
            if (currentDate.DayOfYear < date.DayOfYear)
            {
                range--;
            }
            return range;
        }
        public List<Guid> Awards { get; set; }
    }
}
