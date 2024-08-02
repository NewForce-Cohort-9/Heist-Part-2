// Knocking over banks isn't going to be easy. Alarms... Vaults... Security Guards.... Each of these safeguards is something we'll have to handle for a successful heist. First things first. Let's create a Bank class to represent the security we're up against. Give the Bank class the following properties:

// An integer property for CashOnHand
// An integer property for AlarmScore
// An integer property for VaultScore
// An integer property for SecurityGuardScore
// A computed boolean property called IsSecure. If all the scores are less than or equal to 0, this should be false. If any of the scores are above 0, this should be true

public class Bank
{
    public int CashOnHand { get; set; }
    public int AlarmScore { get; set; }
    public int VaultScore { get; set; }
    public int SecurityGuardScore { get; set; }
    public bool IsSecure
    {
        get
        {
            if (AlarmScore > 0 || VaultScore > 0 || SecurityGuardScore > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    // Let's do a little recon next. Print out a Recon Report to the user. This should tell the user what the bank's most secure system is, and what its least secure system is (don't print the actual integer scores--just the name, i.e. Most Secure: Alarm Least Secure: Vault
    public void Report()
    {
        Dictionary<string, int> values = new Dictionary<string, int>();
        
        values.Add("Alarm", AlarmScore);
        values.Add("Vault", VaultScore);
        values.Add("Guards", SecurityGuardScore);

        // var Scores = from score in values orderby score.Value ascending select score;
        var scores = values.OrderBy(x => x.Value);
        List<KeyValuePair<string, int>> keyValuePairs = scores.ToList();

        Console.WriteLine($"Most Secure: {keyValuePairs[2].Key}");
        Console.WriteLine($"Least Secure:{keyValuePairs[0].Key}");

    }
}