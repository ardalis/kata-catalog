ISBN - International Standard Book Number
=========================================

There are two ISBN standards: ISBN-10 and ISBN-13. Support for ISBN-13 is essential, whereas support for ISBN-10 is optional.

Here are some valid examples of each:

```text
ISBN-13:    9780470059029
            978 0 471 48648 0
            978-0596809485
            978-0-13-149505-0
            978-0-262-13472-9

ISBN-10:    0471958697
            0 471 60695 2
            0-470-84525-2
            0-321-14653-0
```

ISBN-10 is made up of 9 digits plus a check digit (which may be 'X') and ISBN-13 is made up of 12 digits plus a check digit. Spaces and hyphens may be included in a code, but are not significant. This means that 9780471486480 is equivalent to 978-0-471-48648-0 and 978 0 471 48648 0.

The check digit for ISBN-13 is calculated by multiplying each digit alternately by 1 or 3 (i.e., 1 x 1st digit, 3 x 2nd digit, 1 x 3rd digit, 3 x 4th digit, etc.), summing these products together, taking modulo 10 of the result and then subtracting this value from 10.

## Basic Task - ISBN-13

Create a function that takes a string and returns true if the string is a valid ISBN-13 and false otherwise.

## Advanced Task - ISBN-10

The check digit for ISBN-10 is calculated by multiplying each digit by its position (i.e., 1 x 1st digit, 2 x 2nd digit, etc.), summing these products together and taking modulo 11 of the result (with 'X' being used if the result is 10).

Update the original function to also return true if the string is a valid ISBN-10.

[Source - cyber-dojo.org](https://cyber-dojo.org)
