Zombie Survivor Kata
====================
Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

# Instructions #

This kata constructs a model for a zombie boardgame's survivors. If you enjoy the kata, you may find the Zombicide series of boardgames fun as well. Complete each step before reading ahead to the next one. Revise your design to react to new requirements as they appear.

## Step One: Survivors

The zombie apocalypse has occurred. You must model a Survivor in this harsh world. Sometimes, they get hurt, and even die.

- Each **Survivor** has a **Name**.
- Each Survivor begins with 0 **Wounds**.
- A Survivor who receives 2 Wounds dies immediately; additional Wounds are ignored.
- Each Survivor starts with the ability to perform 3 Actions per turn.

## Step Two : Equipment

Survivors can use equipment to help them in their mission.

- Each Survivor can carry up to 5 pieces of **Equipment**. 
	- Up to 2 pieces of carried Equipment are "In Hand"; the rest are "In Reserve".
	- Examples of Equipment: "Baseball bat", "Frying pan", "Katana", "Pistol", "Bottled Water", "Molotov"
- Each Wound a Survivor receives reduces the number of pieces of Equipment they can carry by 1.
	- If the Survivor has more Equipment than their new capacity, choose a piece to discard (implement however you like).

## Step Three : The Game

A Game includes one or more Survivors, as well as other Game elements that are outside the scope of this kata.

- A **Game** begins with 0 Survivors.
- A Game can have Survivors added to it at any time.
	- Survivor Names within a Game must be unique.
- A Game ends immediately if all of its Survivors have died.

## Step Four : Experience and Levels

As Survivors overcome zombies, they gain experience.

- Each Survivor begins with 0 **Experience**.
- Each Survivor has a current **Level**.
- Each Survivor begins at Level Blue.
- Each time the Survivor kills a zombie, they can 1 Experience.
- Levels consist of (in order): Blue, Yellow, Orange, Red.
	- When a Survivor exceeds 6 Experience, they advance ("level up") to level Yellow.
	- When a Survivor exceeds 18 Experience, they advance to level Orange.
	- When a Survivor exceeds 42 Experience, they advance to level Red.
- A Game has a Level (Level here is identical to Level for a Survivor).
- A Game begins at Level Blue.
- A Game Level is always equal to the level of the highest living Survivor's Level.

## Step Five : Output

The Game includes a running history of events that have taken place as it has been played. Managing game history is a Game responsibility.

- A Game's **History** begins by recording the time the Game began.
- A Game's History notes that a Survivor has been added to the Game.
- A Game's History notes that a Survivor acquires a piece of Equipment.
- A Game's History notes that a Survivor is wounded.
- A Game's History notes that a Survivor dies.
- A Game's History notes that a Survivor levels up.
- A Game's History notes that the Game Level changes.
- A Game's History notes that the Game has ended when the last Survivor dies.

## Step Six : Advancement

As the Game proceeds, Survivors get better.

- A set of potential **Skills** and the Levels where they are unlocked is called a **Skill Tree**.
- Each Survivor begins with a Skill Tree.
	- A Skill Tree consists of *potential* skills and *unlocked* skills.
	- A Skill Tree begins with 1 *potential* skill at level Yellow, 2 at Orange, and 3 at Red.
	- All Skill Trees have the same Yellow skill: "+1 Action".
	- Each Survivor can have a Skill Tree unique to themselves.
- When a Survivor first advances to a particular level they may unlock one available skill from that level.
	- At level Yellow, only the "+1 Action" skill should ever be available, so it will be unlocked.
- A Survivor who has "+1 Action" should have one additional Action (a total of 4).
- Additional Skills: "+1 Die (Ranged)", "+1 Die (Melee)", "+1 Free Move Action", "Hoard", "Sniper", "Tough".
	- A Survivor who has unlocked the "Hoard" skill can carry one additional piece of Equipment.
- When a Survivor advanced beyond 43 experience, they remain Level Red but restart through the skill tree a second time.
	- Upon reaching Yellow again (43 + 7 = 50 total), no more potential skills are available.
	- Upon reaching Orange again (43 + 18 = 61 total), a second Orange skills is unlocked.
	- Upon reaching Red again (43 + 43 = 86 total), a second Red skill is unlocked.
- A Survivor can restart a second time, unlocking their last Red skill at (43 + 43 + 43 = 129 total) experience.
- The Game History notes that a Survivor has acquired a new Skill.

## Notes

How did you model interaction between the Survivors and the Game? Do Survivors have direct access to the Game in which they are playing? If so, can code in a Survivor's methods directly modify the state of other Survivors in the same game? Is that a potential problem?

How did you model the Game History? Did you make sure to keep the responsibility for tracking history a concern of the Game, and not of individual Survivors?