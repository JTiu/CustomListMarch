using System;
using System.Collections.Generic;
using System.Text;

namespace CustomListMarch
{
    class List<T> //data type, we are writing our own commands for Array; see note for user story 3 "As a developer, I want to use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.
    {
        T[] testArray;

        private int count; //variable, not capitalized
        public int Count  //Property, capitlized
        {
            get { return count; } // User Story 4 As a developer, I want a read-only Count property implemented on the custom-built list class, so that I can get a count of the number of elements in my custom list class instance.
        }

        private int capacity; //User story: As a developer, I want a Capacity property implemented on the custom-built list class, so that I can publicly see the size of my private array.
       
        public int Capacity //As a developer, I want a Capacity property implemented on the custom-built list class, so that I can publicly see the size of my private array.
        {
            get { return capacity; }
            set
            {

                if (value < count)
                {
                    throw new Exception();
                }
                if (value != capacity) 
                {
                
                }

            }      
        }
    }
}
