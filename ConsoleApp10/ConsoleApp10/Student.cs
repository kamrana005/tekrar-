using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Student
    {
        static Student()
        {
            _totalCount = 0;
        }
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }

        private static int _totalCount;
        public int TotalCount => _totalCount;
        public int No { get;}
        public string FullName;
        private string _groupNo;
        public string GroupNo
        {
            get { return _groupNo; }
            set { if(CheckGroupNo(value)) _groupNo = value; }
            
        }
        public bool CheckGroupNo(string GroupNo)
        {
            if (!string.IsNullOrEmpty(GroupNo) && GroupNo == 4)
            {
                if (Char.IsLetter(GroupNo[0]))
                {
                    for(int i = 1; i < GroupNo.Length; i++)
                    {
                        if(!Char.IsDigit(GroupNo[i])) 
                            return false;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
