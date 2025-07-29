using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop01Cs
{
    internal struct Point
    {

        #region struct

        ///-( struct )

        //public int x;
        //public int Y;

        //// constructor : special methods
        ////             1. Named linke struct
        ////             2. Has no return type

        //// cclr : will generate paremeterless contructor
        //// this constrctor will initialized the atrributes with the default


        ////constructor
        //// public Point() { }

        ////.net 5.0 C# 9.0
        //// .net 6.0 C# 10.0

        //public Point( int x, int y)
        //{
        //    x = 8;
        //    Y = 8; 
        //}  


        #endregion

        #region oop 


        //--------- ( oop )  : obect oriented progragamming
        // programming paradigm
        // oop : the paradigm use for build any business

        /// class : Blueprint of the object
        /// object  : specific instance from class

        /// 4 pillars
        /// ========================
        ///   1. Encapsulation
        ///   2. Inheritance
        ///   3. ploymorphism
        ///   4. Abstraction
        ///   

        #endregion

       

        // 1. Encapsulation : 
        // class or struct 
        // seperate the date( Attributes) definition from its use
        // {setter Getter Method - properties}

        // Employee 
        // id name salary 

        // 1. End user Access data itself
        // 2. No data validation
        // 3. No read only filed

        // Apply Encapsulation :
        // 1. make All Data(Attributes) private
        // 2. Access data through :

        // 2.1. setter getter method
        // 2.2. properties
        //Employee E01 = new Employee();
        //E01 .id=1;
        //E01.name="ahmed";
        //E01.salary = 12000;

        //console.writline(E01.id);
        //console.writline(E01.name);
        //console.writline(E01.salary);

       
        
        //Indexer : special property

        // phonebook : 

    }

}
