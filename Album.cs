using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_L10_DataClass
{
    // Access Modifier - class keyword - class name
    // First Step - Change internal to public
    public class Album
    {
        //fields
        // Data Types - Strings, Ints, Doubles, Bool

        // Public modifier gives access to all classes
        // al field should start with an underscore, _
        public string _title;
        public string _artistName;
        public int _year;
        public string _albumCoverLocation;

        //constuctor
        // Access Modifier - class name - () - parameters

        public Album(String title, string artistName)
        {
            _title = title;
            _artistName = artistName;
        }// Album

        //public Album()
        //{

        //}// default constructor 



        


    }// class
}// namespace
