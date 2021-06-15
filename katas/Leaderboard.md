# Leader Board Kata

Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

## Background

You're writing software that needs to display players on a leader board. Each row of the leader board needs to include the player's overall rank, their name, and their score. For this exercise, higher scores are better, so the player with the highest score should be in the first position on the leader board (which should have a rank of 1 - this not a 0-based leader board).

## Instructions

Create a service with a method that accepts a list of players with their respective scores and produces the data needed for a leader board, including all three of the above elements (rank, name, score). For this step, assume no two players have the same score (all scores are unique).

Test that the basic behavior is correct when there are no duplicate scores.

When duplicate scores exist, which is not uncommon, a tie occurs. When players are tied for a rank, each player will be given the same rank as they would have had if their score had been unique. However, the next player in rank after all tied players will have a rank based on the number of players above them, not the player immediately above them's rank. For example, given the following scores:

| Player Name | Score |
|-------------|-------|
| Ardalis     | 10    |
| Bob         | 8     |
| Chrissy     | 8     |
| Doris       | 7     |

The player ranks, in this case, would be: 1,2,2,4.

When a tie exists and multiple players have the same rank, players should be listed in Player Name order, ascending.

Write tests to ensure your leader board service works correctly given duplicate score values.

## Extra Credit

Sometimes lower scores are better (such as in golf or race completion times). Configure your service so that it will work correctly so that, when given a set of scores, they are ranked based on lowest-to-highest score. Test that your service works correctly in this configuration. Note that player name sorting (in the case of ties) should not change.

Ensure your service works with arbitrary types of score data, provided it is comparable (`IComparable<T>` interface in .NET, or similar in other languages).

## Design Review

How do you represent players, scores, and player-score combinations in your design?

How do you represent the result of the rank calculation?

How easily would your design work in different user interfaces (console, web, mobile, etc.)?

How difficult was it to configure your algorithm to support lowest-to-highest scoring? How much duplicate code, if any, is there in your final solution?

## Flexibility

How would you modify your solution to work for any given data type? Instead of players and games what if you're calculating book sales rankings? Can you design your solution such that its operations are configurable, or leverage a design pattern like Adapter to provide a way for it to work with arbitrary existing data structures?
