

namespace EuropeanParliament
{
    public class ParliamentModel
    {
        public string PollingAggregations { get; set; }
        public double PollingCount { get; set; }

        public ParliamentModel(string pollingAggregations, double pollingCount)
        {
            PollingAggregations = pollingAggregations;
            PollingCount = pollingCount;
        }
    }
}