using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpoDevoir
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static bool IsGood(BinNode<int> t)//Tres bien
        {
           
            if (t.GetRight().GetValue() < 10 && t.GetLeft().GetValue() < 10 && t.GetValue() < 10)//Check if the number is good
            {
                return true;
            }
            
            return false;
        }

        
        static bool Test2(BinNode<int> t)//Tres bien
        {
            bool b1 = true, b2 = true;
            if (t.GetRight().GetRight() == null && t.GetRight().GetLeft() == null && t.GetLeft().GetRight() == null && t.GetLeft().GetLeft() == null)
            {
                if (!IsGood(t))
                    return false;
            }
            else
            {

                if (t.GetRight() != null)
                {
                   b1 = Test2(t.GetRight());
                }
                if (t.GetLeft() != null)
                {
                  b2 =  Test2(t.GetLeft());
                }
                    return true == b1 == b2;
            }

            return true;

        }
        static bool IsTreePele(BinNode<int> t)//bof
        {
            bool IsGoodTree = false;

            if (t.GetRight().GetRight() == null && t.GetRight().GetLeft() == null && t.GetLeft().GetRight() == null && t.GetLeft().GetLeft() == null)
            {
                if (t.GetRight().GetValue() < 10 && t.GetLeft().GetValue() < 10 && t.GetValue() < 10)//Check if the number is good
                {
                    IsGoodTree = true;
                }
                else
                {
                    return false;
                }
            }
            else if (t.GetRight() != null)
            {
                IsTreePele(t.GetRight());
                if (t.GetLeft() != null)
                    IsTreePele(t.GetLeft());
            }

            return IsGoodTree;
        }

        static void Test(BinNode<int> t)//pas mal
        {
            if (t.GetRight().GetRight() != null)
            { Test(t.GetRight()); }
            if (t.GetRight().GetLeft() != null)
            { Test(t.GetRight()); }

            if (t.GetLeft().GetRight() != null)
            { Test(t.GetLeft()); }
            if (t.GetLeft().GetLeft() != null)
            { Test(t.GetLeft()); }

            if (t.GetRight().GetRight() == null && t.GetRight().GetLeft() == null && t.GetLeft().GetRight() == null && t.GetLeft().GetLeft() == null)
                if (!IsGood(t))
                    Console.WriteLine("Is not a tree pele !");

        }

    }
}
