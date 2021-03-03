/*###################################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 03/03/21
 GitHub Link: https://github.com/AbigailHerron/ObjectOrientatedDevelopment/blob/main/Week6/Labsheet2/PartialClasses/SalesOrderHeader.cs

 Description: Partial Class to auto-generated SalesOrderHeader just to override the ToString method
 ###################################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet2
{
    public partial class SalesOrderHeader
    {
        public override string ToString()
        {
            return string.Format("{0}:{1} {2:C}", OrderDate.ToShortDateString(), SalesOrderID, TotalDue);
        }// end ToString()
    }// end SalesOrderHeader partial Class
}// end Namespace
