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

        static bool IsGood(BinNode<int> t)//Check if the number of the  two "Elime" and the "Father" is "< 10"
        {
           
            if (t.GetRight().GetValue() < 10 && t.GetLeft().GetValue() < 10 && t.GetValue() < 10)
            {
                return true;
            }
            
            return false;
        }

        
        static bool IsTreePele(BinNode<int> t)
        {
            bool bRight = true, bLeft = true;
            
            
                //check if t.GetRight() and t.GetLeft() are "Elime" 
                if (t.GetRight().GetRight() == null && t.GetRight().GetLeft() == null && t.GetLeft().GetRight() == null && t.GetLeft().GetLeft() == null)
                {
                    if (!IsGood(t))
                        return false;
                }
                else
                {

                    if (t.GetRight() != null)
                    {
                        bRight = IsTreePele(t.GetRight());
                    }
                    if (t.GetLeft() != null)
                    {
                        bLeft = IsTreePele(t.GetLeft());
                    }
                    return true == bRight == bLeft;
                }
            
            return true;

        }
        
        static bool Foo1(BinNode<char> t)
        {
            if(t !=  null)
            {
                if(t.GetLeft() != null && t.GetRight() != null)
                    if
            }
        }

        static bool Foo2(BinNode<char> t)
        {
            if(t != null)
            {
                if(t.GetLeft().HasLeft() || t.GetLeft().HasRight())
            }
        }
    }
}
