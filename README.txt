1. Reading a text file consisting of several lines, each of which contains several 
(different numbers) of real numbers.

2. Place numbers from each line on a separate stack, implemented on the basis of a singly linked list. 
The result should be a linear list (array) of such stacks.

3. Saving the current state of the stacks array to a text file with the same structure as the original one.

4. At each moment of time, one of the stacks must be the source (S), and any other - the receiver (R).

5. At the command of the user, perform one of the actions (if possible, the command 
should be executed by pressing one key):

  a. Pop a number from the source stack.
  b. Push a user-entered number onto the destination stack.
  c. Move a number from the source stack to the destination stack.
  d. Assign source or sink to another stack (one-key assignment of an adjacent stack must be supported)

6. Display of the current state of the stack array on the screen with markings on the 
source and destination. There should be a case when the number of stacks is too large and 
scrolling through the stacks array should be implemented.