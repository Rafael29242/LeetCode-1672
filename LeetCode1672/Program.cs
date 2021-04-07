using System;

namespace LeetCode1672
{
    class Program
    {
        public int MaximumWealth(int [][] accounts)
        {



            int wealthiest = 0;

            for (int cust = 0; cust < accounts.Length; cust++)// cust is customer
            {
                int Wealthsum = 0;

                for (int banks = 0; banks < accounts[cust].Length; banks++)
                {
                    Wealthsum += accounts[cust][banks];
                }

                wealthiest = Math.Max(wealthiest, Wealthsum);

                //if(Wealthsum > wealthiest)
                //{
                //    wealthiest = Wealthsum;
                //}
                    
            }
                return wealthiest;


        }
    }
}
