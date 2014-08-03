Red Pencil Sale Kata
============
Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

# Background #

This kata is meant to mimic a "real world" feature request. The customer's current application provides a shopping portal where dealers can offer their goods (similar to Amazon's marketplace). They want to support "red pencil" promotions/sales. During such a sale, the old price is shown crossed out in red (hence "red pencil") and the new reduced price is written next to it. However, it's important that these sales are managed correctly, so that they do not overlap (resulting in double-markdowns), and that they respond correctly if the item in question's price changes (if the price goes up, the red pencil sale must end).

# Instructions #

The scope of this kata is the implementation of the rules for activating and deactivating red pencil promotions. Write your code to ensure the following:

- A red pencil promotion starts due to a price reduction. However, the red pencil promotion is only applied if the price was reduced by at least 5% and at most 30%. Also, the previous price must have been stable (unchanged) for at least 30 days.
- A red pencil promotion lasts at most 30 days.
- If the price of an item is further reduced during the red pencil promotion, the promotion will not be prolonged by that reduction.
- If the price of an item is increased during the red pencil promotion, the promotion ends immediately.
- If the price is reduced during the red pencil promotion so that the overall reduction is more than 30% with regard to the original price, the promotion ends immediately.
- After a red pencil promotion has ended, additional red pencil promotions may follow. However, the start condition remains: the price must have been stable for 30 days (and these 30 days cannot intersect with a previous red pencil promotion).

# Resources #
- [Original version by Stefan Roock](http://stefanroock.wordpress.com/2011/03/04/red-pencil-code-kata/)