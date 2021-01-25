using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpTools_2
{
    public class Metalki
    {
        string id;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        bool finished;

        public bool Finished
        {
            get
            {
                return finished;
            }

            set
            {
                finished = value;
            }
        }


        DateTime date;

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        double summ;

        public double Summ
        {
            get
            {
                return summ;
            }

            set
            {
                summ = value;
            }
        }
    }
}
