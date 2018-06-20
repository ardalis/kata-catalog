Monty Hall
==========
Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

# Background #

The [Monty Hall Problem](https://www.montyhallproblem.com/) is based on a game show hosted by Monty Hall in which a contestant picks one of three doors, behind one of which is a prize. The host then reveals that one of the doors not selected is the wrong choice (holds a *goat* not a prize). The host then offers the contestant the chance to switch their choice from the door they originally chose, to the other remaining door.

**Should the contestant switch?**

# Instructions #

Write a program that demonstrates whether there is a benefit in switching when presented with the choice given above. Your program should start with 3 doors and should store which door holds the prize. It should then select one of the doors (either automatically or via user input), at which point one of the remaining non-winning doors should be revealed to not hold the prize. At this point, either **stay** or **switch** (automatically or through user input).

Track the win percentage of each strategy (staying vs. switching). Iterate the game 1000 times to see how the two percentages compare.

## Extra Credit ##

Instead of 3 doors, consider a larger set of options, such as a deck of 52 cards. The contestant is seeking a particular card (let's say Ace of Spaces). They choose one card at random from a full deck of 52 playing cards. The host then reveals all but one of the remaining cards showing that they are **not** the Ace of Spades. The contestant then has the same choice: **stay** with their originally selected card or **switch** to the last card remaining in the deck held by the host.

Track the win percentage of each strategy in this scenario.

# Resources #
- [Monty Hall Problem on Wikipedia](https://en.wikipedia.org/wiki/Monty_Hall_problem)
