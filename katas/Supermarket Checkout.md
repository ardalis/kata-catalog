# Supermarket Checkout Kata

Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

## Background

You've probably been to a supermarket or grocery store and gone through the checkout process. Different items you're purchasing may have simple prices, like one can of soup is $1. But there may be ongoing or temporary sale prices as well, often based on buying more than one item. For example, cans of soup may also have a "buy 2, get the third one free" pricing option. Other items might be priced by weight, like $1.99 per pound (or kilogram), in which case a scale at checkout would be used to calculate the ounces (or grams), which would then be used to calculate the price.

Another thing to keep in mind is what you as the purchaser see as you scan each item. Consider cans of soup: $1 each, but buy 2 and you get a 3rd one free. When you scan one can of soup, you would expect to see some output indicating the price of $1.00. When you scan a second can, you would see the same. But upon scanning the third can, you should see that it's $0.00 because of the special pricing rule.

## Instructions

- Create a class `Checkout` that has a public `Scan` method
- The `Scan` method accepts a string Stock Keeping Unit (SKU) and defaults to a quantity of one.
- An overload of the `Scan` method can accept an integer quantity
- Another overload of the `Scan` method can accept a `float` or `decimal` weight
- Each `Scan` should return a string for display to the customer that includes the item SKU, its quantity, and the incremental price associated with that scan
- Implement the scanning functionality for the following set of products and pricing rules

| SKU    | Unit Price | Volume Pricing Rule |
|--------|-----------:|---------------------|
| SOUP   |      $1.00 | Buy 2, Get 1 Free   |
| RAMEN  |      $0.40 | 3 for $1.00         |
| ORANGE |      $2.00 |                     |
| GRAPES | $4 / pound |                     |
| YOGURT | n/a        | 3 for $2.00         |

## Notes

- Some items have more than one price rule (unit vs. volume); others have only one
- YOGURT should round up the first 2 bought ($0.67 each) but then the third one should be $0.66 so that the price for 3 is $2.00
- The order in which items are scanned should not impact the final price
- Do not assume like items are scanned as a group or even in sequence

## Extra Credit

- Add a method, `GenerateReceipt`, that provides a receipt for all of the items purchased
- The receipt **should** group like items together to make it clear where volume pricing rules have been applied
- Add another few items and pricing rules to your implementation. Note what code you needed to change

## Reflect on Your Solution

The goal of this kata is first: to practice writing code to solve a problem. Secondly, it should provide practice for writing unit tests, whether you choose to write the tests first (TDD) or not. And third, you should assess your code to see how well it follows principles like [Separation of Concerns](https://deviq.com/principles/separation-of-concerns) and [SOLID](https://deviq.com/principles/solid). Ask yourself these questions about your solution:

- Do you need to change the Checkout class or Scan method to add a new SKU?
- Do you need to change the Checkout class or Scan method to add or modify a pricing rule? What about to support an entirely new kind of pricing rule?
- How would you change your design to decouple these from one another (if needed)?

## Resources

- [Original version](http://codekata.com/kata/kata09-back-to-the-checkout/)
