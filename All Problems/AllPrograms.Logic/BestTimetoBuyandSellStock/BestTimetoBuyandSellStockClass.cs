namespace BestTimetoBuyandSellStock
{
    public class BestTimetoBuyandSellStockClass
    {
        public static int MaxProfitMethod1(int[] prices)
        {
            int amount = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                int min = prices[i];
                int max = int.MinValue;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] > max)
                    {
                        max = prices[j];
                    }
                }
                if (max != int.MinValue)
                {
                    int profit = max - min;
                    if (profit > amount)
                    {
                        amount = profit;
                    }
                }
            }
            return amount;
        }
        public static int MaxProfitMethod2(int[] prices)
        {
            int maxProfit = 0;
            int min = int.MaxValue;
            foreach (int price in prices)
            {
                if (price < min)
                {
                    min = price;
                }
                else if (price - min > maxProfit)
                {
                    maxProfit = price - min;
                }
            }
            return maxProfit;
        }
    }
}
