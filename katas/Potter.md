Potter Kata
============
Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

# Instructions #

Imagine a bookstore that is selling the seven books from the Harry Potter series. Each book has a standard price of $8.00. However, if you buy more than one of the series at a time, you get a discount. Buying multiple copies of the same book title does not earn a discount.

<table>
<tr>
<th>Number of Different Book Titles</th>
<th>Discount Percentage</th>
</tr>
<tr><td>2</td><td>5%</td></tr>
<tr><td>3</td><td>10%</td></tr>
<tr><td>4</td><td>15%</td></tr>
<tr><td>5</td><td>25%</td></tr>
<tr><td>6</td><td>30%</td></tr>
<tr><td>7</td><td>35%</td></tr>
</table>

Write a method that will calculate the **optimal** customer discount for any set of books from this series. Keep in mind that larger percentages are not always better as can be seen in the sample below, in which case it was better to keep all the books at 75% discount instead of having some at 70% and others at 85% of retail.

## Sample Selection ##

- 1 copy of Book One
- 2 copies of Book Two
- 2 copies of Book Three
- 2 copies of Book Four
- 2 copies of Book Five
- 1 copy of Book Six

## Result and Analysis ##

In this case 1 each of books one through five make a set of 5 unique books eligible for 25% off, and one each of books two through six make a similar set, resulting in 10 books at 25% off of $8 (10 * $8 * .75) = $60.  If the algorithm had "greedily" used all six unique books to get a 30% discount, the remaining 4 books (Two, Three, Four, Five) would only have been eligible for a 15% discount.  The cost would thus have been (6 * $8 * .7) = $33.60 + (4 * $8 * .85) = $27.20 for a total of $60.80.