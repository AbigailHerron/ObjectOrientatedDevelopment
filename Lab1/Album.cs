/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/01/21
 GitHub Repository Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Lab1/Band.cs
 
 Description: A blueprint for a musical Album object
 Properties: Album Name, Released, Sales
 Methods: 
 Constructors: Default, All
 ##########################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Album
    {
        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string AlbumName { get; set; }
        public int YearFormed { get; set; }
        public decimal Sales { get; set; }
    }// end Album class
}
