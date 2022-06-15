# Collection Default Item Kata

Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

## Instructions

You've been asked to support photo albums as part of an app you're working on. For the purposes of this exercise you can model a particular Photo as just a unique URI representing the image file. A photo album must have at least one photo in it, and it will have a cover photo (one of the photos in the album) that is rendered when the album is displayed (or printed by a print service, etc.).

## Part 1

Design and test one or more ways to support this functionality. Be sure to consider functionality like creating albums, adding photos, removing photos, and choosing which photo is the cover photo for a given album.

## Questions to consider

- Does your design allow for the modeling of inconsistent/invalid states (0 cover photos, more than 1 cover photo)? How would you mitigate these?
- What happens (or do you think should happen) when a photo that is the cover photo is removed from the album?
- How do you handle selecting a new photo to be the cover photo?
- How do you avoid the possibility of having a photo album with no photos in it?

## Part 2

- Abstract your implementation so it works with any type.
- For example, instead of photo albums and cover photo, you have customer Addresses and a default address.
- Leverage generics or another approach to make your design and its constraints easily reusable.
