using nuget1;
using Nuget2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL48
{
    public class UseTwoRecords
    {
        Record1 record1;
        Record2 record2;


        public UseTwoRecords(int n1, int n2)
        {
            record1 = new Record1(n1);
            record2 = new Record2(n2);

            
        }

        public int RecordSum()
        {
            int sum = record1.Uno + record2.Due;
            return sum;
        }
    }
}
