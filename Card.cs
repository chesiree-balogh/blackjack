namespace blackjack
{
  public class Card
  {
    //properties
    //rank
    public string Rank { get; set; }
    //suit
    public string Suit { get; set; }

    //color
    public string ColorOfTheCard { get; set; }



    //method
    //value
    public string DisplayCards()
    {
      return $"{Rank} of {Suit}";
    }

    public int GetCardValue()
    {
      if (Rank == "ace")
      {
        return 11;
      }
      else if (Rank == "queen" || Rank == "king" || Rank == "jack")
      {
        return 10;
      }
      else
      {
        return int.Parse(Rank);
      }
    }
  }

}