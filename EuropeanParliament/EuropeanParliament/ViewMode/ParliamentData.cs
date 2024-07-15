using System.Collections.ObjectModel;

namespace EuropeanParliament
{
    public class ParliamentData
    {
      public ObservableCollection<ParliamentModel> Data {  get; set; }
        public ParliamentData()
        {
            Data = new ObservableCollection<ParliamentModel>()
            {
                new ParliamentModel("The Left",40),
                new ParliamentModel("Progressive Alliance of Socialists and Democrats",136),
                new ParliamentModel("Greens–European Free Alliance",54),
                new ParliamentModel("Renew Europe",80),
                new ParliamentModel("European People's Party Group",188),
                new ParliamentModel("European Conservatives and Reformists",82),
                new ParliamentModel("Identity and Democracy",64),
                new ParliamentModel("Non-Inscrits",76),
            };
        }
    }
}
