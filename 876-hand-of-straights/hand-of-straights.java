class Solution {
    public boolean isNStraightHand(int[] hand, int groupSize) {
        if(hand.length%groupSize!=0) return false;

        HashMap<Integer, Integer> deckOfCards = new HashMap<>();
        for(int num:hand)
        {
            deckOfCards.put(num, deckOfCards.getOrDefault(num, 0)+1);
        }
        for(int card:hand)
        {
            int start = card;
            while(deckOfCards.getOrDefault(start-1, 0)>0)
            {
                start--;
            }
            while(start<=card)
            {
                while(deckOfCards.get(start)>0)
                {
                    for(int currCard = start; currCard < start+groupSize; currCard++)
                    {
                        if(deckOfCards.getOrDefault(currCard, 0) == 0)
                        {
                            return false;
                        }
                        deckOfCards.put(currCard, deckOfCards.get(currCard)-1);
                    }
                }
                start++;
            }
        }
        return true;
    }
}