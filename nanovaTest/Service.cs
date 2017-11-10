using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanovaTest
{
    public class Service
    {
        //Change Threshold by time
        public double ChangeThresholdByTime(int index, double retentionTimeThreshold)
        {
            if (index < 400)
            {
                retentionTimeThreshold = 2;
            }
            else if (400 <= index && index < 1000)
            {
                retentionTimeThreshold = index * 0.005;
            }
            else
            {
                retentionTimeThreshold = 5;
            }
            return retentionTimeThreshold;
        }
    }
}
