using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set { 
                //set the private data
                mStockList = value;
            }
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }

            set
            {
                //we shall worry about this later
            }

        }


        public clsStock ThisStock { get; set; }


        
        //constructor for the class
        public clsStockCollection()
        {
            //create the items of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.IsbnID = 1;
            TestItem.BookName = "a book name";
            TestItem.BookAuthor = "the books author";
            TestItem.Price = 2.99m; ;
            TestItem.DateAdded = DateTime.Now;
            TestItem.QuantityAvailable = 5;
            TestItem.Active = true;
            //add the test items to the test list
            mStockList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStock();
            //set uts properties
            TestItem.IsbnID = 2; ;
            TestItem.BookName = "another book name";
            TestItem.BookAuthor = "the books author";
            TestItem.Price = 4.99m;
            TestItem.DateAdded = DateTime.Now;
            TestItem.QuantityAvailable = 3;
            TestItem.Active = true;
            //add the item to the test list
            mStockList.Add(TestItem);

        }
        
        


            }
}